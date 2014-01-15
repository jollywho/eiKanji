namespace eiKanji
{
    partial class SearchPane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.rtxtStory = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(117, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 25);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "label3";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKey.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(60, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(51, 25);
            this.lblKey.TabIndex = 6;
            this.lblKey.Text = "label2";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChar.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(3, 0);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(51, 25);
            this.lblChar.TabIndex = 5;
            this.lblChar.Text = "label1";
            this.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtStory
            // 
            this.rtxtStory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtxtStory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rtxtStory, 3);
            this.rtxtStory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtStory.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStory.Location = new System.Drawing.Point(3, 28);
            this.rtxtStory.Name = "rtxtStory";
            this.rtxtStory.ReadOnly = true;
            this.rtxtStory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtStory.Size = new System.Drawing.Size(165, 97);
            this.rtxtStory.TabIndex = 4;
            this.rtxtStory.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00082F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.9975F));
            this.tableLayoutPanel1.Controls.Add(this.lblChar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtxtStory, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(500, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 128);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // SearchPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchPane";
            this.Size = new System.Drawing.Size(228, 128);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.RichTextBox rtxtStory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
