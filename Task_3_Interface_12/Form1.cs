using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

namespace Task_3_Interface_12
{
    public partial class Form1 : Form
    {
        public List<IEquipment> players = new List<IEquipment>() {
            new Videoplayer(" Плеер RX - 8", 5, 2010),
        new Videoplayer(" Видеоплеер RX Max", 7, 2013)
    };
        public Videoplayer videoplayer = new Videoplayer();
        public Form1()
        {
            InitializeComponent();

    
         
        }

        private void button_Output_Data_Click(object sender, EventArgs e)
        {
            foreach (Videoplayer tmp in players)
            {
                textBox_Info.Text += tmp.GetInfo();
            }
        }

        private void button_OnPlayer_Click(object sender, EventArgs e)
        {
            videoplayer.OnPlayer();
            MessageBox.Show("Плеер включён");
        }

        private void button_OfPlayer_Click(object sender, EventArgs e)
        {
            videoplayer.OfPlayer();
            MessageBox.Show("Плеер выключен");

        }

        private void button_OnVideo_Click(object sender, EventArgs e)
        {
            videoplayer.OnVideo();
            MessageBox.Show("Видеоплеер включён");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoplayer.OfVideo();
            MessageBox.Show("Видеоплеер выключен");
        }
    }
}
