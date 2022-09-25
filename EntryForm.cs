﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EximBank
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }
        // Form Movement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int X, int Y, int Z);

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeICon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void searchTextbox_Leave(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "")
            {
                searchTextbox.Text = "search";
                searchTextbox.ForeColor = Color.DarkGray;
            }
        }

        private void searchTextbox_Enter(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "search")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = Color.Black;
            }

        }
    }
}
