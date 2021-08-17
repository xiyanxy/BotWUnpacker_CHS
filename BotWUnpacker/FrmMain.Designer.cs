using System.Reflection;

namespace BotwUnpacker
{
    partial class FrmMain
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
            System.Windows.Forms.PictureBox imgIcon;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.Label line1;
            this.btnBrowseRoot = new System.Windows.Forms.Button();
            this.btnExtractPack = new System.Windows.Forms.Button();
            this.btnBuildPack = new System.Windows.Forms.Button();
            this.lblFolderRoot = new System.Windows.Forms.Label();
            this.tbxFolderRoot = new System.Windows.Forms.TextBox();
            this.cbxWriteSarcXml = new System.Windows.Forms.CheckBox();
            this.cbxSetDataOffset = new System.Windows.Forms.CheckBox();
            this.tbxDataOffset = new System.Windows.Forms.TextBox();
            this.btnExtractAll = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnYaz0Decode = new System.Windows.Forms.Button();
            this.cbxNodeDecode = new System.Windows.Forms.CheckBox();
            this.cbxCompileAllInOneFolder = new System.Windows.Forms.CheckBox();
            this.btnYaz0Encode = new System.Windows.Forms.Button();
            this.btnCompareTool = new System.Windows.Forms.Button();
            this.btnPaddingTool = new System.Windows.Forms.Button();
            this.lblFootnote = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.loadingBar = new System.Windows.Forms.PictureBox();
            this.cbxWriteYaz0Xml = new System.Windows.Forms.CheckBox();
            this.rbnWiiU = new System.Windows.Forms.RadioButton();
            this.rbnSwitch = new System.Windows.Forms.RadioButton();
            imgIcon = new System.Windows.Forms.PictureBox();
            line1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(imgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            imgIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            imgIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgIcon.Image")));
            imgIcon.Location = new System.Drawing.Point(18, 19);
            imgIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            imgIcon.Name = "imgIcon";
            imgIcon.Size = new System.Drawing.Size(150, 153);
            imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgIcon.TabIndex = 99;
            imgIcon.TabStop = false;
            // 
            // line1
            // 
            line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            line1.Enabled = false;
            line1.Location = new System.Drawing.Point(18, 347);
            line1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            line1.Name = "line1";
            line1.Size = new System.Drawing.Size(534, 3);
            line1.TabIndex = 23;
            // 
            // btnBrowseRoot
            // 
            this.btnBrowseRoot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBrowseRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRoot.Location = new System.Drawing.Point(174, 83);
            this.btnBrowseRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseRoot.Name = "btnBrowseRoot";
            this.btnBrowseRoot.Size = new System.Drawing.Size(107, 36);
            this.btnBrowseRoot.TabIndex = 15;
            this.btnBrowseRoot.Text = "浏览";
            this.btnBrowseRoot.UseVisualStyleBackColor = true;
            this.btnBrowseRoot.Click += new System.EventHandler(this.btnBrowseRoot_Click);
            // 
            // btnExtractPack
            // 
            this.btnExtractPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractPack.Location = new System.Drawing.Point(18, 181);
            this.btnExtractPack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExtractPack.Name = "btnExtractPack";
            this.btnExtractPack.Size = new System.Drawing.Size(150, 36);
            this.btnExtractPack.TabIndex = 0;
            this.btnExtractPack.Text = "解包SARC文件";
            this.btnExtractPack.UseVisualStyleBackColor = true;
            this.btnExtractPack.Click += new System.EventHandler(this.btnExtractPack_Click);
            // 
            // btnBuildPack
            // 
            this.btnBuildPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildPack.Location = new System.Drawing.Point(18, 367);
            this.btnBuildPack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuildPack.Name = "btnBuildPack";
            this.btnBuildPack.Size = new System.Drawing.Size(152, 73);
            this.btnBuildPack.TabIndex = 5;
            this.btnBuildPack.Text = "打包SARC文件";
            this.btnBuildPack.UseVisualStyleBackColor = true;
            this.btnBuildPack.Click += new System.EventHandler(this.btnBuildPack_Click);
            // 
            // lblFolderRoot
            // 
            this.lblFolderRoot.AutoSize = true;
            this.lblFolderRoot.Location = new System.Drawing.Point(172, 19);
            this.lblFolderRoot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolderRoot.Name = "lblFolderRoot";
            this.lblFolderRoot.Size = new System.Drawing.Size(118, 20);
            this.lblFolderRoot.TabIndex = 5;
            this.lblFolderRoot.Text = "默认文件夹路径:";
            // 
            // tbxFolderRoot
            // 
            this.tbxFolderRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbxFolderRoot.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbxFolderRoot.Location = new System.Drawing.Point(174, 43);
            this.tbxFolderRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFolderRoot.Name = "tbxFolderRoot";
            this.tbxFolderRoot.Size = new System.Drawing.Size(378, 27);
            this.tbxFolderRoot.TabIndex = 14;
            this.tbxFolderRoot.TextChanged += new System.EventHandler(this.tbxFolderRoot_TextChanged);
            // 
            // cbxWriteSarcXml
            // 
            this.cbxWriteSarcXml.AutoSize = true;
            this.cbxWriteSarcXml.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbxWriteSarcXml.Location = new System.Drawing.Point(177, 188);
            this.cbxWriteSarcXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxWriteSarcXml.Name = "cbxWriteSarcXml";
            this.cbxWriteSarcXml.Size = new System.Drawing.Size(149, 24);
            this.cbxWriteSarcXml.TabIndex = 100;
            this.cbxWriteSarcXml.Text = "导出Xml测试文件";
            this.cbxWriteSarcXml.UseVisualStyleBackColor = true;
            // 
            // cbxSetDataOffset
            // 
            this.cbxSetDataOffset.AutoSize = true;
            this.cbxSetDataOffset.Location = new System.Drawing.Point(177, 367);
            this.cbxSetDataOffset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSetDataOffset.Name = "cbxSetDataOffset";
            this.cbxSetDataOffset.Size = new System.Drawing.Size(138, 24);
            this.cbxSetDataOffset.TabIndex = 6;
            this.cbxSetDataOffset.Text = "设置数据偏移0x";
            this.cbxSetDataOffset.UseVisualStyleBackColor = true;
            this.cbxSetDataOffset.CheckedChanged += new System.EventHandler(this.cbxSetDataOffset_CheckedChanged);
            this.cbxSetDataOffset.MouseHover += new System.EventHandler(this.cbxSetDataOffset_MouseHover);
            // 
            // tbxDataOffset
            // 
            this.tbxDataOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tbxDataOffset.Enabled = false;
            this.tbxDataOffset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbxDataOffset.Location = new System.Drawing.Point(323, 364);
            this.tbxDataOffset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDataOffset.MaxLength = 4;
            this.tbxDataOffset.Name = "tbxDataOffset";
            this.tbxDataOffset.ReadOnly = true;
            this.tbxDataOffset.Size = new System.Drawing.Size(46, 27);
            this.tbxDataOffset.TabIndex = 7;
            this.tbxDataOffset.Text = "2000";
            // 
            // btnExtractAll
            // 
            this.btnExtractAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractAll.Location = new System.Drawing.Point(18, 227);
            this.btnExtractAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExtractAll.Name = "btnExtractAll";
            this.btnExtractAll.Size = new System.Drawing.Size(150, 36);
            this.btnExtractAll.TabIndex = 1;
            this.btnExtractAll.Text = "解包全部文件";
            this.btnExtractAll.UseVisualStyleBackColor = true;
            this.btnExtractAll.Click += new System.EventHandler(this.btnExtractAll_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Location = new System.Drawing.Point(289, 83);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(126, 36);
            this.btnOpenFolder.TabIndex = 16;
            this.btnOpenFolder.Text = "打开文件夹";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnYaz0Decode
            // 
            this.btnYaz0Decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYaz0Decode.Location = new System.Drawing.Point(18, 271);
            this.btnYaz0Decode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYaz0Decode.Name = "btnYaz0Decode";
            this.btnYaz0Decode.Size = new System.Drawing.Size(150, 36);
            this.btnYaz0Decode.TabIndex = 3;
            this.btnYaz0Decode.Text = "Yaz0文件解码";
            this.btnYaz0Decode.UseVisualStyleBackColor = true;
            this.btnYaz0Decode.Click += new System.EventHandler(this.btnYaz0Decode_Click);
            // 
            // cbxNodeDecode
            // 
            this.cbxNodeDecode.AutoSize = true;
            this.cbxNodeDecode.Location = new System.Drawing.Point(18, 316);
            this.cbxNodeDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNodeDecode.Name = "cbxNodeDecode";
            this.cbxNodeDecode.Size = new System.Drawing.Size(121, 24);
            this.cbxNodeDecode.TabIndex = 4;
            this.cbxNodeDecode.Text = "自动解码文件";
            this.cbxNodeDecode.UseVisualStyleBackColor = true;
            this.cbxNodeDecode.MouseHover += new System.EventHandler(this.cbxNodeDecode_MouseHover);
            // 
            // cbxCompileAllInOneFolder
            // 
            this.cbxCompileAllInOneFolder.AutoSize = true;
            this.cbxCompileAllInOneFolder.Location = new System.Drawing.Point(177, 232);
            this.cbxCompileAllInOneFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCompileAllInOneFolder.Name = "cbxCompileAllInOneFolder";
            this.cbxCompileAllInOneFolder.Size = new System.Drawing.Size(181, 24);
            this.cbxCompileAllInOneFolder.TabIndex = 2;
            this.cbxCompileAllInOneFolder.Text = "全部编译到同一文件夹";
            this.cbxCompileAllInOneFolder.UseVisualStyleBackColor = true;
            // 
            // btnYaz0Encode
            // 
            this.btnYaz0Encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYaz0Encode.Location = new System.Drawing.Point(18, 449);
            this.btnYaz0Encode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYaz0Encode.Name = "btnYaz0Encode";
            this.btnYaz0Encode.Size = new System.Drawing.Size(150, 36);
            this.btnYaz0Encode.TabIndex = 10;
            this.btnYaz0Encode.Text = "Yaz0文件编码";
            this.btnYaz0Encode.UseVisualStyleBackColor = true;
            this.btnYaz0Encode.Click += new System.EventHandler(this.btnYaz0Encode_Click);
            // 
            // btnCompareTool
            // 
            this.btnCompareTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompareTool.Location = new System.Drawing.Point(408, 367);
            this.btnCompareTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompareTool.Name = "btnCompareTool";
            this.btnCompareTool.Size = new System.Drawing.Size(150, 73);
            this.btnCompareTool.TabIndex = 11;
            this.btnCompareTool.Text = "对比工具";
            this.btnCompareTool.UseVisualStyleBackColor = false;
            this.btnCompareTool.Click += new System.EventHandler(this.btnCompareAndBuild_Click);
            // 
            // btnPaddingTool
            // 
            this.btnPaddingTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaddingTool.Location = new System.Drawing.Point(408, 449);
            this.btnPaddingTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaddingTool.Name = "btnPaddingTool";
            this.btnPaddingTool.Size = new System.Drawing.Size(150, 73);
            this.btnPaddingTool.TabIndex = 12;
            this.btnPaddingTool.Text = "填充工具";
            this.btnPaddingTool.UseVisualStyleBackColor = false;
            this.btnPaddingTool.Click += new System.EventHandler(this.btnSarcEditor_Click);
            // 
            // lblFootnote
            // 
            this.lblFootnote.AutoSize = true;
            this.lblFootnote.Location = new System.Drawing.Point(18, 532);
            this.lblFootnote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFootnote.Name = "lblFootnote";
            this.lblFootnote.Size = new System.Drawing.Size(77, 20);
            this.lblFootnote.TabIndex = 27;
            this.lblFootnote.Text = "Footnote";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // loadingBar
            // 
            this.loadingBar.Image = ((System.Drawing.Image)(resources.GetObject("loadingBar.Image")));
            this.loadingBar.Location = new System.Drawing.Point(18, 493);
            this.loadingBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(269, 33);
            this.loadingBar.TabIndex = 100;
            this.loadingBar.TabStop = false;
            this.loadingBar.Visible = false;
            // 
            // cbxWriteYaz0Xml
            // 
            this.cbxWriteYaz0Xml.AutoSize = true;
            this.cbxWriteYaz0Xml.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbxWriteYaz0Xml.Location = new System.Drawing.Point(177, 277);
            this.cbxWriteYaz0Xml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxWriteYaz0Xml.Name = "cbxWriteYaz0Xml";
            this.cbxWriteYaz0Xml.Size = new System.Drawing.Size(149, 24);
            this.cbxWriteYaz0Xml.TabIndex = 101;
            this.cbxWriteYaz0Xml.Text = "导出Xml测试文件";
            this.cbxWriteYaz0Xml.UseVisualStyleBackColor = true;
            // 
            // rbnWiiU
            // 
            this.rbnWiiU.AutoSize = true;
            this.rbnWiiU.Checked = true;
            this.rbnWiiU.Location = new System.Drawing.Point(177, 401);
            this.rbnWiiU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnWiiU.Name = "rbnWiiU";
            this.rbnWiiU.Size = new System.Drawing.Size(64, 24);
            this.rbnWiiU.TabIndex = 8;
            this.rbnWiiU.TabStop = true;
            this.rbnWiiU.Text = "WiiU";
            this.rbnWiiU.UseVisualStyleBackColor = true;
            // 
            // rbnSwitch
            // 
            this.rbnSwitch.AutoSize = true;
            this.rbnSwitch.Location = new System.Drawing.Point(249, 401);
            this.rbnSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnSwitch.Name = "rbnSwitch";
            this.rbnSwitch.Size = new System.Drawing.Size(78, 24);
            this.rbnSwitch.TabIndex = 9;
            this.rbnSwitch.Text = "Switch";
            this.rbnSwitch.UseVisualStyleBackColor = true;
            this.rbnSwitch.CheckedChanged += new System.EventHandler(this.rbnSwitch_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(576, 617);
            this.Controls.Add(this.rbnSwitch);
            this.Controls.Add(this.rbnWiiU);
            this.Controls.Add(this.cbxWriteYaz0Xml);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.lblFootnote);
            this.Controls.Add(this.btnPaddingTool);
            this.Controls.Add(this.btnCompareTool);
            this.Controls.Add(line1);
            this.Controls.Add(this.btnYaz0Encode);
            this.Controls.Add(this.cbxCompileAllInOneFolder);
            this.Controls.Add(this.cbxNodeDecode);
            this.Controls.Add(this.btnYaz0Decode);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnExtractAll);
            this.Controls.Add(this.tbxDataOffset);
            this.Controls.Add(this.cbxSetDataOffset);
            this.Controls.Add(this.cbxWriteSarcXml);
            this.Controls.Add(this.tbxFolderRoot);
            this.Controls.Add(this.lblFolderRoot);
            this.Controls.Add(this.btnBrowseRoot);
            this.Controls.Add(this.btnBuildPack);
            this.Controls.Add(this.btnExtractPack);
            this.Controls.Add(imgIcon);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BotW Unpacker";
            ((System.ComponentModel.ISupportInitialize)(imgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowseRoot;
        private System.Windows.Forms.Button btnExtractPack;
        private System.Windows.Forms.Button btnBuildPack;
        private System.Windows.Forms.Label lblFolderRoot;
        private System.Windows.Forms.TextBox tbxFolderRoot;
        private System.Windows.Forms.CheckBox cbxWriteSarcXml;
        private System.Windows.Forms.CheckBox cbxSetDataOffset;
        private System.Windows.Forms.TextBox tbxDataOffset;
        private System.Windows.Forms.Button btnExtractAll;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnYaz0Decode;
        private System.Windows.Forms.CheckBox cbxNodeDecode;
        private System.Windows.Forms.CheckBox cbxCompileAllInOneFolder;
        private System.Windows.Forms.Button btnYaz0Encode;
        private System.Windows.Forms.Button btnCompareTool;
        private System.Windows.Forms.Button btnPaddingTool;
        private System.Windows.Forms.Label lblFootnote;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox loadingBar;
        private System.Windows.Forms.CheckBox cbxWriteYaz0Xml;
        private System.Windows.Forms.RadioButton rbnWiiU;
        private System.Windows.Forms.RadioButton rbnSwitch;
    }
}

