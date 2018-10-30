using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    /* 模拟数字栈 */
    double[] num = new double[20];
    /* 模拟操作符栈 */
    char[] op = new char[20];
    int top_num = 1, top_op = 1;

    /* 根据操作符来计算 */
    protected void calculate(char _operator)
    {
        double a = 0;
        double b = 0;
        if (top_num > 2)
            b = num[--top_num];
        if (top_num > 1)
            a = num[--top_num];
        double c = 0;
        switch (_operator)
        {
            case '+': c = a + b; break;
            case '-': c = a - b; break;
            case '*': c = a * b; break;
            case '/': if (b - 0 < 1e-15) { textview1.Buffer.Text = "除数不能0!"; return; } else c = a / b; break;
            default: textview1.Buffer.Text = "error"; break;
        }
        num[top_num++] = c;
    }

    protected bool priority(char a,char b)
    {
        if ((a == '*' || a == '/') && (b == '+' || b == '-')) return true; 
        return false;
    }

    /* @program       中缀表达式计算
    *  @description   利用栈的特性来完成，支持简单浮点数计算
    */
    protected void solve()
    {                                            // 3 * 2 = 6 
        string express = textview1.Buffer.Text;  // + - 
        top_num = 1; top_op = 1;
        int isMinus = 1;
        for (int i = 0; i < express.Length;)
        {
            if (i == 0 && express[i] == '-')
            {
                isMinus = -1;
                i++;
                continue;
            }
            //是数字就直接压进数字栈
            if (char.IsDigit(express[i]))
            {
                double t = 0;
                //整数部分的处理
                while (i < express.Length && char.IsDigit(express[i]))
                {
                    t = t * 10 + express[i++] - '0';
                }
                double decimals = 0; int digit = 0;
                //小数部分的处理
                if (i < express.Length && express[i] == '.')
                {
                    i++;
                    while (i < express.Length && char.IsDigit(express[i]))
                    {
                        digit++;
                        decimals = decimals * 10 + express[i++] - '0';
                    }
                    decimals /= Math.Pow(10, digit);
                }
                num[top_num++] = (t + decimals) * isMinus;
                if (isMinus == -1) isMinus = 1;
                continue;
            }
            //当前操作符优先级高于栈顶的操作符就将其压进操作符栈
            if (priority(express[i], op[top_op - 1]) || top_op == 1)
            {
                op[top_op++] = express[i++];
            }
            else //否则就从数字栈弹出两个数，操作符弹出一个操作符进行计算直至当前操作符优先级比栈顶高或者栈空
            {
                if (top_op > 1)
                {
                    while (top_op > 1 && top_num > 2 && !priority(express[i], op[top_op - 1]))
                        calculate(op[--top_op]);
                }
                op[top_op++] = express[i++];
            }
        }
        //处理表达式结束，开始计算剩余
        while (top_op > 1 && top_num > 2)
        {
            calculate(op[--top_op]);
        }
        //最后数字栈中剩余的一个数就是答案
        if (top_num == 2)
            textview1.Buffer.Text = num[top_num - 1].ToString();
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "1";
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "2";
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "3";
    }

    protected void OnButton4Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "4";
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "5";
    }

    protected void OnButton6Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "6";
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "7";
    }

    protected void OnButton8Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "8";
    }

    protected void OnButton9Clicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "9";
    }

    protected void OnButtonClicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text += "0";
    }

    protected void OnButtonPlusClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "") return;　　
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = t + "+";
    }

    protected void OnButtonSubClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t != "" &&!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = t + "-";
    }

    protected void OnButtonDivClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "") return;
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = t + "/";
    }

    protected void OnButtonMulClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "") return;
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = t + "*";
    }

    protected void OnButtonDotClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "") return;
        if (char.IsDigit(t[t.Length - 1]))
            textview1.Buffer.Text += ".";
    }

    protected void OnButton11Clicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (char.IsDigit(t[t.Length - 1]))
            solve();
    }

    protected void OnButtonDelClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "") return;
        t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = t;
    }

    protected void OnButtonClearClicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text = "";
    }
}
