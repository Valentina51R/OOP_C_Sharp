namespace ViewFigure
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
            this.label_Hight = new System.Windows.Forms.Label();
            this.label_Lenght = new System.Windows.Forms.Label();
            this.label_Wedth = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.Lenght = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.label_m1 = new System.Windows.Forms.Label();
            this.label_m2 = new System.Windows.Forms.Label();
            this.label_m3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Hight
            // 
            this.label_Hight.AutoSize = true;
            this.label_Hight.Location = new System.Drawing.Point(20, 20);
            this.label_Hight.Name = "label_Hight";
            this.label_Hight.Size = new System.Drawing.Size(59, 20);
            this.label_Hight.TabIndex = 0;
            this.label_Hight.Text = "Высота";
            // 
            // label_Lenght
            // 
            this.label_Lenght.AutoSize = true;
            this.label_Lenght.Location = new System.Drawing.Point(20, 60);
            this.label_Lenght.Name = "label_Lenght";
            this.label_Lenght.Size = new System.Drawing.Size(53, 20);
            this.label_Lenght.TabIndex = 1;
            this.label_Lenght.Text = "Длина";
            // 
            // label_Wedth
            // 
            this.label_Wedth.AutoSize = true;
            this.label_Wedth.Location = new System.Drawing.Point(20, 100);
            this.label_Wedth.Name = "label_Wedth";
            this.label_Wedth.Size = new System.Drawing.Size(67, 20);
            this.label_Wedth.TabIndex = 2;
            this.label_Wedth.Text = "Ширина";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(90, 20);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(125, 27);
            this.Height.TabIndex = 3;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // Lenght
            // 
            this.Lenght.Location = new System.Drawing.Point(90, 60);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(125, 27);
            this.Lenght.TabIndex = 4;
            this.Lenght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Length_KeyPress);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(90, 100);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(125, 27);
            this.Width.TabIndex = 5;
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            // 
            // label_m1
            // 
            this.label_m1.AutoSize = true;
            this.label_m1.Location = new System.Drawing.Point(220, 20);
            this.label_m1.Name = "label_m1";
            this.label_m1.Size = new System.Drawing.Size(20, 20);
            this.label_m1.TabIndex = 6;
            this.label_m1.Text = "м";
            // 
            // label_m2
            // 
            this.label_m2.AutoSize = true;
            this.label_m2.Location = new System.Drawing.Point(220, 60);
            this.label_m2.Name = "label_m2";
            this.label_m2.Size = new System.Drawing.Size(20, 20);
            this.label_m2.TabIndex = 7;
            this.label_m2.Text = "м";
            // 
            // label_m3
            // 
            this.label_m3.AutoSize = true;
            this.label_m3.Location = new System.Drawing.Point(220, 100);
            this.label_m3.Name = "label_m3";
            this.label_m3.Size = new System.Drawing.Size(20, 20);
            this.label_m3.TabIndex = 8;
            this.label_m3.Text = "м";
            // 
            // AddParallelepipedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_m3);
            this.Controls.Add(this.label_m2);
            this.Controls.Add(this.label_m1);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label_Wedth);
            this.Controls.Add(this.label_Lenght);
            this.Controls.Add(this.label_Hight);
            this.Name = "AddParallelepipedUserControl";
            this.Size = new System.Drawing.Size(250, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Hight;
        private Label label_Lenght;
        private Label label_Wedth;
        private TextBox Height;
        private TextBox Lenght;
        private TextBox Width;
        private Label label_m1;
        private Label label_m2;
        private Label label_m3;
    }
}
