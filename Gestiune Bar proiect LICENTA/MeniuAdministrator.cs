using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestiune_Bar_proiect_LICENTA
{
    public partial class MeniuAdministrator : Form
    {
        public MeniuAdministrator()
        {



            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdministrareStocuri_Click(object sender, EventArgs e)
        {

        }

        private void MeniuAdministrator_Load(object sender, EventArgs e)
        {
            DATA.Text = DateTime.Now.ToString();
            ORA.Text = DateTime.Now.Hour.ToString("00");
            MINUTE.Text = DateTime.Now.Minute.ToString("00");
            SECUNDE.Text = DateTime.Now.Second.ToString("00");
            Temporizator.Start();
           
        }

        private void Incepere_Final_MouseHover(object sender, EventArgs e)
        {

        }

        private void Temporizator_Tick(object sender, EventArgs e)
        {
            ORA.Text = DateTime.Now.Hour.ToString("00");
            MINUTE.Text = DateTime.Now.Minute.ToString("00");
            SECUNDE.Text = DateTime.Now.Second.ToString("00");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SECUNDE_Click(object sender, EventArgs e)
        {

        }

        private void Incepere_Final_Click(object sender, EventArgs e)
        {

        }
    }
}
