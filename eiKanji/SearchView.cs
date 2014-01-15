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
    public partial class SearchView : UserControl
    {
        List<string> cols = new List<string> { "id", "char", "keyword" };
        SearchPane[] spl = new SearchPane[10];

        public SearchView()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(SearchPane sp in spl)
            {
                tableLayoutPanel1.Controls.Remove(sp);
            }
            
            foreach(string st in cols)
            {
                DataTable dt = DB_Handle.GetDataTable(string.Format(
                    @"SELECT * FROM kanji WHERE {0}='{1}' LIMIT 10", st, txtSearch.Text));

                // unravel results into search panes
                // foreach record in dt
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    spl[i] = new SearchPane();
                    spl[i].SetKey(txtSearch.Text);
                    spl[i].Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(spl[i], 0, i + 1);
                    tableLayoutPanel1.RowStyles[i + 1].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[i + 1].Height = 100;
                }
            }
        }
    }
}
