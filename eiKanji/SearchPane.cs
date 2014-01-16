﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace eiKanji
{
    public partial class SearchPane : UserControl
    {
        ComponentPane cp;
        List<Color> colors = new List<Color>
            { 
                Color.Turquoise, Color.Tomato, Color.BlueViolet,
                Color.CornflowerBlue, Color.Crimson, Color.Orchid,
                Color.LightPink, Color.Chocolate, Color.Magenta
            };

        public SearchPane()
        {
            InitializeComponent();
            cp = new ComponentPane();
            this.tableLayoutPanel1.Controls.Add(cp, 4, 1);
        }

        public void SetKey(string key)
        {
            lblKey.Text = key;
            DataTable dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM kanji WHERE keyword='{0}' LIMIT 1", key));
            lblChar.Text = dt.Rows[0][1].ToString();
            lblId.Text = dt.Rows[0][0].ToString().PadLeft(4, '0');
            lblKey.Text = dt.Rows[0][2].ToString();
            rtxtStory.Text = dt.Rows[0][3].ToString();
            
            dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM kanji WHERE id IN
                ( SELECT pid FROM component WHERE kid ='{0}' ) LIMIT {1}", lblId.Text, colors.Count));

            if (dt.Rows.Count > 0)
            {
                int pos;
                List<KLabel> lst = new List<KLabel>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new KLabel(dt.Rows[i], colors[i]));
                    pos = rtxtStory.Find(dt.Rows[i][2].ToString());
                    if (pos >= 0)
                    {
                        rtxtStory.Select(pos, dt.Rows[i][2].ToString().Length);
                        rtxtStory.SelectionBackColor = colors[i];
                        rtxtStory.SelectionColor = Color.White;
                        rtxtStory.SelectionFont = new Font(this.Font, FontStyle.Bold);
                    }
                }
                pos = rtxtStory.Find(lblKey.Text, RichTextBoxFinds.WholeWord);
                if (pos >= 0)
                {
                    rtxtStory.Select(pos, lblKey.Text.Length);
                    rtxtStory.SelectionFont = new Font(this.Font, FontStyle.Underline);
                }
                cp.SetComponents(lst);
            }
        }
    }
}
