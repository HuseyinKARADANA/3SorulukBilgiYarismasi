namespace BilgiYarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btn_A = new Button();
            btn_B = new Button();
            btn_C = new Button();
            btn_sonraki = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_soruNo = new Label();
            lbl_dogru = new Label();
            lbl_yanlis = new Label();
            btn_D = new Button();
            img_yanlis = new PictureBox();
            img_dogru = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_yanlis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_dogru).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(0, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(646, 220);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Bilgi Yarışmasına  Hoşgeldiniz  :)";
            // 
            // btn_A
            // 
            btn_A.Location = new Point(52, 238);
            btn_A.Name = "btn_A";
            btn_A.Size = new Size(240, 50);
            btn_A.TabIndex = 1;
            btn_A.Text = "A";
            btn_A.UseVisualStyleBackColor = true;
            btn_A.Click += btn_A_Click;
            // 
            // btn_B
            // 
            btn_B.Location = new Point(332, 238);
            btn_B.Name = "btn_B";
            btn_B.Size = new Size(236, 50);
            btn_B.TabIndex = 1;
            btn_B.Text = "B";
            btn_B.UseVisualStyleBackColor = true;
            btn_B.Click += btn_B_Click;
            // 
            // btn_C
            // 
            btn_C.Location = new Point(56, 317);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(236, 50);
            btn_C.TabIndex = 1;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            // 
            // btn_sonraki
            // 
            btn_sonraki.Location = new Point(671, 171);
            btn_sonraki.Name = "btn_sonraki";
            btn_sonraki.Size = new Size(181, 50);
            btn_sonraki.TabIndex = 1;
            btn_sonraki.Text = "Sonraki";
            btn_sonraki.UseVisualStyleBackColor = true;
            btn_sonraki.Click += btn_sonraki_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(671, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 2;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(689, 76);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 2;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 125);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 2;
            label3.Text = "Yanlış:";
            // 
            // lbl_soruNo
            // 
            lbl_soruNo.AutoSize = true;
            lbl_soruNo.Location = new Point(795, 25);
            lbl_soruNo.Name = "lbl_soruNo";
            lbl_soruNo.Size = new Size(26, 31);
            lbl_soruNo.TabIndex = 3;
            lbl_soruNo.Text = "0";
            // 
            // lbl_dogru
            // 
            lbl_dogru.AutoSize = true;
            lbl_dogru.Location = new Point(795, 76);
            lbl_dogru.Name = "lbl_dogru";
            lbl_dogru.Size = new Size(26, 31);
            lbl_dogru.TabIndex = 3;
            lbl_dogru.Text = "0";
            // 
            // lbl_yanlis
            // 
            lbl_yanlis.AutoSize = true;
            lbl_yanlis.Location = new Point(795, 125);
            lbl_yanlis.Name = "lbl_yanlis";
            lbl_yanlis.Size = new Size(26, 31);
            lbl_yanlis.TabIndex = 3;
            lbl_yanlis.Text = "0";
            // 
            // btn_D
            // 
            btn_D.Location = new Point(332, 317);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(236, 50);
            btn_D.TabIndex = 1;
            btn_D.Text = "D";
            btn_D.UseVisualStyleBackColor = true;
            btn_D.Click += btn_D_Click_1;
            // 
            // img_yanlis
            // 
            img_yanlis.Image = (Image)resources.GetObject("img_yanlis.Image");
            img_yanlis.Location = new Point(646, 268);
            img_yanlis.Name = "img_yanlis";
            img_yanlis.Size = new Size(101, 99);
            img_yanlis.SizeMode = PictureBoxSizeMode.StretchImage;
            img_yanlis.TabIndex = 4;
            img_yanlis.TabStop = false;
            img_yanlis.Visible = false;
            // 
            // img_dogru
            // 
            img_dogru.Image = (Image)resources.GetObject("img_dogru.Image");
            img_dogru.Location = new Point(768, 268);
            img_dogru.Name = "img_dogru";
            img_dogru.Size = new Size(101, 99);
            img_dogru.SizeMode = PictureBoxSizeMode.StretchImage;
            img_dogru.TabIndex = 5;
            img_dogru.TabStop = false;
            img_dogru.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 392);
            Controls.Add(img_dogru);
            Controls.Add(img_yanlis);
            Controls.Add(lbl_yanlis);
            Controls.Add(lbl_dogru);
            Controls.Add(lbl_soruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_sonraki);
            Controls.Add(btn_D);
            Controls.Add(btn_C);
            Controls.Add(btn_B);
            Controls.Add(btn_A);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)img_yanlis).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_dogru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_A;
        private Button btn_B;
        private Button btn_C;
        private Button btn_sonraki;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_soruNo;
        private Label lbl_dogru;
        private Label lbl_yanlis;
        private Button btn_D;
        private PictureBox img_yanlis;
        private PictureBox img_dogru;
    }
}