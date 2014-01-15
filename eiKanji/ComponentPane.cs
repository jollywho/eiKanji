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
                Color.Crimson, Color.DeepSkyBlue, Color.LightPink, Color.Moccasin
            };

        public ComponentPane()
        {
            InitializeComponent();
        }

        public void SetId(string id)
        {
            DataTable dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT char FROM kanji WHERE id IN
                ( SELECT pid FROM component WHERE kid ='{0}' ) LIMIT {1}", id, cols.Count));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // if > 3, new col
                Label lb = new Label();
                lb.Text = dt.Rows[i][0].ToString();
                lb.Anchor = AnchorStyles.Left | AnchorStyles.Top;

                lb.BackColor = cols[i];
                lb.Font = new Font("Meiryo", this.Font.Size);
                lb.Dock = DockStyle.Fill;
                lb.TextAlign = ContentAlignment.MiddleCenter;

                tableLayoutPanel1.Controls.Add(lb, 0, i);
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, 30));
            }
        }
    }
}
