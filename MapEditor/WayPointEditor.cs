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
    public partial class WayPointEditor : Form
    {
        public WayPointEditor()
        {
            InitializeComponent();
        }

        private void WayPointEditor_Load(object sender, EventArgs e)
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 34; x++)
                {
                    Button c = new Button();
                    c.Name = "Tile_" + x + "-" + y;
                    c.Location = new System.Drawing.Point(15 * (x + 1), 15 * (y + 1));
                    c.Size = new System.Drawing.Size(15, 15);
                    c.UseVisualStyleBackColor = true;
                    c.Click += new System.EventHandler(Printclickdostuff);
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
        private void Printclickdostuff(object sender, EventArgs e)
        {
            String[] exp = ((Button)sender).Name.ToString().Split(new char[] { '_', '-' });
            String s = "new Point(" + exp[1] + ", " + exp[2] + "),";

            richTextBox1.AppendText(s);
        }
    }
}
