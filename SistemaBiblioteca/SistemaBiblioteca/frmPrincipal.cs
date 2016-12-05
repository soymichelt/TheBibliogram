using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class frmPrincipal : DevComponents.DotNetBar.Office2007RibbonForm
        //Form
    {
        Capadenegocio.BIBLIOGRAFIA.NegRECOMENDACION recomendacion = new Capadenegocio.BIBLIOGRAFIA.NegRECOMENDACION ();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Capadedatos.Models.ContextoBiblioteca())
                {
                    db.Database.CreateIfNotExists();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
        }

        private void btLibro_Click(object sender, EventArgs e)
        {

        }

        private void btAutor_Click(object sender, EventArgs e)
        {

        }

        private void btInstitucion_Click(object sender, EventArgs e)
        {

        }

        private void btEncabezados_Click(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {

        }

        private void btIdioma_Click(object sender, EventArgs e)
        {

        }

        private void btEditor_Click(object sender, EventArgs e)
        {

        }

        private void btVisitante_Click(object sender, EventArgs e)
        {
            Formularios.visitante.Show();
            Formularios.visitante.BringToFront();
        }

        private void btPrestamos_Click(object sender, EventArgs e)
        {
            Formularios.prestamo.Show();
            Formularios.prestamo.BringToFront();
        }
    }
}
