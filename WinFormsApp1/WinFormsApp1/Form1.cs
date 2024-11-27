using System.Reflection;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool who;
        bool length;
        bool empty;
        bool symbol;
        public Form1()
        {
            InitializeComponent();
            Buyer.Visible = true;
            dealer.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox2.UseSystemPasswordChar = true;
        }



        private void Buyer_Click(object sender, EventArgs e)
        {
            Buyer.Visible = false;
            dealer.Visible = false;
            who = true;
        }



        private void dealer_Click(object sender, EventArgs e)
        {
            Buyer.Visible = false;
            dealer.Visible = false;
            who = false;
        }



        private void RegBut_Click(object sender, EventArgs e)
        {
            empty = true;
            symbol = true;
            length = true;


            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("������ ������ ��������� �� ����� 8 ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                length = false;
            }

            if (textBox2.Text.Contains(" "))
            {
                MessageBox.Show("������ �� ������ ��������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                empty = false;
            }



            var specialChars = "!��;@%;?:";
            if (!textBox2.Text.Any(char.IsUpper) || !textBox2.Text.Any(char.IsLower) || !textBox2.Text.Any(char.IsDigit) || !textBox2.Text.Any(c => specialChars.Contains(c)))
            {
                MessageBox.Show("������ ������ ��������� �����, ����� ������� �������� � ���� �� ���� ���������� (!��;@%;?:).", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                symbol = false;
            }


            if (textBox1.Text != null && textBox2.Text != null)
            {
                string alltext = textBox1.Text + " " + textBox2.Text + "\n";
                if (who == true)
                {
                    if (File.Exists("Users.txt"))
                    {
                        string fileText = File.ReadAllText("Users.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1)
                        {
                            MessageBox.Show("������������ � ����� ������ ��� ����������");
                        }
                        else if (IsValidEmail(textBox1.Text) && length != false && empty != false && symbol != false)
                        {
                            MessageBox.Show("����� ������������ ��������");
                            File.AppendAllText("Users.txt", alltext);
                        }
                    }
                }
                else if (who == false)
                {
                    if (File.Exists("Dealers.txt"))
                    {
                        string fileText = File.ReadAllText("Dealers.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1)
                        {
                            MessageBox.Show("������������ � ����� ������ ��� ����������");
                        }
                        else if (IsValidEmail(textBox1.Text) && length != false && empty != false && symbol != false)
                        {
                            MessageBox.Show("����� ������������ ��������");
                            File.AppendAllText("Dealers.txt", alltext);
                        }

                    }
                }
            }
        }



        private void EntraceBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                string alltext = textBox1.Text + " " + textBox2.Text + "\n";
                if (who == true)
                {
                    if (File.Exists("Users.txt"))
                    {
                        string fileText = File.ReadAllText("Users.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1)
                        {
                            if (fileText.Contains(alltext))
                            {
                                MessageBox.Show("�� �����");
                                Form2 f = new Form2(who);
                                this.Hide();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("�� ������ ����� ��� ������");
                            }
                        }
                        else
                        {
                            MessageBox.Show("������������ � ����� ������ �� ����������");
                        }
                    }
                }
                else if (who == false)
                {
                    if (File.Exists("Dealers.txt"))
                    {
                        string fileText = File.ReadAllText("Dealers.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1)
                        {
                            if (fileText.Contains(alltext))
                            {
                                MessageBox.Show("�� �����");
                                Form2 f = new Form2(who);
                                this.Hide();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("�� ������ ����� ��� ������");
                            }
                        }
                        else
                        {
                            MessageBox.Show("������������ � ����� ������ �� ����������");
                        }
                    }
                }
            }
        }



        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                MessageBox.Show("���� �����");
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("�������� �����");
                return false;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }




    }
}
