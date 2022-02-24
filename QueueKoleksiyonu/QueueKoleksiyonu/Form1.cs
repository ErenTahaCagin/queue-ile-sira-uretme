using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueueKoleksiyonu
{
    public partial class Form1 : Form
    {
        private Queue kuyruk = new Queue();
        private int sira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }

        private void Listele()
        {
            lbSiralar.Items.Clear();
            foreach (int sira in kuyruk)
            {
                lbSiralar.Items.Add(sira);
            }
        }

        private void btnSiraCikart_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
    }
}
