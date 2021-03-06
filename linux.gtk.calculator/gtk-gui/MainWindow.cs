
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox6;

	private global::Gtk.VBox vbox8;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

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

	private global::Gtk.HPaned hpaned1;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.HBox hbox3;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Button buttonDiv;

	private global::Gtk.Button buttonMul;

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
		this.Title = global::Mono.Unix.Catalog.GetString("Calculator");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		this.GtkScrolledWindow.WindowPlacement = ((global::Gtk.CornerType)(3));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.WidthRequest = 380;
		this.textview1.HeightRequest = 200;
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.CursorVisible = false;
		this.textview1.Justification = ((global::Gtk.Justification)(1));
		this.textview1.LeftMargin = 15;
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox8.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.GtkScrolledWindow]));
		w2.Position = 0;
		w2.Padding = ((uint)(10));
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.buttonClear = new global::Gtk.Button();
		this.buttonClear.WidthRequest = 175;
		this.buttonClear.HeightRequest = 50;
		this.buttonClear.CanFocus = true;
		this.buttonClear.Name = "buttonClear";
		this.buttonClear.UseUnderline = true;
		this.buttonClear.Label = global::Mono.Unix.Catalog.GetString("AC");
		this.hbox8.Add(this.buttonClear);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonClear]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		w3.Padding = ((uint)(10));
		// Container child hbox8.Gtk.Box+BoxChild
		this.buttonDel = new global::Gtk.Button();
		this.buttonDel.WidthRequest = 175;
		this.buttonDel.HeightRequest = 50;
		this.buttonDel.CanFocus = true;
		this.buttonDel.Name = "buttonDel";
		this.buttonDel.UseUnderline = true;
		this.buttonDel.Label = global::Mono.Unix.Catalog.GetString("DEL");
		this.hbox8.Add(this.buttonDel);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonDel]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		w4.Padding = ((uint)(10));
		this.vbox8.Add(this.hbox8);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox8]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox6.Add(this.vbox8);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.vbox8]));
		w6.Position = 0;
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
		this.button1.WidthRequest = 75;
		this.button1.HeightRequest = 50;
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("1");
		this.table6.Add(this.button1);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table6[this.button1]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.XPadding = ((uint)(10));
		w7.YPadding = ((uint)(5));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button2 = new global::Gtk.Button();
		this.button2.WidthRequest = 75;
		this.button2.HeightRequest = 50;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("2");
		this.table6.Add(this.button2);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table6[this.button2]));
		w8.TopAttach = ((uint)(2));
		w8.BottomAttach = ((uint)(3));
		w8.LeftAttach = ((uint)(1));
		w8.RightAttach = ((uint)(2));
		w8.XPadding = ((uint)(10));
		w8.YPadding = ((uint)(5));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button3 = new global::Gtk.Button();
		this.button3.WidthRequest = 75;
		this.button3.HeightRequest = 50;
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("3");
		this.table6.Add(this.button3);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table6[this.button3]));
		w9.TopAttach = ((uint)(2));
		w9.BottomAttach = ((uint)(3));
		w9.LeftAttach = ((uint)(2));
		w9.RightAttach = ((uint)(3));
		w9.XPadding = ((uint)(10));
		w9.YPadding = ((uint)(5));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button4 = new global::Gtk.Button();
		this.button4.WidthRequest = 75;
		this.button4.HeightRequest = 50;
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("4");
		this.table6.Add(this.button4);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table6[this.button4]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.XPadding = ((uint)(10));
		w10.YPadding = ((uint)(5));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button5 = new global::Gtk.Button();
		this.button5.WidthRequest = 75;
		this.button5.HeightRequest = 50;
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString("5");
		this.table6.Add(this.button5);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table6[this.button5]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.XPadding = ((uint)(10));
		w11.YPadding = ((uint)(4));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button6 = new global::Gtk.Button();
		this.button6.WidthRequest = 75;
		this.button6.HeightRequest = 50;
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString("6");
		this.table6.Add(this.button6);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table6[this.button6]));
		w12.TopAttach = ((uint)(1));
		w12.BottomAttach = ((uint)(2));
		w12.LeftAttach = ((uint)(2));
		w12.RightAttach = ((uint)(3));
		w12.XPadding = ((uint)(10));
		w12.YPadding = ((uint)(5));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button7 = new global::Gtk.Button();
		this.button7.WidthRequest = 75;
		this.button7.HeightRequest = 50;
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString("7");
		this.table6.Add(this.button7);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table6[this.button7]));
		w13.XPadding = ((uint)(10));
		w13.YPadding = ((uint)(5));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button8 = new global::Gtk.Button();
		this.button8.WidthRequest = 75;
		this.button8.HeightRequest = 50;
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString("8");
		this.table6.Add(this.button8);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table6[this.button8]));
		w14.LeftAttach = ((uint)(1));
		w14.RightAttach = ((uint)(2));
		w14.XPadding = ((uint)(10));
		w14.YPadding = ((uint)(5));
		w14.XOptions = ((global::Gtk.AttachOptions)(4));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button9 = new global::Gtk.Button();
		this.button9.WidthRequest = 75;
		this.button9.HeightRequest = 50;
		this.button9.CanFocus = true;
		this.button9.Name = "button9";
		this.button9.UseUnderline = true;
		this.button9.Label = global::Mono.Unix.Catalog.GetString("9");
		this.table6.Add(this.button9);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table6[this.button9]));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		w15.XPadding = ((uint)(10));
		w15.YPadding = ((uint)(5));
		w15.XOptions = ((global::Gtk.AttachOptions)(4));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox6.Add(this.table6);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.table6]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned();
		this.hpaned1.Name = "hpaned1";
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.hpaned1.Add(this.fixed1);
		global::Gtk.Paned.PanedChild w17 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.fixed1]));
		w17.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonDiv = new global::Gtk.Button();
		this.buttonDiv.WidthRequest = 75;
		this.buttonDiv.HeightRequest = 50;
		this.buttonDiv.CanFocus = true;
		this.buttonDiv.Name = "buttonDiv";
		this.buttonDiv.UseUnderline = true;
		this.buttonDiv.Label = global::Mono.Unix.Catalog.GetString("/");
		this.vbox4.Add(this.buttonDiv);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonDiv]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		w18.Padding = ((uint)(5));
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonMul = new global::Gtk.Button();
		this.buttonMul.WidthRequest = 75;
		this.buttonMul.HeightRequest = 50;
		this.buttonMul.CanFocus = true;
		this.buttonMul.Name = "buttonMul";
		this.buttonMul.UseUnderline = true;
		this.buttonMul.Label = global::Mono.Unix.Catalog.GetString("*");
		this.vbox4.Add(this.buttonMul);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonMul]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		w19.Padding = ((uint)(5));
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonSub = new global::Gtk.Button();
		this.buttonSub.WidthRequest = 75;
		this.buttonSub.HeightRequest = 50;
		this.buttonSub.CanFocus = true;
		this.buttonSub.Name = "buttonSub";
		this.buttonSub.UseUnderline = true;
		this.buttonSub.Label = global::Mono.Unix.Catalog.GetString("-");
		this.vbox4.Add(this.buttonSub);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonSub]));
		w20.Position = 2;
		w20.Expand = false;
		w20.Fill = false;
		w20.Padding = ((uint)(5));
		this.hbox3.Add(this.vbox4);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox4]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		this.hpaned1.Add(this.hbox3);
		this.hbox6.Add(this.hpaned1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hpaned1]));
		w23.Position = 1;
		this.vbox6.Add(this.hbox6);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox6]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
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
		this.button.WidthRequest = 75;
		this.button.HeightRequest = 50;
		this.button.CanFocus = true;
		this.button.Name = "button";
		this.button.UseUnderline = true;
		this.button.Label = global::Mono.Unix.Catalog.GetString("0");
		this.hbox10.Add(this.button);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.button]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		w25.Padding = ((uint)(5));
		// Container child hbox10.Gtk.Box+BoxChild
		this.buttonDot = new global::Gtk.Button();
		this.buttonDot.WidthRequest = 75;
		this.buttonDot.HeightRequest = 50;
		this.buttonDot.CanFocus = true;
		this.buttonDot.Name = "buttonDot";
		this.buttonDot.UseUnderline = true;
		this.buttonDot.Label = global::Mono.Unix.Catalog.GetString(".");
		this.hbox10.Add(this.buttonDot);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.buttonDot]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		w26.Padding = ((uint)(15));
		// Container child hbox10.Gtk.Box+BoxChild
		this.button11 = new global::Gtk.Button();
		this.button11.WidthRequest = 75;
		this.button11.HeightRequest = 0;
		this.button11.CanFocus = true;
		this.button11.Name = "button11";
		this.button11.UseUnderline = true;
		this.button11.Label = global::Mono.Unix.Catalog.GetString("=");
		this.hbox10.Add(this.button11);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.button11]));
		w27.PackType = ((global::Gtk.PackType)(1));
		w27.Position = 2;
		w27.Expand = false;
		w27.Fill = false;
		w27.Padding = ((uint)(5));
		this.hbox9.Add(this.hbox10);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.hbox10]));
		w28.Position = 0;
		w28.Expand = false;
		w28.Fill = false;
		w28.Padding = ((uint)(5));
		// Container child hbox9.Gtk.Box+BoxChild
		this.buttonPlus = new global::Gtk.Button();
		this.buttonPlus.WidthRequest = 75;
		this.buttonPlus.HeightRequest = 50;
		this.buttonPlus.CanFocus = true;
		this.buttonPlus.Name = "buttonPlus";
		this.buttonPlus.UseUnderline = true;
		this.buttonPlus.Label = global::Mono.Unix.Catalog.GetString("+");
		this.hbox9.Add(this.buttonPlus);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.buttonPlus]));
		w29.Position = 1;
		w29.Expand = false;
		w29.Fill = false;
		w29.Padding = ((uint)(5));
		this.vbox6.Add(this.hbox9);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox9]));
		w30.Position = 2;
		w30.Expand = false;
		w30.Fill = false;
		this.Add(this.vbox6);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 396;
		this.DefaultHeight = 620;
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
		this.buttonDiv.Clicked += new global::System.EventHandler(this.OnButtonDivClicked);
		this.buttonMul.Clicked += new global::System.EventHandler(this.OnButtonMulClicked);
		this.buttonSub.Clicked += new global::System.EventHandler(this.OnButtonSubClicked);
		this.button.Clicked += new global::System.EventHandler(this.OnButtonClicked);
		this.buttonDot.Clicked += new global::System.EventHandler(this.OnButtonDotClicked);
		this.button11.Clicked += new global::System.EventHandler(this.OnButton11Clicked);
		this.buttonPlus.Clicked += new global::System.EventHandler(this.OnButtonPlusClicked);
	}
}
