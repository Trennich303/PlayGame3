using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



using System.Threading; // add this to your using statements to use Thread.Sleep() 
namespace PlayGame3
{
    public partial class BackGround : Form
    {
        public BackGround()
        {
            InitializeComponent();
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            SoundPlayer bellPlayer = new SoundPlayer(Properties.Resources.Bell);
            SoundPlayer StartGame = new SoundPlayer(Properties.Resources.Game_Start_Sound);
            bellPlayer.Play();

            PlayGameButton.Visible = false;
            
            Refresh();
            Thread.Sleep(1000);
            Counter3.Visible = true;
            bellPlayer.Play();
            Refresh();
            Thread.Sleep(1000);
            Counter3.Visible = false;
            Counter2.Visible = true;
            bellPlayer.Play();
           
            Refresh();
            Thread.Sleep(1000);
            Counter2.Visible = false;
            Counter1.Visible = true;
            bellPlayer.Play();
            
            Refresh();
            Thread.Sleep(1000);
            Counter1.Visible = false;
            BackColor = Color.Green;
            CounterGo.Visible = true;
            StartGame.Play();
        }

        private void BackGround_Load(object sender, EventArgs e)
        {

        }
    }
}
