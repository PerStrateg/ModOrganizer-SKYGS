using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModOrganizerSKYGS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label4.Image = ModOrganizerSKYGS.Properties.Resources.pics12;
            Icon = ModOrganizerSKYGS.Properties.Resources.ico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("\\", "/");
            textBox2.Text = textBox2.Text.Replace("\\", "/");
            textBox3.Text = textBox3.Text.Replace("\\", "/");

            string skyPath = textBox1.Text;
            string moPath = textBox2.Text;
            string javaPath = textBox3.Text;

            Ini ini = new Ini(moPath + "/ModOrganizer.ini");
            ini.WriteValue("gamePath", "General", skyPath);

            //SKSE
            ini.WriteValue("5\\binary", "customExecutables", skyPath + "/skse_loader.exe");
            ini.WriteValue("5\\workingDirectory", "customExecutables", skyPath);
            
            //java
            ini.WriteValue("5\\binary", "customExecutables", javaPath); 
            ini.WriteValue("5\\workingDirectory", "customExecutables", moPath + "/mods/Dual Sheath Redux/SkyProc Patchers/Dual Sheath Redux Patch");

            //TES5Edit
            ini.WriteValue("6\\binary", "customExecutables", skyPath + "/TES5Edit.exe");
            ini.WriteValue("6\\workingDirectory", "customExecutables", skyPath);

            //FNIS
            ini.WriteValue("4\\binary", "customExecutables", moPath + "/mods/Fnis/tools/GenerateFNIS_for_Users/GenerateFNISforUsers.exe");
            ini.WriteValue("4\\workingDirectory", "customExecutables", moPath + "/mods/Fnis/tools/GenerateFNIS_for_Users");

            //Wrye Bash
            ini.WriteValue("7\\binary", "customExecutables", skyPath + "/Mopy/Wrye Bash.exe");
            ini.WriteValue("7\\workingDirectory", "customExecutables", skyPath + "/Mopy");

            //CalinteTools
            ini.WriteValue("8\\binary", "customExecutables", moPath + "/mods/UN7B/CalienteTools/BodySlide/BodySlide.exe");
            ini.WriteValue("8\\workingDirectory", "customExecutables", moPath + "/mods/UN7B/CalienteTools/BodySlide");
            
            //FNIS7
            ini.WriteValue("9\\binary", "customExecutables", moPath + "/mods/FNIS7/tools/GenerateFNIS_for_Users/GenerateFNISforUsers.exe");
            ini.WriteValue("9\\workingDirectory", "customExecutables", moPath + "/mods/FNIS7/tools/GenerateFNIS_for_Users");

            //CalinteTools
            ini.WriteValue("10\\binary", "customExecutables", skyPath + "/PoserDataGen/PoserDataGen.exe");
            ini.WriteValue("10\\workingDirectory", "customExecutables", skyPath + "/PoserDataGen/");

            //recentDirectories

            ini.WriteValue("1\\directory", "recentDirectories", skyPath + "/PoserDataGen/");
            ini.WriteValue("2\\directory", "recentDirectories", skyPath);

            ini.Save();

            button1.Text = "ModOrganizer.ini изменен!";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.SelectedPath = textBox1.Text;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            textBox1.Text = dlg.SelectedPath;
            textBox1.Text = textBox1.Text.Replace("\\", "/");

            //new FileInfo(dlg.FileName, passphraseTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.SelectedPath = textBox2.Text;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            textBox2.Text = dlg.SelectedPath;
            textBox2.Text = textBox2.Text.Replace("\\", "/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.InitialDirectory = textBox3.Text;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            textBox3.Text = dlg.FileName;
            textBox3.Text = textBox3.Text.Replace("\\", "/");
        }
    }
}
