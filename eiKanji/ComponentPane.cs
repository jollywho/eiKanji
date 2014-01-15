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
        List<Color> cols = new List<Color>
            { 
                Color.Azure, Color.SpringGreen, Color.BlueViolet, Color.CornflowerBlue,
                Color.Crimson, Color.Orchid, Color.LightPink, Color.Moccasin,
                Color.Salmon
            };

        public ComponentPane()
        {
            InitializeComponent();
        }

        public void SetId(string id)
        {
            int row = 0;
            int col = 0;
            DataTable dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT char FROM kanji WHERE id IN
                ( SELECT pid FROM component WHERE kid ='{0}' ) LIMIT {1}", id, cols.Count));

            for (int i = 0; i < dt.Rows.Count; i++, row++)
            {
                if (i > 1 && i % 3 == 0)
                {
                    col++;
                    row = 0;
                }
                Label lb = new Label();
                lb.Text = dt.Rows[i][0].ToString();
                lb.Anchor = AnchorStyles.Left | AnchorStyles.Top;

                lb.BackColor = cols[i];
                lb.Font = new Font("Meiryo", this.Font.Size);
                lb.Dock = DockStyle.Fill;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                //todo: add label event for cell hover/ enter/ branch label into user control

                tableLayoutPanel1.Controls.Add(lb, col, row);
            }
        }
    }
}
