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

        private void gvComp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gvComp.CurrentCell.RowIndex != gvComp.Rows.Count - 1)
                {
                    gvComp.Rows.RemoveAt(gvComp.CurrentCell.RowIndex);
                }
            }
            else if (e.KeyCode == Keys.Enter)
                Lookup();
        }

        //todo: validate + commit
        // validate: all component keywords used in story.

        public void Save()
        {
            if (ValidateForm())
            {
                DialogResult dlg = BetterDialog.ShowDialog("Save", "Are you sure you want to save?",
                    txtChar.Text, "Yes", "No",
                    null, BetterDialog.ImageStyle.Image);

                if (dlg == DialogResult.OK)
                {
                    //
                }
            }
        }

        private bool ValidateForm()
        {
            bool err = true;
            if (!Txt_Validate(txtID))
                err = false;
            if (!Txt_Validate(txtChar))
                err = false;
            if (!Txt_Validate(txtKey))
                err = false;
            //note
            if (!Keyword_Validate())
                err = false;
            return err;
        }

        private void Lookup()
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

        private void gvComp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                gvComp.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
                gvComp.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(192, 255, 255);
                gvComp.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void gvComp_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            gvComp.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Azure;
            gvComp.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
        }

        private bool Txt_Validate(object sender)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length < 1)
            {
                epVal.SetError(txt, "-required");
                return false;
            }
            return true;
        }

        private bool Keyword_Validate()
        {
            List<string> lst = new List<string>();

            if (gvComp.Rows.Count < 2)
                return false;

            for (int i = 0; i < gvComp.Rows.Count - 2; i++)
            {
                for (int j = 0; j < gvComp.Columns.Count - 1; j++)
                {
                    if (gvComp.Rows[i].Cells[j].Value == null)
                        return false;
                    lst.Add(gvComp.Rows[i].Cells[j].Value.ToString());
                }
            }

            foreach (string str in lst)
            {
                if (rtxtStory.Find(str, 0) < 0)
                    return false;
            }
            return true;
        }
    }
}
