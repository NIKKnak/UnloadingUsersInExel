namespace UnloadingUsersInExel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 104);
            button1.Name = "button1";
            button1.Size = new Size(216, 78);
            button1.TabIndex = 0;
            button1.Text = "Конвертировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(337, 60);
            label1.TabIndex = 1;
            label1.Text = "Данная программа выгружает данные из XML \r\nфала сети ViPNet в Exel в формате\r\n (пользователь\\id узла\\id пользователя)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 210);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Для выгрузки пользователей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}
