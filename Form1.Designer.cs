namespace NotesApp
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
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            bttNew = new Button();
            bttSave = new Button();
            bttRead = new Button();
            bttDelete = new Button();
            openForm2Button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(106, 85);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(209, 31);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(106, 122);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(270, 230);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(270, 280);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 93);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 5;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 6;
            label2.Text = "Message";
            // 
            // bttNew
            // 
            bttNew.AutoSize = true;
            bttNew.Location = new Point(116, 380);
            bttNew.Name = "bttNew";
            bttNew.Size = new Size(112, 35);
            bttNew.TabIndex = 7;
            bttNew.Text = "New";
            bttNew.UseVisualStyleBackColor = true;
            bttNew.Click += bttNew_Click;
            // 
            // bttSave
            // 
            bttSave.AutoSize = true;
            bttSave.Location = new Point(255, 380);
            bttSave.Name = "bttSave";
            bttSave.Size = new Size(112, 35);
            bttSave.TabIndex = 8;
            bttSave.Text = "Save";
            bttSave.UseVisualStyleBackColor = true;
            bttSave.Click += bttSave_Click;
            // 
            // bttRead
            // 
            bttRead.AutoSize = true;
            bttRead.Location = new Point(400, 380);
            bttRead.Name = "bttRead";
            bttRead.Size = new Size(112, 35);
            bttRead.TabIndex = 9;
            bttRead.Text = "Read";
            bttRead.UseVisualStyleBackColor = true;
            bttRead.Click += bttRead_Click;
            // 
            // bttDelete
            // 
            bttDelete.AutoSize = true;
            bttDelete.Location = new Point(542, 380);
            bttDelete.Name = "bttDelete";
            bttDelete.Size = new Size(112, 35);
            bttDelete.TabIndex = 10;
            bttDelete.Text = "Delete";
            bttDelete.UseVisualStyleBackColor = true;
            bttDelete.Click += bttDelete_Click;
            // 
            // openForm2Button
            // 
            openForm2Button.AutoSize = true;
            openForm2Button.Location = new Point(318, 439);
            openForm2Button.Name = "openForm2Button";
            openForm2Button.Size = new Size(128, 35);
            openForm2Button.TabIndex = 11;
            openForm2Button.Text = "Open Form 2";
            openForm2Button.UseVisualStyleBackColor = true;
            openForm2Button.Click += openForm2Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(openForm2Button);
            Controls.Add(bttDelete);
            Controls.Add(bttRead);
            Controls.Add(bttSave);
            Controls.Add(bttNew);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button bttNew;
        private Button bttSave;
        private Button bttRead;
        private Button bttDelete;
        private Button openForm2Button;
    }
}
