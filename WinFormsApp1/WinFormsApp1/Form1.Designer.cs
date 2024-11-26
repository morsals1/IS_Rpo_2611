namespace WinFormsApp1
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
            Buyer = new Button();
            dealer = new Button();
            RegBut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            EntraceBut = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Buyer
            // 
            Buyer.Location = new Point(12, 12);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(91, 23);
            Buyer.TabIndex = 0;
            Buyer.Text = "покупатель";
            Buyer.UseVisualStyleBackColor = true;
            Buyer.Click += Buyer_Click;
            // 
            // dealer
            // 
            dealer.Location = new Point(12, 41);
            dealer.Name = "dealer";
            dealer.Size = new Size(91, 23);
            dealer.TabIndex = 1;
            dealer.Text = "продаван";
            dealer.UseVisualStyleBackColor = true;
            dealer.Click += dealer_Click;
            // 
            // RegBut
            // 
            RegBut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegBut.Location = new Point(12, 400);
            RegBut.Name = "RegBut";
            RegBut.Size = new Size(360, 38);
            RegBut.TabIndex = 2;
            RegBut.Text = "зарегистрироваться";
            RegBut.UseVisualStyleBackColor = true;
            RegBut.Click += RegBut_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 5;
            label1.Text = "почта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 186);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9727537;
            pictureBox1.Location = new Point(109, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 128);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 245);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 8;
            label3.Text = "Уже есть аккаунт?";
            // 
            // EntraceBut
            // 
            EntraceBut.Location = new Point(158, 247);
            EntraceBut.Name = "EntraceBut";
            EntraceBut.Size = new Size(49, 21);
            EntraceBut.TabIndex = 9;
            EntraceBut.Text = "войти";
            EntraceBut.UseVisualStyleBackColor = true;
            EntraceBut.Click += EntraceBut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(213, 214);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 10;
            label4.Text = "👁";
            label4.MouseLeave += label4_MouseLeave;
            label4.MouseMove += label4_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 450);
            Controls.Add(label4);
            Controls.Add(EntraceBut);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(RegBut);
            Controls.Add(dealer);
            Controls.Add(Buyer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Buyer;
        private Button dealer;
        private Button RegBut;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button EntraceBut;
        private Label label4;
    }
}
