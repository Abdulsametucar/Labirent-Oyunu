using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LabirentOyunu
{
    public partial class Labirent : Form
    {
        SoundPlayer startPlayer = new SoundPlayer(@"C:\Windows\Media\chord.wav");
        SoundPlayer endPlayer = new SoundPlayer(@"C:\Windows\Media\tada.wav");
        public Labirent()
        {
            InitializeComponent();
            movetostart();
        }

        private void finish(object sender, EventArgs e)
        {
            endPlayer.Play();
            MessageBox.Show("congratulations!!");
            Close();
        }
        

        private void Wall(object sender, EventArgs e)
        {
            startPlayer.Play(); 
            movetostart();
        }

        private void movetostart()
        {
            Point startLoc = oyunalani.Location;
            startLoc.Offset(30, 40);
            Cursor.Position = PointToScreen(startLoc);
        }

        
    }
}
