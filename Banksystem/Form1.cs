using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksystem
{
    public partial class Form1 : Form
    {
        
        Queue<string> somedata = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            CheckGenerater checkgenerate = new CheckGenerater();
            string rs = checkgenerate.kGenerate();
            lbl_cek.Text = rs;
            somedata.Enqueue(rs);
        }

        private void btn_em_Click(object sender, EventArgs e)
        {
            CheckGenerater checkgenerate = new CheckGenerater();
            string rs = checkgenerate.eGenerate();
            lbl_cek.Text = rs;
            somedata.Enqueue(rs);
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            CheckGenerater checkgenerate = new CheckGenerater();
            string rs = checkgenerate.cGenerate();
            lbl_cek.Text = rs;
            somedata.Enqueue(rs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           lbl_service.Text = somedata.Dequeue();

        }
    }
}
