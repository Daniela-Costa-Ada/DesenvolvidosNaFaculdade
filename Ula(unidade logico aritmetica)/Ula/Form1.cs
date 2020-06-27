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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            And[] and = new And[4];
            and[0] = new And();
            and[1] = new And();
            and[2] = new And();
            and[3] = new And();


            textBox1.Text = and[0].Conjunção(false, false).ToString() + and[1].Conjunção(false, true).ToString()
                    + and[2].Conjunção(true, false).ToString() + and[3].Conjunção(true, true).ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Or[] ou = new Or[4];
            ou[0] = new Or();
            ou[1] = new Or();
            ou[2] = new Or();
            ou[3] = new Or();

            textBox2.Text = (ou[0].Disjunção(false, false)).ToString() + (ou[1].Disjunção(false, true)).ToString();
            textBox2.Text += (ou[2].Disjunção(true, false)).ToString() + (ou[3].Disjunção(true, true)).ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Xor[] ouExc = new Xor[4];
            ouExc[0] = new Xor();
            ouExc[1] = new Xor();
            ouExc[2] = new Xor();
            ouExc[3] = new Xor();
            textBox3.Text = ouExc[0].EXclusiveOr(false, false).ToString();
            textBox3.Text += (ouExc[1].EXclusiveOr(false, true).ToString() + ouExc[2].EXclusiveOr(true, false).ToString() + ouExc[3].EXclusiveOr(true, true)).ToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Not[] not = new Not[2];
            not[0] = new Not();
            not[1] = new Not();
            textBox4.Text = (not[0].Negacao(false).ToString() + not[1].Negacao(true)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
