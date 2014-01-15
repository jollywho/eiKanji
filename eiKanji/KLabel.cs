using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eiKanji
{
    public partial class KLabel : Label
    {
        Color color;
        string id;
        string key;
        string cha;

        public KLabel(DataRow dt, System.Drawing.Color color)
        {
            InitializeComponent();

            dt[0] =
            this.id = dt[0].ToString();
            this.key = dt[2].ToString();
            this.cha = dt[1].ToString();
            this.Text = cha;
            this.color = color;
            this.BackColor = color;
        }

        public KLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void KLabel_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void KLabel_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void KLabel_DoubleClick(object sender, EventArgs e)
        {
            IProc.Activate(this.cha);
        }
    }
}
