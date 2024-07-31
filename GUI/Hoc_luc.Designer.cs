namespace DXApplication9
{
    partial class Hoc_luc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoc_luc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorHocLuc = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvHocLuc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCanTren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCanDuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemKhongChe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).BeginInit();
            this.bindingNavigatorHocLuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHocLuc);
            this.groupBox1.Controls.Add(this.bindingNavigatorHocLuc);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(575, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học lực";
            // 
            // bindingNavigatorHocLuc
            // 
            this.bindingNavigatorHocLuc.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorHocLuc.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocLuc.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorHocLuc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorHocLuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
            this.bindingNavigatorHocLuc.Location = new System.Drawing.Point(4, 20);
            this.bindingNavigatorHocLuc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocLuc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocLuc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocLuc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocLuc.Name = "bindingNavigatorHocLuc";
            this.bindingNavigatorHocLuc.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocLuc.Size = new System.Drawing.Size(567, 27);
            this.bindingNavigatorHocLuc.TabIndex = 0;
            this.bindingNavigatorHocLuc.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Thêm";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "Xóa";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // dgvHocLuc
            // 
            this.dgvHocLuc.AllowUserToAddRows = false;
            this.dgvHocLuc.AllowUserToResizeColumns = false;
            this.dgvHocLuc.AllowUserToResizeRows = false;
            this.dgvHocLuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHocLuc.ColumnHeadersHeight = 29;
            this.dgvHocLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocLuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocLuc,
            this.colTenHocLuc,
            this.colDiemCanTren,
            this.colDiemCanDuoi,
            this.colDiemKhongChe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocLuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocLuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocLuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHocLuc.Location = new System.Drawing.Point(4, 47);
            this.dgvHocLuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocLuc.Name = "dgvHocLuc";
            this.dgvHocLuc.RowHeadersWidth = 51;
            this.dgvHocLuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHocLuc.Size = new System.Drawing.Size(567, 278);
            this.dgvHocLuc.TabIndex = 4;
            // 
            // colMaHocLuc
            // 
            this.colMaHocLuc.DataPropertyName = "MaHocLuc";
            this.colMaHocLuc.HeaderText = "Mã học lực";
            this.colMaHocLuc.MaxInputLength = 6;
            this.colMaHocLuc.MinimumWidth = 6;
            this.colMaHocLuc.Name = "colMaHocLuc";
            this.colMaHocLuc.ReadOnly = true;
            this.colMaHocLuc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaHocLuc.Width = 90;
            // 
            // colTenHocLuc
            // 
            this.colTenHocLuc.DataPropertyName = "TenHocLuc";
            this.colTenHocLuc.HeaderText = "Tên học lực";
            this.colTenHocLuc.MaxInputLength = 30;
            this.colTenHocLuc.MinimumWidth = 6;
            this.colTenHocLuc.Name = "colTenHocLuc";
            this.colTenHocLuc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenHocLuc.Width = 125;
            // 
            // colDiemCanTren
            // 
            this.colDiemCanTren.DataPropertyName = "DiemCanTren";
            this.colDiemCanTren.HeaderText = "Điểm cận trên";
            this.colDiemCanTren.MaxInputLength = 8;
            this.colDiemCanTren.MinimumWidth = 6;
            this.colDiemCanTren.Name = "colDiemCanTren";
            this.colDiemCanTren.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiemCanTren.Width = 85;
            // 
            // colDiemCanDuoi
            // 
            this.colDiemCanDuoi.DataPropertyName = "DiemCanDuoi";
            this.colDiemCanDuoi.HeaderText = "Điểm cận dưới";
            this.colDiemCanDuoi.MaxInputLength = 8;
            this.colDiemCanDuoi.MinimumWidth = 6;
            this.colDiemCanDuoi.Name = "colDiemCanDuoi";
            this.colDiemCanDuoi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiemCanDuoi.Width = 85;
            // 
            // colDiemKhongChe
            // 
            this.colDiemKhongChe.DataPropertyName = "DiemKhongChe";
            this.colDiemKhongChe.HeaderText = "Điểm khống";
            this.colDiemKhongChe.MaxInputLength = 8;
            this.colDiemKhongChe.MinimumWidth = 6;
            this.colDiemKhongChe.Name = "colDiemKhongChe";
            this.colDiemKhongChe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiemKhongChe.Width = 85;
            // 
            // Hoc_luc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 324);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hoc_luc";
            this.Text = "Hoc_luc";
            this.Load += new System.EventHandler(this.Hoc_luc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).EndInit();
            this.bindingNavigatorHocLuc.ResumeLayout(false);
            this.bindingNavigatorHocLuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocLuc;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCanTren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCanDuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemKhongChe;
    }
}