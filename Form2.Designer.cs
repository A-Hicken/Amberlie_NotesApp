namespace NotesApp
{
    partial class Form2
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
            goBackButton = new Button();
            lblMessage = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.AutoSize = true;
            goBackButton.Location = new Point(339, 340);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(112, 35);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(381, 89);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 25);
            lblMessage.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(124, 89);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 25);
            lblTitle.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblMessage);
            Controls.Add(goBackButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackButton;
        private Label lblMessage;
        private Label lblTitle;
    }
}