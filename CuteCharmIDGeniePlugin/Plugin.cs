﻿using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace CuteCharmIDGeniePlugin
{
    public class CuteCharmIDGeniePlugin : IPlugin
    {
        public string Name => "CuteCharmIDGenie";
        public int Priority => 1; // Loading order, lowest is first.
        public ISaveFileProvider SaveFileEditor { get; private set; }
        public IPKMView PKMEditor { get; private set; }

        public void Initialize(params object[] args) {
            Console.WriteLine($"Loading {Name}...");
            if (args == null) { return; }
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);
        }

        private void LoadMenuStrip(ToolStrip menuStrip) {
            var items = menuStrip.Items;
            var tools = items.Find("Menu_Tools", false)[0] as ToolStripDropDownItem;
            AddPluginControl(tools);
        }

        private void AddPluginControl(ToolStripDropDownItem tools) {
            var ctrl = new ToolStripMenuItem(Name);
            tools.DropDownItems.Add(ctrl);
            ctrl.Image = Properties.Resources.icon;
            ctrl.Click += new EventHandler(OpenFeebasLocatorForm);
        }

        private void OpenFeebasLocatorForm(object sender, EventArgs e) {
            switch (SaveFileEditor.SAV.Version) {                               
                case GameVersion.D:
                case GameVersion.P:
                case GameVersion.Pt:
                case GameVersion.HG:
                case GameVersion.SS:
                case GameVersion.DP:
                case GameVersion.DPPt:
                case GameVersion.HGSS:
                    new MainForm(SaveFileEditor.SAV).ShowDialog();
                    break;
                default:
                    MessageBox.Show("CuteCharmIDGenie is only available for Diamond, Pearl, Platinum, HeartGold, and SoulSilver.", "Error");
                    break;
            }
        }

        public void NotifySaveLoaded() {
            Console.WriteLine($"{Name} was notified that a Save File was just loaded.");
        }
        public bool TryLoadFile(string filePath) {
            Console.WriteLine($"{Name} was provided with the file path, but chose to do nothing with it.");
            return false; // no action taken
        }
    }
}