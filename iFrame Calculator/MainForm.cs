using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTP_Viewer
{
    public partial class MainForm : Form
    {
        TTP driverInfo;
        TTP kartInfo;
        TTP wheelInfo;
        TTP gliderInfo;
        MDRP iFrameInfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void updateIFrames()
        {
            uint driverIndex = (uint)driverComboBox.SelectedIndex;
            uint kartIndex = (uint)kartComboBox.SelectedIndex;
            uint wheelIndex = (uint)wheelComboBox.SelectedIndex;
            uint gliderIndex = (uint)gliderComboBox.SelectedIndex;
            uint sum = 0;

            sum += driverInfo.getAttributeFromIndex(driverIndex) + kartInfo.getAttributeFromIndex(kartIndex)
                + wheelInfo.getAttributeFromIndex(wheelIndex) + gliderInfo.getAttributeFromIndex(gliderIndex);
            sum -= 1;
            if (sum >= 0x13) sum = 0x13;

            float frameInfo = iFrameInfo.getAttributeFromIndex(sum);

            iFrameFactorTextBox.Text = frameInfo.ToString();
            iFrameTextBox.Text = ((int)(frameInfo * 90.0) + 1).ToString();
        }

        private void openTTPFile(string fileName, ref TTP partInfo)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(fileName);
                partInfo = new TTP(bytes[4], bytes);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show(fileName + " not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }

        private void openMDRPFile(string fileName, ref MDRP partInfo)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(fileName);
                partInfo = new MDRP(bytes[4], bytes);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(fileName + " not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }
        private void initializeData()
        {
            openTTPFile("driver.ttp", ref driverInfo);
            openTTPFile("kart.ttp", ref kartInfo);
            openTTPFile("tire.ttp", ref wheelInfo);
            openTTPFile("glider.ttp", ref gliderInfo);
            openMDRPFile("iFrames.mdrp", ref iFrameInfo);

            driverComboBox.SelectedIndex = 0;
            kartComboBox.SelectedIndex = 0;
            wheelComboBox.SelectedIndex = 0;
            gliderComboBox.SelectedIndex = 0;
            updateIFrames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeData();
        }

        private void driverComboBox_TextChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void kartComboBox_TextChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void wheelComboBox_TextChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void gliderComboBox_TextChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: fishguy6564");
        }
    }
}
