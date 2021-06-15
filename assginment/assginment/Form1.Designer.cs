namespace assginment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EUR_box = new System.Windows.Forms.Button();
            this.User_imput_GBP = new System.Windows.Forms.Label();
            this.User_imput = new System.Windows.Forms.Label();
            this.Output_box = new System.Windows.Forms.Label();
            this.Output_text = new System.Windows.Forms.Label();
            this.Money_imput = new System.Windows.Forms.TextBox();
            this.imput_GBP = new System.Windows.Forms.TextBox();
            this.TITLE_BUY = new System.Windows.Forms.Label();
            this.Title_SELL = new System.Windows.Forms.Label();
            this.TRY_box_sell = new System.Windows.Forms.Button();
            this.USD_box_sell = new System.Windows.Forms.Button();
            this.EUR_box_sell = new System.Windows.Forms.Button();
            this.TRY_box = new System.Windows.Forms.Button();
            this.USD_box = new System.Windows.Forms.Button();
            this.Info_buy = new System.Windows.Forms.Button();
            this.Buy_info = new System.Windows.Forms.Label();
            this.Sell_text = new System.Windows.Forms.Label();
            this.Sell_Info = new System.Windows.Forms.Button();
            this.Custom_Buy = new System.Windows.Forms.Button();
            this.NOTE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.E1 = new System.Windows.Forms.Label();
            this.U1 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Label();
            this.E2 = new System.Windows.Forms.Label();
            this.U2 = new System.Windows.Forms.Label();
            this.T2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cus_Sell = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cus_Buy = new System.Windows.Forms.TextBox();
            this.Cusstom_imput = new System.Windows.Forms.Button();
            this.Custom_Sell = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EUR_box
            // 
            this.EUR_box.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUR_box.Location = new System.Drawing.Point(11, 140);
            this.EUR_box.Name = "EUR_box";
            this.EUR_box.Size = new System.Drawing.Size(92, 30);
            this.EUR_box.TabIndex = 0;
            this.EUR_box.Text = "EUR";
            this.EUR_box.UseVisualStyleBackColor = true;
            this.EUR_box.Click += new System.EventHandler(this.EUR_box_Click);
            // 
            // User_imput_GBP
            // 
            this.User_imput_GBP.AutoSize = true;
            this.User_imput_GBP.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_imput_GBP.Location = new System.Drawing.Point(12, 90);
            this.User_imput_GBP.Name = "User_imput_GBP";
            this.User_imput_GBP.Size = new System.Drawing.Size(185, 21);
            this.User_imput_GBP.TabIndex = 3;
            this.User_imput_GBP.Text = "Amount of GBP you have";
            // 
            // User_imput
            // 
            this.User_imput.AutoSize = true;
            this.User_imput.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_imput.Location = new System.Drawing.Point(12, 258);
            this.User_imput.Name = "User_imput";
            this.User_imput.Size = new System.Drawing.Size(138, 21);
            this.User_imput.TabIndex = 3;
            this.User_imput.Text = "Amount  you have";
            // 
            // Output_box
            // 
            this.Output_box.AutoSize = true;
            this.Output_box.Font = new System.Drawing.Font("Calibri", 20F);
            this.Output_box.Location = new System.Drawing.Point(32, 416);
            this.Output_box.Name = "Output_box";
            this.Output_box.Size = new System.Drawing.Size(27, 33);
            this.Output_box.TabIndex = 1;
            this.Output_box.Text = "  ";
            this.Output_box.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Output_text
            // 
            this.Output_text.AutoSize = true;
            this.Output_text.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_text.Location = new System.Drawing.Point(10, 383);
            this.Output_text.Name = "Output_text";
            this.Output_text.Size = new System.Drawing.Size(198, 33);
            this.Output_text.TabIndex = 1;
            this.Output_text.Text = "Amount you get:";
            // 
            // Money_imput
            // 
            this.Money_imput.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Money_imput.Location = new System.Drawing.Point(12, 282);
            this.Money_imput.Name = "Money_imput";
            this.Money_imput.Size = new System.Drawing.Size(288, 23);
            this.Money_imput.TabIndex = 2;
            this.Money_imput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_imput_KeyPress);
            // 
            // imput_GBP
            // 
            this.imput_GBP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imput_GBP.Location = new System.Drawing.Point(12, 114);
            this.imput_GBP.Name = "imput_GBP";
            this.imput_GBP.Size = new System.Drawing.Size(288, 23);
            this.imput_GBP.TabIndex = 2;
            this.imput_GBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Imput_GBP_KeyPress);
            // 
            // TITLE_BUY
            // 
            this.TITLE_BUY.AutoSize = true;
            this.TITLE_BUY.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE_BUY.Location = new System.Drawing.Point(3, 41);
            this.TITLE_BUY.Name = "TITLE_BUY";
            this.TITLE_BUY.Size = new System.Drawing.Size(83, 49);
            this.TITLE_BUY.TabIndex = 1;
            this.TITLE_BUY.Text = "Buy";
            // 
            // Title_SELL
            // 
            this.Title_SELL.AutoSize = true;
            this.Title_SELL.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_SELL.Location = new System.Drawing.Point(13, 216);
            this.Title_SELL.Name = "Title_SELL";
            this.Title_SELL.Size = new System.Drawing.Size(78, 49);
            this.Title_SELL.TabIndex = 1;
            this.Title_SELL.Text = "Sell";
            // 
            // TRY_box_sell
            // 
            this.TRY_box_sell.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRY_box_sell.Location = new System.Drawing.Point(207, 311);
            this.TRY_box_sell.Name = "TRY_box_sell";
            this.TRY_box_sell.Size = new System.Drawing.Size(92, 30);
            this.TRY_box_sell.TabIndex = 0;
            this.TRY_box_sell.Text = "TRY";
            this.TRY_box_sell.UseVisualStyleBackColor = true;
            this.TRY_box_sell.Click += new System.EventHandler(this.TRY_box_sell_Click);
            // 
            // USD_box_sell
            // 
            this.USD_box_sell.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_box_sell.Location = new System.Drawing.Point(109, 311);
            this.USD_box_sell.Name = "USD_box_sell";
            this.USD_box_sell.Size = new System.Drawing.Size(92, 30);
            this.USD_box_sell.TabIndex = 0;
            this.USD_box_sell.Text = "USD";
            this.USD_box_sell.UseVisualStyleBackColor = true;
            this.USD_box_sell.Click += new System.EventHandler(this.USD_box_sell_Click);
            // 
            // EUR_box_sell
            // 
            this.EUR_box_sell.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUR_box_sell.Location = new System.Drawing.Point(11, 311);
            this.EUR_box_sell.Name = "EUR_box_sell";
            this.EUR_box_sell.Size = new System.Drawing.Size(92, 30);
            this.EUR_box_sell.TabIndex = 0;
            this.EUR_box_sell.Text = "EUR";
            this.EUR_box_sell.UseVisualStyleBackColor = true;
            this.EUR_box_sell.Click += new System.EventHandler(this.EUR_box_sell_Click_1);
            // 
            // TRY_box
            // 
            this.TRY_box.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRY_box.Location = new System.Drawing.Point(207, 140);
            this.TRY_box.Name = "TRY_box";
            this.TRY_box.Size = new System.Drawing.Size(92, 30);
            this.TRY_box.TabIndex = 0;
            this.TRY_box.Text = "TRY";
            this.TRY_box.UseVisualStyleBackColor = true;
            this.TRY_box.Click += new System.EventHandler(this.TRY_box_Click);
            // 
            // USD_box
            // 
            this.USD_box.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_box.Location = new System.Drawing.Point(109, 140);
            this.USD_box.Name = "USD_box";
            this.USD_box.Size = new System.Drawing.Size(92, 30);
            this.USD_box.TabIndex = 0;
            this.USD_box.Text = "USD";
            this.USD_box.UseVisualStyleBackColor = true;
            this.USD_box.Click += new System.EventHandler(this.USD_box_Click);
            // 
            // Info_buy
            // 
            this.Info_buy.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_buy.Location = new System.Drawing.Point(103, 55);
            this.Info_buy.Name = "Info_buy";
            this.Info_buy.Size = new System.Drawing.Size(24, 24);
            this.Info_buy.TabIndex = 4;
            this.Info_buy.Text = "i";
            this.Info_buy.UseVisualStyleBackColor = true;
            this.Info_buy.MouseLeave += new System.EventHandler(this.Info_buy_MouseLeave_1);
            this.Info_buy.MouseHover += new System.EventHandler(this.Info_buy_MouseHover);
            // 
            // Buy_info
            // 
            this.Buy_info.AutoSize = true;
            this.Buy_info.BackColor = System.Drawing.Color.Transparent;
            this.Buy_info.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Buy_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buy_info.Location = new System.Drawing.Point(133, 39);
            this.Buy_info.Name = "Buy_info";
            this.Buy_info.Size = new System.Drawing.Size(221, 39);
            this.Buy_info.TabIndex = 5;
            this.Buy_info.Text = "Buy instuctions\r\n- put the amount of £ you have in the text box\r\n- click what Cur" +
    "ecny you want";
            // 
            // Sell_text
            // 
            this.Sell_text.AutoSize = true;
            this.Sell_text.BackColor = System.Drawing.Color.Transparent;
            this.Sell_text.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Sell_text.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sell_text.Location = new System.Drawing.Point(127, 226);
            this.Sell_text.Name = "Sell_text";
            this.Sell_text.Size = new System.Drawing.Size(246, 39);
            this.Sell_text.TabIndex = 7;
            this.Sell_text.Text = "Sell instuctions\r\n- put the amount of money you have in the text box\r\n- Select wa" +
    "ht currecny you HAVE";
            // 
            // Sell_Info
            // 
            this.Sell_Info.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_Info.Location = new System.Drawing.Point(97, 231);
            this.Sell_Info.Name = "Sell_Info";
            this.Sell_Info.Size = new System.Drawing.Size(24, 24);
            this.Sell_Info.TabIndex = 6;
            this.Sell_Info.Text = "i";
            this.Sell_Info.UseVisualStyleBackColor = true;
            this.Sell_Info.MouseLeave += new System.EventHandler(this.Sell_Info_MouseLeave);
            this.Sell_Info.MouseHover += new System.EventHandler(this.Sell_Info_MouseHover);
            // 
            // Custom_Buy
            // 
            this.Custom_Buy.Font = new System.Drawing.Font("Calibri", 13F);
            this.Custom_Buy.Location = new System.Drawing.Point(11, 174);
            this.Custom_Buy.Name = "Custom_Buy";
            this.Custom_Buy.Size = new System.Drawing.Size(92, 30);
            this.Custom_Buy.TabIndex = 8;
            this.Custom_Buy.Text = "Custom";
            this.Custom_Buy.UseVisualStyleBackColor = true;
            this.Custom_Buy.Click += new System.EventHandler(this.Custom_Buy_Click);
            // 
            // NOTE
            // 
            this.NOTE.AutoSize = true;
            this.NOTE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTE.ForeColor = System.Drawing.Color.Firebrick;
            this.NOTE.Location = new System.Drawing.Point(22, 9);
            this.NOTE.Name = "NOTE";
            this.NOTE.Size = new System.Drawing.Size(451, 19);
            this.NOTE.TabIndex = 9;
            this.NOTE.Text = "Note: The text boxes only allow for numbers or \".\" to be put in them.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(444, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label2.Location = new System.Drawing.Point(455, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label3.Location = new System.Drawing.Point(521, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label4.Location = new System.Drawing.Point(395, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "EUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label5.Location = new System.Drawing.Point(395, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "USD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label6.Location = new System.Drawing.Point(395, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "TRY";
            // 
            // E1
            // 
            this.E1.AutoSize = true;
            this.E1.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.E1.Location = new System.Drawing.Point(455, 113);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(27, 21);
            this.E1.TabIndex = 10;
            this.E1.Text = "E1";
            // 
            // U1
            // 
            this.U1.AutoSize = true;
            this.U1.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.U1.Location = new System.Drawing.Point(455, 148);
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(30, 21);
            this.U1.TabIndex = 10;
            this.U1.Text = "U1";
            // 
            // T1
            // 
            this.T1.AutoSize = true;
            this.T1.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.T1.Location = new System.Drawing.Point(455, 183);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(27, 21);
            this.T1.TabIndex = 10;
            this.T1.Text = "T1";
            // 
            // E2
            // 
            this.E2.AutoSize = true;
            this.E2.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.E2.Location = new System.Drawing.Point(521, 113);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(27, 21);
            this.E2.TabIndex = 10;
            this.E2.Text = "E2";
            // 
            // U2
            // 
            this.U2.AutoSize = true;
            this.U2.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.U2.Location = new System.Drawing.Point(521, 148);
            this.U2.Name = "U2";
            this.U2.Size = new System.Drawing.Size(30, 21);
            this.U2.TabIndex = 10;
            this.U2.Text = "U2";
            // 
            // T2
            // 
            this.T2.AutoSize = true;
            this.T2.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.T2.Location = new System.Drawing.Point(521, 183);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(27, 21);
            this.T2.TabIndex = 10;
            this.T2.Text = "T2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label7.Location = new System.Drawing.Point(394, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Add custom Curency";
            // 
            // Cus_Sell
            // 
            this.Cus_Sell.Location = new System.Drawing.Point(486, 329);
            this.Cus_Sell.Name = "Cus_Sell";
            this.Cus_Sell.Size = new System.Drawing.Size(78, 20);
            this.Cus_Sell.TabIndex = 12;
            this.Cus_Sell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 11F);
            this.label9.Location = new System.Drawing.Point(388, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sell Prce";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11F);
            this.label10.Location = new System.Drawing.Point(384, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Buy Price";
            // 
            // Cus_Buy
            // 
            this.Cus_Buy.Location = new System.Drawing.Point(486, 303);
            this.Cus_Buy.Name = "Cus_Buy";
            this.Cus_Buy.Size = new System.Drawing.Size(78, 20);
            this.Cus_Buy.TabIndex = 15;
            this.Cus_Buy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Cusstom_imput
            // 
            this.Cusstom_imput.Font = new System.Drawing.Font("Calibri", 11F);
            this.Cusstom_imput.Location = new System.Drawing.Point(427, 355);
            this.Cusstom_imput.Name = "Cusstom_imput";
            this.Cusstom_imput.Size = new System.Drawing.Size(75, 23);
            this.Cusstom_imput.TabIndex = 17;
            this.Cusstom_imput.Text = "Add";
            this.Cusstom_imput.UseVisualStyleBackColor = true;
            this.Cusstom_imput.Click += new System.EventHandler(this.Cusstom_imput_Click);
            // 
            // Custom_Sell
            // 
            this.Custom_Sell.Font = new System.Drawing.Font("Calibri", 13F);
            this.Custom_Sell.Location = new System.Drawing.Point(11, 342);
            this.Custom_Sell.Name = "Custom_Sell";
            this.Custom_Sell.Size = new System.Drawing.Size(92, 30);
            this.Custom_Sell.TabIndex = 18;
            this.Custom_Sell.Text = "Custom";
            this.Custom_Sell.UseVisualStyleBackColor = true;
            this.Custom_Sell.Click += new System.EventHandler(this.Custom_Sell_Click);
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.C1.Location = new System.Drawing.Point(455, 211);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(28, 21);
            this.C1.TabIndex = 19;
            this.C1.Text = "C1";
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.C2.Location = new System.Drawing.Point(520, 211);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(28, 21);
            this.C2.TabIndex = 19;
            this.C2.Text = "C2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.label12.Location = new System.Drawing.Point(374, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Custom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(609, 487);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.Custom_Sell);
            this.Controls.Add(this.Cusstom_imput);
            this.Controls.Add(this.Cus_Buy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cus_Sell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.U2);
            this.Controls.Add(this.U1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NOTE);
            this.Controls.Add(this.Custom_Buy);
            this.Controls.Add(this.Sell_text);
            this.Controls.Add(this.Sell_Info);
            this.Controls.Add(this.Buy_info);
            this.Controls.Add(this.Info_buy);
            this.Controls.Add(this.User_imput_GBP);
            this.Controls.Add(this.User_imput);
            this.Controls.Add(this.Money_imput);
            this.Controls.Add(this.imput_GBP);
            this.Controls.Add(this.Output_box);
            this.Controls.Add(this.Output_text);
            this.Controls.Add(this.TITLE_BUY);
            this.Controls.Add(this.Title_SELL);
            this.Controls.Add(this.TRY_box_sell);
            this.Controls.Add(this.TRY_box);
            this.Controls.Add(this.USD_box_sell);
            this.Controls.Add(this.EUR_box_sell);
            this.Controls.Add(this.USD_box);
            this.Controls.Add(this.EUR_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Curency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EUR_box;
        private System.Windows.Forms.Label User_imput_GBP;
        private System.Windows.Forms.Label User_imput;
        private System.Windows.Forms.Label Output_box;
        private System.Windows.Forms.Label Output_text;
        private System.Windows.Forms.TextBox Money_imput;
        private System.Windows.Forms.TextBox imput_GBP;
        private System.Windows.Forms.Label TITLE_BUY;
        private System.Windows.Forms.Label Title_SELL;
        private System.Windows.Forms.Button TRY_box_sell;
        private System.Windows.Forms.Button USD_box_sell;
        private System.Windows.Forms.Button EUR_box_sell;
        private System.Windows.Forms.Button TRY_box;
        private System.Windows.Forms.Button USD_box;
        private System.Windows.Forms.Button Info_buy;
        private System.Windows.Forms.Label Buy_info;
        private System.Windows.Forms.Label Sell_text;
        private System.Windows.Forms.Button Sell_Info;
        private System.Windows.Forms.Button Custom_Buy;
        private System.Windows.Forms.Label NOTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label E1;
        private System.Windows.Forms.Label U1;
        private System.Windows.Forms.Label T1;
        private System.Windows.Forms.Label E2;
        private System.Windows.Forms.Label U2;
        private System.Windows.Forms.Label T2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cus_Sell;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Cus_Buy;
        private System.Windows.Forms.Button Cusstom_imput;
        private System.Windows.Forms.Button Custom_Sell;
        private System.Windows.Forms.Label C1;
        private System.Windows.Forms.Label C2;
        private System.Windows.Forms.Label label12;
    }
}

