using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //globalis szoveg vektorok a zene cimeknek lol
        String[] paths, files;

        private void button1_Click(object sender, EventArgs e)
        {
            //app bezarasa lol
            this.Close();
        }
        //int hossz;
        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            
            //zene kivalaszto kod lol
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            //kod ami csak az audio fileokat engedi megnyitni lol
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            //kod tobb file megnyitasara lol
            //ofd.Multiselect = true;
            //bugfix lol
            //Array.Clear(files, 0, files.Length); i made another bug lol
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                files = ofd.SafeFileNames; // lementi a zenecimet lol
                //hossz = files.Length;
                paths = ofd.FileNames; // elmenti a zene helyet lol
                //kiirja a zene cimeket a listboxba lol
                for ( int i=0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // kiirja a zeneket a listboxba lol

                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
                //zene lejatszo kod
            WindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            //teljesen original code, teljsen original lol, abszolut nem loptam el semmi kodot lol
            //esku nem loptam el semmit lol
            //ha chrashel, akkor emiatt a sor miatt, nem tudom mi a baja, meg se tudom oldani lol
            //de valahol ittttttt van a baj lol, send help pls lol
        }

        private void lblfooter_Click(object sender, EventArgs e)
        {
            //ez nem csinal semmit lol haha lol klmsmamkdm asd
        }
        //emiatt lehet mozgatni az ablakot lol
        int mouseX = 0, mouseY = 0;
        //eger pozicio lol
        bool mouseDown;
        //ez valami boolean idunoo lol
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) 
            {
                mouseX = MousePosition.X - 600;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
