using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eiKanji
{
    public partial class Form1 : Form
    {
        EditView ev;
        SearchView sv;

        public Form1()
        {
            InitializeComponent();
            ev = new EditView();
            sv = new SearchView();
            this.Controls.Add(ev);
            ev.Dock = DockStyle.Fill;
            sv.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Intercept form-level keypress events:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D1)
            {
                this.Controls.Remove(sv);
                this.Controls.Add(ev);
                ev.Focus();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D2)
            {
                this.Controls.Remove(ev);
                this.Controls.Add(sv);
                sv.Focus();
            }
        }

    }
}