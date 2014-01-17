﻿using System;
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
            this.Dock = DockStyle.Fill;
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
                Lookup(gvComp.Columns[gvComp.CurrentCell.ColumnIndex].HeaderText, 
                    gvComp.CurrentCell.Value.ToString());
        }

        public void Search(string key)
        {
            DataTable dt = DB_Handle.GetDataTable(
                string.Format(@"SELECT * FROM kanji WHERE keyword = '{0}'", key));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtID.Text = dt.Rows[i][0].ToString();
                txtChar.Text = dt.Rows[i][1].ToString();
                txtKey.Text = dt.Rows[i][2].ToString();
                rtxtStory.Text = dt.Rows[i][3].ToString();
            }

            dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM kanji WHERE id IN
                ( SELECT pid FROM component WHERE kid ='{0}' ) LIMIT 9", txtID.Text));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Lookup("id", dt.Rows[i][0].ToString());
            }
        }

        public bool Save()
        {
            if (ValidateForm())
            {
                try
                {
                    DialogResult dlg = BetterDialog.ShowDialog("Save", "Are you sure you want to save?",
                        txtChar.Text, "Yes", "No",
                        null, BetterDialog.ImageStyle.Image);

                    if (dlg == DialogResult.OK)
                    {
                        DB_Handle.UpdateTable(string.Format(
                            "INSERT OR REPLACE INTO kanji VALUES ({0}, '{1}', '{2}', '{3}')",
                            txtID.Text, txtChar.Text, txtKey.Text, rtxtStory.Text));
                        for (int i = 0; i < gvComp.Rows.Count - 1; i++)
                        {
                            DB_Handle.UpdateTable(string.Format(
                                "INSERT OR REPLACE INTO component VALUES ({0}, {1})",
                                txtID.Text, gvComp.Rows[i].Cells[2].Value.ToString()));
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
            return false;
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

        private void Lookup(string field, string key)
        {
            DataTable dt = DB_Handle.GetDataTable(string.Format(@"SELECT * FROM kanji WHERE {0}='{1}'", field, key));

            if (dt.Rows.Count > 0)
            {
                gvComp.SelectedRows[0].Cells[2].Value = dt.Rows[0][0];
                gvComp.SelectedRows[0].Cells[1].Value = dt.Rows[0][1];
                gvComp.SelectedRows[0].Cells[0].Value = dt.Rows[0][2];
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

            for (int i = 0; i < gvComp.Rows.Count - 2; i++)
            {
                for (int j = 0; j < gvComp.Columns.Count - 1; j++)
                {
                    if (gvComp.Rows[i].Cells[j].Value == null)
                        return false;
                }
                lst.Add(gvComp.Rows[i].Cells[0].Value.ToString());
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
