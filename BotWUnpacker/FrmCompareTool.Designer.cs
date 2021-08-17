namespace BotwUnpacker
{
    partial class FrmCompareTool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompareTool));
            this.tbxOriFile = new System.Windows.Forms.TextBox();
            this.tbxCustom = new System.Windows.Forms.TextBox();
            this.btnOriBrowse = new System.Windows.Forms.Button();
            this.btnCusBrowse = new System.Windows.Forms.Button();
            this.dgvOriTable = new System.Windows.Forms.DataGridView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.dgvCusTable = new System.Windows.Forms.DataGridView();
            this.rbnOriFile = new System.Windows.Forms.RadioButton();
            this.rbnOriFolder = new System.Windows.Forms.RadioButton();
            this.panelOri = new System.Windows.Forms.Panel();
            this.panelCus = new System.Windows.Forms.Panel();
            this.rbnCustomFolder = new System.Windows.Forms.RadioButton();
            this.rbnCustomFile = new System.Windows.Forms.RadioButton();
            this.nodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeSizeHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodePadding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusTable)).BeginInit();
            this.panelOri.SuspendLayout();
            this.panelCus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxOriFile
            // 
            this.tbxOriFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tbxOriFile.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxOriFile.Location = new System.Drawing.Point(18, 81);
            this.tbxOriFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxOriFile.Name = "tbxOriFile";
            this.tbxOriFile.ReadOnly = true;
            this.tbxOriFile.Size = new System.Drawing.Size(444, 27);
            this.tbxOriFile.TabIndex = 7;
            // 
            // tbxCustom
            // 
            this.tbxCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tbxCustom.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxCustom.Location = new System.Drawing.Point(595, 81);
            this.tbxCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCustom.Name = "tbxCustom";
            this.tbxCustom.ReadOnly = true;
            this.tbxCustom.Size = new System.Drawing.Size(444, 27);
            this.tbxCustom.TabIndex = 8;
            // 
            // btnOriBrowse
            // 
            this.btnOriBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriBrowse.Location = new System.Drawing.Point(350, 17);
            this.btnOriBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOriBrowse.Name = "btnOriBrowse";
            this.btnOriBrowse.Size = new System.Drawing.Size(112, 53);
            this.btnOriBrowse.TabIndex = 0;
            this.btnOriBrowse.Text = "浏览";
            this.btnOriBrowse.UseVisualStyleBackColor = true;
            this.btnOriBrowse.Click += new System.EventHandler(this.btnOriBrowse_Click);
            // 
            // btnCusBrowse
            // 
            this.btnCusBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusBrowse.Location = new System.Drawing.Point(927, 17);
            this.btnCusBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCusBrowse.Name = "btnCusBrowse";
            this.btnCusBrowse.Size = new System.Drawing.Size(112, 51);
            this.btnCusBrowse.TabIndex = 1;
            this.btnCusBrowse.Text = "浏览";
            this.btnCusBrowse.UseVisualStyleBackColor = true;
            this.btnCusBrowse.Click += new System.EventHandler(this.btnCusBrowse_Click);
            // 
            // dgvOriTable
            // 
            this.dgvOriTable.AllowUserToAddRows = false;
            this.dgvOriTable.AllowUserToDeleteRows = false;
            this.dgvOriTable.AllowUserToResizeRows = false;
            this.dgvOriTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOriTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOriTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOriTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeId,
            this.nodeType,
            this.nodeSize,
            this.nodeSizeHex,
            this.nodePath,
            this.nodePadding});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOriTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOriTable.Location = new System.Drawing.Point(18, 111);
            this.dgvOriTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOriTable.Name = "dgvOriTable";
            this.dgvOriTable.ReadOnly = true;
            this.dgvOriTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvOriTable.RowHeadersVisible = false;
            this.dgvOriTable.RowHeadersWidth = 51;
            this.dgvOriTable.ShowCellToolTips = false;
            this.dgvOriTable.ShowEditingIcon = false;
            this.dgvOriTable.Size = new System.Drawing.Size(446, 488);
            this.dgvOriTable.TabIndex = 5;
            // 
            // btnCompare
            // 
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Location = new System.Drawing.Point(472, 313);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(112, 67);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "对比";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // dgvCusTable
            // 
            this.dgvCusTable.AllowUserToAddRows = false;
            this.dgvCusTable.AllowUserToDeleteRows = false;
            this.dgvCusTable.AllowUserToResizeRows = false;
            this.dgvCusTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCusTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCusTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCusTable.Location = new System.Drawing.Point(595, 111);
            this.dgvCusTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCusTable.Name = "dgvCusTable";
            this.dgvCusTable.ReadOnly = true;
            this.dgvCusTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCusTable.RowHeadersVisible = false;
            this.dgvCusTable.RowHeadersWidth = 51;
            this.dgvCusTable.ShowCellToolTips = false;
            this.dgvCusTable.ShowEditingIcon = false;
            this.dgvCusTable.Size = new System.Drawing.Size(446, 488);
            this.dgvCusTable.TabIndex = 13;
            // 
            // rbnOriFile
            // 
            this.rbnOriFile.AutoSize = true;
            this.rbnOriFile.Checked = true;
            this.rbnOriFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnOriFile.Location = new System.Drawing.Point(4, 31);
            this.rbnOriFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnOriFile.Name = "rbnOriFile";
            this.rbnOriFile.Size = new System.Drawing.Size(59, 24);
            this.rbnOriFile.TabIndex = 17;
            this.rbnOriFile.TabStop = true;
            this.rbnOriFile.Text = "文件";
            this.rbnOriFile.UseVisualStyleBackColor = true;
            // 
            // rbnOriFolder
            // 
            this.rbnOriFolder.AutoSize = true;
            this.rbnOriFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnOriFolder.Location = new System.Drawing.Point(4, 4);
            this.rbnOriFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnOriFolder.Name = "rbnOriFolder";
            this.rbnOriFolder.Size = new System.Drawing.Size(74, 24);
            this.rbnOriFolder.TabIndex = 16;
            this.rbnOriFolder.Text = "文件夹";
            this.rbnOriFolder.UseVisualStyleBackColor = true;
            // 
            // panelOri
            // 
            this.panelOri.Controls.Add(this.rbnOriFolder);
            this.panelOri.Controls.Add(this.rbnOriFile);
            this.panelOri.Location = new System.Drawing.Point(18, 13);
            this.panelOri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOri.Name = "panelOri";
            this.panelOri.Size = new System.Drawing.Size(86, 57);
            this.panelOri.TabIndex = 18;
            // 
            // panelCus
            // 
            this.panelCus.Controls.Add(this.rbnCustomFolder);
            this.panelCus.Controls.Add(this.rbnCustomFile);
            this.panelCus.Location = new System.Drawing.Point(595, 19);
            this.panelCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCus.Name = "panelCus";
            this.panelCus.Size = new System.Drawing.Size(86, 57);
            this.panelCus.TabIndex = 19;
            // 
            // rbnCustomFolder
            // 
            this.rbnCustomFolder.AutoSize = true;
            this.rbnCustomFolder.Checked = true;
            this.rbnCustomFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnCustomFolder.Location = new System.Drawing.Point(4, 4);
            this.rbnCustomFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnCustomFolder.Name = "rbnCustomFolder";
            this.rbnCustomFolder.Size = new System.Drawing.Size(74, 24);
            this.rbnCustomFolder.TabIndex = 16;
            this.rbnCustomFolder.TabStop = true;
            this.rbnCustomFolder.Text = "文件夹";
            this.rbnCustomFolder.UseVisualStyleBackColor = true;
            // 
            // rbnCustomFile
            // 
            this.rbnCustomFile.AutoSize = true;
            this.rbnCustomFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnCustomFile.Location = new System.Drawing.Point(4, 31);
            this.rbnCustomFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnCustomFile.Name = "rbnCustomFile";
            this.rbnCustomFile.Size = new System.Drawing.Size(59, 24);
            this.rbnCustomFile.TabIndex = 17;
            this.rbnCustomFile.Text = "文件";
            this.rbnCustomFile.UseVisualStyleBackColor = true;
            // 
            // nodeId
            // 
            this.nodeId.Frozen = true;
            this.nodeId.HeaderText = "节点 ID";
            this.nodeId.MinimumWidth = 6;
            this.nodeId.Name = "nodeId";
            this.nodeId.ReadOnly = true;
            this.nodeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nodeId.Width = 40;
            // 
            // nodeType
            // 
            this.nodeType.HeaderText = "类型";
            this.nodeType.MinimumWidth = 6;
            this.nodeType.Name = "nodeType";
            this.nodeType.ReadOnly = true;
            this.nodeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nodeType.Width = 40;
            // 
            // nodeSize
            // 
            this.nodeSize.HeaderText = "大小 (字节)";
            this.nodeSize.MinimumWidth = 6;
            this.nodeSize.Name = "nodeSize";
            this.nodeSize.ReadOnly = true;
            this.nodeSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nodeSize.Width = 50;
            // 
            // nodeSizeHex
            // 
            this.nodeSizeHex.HeaderText = "大小 (十六进制)";
            this.nodeSizeHex.MinimumWidth = 6;
            this.nodeSizeHex.Name = "nodeSizeHex";
            this.nodeSizeHex.ReadOnly = true;
            this.nodeSizeHex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nodeSizeHex.Width = 50;
            // 
            // nodePath
            // 
            this.nodePath.FillWeight = 500F;
            this.nodePath.HeaderText = "路径";
            this.nodePath.MinimumWidth = 6;
            this.nodePath.Name = "nodePath";
            this.nodePath.ReadOnly = true;
            this.nodePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nodePath.Width = 400;
            // 
            // nodePadding
            // 
            this.nodePadding.HeaderText = "已添加填充";
            this.nodePadding.MinimumWidth = 6;
            this.nodePadding.Name = "nodePadding";
            this.nodePadding.ReadOnly = true;
            this.nodePadding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nodePadding.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "节点 ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "类型";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "大小 (字节)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "大小 (十六进制)";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 500F;
            this.dataGridViewTextBoxColumn5.HeaderText = "路径";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 400;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "已添加填充";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // FrmCompareTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1056, 617);
            this.Controls.Add(this.panelCus);
            this.Controls.Add(this.panelOri);
            this.Controls.Add(this.dgvCusTable);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.dgvOriTable);
            this.Controls.Add(this.btnCusBrowse);
            this.Controls.Add(this.btnOriBrowse);
            this.Controls.Add(this.tbxCustom);
            this.Controls.Add(this.tbxOriFile);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCompareTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "对比工具";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusTable)).EndInit();
            this.panelOri.ResumeLayout(false);
            this.panelOri.PerformLayout();
            this.panelCus.ResumeLayout(false);
            this.panelCus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOriFile;
        private System.Windows.Forms.TextBox tbxCustom;
        private System.Windows.Forms.Button btnOriBrowse;
        private System.Windows.Forms.Button btnCusBrowse;
        private System.Windows.Forms.DataGridView dgvOriTable;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.DataGridView dgvCusTable;
        private System.Windows.Forms.RadioButton rbnOriFile;
        private System.Windows.Forms.RadioButton rbnOriFolder;
        private System.Windows.Forms.Panel panelOri;
        private System.Windows.Forms.Panel panelCus;
        private System.Windows.Forms.RadioButton rbnCustomFolder;
        private System.Windows.Forms.RadioButton rbnCustomFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeSizeHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodePadding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}