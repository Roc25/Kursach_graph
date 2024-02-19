namespace Kursach_graph
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
            this.Field = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Field.SuspendLayout();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.BackColor = System.Drawing.Color.Gray;
            this.Field.Controls.Add(this.button1);
            this.Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field.Location = new System.Drawing.Point(0, 0);
            this.Field.Margin = new System.Windows.Forms.Padding(0);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(800, 450);
            this.Field.TabIndex = 0;
            this.Field.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Field.DoubleClick += new System.EventHandler(this.Field_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Field.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Button button1;
    }
}

