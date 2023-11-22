namespace ProjectZ
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
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
            label2.Location = new Point(125, 109);
            label2.Name = "label2";
            label2.Size = new Size(573, 105);
            label2.TabIndex = 35;
            label2.Text = "Каким образом должны быть \r\nобозначены нулевые рабочие (нейтральные) \r\nпроводники в электроустановках?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(304, 350);
            button1.Name = "button1";
            button1.Size = new Size(191, 85);
            button1.TabIndex = 34;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(168, 260);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(182, 19);
            radioButton4.TabIndex = 33;
            radioButton4.TabStop = true;
            radioButton4.Text = "Буквой N и голубым цветом";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(470, 265);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(182, 19);
            radioButton3.TabIndex = 32;
            radioButton3.TabStop = true;
            radioButton3.Text = "Буквой Н и голубым цветом";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(168, 298);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(170, 19);
            radioButton2.TabIndex = 31;
            radioButton2.TabStop = true;
            radioButton2.Text = "Буквой N и белым цветом";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(470, 298);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 19);
            radioButton1.TabIndex = 30;
            radioButton1.TabStop = true;
            radioButton1.Text = "Буквой Н и белым цветом";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 16);
            label1.Name = "label1";
            label1.Size = new Size(212, 47);
            label1.TabIndex = 29;
            label1.Text = "Вопрос №4";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(807, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Вопрос №4";
            Load += Form5_Load;
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