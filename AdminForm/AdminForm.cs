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
				public partial class AdminForm : Form
				{
								DataBase dataBase = new DataBase();
								Hash hash = new Hash();
								private int idAdmin;
								private string surnameAdmin;
								private string nameAdmin;
								private string pathernameAdmin;
								private string phoneAdmin;
								private string loginAdmin;
								private string passwordAdmin;

								public int IdAdmin
								{
												get { return idAdmin; }
												set { idAdmin = value; }
								}
								public string SurnameAdmin
								{
												get { return surnameAdmin; }
												set { surnameAdmin = value; }
								}
								public string NameAdmin
								{
												get { return nameAdmin; }
												set { nameAdmin = value; }
								}
								public string PathernameAdmin
								{
												get { return pathernameAdmin; }
												set { pathernameAdmin = value; }
								}
								public string PhoneAdmin
								{
												get { return phoneAdmin; }
												set { phoneAdmin = value; }
								}
								public string LoginAdmin
								{
												get { return loginAdmin; }
												set { loginAdmin = value; }
								}
								public string PasswordAdmin
								{
												get { return passwordAdmin; }
												set { passwordAdmin = value; }
								}

								public AdminForm()
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

								private void buttonExit_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								private void button7_Click(object sender, EventArgs e) //меню
								{
												SqlCommand command = new SqlCommand("EXEC Menu", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView4.DataSource = dataTable;
								}

								private void button20_Click(object sender, EventArgs e) //список всех заказов
								{
												SqlCommand command = new SqlCommand("EXEC AllOrdersProc", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView1.DataSource = dataTable;
								}

								private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
								{

								}

								private void AdminForm_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet8.Storage". При необходимости она может быть перемещена или удалена.
												this.storageTableAdapter.Fill(this.restrauntDataSet8.Storage);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet7.Ingredient". При необходимости она может быть перемещена или удалена.
												this.ingredientTableAdapter.Fill(this.restrauntDataSet7.Ingredient);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet6.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet6.Food);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet5.Orders". При необходимости она может быть перемещена или удалена.
												this.ordersTableAdapter.Fill(this.restrauntDataSet5.Orders);

								}

								private void button18_Click(object sender, EventArgs e) //все блюда в заказе
								{
												var id = Int32.Parse(comboBox3.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("AllFoodOrder", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@IdOrders", id);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView9.DataSource = dataTable;
								}

								private void button14_Click(object sender, EventArgs e) //ингредиенты блюда
								{
												var id = Int32.Parse(comboBox4.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("OutputIngrFoodId", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Id", id);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView8.DataSource = dataTable;
								}

								private void button24_Click(object sender, EventArgs e) //ингредиенты на опр. складе
								{
												var id = Int32.Parse(comboBox5.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("OutputIngrFromStorage", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Id", id);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView10.DataSource = dataTable;
								}

								private void button1_Click(object sender, EventArgs e) //список всех сотрудников
								{
												SqlCommand command = new SqlCommand("EXEC PerconalDataEmployees", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView3.DataSource = dataTable;

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

								private void button4_Click(object sender, EventArgs e) //выручка
								{
												var start = textBox8.Text;
												var end = textBox7.Text;
												dataBase.openConnection();
												if (start != "" && end != "" && isValidDataTime(start) && isValidDataTime(end))
												{
																SqlCommand command = new SqlCommand("Vyruchka", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@starting_period", start);
																command.Parameters.AddWithValue("@end_period", end);
																SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
																DataTable dataTable = new DataTable();
																dataAdapter.Fill(dataTable);
																dataGridView5.DataSource = dataTable;
												}
												else
												{
																MessageBox.Show("Введен неверный формат даты и времени! Введите в формате дд.мм.гггг чч:мм");
												}
												dataBase.closeConnection();
								}

								private void button5_Click(object sender, EventArgs e) //прибыль
								{
												var start = textBox18.Text;
												var end = textBox17.Text;
												dataBase.openConnection();
												if (start != "" && end != "" && isValidDataTime(start) && isValidDataTime(end))
												{
																SqlCommand command = new SqlCommand($"DECLARE @Prof money EXECUTE GetProfit @Begin = '{start}', @End = '{end}', @Profit = @Prof output SELECT @Prof AS 'Прибыль'", dataBase.getConnection());
																SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
																DataTable dataTable = new DataTable();
																dataAdapter.Fill(dataTable);
																dataGridView11.DataSource = dataTable;
												}
												else
												{
																MessageBox.Show("Введен неверный формат даты и времени! Введите в формате дд.мм.гггг чч:мм");
												}
												dataBase.closeConnection();
								}

								private void button11_Click(object sender, EventArgs e) // лучший официант
								{
												SqlCommand command = new SqlCommand("BestWaiter", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView7.DataSource = dataTable;
								}

								private void button10_Click(object sender, EventArgs e) // лучший повар
								{
												SqlCommand command = new SqlCommand("BestCook", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView7.DataSource = dataTable;
								}

								private void button6_Click(object sender, EventArgs e) //популярная позиция в меню
								{
												SqlCommand command = new SqlCommand("BestFood", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView6.DataSource = dataTable;
								}

								private void button8_Click(object sender, EventArgs e) //непопулярная позиция в меню
								{
												SqlCommand command = new SqlCommand("WorstFood", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView6.DataSource = dataTable;
								}

								private void button9_Click(object sender, EventArgs e) //топ 5 блюд
								{
												SqlCommand command = new SqlCommand("Top5Food", dataBase.getConnection());
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView6.DataSource = dataTable;
								}

								private void button22_Click(object sender, EventArgs e) //удаление ингредиента
								{
												DelIngr deling = new DelIngr();
												deling.ShowDialog();
								}

								private void button19_Click(object sender, EventArgs e) //изменение статуса заказа
								{
												var id = Int32.Parse(comboBox2.SelectedValue.ToString());
												var status = comboBox7.SelectedItem.ToString();
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
												dataBase.closeConnection();
								}

								private void button15_Click(object sender, EventArgs e) //удаление блюда из меню
								{
												DelFood del = new DelFood();
												del.ShowDialog();
								}

								private void button13_Click(object sender, EventArgs e) //увольнение сотрудника
								{
												DelEmployee del = new DelEmployee();
												del.ShowDialog();
								}

								private void button12_Click(object sender, EventArgs e) //регистрация сотрудника
								{
												Registration registration = new Registration();
												registration.ShowDialog();
								}

								private void button23_Click(object sender, EventArgs e) //добавление ингредиента
								{
												AddIngr ingr = new AddIngr();
												ingr.Show();
								}

								private void tabPage3_Click(object sender, EventArgs e) //просмотр личных данных
								{
												textBox1.Text = SurnameAdmin;
												textBox2.Text = NameAdmin;
												textBox3.Text = PathernameAdmin;
												textBox4.Text = PhoneAdmin;
												textBox5.Text = LoginAdmin;
												//textBox6.Text = PasswordAdmin;
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
																				command.Parameters.AddWithValue("@IdEmploy", idAdmin);
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

								private void button25_Click(object sender, EventArgs e) //изменение ингредиента
								{
												ChangeIngr change = new ChangeIngr();
												change.ShowDialog();
								}

								private void button16_Click(object sender, EventArgs e) //добавление блюда в меню
								{
												AddFood add = new AddFood();
												add.ShowDialog();
								}

								private void button27_Click(object sender, EventArgs e) //формирование тех карты блюда
								{
												AddTechMap map = new AddTechMap();
												map.ShowDialog();
								}

								private void button26_Click(object sender, EventArgs e) //изменение блюда
								{
												ChangeFood food = new ChangeFood();
												food.ShowDialog();
								}

								private void button17_Click(object sender, EventArgs e) //удаление блюда 
								{
												dataBase.openConnection();
												var idOrder = Int32.Parse(comboBox1.SelectedValue.ToString());
												var idFood = Int32.Parse(comboBox6.SelectedValue.ToString());

												SqlCommand command = new SqlCommand("DeleteFoodFromOrder", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@IdFood", idFood);
												command.Parameters.AddWithValue("@IdOrder", idOrder);
												command.ExecuteNonQuery();
												
												//if (command.ExecuteNonQuery() > 0)
												//{
												//				MessageBox.Show("Удаление успешно!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												//}
												//else
												//{
												//				MessageBox.Show("Удаление не выполнилось!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												//}
												dataBase.closeConnection();
								}

								private void button21_Click(object sender, EventArgs e) //добавление блюда в заказ 
								{
												AddFoodToOrder add = new AddFoodToOrder();
												add.ShowDialog();
								}

								private void button3_Click(object sender, EventArgs e) // формирование заказа
								{
												AddOrder order = new AddOrder();
												order.ShowDialog();
								}

								
				}
}
