using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSangre.Vista
{
    public partial class BotonSalir : Form
    {
        public BotonSalir()
        {
            InitializeComponent();
        }

        private void buttonsi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
