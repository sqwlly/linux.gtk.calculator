
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox6;

	private global::Gtk.VBox vbox8;

	private global::Gtk.TextView textview1;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Button buttonClear;

	private global::Gtk.Button buttonDel;

	private global::Gtk.HBox hbox6;

	private global::Gtk.Table table6;

	private global::Gtk.Button button1;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

	private global::Gtk.Button button4;

	private global::Gtk.Button button5;

	private global::Gtk.Button button6;

	private global::Gtk.Button button7;

	private global::Gtk.Button button8;

	private global::Gtk.Button button9;

	private global::Gtk.VBox vbox7;

	private global::Gtk.Button buttonMul;

	private global::Gtk.Button buttonDiv;

	private global::Gtk.Button buttonSub;

	private global::Gtk.HBox hbox9;

	private global::Gtk.HBox hbox10;

	private global::Gtk.Button button;

	private global::Gtk.Button buttonDot;

	private global::Gtk.Button button11;

	private global::Gtk.Button buttonPlus;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.CursorVisible = false;
		this.textview1.Justification = ((global::Gtk.Justification)(1));
		this.vbox8.Add(this.textview1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.textview1]));
		w1.Position = 0;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.buttonClear = new global::Gtk.Button();
		this.buttonClear.WidthRequest = 185;
		this.buttonClear.HeightRequest = 50;
		this.buttonClear.CanFocus = true;
		this.buttonClear.Name = "buttonClear";
		this.buttonClear.UseUnderline = true;
		this.buttonClear.Label = global::Mono.Unix.Catalog.GetString("AC");
		this.hbox8.Add(this.buttonClear);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonClear]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.buttonDel = new global::Gtk.Button();
		this.buttonDel.WidthRequest = 185;
		this.buttonDel.CanFocus = true;
		this.buttonDel.Name = "buttonDel";
		this.buttonDel.UseUnderline = true;
		this.buttonDel.Label = global::Mono.Unix.Catalog.GetString("DEL");
		this.hbox8.Add(this.buttonDel);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonDel]));
		w3.PackType = ((global::Gtk.PackType)(1));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox8.Add(this.hbox8);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox8]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox6.Add(this.vbox8);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.vbox8]));
		w5.Position = 0;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.table6 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
		this.table6.Name = "table6";
		this.table6.RowSpacing = ((uint)(6));
		this.table6.ColumnSpacing = ((uint)(6));
		// Container child table6.Gtk.Table+TableChild
		this.button1 = new global::Gtk.Button();
		this.button1.WidthRequest = 105;
		this.button1.HeightRequest = 50;
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("1");
		this.table6.Add(this.button1);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table6[this.button1]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button2 = new global::Gtk.Button();
		this.button2.WidthRequest = 105;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("2");
		this.table6.Add(this.button2);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table6[this.button2]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button3 = new global::Gtk.Button();
		this.button3.WidthRequest = 105;
		this.button3.HeightRequest = 50;
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("3");
		this.table6.Add(this.button3);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table6[this.button3]));
		w8.TopAttach = ((uint)(2));
		w8.BottomAttach = ((uint)(3));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button4 = new global::Gtk.Button();
		this.button4.WidthRequest = 105;
		this.button4.HeightRequest = 50;
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("4");
		this.table6.Add(this.button4);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table6[this.button4]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button5 = new global::Gtk.Button();
		this.button5.WidthRequest = 105;
		this.button5.HeightRequest = 50;
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString("5");
		this.table6.Add(this.button5);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table6[this.button5]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button6 = new global::Gtk.Button();
		this.button6.WidthRequest = 105;
		this.button6.HeightRequest = 50;
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString("6");
		this.table6.Add(this.button6);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table6[this.button6]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(2));
		w11.RightAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button7 = new global::Gtk.Button();
		this.button7.HeightRequest = 50;
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString("7");
		this.table6.Add(this.button7);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table6[this.button7]));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button8 = new global::Gtk.Button();
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString("8");
		this.table6.Add(this.button8);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table6[this.button8]));
		w13.LeftAttach = ((uint)(1));
		w13.RightAttach = ((uint)(2));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button9 = new global::Gtk.Button();
		this.button9.WidthRequest = 105;
		this.button9.HeightRequest = 50;
		this.button9.CanFocus = true;
		this.button9.Name = "button9";
		this.button9.UseUnderline = true;
		this.button9.Label = global::Mono.Unix.Catalog.GetString("9");
		this.table6.Add(this.button9);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table6[this.button9]));
		w14.LeftAttach = ((uint)(2));
		w14.RightAttach = ((uint)(3));
		w14.XOptions = ((global::Gtk.AttachOptions)(4));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox6.Add(this.table6);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.table6]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.WidthRequest = 50;
		this.vbox7.HeightRequest = 50;
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.buttonMul = new global::Gtk.Button();
		this.buttonMul.WidthRequest = 50;
		this.buttonMul.HeightRequest = 50;
		this.buttonMul.CanFocus = true;
		this.buttonMul.Name = "buttonMul";
		this.buttonMul.UseUnderline = true;
		this.buttonMul.Label = global::Mono.Unix.Catalog.GetString("*");
		this.vbox7.Add(this.buttonMul);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.buttonMul]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.buttonDiv = new global::Gtk.Button();
		this.buttonDiv.WidthRequest = 50;
		this.buttonDiv.HeightRequest = 50;
		this.buttonDiv.CanFocus = true;
		this.buttonDiv.Name = "buttonDiv";
		this.buttonDiv.UseUnderline = true;
		this.buttonDiv.Label = global::Mono.Unix.Catalog.GetString("/");
		this.vbox7.Add(this.buttonDiv);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.buttonDiv]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.buttonSub = new global::Gtk.Button();
		this.buttonSub.WidthRequest = 50;
		this.buttonSub.HeightRequest = 50;
		this.buttonSub.CanFocus = true;
		this.buttonSub.Name = "buttonSub";
		this.buttonSub.UseUnderline = true;
		this.buttonSub.Label = global::Mono.Unix.Catalog.GetString("-");
		this.vbox7.Add(this.buttonSub);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.buttonSub]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		this.hbox6.Add(this.vbox7);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.vbox7]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		this.vbox6.Add(this.hbox6);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox6]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.button = new global::Gtk.Button();
		this.button.WidthRequest = 105;
		this.button.HeightRequest = 50;
		this.button.CanFocus = true;
		this.button.Name = "button";
		this.button.UseUnderline = true;
		this.button.Label = global::Mono.Unix.Catalog.GetString("0");
		this.hbox10.Add(this.button);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.button]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.buttonDot = new global::Gtk.Button();
		this.buttonDot.WidthRequest = 105;
		this.buttonDot.HeightRequest = 50;
		this.buttonDot.CanFocus = true;
		this.buttonDot.Name = "buttonDot";
		this.buttonDot.UseUnderline = true;
		this.buttonDot.Label = global::Mono.Unix.Catalog.GetString(".");
		this.hbox10.Add(this.buttonDot);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.buttonDot]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.button11 = new global::Gtk.Button();
		this.button11.WidthRequest = 105;
		this.button11.HeightRequest = 0;
		this.button11.CanFocus = true;
		this.button11.Name = "button11";
		this.button11.UseUnderline = true;
		this.button11.Label = global::Mono.Unix.Catalog.GetString("=");
		this.hbox10.Add(this.button11);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.button11]));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		this.hbox9.Add(this.hbox10);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.hbox10]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.buttonPlus = new global::Gtk.Button();
		this.buttonPlus.WidthRequest = 50;
		this.buttonPlus.HeightRequest = 50;
		this.buttonPlus.CanFocus = true;
		this.buttonPlus.Name = "buttonPlus";
		this.buttonPlus.UseUnderline = true;
		this.buttonPlus.Label = global::Mono.Unix.Catalog.GetString("+");
		this.hbox9.Add(this.buttonPlus);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.buttonPlus]));
		w25.Position = 1;
		w25.Expand = false;
		w25.Fill = false;
		this.vbox6.Add(this.hbox9);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox9]));
		w26.Position = 2;
		w26.Expand = false;
		w26.Fill = false;
		this.Add(this.vbox6);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 383;
		this.DefaultHeight = 413;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.buttonClear.Clicked += new global::System.EventHandler(this.OnButtonClearClicked);
		this.buttonDel.Clicked += new global::System.EventHandler(this.OnButtonDelClicked);
		this.button9.Clicked += new global::System.EventHandler(this.OnButton9Clicked);
		this.button8.Clicked += new global::System.EventHandler(this.OnButton8Clicked);
		this.button7.Clicked += new global::System.EventHandler(this.OnButton7Clicked);
		this.button6.Clicked += new global::System.EventHandler(this.OnButton6Clicked);
		this.button5.Clicked += new global::System.EventHandler(this.OnButton5Clicked);
		this.button4.Clicked += new global::System.EventHandler(this.OnButton4Clicked);
		this.button3.Clicked += new global::System.EventHandler(this.OnButton3Clicked);
		this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		this.buttonMul.Clicked += new global::System.EventHandler(this.OnButtonMulClicked);
		this.buttonDiv.Clicked += new global::System.EventHandler(this.OnButtonDivClicked);
		this.buttonSub.Clicked += new global::System.EventHandler(this.OnButtonSubClicked);
		this.button.Clicked += new global::System.EventHandler(this.OnButtonClicked);
		this.buttonDot.Clicked += new global::System.EventHandler(this.OnButtonDotClicked);
		this.button11.Clicked += new global::System.EventHandler(this.OnButton11Clicked);
		this.buttonPlus.Clicked += new global::System.EventHandler(this.OnButtonPlusClicked);
	}
}