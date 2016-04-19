using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace potoki_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnreset_Click(object sender, EventArgs e)
        {
            int Count = 10000;
            Random Rnd = new Random();
            int[] Mas_1 = new int[Count];
            int[] Mas_2 = new int[Count];
            for (int i = 0; i < Count; ++i)
            {
                Mas_1[i] = Rnd.Next();
                Mas_2[i] = Rnd.Next();
            }
            _prbProces.Maximum = Count;
            _prbProces.Value = 0;

            Thread t = new Thread(new ThreadStart(delegate {
                for (int i = 0; i < Count; ++i)
                {
                    this.Invoke(new ThreadStart(delegate
                    {

                        _prbProces.Value++;
                    }));
                }
            }));
            t.Start();
        }
    }
}
