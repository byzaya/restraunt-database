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
				public partial class AddIngr : Form
				{
								DataBase dataBase = new DataBase();
								public AddIngr()
								{
												InitializeComponent();
												StartPosition = FormStartPosition.CenterScreen;
												this.MouseDown += new MouseEventHandler(Form1_MouseDown);
												comboBox1.SelectedItem = "кг";
												textBox2.Text = "1";
								}
								void Form1_MouseDown(object sender, MouseEventArgs e)
								{
												base.Capture = false;
												Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
												this.WndProc(ref m);
								}

								private void AddIngr_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet13.Storage". При необходимости она может быть перемещена или удалена.
												this.storageTableAdapter.Fill(this.restrauntDataSet13.Storage);

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
												var idStorage = Int32.Parse(comboBox5.SelectedValue.ToString());
												var price = textBox3.Text;
												var quantity = textBox2.Text;
												var unit = comboBox1.SelectedItem.ToString();
												dataBase.openConnection();
												if (StringIsDigits(price) && StringIsDigits(quantity) && name != "" && quantity != "" && price !="") {
																SqlCommand command = new SqlCommand("AddIngr", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@StorageId", idStorage);
																command.Parameters.AddWithValue("@Name", name);
																command.Parameters.AddWithValue("@Price", price);
																command.Parameters.AddWithValue("@Quantity", quantity);
																command.Parameters.AddWithValue("@Unit", unit);

																if (command.ExecuteNonQuery() == 1)
																{
																				MessageBox.Show("Ингредиент успешно добавлен на склад", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																}
																else
																{
																				MessageBox.Show("Не удалось добавить ингредиент!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось добавить ингредиент!");
												}
												dataBase.closeConnection();
								}

								private void CloseButton_Click(object sender, EventArgs e)
								{
												this.Hide();
								}
				}
}
