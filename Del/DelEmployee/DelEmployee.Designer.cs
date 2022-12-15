
namespace KursDB
{
				partial class DelEmployee
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
												this.button2 = new System.Windows.Forms.Button();
												this.panel1 = new System.Windows.Forms.Panel();
												this.CloseButton = new System.Windows.Forms.Button();
												this.comboBox5 = new System.Windows.Forms.ComboBox();
												this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet11 = new KursDB.RestrauntDataSet11();
												this.employeeTableAdapter = new KursDB.RestrauntDataSet11TableAdapters.EmployeeTableAdapter();
												this.comboBox1 = new System.Windows.Forms.ComboBox();
												this.comboBox2 = new System.Windows.Forms.ComboBox();
												this.comboBox3 = new System.Windows.Forms.ComboBox();
												this.panel1.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet11)).BeginInit();
												this.SuspendLayout();
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
												this.button2.Location = new System.Drawing.Point(117, 318);
												this.button2.Margin = new System.Windows.Forms.Padding(2);
												this.button2.Name = "button2";
												this.button2.Size = new System.Drawing.Size(169, 29);
												this.button2.TabIndex = 32;
												this.button2.Text = "Уволить";
												this.button2.UseVisualStyleBackColor = false;
												this.button2.Click += new System.EventHandler(this.button2_Click);
												// 
												// panel1
												// 
												this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.panel1.Controls.Add(this.CloseButton);
												this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
												this.panel1.Location = new System.Drawing.Point(0, 0);
												this.panel1.Margin = new System.Windows.Forms.Padding(2);
												this.panel1.Name = "panel1";
												this.panel1.Size = new System.Drawing.Size(401, 34);
												this.panel1.TabIndex = 33;
												// 
												// CloseButton
												// 
												this.CloseButton.FlatAppearance.BorderSize = 0;
												this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.CloseButton.ForeColor = System.Drawing.Color.White;
												this.CloseButton.Location = new System.Drawing.Point(375, 2);
												this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
												this.CloseButton.Name = "CloseButton";
												this.CloseButton.Size = new System.Drawing.Size(24, 24);
												this.CloseButton.TabIndex = 3;
												this.CloseButton.Text = "х\r\n";
												this.CloseButton.UseVisualStyleBackColor = true;
												this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
												// 
												// comboBox5
												// 
												this.comboBox5.DataSource = this.employeeBindingSource;
												this.comboBox5.DisplayMember = "Surname";
												this.comboBox5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox5.FormattingEnabled = true;
												this.comboBox5.Location = new System.Drawing.Point(43, 61);
												this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox5.Name = "comboBox5";
												this.comboBox5.Size = new System.Drawing.Size(312, 27);
												this.comboBox5.TabIndex = 36;
												this.comboBox5.ValueMember = "IdEmployee";
												// 
												// employeeBindingSource
												// 
												this.employeeBindingSource.DataMember = "Employee";
												this.employeeBindingSource.DataSource = this.restrauntDataSet11;
												// 
												// restrauntDataSet11
												// 
												this.restrauntDataSet11.DataSetName = "RestrauntDataSet11";
												this.restrauntDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// employeeTableAdapter
												// 
												this.employeeTableAdapter.ClearBeforeFill = true;
												// 
												// comboBox1
												// 
												this.comboBox1.DataSource = this.employeeBindingSource;
												this.comboBox1.DisplayMember = "Name";
												this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox1.FormattingEnabled = true;
												this.comboBox1.Location = new System.Drawing.Point(43, 120);
												this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox1.Name = "comboBox1";
												this.comboBox1.Size = new System.Drawing.Size(312, 27);
												this.comboBox1.TabIndex = 37;
												this.comboBox1.ValueMember = "IdEmployee";
												// 
												// comboBox2
												// 
												this.comboBox2.DataSource = this.employeeBindingSource;
												this.comboBox2.DisplayMember = "Pathername";
												this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox2.FormattingEnabled = true;
												this.comboBox2.Location = new System.Drawing.Point(43, 182);
												this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox2.Name = "comboBox2";
												this.comboBox2.Size = new System.Drawing.Size(312, 27);
												this.comboBox2.TabIndex = 38;
												this.comboBox2.ValueMember = "IdEmployee";
												// 
												// comboBox3
												// 
												this.comboBox3.DataSource = this.employeeBindingSource;
												this.comboBox3.DisplayMember = "Login";
												this.comboBox3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox3.FormattingEnabled = true;
												this.comboBox3.Location = new System.Drawing.Point(43, 241);
												this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox3.Name = "comboBox3";
												this.comboBox3.Size = new System.Drawing.Size(312, 27);
												this.comboBox3.TabIndex = 39;
												this.comboBox3.ValueMember = "IdEmployee";
												// 
												// DelEmployee
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(401, 393);
												this.Controls.Add(this.comboBox3);
												this.Controls.Add(this.comboBox2);
												this.Controls.Add(this.comboBox1);
												this.Controls.Add(this.comboBox5);
												this.Controls.Add(this.panel1);
												this.Controls.Add(this.button2);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Margin = new System.Windows.Forms.Padding(2);
												this.Name = "DelEmployee";
												this.Text = "DelEmployee";
												this.Load += new System.EventHandler(this.DelEmployee_Load);
												this.panel1.ResumeLayout(false);
												((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet11)).EndInit();
												this.ResumeLayout(false);

								}

								#endregion
								private System.Windows.Forms.Button button2;
								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Button CloseButton;
								private System.Windows.Forms.ComboBox comboBox5;
								private RestrauntDataSet11 restrauntDataSet11;
								private System.Windows.Forms.BindingSource employeeBindingSource;
								private RestrauntDataSet11TableAdapters.EmployeeTableAdapter employeeTableAdapter;
								private System.Windows.Forms.ComboBox comboBox1;
								private System.Windows.Forms.ComboBox comboBox2;
								private System.Windows.Forms.ComboBox comboBox3;
				}
}