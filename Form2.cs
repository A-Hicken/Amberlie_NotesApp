﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void SetNoteData(string title, string message)
        {
            lblTitle.Text = "Title: " + title;
            lblMessage.Text = "Message: " + message;
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
