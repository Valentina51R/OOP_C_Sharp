namespace ViewFigure
{
    partial class AddBallUserControl
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
            this.label_Radius = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.label_m = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Radius
            // 
            this.label_Radius.AutoSize = true;
            this.label_Radius.Location = new System.Drawing.Point(20, 20);
            this.label_Radius.Name = "label_Radius";
            this.label_Radius.Size = new System.Drawing.Size(56, 20);
            this.label_Radius.TabIndex = 0;
            this.label_Radius.Text = "Радиус";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(90, 20);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(125, 27);
            this.Radius.TabIndex = 1;
            this.Radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Radius_KeyPress);
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(220, 20);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(20, 20);
            this.label_m.TabIndex = 2;
            this.label_m.Text = "м";
            // 
            // AddBallUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.label_Radius);
            this.Name = "AddBallUserControl";
            this.Size = new System.Drawing.Size(250, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Radius;
        private TextBox Radius;
        private Label label_m;
    }
}
