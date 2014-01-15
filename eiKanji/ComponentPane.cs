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
    public partial class ComponentPane : UserControl
    {

        public ComponentPane()
        {
            InitializeComponent();
        }

        public void SetComponents(List<KLabel> lst)
        {
            int row = 0;
            int col = 0;

            for (int i = 0; i < lst.Count; i++, row++)
            {
                if (i > 1 && i % 3 == 0)
                {
                    col++;
                    row = 0;
                }
                tableLayoutPanel1.Controls.Add(lst[i], col, row);
            }
        }
    }
}
