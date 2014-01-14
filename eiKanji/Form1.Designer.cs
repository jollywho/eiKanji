namespace eiKanji
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStory = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvComp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStory
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtStory, 2);
            this.txtStory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStory.Location = new System.Drawing.Point(3, 103);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.Size = new System.Drawing.Size(214, 156);
            this.txtStory.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtID.Location = new System.Drawing.Point(89, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtKey.Location = new System.Drawing.Point(89, 23);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(122, 20);
            this.txtKey.TabIndex = 1;
            // 
            // txtChar
            // 
            this.txtChar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtChar.Location = new System.Drawing.Point(89, 43);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(122, 20);
            this.txtChar.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNote.Location = new System.Drawing.Point(89, 63);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(122, 20);
            this.txtNote.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStory, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.gvComp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtChar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNote, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Story";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Char";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Keyword";
            // 
            // gvComp
            // 
            this.gvComp.AllowUserToAddRows = false;
            this.gvComp.AllowUserToDeleteRows = false;
            this.gvComp.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.gvComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvComp.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvComp.Location = new System.Drawing.Point(223, 3);
            this.gvComp.MultiSelect = false;
            this.gvComp.Name = "gvComp";
            this.gvComp.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.gvComp, 6);
            this.gvComp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvComp.ShowCellToolTips = false;
            this.gvComp.ShowEditingIcon = false;
            this.gvComp.Size = new System.Drawing.Size(237, 256);
            this.gvComp.TabIndex = 4;
            this.gvComp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvComp_CellEndEdit);
            this.gvComp.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvComp_CellLeave);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 36.02257F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 27.99287F;
            this.Column3.HeaderText = "Char";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 77.9135F;
            this.Column2.HeaderText = "Keyword";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Note";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.Text = "eiKanji";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvComp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

