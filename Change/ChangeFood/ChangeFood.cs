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
				public partial class ChangeFood : Form
				{
								DataBase dataBase = new DataBase();
								public ChangeFood()
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

								private void ChangeFood_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet19.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet19.Food);

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
												var idFood = Int32.Parse(comboBox4.SelectedValue.ToString());
												var name = textBox10.Text;
												var costprice = textBox3.Text;
												var price = textBox1.Text;
												dataBase.openConnection();
												if (StringIsDigits(costprice) && StringIsDigits(price) && name != "" && costprice != "" && price !="") {
																SqlCommand command = new SqlCommand("ChangeFood", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@Id", idFood);
																command.Parameters.AddWithValue("@Name", name);
																command.Parameters.AddWithValue("@CostPrice", costprice);
																command.Parameters.AddWithValue("@Price", price);
																if (command.ExecuteNonQuery() == 1)
																{
																				MessageBox.Show("Блюдо успешно изменено", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																}
																else
																{
																				MessageBox.Show("Не удалось изменить данные!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось изменить данные! Введен неверный формат данных");
												}
												dataBase.closeConnection();

								}

								private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
								{
												var idFood = Int32.Parse(comboBox4.SelectedValue.ToString());
												SqlDataAdapter adapter = new SqlDataAdapter();
												DataTable table = new DataTable();

												string querystring = $"select * from Food where IdFood = '{idFood}'";
												SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

												dataBase.getConnection().Open();
												adapter.SelectCommand = command;
												adapter.Fill(table);
												SqlDataReader reader = command.ExecuteReader();

												if (table.Rows.Count == 1)
												{
																if (reader.HasRows)
																{
																				reader.Read();
																				textBox10.Text = comboBox4.Text; 
																				var costprice = reader[2].ToString();
																				costprice = costprice.Substring(0, costprice.Length - 5);
																				textBox3.Text = costprice;
																				var price = reader[3].ToString();
																				price = price.Substring(0, price.Length - 5);
																				textBox1.Text = price;
																}
																dataBase.getConnection().Close();
												}
												dataBase.getConnection().Close();
								}
				}
}
