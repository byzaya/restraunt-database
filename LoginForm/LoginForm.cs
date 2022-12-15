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
				public partial class LoginForm : Form
				{
								DataBase dataBase = new DataBase();

								Hash hash = new Hash();

								public LoginForm()
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

								private void AuthButton_Click(object sender, EventArgs e)
								{
												LoginField.MaxLength = 20;
												PasswordField.MaxLength = 50;
												var loginUser = LoginField.Text;
												var passwordUser = hash.GetHash(PasswordField.Text);

												SqlDataAdapter adapter = new SqlDataAdapter();
												DataTable table = new DataTable();

												string querystring = $"select * from Employee where Login = '{loginUser}' and Password = '{passwordUser}'";
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
																				if (reader[4].ToString() == "3")
																				{
																								CookForm form2 = new CookForm();
																								form2.IdCook = Int32.Parse(reader[0].ToString());
																								form2.SurnameCook = reader[1].ToString();
																								form2.NameCook = reader[2].ToString();
																								form2.PathernameCook = reader[3].ToString();
																								form2.PhoneCook = reader[5].ToString();
																								form2.LoginCook = reader[6].ToString();
																								form2.PasswordCook = reader[7].ToString();
																								this.Hide();
																								form2.ShowDialog();
																								LoginField.Clear();
																								PasswordField.Clear();
																								this.Show();
																				}
																				else if (reader[4].ToString() == "2")
																				{
																								WaiterForm form2 = new WaiterForm();
																								form2.IdWaiter = Int32.Parse(reader[0].ToString());
																								form2.SurnameWaiter = reader[1].ToString();
																								form2.NameWaiter = reader[2].ToString();
																								form2.PathernameWaiter = reader[3].ToString();
																								form2.PhoneWaiter = reader[5].ToString();
																								form2.LoginWaiter = reader[6].ToString();
																								form2.PasswordWaiter = reader[7].ToString();
																								this.Hide();
																								form2.ShowDialog();
																								LoginField.Clear();
																								PasswordField.Clear();
																								this.Show();
																				}
																				else if (reader[4].ToString() == "1")
																				{
																								AdminForm form2 = new AdminForm();
																								form2.IdAdmin = Int32.Parse(reader[0].ToString());
																								form2.SurnameAdmin = reader[1].ToString();
																								form2.NameAdmin = reader[2].ToString();
																								form2.PathernameAdmin = reader[3].ToString();
																								form2.PhoneAdmin = reader[5].ToString();
																								form2.LoginAdmin = reader[6].ToString();
																								form2.PasswordAdmin = reader[7].ToString();
																								this.Hide();
																								form2.ShowDialog();
																								LoginField.Clear();
																								PasswordField.Clear();
																								this.Show();
																				}
																				else
																				{
																								MessageBox.Show("У вас нет доступа в личный кабинет.");
																								LoginField.Clear();
																								PasswordField.Clear();
																				}
																				dataBase.getConnection().Close();
																}
												} else
												{
																MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Information);
																LoginField.Clear();
																PasswordField.Clear();
																dataBase.getConnection().Close();
												}
								}

								private void CloseButton_Click(object sender, EventArgs e)
								{
												Application.Exit();
								}

				}
}
