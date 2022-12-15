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
				public partial class WaiterForm : Form
				{
								DataBase dataBase = new DataBase();
								Hash hash = new Hash();
								private int idWaiter;
								private string surnameWaiter;
								private string nameWaiter;
								private string pathernameWaiter;
								private string phoneWaiter;
								private string loginWaiter;
								private string passwordWaiter;

								public int IdWaiter
								{
												get { return idWaiter; }
												set { idWaiter = value; }
								}
								public string SurnameWaiter
								{
												get { return surnameWaiter; }
												set { surnameWaiter = value; }
								}
								public string NameWaiter
								{
												get { return nameWaiter; }
												set { nameWaiter = value; }
								}
								public string PathernameWaiter
								{
												get { return pathernameWaiter; }
												set { pathernameWaiter = value; }
								}
								public string PhoneWaiter
								{
												get { return phoneWaiter; }
												set { phoneWaiter = value; }
								}
								public string LoginWaiter
								{
												get { return loginWaiter; }
												set { loginWaiter = value; }
								}
								public string PasswordWaiter
								{
												get { return passwordWaiter; }
												set { passwordWaiter = value; }
								}

								public WaiterForm()
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

								private void buttonExitWaiter_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								private void button1_Click(object sender, EventArgs e) //меню
								{
												SqlCommand command = new SqlCommand("EXEC Menu", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridViewWaiter.DataSource = dataTable;
								}

								private void button3_Click(object sender, EventArgs e) //все заказы официанта
								{
												SqlCommand command = new SqlCommand("OrdersWaiter", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Id", IdWaiter);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView1.DataSource = dataTable;
								}

								private void WaiterForm_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet2.Orders". При необходимости она может быть перемещена или удалена.
												this.ordersTableAdapter.Fill(this.restrauntDataSet2.Orders);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet1.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter1.Fill(this.restrauntDataSet1.Food);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet.Food);

								}

								private void button4_Click(object sender, EventArgs e) //изменение статуса заказа 
								{
												var id = Int32.Parse(comboBox2.SelectedValue.ToString());
												var status = comboBox6.SelectedItem.ToString();
												SqlCommand command = new SqlCommand("ChangeStatus", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Status", status);
												command.Parameters.AddWithValue("@Id", id);
												dataBase.openConnection();
												if (command.ExecuteNonQuery() == 1)
												{
																MessageBox.Show("Статус заказа успешно изменен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												else
												{
																MessageBox.Show("Не удалось изменить данные!");
												}

								}

								private void button6_Click(object sender, EventArgs e) //все блюда в заказе
								{
												var id = Int32.Parse(comboBox3.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("AllFoodOrder", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@IdOrders", id);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView3.DataSource = dataTable;
								}

								private void button7_Click(object sender, EventArgs e) //ингредиенты блюда
								{
												var id = Int32.Parse(comboBox1.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("OutputIngrFoodId", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Id", id);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView4.DataSource = dataTable;
								}

								private void tabPage3_Click(object sender, EventArgs e) //просмотр личных данных
								{
												textBox1.Text = SurnameWaiter;
												textBox2.Text = NameWaiter;
												textBox3.Text = PathernameWaiter;
												textBox4.Text = PhoneWaiter;
												textBox5.Text = LoginWaiter;
											//	textBox6.Text = PasswordWaiter;
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

								private void button2_Click(object sender, EventArgs e) //изменение личных данных
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
												var phone = textBox4.Text;
												var login = textBox5.Text;
												var password = hash.GetHash(textBox6.Text);
												SqlDataAdapter adapter = new SqlDataAdapter();
												DataTable table = new DataTable();

												string querystring = $"select * from Employee where Login = '{login}'";
												SqlCommand comm = new SqlCommand(querystring, dataBase.getConnection());

												dataBase.getConnection().Open();
												adapter.SelectCommand = comm;
												adapter.Fill(table);
												

																if (login.Length > 5 && password.Length > 5 && phone.Length == 11 && StringIsDigits(phone) && surname != "" && name != "" && pathername != "")
																{

																				SqlCommand command = new SqlCommand("ChangePerconalData", dataBase.getConnection());
																				command.CommandType = CommandType.StoredProcedure;
																				command.Parameters.AddWithValue("@IdEmploy", idWaiter);
																				command.Parameters.AddWithValue("@Surname", surname);
																				command.Parameters.AddWithValue("@Name", name);
																				command.Parameters.AddWithValue("@Pathername", pathername);
																				command.Parameters.AddWithValue("@Phone", phone);
																				command.Parameters.AddWithValue("@Login", login);
																				command.Parameters.AddWithValue("@Password", password);
																				dataBase.openConnection();
																				if (command.ExecuteNonQuery() == 1)
																				{
																								MessageBox.Show("Личные данные успешно изменены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
																				}
																				else
																				{
																								MessageBox.Show("Не удалось изменить данные!");
																				}
																}
																else
																{
																				MessageBox.Show("Не удалось изменить данные! Минимальная длина логина и пароля - 6. Формат номера телефона 80000000000");
																}
												
												dataBase.closeConnection();
								}

								private void button9_Click(object sender, EventArgs e) //добавление блюда в заказ
								{
												AddFoodToOrder add = new AddFoodToOrder();
												add.ShowDialog();
								}

								private void button8_Click(object sender, EventArgs e) //TODO удаление блюда из заказа ДОБАВИТЬ ПРОВЕРКУ НА СУЩЕСТВОВАНИЕ БЛЮДА В ЗАКАЗЕ
								{
												dataBase.openConnection();
												var idOrder = Int32.Parse(comboBox4.SelectedValue.ToString());
												var idFood = Int32.Parse(comboBox5.SelectedValue.ToString());

												SqlCommand command = new SqlCommand("DeleteFoodFromOrder", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@IdFood", idFood);
												command.Parameters.AddWithValue("@IdOrder", idOrder);
												command.ExecuteNonQuery();
												//if (command.ExecuteNonQuery() == 1)
												//{
												//				MessageBox.Show("Удаление не выполнилось!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												//}
												//else
												//{
												//				MessageBox.Show("Удаление успешно!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												//}
												dataBase.closeConnection();
								}

								private void button5_Click(object sender, EventArgs e)
								{
												AddOrder order = new AddOrder();
												order.ShowDialog();
								}
				}
}
