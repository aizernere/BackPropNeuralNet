using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropNeuralNet
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn= new NeuralNet(4, 1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < 3800; x++)
            {
                double[,] truthTable = new double[,]
                {
                    {0.0, 0.0, 0.0, 0.0, 0.0},
                    {0.0, 0.0, 0.0, 1.0, 0.0},
                    {0.0, 0.0, 1.0, 0.0, 0.0},
                    {0.0, 0.0, 1.0, 1.0, 0.0},
                    {0.0, 1.0, 0.0, 0.0, 0.0},
                    {0.0, 1.0, 0.0, 1.0, 0.0},
                    {0.0, 1.0, 1.0, 0.0, 0.0},
                    {0.0, 1.0, 1.0, 1.0, 0.0},
                    {1.0, 0.0, 0.0, 0.0, 0.0},
                    {1.0, 0.0, 0.0, 1.0, 0.0},
                    {1.0, 0.0, 1.0, 0.0, 0.0},
                    {1.0, 0.0, 1.0, 1.0, 0.0},
                    {1.0, 1.0, 0.0, 0.0, 0.0},
                    {1.0, 1.0, 0.0, 1.0, 0.0},
                    {1.0, 1.0, 1.0, 0.0, 0.0},
                    {1.0, 1.0, 1.0, 1.0, 1.0}
                };

                for (int i = 0; i < truthTable.GetLength(0); i++)
                {
                    nn.setInputs(0, truthTable[i, 0]);
                    nn.setInputs(1, truthTable[i, 1]);
                    nn.setInputs(2, truthTable[i, 2]);
                    nn.setInputs(3, truthTable[i, 3]);
                    nn.setDesiredOutput(0, truthTable[i, 4]);
                    nn.learn();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }
    }
}
