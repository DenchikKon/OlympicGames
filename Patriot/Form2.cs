using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patriot
{
    public partial class Form2 : Form
    {
        public string VideoPlayerURL
        {
            get
            {
                return VideoPlayer.URL;
            }
            set
            {
                VideoPlayer.URL = value;
            }
        }

    public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
