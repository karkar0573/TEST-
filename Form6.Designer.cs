namespace ProjectZ
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label2 = new Label();
            button1 = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 18.18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(181, 103);
            label2.Name = "label2";
            label2.Size = new Size(450, 105);
            label2.TabIndex = 43;
            label2.Text = "Какое напряжение должно \r\nподдерживаться в шинах \r\nсобственных нужд электростанции?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(315, 350);
            button1.Name = "button1";
            button1.Size = new Size(191, 85);
            button1.TabIndex = 42;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(211, 253);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(165, 19);
            radioButton4.TabIndex = 41;
            radioButton4.TabStop = true;
            radioButton4.Text = "90%-100% номинального";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(445, 253);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(171, 19);
            radioButton3.TabIndex = 40;
            radioButton3.TabStop = true;
            radioButton3.Text = "105%-110% номинального";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(211, 291);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(171, 19);
            radioButton2.TabIndex = 39;
            radioButton2.TabStop = true;
            radioButton2.Text = "100%-105% номинального";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(445, 291);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(159, 19);
            radioButton1.TabIndex = 38;
            radioButton1.TabStop = true;
            radioButton1.Text = "85%-90% номинального";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(300, 16);
            label1.Name = "label1";
            label1.Size = new Size(211, 47);
            label1.TabIndex = 37;
            label1.Text = "Вопрос №5";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Вопрос №5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
    }
}