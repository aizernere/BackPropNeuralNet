using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Backprop;

namespace BackPropNeuralNet
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int[,] inputSets = new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 0, 1},
                {0, 0, 1, 0},
                {0, 0, 1, 1},
                {0, 1, 0, 0},
                {0, 1, 0, 1},
                {0, 1, 1, 0},
                {0, 1, 1, 1},
                {1, 0, 0, 0},
                {1, 0, 0, 1},
                {1, 0, 1, 0},
                {1, 0, 1, 1},
                {1, 1, 0, 0},
                {1, 1, 0, 1},
                {1, 1, 1, 0},
                {1, 1, 1, 1}
            };
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[0, 0];
            textBox2.Text = "" + inputSets[0, 1];
            textBox3.Text = "" + inputSets[0, 2];
            textBox4.Text = "" + inputSets[0, 3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[1, 0];
            textBox2.Text = "" + inputSets[1, 1];
            textBox3.Text = "" + inputSets[1, 2];
            textBox4.Text = "" + inputSets[1, 3];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[2, 0];
            textBox2.Text = "" + inputSets[2, 1];
            textBox3.Text = "" + inputSets[2, 2];
            textBox4.Text = "" + inputSets[2, 3];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[3, 0];
            textBox2.Text = "" + inputSets[3, 1];
            textBox3.Text = "" + inputSets[3, 2];
            textBox4.Text = "" + inputSets[3, 3];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[4, 0];
            textBox2.Text = "" + inputSets[4, 1];
            textBox3.Text = "" + inputSets[4, 2];
            textBox4.Text = "" + inputSets[4, 3];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[5, 0];
            textBox2.Text = "" + inputSets[5, 1];
            textBox3.Text = "" + inputSets[5, 2];
            textBox4.Text = "" + inputSets[5, 3];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[6, 0];
            textBox2.Text = "" + inputSets[6, 1];
            textBox3.Text = "" + inputSets[6, 2];
            textBox4.Text = "" + inputSets[6, 3];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[7, 0];
            textBox2.Text = "" + inputSets[7, 1];
            textBox3.Text = "" + inputSets[7, 2];
            textBox4.Text = "" + inputSets[7, 3];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[8, 0];
            textBox2.Text = "" + inputSets[8, 1];
            textBox3.Text = "" + inputSets[8, 2];
            textBox4.Text = "" + inputSets[8, 3];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[9, 0];
            textBox2.Text = "" + inputSets[9, 1];
            textBox3.Text = "" + inputSets[9, 2];
            textBox4.Text = "" + inputSets[9, 3];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[10, 0];
            textBox2.Text = "" + inputSets[10, 1];
            textBox3.Text = "" + inputSets[10, 2];
            textBox4.Text = "" + inputSets[10, 3];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[11, 0];
            textBox2.Text = "" + inputSets[11, 1];
            textBox3.Text = "" + inputSets[11, 2];
            textBox4.Text = "" + inputSets[11, 3];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[12, 0];
            textBox2.Text = "" + inputSets[12, 1];
            textBox3.Text = "" + inputSets[12, 2];
            textBox4.Text = "" + inputSets[12, 3];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[13, 0];
            textBox2.Text = "" + inputSets[13, 1];
            textBox3.Text = "" + inputSets[13, 2];
            textBox4.Text = "" + inputSets[13, 3];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[14, 0];
            textBox2.Text = "" + inputSets[14, 1];
            textBox3.Text = "" + inputSets[14, 2];
            textBox4.Text = "" + inputSets[14, 3];
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + inputSets[15, 0];
            textBox2.Text = "" + inputSets[15, 1];
            textBox3.Text = "" + inputSets[15, 2];
            textBox4.Text = "" + inputSets[15, 3];
        }

    }
}
