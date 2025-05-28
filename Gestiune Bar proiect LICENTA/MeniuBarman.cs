using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestiune_Bar_proiect_LICENTA
{
    public partial class MeniuBarman : Form
    {
        public MeniuBarman()
        {
            InitializeComponent();
        }

        private void MeniuBarman_Load(object sender, EventArgs e)
        {
           
            ORA.Text = DateTime.Now.Hour.ToString("00");
            MINUTE.Text = DateTime.Now.Minute.ToString("00");
            SECUNDE.Text = DateTime.Now.Second.ToString("00");
            Temporizator.Start();
        }

        private void Temporizator_Tick(object sender, EventArgs e)
        {
            ORA.Text = DateTime.Now.Hour.ToString("00");
            MINUTE.Text = DateTime.Now.Minute.ToString("00");
            SECUNDE.Text = DateTime.Now.Second.ToString("00");
        }
    }
}
