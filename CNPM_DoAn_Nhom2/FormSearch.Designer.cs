namespace CNPM_DoAn_Nhom2
{
    partial class FormSearch
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
            this.tbcMain = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbpDoibong = new System.Windows.Forms.TabPage();
            this.tbpCauthu = new System.Windows.Forms.TabPage();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDoibong = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbDoibong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tbpDoibong.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoibong)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcMain.Controls.Add(this.tbpDoibong);
            this.tbcMain.Controls.Add(this.tbpCauthu);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.ItemSize = new System.Drawing.Size(180, 40);
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1203, 587);
            this.tbcMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbcMain.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcMain.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbcMain.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbcMain.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcMain.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcMain.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbcMain.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbcMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbcMain.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbcMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbcMain.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbcMain.TabIndex = 0;
            this.tbcMain.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // tbpDoibong
            // 
            this.tbpDoibong.Controls.Add(this.pnlContainer);
            this.tbpDoibong.Location = new System.Drawing.Point(184, 4);
            this.tbpDoibong.Name = "tbpDoibong";
            this.tbpDoibong.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDoibong.Size = new System.Drawing.Size(1015, 579);
            this.tbpDoibong.TabIndex = 0;
            this.tbpDoibong.Text = "Tra cứu đội bóng";
            this.tbpDoibong.UseVisualStyleBackColor = true;
            // 
            // tbpCauthu
            // 
            this.tbpCauthu.Location = new System.Drawing.Point(184, 4);
            this.tbpCauthu.Name = "tbpCauthu";
            this.tbpCauthu.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCauthu.Size = new System.Drawing.Size(1015, 579);
            this.tbpCauthu.TabIndex = 1;
            this.tbpCauthu.Text = "Tra cứu cầu thủ";
            this.tbpCauthu.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.panel3);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1009, 573);
            this.pnlContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbDoibong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDoibong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 513);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 57);
            this.panel3.TabIndex = 2;
            // 
            // dgvDoibong
            // 
            this.dgvDoibong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoibong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoibong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoibong.ColumnHeadersHeight = 35;
            this.dgvDoibong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.CauThu,
            this.NgaySinh,
            this.LoaiCauThu,
            this.Ghichu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoibong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoibong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoibong.EnableHeadersVisualStyles = false;
            this.dgvDoibong.GridColor = System.Drawing.Color.Silver;
            this.dgvDoibong.Location = new System.Drawing.Point(0, 0);
            this.dgvDoibong.MultiSelect = false;
            this.dgvDoibong.Name = "dgvDoibong";
            this.dgvDoibong.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDoibong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoibong.RowTemplate.Height = 24;
            this.dgvDoibong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoibong.Size = new System.Drawing.Size(1009, 513);
            this.dgvDoibong.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 90;
            // 
            // CauThu
            // 
            this.CauThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CauThu.HeaderText = "Cầu thủ";
            this.CauThu.MinimumWidth = 6;
            this.CauThu.Name = "CauThu";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // LoaiCauThu
            // 
            this.LoaiCauThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiCauThu.HeaderText = "Loại cầu thủ";
            this.LoaiCauThu.MinimumWidth = 6;
            this.LoaiCauThu.Name = "LoaiCauThu";
            // 
            // Ghichu
            // 
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.MinimumWidth = 6;
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Width = 125;
            // 
            // cbbDoibong
            // 
            this.cbbDoibong.BackColor = System.Drawing.Color.Transparent;
            this.cbbDoibong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDoibong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDoibong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDoibong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDoibong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDoibong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbDoibong.ItemHeight = 30;
            this.cbbDoibong.Location = new System.Drawing.Point(660, 12);
            this.cbbDoibong.Name = "cbbDoibong";
            this.cbbDoibong.Size = new System.Drawing.Size(249, 36);
            this.cbbDoibong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đội Bóng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tra cứu đội bóng";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 587);
            this.Controls.Add(this.tbcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.tbcMain.ResumeLayout(false);
            this.tbpDoibong.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoibong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpDoibong;
        private System.Windows.Forms.TabPage tbpCauthu;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDoibong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbDoibong;
    }
}