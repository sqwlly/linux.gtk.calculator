﻿using System;
using System.Collections;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        MyDelegate();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    void MyDelegate()
    {
        button9.Clicked += FirstClcik;
        button8.Clicked += FirstClcik;
        button7.Clicked += FirstClcik;
        button6.Clicked += FirstClcik;
        button5.Clicked += FirstClcik;
        button4.Clicked += FirstClcik;
        button3.Clicked += FirstClcik;
        button2.Clicked += FirstClcik;
        button1.Clicked += FirstClcik;
        button.Clicked += FirstClcik;
        textview1.SizeAllocated += ScrollToEnd;
        var endIter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref endIter, "0", getTag(15));
    }

    /* 模拟数字栈 */
    double[] num = new double[20];
    /* 模拟操作符栈 */
    char[] op = new char[20];
    int top_num = 1, top_op = 1;
    Stack Stack = new Stack();
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

    //判断操作符优先级
    protected bool priority(char a,char b)
    {
        if ((a == '*' || a == '/') && (b == '+' || b == '-')) return true; 
        return false;
    }

    //字体渲染
    protected TextTag getTag(int num)
    {
        var tag = new TextTag(null);
        textview1.Buffer.TagTable.Add(tag);
        tag.Weight = Pango.Weight.Light;
        tag.Family = "monaco"; //喜欢这个字体
        tag.Foreground = "gray";
        tag.Size = (int)Pango.Scale.PangoScale * num;
        return tag;
    }

    /* @program       中缀表达式计算
    *  @description   利用栈的特性来完成，支持简单浮点数计算
    */
    protected void solve()
    {
        TextBuffer str = textview1.Buffer;

        //获取最后一行
        string express = textview1.Buffer.GetText(textview1.Buffer.GetIterAtLine(str.LineCount), str.EndIter, false);

        /*int idx = textview1.Buffer.Text.Substring(0,textview1.Buffer.Text.Length - 1).LastIndexOf('\n');
        if (idx == -1) idx = 0;
        string express = textview1.Buffer.Text.Substring(idx);
        if (express[0] == '\n') express = express.Substring(1); //满足第一个字符可以是负号 */

        top_num = 2; top_op = 1;
        num[1] = 0;
        for (int i = 0; i < express.Length;)
        {
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
                num[top_num++] = t + decimals;　//入数字栈
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
        var iter1 = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter1, "\n", getTag(1));　//从末尾插入换行
        var iter = textview1.Buffer.GetIterAtLine(textview1.Buffer.LineCount); //再获取最后一行
        int maxL = num[top_num - 1].ToString().Length;
        if (maxL > 12) maxL = 12; //限制输出答案的长度
        if(top_num > 1) //数字栈中剩余的一个元素就是答案，将其插入最后一行
            textview1.Buffer.InsertWithTags(ref iter, "= "+num[top_num - 1].ToString().Substring(0,maxL)+"\n------------------\n", getTag(25));
    }

    // 实现没有前导0
    protected void FirstClcik(object sender, EventArgs e)
    {
        TextBuffer str = textview1.Buffer;
        string t = textview1.Buffer.GetText(textview1.Buffer.GetIterAtLine(str.LineCount), str.EndIter, false);
        for (int i = 0; i < 10; ++i) {
            if(t == "0" + i) {
                string tmp = textview1.Buffer.Text;
                tmp = tmp.Substring(0, tmp.Length - 2);
                textview1.Buffer.Text = "";
                var iter1 = textview1.Buffer.EndIter;
                textview1.Buffer.InsertWithTags(ref iter1, tmp, getTag(15));
                var iter = textview1.Buffer.EndIter;
                textview1.Buffer.InsertWithTags(ref iter, i+"", getTag(15));
            }
        }
    }

    //滚轮滚动到底部
    protected void ScrollToEnd(object sender, Gtk.SizeAllocatedArgs e)
    {
        textview1.ScrollToIter(textview1.Buffer.EndIter, 0, false, 0, 0);   
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "1", getTag(15));
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "2", getTag(15));
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "3", getTag(15));
    }

    protected void OnButton4Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "4", getTag(15));
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "5", getTag(15));
    }

    protected void OnButton6Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "6", getTag(15));
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "7", getTag(15));
    }

    protected void OnButton8Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "8", getTag(15));
    }

    protected void OnButton9Clicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "9", getTag(15));
    }

    protected void OnButtonClicked(object sender, EventArgs e)
    {
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "0", getTag(15));
    }

    //加号
    protected void OnButtonPlusClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "" || t[t.Length-1] == '\n' || t[t.Length - 1] == '.') return; //防止在分割线处添加
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = "";  
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, t + "+", getTag(15));
    }

    //减号
    protected void OnButtonSubClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t != "" && t[t.Length - 1] == '.') return;
        if (t == "" || t[t.Length - 1] == '\n') t += "\n";　//防止将减号添加到分割线末尾，因此要加一个回车
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = "";
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, t + "-", getTag(15));
    }

    //除号
    protected void OnButtonDivClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "" || t[t.Length-1] == '\n' || t[t.Length - 1] == '.') return; //防止在分割线处添加
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = "";
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, t + "/", getTag(15));
    }

    // 乘号
    protected void OnButtonMulClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "" || t[t.Length-1] == '\n' || t[t.Length - 1] == '.') return; //防止在分割线处添加
        if (!char.IsDigit(t[t.Length - 1]))
            t = t.Substring(0, t.Length - 1);
        textview1.Buffer.Text = "";
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, t + "*", getTag(15));
    }

    protected bool isOper(char ch)
    {
        char[] oper = { '+', '-', '*', '/', '\n'};
        for (int i = 0; i < oper.Length; ++i) {
            if (ch == oper[i]) return true;
        }
        return false;
    }

    //加点
    protected void OnButtonDotClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        bool judge = true;

        //防止多次加点，如2.2.2 
        for (int i = t.Length - 1;  i >= 0 && !isOper(t[i]); --i){
            if (t[i] == '.')
            {
                judge = false;
                break;
            }
        }

        if (t == "" || !judge) return;
        if (char.IsDigit(t[t.Length - 1]))　//只有前一个字符是数字才可以加点
        {
            var iter = textview1.Buffer.EndIter;
            textview1.Buffer.InsertWithTags(ref iter, ".", getTag(15));
        }
    }

    //等于号，开始计算
    protected void OnButton11Clicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (char.IsDigit(t[t.Length - 1]))
            solve();
    }

    //删除键
    protected void OnButtonDelClicked(object sender, EventArgs e)
    {
        string t = textview1.Buffer.Text;
        if (t == "") return;
        char[] oper = { '+', '-', '*', '/', '.'}; 
        bool judge = false;

        // 如果最后一个字符是操作符或者数字都可以删掉
        if (char.IsDigit(t[t.Length - 1])) judge = true;　
        foreach(char i in oper){
            if (i == t[t.Length - 1]) judge = true;
        }

        if (!judge) return;
        t = t.Substring(0, t.Length - 1); //删掉最后一个字符
        textview1.Buffer.Text = "";
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, t, getTag(15));
    }

    //清空键
    protected void OnButtonClearClicked(object sender, EventArgs e)
    {
        textview1.Buffer.Text = "";
        var iter = textview1.Buffer.EndIter;
        textview1.Buffer.InsertWithTags(ref iter, "0", getTag(15));
    }
}