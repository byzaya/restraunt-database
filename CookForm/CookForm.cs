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
				public partial class CookForm : Form
				{
								DataBase dataBase = new DataBase();
								Hash hash = new Hash();
								private int idCook;
								private string surnameCook;
								private string nameCook;
								private string pathernameCook;
								private string phoneCook;
								private string loginCook;
								private string passwordCook;
								public int IdCook
								{
												get { return idCook; }
												set { idCook = value; }
								}
								public string SurnameCook
								{
												get { return surnameCook; }
												set { surnameCook = value; }
								}
								public string NameCook
								{
												get { return nameCook; }
												set { nameCook = value; }
								}
								public string PathernameCook
								{
												get { return pathernameCook; }
												set { pathernameCook = value; }
								}
								public string PhoneCook
								{
												get { return phoneCook; }
												set { phoneCook = value; }
								}
								public string LoginCook
								{
												get { return loginCook; }
												set { loginCook = value; }
								}

								public string PasswordCook
								{
												get { return passwordCook; }
												set { passwordCook = value; }
								}

								public CookForm()
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

								private void CookForm_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet4.Storage". При необходимости она может быть перемещена или удалена.
												this.storageTableAdapter.Fill(this.restrauntDataSet4.Storage);
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet3.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet3.Food);

								}

								private void button3_Click(object sender, EventArgs e) //все заказы повара
								{
												SqlCommand command = new SqlCommand("OrdersCook", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Id", IdCook);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView1.DataSource = dataTable;
								}

								private void button24_Click(object sender, EventArgs e) //вывод всех ингредиентов на опр. складе
								{
												var id = Int32.Parse(comboBox2.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("OutputIngrFromStorage", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@Id", id);
												SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
												DataTable dataTable = new DataTable();
												dataAdapter.Fill(dataTable);
												dataGridView3.DataSource = dataTable;
								}

								private void button1_Click(object sender, EventArgs e) //ингредиенты блюда
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

								private void button5_Click(object sender, EventArgs e) //удаление ингредиента
								{
												DelIngr deling = new DelIngr();
												deling.ShowDialog();
								}

								private void button23_Click(object sender, EventArgs e) //добавление ингредиента
								{
												AddIngr ingr = new AddIngr();
												ingr.ShowDialog();
								}

								private void tabPage3_Click(object sender, EventArgs e) //просмотр личных данных
								{
												textBox1.Text = SurnameCook;
												textBox2.Text = NameCook;
												textBox3.Text = PathernameCook;
												textBox4.Text = PhoneCook;
												textBox5.Text = LoginCook;
												//textBox6.Text = PasswordCook;
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
																				command.Parameters.AddWithValue("@IdEmploy", idCook);
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

								private void button25_Click(object sender, EventArgs e)
								{
												ChangeIngr change = new ChangeIngr();
												change.ShowDialog();
								}
				}
}
