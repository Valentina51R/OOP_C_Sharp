﻿namespace ViewFigure
{
    partial class AddParallelepipedUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.Lenght = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ширина";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(91, 14);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(125, 27);
            this.Height.TabIndex = 3;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // Lenght
            // 
            this.Lenght.Location = new System.Drawing.Point(91, 50);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(125, 27);
            this.Lenght.TabIndex = 4;
            this.Lenght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Length_KeyPress);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(91, 90);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(125, 27);
            this.Width.TabIndex = 5;
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            // 
            // AddParallelepipedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddParallelepipedUserControl";
            this.Size = new System.Drawing.Size(238, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Height;
        private TextBox Lenght;
        private TextBox Width;
    }
}
