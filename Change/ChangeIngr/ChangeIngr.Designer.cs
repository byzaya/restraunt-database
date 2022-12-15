
namespace KursDB
{
				partial class ChangeIngr
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
												System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeIngr));
												this.panel1 = new System.Windows.Forms.Panel();
												this.CloseButton = new System.Windows.Forms.Button();
												this.label2 = new System.Windows.Forms.Label();
												this.comboBox5 = new System.Windows.Forms.ComboBox();
												this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet15 = new KursDB.RestrauntDataSet15();
												this.label5 = new System.Windows.Forms.Label();
												this.textBox4 = new System.Windows.Forms.TextBox();
												this.label3 = new System.Windows.Forms.Label();
												this.textBox2 = new System.Windows.Forms.TextBox();
												this.label4 = new System.Windows.Forms.Label();
												this.textBox3 = new System.Windows.Forms.TextBox();
												this.label1 = new System.Windows.Forms.Label();
												this.label11 = new System.Windows.Forms.Label();
												this.textBox10 = new System.Windows.Forms.TextBox();
												this.button7 = new System.Windows.Forms.Button();
												this.comboBox1 = new System.Windows.Forms.ComboBox();
												this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet14 = new KursDB.RestrauntDataSet14();
												this.label6 = new System.Windows.Forms.Label();
												this.ingredientTableAdapter = new KursDB.RestrauntDataSet14TableAdapters.IngredientTableAdapter();
												this.storageTableAdapter = new KursDB.RestrauntDataSet15TableAdapters.StorageTableAdapter();
												this.panel1.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet15)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet14)).BeginInit();
												this.SuspendLayout();
												// 
												// panel1
												// 
												this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.panel1.Controls.Add(this.CloseButton);
												this.panel1.Controls.Add(this.label2);
												this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
												this.panel1.Location = new System.Drawing.Point(0, 0);
												this.panel1.Margin = new System.Windows.Forms.Padding(2);
												this.panel1.Name = "panel1";
												this.panel1.Size = new System.Drawing.Size(351, 71);
												this.panel1.TabIndex = 2;
												// 
												// CloseButton
												// 
												this.CloseButton.FlatAppearance.BorderSize = 0;
												this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.CloseButton.ForeColor = System.Drawing.Color.White;
												this.CloseButton.Location = new System.Drawing.Point(325, 2);
												this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
												this.CloseButton.Name = "CloseButton";
												this.CloseButton.Size = new System.Drawing.Size(24, 24);
												this.CloseButton.TabIndex = 3;
												this.CloseButton.Text = "х\r\n";
												this.CloseButton.UseVisualStyleBackColor = true;
												this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Font = new System.Drawing.Font("Doppio One", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.label2.ForeColor = System.Drawing.Color.White;
												this.label2.Location = new System.Drawing.Point(133, 16);
												this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(93, 32);
												this.label2.TabIndex = 1;
												this.label2.Text = "BIRCH";
												this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// comboBox5
												// 
												this.comboBox5.DataSource = this.storageBindingSource;
												this.comboBox5.DisplayMember = "Name";
												this.comboBox5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox5.FormattingEnabled = true;
												this.comboBox5.Location = new System.Drawing.Point(139, 212);
												this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox5.Name = "comboBox5";
												this.comboBox5.Size = new System.Drawing.Size(173, 27);
												this.comboBox5.TabIndex = 44;
												this.comboBox5.ValueMember = "IdStorage";
												// 
												// storageBindingSource
												// 
												this.storageBindingSource.DataMember = "Storage";
												this.storageBindingSource.DataSource = this.restrauntDataSet15;
												// 
												// restrauntDataSet15
												// 
												this.restrauntDataSet15.DataSetName = "RestrauntDataSet15";
												this.restrauntDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// label5
												// 
												this.label5.AutoSize = true;
												this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label5.Location = new System.Drawing.Point(37, 345);
												this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label5.Name = "label5";
												this.label5.Size = new System.Drawing.Size(60, 20);
												this.label5.TabIndex = 43;
												this.label5.Text = "Ед. изм.";
												// 
												// textBox4
												// 
												this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.textBox4.Location = new System.Drawing.Point(139, 345);
												this.textBox4.Margin = new System.Windows.Forms.Padding(2);
												this.textBox4.Name = "textBox4";
												this.textBox4.Size = new System.Drawing.Size(173, 25);
												this.textBox4.TabIndex = 42;
												// 
												// label3
												// 
												this.label3.AutoSize = true;
												this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label3.Location = new System.Drawing.Point(37, 306);
												this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label3.Name = "label3";
												this.label3.Size = new System.Drawing.Size(87, 20);
												this.label3.TabIndex = 41;
												this.label3.Text = "Количество";
												// 
												// textBox2
												// 
												this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.textBox2.Location = new System.Drawing.Point(139, 306);
												this.textBox2.Margin = new System.Windows.Forms.Padding(2);
												this.textBox2.Name = "textBox2";
												this.textBox2.Size = new System.Drawing.Size(173, 25);
												this.textBox2.TabIndex = 40;
												// 
												// label4
												// 
												this.label4.AutoSize = true;
												this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label4.Location = new System.Drawing.Point(37, 258);
												this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label4.Name = "label4";
												this.label4.Size = new System.Drawing.Size(43, 20);
												this.label4.TabIndex = 39;
												this.label4.Text = "Цена";
												// 
												// textBox3
												// 
												this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.textBox3.Location = new System.Drawing.Point(139, 258);
												this.textBox3.Margin = new System.Windows.Forms.Padding(2);
												this.textBox3.Name = "textBox3";
												this.textBox3.Size = new System.Drawing.Size(173, 25);
												this.textBox3.TabIndex = 38;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label1.Location = new System.Drawing.Point(37, 212);
												this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(48, 20);
												this.label1.TabIndex = 37;
												this.label1.Text = "Склад";
												// 
												// label11
												// 
												this.label11.AutoSize = true;
												this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label11.Location = new System.Drawing.Point(37, 165);
												this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label11.Name = "label11";
												this.label11.Size = new System.Drawing.Size(75, 20);
												this.label11.TabIndex = 36;
												this.label11.Text = "Название ";
												// 
												// textBox10
												// 
												this.textBox10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.textBox10.Location = new System.Drawing.Point(139, 165);
												this.textBox10.Margin = new System.Windows.Forms.Padding(2);
												this.textBox10.Name = "textBox10";
												this.textBox10.Size = new System.Drawing.Size(173, 25);
												this.textBox10.TabIndex = 35;
												// 
												// button7
												// 
												this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.button7.FlatAppearance.BorderSize = 0;
												this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button7.ForeColor = System.Drawing.Color.White;
												this.button7.Location = new System.Drawing.Point(108, 398);
												this.button7.Margin = new System.Windows.Forms.Padding(2);
												this.button7.Name = "button7";
												this.button7.Size = new System.Drawing.Size(132, 29);
												this.button7.TabIndex = 45;
												this.button7.Text = "Изменить";
												this.button7.UseVisualStyleBackColor = false;
												this.button7.Click += new System.EventHandler(this.button7_Click);
												// 
												// comboBox1
												// 
												this.comboBox1.DataSource = this.ingredientBindingSource;
												this.comboBox1.DisplayMember = "Name";
												this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox1.FormattingEnabled = true;
												this.comboBox1.Location = new System.Drawing.Point(139, 99);
												this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox1.Name = "comboBox1";
												this.comboBox1.Size = new System.Drawing.Size(173, 27);
												this.comboBox1.TabIndex = 47;
												this.comboBox1.ValueMember = "IdIngregient";
												this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
												// 
												// ingredientBindingSource
												// 
												this.ingredientBindingSource.DataMember = "Ingredient";
												this.ingredientBindingSource.DataSource = this.restrauntDataSet14;
												// 
												// restrauntDataSet14
												// 
												this.restrauntDataSet14.DataSetName = "RestrauntDataSet14";
												this.restrauntDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// label6
												// 
												this.label6.AutoSize = true;
												this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label6.Location = new System.Drawing.Point(37, 99);
												this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label6.Name = "label6";
												this.label6.Size = new System.Drawing.Size(87, 20);
												this.label6.TabIndex = 46;
												this.label6.Text = "Ингредиент";
												// 
												// ingredientTableAdapter
												// 
												this.ingredientTableAdapter.ClearBeforeFill = true;
												// 
												// storageTableAdapter
												// 
												this.storageTableAdapter.ClearBeforeFill = true;
												// 
												// ChangeIngr
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(351, 458);
												this.Controls.Add(this.comboBox1);
												this.Controls.Add(this.label6);
												this.Controls.Add(this.button7);
												this.Controls.Add(this.comboBox5);
												this.Controls.Add(this.label5);
												this.Controls.Add(this.textBox4);
												this.Controls.Add(this.label3);
												this.Controls.Add(this.textBox2);
												this.Controls.Add(this.label4);
												this.Controls.Add(this.textBox3);
												this.Controls.Add(this.label1);
												this.Controls.Add(this.label11);
												this.Controls.Add(this.textBox10);
												this.Controls.Add(this.panel1);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
												this.Name = "ChangeIngr";
												this.Text = "ChangeIngr";
												this.Load += new System.EventHandler(this.ChangeIngr_Load);
												this.panel1.ResumeLayout(false);
												this.panel1.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet15)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet14)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Button CloseButton;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.ComboBox comboBox5;
								private System.Windows.Forms.Label label5;
								private System.Windows.Forms.TextBox textBox4;
								private System.Windows.Forms.Label label3;
								private System.Windows.Forms.TextBox textBox2;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.TextBox textBox3;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Label label11;
								private System.Windows.Forms.TextBox textBox10;
								private System.Windows.Forms.Button button7;
								private System.Windows.Forms.ComboBox comboBox1;
								private System.Windows.Forms.Label label6;
								private RestrauntDataSet14 restrauntDataSet14;
								private System.Windows.Forms.BindingSource ingredientBindingSource;
								private RestrauntDataSet14TableAdapters.IngredientTableAdapter ingredientTableAdapter;
								private RestrauntDataSet15 restrauntDataSet15;
								private System.Windows.Forms.BindingSource storageBindingSource;
								private RestrauntDataSet15TableAdapters.StorageTableAdapter storageTableAdapter;
				}
}