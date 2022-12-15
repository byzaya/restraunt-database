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
				public partial class AddFoodToOrder : Form
				{
								DataBase dataBase = new DataBase();
								public AddFoodToOrder()
								{
												InitializeComponent();
												StartPosition = FormStartPosition.CenterScreen;
												this.MouseDown += new MouseEventHandler(Form1_MouseDown);
												comboBox6.SelectedItem = "1";
								}
								void Form1_MouseDown(object sender, MouseEventArgs e)
								{
												base.Capture = false;
												Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
												this.WndProc(ref m);
								}

								private void button1_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								private void button17_Click(object sender, EventArgs e) 
								{
												var idOrder = Int32.Parse(comboBox2.SelectedValue.ToString());
												var idFood = Int32.Parse(comboBox1.SelectedValue.ToString());
												var quantity = Int32.Parse(comboBox6.SelectedItem.ToString());
												var idSurname = Int32.Parse(comboBox3.SelectedValue.ToString());
												var idName = Int32.Parse(comboBox4.SelectedValue.ToString());
												var idPathername = Int32.Parse(comboBox5.SelectedValue.ToString());

												dataBase.openConnection();
												if (idSurname == idName && idName == idPathername && quantity > 0 && quantity < 21) {
																SqlCommand command = new SqlCommand("InpFoodOrder", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@OrderId", idOrder);
																command.Parameters.AddWithValue("@FoodId", idFood);
																command.Parameters.AddWithValue("@CookId", idName);
																command.Parameters.AddWithValue("@Quantity", quantity);

																if (command.ExecuteNonQuery() > 0)
																{
																				MessageBox.Show("Блюдо успешно добавлено в заказ", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																				
																}
																else
																{
																				MessageBox.Show("Не удалось добавить блюдо в заказ!");
																}
												}
												else
												{
																MessageBox.Show("Не удалось добавить блюдо в заказ!");
												}

												dataBase.closeConnection();

								}

								private void AddFoodToOrder_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet23.Employee". При необходимости она может быть перемещена или удалена.
												this.employeeTableAdapter1.Fill(this.restrauntDataSet23.Employee);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet22.Employee". При необходимости она может быть перемещена или удалена.
												this.employeeTableAdapter.Fill(this.restrauntDataSet22.Employee);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet21.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet21.Food);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet20.Orders". При необходимости она может быть перемещена или удалена.
												this.ordersTableAdapter.Fill(this.restrauntDataSet20.Orders);

								}

				}
}
