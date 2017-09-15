using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MSR_Amiibo_Unlocker
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        OpenFileDialog open = new OpenFileDialog();
        List<int> amiibo = new List<int>();

        private void Open_button_Click(object sender, EventArgs e)
        {
            try
            {
                open.Filter = " pkprfl.bmssv Files |pkprfl.bmssv|All Files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    Reserve_tank_button.Enabled = true;
                    BinaryReader br = new BinaryReader(File.OpenRead(open.FileName));

                    for (int i = 0x2C; i < br.BaseStream.Length; i++)
                    {
                        br.BaseStream.Position = i;
                        if (br.ReadByte().ToString("X2") == "62")
                        {
                            var current = br.ReadByte().ToString("X2");
                            if (current == "00" || current == "01")
                            {
                                amiibo.Add(i + 1);
                            }
                        }
                    }
                    br.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid pkprfl.bmssv", "Failed to open the file");
                Reserve_tank_button.Enabled = false;
            }
        }

        private void Reserve_tank_button_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(open.FileName));

                for (int i = 0; i < amiibo.Count; i++)
                {
                    bw.BaseStream.Position = amiibo[i];
                    bw.Write(Convert.ToByte(1));
                }
                bw.Close();
                MessageBox.Show("All Reserve Tanks have been Unlocked!!!", "File Successfully Saved");
            }
            catch
            {
                MessageBox.Show("Failed to save onto file", "Error");
                Reserve_tank_button.Enabled = false;
            }
        }
    }
}
