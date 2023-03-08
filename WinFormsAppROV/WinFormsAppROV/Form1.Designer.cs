namespace WinFormsAppROV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDisConnect = new Button();
            btnConnect = new Button();
            lbStatus = new Label();
            label3 = new Label();
            cbxBaudrate = new ComboBox();
            label2 = new Label();
            cbxCOM = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            Trái = new Button();
            Tiến = new Button();
            panel3 = new Panel();
            groupB = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDisConnect);
            panel1.Controls.Add(btnConnect);
            panel1.Controls.Add(lbStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbxBaudrate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbxCOM);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1130, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 196);
            panel1.TabIndex = 0;
            // 
            // btnDisConnect
            // 
            btnDisConnect.Cursor = Cursors.Hand;
            btnDisConnect.Location = new Point(118, 148);
            btnDisConnect.Name = "btnDisConnect";
            btnDisConnect.Size = new Size(99, 23);
            btnDisConnect.TabIndex = 7;
            btnDisConnect.Text = "Ngắt kết nối";
            btnDisConnect.UseVisualStyleBackColor = true;
            btnDisConnect.Click += btnDisConnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.AccessibleName = "";
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.Location = new Point(24, 148);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.ForeColor = Color.Red;
            lbStatus.Location = new Point(94, 103);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(74, 15);
            lbStatus.TabIndex = 5;
            lbStatus.Text = "Chưa kết nối";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 103);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // cbxBaudrate
            // 
            cbxBaudrate.FormattingEnabled = true;
            cbxBaudrate.Location = new Point(94, 57);
            cbxBaudrate.Name = "cbxBaudrate";
            cbxBaudrate.Size = new Size(217, 23);
            cbxBaudrate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Baudrate";
            // 
            // cbxCOM
            // 
            cbxCOM.FormattingEnabled = true;
            cbxCOM.Location = new Point(94, 17);
            cbxCOM.Name = "cbxCOM";
            cbxCOM.Size = new Size(217, 23);
            cbxCOM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "COM";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Trái);
            panel2.Controls.Add(Tiến);
            panel2.Location = new Point(837, 529);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 100);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(215, 23);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 3;
            button4.Text = "Phải";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(149, 23);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "Lùi";
            button3.UseVisualStyleBackColor = true;
            // 
            // Trái
            // 
            Trái.Cursor = Cursors.Hand;
            Trái.Location = new Point(83, 23);
            Trái.Name = "Trái";
            Trái.Size = new Size(60, 60);
            Trái.TabIndex = 1;
            Trái.Text = "Trái";
            Trái.UseVisualStyleBackColor = true;
            // 
            // Tiến
            // 
            Tiến.Cursor = Cursors.Hand;
            Tiến.Location = new Point(17, 23);
            Tiến.Name = "Tiến";
            Tiến.Size = new Size(60, 60);
            Tiến.TabIndex = 0;
            Tiến.Text = "Tiến";
            Tiến.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 511);
            panel3.TabIndex = 2;
            // 
            // groupB
            // 
            groupB.Location = new Point(1130, 12);
            groupB.Name = "groupB";
            groupB.Size = new Size(342, 415);
            groupB.TabIndex = 3;
            groupB.TabStop = false;
            groupB.Text = "Console";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 641);
            Controls.Add(groupB);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbxBaudrate;
        private Label label2;
        private ComboBox cbxCOM;
        private Label label1;
        private Button btnDisConnect;
        private Button btnConnect;
        private Label lbStatus;
        private Label label3;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button Trái;
        private Button Tiến;
        private Panel panel3;
        private GroupBox groupB;
    }
}