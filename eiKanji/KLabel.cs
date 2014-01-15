using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eiKanji
{
    public partial class KLabel : Label
    {
        string id;
        string key;
        string cha;

        //todo: add label event for cell hover/ enter/ branch label into user control
        public KLabel(DataRow dt, System.Drawing.Color color)
        {
            InitializeComponent();

            dt[0] =
            this.id = dt[0].ToString();
            this.key = dt[2].ToString();
            this.cha = dt[1].ToString();
            this.Text = cha;
            this.BackColor = color;

        }

        public KLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
