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

namespace Quiz05___Methods
{
    public partial class Form3 : Form
    {
        SoundPlayer bells = new SoundPlayer("C:\\Users\\xavie\\Downloads\\christmas-bells-02-439604.wav");
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        public void flash()
        {
            for (int i = 0; i <= 5; i++)
            {
                BackColor = Color.Red;
                Task.Delay(500).Wait();
                bells.Play();
                BackColor = Color.Green;
                Task.Delay(500).Wait();
                bells.Play();
            }
            BackgroundImage = Properties.Resources.SantaClause;
        }
    }
}
