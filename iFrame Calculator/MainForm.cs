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

        private uint getMiiReplacementID()
        {
            switch(miiSizeComboBox.SelectedIndex)
            {
                case 0:
                    return 0x11;
                case 1:
                    return 0;
                case 2:
                    return 0xA;
                default:
                    return 0;
            }
        }

        private uint getAttributeSum()
        {
            uint driverIndex = (uint)driverComboBox.SelectedIndex;
            uint kartIndex = (uint)kartComboBox.SelectedIndex;
            uint wheelIndex = (uint)wheelComboBox.SelectedIndex;
            uint gliderIndex = (uint)gliderComboBox.SelectedIndex;
            uint attributeSum;

            if (driverIndex == 0x1D) driverIndex = getMiiReplacementID();

            attributeSum = driverInfo.getAttributeFromIndex(driverIndex) + kartInfo.getAttributeFromIndex(kartIndex)
                         + wheelInfo.getAttributeFromIndex(wheelIndex) + gliderInfo.getAttributeFromIndex(gliderIndex);
            attributeSum -= 1;

            if (attributeSum >= 0x13) return 0x13;
            return attributeSum;
        }

        private float getInvincibilityFrameConstant()
        {
            int damageBitField = 0xFAE8A;
            int damageType = (int)damageTypeComboBox.SelectedIndex;
            if (((damageBitField >> damageType) & 1) == 1) return 90.0f;
            return 60.0f;
        }

        private void updateMiiState()
        {
            uint driverIndex = (uint)driverComboBox.SelectedIndex;
            if (driverIndex == 0x1D) miiSizeComboBox.Enabled = true;
            else miiSizeComboBox.Enabled = false;
        }

        private void updateIFrames()
        {

            uint attributeSum;
            float frameInfo;
            float iFrameConstant;

            attributeSum = getAttributeSum();
            frameInfo = iFrameInfo.getAttributeFromIndex(attributeSum);
            iFrameConstant = getInvincibilityFrameConstant();

            iFrameFactorTextBox.Text = frameInfo.ToString();
            iFrameTextBox.Text = ((int)(frameInfo * iFrameConstant) + 1).ToString();
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
            miiSizeComboBox.SelectedIndex = 0;
            damageTypeComboBox.SelectedIndex = 0;
            updateIFrames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeData();
        }
        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMiiState();
            updateIFrames();
        }

        private void kartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void wheelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void gliderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void miiSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void damageTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIFrames();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: fishguy6564", "Credits");
        }
    }
}
