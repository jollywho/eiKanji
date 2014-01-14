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
        public Form1()
        {
            InitializeComponent();
        }

        private void gvComp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = DB_Handle.GetDataTable(string.Format(@"SELECT * FROM kanji WHERE char='{0}'", "私"));
            gvComp.SelectedRows[0].Cells[0].Value = dt.Rows[0][0];
            gvComp.SelectedRows[0].Cells[1].Value = dt.Rows[0][1];
            gvComp.SelectedRows[0].Cells[2].Value = dt.Rows[0][2];
        }



    }
}