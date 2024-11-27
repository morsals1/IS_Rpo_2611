namespace WinFormsApp1
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
            catalogPanel = new FlowLayoutPanel();
            tabOrder = new TabPage();
            loadButton = new Button();
            saveButton = new Button();
            ordersDataGridView = new DataGridView();
            Название = new DataGridViewTextBoxColumn();
            Цена = new DataGridViewTextBoxColumn();
            Пункт_выдачи = new DataGridViewTextBoxColumn();
            Количество = new DataGridViewTextBoxColumn();
            tabSklad = new TabPage();
            tabFin = new TabPage();
            tabControl1.SuspendLayout();
            tabCat.SuspendLayout();
            tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCat);
            tabControl1.Controls.Add(tabOrder);
            tabControl1.Controls.Add(tabSklad);
            tabControl1.Controls.Add(tabFin);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 338);
            tabControl1.TabIndex = 0;
            // 
            // tabCat
            // 
            tabCat.Controls.Add(catalogPanel);
            tabCat.Location = new Point(4, 24);
            tabCat.Margin = new Padding(3, 2, 3, 2);
            tabCat.Name = "tabCat";
            tabCat.Padding = new Padding(3, 2, 3, 2);
            tabCat.Size = new Size(692, 310);
            tabCat.TabIndex = 0;
            tabCat.Text = "Каталог";
            tabCat.UseVisualStyleBackColor = true;
            // 
            // catalogPanel
            // 
            catalogPanel.Location = new Point(8, 5);
            catalogPanel.Name = "catalogPanel";
            catalogPanel.Size = new Size(416, 187);
            catalogPanel.TabIndex = 0;
            // 
            // tabOrder
            // 
            tabOrder.Controls.Add(loadButton);
            tabOrder.Controls.Add(saveButton);
            tabOrder.Controls.Add(ordersDataGridView);
            tabOrder.Location = new Point(4, 24);
            tabOrder.Margin = new Padding(3, 2, 3, 2);
            tabOrder.Name = "tabOrder";
            tabOrder.Padding = new Padding(3, 2, 3, 2);
            tabOrder.Size = new Size(692, 310);
            tabOrder.TabIndex = 1;
            tabOrder.Text = "Заказы";
            tabOrder.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(87, 279);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 2;
            loadButton.Text = "загрузить";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(6, 279);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Название, Цена, Пункт_выдачи, Количество });
            ordersDataGridView.Location = new Point(25, 16);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.Size = new Size(444, 208);
            ordersDataGridView.TabIndex = 0;
            // 
            // Название
            // 
            Название.HeaderText = "Название";
            Название.Name = "Название";
            // 
            // Цена
            // 
            Цена.HeaderText = "Цена";
            Цена.Name = "Цена";
            // 
            // Пункт_выдачи
            // 
            Пункт_выдачи.HeaderText = "Пункт выдачи";
            Пункт_выдачи.Name = "Пункт_выдачи";
            // 
            // Количество
            // 
            Количество.HeaderText = "Количество";
            Количество.Name = "Количество";
            // 
            // tabSklad
            // 
            tabSklad.Location = new Point(4, 24);
            tabSklad.Margin = new Padding(3, 2, 3, 2);
            tabSklad.Name = "tabSklad";
            tabSklad.Size = new Size(692, 310);
            tabSklad.TabIndex = 2;
            tabSklad.Text = "Склад";
            tabSklad.UseVisualStyleBackColor = true;
            // 
            // tabFin
            // 
            tabFin.Location = new Point(4, 24);
            tabFin.Margin = new Padding(3, 2, 3, 2);
            tabFin.Name = "tabFin";
            tabFin.Size = new Size(692, 310);
            tabFin.TabIndex = 3;
            tabFin.Text = "Финансы";
            tabFin.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabCat.ResumeLayout(false);
            tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCat;
        private TabPage tabOrder;
        private TabPage tabSklad;
        private TabPage tabFin;
        private FlowLayoutPanel catalogPanel;
        private DataGridView ordersDataGridView;
        private DataGridViewTextBoxColumn Название;
        private DataGridViewTextBoxColumn Цена;
        private DataGridViewTextBoxColumn Пункт_выдачи;
        private DataGridViewTextBoxColumn Количество;
        private Button loadButton;
        private Button saveButton;
    }
}