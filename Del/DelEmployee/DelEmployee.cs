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
				public partial class DelEmployee : Form
				{
								DataBase dataBase = new DataBase();
								public DelEmployee()
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

								private void DelEmployee_Load(object sender, EventArgs e)
								{
												// TODO: данная строка кода позволяет загрузить данные в таблицу "restrauntDataSet11.Employee". При необходимости она может быть перемещена или удалена.
												this.employeeTableAdapter.Fill(this.restrauntDataSet11.Employee);

								}

								private void button2_Click(object sender, EventArgs e)
								{
												dataBase.openConnection();
												var idSur = Int32.Parse(comboBox5.SelectedValue.ToString());
												var idName = Int32.Parse(comboBox1.SelectedValue.ToString());
												var idPath = Int32.Parse(comboBox1.SelectedValue.ToString());
												var idLogin = Int32.Parse(comboBox1.SelectedValue.ToString());

												if(idSur == idName && idName == idPath && idPath == idLogin)
												{
																SqlCommand command = new SqlCommand("DelEmployee", dataBase.getConnection());
																command.CommandType = CommandType.StoredProcedure;
																command.Parameters.AddWithValue("@IdEmpl", idSur);
																command.ExecuteNonQuery();
																				MessageBox.Show("Удаление успешно!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
												else
												{
																MessageBox.Show("Удаление не выполнилось!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
												}
								}

								private void CloseButton_Click(object sender, EventArgs e)
								{
												this.Hide();
								}
				}
}
