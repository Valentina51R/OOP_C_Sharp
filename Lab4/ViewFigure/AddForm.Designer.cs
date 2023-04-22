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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.Random = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBallUserControl1 = new ViewFigure.AddBallUserControl();
            this.addParallelepipedUserControl1 = new ViewFigure.AddParallelepipedUserControl();
            this.addPyramidUserControl1 = new ViewFigure.AddPyramidUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(169, 51);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(151, 29);
            this.Random.TabIndex = 26;
            this.Random.Text = "Случайна фигура";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(169, 267);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(151, 29);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 267);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(151, 29);
            this.OK.TabIndex = 23;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Location = new System.Drawing.Point(12, 51);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFigures.TabIndex = 22;
            this.comboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigeres_SelectedIndexChanged);
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
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(333, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фигуры";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Random;
        private Button Cancel;
        private Button OK;
        private ComboBox comboBoxFigures;
        private Label label1;
        private AddBallUserControl addBallUserControl1;
        private AddParallelepipedUserControl addParallelepipedUserControl1;
        private AddPyramidUserControl addPyramidUserControl1;
        private GroupBox groupBox1;
    }
}