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
        string keyid;

        public SearchView()
        {
            InitializeComponent();
            IProc.Sv = this;
            this.Dock = DockStyle.Fill;
        }

        public void SetKey(string key)
        {
            txtSearch.Text = key;
        }

        public string GetKey()
        {
            return keyid;
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

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SearchPane sp = new SearchPane();
                    keyid = dt.Rows[0][2].ToString();
                    sp.SetKey(keyid);
                    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.AutoSize, 100));
                    sp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    tableLayoutPanel1.Controls.Add(sp, 0, i + 1);
                }
            }
        }
    }
}
