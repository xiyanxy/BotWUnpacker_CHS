using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;

namespace BotwUnpacker
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //Load in previous instance
            tbxFolderRoot.Text = BotwUnpacker.Properties.Settings.Default.RootFolder;
            if (tbxFolderRoot.Text != "") btnExtractAll.Enabled = true;
            if (tbxFolderRoot.Text != "") btnOpenFolder.Enabled = true;
            cbxNodeDecode.Checked = true;

            if (BotwUnpacker.Properties.Settings.Default.LittleEndian)
            {
                rbnWiiU.Checked = false;
                rbnSwitch.Checked = true;
            }

            cbxWriteSarcXml.Visible = false; //hidden for release version
            cbxWriteYaz0Xml.Visible = false; //hidden for release version

            lblFootnote.Text = "版本: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "\n作者: Shadsterwolf  汉化: 曦颜XY\n借鉴并修改UWizard SARC";
        }

        #region Button Browse Root 
        private void btnBrowseRoot_Click(object sender, EventArgs e) //Browse Root button
        {
            CommonOpenFileDialog oFolder = new CommonOpenFileDialog();
            oFolder.IsFolderPicker = true;
            if (tbxFolderRoot.Text != "")
                oFolder.InitialDirectory = tbxFolderRoot.Text;
            if (oFolder.ShowDialog() == CommonFileDialogResult.Cancel) goto toss;
            tbxFolderRoot.Text = oFolder.FileName;
            btnExtractAll.Enabled = true;
            btnOpenFolder.Enabled = true;

            //Save GameRoot property
            BotwUnpacker.Properties.Settings.Default.RootFolder = oFolder.FileName;
            BotwUnpacker.Properties.Settings.Default.Save();

            toss:
            oFolder.Dispose();
        }
        #endregion

        #region Button Extract Pack
        private void btnExtractPack_Click(object sender, EventArgs e) //Extract Pack button
        {
            loadingBar.Visible = true;
            OpenFileDialog oFile = new OpenFileDialog();
            if (tbxFolderRoot.Text != "") oFile.InitialDirectory = tbxFolderRoot.Text;
            if (oFile.ShowDialog() == DialogResult.Cancel) goto toss;

            String oFolderName = Path.GetFileNameWithoutExtension(oFile.FileName);
            String oFolderPath = Path.GetDirectoryName(oFile.FileName) + "\\" + oFolderName;

            // if the output folder exists, prompt user if they want to extract anyway
            if (Directory.Exists(oFolderPath))
                if (MessageBox.Show(oFolderName + "存在!" + "\n\n" + "仍要继续?", "覆盖吗?", MessageBoxButtons.YesNo) == DialogResult.No) goto xml;

            //SARC
            bool boolAutoDecode = false;
            bool boolNodeDecode = false;
            if (cbxNodeDecode.Checked) //Node Yaz0 decoding
                boolNodeDecode = true;
            else //Default, without any checkboxes
            {
                if (SARC.IsYaz0File(oFile.FileName))
                {
                    if (MessageBox.Show("该文件存在Yaz0编码！" + "\n\n" + "解码并尝试解包吗?", "解码并解包吗?", MessageBoxButtons.YesNo) != DialogResult.No)
                        boolAutoDecode = true; //Auto decode just this once since we prompted
                    else
                        goto toss; //User clicked no
                }
            }
            if (!SARC.Extract(oFile.FileName, oFolderPath, boolAutoDecode, boolNodeDecode)) //Extraction
            {
                MessageBox.Show("解包失败:" + "\n\n" + SARC.lerror);
                goto toss;
            }
            else
                System.Diagnostics.Process.Start(oFolderPath);

            //XML
            xml:
            if (cbxWriteSarcXml.Checked)
            {
                if (File.Exists(oFolderPath + "_SarcDebug.xml"))
                    if (MessageBox.Show(oFolderName + ".xml存在!" + "\n\n" + "仍要继续?", "覆盖吗?", MessageBoxButtons.YesNo) == DialogResult.No) goto toss;
                if (!DebugWriter.WriteSarcXml(oFile.FileName, (oFolderPath + "_SarcDebug.xml")))
                    MessageBox.Show("XML文件因未知原因无法导出");
            }

            toss:
            oFile.Dispose();
            GC.Collect();
            loadingBar.Visible = false;
        }
        #endregion

        #region Button Extract All
        private void btnExtractAll_Click(object sender, EventArgs e)
        {
            if (tbxFolderRoot.Text == "")
            {
                MessageBox.Show("首先设置要解包的默认文件夹！");
                goto toss;
            }
            if (!(Directory.Exists(tbxFolderRoot.Text)))
            {
                MessageBox.Show("错误：路径无效" + "\n" + tbxFolderRoot.Text);
                goto toss;
            }
            loadingBar.Visible = true;
            if (cbxCompileAllInOneFolder.Checked) { if (MessageBox.Show("从默认路径解包所有SARC数据类型文件?" + "\n" + tbxFolderRoot.Text + "\n" + "*这不包括子文件夹" + "\n\n" + "你选择将所有提取的数据编译到一个文件夹中！" + "\n" + "然后，你将选择一个文件夹，将它们全部放在里面。", "确定吗?", MessageBoxButtons.YesNo) == DialogResult.No) goto toss; }
            else { if (MessageBox.Show("从默认路径解包所有SARC数据类型文件?" + "\n" + tbxFolderRoot.Text + "\n" + "*这不包括子文件夹" + "\n\n" + "这将生成每个文件的单独文件夹！", "确定吗?", MessageBoxButtons.YesNo) == DialogResult.No) goto toss; }
            DirectoryInfo dirFolder = new DirectoryInfo(tbxFolderRoot.Text);


            String oFolderName, oFolderPath;
            int sarcFileCount = 0;
            bool boolAutoDecode = false;
            bool boolNodeDecode = false;
            if (cbxNodeDecode.Checked) //Auto Yaz0 decoding
            {
                boolNodeDecode = true;
            }

            if (cbxCompileAllInOneFolder.Checked) //Compile All to New Folder
            {
                CommonOpenFileDialog oFolder = new CommonOpenFileDialog();
                oFolder.IsFolderPicker = true;
                if (tbxFolderRoot.Text != "") oFolder.InitialDirectory = tbxFolderRoot.Text;
                if (oFolder.ShowDialog() == CommonFileDialogResult.Cancel) goto toss;
                foreach (FileInfo file in dirFolder.GetFiles()) //Extraction
                {
                    oFolderName = Path.GetFileNameWithoutExtension(file.FullName);
                    oFolderPath = oFolder.FileName;
                    if (SARC.Extract(file.FullName, oFolderPath, boolAutoDecode, boolNodeDecode))
                        sarcFileCount++;
                }

            }
            else
            {
                foreach (FileInfo file in dirFolder.GetFiles()) //Extraction
                {
                    oFolderName = Path.GetFileNameWithoutExtension(file.FullName);
                    oFolderPath = Path.GetDirectoryName(file.FullName) + "\\" + oFolderName;
                    if (SARC.Extract(file.FullName, oFolderPath, boolAutoDecode, boolNodeDecode))
                        sarcFileCount++;
                }
            }

            MessageBox.Show("完成" + "\n\n" + sarcFileCount + "文件解包！");

            toss:
            GC.Collect();
            loadingBar.Visible = false;
        }
        #endregion

        #region Button Yaz0 Decode
        private void btnYaz0Decode_Click(object sender, EventArgs e)
        {
            loadingBar.Visible = true;
            OpenFileDialog oFile = new OpenFileDialog();
            if (tbxFolderRoot.Text != "") oFile.InitialDirectory = tbxFolderRoot.Text;
            if (oFile.ShowDialog() == DialogResult.Cancel) goto toss;
            string outFile = oFile.FileName;
            {
                if (!Yaz0.Decode(oFile.FileName, Yaz0.DecodeOutputFileRename(oFile.FileName)))
                {
                    MessageBox.Show("解码失败:" + "\n\n" + Yaz0.lerror);
                    goto toss;
                }
            }

            //XML
            if (cbxWriteYaz0Xml.Checked)
            {
                String oFolderName = Path.GetFileNameWithoutExtension(oFile.FileName);
                String oFolderPath = Path.GetDirectoryName(oFile.FileName) + "\\" + oFolderName;
                if (File.Exists(oFolderPath + "_Yaz0Debug.xml"))
                    if (MessageBox.Show(oFolderName + ".xml存在!" + "\n\n" + "仍要继续?", "覆盖吗?", MessageBoxButtons.YesNo) == DialogResult.No) goto toss;
                if (!DebugWriter.WriteYaz0Xml(oFile.FileName, (oFolderPath + "_Yaz0Debug.xml")))
                    MessageBox.Show("XML文件因未知原因无法导出");
            }

            MessageBox.Show("解码完成!" + "\n\n" + outFile);

            toss:
            oFile.Dispose();
            GC.Collect();
            loadingBar.Visible = false;
        }
        #endregion

        #region Button Yaz0 Encode
        private async void btnYaz0Encode_Click(object sender, EventArgs e)
        {
            loadingBar.Visible = true;
            OpenFileDialog oFile = new OpenFileDialog();
            if (tbxFolderRoot.Text != "") oFile.InitialDirectory = tbxFolderRoot.Text;
            if (!(oFile.ShowDialog() == DialogResult.Cancel))
            {
                if (!SARC.IsYaz0File(oFile.FileName))
                {
                    string outFile = Yaz0.EncodeOutputFileRename(oFile.FileName);
                    if (File.Exists(outFile))
                    {
                        if (MessageBox.Show(Path.GetFileName(outFile) + "存在!" + "\n\n" + "仍要继续?", "覆盖吗?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            await Encode(oFile.FileName, outFile);
                    }
                    else
                        await Encode(oFile.FileName, outFile);
                }
                else
                    MessageBox.Show("编码失败:" + "\n\n" + "该文件已经Yaz0编码！");
            }
            oFile.Dispose();
            loadingBar.Visible = false;
        }

        private async Task Encode(string inFile, string outFile) //Yaz0 Encode
        {
            bool result;
            if (result = await Task.Run(() => Yaz0.Encode(inFile, outFile)))
                MessageBox.Show("编码完成！" + "\n\n" + outFile);
            else
                MessageBox.Show("编码失败:" + "\n\n" + Yaz0.lerror);
        }
        #endregion

        #region Button Build Pack 
        private void btnBuildPack_Click(object sender, EventArgs e) // Build Pack button
        {
            loadingBar.Visible = true;
            CommonOpenFileDialog oFolder = new CommonOpenFileDialog();
            oFolder.IsFolderPicker = true;
            SaveFileDialog sFile = new SaveFileDialog();

            if (cbxSetDataOffset.Checked)
            {
                try{int.Parse(tbxDataOffset.Text, System.Globalization.NumberStyles.HexNumber);} //check if it's a hex value (textbox limited to 4 characters)
                catch{MessageBox.Show("错误:" + "\n\n" + "固定数据偏移量不是十六进制值！"); goto toss;}
            }
            if (tbxFolderRoot.Text != "") oFolder.InitialDirectory = tbxFolderRoot.Text;
            if (oFolder.ShowDialog() == CommonFileDialogResult.Cancel) goto toss;
            int numFiles = Directory.GetFiles(oFolder.FileName, "*", SearchOption.AllDirectories).Length;            

            sFile.Filter = "全部文件|*.*";
            sFile.InitialDirectory = oFolder.FileName.Remove(oFolder.FileName.LastIndexOf("\\")); //Previous folder, as selected is to build outside of it.
            sFile.FileName = System.IO.Path.GetFileName(oFolder.FileName);
            if (sFile.ShowDialog() == DialogResult.Cancel) goto toss;

            uint dataOffset = 0;
            if (cbxSetDataOffset.Checked)
                dataOffset = (uint)int.Parse(tbxDataOffset.Text, System.Globalization.NumberStyles.HexNumber);

            if (SARC.Build(oFolder.FileName, sFile.FileName, dataOffset, rbnSwitch.Checked)) //Build
                MessageBox.Show("构建完成!" + "\n\n" + sFile.FileName);
            else
                MessageBox.Show("构建失败！" + "\n\n" + SARC.lerror);


            toss:
            oFolder.Dispose();
            sFile.Dispose();
            GC.Collect();
            loadingBar.Visible = false;
        }
        #endregion

        private void cbxSetDataOffset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSetDataOffset.Checked)
            {
                tbxDataOffset.Enabled = true;
            }
            else
            {
                tbxDataOffset.Enabled = false;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (tbxFolderRoot.Text == "")
            {
                MessageBox.Show("首先需设置默认文件夹！");
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(tbxFolderRoot.Text);
                }
                catch
                {
                    MessageBox.Show("错误：路径无效" + "\n" + tbxFolderRoot.Text);
                }
            }
        }

        private void tbxFolderRoot_TextChanged(object sender, EventArgs e)
        {
            if (tbxFolderRoot.Text == "")
                BotwUnpacker.Properties.Settings.Default.RootFolder = "";
            else
                BotwUnpacker.Properties.Settings.Default.RootFolder = tbxFolderRoot.Text;
            BotwUnpacker.Properties.Settings.Default.Save();
        }        
        
        FrmCompareTool frmCompareBuild = new FrmCompareTool();
        private void btnCompareAndBuild_Click(object sender, EventArgs e)
        {
            if (!(frmCompareBuild.Visible))
            {
                if (frmCompareBuild.IsDisposed)
                    frmCompareBuild = new FrmCompareTool();
                frmCompareBuild.StartPosition = FormStartPosition.Manual;
                frmCompareBuild.Location = new Point (FrmMain.ActiveForm.DesktopLocation.X + 380, FrmMain.ActiveForm.DesktopLocation.Y);
                frmCompareBuild.Show();
            }
            else
            {
                frmCompareBuild.Refresh();
                if (frmCompareBuild.WindowState == FormWindowState.Minimized)
                    frmCompareBuild.WindowState = FormWindowState.Normal;
                frmCompareBuild.BringToFront();
            }

        }

        FrmPaddingTool frmPaddingEditor = new FrmPaddingTool();
        private void btnSarcEditor_Click(object sender, EventArgs e)
        {
            if (!(frmPaddingEditor.Visible))
            {
                if (frmPaddingEditor.IsDisposed)
                    frmPaddingEditor = new FrmPaddingTool();
                frmPaddingEditor.StartPosition = FormStartPosition.Manual;
                frmPaddingEditor.Location = new Point(FrmMain.ActiveForm.DesktopLocation.X + 380, FrmMain.ActiveForm.DesktopLocation.Y);
                frmPaddingEditor.Show();
            }
            else
            {
                frmPaddingEditor.Refresh();
                if (frmPaddingEditor.WindowState == FormWindowState.Minimized)
                    frmPaddingEditor.WindowState = FormWindowState.Normal;
                frmPaddingEditor.BringToFront();
            }
        }

        ToolTip t1 = new ToolTip();
        private void cbxSetDataOffset_MouseHover(object sender, EventArgs e)
        {
            t1.Show("如果要构建需设置节点数据的起始位置（仅适用于特殊情况）", cbxSetDataOffset);
        }

        private void cbxNodeDecode_MouseHover(object sender, EventArgs e)
        {
            t1.Show("这将解码所有未打包的节点文件（还将保留编码文件）", cbxNodeDecode);
        }

        private void rbnSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSwitch.Checked == true)
                BotwUnpacker.Properties.Settings.Default.LittleEndian = true;
            else
                BotwUnpacker.Properties.Settings.Default.LittleEndian = false;
            BotwUnpacker.Properties.Settings.Default.Save();
        }
    }
}
