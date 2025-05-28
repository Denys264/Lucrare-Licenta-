namespace Gestiune_Bar_proiect_LICENTA
{
    partial class MeniuAdministrator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuAdministrator));
            panel1 = new Panel();
            DATA = new Label();
            label2 = new Label();
            label1 = new Label();
            ORA = new Label();
            SECUNDE = new Label();
            MINUTE = new Label();
            USER = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            AdministrareStocuri = new Button();
            Rapoarte = new Button();
            SchimbareCont = new Button();
            Incepere_Final = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            Temporizator = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(DATA);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ORA);
            panel1.Controls.Add(SECUNDE);
            panel1.Controls.Add(MINUTE);
            panel1.Controls.Add(USER);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1405, 264);
            panel1.TabIndex = 0;
            // 
            // DATA
            // 
            DATA.AutoSize = true;
            DATA.Location = new Point(10, 64);
            DATA.Name = "DATA";
            DATA.Size = new Size(50, 20);
            DATA.TabIndex = 6;
            DATA.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 9);
            label2.Name = "label2";
            label2.Size = new Size(35, 52);
            label2.TabIndex = 5;
            label2.Text = ":";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 52);
            label1.TabIndex = 4;
            label1.Text = ":";
            label1.Click += label1_Click;
            // 
            // ORA
            // 
            ORA.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ORA.Location = new Point(0, 12);
            ORA.Name = "ORA";
            ORA.Size = new Size(81, 52);
            ORA.TabIndex = 3;
            ORA.Text = "00 ";
            // 
            // SECUNDE
            // 
            SECUNDE.AutoSize = true;
            SECUNDE.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SECUNDE.Location = new Point(189, 12);
            SECUNDE.Name = "SECUNDE";
            SECUNDE.Size = new Size(80, 52);
            SECUNDE.TabIndex = 3;
            SECUNDE.Text = "00";
            SECUNDE.Click += SECUNDE_Click;
            // 
            // MINUTE
            // 
            MINUTE.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MINUTE.Location = new Point(90, 12);
            MINUTE.Name = "MINUTE";
            MINUTE.Size = new Size(80, 52);
            MINUTE.TabIndex = 2;
            MINUTE.Text = "00 ";
            // 
            // USER
            // 
            USER.AutoSize = true;
            USER.Font = new Font("Elephant", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            USER.ForeColor = Color.Black;
            USER.Location = new Point(1023, 198);
            USER.Name = "USER";
            USER.Size = new Size(243, 38);
            USER.TabIndex = 1;
            USER.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1050, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(AdministrareStocuri);
            panel2.Controls.Add(Rapoarte);
            panel2.Controls.Add(SchimbareCont);
            panel2.Controls.Add(Incepere_Final);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(835, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 514);
            panel2.TabIndex = 1;
            // 
            // AdministrareStocuri
            // 
            AdministrareStocuri.BackColor = Color.Silver;
            AdministrareStocuri.FlatAppearance.BorderSize = 0;
            AdministrareStocuri.FlatStyle = FlatStyle.Flat;
            AdministrareStocuri.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdministrareStocuri.Location = new Point(22, 35);
            AdministrareStocuri.Margin = new Padding(0);
            AdministrareStocuri.Name = "AdministrareStocuri";
            AdministrareStocuri.Size = new Size(527, 110);
            AdministrareStocuri.TabIndex = 3;
            AdministrareStocuri.Text = "Administrare Stocuri";
            AdministrareStocuri.UseVisualStyleBackColor = false;
            AdministrareStocuri.Click += AdministrareStocuri_Click;
            // 
            // Rapoarte
            // 
            Rapoarte.BackColor = Color.Silver;
            Rapoarte.FlatAppearance.BorderSize = 0;
            Rapoarte.FlatStyle = FlatStyle.Flat;
            Rapoarte.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rapoarte.Location = new Point(22, 151);
            Rapoarte.Name = "Rapoarte";
            Rapoarte.Size = new Size(527, 110);
            Rapoarte.TabIndex = 2;
            Rapoarte.Text = "Rapoarte";
            Rapoarte.UseVisualStyleBackColor = false;
            // 
            // SchimbareCont
            // 
            SchimbareCont.BackColor = Color.Silver;
            SchimbareCont.FlatAppearance.BorderSize = 0;
            SchimbareCont.FlatStyle = FlatStyle.Flat;
            SchimbareCont.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SchimbareCont.Location = new Point(22, 267);
            SchimbareCont.Name = "SchimbareCont";
            SchimbareCont.Size = new Size(527, 110);
            SchimbareCont.TabIndex = 1;
            SchimbareCont.Text = "Schimbare Cont";
            SchimbareCont.UseVisualStyleBackColor = false;
            // 
            // Incepere_Final
            // 
            Incepere_Final.BackColor = Color.Silver;
            Incepere_Final.FlatAppearance.BorderSize = 0;
            Incepere_Final.FlatStyle = FlatStyle.Flat;
            Incepere_Final.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Incepere_Final.Location = new Point(22, 383);
            Incepere_Final.Name = "Incepere_Final";
            Incepere_Final.Size = new Size(527, 110);
            Incepere_Final.TabIndex = 0;
            Incepere_Final.Text = "button16";
            Incepere_Final.UseVisualStyleBackColor = false;
            Incepere_Final.Click += Incepere_Final_Click;
            Incepere_Final.MouseHover += Incepere_Final_MouseHover;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button13);
            flowLayoutPanel1.Controls.Add(button14);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 264);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(835, 514);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(805, 82);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 91);
            button2.Name = "button2";
            button2.Size = new Size(805, 82);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 179);
            button3.Name = "button3";
            button3.Size = new Size(805, 82);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 267);
            button4.Name = "button4";
            button4.Size = new Size(805, 82);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 355);
            button5.Name = "button5";
            button5.Size = new Size(805, 82);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 443);
            button6.Name = "button6";
            button6.Size = new Size(805, 82);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 531);
            button7.Name = "button7";
            button7.Size = new Size(805, 82);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(3, 619);
            button8.Name = "button8";
            button8.Size = new Size(805, 82);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(3, 707);
            button9.Name = "button9";
            button9.Size = new Size(805, 82);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(3, 795);
            button10.Name = "button10";
            button10.Size = new Size(805, 82);
            button10.TabIndex = 9;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(3, 883);
            button11.Name = "button11";
            button11.Size = new Size(805, 82);
            button11.TabIndex = 10;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(3, 971);
            button12.Name = "button12";
            button12.Size = new Size(805, 82);
            button12.TabIndex = 11;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(3, 1059);
            button13.Name = "button13";
            button13.Size = new Size(805, 82);
            button13.TabIndex = 12;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(3, 1147);
            button14.Name = "button14";
            button14.Size = new Size(805, 82);
            button14.TabIndex = 13;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(3, 1235);
            button15.Name = "button15";
            button15.Size = new Size(805, 82);
            button15.TabIndex = 14;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // Temporizator
            // 
            Temporizator.Interval = 1000;
            Temporizator.Tick += Temporizator_Tick;
            // 
            // MeniuAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1405, 778);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MeniuAdministrator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meniu Administrator";
            Load += MeniuAdministrator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label USER;
        private PictureBox pictureBox1;
        private Button Incepere_Final;
        private Button AdministrareStocuri;
        private Button Rapoarte;
        private Button SchimbareCont;
        private Label ORA;
        private Label SECUNDE;
        private Label MINUTE;
        private System.Windows.Forms.Timer Temporizator;
        private Label label2;
        private Label label1;
        private Label DATA;
    }
}