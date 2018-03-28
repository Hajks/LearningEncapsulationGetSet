using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEncapsulationGetSet
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów", farmer.BagsOfFeed, farmer.NumberOfCows); //new method for me "WriteLine" {0}, it's 1st paramters {1} 2nd etc. etc.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //farmer.BagsOfFeed = 5;  ->>>> not working anymore, because "The property or indexer 'Farmer.BagsOfFeed' cannot be used in this context because the set accessor is inaccessible"

        }
    }
}
