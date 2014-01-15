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

        public void SetKey(string key)
        {
            lblKey.Text = key;
            DataTable dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM kanji WHERE keyword='{0}' LIMIT 1", key));
            lblChar.Text = dt.Rows[0][1].ToString();
            lblId.Text = dt.Rows[0][0].ToString();
            lblKey.Text = dt.Rows[0][2].ToString();
            rtxtStory.Text = dt.Rows[0][3].ToString();
        }
    }
}
