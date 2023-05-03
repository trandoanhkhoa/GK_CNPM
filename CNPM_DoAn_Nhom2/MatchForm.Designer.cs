namespace CNPM_DoAn_Nhom2
{
    partial class MatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.ptcAdd = new System.Windows.Forms.PictureBox();
            this.txtSearchMatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKetQua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDoi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1203, 69);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH THI ĐẤU";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMatch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 69);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1203, 518);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvMatch
            // 
            this.dgvMatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatch.ColumnHeadersHeight = 35;
            this.dgvMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.btnKetQua,
            this.ID,
            this.Doi1,
            this.Doi2,
            this.NgayGio,
            this.TenSan,
            this.IDDoi1,
            this.IDDoi2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatch.EnableHeadersVisualStyles = false;
            this.dgvMatch.GridColor = System.Drawing.Color.Silver;
            this.dgvMatch.Location = new System.Drawing.Point(0, 0);
            this.dgvMatch.MultiSelect = false;
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMatch.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatch.RowTemplate.Height = 24;
            this.dgvMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatch.Size = new System.Drawing.Size(1203, 518);
            this.dgvMatch.TabIndex = 1;
            this.dgvMatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBottom.Controls.Add(this.ptcAdd);
            this.pnlBottom.Controls.Add(this.txtSearchMatch);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 518);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1203, 69);
            this.pnlBottom.TabIndex = 0;
            // 
            // ptcAdd
            // 
            this.ptcAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptcAdd.Image = ((System.Drawing.Image)(resources.GetObject("ptcAdd.Image")));
            this.ptcAdd.Location = new System.Drawing.Point(1130, 9);
            this.ptcAdd.Name = "ptcAdd";
            this.ptcAdd.Size = new System.Drawing.Size(53, 50);
            this.ptcAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcAdd.TabIndex = 9;
            this.ptcAdd.TabStop = false;
            this.ptcAdd.Click += new System.EventHandler(this.ptcAdd_Click);
            // 
            // txtSearchMatch
            // 
            this.txtSearchMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMatch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMatch.ForeColor = System.Drawing.Color.Black;
            this.txtSearchMatch.Location = new System.Drawing.Point(155, 18);
            this.txtSearchMatch.Name = "txtSearchMatch";
            this.txtSearchMatch.Size = new System.Drawing.Size(406, 30);
            this.txtSearchMatch.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm";
            // 
            // stt
            // 
            this.stt.DataPropertyName = "index";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 90;
            // 
            // btnKetQua
            // 
            this.btnKetQua.HeaderText = "";
            this.btnKetQua.MinimumWidth = 6;
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnKetQua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseColumnTextForButtonValue = true;
            this.btnKetQua.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Doi1
            // 
            this.Doi1.DataPropertyName = "TenDoi1";
            this.Doi1.HeaderText = "Đội 1";
            this.Doi1.MinimumWidth = 6;
            this.Doi1.Name = "Doi1";
            this.Doi1.Width = 200;
            // 
            // Doi2
            // 
            this.Doi2.DataPropertyName = "TenDoi2";
            this.Doi2.HeaderText = "Đội 2";
            this.Doi2.MinimumWidth = 6;
            this.Doi2.Name = "Doi2";
            this.Doi2.Width = 200;
            // 
            // NgayGio
            // 
            this.NgayGio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGio.DataPropertyName = "NgayGio";
            this.NgayGio.HeaderText = "Ngày giờ";
            this.NgayGio.MinimumWidth = 6;
            this.NgayGio.Name = "NgayGio";
            // 
            // TenSan
            // 
            this.TenSan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenSan.DataPropertyName = "TenSan";
            this.TenSan.HeaderText = "Sân thi đấu";
            this.TenSan.MinimumWidth = 6;
            this.TenSan.Name = "TenSan";
            this.TenSan.Width = 126;
            // 
            // IDDoi1
            // 
            this.IDDoi1.DataPropertyName = "Doi1";
            this.IDDoi1.HeaderText = "IDDoi1";
            this.IDDoi1.MinimumWidth = 6;
            this.IDDoi1.Name = "IDDoi1";
            this.IDDoi1.Visible = false;
            this.IDDoi1.Width = 125;
            // 
            // IDDoi2
            // 
            this.IDDoi2.DataPropertyName = "Doi2";
            this.IDDoi2.HeaderText = "IDDoi2";
            this.IDDoi2.MinimumWidth = 6;
            this.IDDoi2.Name = "IDDoi2";
            this.IDDoi2.Visible = false;
            this.IDDoi2.Width = 125;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 587);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.PictureBox ptcAdd;
        private System.Windows.Forms.TextBox txtSearchMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewButtonColumn btnKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoi2;
    }
}