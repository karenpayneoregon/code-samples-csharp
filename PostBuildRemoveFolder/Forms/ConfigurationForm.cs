using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PostBuildRemoveFolder.Classes;

namespace PostBuildRemoveFolder.Forms
{
    public partial class ConfigurationForm : Form
    {
        private ApplicationSettings _ApplicationSettings = new ApplicationSettings();
        public ApplicationSettings ApplicationSettings { get { return _ApplicationSettings; } }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        public ConfigurationForm()
        {
            InitializeComponent();
            Shown += ConfigurationForm_Shown;
        }
        /// <summary>
        /// Read json file, get paths and files names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigurationForm_Shown(object sender, EventArgs e)
        {
            try
            {

                var btn = new Button();
                btn.Size = new Size(25, txtExcelFileName.ClientSize.Height + 2);
                btn.Location = new Point(txtExcelFileName.ClientSize.Width - btn.Width, -1);
                btn.Cursor = Cursors.Default;
                btn.Click += OpenExcelFileClick;

                btn.Image = Properties.Resources.Excel_small;
                txtExcelFileName.Controls.Add(btn);
                // Send EM_SETMARGINS to prevent text from disappearing underneath the button
                SendMessage(txtExcelFileName.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));


                var config = new Configuration();

                txtDestinationPath.Text = config.Settings.DestinationPath;
                txtPdfDocumentPath.Text = config.Settings.PdfFileLocationPath;
                txtExcelFileName.Text = Path.Combine(config.Settings.ExcelFileLocationPath,config.Settings.ExcelFileName);
                txtSheetName.Text = config.Settings.WorkSheetName;
                chkLoadOnStartUp.Checked = config.Settings.LoadOnStartUp;

                //var ops = new Operations();
                //var sheets = ops.WorkSheets(txtExcelFileName.Text);

                // make TextBox inputs read-only to prevent bad entries
                Controls.OfType<TextBox>().ToList().ForEach(tb =>
                {
                    tb.ReadOnly = true;
                    tb.BackColor = Color.LightYellow;
                });

                ActiveControl = txtDestinationPath;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Try and open Excel file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExcelFileClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(txtExcelFileName.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to open Excel file{Environment.NewLine}{ex.Message}");
            }
        }

        private void cmdSelectDestimationPath_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdSelectPdfPath_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdSelectExcelFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExcelFileName.Text))
            {                
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(txtExcelFileName.Text);
                openFileDialog1.FileName = txtExcelFileName.Text;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtExcelFileName.Text = openFileDialog1.FileName;
                }
            }
        }
        /// <summary>
        /// Set Worksheet name to read from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSelectWorkSheet_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Save back to configuration file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            _ApplicationSettings.DestinationPath = txtDestinationPath.Text;
            _ApplicationSettings.PdfFileLocationPath = txtPdfDocumentPath.Text;
            _ApplicationSettings.ExcelFileLocationPath = Path.GetDirectoryName(txtExcelFileName.Text);
            _ApplicationSettings.ExcelFileName = Path.GetFileName(txtExcelFileName.Text);
            _ApplicationSettings.WorkSheetName = txtSheetName.Text;
            _ApplicationSettings.LoadOnStartUp = chkLoadOnStartUp.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}
