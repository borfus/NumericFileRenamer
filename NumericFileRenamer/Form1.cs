using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericFileRenamer
{
    public partial class Form1 : Form
    {
        ToolTip toolTip;
        bool directoryChosen = false;
        string directory;

        public Form1()
        {
            InitializeComponent();
            numName.Maximum = decimal.MaxValue;
            toolTip = new ToolTip();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                // Fail and print message if user hasn't chosen directory.
                if (!directoryChosen) { MessageBox.Show("Please choose a directory before renaming."); }
                else
                {
                    var files = new DirectoryInfo(directory).GetFiles().Where(x => (x.Attributes & FileAttributes.Hidden) == 0);

                    /*
                     * Variable "files" is not sorted in the natural number order.
                     * Instead it uses sorting as such: 1, 10, 11, 2, 20, 3, 45, etc
                     */

                    int i = 0;
                    foreach (var f in files)
                    {
                        string temp = directory + "\\" + (numName.Value + i) + f.Extension;
                        while (File.Exists(temp))
                        {
                            i++;
                            temp = directory + "\\" + (numName.Value + i) + f.Extension;
                        }

                        File.Move(f.FullName, temp);
                        i++;
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Something happened and the program broke.\n" + exp.ToString());
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                directory = dlg.SelectedPath;
                if (!truncateLabel())
                {
                    lblDirectory.Text = "Dir: " + directory.ToString();
                }
                toolTip.SetToolTip(lblDirectory, directory.ToString());
                directoryChosen = true;
                btnRename.Enabled = true;
            }
            else
            {
                // Prevents crash if no directory chosen.
            }
        }

        private bool truncateLabel()
        {
            string temp = "Dir: " + directory;
            if (temp.Length > 42)
            {
                temp = temp.Substring(0, 39) + "...";
                lblDirectory.Text = temp;
                return true;
            }
            return false;
        }
    }
}
