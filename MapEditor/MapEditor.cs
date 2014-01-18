using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class MapEditor : Form
    {
        public MapEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 34; x++)
                {
                    CheckBox c = new CheckBox();
                    c.Name = "Tile_" + x + "-" + y;
                    c.Location = new System.Drawing.Point(15 * (x + 1), 15 * (y + 1));
                    c.Size = new System.Drawing.Size(15, 15);
                    c.UseVisualStyleBackColor = true;
                    Controls.Add(c);
                }
            }

            for (int y = 0; y < 20; y++)
            {
                Label l = new Label();
                l.Text = y.ToString();
                l.Location = new System.Drawing.Point(0, 15 * (y + 1));
                l.Size = new System.Drawing.Size(15, 15);
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Controls.Add(l);
            }

            for (int y = 0; y < 20; y++)
            {
                Label l = new Label();
                l.Text = y.ToString();
                l.Location = new System.Drawing.Point(525, 15 * (y + 1));
                l.Size = new System.Drawing.Size(15, 15);
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Controls.Add(l);
            }

            for (int x = 0; x < 34; x++)
            {
                Label l = new Label();
                l.Text = x.ToString();
                l.Location = new System.Drawing.Point(15 * (x + 1), 0);
                l.Size = new System.Drawing.Size(15, 15);
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Controls.Add(l);
            }

            for (int x = 0; x < 34; x++)
            {
                Label l = new Label();
                l.Text = x.ToString();
                l.Location = new System.Drawing.Point(15 * (x + 1), 315);
                l.Size = new System.Drawing.Size(15, 15);
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Controls.Add(l);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    if(((CheckBox)c).Checked)
                    {
                        String s = String.Empty;
                        

                        String[] exp = c.Name.ToString().Split(new char[] {'_','-'});
                        s = "data[" + exp[1] + "][" + exp[2] + "] = true;\r\n";

                        richTextBox1.AppendText(s);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "waypoints.add(new Point[] { ";
            
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)c).Checked)
                    {
                        String s = String.Empty;


                        String[] exp = c.Name.ToString().Split(new char[] { '_', '-' });
                        s = "new Point(" + exp[1] + ", " + exp[2] + "),";

                        richTextBox1.AppendText(s);
                    }
                }
            }
            richTextBox1.Text += "});";
        }
    }
}
