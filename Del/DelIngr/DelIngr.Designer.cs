
namespace KursDB
{
				partial class DelIngr
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
												System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelIngr));
												this.panel1 = new System.Windows.Forms.Panel();
												this.button1 = new System.Windows.Forms.Button();
												this.CloseButton = new System.Windows.Forms.Button();
												this.button7 = new System.Windows.Forms.Button();
												this.comboBox5 = new System.Windows.Forms.ComboBox();
												this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet9 = new KursDB.RestrauntDataSet9();
												this.ingredientTableAdapter = new KursDB.RestrauntDataSet9TableAdapters.IngredientTableAdapter();
												this.panel1.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet9)).BeginInit();
												this.SuspendLayout();
												// 
												// panel1
												// 
												this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.panel1.Controls.Add(this.button1);
												this.panel1.Controls.Add(this.CloseButton);
												this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
												this.panel1.Location = new System.Drawing.Point(0, 0);
												this.panel1.Margin = new System.Windows.Forms.Padding(2);
												this.panel1.Name = "panel1";
												this.panel1.Size = new System.Drawing.Size(325, 34);
												this.panel1.TabIndex = 26;
												// 
												// button1
												// 
												this.button1.FlatAppearance.BorderSize = 0;
												this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button1.ForeColor = System.Drawing.Color.White;
												this.button1.Location = new System.Drawing.Point(292, 2);
												this.button1.Margin = new System.Windows.Forms.Padding(2);
												this.button1.Name = "button1";
												this.button1.Size = new System.Drawing.Size(24, 24);
												this.button1.TabIndex = 3;
												this.button1.Text = "х\r\n";
												this.button1.UseVisualStyleBackColor = true;
												this.button1.Click += new System.EventHandler(this.button1_Click);
												// 
												// CloseButton
												// 
												this.CloseButton.FlatAppearance.BorderSize = 0;
												this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.CloseButton.ForeColor = System.Drawing.Color.White;
												this.CloseButton.Location = new System.Drawing.Point(354, 2);
												this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
												this.CloseButton.Name = "CloseButton";
												this.CloseButton.Size = new System.Drawing.Size(24, 24);
												this.CloseButton.TabIndex = 2;
												this.CloseButton.Text = "х\r\n";
												this.CloseButton.UseVisualStyleBackColor = true;
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
												this.button7.Location = new System.Drawing.Point(94, 145);
												this.button7.Margin = new System.Windows.Forms.Padding(2);
												this.button7.Name = "button7";
												this.button7.Size = new System.Drawing.Size(132, 29);
												this.button7.TabIndex = 27;
												this.button7.Text = "Удалить";
												this.button7.UseVisualStyleBackColor = false;
												this.button7.Click += new System.EventHandler(this.button7_Click);
												// 
												// comboBox5
												// 
												this.comboBox5.DataSource = this.ingredientBindingSource;
												this.comboBox5.DisplayMember = "Name";
												this.comboBox5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox5.FormattingEnabled = true;
												this.comboBox5.Location = new System.Drawing.Point(58, 80);
												this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox5.Name = "comboBox5";
												this.comboBox5.Size = new System.Drawing.Size(209, 27);
												this.comboBox5.TabIndex = 34;
												this.comboBox5.ValueMember = "IdIngregient";
												// 
												// ingredientBindingSource
												// 
												this.ingredientBindingSource.DataMember = "Ingredient";
												this.ingredientBindingSource.DataSource = this.restrauntDataSet9;
												// 
												// restrauntDataSet9
												// 
												this.restrauntDataSet9.DataSetName = "RestrauntDataSet9";
												this.restrauntDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// ingredientTableAdapter
												// 
												this.ingredientTableAdapter.ClearBeforeFill = true;
												// 
												// DelIngr
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(325, 198);
												this.Controls.Add(this.comboBox5);
												this.Controls.Add(this.button7);
												this.Controls.Add(this.panel1);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
												this.Margin = new System.Windows.Forms.Padding(2);
												this.Name = "DelIngr";
												this.Text = "DelIngr";
												this.Load += new System.EventHandler(this.DelIngr_Load);
												this.panel1.ResumeLayout(false);
												((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet9)).EndInit();
												this.ResumeLayout(false);

								}

								#endregion
								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Button CloseButton;
								private System.Windows.Forms.Button button7;
								private System.Windows.Forms.Button button1;
								private System.Windows.Forms.ComboBox comboBox5;
								private RestrauntDataSet9 restrauntDataSet9;
								private System.Windows.Forms.BindingSource ingredientBindingSource;
								private RestrauntDataSet9TableAdapters.IngredientTableAdapter ingredientTableAdapter;
				}
}