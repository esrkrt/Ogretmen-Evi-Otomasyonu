using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğretmen_Evi_Uygulaması
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sozcu.com.tr");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberturk.com.tr");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.fanatik.com.tr");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.onedio.com.tr");

        }
    }
}
