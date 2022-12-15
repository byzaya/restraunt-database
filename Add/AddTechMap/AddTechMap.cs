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
				public partial class AddTechMap : Form
				{
								DataBase dataBase = new DataBase();
								public AddTechMap()
								{
												InitializeComponent();
												StartPosition = FormStartPosition.CenterScreen;
												this.MouseDown += new MouseEventHandler(Form1_MouseDown);
												textBox2.Text = "1";
								}
								void Form1_MouseDown(object sender, MouseEventArgs e)
								{
												base.Capture = false;
												Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
												this.WndProc(ref m);
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

								private void button1_Click(object sender, EventArgs e) //добавление
								{
												var idFood = Int32.Parse(comboBox2.SelectedValue.ToString());
												var idIng = Int32.Parse(comboBox1.SelectedValue.ToString());
												var quantity = textBox2.Text;
												var unit = comboBox5.SelectedItem.ToString();
												dataBase.openConnection();
												if (StringIsDigits(quantity) && quantity != "") {
																SqlCommand command = new SqlCommand("AddTechMap", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@FoodId", idFood);
																command.Parameters.AddWithValue("@IngredientId", idIng);
																command.Parameters.AddWithValue("@Quantity", quantity);
																command.Parameters.AddWithValue("@Unit", unit);

																if (command.ExecuteNonQuery() == 1)
																{
																				MessageBox.Show("Ингредиент успешно добавлен в тех карту блюда", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																}
																else
																{
																				MessageBox.Show("Не удалось добавить ингредиент в тех карту!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось добавить ингредиент в тех карту! Неверный формат количества");
												}

												dataBase.closeConnection();
								}

								private void button2_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								private void AddTechMap_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet18.Ingredient". При необходимости она может быть перемещена или удалена.
												this.ingredientTableAdapter.Fill(this.restrauntDataSet18.Ingredient);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet17.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet17.Food);

								}

								private void button3_Click(object sender, EventArgs e) //удаление
								{
											 var idFood = Int32.Parse(comboBox3.SelectedValue.ToString());
												var idIng = Int32.Parse(comboBox4.SelectedValue.ToString());

											 dataBase.openConnection();
												SqlCommand command = new SqlCommand("DelTechMap", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@IdFood", idFood);
												command.Parameters.AddWithValue("@IdIng", idIng);
												command.ExecuteNonQuery();
												if (command.ExecuteNonQuery() > 0)
												{
																MessageBox.Show("Удаление успешно!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												else
												{
																MessageBox.Show("Удаление не выполнилось!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												dataBase.closeConnection();
								}
				}
}
