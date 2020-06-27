using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ula
{
    public partial class Form2 : Form
    {
        bool[] convbool_1 = new bool[8];        
        bool[] convbool_2 = new bool[8];
        public Form2()
        {
            InitializeComponent();
        }  
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ConversorDecForBin conv1 = new ConversorDecForBin(int.Parse(textBox1.Text), 2, 8);

            int[] vetBinario1 = new int[8];

            vetBinario1 = conv1.ConverteDB();

            ConversorBin4Boll convBool1 = new ConversorBin4Boll(vetBinario1);

            convbool_1 = convBool1.CoverteBinToBoll();

            string juntarInt = "";
            for (int i = 0; i < 8; i++)
            {
                juntarInt += vetBinario1[i].ToString();
            }
            textBox3.Text = juntarInt;
            textBox3.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Somador somador = new Somador(convbool_1, convbool_2, false);
            bool[] resulSoma = new bool[8];
            resulSoma = somador.Soma();
            ConversorBool4Bin paraBinario = new ConversorBool4Bin(resulSoma);
            int[] resulSomaintbin = new int[8];
            resulSomaintbin = paraBinario.CoverteBool4Bin();
            string join = "";

            for (int i = 0; i < 8; i++)
            {
                join += resulSomaintbin[i].ToString();
            }
            textBox5.Text = join;
            textBox5.Show();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            ConversorDecForBin conv2 = new ConversorDecForBin(int.Parse(textBox2.Text), 2, 8);
            int[] vetBinario2 = new int[8];
            vetBinario2 = conv2.ConverteDB();
            ConversorBin4Boll convBool2 = new ConversorBin4Boll(vetBinario2);

            convbool_2 = convBool2.CoverteBinToBoll();
            string juntarInt2 = "";
            for (int i = 0; i < 8; i++)
            {
                juntarInt2 += vetBinario2[i].ToString();
            }
            textBox4.Text = juntarInt2;
            textBox4.Show();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
