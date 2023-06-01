namespace ViewFigure
{
    partial class AddPyramidUserControl
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
            this.label1_Height = new System.Windows.Forms.Label();
            this.label2_Square = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.Square = new System.Windows.Forms.TextBox();
            this.label3_m = new System.Windows.Forms.Label();
            this.label4_m = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Height
            // 
            this.label1_Height.AutoSize = true;
            this.label1_Height.Location = new System.Drawing.Point(20, 20);
            this.label1_Height.Name = "label1_Height";
            this.label1_Height.Size = new System.Drawing.Size(59, 20);
            this.label1_Height.TabIndex = 0;
            this.label1_Height.Text = "Высота";
            // 
            // label2_Square
            // 
            this.label2_Square.AutoSize = true;
            this.label2_Square.Location = new System.Drawing.Point(20, 60);
            this.label2_Square.Name = "label2_Square";
            this.label2_Square.Size = new System.Drawing.Size(153, 20);
            this.label2_Square.TabIndex = 1;
            this.label2_Square.Text = "Площадь основания";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(90, 20);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(125, 27);
            this.Height.TabIndex = 2;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(90, 100);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(125, 27);
            this.Square.TabIndex = 3;
            this.Square.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Square_KeyPress);
            // 
            // label3_m
            // 
            this.label3_m.AutoSize = true;
            this.label3_m.Location = new System.Drawing.Point(220, 20);
            this.label3_m.Name = "label3_m";
            this.label3_m.Size = new System.Drawing.Size(20, 20);
            this.label3_m.TabIndex = 4;
            this.label3_m.Text = "м";
            // 
            // label4_m
            // 
            this.label4_m.AutoSize = true;
            this.label4_m.Location = new System.Drawing.Point(220, 100);
            this.label4_m.Name = "label4_m";
            this.label4_m.Size = new System.Drawing.Size(20, 20);
            this.label4_m.TabIndex = 5;
            this.label4_m.Text = "м";
            // 
            // AddPyramidUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4_m);
            this.Controls.Add(this.label3_m);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label2_Square);
            this.Controls.Add(this.label1_Height);
            this.Name = "AddPyramidUserControl";
            this.Size = new System.Drawing.Size(250, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_Height;
        private Label label2_Square;
        private TextBox Height;
        private TextBox Square;
        private Label label3_m;
        private Label label4_m;
    }
}
