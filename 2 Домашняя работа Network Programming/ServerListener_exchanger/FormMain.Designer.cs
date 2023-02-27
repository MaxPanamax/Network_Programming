
namespace ServerListener
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIPAddr = new System.Windows.Forms.Label();
            this.textBoxIPAddr = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.buttonStopServer = new System.Windows.Forms.Button();
            this.labelMaxRequestsUser = new System.Windows.Forms.Label();
            this.numericUpDownMaxRequestsUser = new System.Windows.Forms.NumericUpDown();
            this.labelMaxCountConnectClient = new System.Windows.Forms.Label();
            this.numericUpDownMaxCountConnectClient = new System.Windows.Forms.NumericUpDown();
            this.buttonLoginPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRequestsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCountConnectClient)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIPAddr
            // 
            this.labelIPAddr.AutoSize = true;
            this.labelIPAddr.Location = new System.Drawing.Point(14, 22);
            this.labelIPAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIPAddr.Name = "labelIPAddr";
            this.labelIPAddr.Size = new System.Drawing.Size(62, 13);
            this.labelIPAddr.TabIndex = 0;
            this.labelIPAddr.Text = "IP-адрес:";
            // 
            // textBoxIPAddr
            // 
            this.textBoxIPAddr.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxIPAddr.Location = new System.Drawing.Point(83, 19);
            this.textBoxIPAddr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIPAddr.Name = "textBoxIPAddr";
            this.textBoxIPAddr.Size = new System.Drawing.Size(116, 20);
            this.textBoxIPAddr.TabIndex = 1;
            this.textBoxIPAddr.Text = "127.0.0.1";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(278, 22);
            this.labelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Порт:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxPort.Location = new System.Drawing.Point(344, 19);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(116, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "1234";
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // listBoxLog
            // 
            this.listBoxLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(14, 218);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(446, 173);
            this.listBoxLog.TabIndex = 4;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(14, 191);
            this.labelLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(87, 13);
            this.labelLog.TabIndex = 5;
            this.labelLog.Text = "Лог событий:";
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.BackColor = System.Drawing.Color.Red;
            this.buttonStartServer.ForeColor = System.Drawing.Color.White;
            this.buttonStartServer.Location = new System.Drawing.Point(14, 406);
            this.buttonStartServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(160, 50);
            this.buttonStartServer.TabIndex = 6;
            this.buttonStartServer.Text = "Запустить сервер";
            this.buttonStartServer.UseVisualStyleBackColor = false;
            // 
            // buttonStopServer
            // 
            this.buttonStopServer.BackColor = System.Drawing.Color.Red;
            this.buttonStopServer.ForeColor = System.Drawing.Color.White;
            this.buttonStopServer.Location = new System.Drawing.Point(281, 406);
            this.buttonStopServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStopServer.Name = "buttonStopServer";
            this.buttonStopServer.Size = new System.Drawing.Size(161, 50);
            this.buttonStopServer.TabIndex = 7;
            this.buttonStopServer.Text = "Остановить сервер";
            this.buttonStopServer.UseVisualStyleBackColor = false;
            // 
            // labelMaxRequestsUser
            // 
            this.labelMaxRequestsUser.AutoSize = true;
            this.labelMaxRequestsUser.Location = new System.Drawing.Point(14, 58);
            this.labelMaxRequestsUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxRequestsUser.Name = "labelMaxRequestsUser";
            this.labelMaxRequestsUser.Size = new System.Drawing.Size(319, 13);
            this.labelMaxRequestsUser.TabIndex = 8;
            this.labelMaxRequestsUser.Text = "Максимальное количество запросов пользователя:";
            // 
            // numericUpDownMaxRequestsUser
            // 
            this.numericUpDownMaxRequestsUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericUpDownMaxRequestsUser.Location = new System.Drawing.Point(348, 56);
            this.numericUpDownMaxRequestsUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownMaxRequestsUser.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxRequestsUser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRequestsUser.Name = "numericUpDownMaxRequestsUser";
            this.numericUpDownMaxRequestsUser.Size = new System.Drawing.Size(113, 20);
            this.numericUpDownMaxRequestsUser.TabIndex = 9;
            this.numericUpDownMaxRequestsUser.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelMaxCountConnectClient
            // 
            this.labelMaxCountConnectClient.AutoSize = true;
            this.labelMaxCountConnectClient.Location = new System.Drawing.Point(102, 92);
            this.labelMaxCountConnectClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxCountConnectClient.Name = "labelMaxCountConnectClient";
            this.labelMaxCountConnectClient.Size = new System.Drawing.Size(231, 13);
            this.labelMaxCountConnectClient.TabIndex = 10;
            this.labelMaxCountConnectClient.Text = "Максимальное количество клиентов:";
            // 
            // numericUpDownMaxCountConnectClient
            // 
            this.numericUpDownMaxCountConnectClient.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericUpDownMaxCountConnectClient.Location = new System.Drawing.Point(344, 90);
            this.numericUpDownMaxCountConnectClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownMaxCountConnectClient.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxCountConnectClient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxCountConnectClient.Name = "numericUpDownMaxCountConnectClient";
            this.numericUpDownMaxCountConnectClient.Size = new System.Drawing.Size(113, 20);
            this.numericUpDownMaxCountConnectClient.TabIndex = 11;
            this.numericUpDownMaxCountConnectClient.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonLoginPassword
            // 
            this.buttonLoginPassword.BackColor = System.Drawing.Color.Red;
            this.buttonLoginPassword.ForeColor = System.Drawing.Color.White;
            this.buttonLoginPassword.Location = new System.Drawing.Point(14, 126);
            this.buttonLoginPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLoginPassword.Name = "buttonLoginPassword";
            this.buttonLoginPassword.Size = new System.Drawing.Size(160, 49);
            this.buttonLoginPassword.TabIndex = 12;
            this.buttonLoginPassword.Text = "Логины и пароли";
            this.buttonLoginPassword.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(486, 513);
            this.Controls.Add(this.buttonLoginPassword);
            this.Controls.Add(this.numericUpDownMaxCountConnectClient);
            this.Controls.Add(this.labelMaxCountConnectClient);
            this.Controls.Add(this.numericUpDownMaxRequestsUser);
            this.Controls.Add(this.labelMaxRequestsUser);
            this.Controls.Add(this.buttonStopServer);
            this.Controls.Add(this.buttonStartServer);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAddr);
            this.Controls.Add(this.labelIPAddr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Сервер";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRequestsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCountConnectClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIPAddr;
        private System.Windows.Forms.TextBox textBoxIPAddr;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Button buttonStopServer;
        private System.Windows.Forms.Label labelMaxRequestsUser;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRequestsUser;
        private System.Windows.Forms.Label labelMaxCountConnectClient;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCountConnectClient;
        private System.Windows.Forms.Button buttonLoginPassword;
    }
}

