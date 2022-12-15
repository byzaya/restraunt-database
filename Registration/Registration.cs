using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursDB
{
				public partial class Registration : Form
				{
								DataBase dataBase = new DataBase();
								Hash hash = new Hash();
								public Registration()
								{
												InitializeComponent();
												StartPosition = FormStartPosition.CenterScreen;
												this.MouseDown += new MouseEventHandler(Form1_MouseDown);
								}
								void Form1_MouseDown(object sender, MouseEventArgs e)
								{
												base.Capture = false;
												Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
												this.WndProc(ref m);
								}

								private void CloseButton_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								bool StringIsDigits(string s)
								{
												foreach (var item in s)
												{
																if (!char.IsDigit(item))
																				return false; //если хоть один символ не число, то выкидываешь "ложь"
												}
												return true; //если ни разу не выбило в цикле, значит, все символы - это цифры
								}

								private void button2_Click(object sender, EventArgs e)
								{
												textBox1.MaxLength = 50;
												textBox2.MaxLength = 50;
												textBox3.MaxLength = 50;
												textBox4.MaxLength = 11;
												textBox5.MaxLength = 20;
												textBox6.MaxLength = 50;

												var surname = textBox1.Text;
												var name = textBox2.Text;
												var pathername = textBox3.Text;
												var idRole = Int32.Parse(comboBox3.SelectedValue.ToString());
												var phone = textBox4.Text;
												var login = textBox5.Text;
												var password = hash.GetHash(textBox6.Text);
												
												dataBase.openConnection();
												SqlCommand comma = new SqlCommand("Registration", dataBase.getConnection());
												comma.CommandType = CommandType.StoredProcedure;
												comma.Parameters.AddWithValue("@Surname", surname);
												comma.Parameters.AddWithValue("@Name", name);
												comma.Parameters.AddWithValue("@Pathername", pathername);
												comma.Parameters.AddWithValue("@RoleId", idRole);
												comma.Parameters.AddWithValue("@Phone", phone);
												comma.Parameters.AddWithValue("@Login", login);
												comma.Parameters.AddWithValue("@Password", password);
												if (comma.ExecuteNonQuery() == 1)
												{
																MessageBox.Show("Сотрудник успешно зарегестрирован", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												else
												{
																MessageBox.Show("Не удалось загрегестрировать !");
												}

												dataBase.closeConnection();

								}

								private void Registration_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet12.Role". При необходимости она может быть перемещена или удалена.
												this.roleTableAdapter.Fill(this.restrauntDataSet12.Role);

								}
				}
}
