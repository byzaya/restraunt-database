
namespace KursDB
{
				partial class DelFood
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
												this.button1 = new System.Windows.Forms.Button();
												this.CloseButton = new System.Windows.Forms.Button();
												this.button7 = new System.Windows.Forms.Button();
												this.comboBox5 = new System.Windows.Forms.ComboBox();
												this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
												this.restrauntDataSet10 = new KursDB.RestrauntDataSet10();
												this.foodTableAdapter = new KursDB.RestrauntDataSet10TableAdapters.FoodTableAdapter();
												this.panel1.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet10)).BeginInit();
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
												this.panel1.Size = new System.Drawing.Size(311, 34);
												this.panel1.TabIndex = 27;
												// 
												// button1
												// 
												this.button1.FlatAppearance.BorderSize = 0;
												this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.button1.ForeColor = System.Drawing.Color.White;
												this.button1.Location = new System.Drawing.Point(285, 0);
												this.button1.Margin = new System.Windows.Forms.Padding(2);
												this.button1.Name = "button1";
												this.button1.Size = new System.Drawing.Size(24, 24);
												this.button1.TabIndex = 31;
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
												this.button7.Location = new System.Drawing.Point(91, 133);
												this.button7.Margin = new System.Windows.Forms.Padding(2);
												this.button7.Name = "button7";
												this.button7.Size = new System.Drawing.Size(132, 29);
												this.button7.TabIndex = 30;
												this.button7.Text = "Удалить";
												this.button7.UseVisualStyleBackColor = false;
												this.button7.Click += new System.EventHandler(this.button7_Click);
												// 
												// comboBox5
												// 
												this.comboBox5.DataSource = this.foodBindingSource;
												this.comboBox5.DisplayMember = "Name";
												this.comboBox5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.comboBox5.FormattingEnabled = true;
												this.comboBox5.Location = new System.Drawing.Point(51, 75);
												this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
												this.comboBox5.Name = "comboBox5";
												this.comboBox5.Size = new System.Drawing.Size(209, 27);
												this.comboBox5.TabIndex = 35;
												this.comboBox5.ValueMember = "IdFood";
												// 
												// foodBindingSource
												// 
												this.foodBindingSource.DataMember = "Food";
												this.foodBindingSource.DataSource = this.restrauntDataSet10;
												// 
												// restrauntDataSet10
												// 
												this.restrauntDataSet10.DataSetName = "RestrauntDataSet10";
												this.restrauntDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
												// 
												// foodTableAdapter
												// 
												this.foodTableAdapter.ClearBeforeFill = true;
												// 
												// DelFood
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(311, 190);
												this.Controls.Add(this.comboBox5);
												this.Controls.Add(this.button7);
												this.Controls.Add(this.panel1);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Margin = new System.Windows.Forms.Padding(2);
												this.Name = "DelFood";
												this.Text = "DelFood";
												this.Load += new System.EventHandler(this.DelFood_Load);
												this.panel1.ResumeLayout(false);
												((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.restrauntDataSet10)).EndInit();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Button CloseButton;
								private System.Windows.Forms.Button button7;
								private System.Windows.Forms.Button button1;
								private System.Windows.Forms.ComboBox comboBox5;
								private RestrauntDataSet10 restrauntDataSet10;
								private System.Windows.Forms.BindingSource foodBindingSource;
								private RestrauntDataSet10TableAdapters.FoodTableAdapter foodTableAdapter;
				}
}