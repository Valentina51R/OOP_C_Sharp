using Model;

namespace ViewFigure
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBallUserControl1 = new ViewFigure.AddBallUserControl();
            this.addParallelepipedUserControl1 = new ViewFigure.AddParallelepipedUserControl();
            this.addPyramidUserControl1 = new ViewFigure.AddPyramidUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 29);
            this.button3.TabIndex = 26;
            this.button3.Text = "Случайна фигура";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Выберете фигуру";
            // 
            // addBallUserControl1
            // 
            this.addBallUserControl1.Location = new System.Drawing.Point(20, 51);
            this.addBallUserControl1.Name = "addBallUserControl1";
            this.addBallUserControl1.Size = new System.Drawing.Size(231, 58);
            this.addBallUserControl1.TabIndex = 27;
            // 
            // addParallelepipedUserControl1
            // 
            this.addParallelepipedUserControl1.Location = new System.Drawing.Point(37, 25);
            this.addParallelepipedUserControl1.Name = "addParallelepipedUserControl1";
            this.addParallelepipedUserControl1.Size = new System.Drawing.Size(236, 125);
            this.addParallelepipedUserControl1.TabIndex = 28;
            // 
            // addPyramidUserControl1
            // 
            this.addPyramidUserControl1.Location = new System.Drawing.Point(37, 25);
            this.addPyramidUserControl1.Name = "addPyramidUserControl1";
            this.addPyramidUserControl1.Size = new System.Drawing.Size(228, 131);
            this.addPyramidUserControl1.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addParallelepipedUserControl1);
            this.groupBox1.Controls.Add(this.addBallUserControl1);
            this.groupBox1.Controls.Add(this.addPyramidUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(17, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 164);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фигуры";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Добавление фигуры";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Button button2;
        private Label label11;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private AddBallUserControl addBallUserControl1;
        private AddParallelepipedUserControl addParallelepipedUserControl1;
        private AddPyramidUserControl addPyramidUserControl1;
        private GroupBox groupBox1;
    }
}