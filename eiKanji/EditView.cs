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
    public partial class EditView : UserControl
    {
        public EditView()
        {
            InitializeComponent();
            gvComp.Rows.Add("", "", "");
        }

        private void gvComp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gvComp.CurrentCell.Value == null)
                return;

            string col = gvComp.Columns[gvComp.CurrentCell.ColumnIndex].HeaderText;
            string val = gvComp.CurrentCell.Value.ToString();
            DataTable dt = DB_Handle.GetDataTable(string.Format(@"SELECT * FROM kanji WHERE {0}='{1}'", col, val));

            if (dt.Rows.Count > 0)
            {
                gvComp.SelectedRows[0].Cells[0].Value = dt.Rows[0][0];
                gvComp.SelectedRows[0].Cells[1].Value = dt.Rows[0][1];
                gvComp.SelectedRows[0].Cells[2].Value = dt.Rows[0][2];
                gvComp.CurrentCell.ErrorText = "";
                gvComp.Rows.Add("", "", "");
                gvComp.CurrentCell = gvComp.Rows[gvComp.Rows.Count - 1].Cells[gvComp.CurrentCell.ColumnIndex];
            }
            else
            {
                gvComp.CurrentCell.ErrorText = "No record found.";
            }
        }

        private void gvComp_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            gvComp.CurrentCell.ErrorText = "";
        }

        private void gvComp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gvComp.CurrentCell.RowIndex != gvComp.Rows.Count - 1)
                {
                    gvComp.Rows.RemoveAt(gvComp.CurrentCell.RowIndex);
                }
            }
        }
    }
}
