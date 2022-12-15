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
				public partial class ChangeIngr : Form
				{
								DataBase dataBase = new DataBase();
								public ChangeIngr()
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

								private void ChangeIngr_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet15.Storage". При необходимости она может быть перемещена или удалена.
												this.storageTableAdapter.Fill(this.restrauntDataSet15.Storage);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet14.Ingredient". При необходимости она может быть перемещена или удалена.
												this.ingredientTableAdapter.Fill(this.restrauntDataSet14.Ingredient);

								}

								private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
								{
												var idIngr = Int32.Parse(comboBox1.SelectedValue.ToString());

												SqlDataAdapter adapter = new SqlDataAdapter();
												DataTable table = new DataTable();

												string querystring = $"select * from Ingredient where IdIngregient = '{idIngr}'";
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
																				textBox10.Text = comboBox1.Text;
																				var price = reader[3].ToString();
																				price = price.Substring(0, price.Length - 5);
																				textBox3.Text = price; 
																				textBox2.Text = reader[4].ToString();
																				textBox4.Text = reader[5].ToString();
																				if (Int32.Parse(reader[1].ToString()) < 6)
																				{
																								comboBox5.SelectedIndex = Int32.Parse(reader[1].ToString()) - 1;
																				}
																				else if (Int32.Parse(reader[1].ToString()) == 1002)
																				{
																								comboBox5.SelectedIndex = 5;
																				}
																				else if (Int32.Parse(reader[1].ToString()) == 1003)
																				{
																								comboBox5.SelectedIndex = 6;
																				}
																}
																dataBase.getConnection().Close();
												}
												dataBase.getConnection().Close();
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

								private void button7_Click(object sender, EventArgs e)
								{
												textBox10.MaxLength = 50;
												textBox4.MaxLength = 10;
												
												var id = Int32.Parse(comboBox1.SelectedValue.ToString());
												var name = textBox10.Text;
												var storage = Int32.Parse(comboBox5.SelectedValue.ToString());
												var price = textBox3.Text;
												var quantity = textBox2.Text;
												var unit = textBox4.Text;
												dataBase.openConnection();
												if (unit.Length < 10 && StringIsDigits(price) && StringIsDigits(quantity) && name!="" && price !="" && quantity !="" && unit !="") 
												{
																SqlCommand command = new SqlCommand("ChangeIngr", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@Id", id);
																command.Parameters.AddWithValue("@StorageId", storage);
																command.Parameters.AddWithValue("@Name", name);
																command.Parameters.AddWithValue("@Price", price);
																command.Parameters.AddWithValue("@Quantity", quantity);
																command.Parameters.AddWithValue("@Unit", unit);
																if (command.ExecuteNonQuery() == 1)
																{
																				MessageBox.Show("Ингредиент успешно изменен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																}
																else
																{
																				MessageBox.Show("Не удалось изменить данные!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось изменить данные! Введен неверный формат данных ");
												}
												dataBase.closeConnection();
								}
				}
}
