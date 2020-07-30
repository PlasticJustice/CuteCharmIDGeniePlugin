using System;
using System.Drawing;
using PKHeX.Core;
using System.Windows.Forms;
using System.Collections.Generic;
using CuteCharmIDGeniePlugin.Properties;
using Microsoft.VisualBasic;

namespace CuteCharmIDGeniePlugin {

    public partial class MainForm : Form {
        readonly string[] Natures = {"Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest",
        "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky"}; //List of Natures
        short TSVt = 0; //Target Trainer Shiny Value
        byte Group = 0; //Shiny Group Selection

        #region "Stuff"
        private SaveFile sav;
        private ushort TID;
        private ushort SID;
        private byte IDOffset;

        public MainForm(SaveFile sav) {
            this.sav = sav;
            InitializeComponent();

            switch (sav.Version) {
                case GameVersion.D:
                case GameVersion.P:
                case GameVersion.DP:
                    IDOffset = 0x74;
                    cb_GameList.SelectedIndex = 0;
                    break;
                case GameVersion.Pt:
                    IDOffset = 0x78;
                    cb_GameList.SelectedIndex = 1;
                    break;
                case GameVersion.HG:
                case GameVersion.SS:
                case GameVersion.HGSS:
                    IDOffset = 0x74;
                    cb_GameList.SelectedIndex = 2;
                    break;
            }
            SetupForm();
        }



        private void SaveButton_Click(object sender, EventArgs e) {
            if (sav.Generation == 4) {
                sav.SetData(((SAV4)sav).General, BitConverter.GetBytes(SID), IDOffset + 2);
                sav.SetData(((SAV4)sav).General, BitConverter.GetBytes(TID), IDOffset);
            }
            Close();
        }
        #endregion

        #region "Startup"
        private void SetupForm() {
            cb_LeadList.SelectedIndex = 0;
            PicTXT();
            Default_Form();
            bt_Save.Enabled = false;
            lklb_Update.Visible = false;
        }

        //Adds text onto the PictureBoxes
        private void DrawTXT(string txt, PictureBox pb, Point pnt, bool bg = true, float fnts = 9) { //*
            Font myfont = new Font("Calibri", fnts, FontStyle.Regular);
            Brush myBrush = Brushes.Black;
            if (txt.Contains(@"\")) {
                txt = txt.Replace(@"\", @"");
                myfont = new Font("Calibri", fnts, FontStyle.Italic);
            } else if (txt.Contains("*")) {
                txt = txt.Replace(@"*", @"");
                myfont = new Font("Arial Black", fnts, FontStyle.Bold);
                myBrush = Brushes.White;
            }
            Bitmap img;
            if (bg == true) {
                img = new Bitmap(pb.BackgroundImage);
            } else {
                img = new Bitmap(pb.Image);
            }
            using (var g = Graphics.FromImage(img)) {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawString(txt, myfont, myBrush, new PointF(pnt.X, pnt.Y));
            }
            //Dispose the existing image if there is one.
            if (bg == true) {
                pb.BackgroundImage?.Dispose();
                pb.BackgroundImage = img;
            } else {
                pb.Image?.Dispose();
                pb.Image = img;
            }
        }

        //Calls the text changes on the PicBoxes
        private void PicTXT() {
            byte index = 1;
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup1, pb_ShinyGroup2, pb_ShinyGroup3, pb_ShinyGroup4 });
            foreach (PictureBox i in table) {
                i.BackgroundImage = Resources.sg;
                DrawTXT("*Shiny Group " + index, i, new Point(11, 2), true, 8);
                index += 1;
            }
            switch (cb_LeadList.SelectedIndex) {
                case 0:
                    rb_RandomFixed.Text = rb_RandomFixed.Text.Replace("1", "4");
                    rb_RandomPure.Text = rb_RandomPure.Text.Replace("1", "4");
                    break;
                default:
                    switch (cb_LeadList.SelectedIndex) {
                        case 2:
                        case 4:
                            rb_RandomFixed.Text = rb_RandomFixed.Text.Replace("1", "4");
                            rb_RandomPure.Text = rb_RandomPure.Text.Replace("1", "4");
                            break;
                        case 1:
                        case 3:
                            rb_RandomFixed.Text = rb_RandomFixed.Text.Replace("4", "1");
                            rb_RandomPure.Text = rb_RandomPure.Text.Replace("4", "1");
                            break;
                    }
                    break;
            }
            index = 0;
            byte[,] buffers = { { 0, 7, 0 }, { 2, 0, 0x30 }, { 0, 4, 0x48 }, { 6, 1, 0x90 }, { 0, 7, 0xC8 } };
            foreach (PictureBox i in table) {
                for (int n = buffers[cb_LeadList.SelectedIndex, 2] + (index * 8) + ((index == 0) ? buffers[cb_LeadList.SelectedIndex, 0] : 0); n <= buffers[cb_LeadList.SelectedIndex, 2] + (index * 8) + (7 - (index == 3 ? buffers[cb_LeadList.SelectedIndex, 1] : 0)); n++) {
                    int y = n % (buffers[cb_LeadList.SelectedIndex, 2] + (index * 8) + (index == 0 ? (cb_LeadList.SelectedIndex == 0 ? 8 : 0) : 0));
                    int x = n % (buffers[cb_LeadList.SelectedIndex, 0] + buffers[cb_LeadList.SelectedIndex, 2] + (cb_LeadList.SelectedIndex == 0 ? 25 : 0));
                    if (cb_LeadList.SelectedIndex == 1 && (index == 3) && (y > 2)) {
                        DrawTXT(@"\000000" + n.ToString("X") + " " + Natures[x % 25], i, new Point(3, (int)(22 + (y * 17.5))));
                    } else if (cb_LeadList.SelectedIndex == 2 && index == 0 && (y < 3)) {
                        DrawTXT(@"\000000" + n.ToString("X") + " " + Natures[x + 22], i, new Point(3, (int)(22 + (y * 17.5))));
                    } else {
                        DrawTXT(@"000000" + n.ToString("X") + " " + Natures[x - (cb_LeadList.SelectedIndex == 2 ? 3 : 0)], i, new Point(3, (int)(22 + (y * 17.5))));
                    }
                }
                index += 1;
            }
            //*
            if (rb_Choose.Checked == true) {
                rb_Choose.PerformClick();
                if (rb_ShinyGroup1.Checked == true) {
                    rb_ShinyGroup4.PerformClick();
                    rb_ShinyGroup1.PerformClick();
                } else if (rb_ShinyGroup2.Checked == true) {
                    rb_ShinyGroup4.PerformClick();
                    rb_ShinyGroup2.PerformClick();
                } else if (rb_ShinyGroup3.Checked == true) {
                    rb_ShinyGroup4.PerformClick();
                    rb_ShinyGroup3.PerformClick();
                } else if (rb_ShinyGroup4.Checked == true) {
                    rb_ShinyGroup1.PerformClick();
                    rb_ShinyGroup4.PerformClick();
                }
            } else if (rb_RandomFixed.Checked == true) {
                rb_Choose.PerformClick();
                rb_RandomFixed.PerformClick();
            } else if (rb_RandomPure.Checked == true) {
                rb_Choose.PerformClick();
                rb_RandomPure.PerformClick();
            }
        }

        private void Default_Form() { //*
            rb_ShinyGroup1.Checked = false;
            rb_RandomFixed.PerformClick();
            rb_RandomTID.PerformClick();
            rb_RandomTID.Checked = true;
            cb_LeadList.SelectedIndex = 1;
            cb_LeadList.SelectedIndex = 0;
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup1, pb_ShinyGroup2, pb_ShinyGroup3, pb_ShinyGroup4 });
            ListDE(table);
            gb_ShinyGroups.Enabled = false;
        }

        //Greys out PictureBoxes
        private void DrawDE(PictureBox pb) {
            try {
                pb.Enabled = false;
                if (pb != null) { ControlPaint.DrawImageDisabled(pb.CreateGraphics(), pb.BackgroundImage, 0, 0, Color.Gray); }
            } catch {
            }
        }
        private void ListDE(List<PictureBox> table) {
            foreach (PictureBox i in table) {
                DrawDE(i);
            }
        }
        private void ListEnable(List<PictureBox> table) {
            foreach (PictureBox i in table) {
                i.Enabled = true;
            }
        }

        private void Cb_LeadList_SelectedIndexChanged(object sender, EventArgs e) => PicTXT();
        #endregion

        #region "Pick IDs"
        //Picks IDs
        private void PickID() {
            TSVt = (short)(Math.Floor(-0.708 * Math.Pow(cb_LeadList.SelectedIndex, 4) + 5.75 * Math.Pow(cb_LeadList.SelectedIndex, 3) + -13.792 * Math.Pow(cb_LeadList.SelectedIndex, 2) + 14.75 * cb_LeadList.SelectedIndex));
            //TSVt = Math.Floor(-0.70834335 * cb_LeadList.SelectedIndex ^ 4 + 5.7501018 * cb_LeadList.SelectedIndex ^ 3 + -13.791902 * cb_LeadList.SelectedIndex ^ 2 + 14.7501436 * cb_LeadList.SelectedIndex)
            TSVt += (short)(rb_Choose.Checked == true ? Group - 1 : Group);
            Random gen = new Random();
            TID = (ushort)(rb_ChooseTID.Checked == true ? nud_TrainerID.Value : gen.Next(0, 65536));
            SID = (ushort)(TID ^ (gen.Next(0, 8) + (TSVt << 3)));
            if (ValueCheck()) { return; }
            lb_TIDValue.Text = TID.ToString();
            lb_SIDValue.Text = SID.ToString();
            lb_TIDValue.Show();
            lb_SIDValue.Show();
        }

        //Verifies IDs
        private bool ValueCheck() {
            int result = ((TID ^ SID) >> 3);
            if (result == TSVt) {
                return false;
            } else {
                return true;
            }
        }

        //Picks Group
        private void PickGroup() {
            Random gen = new Random();
            if (rb_RandomFixed.Checked == true) {
                Group = (byte)Math.Floor(gen.Next(0, 30) / (double)10);
                if (rb_RandomFixed.Text.Contains("1")) { Group += 1; }
            } else if (rb_RandomPure.Checked == true) {
                Group = (byte)Math.Floor((gen.Next(0, 40)) / (double)10);
            }
        }

        //Sets to Random
        private void Rb_RandomTID_CheckedChanged(object sender, EventArgs e) {
            nud_TrainerID.Enabled = false;
        }

        //User's Choice
        private void Rb_ChooseTID_CheckedChanged(object sender, EventArgs e) {
            nud_TrainerID.Enabled = true;
        }
        #endregion

        #region "Shiny Group Selection"
        //User Chooses Shiny Group
        private void Rb_Choose_CheckedChanged(object sender, EventArgs e) {
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup1, pb_ShinyGroup2, pb_ShinyGroup3, pb_ShinyGroup4 });
            if (rb_Choose.Checked == true) {
                gb_ShinyGroups.Enabled = true;
                ListEnable(table);
            } else {
                gb_ShinyGroups.Enabled = false;
                ListDE(table);
            }
        }
        #endregion

        #region "Specific Shiny Group RadioButtons"
        //Shiny Group 1
        private void Rb_ShinyGroup1_CheckedChanged(object sender, EventArgs e) {
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup2, pb_ShinyGroup3, pb_ShinyGroup4 });
            if (rb_ShinyGroup1.Checked == true) {
                Group = 1;
                ListDE(table);
            } else {
                Group = 0;
                ListEnable(table);
            }
        }

        //Shiny Group 2
        private void Rb_ShinyGroup2_CheckedChanged(object sender, EventArgs e) {
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup1, pb_ShinyGroup3, pb_ShinyGroup4 });
            if (rb_ShinyGroup2.Checked == true) {
                Group = 2;
                ListDE(table);
            }
            else {
                Group = 0;
                ListEnable(table);
            }
        }

        //Shiny Group 3
        private void Rb_ShinyGroup3_CheckedChanged(object sender, EventArgs e) {
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup1, pb_ShinyGroup2, pb_ShinyGroup4 });
            if (rb_ShinyGroup3.Checked == true) {
                Group = 3;
                ListDE(table);
            }
            else {
                Group = 0;
                ListEnable(table);
            }
        }

        //Shiny Group 4
        private void Rb_ShinyGroup4_CheckedChanged(object sender, EventArgs e) {
            List<PictureBox> table = new List<PictureBox>(new PictureBox[] { pb_ShinyGroup1, pb_ShinyGroup2, pb_ShinyGroup3 });
            if (rb_ShinyGroup4.Checked == true) {
                Group = 4;
                ListDE(table);
            } else {
                Group = 0;
                ListEnable(table);
            }
        }
        #endregion

        #region "Links"

        //Link to Update version
        private void Lklb_Update_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {
                System.Diagnostics.Process.Start("https://github.com/PlasticJustice/CuteCharmIDGenie/releases/latest");
        } else {
                MessageBox.Show("No Internet connection!" + Constants.vbNewLine + "You can not update at the moment.", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
    }

        //Link the Author's, yours truly, Github Page
        private void Lklb_Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {
                System.Diagnostics.Process.Start("https://github.com/PlasticJustice");
            } else {
                MessageBox.Show("No Internet connection!" + Constants.vbNewLine + "You can look me up later.", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        //PayPal Donate Button
        private void Pb_Donate_Click(object sender, EventArgs e) {
            System.Threading.Thread.Sleep(200);
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {
                System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UGSCC5VGSGN3E");
            } else {
                MessageBox.Show("No Internet connection!" + Constants.vbNewLine + "I appreciate the gesture.", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void Pb_Donate_MouseDown(object sender, MouseEventArgs e) {
            pb_Donate.Image = Resources.ppdbs;
        }
        private void Pb_Donate_MouseUp(object sender, MouseEventArgs e) {
            pb_Donate.Image = null;
        }       
        #endregion

        //Checks for empty options
        private bool Checks() {
            if (cb_GameList.SelectedItem == null) {
                cb_GameList.ForeColor = Color.Red;
                lb_Game.ForeColor = Color.Red;
                return true;
            } else if (Group == 0 && rb_Choose.Checked == true) {
                gb_ShinyGroups.ForeColor = Color.Red;
                return true;
            } else if (rb_RandomFixed.Checked == false && rb_RandomPure.Checked == false && rb_Choose.Checked == false) {
                gb_RandomChoice.ForeColor = Color.Red;
                return true;
            } else {
                cb_GameList.ForeColor = DefaultForeColor;
                lb_Game.ForeColor = DefaultForeColor;
                gb_RandomChoice.ForeColor = DefaultForeColor;
                gb_ShinyGroups.ForeColor = DefaultForeColor;                
                return false;
            }
        }

        //Executes AR code generation
        private void Bt_Calculate_Click(object sender, EventArgs e) {
            if (Checks()) { return; }
            PickGroup();
            PickID();
            bt_Save.Enabled = true;
        }
    }
}