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

        public SearchView()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tableLayoutPanel1.Controls.RemoveAt(i);
                tableLayoutPanel1.RowStyles.RemoveAt(i);
            }
            
            foreach(string st in cols)
            {
                DataTable dt = DB_Handle.GetDataTable(string.Format(
                    @"SELECT * FROM kanji WHERE {0} = '{1}' LIMIT 10", st, txtSearch.Text));

                // unravel results into search panes
                // foreach record in dt
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SearchPane sp = new SearchPane();
                    sp.SetKey(dt.Rows[0][2].ToString());
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.AutoSize, 100));
                    sp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    tableLayoutPanel1.Controls.Add(sp, 0, i + 1);
                    
                }
            }
        }
    }
}
