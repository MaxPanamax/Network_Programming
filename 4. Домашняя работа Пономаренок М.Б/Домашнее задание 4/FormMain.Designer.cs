
namespace Task1_4
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxContentSearch = new System.Windows.Forms.ComboBox();
            this.labelSearchLine = new System.Windows.Forms.Label();
            this.labelContentSearch = new System.Windows.Forms.Label();
            this.textBoxSearchLine = new System.Windows.Forms.TextBox();
            this.comboBoxSearchSystem = new System.Windows.Forms.ComboBox();
            this.labelSearchSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(374, 73);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(147, 32);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Поиск в браузере";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxContentSearch
            // 
            this.comboBoxContentSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContentSearch.FormattingEnabled = true;
            this.comboBoxContentSearch.Items.AddRange(new object[] {
            "Общий поиск",
            "Поиск изображений"});
            this.comboBoxContentSearch.Location = new System.Drawing.Point(483, 31);
            this.comboBoxContentSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxContentSearch.Name = "comboBoxContentSearch";
            this.comboBoxContentSearch.Size = new System.Drawing.Size(140, 21);
            this.comboBoxContentSearch.TabIndex = 4;
            // 
            // labelSearchLine
            // 
            this.labelSearchLine.AutoSize = true;
            this.labelSearchLine.Location = new System.Drawing.Point(14, 83);
            this.labelSearchLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchLine.Name = "labelSearchLine";
            this.labelSearchLine.Size = new System.Drawing.Size(99, 13);
            this.labelSearchLine.TabIndex = 6;
            this.labelSearchLine.Text = "Строка поиска:";
            // 
            // labelContentSearch
            // 
            this.labelContentSearch.AutoSize = true;
            this.labelContentSearch.Location = new System.Drawing.Point(371, 34);
            this.labelContentSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContentSearch.Name = "labelContentSearch";
            this.labelContentSearch.Size = new System.Drawing.Size(105, 13);
            this.labelContentSearch.TabIndex = 3;
            this.labelContentSearch.Text = "Контент поиска:";
            // 
            // textBoxSearchLine
            // 
            this.textBoxSearchLine.Location = new System.Drawing.Point(128, 80);
            this.textBoxSearchLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchLine.Name = "textBoxSearchLine";
            this.textBoxSearchLine.Size = new System.Drawing.Size(238, 20);
            this.textBoxSearchLine.TabIndex = 5;
            // 
            // comboBoxSearchSystem
            // 
            this.comboBoxSearchSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchSystem.FormattingEnabled = true;
            this.comboBoxSearchSystem.Items.AddRange(new object[] {
            "https://www.google.com/",
            "https://yandex.ru/"});
            this.comboBoxSearchSystem.Location = new System.Drawing.Point(152, 31);
            this.comboBoxSearchSystem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSearchSystem.Name = "comboBoxSearchSystem";
            this.comboBoxSearchSystem.Size = new System.Drawing.Size(195, 21);
            this.comboBoxSearchSystem.TabIndex = 1;
            // 
            // labelSearchSystem
            // 
            this.labelSearchSystem.AutoSize = true;
            this.labelSearchSystem.Location = new System.Drawing.Point(14, 34);
            this.labelSearchSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchSystem.Name = "labelSearchSystem";
            this.labelSearchSystem.Size = new System.Drawing.Size(130, 13);
            this.labelSearchSystem.TabIndex = 2;
            this.labelSearchSystem.Text = "Поисковая система:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(671, 165);
            this.Controls.Add(this.labelContentSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchLine);
            this.Controls.Add(this.comboBoxContentSearch);
            this.Controls.Add(this.labelSearchSystem);
            this.Controls.Add(this.labelSearchLine);
            this.Controls.Add(this.comboBoxSearchSystem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxContentSearch;
        private System.Windows.Forms.Label labelSearchLine;
        private System.Windows.Forms.Label labelContentSearch;
        private System.Windows.Forms.TextBox textBoxSearchLine;
        private System.Windows.Forms.ComboBox comboBoxSearchSystem;
        private System.Windows.Forms.Label labelSearchSystem;
    }
}

