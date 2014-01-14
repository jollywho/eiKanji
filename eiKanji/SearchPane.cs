using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eiKanji
{
    public partial class SearchPane : UserControl
    {
        public SearchPane()
        {
            InitializeComponent();
            ComponentPane cp = new ComponentPane();
            this.tableLayoutPanel1.Controls.Add(cp, 4, 1);
        }

        public void SetName(string name)
        {
            label1.Text = name;
        }
    }
}
