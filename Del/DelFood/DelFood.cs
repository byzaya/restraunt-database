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
				public partial class DelFood : Form
				{
								DataBase dataBase = new DataBase();
								public DelFood()
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

								private void button1_Click(object sender, EventArgs e)
								{
												this.Hide();
								}

								private void button7_Click(object sender, EventArgs e)
								{
												dataBase.openConnection();
												var id = Int32.Parse(comboBox5.SelectedValue.ToString());
												SqlCommand command = new SqlCommand("DelFood", dataBase.getConnection());
												command.CommandType = CommandType.StoredProcedure;
												command.Parameters.AddWithValue("@IdFoodDel", id);
												command.ExecuteNonQuery();
												if (command.ExecuteNonQuery() >= 0)
												{
																MessageBox.Show("Удаление успешно!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												else
												{
																MessageBox.Show("Удаление не выполнилось!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												dataBase.closeConnection();
								}

								private void DelFood_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet10.Food". При необходимости она может быть перемещена или удалена.
												this.foodTableAdapter.Fill(this.restrauntDataSet10.Food);

								}
				}
}
