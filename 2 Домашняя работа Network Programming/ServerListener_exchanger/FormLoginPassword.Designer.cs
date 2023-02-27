
namespace ServerListener
{
    partial class FormLoginPassword
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
            this.dataGridViewListLoginPassword = new System.Windows.Forms.DataGridView();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.buttonAddLoginPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListLoginPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListLoginPassword
            // 
            this.dataGridViewListLoginPassword.AllowUserToAddRows = false;
            this.dataGridViewListLoginPassword.AllowUserToDeleteRows = false;
            this.dataGridViewListLoginPassword.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewListLoginPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListLoginPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewListLoginPassword.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListLoginPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewListLoginPassword.Name = "dataGridViewListLoginPassword";
            this.dataGridViewListLoginPassword.ReadOnly = true;
            this.dataGridViewListLoginPassword.Size = new System.Drawing.Size(933, 187);
            this.dataGridViewListLoginPassword.TabIndex = 0;
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.BackColor = System.Drawing.Color.Red;
            this.buttonUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateInfo.Location = new System.Drawing.Point(173, 291);
            this.buttonUpdateInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(133, 45);
            this.buttonUpdateInfo.TabIndex = 1;
            this.buttonUpdateInfo.Text = "Обновить информацию";
            this.buttonUpdateInfo.UseVisualStyleBackColor = false;
            // 
            // buttonAddLoginPassword
            // 
            this.buttonAddLoginPassword.BackColor = System.Drawing.Color.Red;
            this.buttonAddLoginPassword.Enabled = false;
            this.buttonAddLoginPassword.ForeColor = System.Drawing.Color.White;
            this.buttonAddLoginPassword.Location = new System.Drawing.Point(19, 291);
            this.buttonAddLoginPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddLoginPassword.Name = "buttonAddLoginPassword";
            this.buttonAddLoginPassword.Size = new System.Drawing.Size(133, 45);
            this.buttonAddLoginPassword.TabIndex = 2;
            this.buttonAddLoginPassword.Text = "Добавить";
            this.buttonAddLoginPassword.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите новый логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxLogin.Location = new System.Drawing.Point(173, 214);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(132, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxPassword.Location = new System.Drawing.Point(173, 251);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // FormLoginPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(933, 364);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddLoginPassword);
            this.Controls.Add(this.buttonUpdateInfo);
            this.Controls.Add(this.dataGridViewListLoginPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLoginPassword";
            this.Text = "Логины и пароли";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListLoginPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListLoginPassword;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.Button buttonAddLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}