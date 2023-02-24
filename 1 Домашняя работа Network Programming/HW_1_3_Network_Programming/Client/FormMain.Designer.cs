
namespace Client
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
            this.buttonSengMsg = new System.Windows.Forms.Button();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.labelSendMsg = new System.Windows.Forms.Label();
            this.textBoxLogMsg = new System.Windows.Forms.TextBox();
            this.labelLogMsg = new System.Windows.Forms.Label();
            this.buttonBeginListen = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.labelIPAdress = new System.Windows.Forms.Label();
            this.buttonStopClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSengMsg
            // 
            this.buttonSengMsg.BackColor = System.Drawing.Color.Red;
            this.buttonSengMsg.ForeColor = System.Drawing.Color.White;
            this.buttonSengMsg.Location = new System.Drawing.Point(379, 235);
            this.buttonSengMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSengMsg.Name = "buttonSengMsg";
            this.buttonSengMsg.Size = new System.Drawing.Size(128, 43);
            this.buttonSengMsg.TabIndex = 29;
            this.buttonSengMsg.Text = "Отправить сообщение";
            this.buttonSengMsg.UseVisualStyleBackColor = false;
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxSendMsg.ForeColor = System.Drawing.Color.Purple;
            this.textBoxSendMsg.Location = new System.Drawing.Point(160, 247);
            this.textBoxSendMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(204, 20);
            this.textBoxSendMsg.TabIndex = 28;
            // 
            // labelSendMsg
            // 
            this.labelSendMsg.AutoSize = true;
            this.labelSendMsg.Location = new System.Drawing.Point(28, 247);
            this.labelSendMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSendMsg.Name = "labelSendMsg";
            this.labelSendMsg.Size = new System.Drawing.Size(130, 13);
            this.labelSendMsg.TabIndex = 27;
            this.labelSendMsg.Text = "Введите сообщение:";
            // 
            // textBoxLogMsg
            // 
            this.textBoxLogMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxLogMsg.ForeColor = System.Drawing.Color.Purple;
            this.textBoxLogMsg.Location = new System.Drawing.Point(142, 52);
            this.textBoxLogMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLogMsg.Multiline = true;
            this.textBoxLogMsg.Name = "textBoxLogMsg";
            this.textBoxLogMsg.Size = new System.Drawing.Size(548, 173);
            this.textBoxLogMsg.TabIndex = 26;
            // 
            // labelLogMsg
            // 
            this.labelLogMsg.AutoSize = true;
            this.labelLogMsg.Location = new System.Drawing.Point(28, 54);
            this.labelLogMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogMsg.Name = "labelLogMsg";
            this.labelLogMsg.Size = new System.Drawing.Size(103, 13);
            this.labelLogMsg.TabIndex = 25;
            this.labelLogMsg.Text = "Лог сообщений:";
            // 
            // buttonBeginListen
            // 
            this.buttonBeginListen.BackColor = System.Drawing.Color.Red;
            this.buttonBeginListen.ForeColor = System.Drawing.Color.White;
            this.buttonBeginListen.Location = new System.Drawing.Point(323, 13);
            this.buttonBeginListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBeginListen.Name = "buttonBeginListen";
            this.buttonBeginListen.Size = new System.Drawing.Size(184, 31);
            this.buttonBeginListen.TabIndex = 24;
            this.buttonBeginListen.Text = "Подключиться к серверу";
            this.buttonBeginListen.UseVisualStyleBackColor = false;
            // 
            // textBoxPort
            // 
            this.textBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxPort.ForeColor = System.Drawing.Color.Purple;
            this.textBoxPort.Location = new System.Drawing.Point(216, 19);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(88, 20);
            this.textBoxPort.TabIndex = 23;
            this.textBoxPort.Text = "1234";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(158, 21);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(45, 13);
            this.labelPort.TabIndex = 22;
            this.labelPort.Text = "PORT:";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxIPAdress.ForeColor = System.Drawing.Color.Purple;
            this.textBoxIPAdress.Location = new System.Drawing.Point(55, 19);
            this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(88, 20);
            this.textBoxIPAdress.TabIndex = 21;
            this.textBoxIPAdress.Text = "127.0.0.1";
            // 
            // labelIPAdress
            // 
            this.labelIPAdress.AutoSize = true;
            this.labelIPAdress.Location = new System.Drawing.Point(28, 21);
            this.labelIPAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIPAdress.Name = "labelIPAdress";
            this.labelIPAdress.Size = new System.Drawing.Size(23, 13);
            this.labelIPAdress.TabIndex = 20;
            this.labelIPAdress.Text = "IP:";
            // 
            // buttonStopClient
            // 
            this.buttonStopClient.BackColor = System.Drawing.Color.Red;
            this.buttonStopClient.ForeColor = System.Drawing.Color.White;
            this.buttonStopClient.Location = new System.Drawing.Point(522, 12);
            this.buttonStopClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStopClient.Name = "buttonStopClient";
            this.buttonStopClient.Size = new System.Drawing.Size(169, 31);
            this.buttonStopClient.TabIndex = 30;
            this.buttonStopClient.Text = "Завершить соединение";
            this.buttonStopClient.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(712, 318);
            this.Controls.Add(this.buttonStopClient);
            this.Controls.Add(this.buttonSengMsg);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.labelSendMsg);
            this.Controls.Add(this.textBoxLogMsg);
            this.Controls.Add(this.labelLogMsg);
            this.Controls.Add(this.buttonBeginListen);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.labelIPAdress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSengMsg;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.Label labelSendMsg;
        private System.Windows.Forms.TextBox textBoxLogMsg;
        private System.Windows.Forms.Label labelLogMsg;
        private System.Windows.Forms.Button buttonBeginListen;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Label labelIPAdress;
        private System.Windows.Forms.Button buttonStopClient;
    }
}

