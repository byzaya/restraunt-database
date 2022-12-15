
namespace KursDB
{
				partial class AddTechMap
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
												this.label5 = new System.Windows.Forms.Label();
												this.label3 = new System.Windows.Forms.Label();
												this.textBox2 = new System.Windows.Forms.TextBox();
												this.comboBox1 = new System.Windows.Forms.ComboBox();
												this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet18 = new KursDB.RestrauntDataSet18();
												this.label6 = new System.Windows.Forms.Label();
												this.button1 = new System.Windows.Forms.Button();
												this.comboBox2 = new System.Windows.Forms.ComboBox();
												this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet17 = new KursDB.RestrauntDataSet17();
												this.label1 = new System.Windows.Forms.Label();
												this.panel1 = new System.Windows.Forms.Panel();
												this.button2 = new System.Windows.Forms.Button();
												this.label2 = new System.Windows.Forms.Label();
												this.foodTableAdapter = new KursDB.RestrauntDataSet17TableAdapters.FoodTableAdapter();
												this.ingredientTableAdapter = new KursDB.RestrauntDataSet18TableAdapters.IngredientTableAdapter();
												this.label4 = new System.Windows.Forms.Label();
												this.comboBox3 = new System.Windows.Forms.ComboBox();
												this.comboBox4 = new System.Windows.Forms.ComboBox();
												this.label7 = new System.Windows.Forms.Label();
												this.button3 = new System.Windows.Forms.Button();
												this.comboBox5 = new System.Windows.Forms.ComboBox();
												((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet18)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet17)).BeginInit();
												this.panel1.SuspendLayout();
												this.SuspendLayout();
												// 
												// label5
												// 
												this.label5.AutoSize = true;
												this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label5.Location = new System.Drawing.Point(31, 291);
												this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label5.Name = "label5";
												this.label5.Size = new System.Drawing.Size(56, 20);
												this.label5.TabIndex = 61;
												this.label5.Text = "Ед.изм.";
												// 
												// label3
												// 
												this.label3.AutoSize = true;
												this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label3.Location = new System.Drawing.Point(31, 232);
												this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label3.Name = "label3";
												this.label3.Size = new System.Drawing.Size(87, 20);
												this.label3.TabIndex = 60;
												this.label3.Text = "Количество";
												// 
												// textBox2
												// 
												this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.textBox2.Location = new System.Drawing.Point(161, 227);
												this.textBox2.Margin = new System.Windows.Forms.Padding(2);
												this.textBox2.Name = "textBox2";
												this.textBox2.Size = new System.Drawing.Size(210, 25);
												this.textBox2.TabIndex = 58;
												// 
												// comboBox1
												// 
												this.comboBox1.DataSource = this.ingredientBindingSource;
												this.comboBox1.DisplayMember = "Name";
												this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox1.FormattingEnabled = true;
												this.comboBox1.Location = new System.Drawing.Point(161, 171);
												this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox1.Name = "comboBox1";
												this.comboBox1.Size = new System.Drawing.Size(210, 27);
												this.comboBox1.TabIndex = 57;
												this.comboBox1.ValueMember = "IdIngregient";
												// 
												// ingredientBindingSource
												// 
												this.ingredientBindingSource.DataMember = "Ingredient";
												this.ingredientBindingSource.DataSource = this.restrauntDataSet18;
												// 
												// restrauntDataSet18
												// 
												this.restrauntDataSet18.DataSetName = "RestrauntDataSet18";
												this.restrauntDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// label6
												// 
												this.label6.AutoSize = true;
												this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label6.Location = new System.Drawing.Point(31, 174);
												this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label6.Name = "label6";
												this.label6.Size = new System.Drawing.Size(87, 20);
												this.label6.TabIndex = 56;
												this.label6.Text = "Ингредиент";
												// 
												// button1
												// 
												this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.button1.FlatAppearance.BorderSize = 0;
												this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button1.ForeColor = System.Drawing.Color.White;
												this.button1.Location = new System.Drawing.Point(120, 351);
												this.button1.Margin = new System.Windows.Forms.Padding(2);
												this.button1.Name = "button1";
												this.button1.Size = new System.Drawing.Size(132, 29);
												this.button1.TabIndex = 55;
												this.button1.Text = "Добавить";
												this.button1.UseVisualStyleBackColor = false;
												this.button1.Click += new System.EventHandler(this.button1_Click);
												// 
												// comboBox2
												// 
												this.comboBox2.DataSource = this.foodBindingSource;
												this.comboBox2.DisplayMember = "Name";
												this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox2.FormattingEnabled = true;
												this.comboBox2.Location = new System.Drawing.Point(161, 119);
												this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox2.Name = "comboBox2";
												this.comboBox2.Size = new System.Drawing.Size(235, 27);
												this.comboBox2.TabIndex = 62;
												this.comboBox2.ValueMember = "IdFood";
												// 
												// foodBindingSource
												// 
												this.foodBindingSource.DataMember = "Food";
												this.foodBindingSource.DataSource = this.restrauntDataSet17;
												// 
												// restrauntDataSet17
												// 
												this.restrauntDataSet17.DataSetName = "RestrauntDataSet17";
												this.restrauntDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label1.Location = new System.Drawing.Point(31, 122);
												this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(54, 20);
												this.label1.TabIndex = 63;
												this.label1.Text = "Блюдо";
												// 
												// panel1
												// 
												this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.panel1.Controls.Add(this.button2);
												this.panel1.Controls.Add(this.label2);
												this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
												this.panel1.Location = new System.Drawing.Point(0, 0);
												this.panel1.Margin = new System.Windows.Forms.Padding(2);
												this.panel1.Name = "panel1";
												this.panel1.Size = new System.Drawing.Size(788, 71);
												this.panel1.TabIndex = 64;
												// 
												// button2
												// 
												this.button2.FlatAppearance.BorderSize = 0;
												this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button2.ForeColor = System.Drawing.Color.White;
												this.button2.Location = new System.Drawing.Point(753, 11);
												this.button2.Margin = new System.Windows.Forms.Padding(2);
												this.button2.Name = "button2";
												this.button2.Size = new System.Drawing.Size(24, 24);
												this.button2.TabIndex = 44;
												this.button2.Text = "х\r\n";
												this.button2.UseVisualStyleBackColor = true;
												this.button2.Click += new System.EventHandler(this.button2_Click);
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Font = new System.Drawing.Font("Doppio One", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.label2.ForeColor = System.Drawing.Color.White;
												this.label2.Location = new System.Drawing.Point(342, 20);
												this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(93, 32);
												this.label2.TabIndex = 1;
												this.label2.Text = "BIRCH";
												this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// foodTableAdapter
												// 
												this.foodTableAdapter.ClearBeforeFill = true;
												// 
												// ingredientTableAdapter
												// 
												this.ingredientTableAdapter.ClearBeforeFill = true;
												// 
												// label4
												// 
												this.label4.AutoSize = true;
												this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label4.Location = new System.Drawing.Point(406, 176);
												this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label4.Name = "label4";
												this.label4.Size = new System.Drawing.Size(54, 20);
												this.label4.TabIndex = 68;
												this.label4.Text = "Блюдо";
												// 
												// comboBox3
												// 
												this.comboBox3.DataSource = this.foodBindingSource;
												this.comboBox3.DisplayMember = "Name";
												this.comboBox3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox3.FormattingEnabled = true;
												this.comboBox3.Location = new System.Drawing.Point(506, 173);
												this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox3.Name = "comboBox3";
												this.comboBox3.Size = new System.Drawing.Size(261, 27);
												this.comboBox3.TabIndex = 67;
												this.comboBox3.ValueMember = "IdFood";
												// 
												// comboBox4
												// 
												this.comboBox4.DataSource = this.ingredientBindingSource;
												this.comboBox4.DisplayMember = "Name";
												this.comboBox4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox4.FormattingEnabled = true;
												this.comboBox4.Location = new System.Drawing.Point(506, 225);
												this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox4.Name = "comboBox4";
												this.comboBox4.Size = new System.Drawing.Size(218, 27);
												this.comboBox4.TabIndex = 66;
												this.comboBox4.ValueMember = "IdIngregient";
												// 
												// label7
												// 
												this.label7.AutoSize = true;
												this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.label7.Location = new System.Drawing.Point(406, 228);
												this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label7.Name = "label7";
												this.label7.Size = new System.Drawing.Size(87, 20);
												this.label7.TabIndex = 65;
												this.label7.Text = "Ингредиент";
												// 
												// button3
												// 
												this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.button3.FlatAppearance.BorderSize = 0;
												this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button3.ForeColor = System.Drawing.Color.White;
												this.button3.Location = new System.Drawing.Point(525, 351);
												this.button3.Margin = new System.Windows.Forms.Padding(2);
												this.button3.Name = "button3";
												this.button3.Size = new System.Drawing.Size(132, 29);
												this.button3.TabIndex = 69;
												this.button3.Text = "Удалить";
												this.button3.UseVisualStyleBackColor = false;
												this.button3.Click += new System.EventHandler(this.button3_Click);
												// 
												// comboBox5
												// 
												this.comboBox5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox5.FormattingEnabled = true;
												this.comboBox5.Items.AddRange(new object[] {
            "л",
            "мл",
            "кг",
            "г",
            "уп",
            "шт",
            "бут"});
												this.comboBox5.Location = new System.Drawing.Point(161, 288);
												this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox5.Name = "comboBox5";
												this.comboBox5.Size = new System.Drawing.Size(210, 27);
												this.comboBox5.TabIndex = 70;
												// 
												// AddTechMap
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(788, 408);
												this.Controls.Add(this.comboBox5);
												this.Controls.Add(this.button3);
												this.Controls.Add(this.label4);
												this.Controls.Add(this.comboBox3);
												this.Controls.Add(this.comboBox4);
												this.Controls.Add(this.label7);
												this.Controls.Add(this.panel1);
												this.Controls.Add(this.label1);
												this.Controls.Add(this.comboBox2);
												this.Controls.Add(this.label5);
												this.Controls.Add(this.label3);
												this.Controls.Add(this.textBox2);
												this.Controls.Add(this.comboBox1);
												this.Controls.Add(this.label6);
												this.Controls.Add(this.button1);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Name = "AddTechMap";
												this.Text = "AddTechMap";
												this.Load += new System.EventHandler(this.AddTechMap_Load);
												((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet18)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet17)).EndInit();
												this.panel1.ResumeLayout(false);
												this.panel1.PerformLayout();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Label label5;
								private System.Windows.Forms.Label label3;
								private System.Windows.Forms.TextBox textBox2;
								private System.Windows.Forms.ComboBox comboBox1;
								private System.Windows.Forms.Label label6;
								private System.Windows.Forms.Button button1;
								private System.Windows.Forms.ComboBox comboBox2;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Button button2;
								private System.Windows.Forms.Label label2;
								private RestrauntDataSet17 restrauntDataSet17;
								private System.Windows.Forms.BindingSource foodBindingSource;
								private RestrauntDataSet17TableAdapters.FoodTableAdapter foodTableAdapter;
								private RestrauntDataSet18 restrauntDataSet18;
								private System.Windows.Forms.BindingSource ingredientBindingSource;
								private RestrauntDataSet18TableAdapters.IngredientTableAdapter ingredientTableAdapter;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.ComboBox comboBox3;
								private System.Windows.Forms.ComboBox comboBox4;
								private System.Windows.Forms.Label label7;
								private System.Windows.Forms.Button button3;
								private System.Windows.Forms.ComboBox comboBox5;
				}
}