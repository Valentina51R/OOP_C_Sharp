namespace ViewFigure
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VolumeCheckBox = new System.Windows.Forms.CheckBox();
            this.ParallelepipedCheckBox = new System.Windows.Forms.CheckBox();
            this.PyramidCheckBox = new System.Windows.Forms.CheckBox();
            this.label1_m = new System.Windows.Forms.Label();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.BallCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolumeCheckBox);
            this.groupBox1.Controls.Add(this.ParallelepipedCheckBox);
            this.groupBox1.Controls.Add(this.PyramidCheckBox);
            this.groupBox1.Controls.Add(this.label1_m);
            this.groupBox1.Controls.Add(this.VolumeTextBox);
            this.groupBox1.Controls.Add(this.BallCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фильтрации";
            // 
            // VolumeCheckBox
            // 
            this.VolumeCheckBox.AutoSize = true;
            this.VolumeCheckBox.Location = new System.Drawing.Point(10, 118);
            this.VolumeCheckBox.Name = "VolumeCheckBox";
            this.VolumeCheckBox.Size = new System.Drawing.Size(79, 24);
            this.VolumeCheckBox.TabIndex = 6;
            this.VolumeCheckBox.Text = "Объём";
            this.VolumeCheckBox.UseVisualStyleBackColor = true;
            this.VolumeCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxVolume_CheckedChanged);
            // 
            // ParallelepipedCheckBox
            // 
            this.ParallelepipedCheckBox.AutoSize = true;
            this.ParallelepipedCheckBox.Location = new System.Drawing.Point(10, 87);
            this.ParallelepipedCheckBox.Name = "ParallelepipedCheckBox";
            this.ParallelepipedCheckBox.Size = new System.Drawing.Size(150, 24);
            this.ParallelepipedCheckBox.TabIndex = 5;
            this.ParallelepipedCheckBox.Text = "Параллелепипед";
            this.ParallelepipedCheckBox.UseVisualStyleBackColor = true;
            // 
            // PyramidCheckBox
            // 
            this.PyramidCheckBox.AutoSize = true;
            this.PyramidCheckBox.Location = new System.Drawing.Point(10, 56);
            this.PyramidCheckBox.Name = "PyramidCheckBox";
            this.PyramidCheckBox.Size = new System.Drawing.Size(104, 24);
            this.PyramidCheckBox.TabIndex = 4;
            this.PyramidCheckBox.Text = "Пирамида";
            this.PyramidCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1_m
            // 
            this.label1_m.AutoSize = true;
            this.label1_m.Location = new System.Drawing.Point(160, 119);
            this.label1_m.Name = "label1_m";
            this.label1_m.Size = new System.Drawing.Size(20, 20);
            this.label1_m.TabIndex = 3;
            this.label1_m.Text = "м";
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(94, 115);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(63, 27);
            this.VolumeTextBox.TabIndex = 2;
            this.VolumeTextBox.TextChanged += new System.EventHandler(this.textBoxVolume_TextChanged);
            this.VolumeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVolume_KeyPress);
            // 
            // BallCheckBox
            // 
            this.BallCheckBox.AutoSize = true;
            this.BallCheckBox.Location = new System.Drawing.Point(10, 26);
            this.BallCheckBox.Name = "BallCheckBox";
            this.BallCheckBox.Size = new System.Drawing.Size(62, 24);
            this.BallCheckBox.TabIndex = 1;
            this.BallCheckBox.Text = "Шар";
            this.BallCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(20, 175);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(200, 30);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Запуск фильтра";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(242, 213);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FilterForm";
            this.Text = "Фильтр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1_m;
        private TextBox VolumeTextBox;
        private CheckBox BallCheckBox;
        private Button FilterButton;
        private CheckBox VolumeCheckBox;
        private CheckBox ParallelepipedCheckBox;
        private CheckBox PyramidCheckBox;
    }
}