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

        int Count_value;
        int Energy_tank_address;
        int Aeion_tank_address;
        int Missile_tank_address;
        int Complete_save_address;
        int Metroid_art_address;
        int Concept_art_address;
        int Music_address;

        bool Complete_save_bool = false;
        bool Metroid_art_bool = false;
        bool Concept_art_bool = false;
        bool Music_bool = false;

        byte[] endBytes;
        byte[] Complete_save_bytes = new byte[] { 0x7E, 0x1B, 0xD4, 0xB3, 0x62, 0x00 };
        byte[] Metroid_art_bytes = new byte[] { 0xE7, 0xB5, 0x5D, 0x67, 0x62, 0x00 };
        byte[] Concept_art_bytes = new byte[] { 0xDC, 0xE2, 0x50, 0x38, 0x62, 0x00 };
        byte[] Music_bytes = new byte[] { 0x0F, 0x83, 0x07, 0xD8, 0x62, 0x00 };

        private void Open_button_Click(object sender, EventArgs e)
        {
            try
            {
                open.Filter = " pkprfl.bmssv Files |pkprfl.bmssv|All Files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Set stuff when opening a file
                    Complete_save_bool = false;
                    Metroid_art_bool = false;
                    Concept_art_bool = false;
                    Music_bool = false;

                    Save_button.Enabled = true;
                    Energy_tank_checkBox.Enabled = true;
                    Aeion_tank_checkBox.Enabled = true;
                    Missile_tank_checkBox.Enabled = true;
                    Normal_radioButton.Enabled = true;
                    Hard_radioButton.Enabled = true;
                    Fusion_radioButton.Enabled = true;
                    Completed_save_checkBox.Enabled = true;
                    Metroid_art_checkBox.Enabled = true;
                    Concept_art_checkBox.Enabled = true;
                    Music_checkBox.Enabled = true;

                    BinaryReader br = new BinaryReader(File.OpenRead(open.FileName));
                    //The count value
                    br.BaseStream.Position = 0x04;
                    Count_value = br.ReadByte();

                    //store the last couple of bytes
                    br.BaseStream.Position = 0x56;
                    endBytes = br.ReadBytes(0x100);

                    //check for values to assign addresses
                    for (int i = 0x2C; i < br.BaseStream.Length; i++)
                    {
                        br.BaseStream.Position = i;
                        var currentbyte = br.ReadByte().ToString("X2");
                        //Energy Tank
                        if (currentbyte == "D9" && br.ReadByte().ToString("X2") == "1D" && br.ReadByte().ToString("X2") == "FD")
                        {
                            Energy_tank_address = i + 5;
                        }
                        //Aeion Tank
                        else if (currentbyte == "BC" && br.ReadByte().ToString("X2") == "15" && br.ReadByte().ToString("X2") == "56")
                        {
                            Aeion_tank_address = i + 5;
                        }
                        //Missile Tank
                        else if (currentbyte == "D2" && br.ReadByte().ToString("X2") == "81" && br.ReadByte().ToString("X2") == "B2")
                        {
                            Missile_tank_address = i + 5;
                        }
                        //Completed save
                        else if (currentbyte == "7E" && br.ReadByte().ToString("X2") == "1B" && br.ReadByte().ToString("X2") == "D4")
                        {
                            Complete_save_bool = true;
                            Complete_save_address = i + 5;
                        }
                        //Metroid Art
                        else if (currentbyte == "E7" && br.ReadByte().ToString("X2") == "B5" && br.ReadByte().ToString("X2") == "5D")
                        {
                            Metroid_art_bool = true;
                            Metroid_art_address = i + 5;
                        }
                        //Concept Art
                        else if (currentbyte == "DC" && br.ReadByte().ToString("X2") == "E2" && br.ReadByte().ToString("X2") == "50")
                        {
                            Concept_art_bool = true;
                            Concept_art_address = i + 5;
                        }
                        //Music
                        else if (currentbyte == "0F" && br.ReadByte().ToString("X2") == "83" && br.ReadByte().ToString("X2") == "07")
                        {
                            Music_bool = true;
                            Music_address = i + 5;
                        }
                    }

                    //Read difficulty mode values
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

                    //Read Energy Tank value
                    br.BaseStream.Position = Energy_tank_address;
                    if (br.ReadByte().ToString("X2") == "01")
                    {
                        Energy_tank_checkBox.Checked = true;
                    }
                    else
                    {
                        Energy_tank_checkBox.Checked = false;
                    }

                    //Read Aeion Tank value
                    br.BaseStream.Position = Aeion_tank_address;
                    if (br.ReadByte().ToString("X2") == "01")
                    {
                        Aeion_tank_checkBox.Checked = true;
                    }
                    else
                    {
                        Aeion_tank_checkBox.Checked = false;
                    }

                    //Read Missile Tank value
                    br.BaseStream.Position = Missile_tank_address;
                    if (br.ReadByte().ToString("X2") == "01")
                    {
                        Missile_tank_checkBox.Checked = true;
                    }
                    else
                    {
                        Missile_tank_checkBox.Checked = false;
                    }

                    //Read save completed value
                    if (Complete_save_bool == true)
                    {
                        br.BaseStream.Position = Complete_save_address;
                        if (br.ReadByte().ToString("X2") == "01")
                        {
                            Completed_save_checkBox.Checked = true;
                        }
                        else
                        {
                            Completed_save_checkBox.Checked = false;
                        }
                    }
                    else if (Complete_save_bool == false)
                    {
                        Completed_save_checkBox.Checked = false;
                    }

                    //Read Metroid Art value
                    if (Metroid_art_bool == true)
                    {
                        br.BaseStream.Position = Metroid_art_address;
                        if (br.ReadByte().ToString("X2") == "01")
                        {
                            Metroid_art_checkBox.Checked = true;
                        }
                        else
                        {
                            Metroid_art_checkBox.Checked = false;
                        }
                    }
                    else if (Metroid_art_bool == false)
                    {
                        Metroid_art_checkBox.Checked = false;
                    }

                    //Read Concept Art value
                    if (Concept_art_bool == true)
                    {
                        br.BaseStream.Position = Concept_art_address;
                        if (br.ReadByte().ToString("X2") == "01")
                        {
                            Concept_art_checkBox.Checked = true;
                        }
                        else
                        {
                            Concept_art_checkBox.Checked = false;
                        }
                    }
                    else if (Concept_art_bool == false)
                    {
                        Concept_art_checkBox.Checked = false;
                    }

                    //Read Music value
                    if (Music_bool == true)
                    {
                        br.BaseStream.Position = Music_address;
                        if (br.ReadByte().ToString("X2") == "01")
                        {
                            Music_checkBox.Checked = true;
                        }
                        else
                        {
                            Music_checkBox.Checked = false;
                        }
                    }
                    else if (Music_bool == false)
                    {
                        Music_checkBox.Checked = false;
                    }
                    br.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid pkprfl.bmssv", "Failed to open the file");
                Save_button.Enabled = false;
                Energy_tank_checkBox.Enabled = false;
                Aeion_tank_checkBox.Enabled = false;
                Missile_tank_checkBox.Enabled = false;
                Normal_radioButton.Enabled = false;
                Hard_radioButton.Enabled = false;
                Fusion_radioButton.Enabled = false;
                Completed_save_checkBox.Enabled = false;
                Metroid_art_checkBox.Enabled = false;
                Concept_art_checkBox.Enabled = false;
                Music_checkBox.Enabled = false;
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(open.FileName));

                int Addbytes = 0x56;
                //if completed save values don't exist add them on
                if (Complete_save_bool == false)
                {
                    bw.BaseStream.Position = Addbytes;
                    bw.Write(Complete_save_bytes);
                    Complete_save_address = Addbytes + 5;
                    Addbytes += 6;
                    Count_value += 1;
                }

                //if Metroid Art values don't exist add them on
                if (Metroid_art_bool == false)
                {
                    bw.BaseStream.Position = Addbytes;
                    bw.Write(Metroid_art_bytes);
                    Metroid_art_address = Addbytes + 5;
                    Addbytes += 6;
                    Count_value += 1;
                }

                //if Concept Art values don't exist add them on
                if (Concept_art_bool == false)
                {
                    bw.BaseStream.Position = Addbytes;
                    bw.Write(Concept_art_bytes);
                    Concept_art_address = Addbytes + 5;
                    Addbytes += 6;
                    Count_value += 1;
                }

                //if Music values don't exist add them on
                if (Music_bool == false)
                {
                    bw.BaseStream.Position = Addbytes;
                    bw.Write(Music_bytes);
                    Music_address = Addbytes + 5;
                    Addbytes += 6;
                    Count_value += 1;
                }

                //if any of the addresses didn't exist then assign new counter value
                //write the last couple of bytes that were stored after the addresses that didn't exist previously
                //also set those bools to true
                if (Complete_save_bool == false || Metroid_art_bool == false || Concept_art_bool == false || Music_bool == false)
                {
                    bw.BaseStream.Position = 0x04;
                    bw.Write(Count_value);

                    bw.BaseStream.Position = Addbytes;
                    bw.Write(endBytes);

                    Complete_save_bool = true;
                    Metroid_art_bool = true;
                    Concept_art_bool = true;
                    Music_bool = true;
                }

                //check if completed save checkbox is checked then write the value onto the save
                if (Completed_save_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Complete_save_address;
                    bw.Write(Convert.ToByte(1));
                }
                else if (Completed_save_checkBox.Checked == false)
                {
                    bw.BaseStream.Position = Complete_save_address;
                    bw.Write(Convert.ToByte(0));
                }

                //check if Metroid Art checkbox is checked then write the value onto the save
                if (Metroid_art_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Metroid_art_address;
                    bw.Write(Convert.ToByte(1));
                }
                else if (Metroid_art_checkBox.Checked == false)
                {
                    bw.BaseStream.Position = Metroid_art_address;
                    bw.Write(Convert.ToByte(0));
                }

                //check if Concept Art checkbox is checked then write the value onto the save
                if (Concept_art_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Concept_art_address;
                    bw.Write(Convert.ToByte(1));
                }
                else if (Concept_art_checkBox.Checked == false)
                {
                    bw.BaseStream.Position = Concept_art_address;
                    bw.Write(Convert.ToByte(0));
                }

                //check if Music checkbox is checked then write the value onto the save
                if (Music_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Music_address;
                    bw.Write(Convert.ToByte(1));
                }
                else if (Music_checkBox.Checked == false)
                {
                    bw.BaseStream.Position = Music_address;
                    bw.Write(Convert.ToByte(0));
                }

                //check if Energy Tank checkbox is checked then write the value onto the save
                if (Energy_tank_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Energy_tank_address;
                    bw.Write(Convert.ToByte(1));

                    bw.BaseStream.Position = Energy_tank_address + 6;
                    bw.Write(Convert.ToByte(1));
                }
                else
                {
                    bw.BaseStream.Position = Energy_tank_address;
                    bw.Write(Convert.ToByte(0));

                    bw.BaseStream.Position = Energy_tank_address + 6;
                    bw.Write(Convert.ToByte(0));
                }

                //check if Aeion Tank checkbox is checked then write the value onto the save
                if (Aeion_tank_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Aeion_tank_address;
                    bw.Write(Convert.ToByte(1));

                    bw.BaseStream.Position = Aeion_tank_address + 6;
                    bw.Write(Convert.ToByte(1));
                }
                else
                {
                    bw.BaseStream.Position = Aeion_tank_address;
                    bw.Write(Convert.ToByte(0));

                    bw.BaseStream.Position = Aeion_tank_address + 6;
                    bw.Write(Convert.ToByte(0));
                }

                //check if Missile Tank checkbox is checked then write the value onto the save
                if (Missile_tank_checkBox.Checked == true)
                {
                    bw.BaseStream.Position = Missile_tank_address;
                    bw.Write(Convert.ToByte(1));

                    bw.BaseStream.Position = Missile_tank_address + 6;
                    bw.Write(Convert.ToByte(1));
                }
                else
                {
                    bw.BaseStream.Position = Missile_tank_address;
                    bw.Write(Convert.ToByte(0));

                    bw.BaseStream.Position = Missile_tank_address + 6;
                    bw.Write(Convert.ToByte(0));
                }

                //check what difficulty mode the radio button is set to then write the value onto the save
                if (Normal_radioButton.Checked == true)
                {
                    bw.BaseStream.Position = 0x28;
                    bw.Write(0x00);
                }
                else if (Hard_radioButton.Checked == true)
                {
                    bw.BaseStream.Position = 0x28;
                    bw.Write(0x01);
                }
                else if (Fusion_radioButton.Checked == true)
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
            }
        }
    }
}
