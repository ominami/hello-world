namespace WindowsFormsApp
{
    partial class Form1
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
            this.SaveSettings = new System.Windows.Forms.Button();
            this.ColorList = new System.Windows.Forms.ListBox();
            this.UploadSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WindowWidth = new System.Windows.Forms.TextBox();
            this.WindowHeight = new System.Windows.Forms.TextBox();
            this.WindowSize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WindowColor = new System.Windows.Forms.Button();
            this.ResetSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(22, 215);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(495, 41);
            this.SaveSettings.TabIndex = 1;
            this.SaveSettings.Text = "Сохранить в реестр";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // ColorList
            // 
            this.ColorList.FormattingEnabled = true;
            this.ColorList.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange"});
            this.ColorList.Location = new System.Drawing.Point(18, 28);
            this.ColorList.Name = "ColorList";
            this.ColorList.Size = new System.Drawing.Size(201, 95);
            this.ColorList.TabIndex = 4;
            // 
            // UploadSettings
            // 
            this.UploadSettings.Location = new System.Drawing.Point(22, 262);
            this.UploadSettings.Name = "UploadSettings";
            this.UploadSettings.Size = new System.Drawing.Size(495, 41);
            this.UploadSettings.TabIndex = 0;
            this.UploadSettings.Text = "Загрузить из реестра";
            this.UploadSettings.UseVisualStyleBackColor = true;
            this.UploadSettings.Click += new System.EventHandler(this.UploadSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WindowWidth);
            this.groupBox1.Controls.Add(this.WindowHeight);
            this.groupBox1.Controls.Add(this.WindowSize);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер окна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ширина:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Высота:";
            // 
            // WindowWidth
            // 
            this.WindowWidth.Location = new System.Drawing.Point(18, 88);
            this.WindowWidth.Name = "WindowWidth";
            this.WindowWidth.Size = new System.Drawing.Size(201, 20);
            this.WindowWidth.TabIndex = 9;
            this.WindowWidth.Text = "560";
            // 
            // WindowHeight
            // 
            this.WindowHeight.Location = new System.Drawing.Point(18, 49);
            this.WindowHeight.Name = "WindowHeight";
            this.WindowHeight.Size = new System.Drawing.Size(201, 20);
            this.WindowHeight.TabIndex = 8;
            this.WindowHeight.Text = "414";
            // 
            // WindowSize
            // 
            this.WindowSize.Location = new System.Drawing.Point(0, 141);
            this.WindowSize.Name = "WindowSize";
            this.WindowSize.Size = new System.Drawing.Size(238, 41);
            this.WindowSize.TabIndex = 6;
            this.WindowSize.Text = "Изменить размер окна";
            this.WindowSize.UseVisualStyleBackColor = true;
            this.WindowSize.Click += new System.EventHandler(this.WindowSize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WindowColor);
            this.groupBox2.Controls.Add(this.ColorList);
            this.groupBox2.Location = new System.Drawing.Point(279, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвет окна";
            // 
            // WindowColor
            // 
            this.WindowColor.Location = new System.Drawing.Point(0, 141);
            this.WindowColor.Name = "WindowColor";
            this.WindowColor.Size = new System.Drawing.Size(238, 41);
            this.WindowColor.TabIndex = 7;
            this.WindowColor.Text = "Изменить цвет окна";
            this.WindowColor.UseVisualStyleBackColor = true;
            this.WindowColor.Click += new System.EventHandler(this.WindowColor_Click);
            // 
            // ResetSettings
            // 
            this.ResetSettings.Location = new System.Drawing.Point(22, 309);
            this.ResetSettings.Name = "ResetSettings";
            this.ResetSettings.Size = new System.Drawing.Size(495, 41);
            this.ResetSettings.TabIndex = 7;
            this.ResetSettings.Text = "Сбросить реестр";
            this.ResetSettings.UseVisualStyleBackColor = true;
            this.ResetSettings.Click += new System.EventHandler(this.ResetSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.ResetSettings);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UploadSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.ListBox ColorList;
        private System.Windows.Forms.Button UploadSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WindowWidth;
        private System.Windows.Forms.TextBox WindowHeight;
        private System.Windows.Forms.Button WindowSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button WindowColor;
        private System.Windows.Forms.Button ResetSettings;
    }
}

