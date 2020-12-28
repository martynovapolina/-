namespace lab4
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
            this.buttonLoadFile_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonApprox_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.buttonExit_Click = new System.Windows.Forms.Button();
            this.buttonSaveReport_Click = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile_Click
            // 
            this.buttonLoadFile_Click.Location = new System.Drawing.Point(6, 31);
            this.buttonLoadFile_Click.Name = "buttonLoadFile_Click";
            this.buttonLoadFile_Click.Size = new System.Drawing.Size(212, 31);
            this.buttonLoadFile_Click.TabIndex = 0;
            this.buttonLoadFile_Click.Text = "Загрузить файл";
            this.buttonLoadFile_Click.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoadFile_Click.UseVisualStyleBackColor = true;
            this.buttonLoadFile_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Чёткий поиск:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxFileReadTime.Location = new System.Drawing.Point(424, 29);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(305, 26);
            this.textBoxFileReadTime.TabIndex = 2;
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxFileReadCount.Location = new System.Drawing.Point(532, 61);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(197, 26);
            this.textBoxFileReadCount.TabIndex = 3;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(446, 129);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(283, 26);
            this.textBoxFind.TabIndex = 4;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxExactTime.Location = new System.Drawing.Point(446, 168);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(283, 26);
            this.textBoxExactTime.TabIndex = 5;
            // 
            // listBoxResult
            // 
            this.listBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(185, 401);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(432, 424);
            this.listBoxResult.TabIndex = 6;
            // 
            // buttonApprox_Click
            // 
            this.buttonApprox_Click.Location = new System.Drawing.Point(3, 257);
            this.buttonApprox_Click.Name = "buttonApprox_Click";
            this.buttonApprox_Click.Size = new System.Drawing.Size(215, 65);
            this.buttonApprox_Click.TabIndex = 7;
            this.buttonApprox_Click.Text = "Параллельный нечеткий поиск:";
            this.buttonApprox_Click.UseVisualStyleBackColor = true;
            this.buttonApprox_Click.Click += new System.EventHandler(this.buttonApprox_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Время чтения из файла:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество уникальных слов в файле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите слово для поиска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Время для чёткого поиска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Максимальное расстояние для нечеткого поиска:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(629, 241);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(100, 26);
            this.textBoxMaxDist.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Время нечеткого поиска:";
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxApproxTime.Location = new System.Drawing.Point(435, 344);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.Size = new System.Drawing.Size(292, 26);
            this.textBoxApproxTime.TabIndex = 16;
            // 
            // buttonExit_Click
            // 
            this.buttonExit_Click.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonExit_Click.Location = new System.Drawing.Point(410, 846);
            this.buttonExit_Click.Name = "buttonExit_Click";
            this.buttonExit_Click.Size = new System.Drawing.Size(155, 35);
            this.buttonExit_Click.TabIndex = 17;
            this.buttonExit_Click.Text = "Выйти";
            this.buttonExit_Click.UseVisualStyleBackColor = false;
            this.buttonExit_Click.Click += new System.EventHandler(this.buttonExit_Click_Click);
            // 
            // buttonSaveReport_Click
            // 
            this.buttonSaveReport_Click.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSaveReport_Click.Location = new System.Drawing.Point(235, 846);
            this.buttonSaveReport_Click.Name = "buttonSaveReport_Click";
            this.buttonSaveReport_Click.Size = new System.Drawing.Size(155, 35);
            this.buttonSaveReport_Click.TabIndex = 18;
            this.buttonSaveReport_Click.Text = "Сохранить";
            this.buttonSaveReport_Click.UseVisualStyleBackColor = false;
            this.buttonSaveReport_Click.Click += new System.EventHandler(this.buttonSaveReport_Click_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Количество потоков";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Вычисленное количество потоков";
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(505, 311);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(222, 26);
            this.textBoxThreadCountAll.TabIndex = 21;
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(505, 273);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(222, 26);
            this.textBoxThreadCount.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 893);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSaveReport_Click);
            this.Controls.Add(this.buttonExit_Click);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonApprox_Click);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoadFile_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile_Click;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonApprox_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.Button buttonExit_Click;
        private System.Windows.Forms.Button buttonSaveReport_Click;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.TextBox textBoxThreadCount;
    }
}

