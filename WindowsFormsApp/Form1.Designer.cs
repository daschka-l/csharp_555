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
            this.textBoxArrItems = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_hint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultCount = new System.Windows.Forms.Label();
            this.labelInputError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxArrItems
            // 
            this.textBoxArrItems.Location = new System.Drawing.Point(12, 12);
            this.textBoxArrItems.Name = "textBoxArrItems";
            this.textBoxArrItems.Size = new System.Drawing.Size(776, 20);
            this.textBoxArrItems.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.Location = new System.Drawing.Point(9, 35);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(167, 13);
            this.label_hint.TabIndex = 2;
            this.label_hint.Text = "Введите 12 чисел через пробел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Перестановок:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(120, 102);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // labelResultCount
            // 
            this.labelResultCount.AutoSize = true;
            this.labelResultCount.Location = new System.Drawing.Point(120, 125);
            this.labelResultCount.Name = "labelResultCount";
            this.labelResultCount.Size = new System.Drawing.Size(0, 13);
            this.labelResultCount.TabIndex = 6;
            // 
            // labelInputError
            // 
            this.labelInputError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInputError.AutoSize = true;
            this.labelInputError.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelInputError.Location = new System.Drawing.Point(511, 35);
            this.labelInputError.Name = "labelInputError";
            this.labelInputError.Size = new System.Drawing.Size(35, 13);
            this.labelInputError.TabIndex = 7;
            this.labelInputError.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInputError);
            this.Controls.Add(this.labelResultCount);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxArrItems);
            this.Name = "Form1";
            this.Text = "Сортировка с подсчетом";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArrItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResultCount;
        private System.Windows.Forms.Label labelInputError;
    }
}

