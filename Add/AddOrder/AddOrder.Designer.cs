
namespace KursDB
{
				partial class AddOrder
				{
								/// <summary>
								/// Required designer variable.
								/// </summary>
								private System.ComponentModel.IContainer components = null;

								/// <summary>
								/// Clean up any resources being used.
								/// </summary>
								/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
								protected override void Dispose(bool disposing)
								{
												if (disposing && (components != null))
												{
																components.Dispose();
												}
												base.Dispose(disposing);
								}

								#region Windows Form Designer generated code

								/// <summary>
								/// Required method for Designer support - do not modify
								/// the contents of this method with the code editor.
								/// </summary>
								private void InitializeComponent()
								{
												this.components = new System.ComponentModel.Container();
												this.panel1 = new System.Windows.Forms.Panel();
												this.label3 = new System.Windows.Forms.Label();
												this.button1 = new System.Windows.Forms.Button();
												this.comboBox5 = new System.Windows.Forms.ComboBox();
												this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet24 = new KursDB.RestrauntDataSet24();
												this.comboBox4 = new System.Windows.Forms.ComboBox();
												this.comboBox3 = new System.Windows.Forms.ComboBox();
												this.label2 = new System.Windows.Forms.Label();
												this.button17 = new System.Windows.Forms.Button();
												this.label1 = new System.Windows.Forms.Label();
												this.employeeTableAdapter = new KursDB.RestrauntDataSet24TableAdapters.EmployeeTableAdapter();
												this.comboBox1 = new System.Windows.Forms.ComboBox();
												this.label4 = new System.Windows.Forms.Label();
												this.textBox1 = new System.Windows.Forms.TextBox();
												this.label5 = new System.Windows.Forms.Label();
												this.comboBox2 = new System.Windows.Forms.ComboBox();
												this.button2 = new System.Windows.Forms.Button();
												this.panel1.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet24)).BeginInit();
												this.SuspendLayout();
												// 
												// panel1
												// 
												this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.panel1.Controls.Add(this.label3);
												this.panel1.Controls.Add(this.button1);
												this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
												this.panel1.Location = new System.Drawing.Point(0, 0);
												this.panel1.Margin = new System.Windows.Forms.Padding(2);
												this.panel1.Name = "panel1";
												this.panel1.Size = new System.Drawing.Size(849, 47);
												this.panel1.TabIndex = 29;
												// 
												// label3
												// 
												this.label3.AutoSize = true;
												this.label3.Font = new System.Drawing.Font("Doppio One", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.label3.ForeColor = System.Drawing.Color.White;
												this.label3.Location = new System.Drawing.Point(371, 9);
												this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label3.Name = "label3";
												this.label3.Size = new System.Drawing.Size(93, 32);
												this.label3.TabIndex = 55;
												this.label3.Text = "BIRCH";
												this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// button1
												// 
												this.button1.FlatAppearance.BorderSize = 0;
												this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button1.ForeColor = System.Drawing.Color.White;
												this.button1.Location = new System.Drawing.Point(817, 2);
												this.button1.Margin = new System.Windows.Forms.Padding(2);
												this.button1.Name = "button1";
												this.button1.Size = new System.Drawing.Size(24, 24);
												this.button1.TabIndex = 31;
												this.button1.Text = "х\r\n";
												this.button1.UseVisualStyleBackColor = true;
												this.button1.Click += new System.EventHandler(this.button1_Click);
												// 
												// comboBox5
												// 
												this.comboBox5.DataSource = this.employeeBindingSource;
												this.comboBox5.DisplayMember = "Pathername";
												this.comboBox5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox5.FormattingEnabled = true;
												this.comboBox5.Location = new System.Drawing.Point(588, 76);
												this.comboBox5.Name = "comboBox5";
												this.comboBox5.Size = new System.Drawing.Size(224, 27);
												this.comboBox5.TabIndex = 65;
												this.comboBox5.ValueMember = "IdEmployee";
												// 
												// employeeBindingSource
												// 
												this.employeeBindingSource.DataMember = "Employee";
												this.employeeBindingSource.DataSource = this.restrauntDataSet24;
												// 
												// restrauntDataSet24
												// 
												this.restrauntDataSet24.DataSetName = "RestrauntDataSet24";
												this.restrauntDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// comboBox4
												// 
												this.comboBox4.DataSource = this.employeeBindingSource;
												this.comboBox4.DisplayMember = "Name";
												this.comboBox4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox4.FormattingEnabled = true;
												this.comboBox4.Location = new System.Drawing.Point(358, 76);
												this.comboBox4.Name = "comboBox4";
												this.comboBox4.Size = new System.Drawing.Size(224, 27);
												this.comboBox4.TabIndex = 64;
												this.comboBox4.ValueMember = "IdEmployee";
												// 
												// comboBox3
												// 
												this.comboBox3.DataSource = this.employeeBindingSource;
												this.comboBox3.DisplayMember = "Surname";
												this.comboBox3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox3.FormattingEnabled = true;
												this.comboBox3.Location = new System.Drawing.Point(128, 76);
												this.comboBox3.Name = "comboBox3";
												this.comboBox3.Size = new System.Drawing.Size(224, 27);
												this.comboBox3.TabIndex = 63;
												this.comboBox3.ValueMember = "IdEmployee";
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label2.Location = new System.Drawing.Point(29, 79);
												this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(77, 20);
												this.label2.TabIndex = 60;
												this.label2.Text = "Официант";
												// 
												// button17
												// 
												this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.button17.FlatAppearance.BorderSize = 0;
												this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button17.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button17.ForeColor = System.Drawing.Color.White;
												this.button17.Location = new System.Drawing.Point(236, 269);
												this.button17.Margin = new System.Windows.Forms.Padding(2);
												this.button17.Name = "button17";
												this.button17.Size = new System.Drawing.Size(161, 29);
												this.button17.TabIndex = 55;
												this.button17.Text = "Добавить заказ";
												this.button17.UseVisualStyleBackColor = false;
												this.button17.Click += new System.EventHandler(this.button17_Click);
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label1.Location = new System.Drawing.Point(29, 124);
												this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(56, 20);
												this.label1.TabIndex = 66;
												this.label1.Text = "Столик";
												// 
												// employeeTableAdapter
												// 
												this.employeeTableAdapter.ClearBeforeFill = true;
												// 
												// comboBox1
												// 
												this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox1.FormattingEnabled = true;
												this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
												this.comboBox1.Location = new System.Drawing.Point(128, 121);
												this.comboBox1.Name = "comboBox1";
												this.comboBox1.Size = new System.Drawing.Size(224, 27);
												this.comboBox1.TabIndex = 67;
												// 
												// label4
												// 
												this.label4.AutoSize = true;
												this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label4.Location = new System.Drawing.Point(29, 172);
												this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label4.Name = "label4";
												this.label4.Size = new System.Drawing.Size(95, 20);
												this.label4.TabIndex = 69;
												this.label4.Text = "Дата и время";
												// 
												// textBox1
												// 
												this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.textBox1.Location = new System.Drawing.Point(128, 169);
												this.textBox1.Margin = new System.Windows.Forms.Padding(2);
												this.textBox1.Name = "textBox1";
												this.textBox1.Size = new System.Drawing.Size(224, 25);
												this.textBox1.TabIndex = 70;
												// 
												// label5
												// 
												this.label5.AutoSize = true;
												this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label5.Location = new System.Drawing.Point(29, 217);
												this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label5.Name = "label5";
												this.label5.Size = new System.Drawing.Size(51, 20);
												this.label5.TabIndex = 72;
												this.label5.Text = "Статус";
												// 
												// comboBox2
												// 
												this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox2.FormattingEnabled = true;
												this.comboBox2.Items.AddRange(new object[] {
            "заказ принят",
            "заказ в процессе приготовления",
            "заказ исполнен",
            "заказ оплачен"});
												this.comboBox2.Location = new System.Drawing.Point(128, 217);
												this.comboBox2.Name = "comboBox2";
												this.comboBox2.Size = new System.Drawing.Size(224, 27);
												this.comboBox2.TabIndex = 73;
												// 
												// button2
												// 
												this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.button2.FlatAppearance.BorderSize = 0;
												this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button2.ForeColor = System.Drawing.Color.White;
												this.button2.Location = new System.Drawing.Point(466, 269);
												this.button2.Margin = new System.Windows.Forms.Padding(2);
												this.button2.Name = "button2";
												this.button2.Size = new System.Drawing.Size(228, 29);
												this.button2.TabIndex = 74;
												this.button2.Text = "Добавить блюдо в заказ";
												this.button2.UseVisualStyleBackColor = false;
												this.button2.Click += new System.EventHandler(this.button2_Click);
												// 
												// AddOrder
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(849, 322);
												this.Controls.Add(this.button2);
												this.Controls.Add(this.comboBox2);
												this.Controls.Add(this.label5);
												this.Controls.Add(this.textBox1);
												this.Controls.Add(this.label4);
												this.Controls.Add(this.comboBox1);
												this.Controls.Add(this.label1);
												this.Controls.Add(this.comboBox5);
												this.Controls.Add(this.comboBox4);
												this.Controls.Add(this.comboBox3);
												this.Controls.Add(this.label2);
												this.Controls.Add(this.button17);
												this.Controls.Add(this.panel1);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Name = "AddOrder";
												this.Text = "AddOrder";
												this.Load += new System.EventHandler(this.AddOrder_Load);
												this.panel1.ResumeLayout(false);
												this.panel1.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet24)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Label label3;
								private System.Windows.Forms.Button button1;
								private System.Windows.Forms.ComboBox comboBox5;
								private System.Windows.Forms.ComboBox comboBox4;
								private System.Windows.Forms.ComboBox comboBox3;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Button button17;
								private System.Windows.Forms.Label label1;
								private RestrauntDataSet24 restrauntDataSet24;
								private System.Windows.Forms.BindingSource employeeBindingSource;
								private RestrauntDataSet24TableAdapters.EmployeeTableAdapter employeeTableAdapter;
								private System.Windows.Forms.ComboBox comboBox1;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.TextBox textBox1;
								private System.Windows.Forms.Label label5;
								private System.Windows.Forms.ComboBox comboBox2;
								private System.Windows.Forms.Button button2;
				}
}