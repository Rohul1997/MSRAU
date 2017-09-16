using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MSRAU
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        OpenFileDialog open = new OpenFileDialog();
        List<int> Tank_addresses = new List<int>();
        List<string> Tank_values = new List<string>();

        private void Open_button_Click(object sender, EventArgs e)
        {
            try
            {
                open.Filter = " pkprfl.bmssv Files |pkprfl.bmssv|All Files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    Save_button.Enabled = true;
                    Reserve_tanks_checkBox.Enabled = true;
                    Normal_radioButton.Enabled = true;
                    Hard_radioButton.Enabled = true;
                    Fusion_radioButton.Enabled = true;
                    BinaryReader br = new BinaryReader(File.OpenRead(open.FileName));

                    for (int i = 0x2C; i < br.BaseStream.Length; i++)
                    {
                        br.BaseStream.Position = i;
                        if (br.ReadByte().ToString("X2") == "62")
                        {
                            var current = br.ReadByte().ToString("X2");
                            if (current == "00" || current == "01")
                            {
                                Tank_addresses.Add(i + 1);
                                Tank_values.Add(current);
                            }
                        }
                    }
                    if (Tank_values[0] == "01" && Tank_values[1] == "01" && Tank_values[2] == "01" && Tank_values[3] == "01" && Tank_values[4] == "01" && Tank_values[5] == "01")
                    {
                        Reserve_tanks_checkBox.Checked = true;
                    }

                    br.BaseStream.Position = 0x28;
                    var Mode_check = br.ReadByte().ToString("X2");
                    if (Mode_check == "00")
                    {
                        Normal_radioButton.Checked = true;
                    }
                    else if (Mode_check == "01")
                    {
                        Hard_radioButton.Checked = true;
                    }
                    else if (Mode_check == "02")
                    {
                        Fusion_radioButton.Checked = true;
                    }
                    br.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid pkprfl.bmssv", "Failed to open the file");
                Save_button.Enabled = false;
                Reserve_tanks_checkBox.Enabled = false;
                Normal_radioButton.Enabled = false;
                Hard_radioButton.Enabled = false;
                Fusion_radioButton.Enabled = false;
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(open.FileName));

                if (Reserve_tanks_checkBox.Checked == true)
                {
                    for (int i = 0; i < Tank_addresses.Count; i++)
                    {
                        bw.BaseStream.Position = Tank_addresses[i];
                        bw.Write(Convert.ToByte(1));
                    }
                }
                else
                {
                    for (int i = 0; i < Tank_addresses.Count; i++)
                    {
                        bw.BaseStream.Position = Tank_addresses[i];
                        bw.Write(Convert.ToByte(0));
                    }
                }

                if (Normal_radioButton.Checked == true)
                {
                    bw.BaseStream.Position = 0x28;
                    bw.Write(0x00);
                } else if (Hard_radioButton.Checked == true)
                {
                    bw.BaseStream.Position = 0x28;
                    bw.Write(0x01);
                } else if (Fusion_radioButton.Checked == true)
                {
                    bw.BaseStream.Position = 0x28;
                    bw.Write(0x02);
                }
                bw.Close();
                MessageBox.Show("Your file has been successfully saved to pkprfl.bmssv!!!", "File Successfully Saved");
            }
            catch
            {
                MessageBox.Show("Failed to save onto file", "Error");
                Save_button.Enabled = false;
            }
        }
    }
}
