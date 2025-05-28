namespace Gestiune_Bar_proiect_LICENTA
{
    partial class MeniuBarman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuBarman));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ORA = new Label();
            SECUNDE = new Label();
            MINUTE = new Label();
            panel2 = new Panel();
            InformatiiStocuri = new Button();
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
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ORA);
            panel1.Controls.Add(SECUNDE);
            panel1.Controls.Add(MINUTE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1405, 264);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(1069, 198);
            label3.Name = "label3";
            label3.Size = new Size(151, 38);
            label3.TabIndex = 12;
            label3.Text = "Barman";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1043, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 6);
            label2.Name = "label2";
            label2.Size = new Size(35, 52);
            label2.TabIndex = 10;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 52);
            label1.TabIndex = 9;
            label1.Text = ":";
            // 
            // ORA
            // 
            ORA.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ORA.Location = new Point(9, 9);
            ORA.Name = "ORA";
            ORA.Size = new Size(81, 52);
            ORA.TabIndex = 7;
            ORA.Text = "00 ";
            // 
            // SECUNDE
            // 
            SECUNDE.AutoSize = true;
            SECUNDE.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SECUNDE.Location = new Point(198, 9);
            SECUNDE.Name = "SECUNDE";
            SECUNDE.Size = new Size(80, 52);
            SECUNDE.TabIndex = 8;
            SECUNDE.Text = "00";
            // 
            // MINUTE
            // 
            MINUTE.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MINUTE.Location = new Point(99, 9);
            MINUTE.Name = "MINUTE";
            MINUTE.Size = new Size(80, 52);
            MINUTE.TabIndex = 6;
            MINUTE.Text = "00 ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(InformatiiStocuri);
            panel2.Controls.Add(SchimbareCont);
            panel2.Controls.Add(Incepere_Final);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(835, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 514);
            panel2.TabIndex = 1;
            // 
            // InformatiiStocuri
            // 
            InformatiiStocuri.BackColor = Color.Silver;
            InformatiiStocuri.FlatAppearance.BorderSize = 0;
            InformatiiStocuri.FlatStyle = FlatStyle.Flat;
            InformatiiStocuri.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InformatiiStocuri.Location = new Point(19, 80);
            InformatiiStocuri.Margin = new Padding(0);
            InformatiiStocuri.Name = "InformatiiStocuri";
            InformatiiStocuri.Size = new Size(527, 110);
            InformatiiStocuri.TabIndex = 7;
            InformatiiStocuri.Text = "Informatii Stocuri";
            InformatiiStocuri.UseVisualStyleBackColor = false;
            // 
            // SchimbareCont
            // 
            SchimbareCont.BackColor = Color.Silver;
            SchimbareCont.FlatAppearance.BorderSize = 0;
            SchimbareCont.FlatStyle = FlatStyle.Flat;
            SchimbareCont.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SchimbareCont.Location = new Point(19, 208);
            SchimbareCont.Name = "SchimbareCont";
            SchimbareCont.Size = new Size(527, 110);
            SchimbareCont.TabIndex = 5;
            SchimbareCont.Text = "Schimbare Cont";
            SchimbareCont.UseVisualStyleBackColor = false;
            // 
            // Incepere_Final
            // 
            Incepere_Final.BackColor = Color.Silver;
            Incepere_Final.FlatAppearance.BorderSize = 0;
            Incepere_Final.FlatStyle = FlatStyle.Flat;
            Incepere_Final.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Incepere_Final.Location = new Point(19, 335);
            Incepere_Final.Name = "Incepere_Final";
            Incepere_Final.Size = new Size(527, 110);
            Incepere_Final.TabIndex = 4;
            Incepere_Final.Text = "button16";
            Incepere_Final.UseVisualStyleBackColor = false;
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
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(805, 82);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            // MeniuBarman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 778);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MeniuBarman";
            Text = "Meniu Barman";
            Load += MeniuBarman_Load;
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
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label ORA;
        private Label SECUNDE;
        private Label MINUTE;
        private Label label3;
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
        private System.Windows.Forms.Timer Temporizator;
        private Button InformatiiStocuri;
        private Button SchimbareCont;
        private Button Incepere_Final;
    }
}