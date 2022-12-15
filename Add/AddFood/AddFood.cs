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
				public partial class AddFood : Form
				{
								DataBase dataBase = new DataBase();
								public AddFood()
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

								private void button2_Click(object sender, EventArgs e)
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


								private void button7_Click(object sender, EventArgs e)
								{
												textBox10.MaxLength = 50;
												var name = textBox10.Text;
												var costprice = textBox3.Text;
												var price = textBox1.Text;

												dataBase.openConnection();
												if (StringIsDigits(costprice) && StringIsDigits(price) && name !="" && price !="" && costprice!="")
												{
																SqlCommand command = new SqlCommand("AddFoodToMenu", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@Name", name);
																command.Parameters.AddWithValue("@CostPrice", costprice);
																command.Parameters.AddWithValue("@Price", price);

																if (command.ExecuteNonQuery() == 1)
																{
																				MessageBox.Show("Блюдо успешно добавлено в меню", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																}
																else
																{
																				MessageBox.Show("Не удалось добавить блюдо в меню!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось добавить блюдо в меню! Неверный формат ввода данныхы");
												}
												dataBase.closeConnection();
								}

								private void AddFood_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet16.Ingredient". При необходимости она может быть перемещена или удалена.
												this.ingredientTableAdapter.Fill(this.restrauntDataSet16.Ingredient);

								}
				}
}
