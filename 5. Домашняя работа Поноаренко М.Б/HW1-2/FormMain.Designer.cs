
namespace HomeWork1_2
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
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAPIKEY = new System.Windows.Forms.TextBox();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.buttonForecast = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGetWeather.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGetWeather.Location = new System.Drawing.Point(14, 215);
            this.buttonGetWeather.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(178, 38);
            this.buttonGetWeather.TabIndex = 0;
            this.buttonGetWeather.Text = "Узнать погоду";
            this.buttonGetWeather.UseVisualStyleBackColor = false;
            this.buttonGetWeather.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.ForeColor = System.Drawing.Color.Red;
            this.textBoxCity.Location = new System.Drawing.Point(196, 80);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(234, 20);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.Text = "Kaliningrad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите API key:";
            // 
            // textBoxAPIKEY
            // 
            this.textBoxAPIKEY.ForeColor = System.Drawing.Color.Red;
            this.textBoxAPIKEY.Location = new System.Drawing.Point(195, 109);
            this.textBoxAPIKEY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAPIKEY.Name = "textBoxAPIKEY";
            this.textBoxAPIKEY.Size = new System.Drawing.Size(234, 20);
            this.textBoxAPIKEY.TabIndex = 4;
            this.textBoxAPIKEY.Text = "8cbdfff687808c9ab5ffad072111e000";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(8, 362);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(955, 148);
            this.dataGridViewInfo.TabIndex = 7;
            // 
            // buttonForecast
            // 
            this.buttonForecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonForecast.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonForecast.Location = new System.Drawing.Point(254, 215);
            this.buttonForecast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonForecast.Name = "buttonForecast";
            this.buttonForecast.Size = new System.Drawing.Size(175, 38);
            this.buttonForecast.TabIndex = 8;
            this.buttonForecast.Text = "Прогноз";
            this.buttonForecast.UseVisualStyleBackColor = false;
            this.buttonForecast.Click += new System.EventHandler(this.buttonForecast_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(11, 83);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(165, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "Введите название города:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::HomeWork1_2.Properties.Resources.Прогноз_погоды_3;
            this.ClientSize = new System.Drawing.Size(976, 534);
            this.Controls.Add(this.buttonForecast);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.textBoxAPIKEY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.buttonGetWeather);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Прогноз погоды......";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAPIKEY;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button buttonForecast;
        private System.Windows.Forms.Label labelCity;
    }
}

