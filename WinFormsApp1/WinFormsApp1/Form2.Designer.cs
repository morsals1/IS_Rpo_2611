﻿namespace WinFormsApp1
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabCat = new TabPage();
            tabOrder = new TabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCat);
            tabControl1.Controls.Add(tabOrder);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 125);
            tabControl1.TabIndex = 0;
            // 
            // tabCat
            // 
            tabCat.Location = new Point(4, 29);
            tabCat.Name = "tabCat";
            tabCat.Padding = new Padding(3);
            tabCat.Size = new Size(792, 92);
            tabCat.TabIndex = 0;
            tabCat.Text = "Каталог";
            tabCat.UseVisualStyleBackColor = true;
            // 
            // tabOrder
            // 
            tabOrder.Location = new Point(4, 29);
            tabOrder.Name = "tabOrder";
            tabOrder.Padding = new Padding(3);
            tabOrder.Size = new Size(792, 92);
            tabOrder.TabIndex = 1;
            tabOrder.Text = "Заказы";
            tabOrder.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(792, 92);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Склад";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 92);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Финансы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCat;
        private TabPage tabOrder;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}