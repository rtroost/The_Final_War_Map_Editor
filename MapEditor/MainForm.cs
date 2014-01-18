﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MapEditor m = new MapEditor();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WayPointEditor m = new WayPointEditor();
            m.ShowDialog();
        }
    }
}
