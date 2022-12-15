
namespace KursDB
{
				partial class LoginForm
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
												System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
												this.panel1 = new System.Windows.Forms.Panel();
												this.CloseButton = new System.Windows.Forms.Button();
												this.label2 = new System.Windows.Forms.Label();
												this.label1 = new System.Windows.Forms.Label();
												this.LoginField = new System.Windows.Forms.TextBox();
												this.PasswordField = new System.Windows.Forms.TextBox();
												this.AuthButton = new System.Windows.Forms.Button();
												this.pictureBox3 = new System.Windows.Forms.PictureBox();
												this.pictureBox4 = new System.Windows.Forms.PictureBox();
												this.panel1.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
												this.SuspendLayout();
												// 
												// panel1
												// 
												this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.panel1.Controls.Add(this.CloseButton);
												this.panel1.Controls.Add(this.label2);
												this.panel1.Controls.Add(this.label1);
												this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
												this.panel1.Location = new System.Drawing.Point(0, 0);
												this.panel1.Margin = new System.Windows.Forms.Padding(2);
												this.panel1.Name = "panel1";
												this.panel1.Size = new System.Drawing.Size(380, 71);
												this.panel1.TabIndex = 0;
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
												this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Font = new System.Drawing.Font("Doppio One", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.label2.ForeColor = System.Drawing.Color.White;
												this.label2.Location = new System.Drawing.Point(143, 7);
												this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(93, 32);
												this.label2.TabIndex = 1;
												this.label2.Text = "BIRCH";
												this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.label1.ForeColor = System.Drawing.Color.White;
												this.label1.Location = new System.Drawing.Point(131, 41);
												this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(123, 20);
												this.label1.TabIndex = 0;
												this.label1.Text = "AUTHORIZATION";
												this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
												// 
												// LoginField
												// 
												this.LoginField.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.LoginField.Location = new System.Drawing.Point(113, 160);
												this.LoginField.Margin = new System.Windows.Forms.Padding(2);
												this.LoginField.Name = "LoginField";
												this.LoginField.Size = new System.Drawing.Size(194, 36);
												this.LoginField.TabIndex = 3;
												// 
												// PasswordField
												// 
												this.PasswordField.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
												this.PasswordField.Location = new System.Drawing.Point(113, 229);
												this.PasswordField.Margin = new System.Windows.Forms.Padding(2);
												this.PasswordField.Name = "PasswordField";
												this.PasswordField.Size = new System.Drawing.Size(194, 36);
												this.PasswordField.TabIndex = 4;
												this.PasswordField.UseSystemPasswordChar = true;
												// 
												// AuthButton
												// 
												this.AuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.AuthButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
												this.AuthButton.FlatAppearance.BorderSize = 0;
												this.AuthButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.AuthButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(82)))));
												this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
												this.AuthButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.AuthButton.ForeColor = System.Drawing.Color.White;
												this.AuthButton.Location = new System.Drawing.Point(223, 294);
												this.AuthButton.Margin = new System.Windows.Forms.Padding(2);
												this.AuthButton.Name = "AuthButton";
												this.AuthButton.Size = new System.Drawing.Size(83, 32);
												this.AuthButton.TabIndex = 5;
												this.AuthButton.Text = "Войти\r\n";
												this.AuthButton.UseVisualStyleBackColor = false;
												this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
												// 
												// pictureBox3
												// 
												this.pictureBox3.Image = global::KursDB.Properties.Resources._lock;
												this.pictureBox3.Location = new System.Drawing.Point(51, 229);
												this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
												this.pictureBox3.Name = "pictureBox3";
												this.pictureBox3.Size = new System.Drawing.Size(40, 39);
												this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
												this.pictureBox3.TabIndex = 2;
												this.pictureBox3.TabStop = false;
												// 
												// pictureBox4
												// 
												this.pictureBox4.Image = global::KursDB.Properties.Resources.user;
												this.pictureBox4.Location = new System.Drawing.Point(57, 161);
												this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
												this.pictureBox4.Name = "pictureBox4";
												this.pictureBox4.Size = new System.Drawing.Size(34, 35);
												this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
												this.pictureBox4.TabIndex = 1;
												this.pictureBox4.TabStop = false;
												// 
												// LoginForm
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(380, 375);
												this.Controls.Add(this.AuthButton);
												this.Controls.Add(this.PasswordField);
												this.Controls.Add(this.LoginField);
												this.Controls.Add(this.pictureBox3);
												this.Controls.Add(this.pictureBox4);
												this.Controls.Add(this.panel1);
												this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
												this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
												this.Margin = new System.Windows.Forms.Padding(2);
												this.Name = "LoginForm";
												this.Text = "LoginForm";
												this.panel1.ResumeLayout(false);
												this.panel1.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Panel panel1;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.TextBox LoginField;
								private System.Windows.Forms.TextBox PasswordField;
								private System.Windows.Forms.Button AuthButton;
								private System.Windows.Forms.Button CloseButton;
								private System.Windows.Forms.PictureBox pictureBox3;
								private System.Windows.Forms.PictureBox pictureBox4;
				}
}