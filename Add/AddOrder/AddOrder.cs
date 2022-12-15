using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursDB
{
				public partial class AddOrder : Form
				{
								DataBase dataBase = new DataBase();
								public AddOrder()
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

								private void AddOrder_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet24.Employee". При необходимости она может быть перемещена или удалена.
												this.employeeTableAdapter.Fill(this.restrauntDataSet24.Employee);

								}

								private void button1_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								private void button2_Click(object sender, EventArgs e)
								{
												AddFoodToOrder food = new AddFoodToOrder();
												food.ShowDialog();
								}
								private string patternForDataTime = @"\d{2}.\d{2}.\d{4} \d{2}:\d{2}";
								private bool isValidDataTime(string input)
								{
												if (input.Contains(":"))
												{
																return Regex.IsMatch(input, patternForDataTime);
												}
												else
												{
																return false;
												}
								}
								private void button17_Click(object sender, EventArgs e)
								{
												var idSurname = Int32.Parse(comboBox3.SelectedValue.ToString());
												var idName = Int32.Parse(comboBox4.SelectedValue.ToString());
												var idPathername = Int32.Parse(comboBox5.SelectedValue.ToString());
												var table = Int32.Parse(comboBox1.SelectedItem.ToString());
												var date = textBox1.Text;
												var status = comboBox2.SelectedItem.ToString();

												dataBase.openConnection();
												if (idSurname == idName && idName == idPathername && date !="" && isValidDataTime(date))
												{
																SqlCommand command = new SqlCommand("InpOrder", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@WaiterId", idName);
																command.Parameters.AddWithValue("@TableNumber", table);
																command.Parameters.AddWithValue("@DateTime", date);
																command.Parameters.AddWithValue("@Status", status);

																if (command.ExecuteNonQuery() > 0)
																{
																				MessageBox.Show("Заказ успешно сформирован", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																}
																else
																{
																				MessageBox.Show("Не удалось сформировать заказ!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось сформировать заказ! Введен неверный формат данных");
												}

												dataBase.closeConnection();
								}
				}
}
