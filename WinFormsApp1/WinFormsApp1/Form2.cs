using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private List<Product> products;
        private bool who1;
        public Form2(bool who)
        {
            InitializeComponent();

            products = new List<Product>
            {
                new Product { Name = "Помидор", Price = 10, Quantity = 100, Manufacturer = "ООО 1" },
                new Product { Name = "Огурец", Price = 15, Quantity = 85, Manufacturer = "ООО 2" },
                new Product { Name = "Картофель", Price = 5, Quantity = 150, Manufacturer = "ООО 3" },
                new Product { Name = "Морковь", Price = 20, Quantity = 45, Manufacturer = "ООО 4" }
            };
            who1 = who;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCatalog();
        }

        private void LoadCatalog()
        {
            catalogPanel.Controls.Clear();

            foreach (var product in products)
            {
                var panel = new Panel
                {
                    Width = 200,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var nameLabel = new Label { Text = product.Name, Dock = DockStyle.Top };
                var priceLabel = new Label { Text = $"Цена: {product.Price} руб.", Dock = DockStyle.Top };
                var quantityLabel = new Label { Text = $"Кол-во: {product.Quantity}", Dock = DockStyle.Top };

                panel.Controls.Add(quantityLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(nameLabel);

                catalogPanel.Controls.Add(panel);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            var lines = new List<string>();

            foreach (DataGridViewRow row in ordersDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                var name = row.Cells[0].Value.ToString();
                var price = row.Cells[1].Value.ToString();
                var pickupPoint = row.Cells[2].Value.ToString();
                var quantity = row.Cells[3].Value.ToString();

                lines.Add($"{name},{price},{pickupPoint},{quantity}");
            }

            File.WriteAllLines("orders.txt", lines);
            MessageBox.Show("Данные сохранены в файл orders.txt!");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            var lines = File.ReadAllLines("orders.txt");
            ordersDataGridView.Rows.Clear();

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 4)
                {
                    ordersDataGridView.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                }
            }

            MessageBox.Show("Данные загружены из файла orders.txt!");
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Manufacturer { get; set; }
    }
}
