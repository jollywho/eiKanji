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
        public static Form form;
        EditView ev;
        SearchView sv;
        bool edit;

        public Form1()
        {
            form = this;
            InitializeComponent();
            ev = new EditView();
            sv = new SearchView();
            this.Controls.Add(ev);
            edit = true;
        }

        /// <summary>
        /// Intercept form-level keypress events:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!edit && e.Modifiers == Keys.Control && e.KeyCode == Keys.D1)
            {
                Swap_View(sv, ev);
            }
            if (edit && e.Modifiers == Keys.Control && e.KeyCode == Keys.D2)
            {
                Swap_View(ev, sv);
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                if (edit)
                {
                    if (ev.Save())
                    {
                        this.Controls.Remove(ev);
                        ev = new EditView();
                        this.Controls.Add(ev);
                        ev.Focus();
                    }
                }
            }
            if (!edit && e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                if (sv.GetKey().Length > 0)
                {
                    Swap_View(sv, ev);
                    ev.Search(sv.GetKey());
                }
            }
        }

        private void Swap_View(UserControl uc1, UserControl uc2)
        {
            edit = !edit;
            this.Controls.Remove(uc1);
            this.Controls.Add(uc2);
            uc2.Focus();
        }
    }
}