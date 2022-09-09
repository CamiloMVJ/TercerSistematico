using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Camilo Javie Mayorga Vivas - 1M2-IS
namespace Tercer_sistematico
{
    public partial class frmPromedio : Form
    {
        int a = 0;
        int[] notas = new int[3];
        Estudiante est = new Estudiante();
        public frmPromedio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Esta seguro que quiere salir?", "Control de promedio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            est.Nombre = txtNombre.Text;
            est.Notas = notas;

            ListViewItem info = new ListViewItem(est.Nombre);
            info.SubItems.Add(est.Notas[0].ToString() + ", " + est.Notas[1].ToString() + ", " + est.Notas[2].ToString());
            info.SubItems.Add(est.PromedioArregl().ToString("0.00"));
            lvInfo.Items.Add(info);
            txtNombre.Clear();
            txtNota.Clear();
            lblNota1.Text = "";
            lblNota2.Text = "";
            lblNota3.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            notas[a] = int.Parse(txtNota.Text);
            if (a == 0)
            {
                lblNota1.Text = notas[a].ToString();
            }
            if (a == 1)
            {
                lblNota2.Text = notas[a].ToString();
            }
            if (a == 2)
            {
                lblNota3.Text = notas[a].ToString();
            }
            a++;
            if (a == 3)
            {
                a = 0;
            }

            txtNota.Clear();
            txtNota.Focus();

        }

        private void frmPromedio_Load(object sender, EventArgs e)
        {
            lblNota1.Text = "";
            lblNota2.Text = "";
            lblNota3.Text = "";
        }
    }
}
