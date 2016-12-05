using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadenegocio.PRESTAMOS;
using Capadenegocio.PERSONAL;

namespace SistemaBiblioteca.PRESTAMO.SALIDA
{
    public partial class frmSalida : DevComponents.DotNetBar.Office2007Form
        //Form
    {
        NegPRESTAMO prestamo = new NegPRESTAMO();
        public frmSalida()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            try
            {
                txtNPrestamo.Text = prestamo.GenerarCodigo();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
            dtpFecha.Value = DateTime.Now;
            txtObservacion.Clear();

            //limpiar visitante
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();

            //limpiar datagrid
            dtRegistro.DataSource = null;
            
            //botones
            btGuardar.Enabled = true;
            btEditar.Enabled = false;
            btEliminar.Enabled = false;
        }

        private void frmSalida_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            try
            {
                txtNPrestamo.Text = prestamo.GenerarCodigo();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
        }

        private void frmSalida_Resize(object sender, EventArgs e)
        {
            this.panelEx5.Width = dtRegistro.Width;
            this.panelEx6.Width = dtRegistro.Width;
            this.btCargarLibros.Left = dtRegistro.Width + panelEx9.Width - btCargarLibros.Width;
        }

        private void frmSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.prestamo = new frmSalida();
        }

        private void btCargarLibros_Click(object sender, EventArgs e)
        {
            Formularios.buscarbibliografia.Show();
        }

        private void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtIdentificacion.Text.Trim() != "")
                {
                    var visitante = new NegVISITANTE();
                    var v = visitante.buscar(txtIdentificacion.Text.Trim());
                    if (v != null)
                    {
                        txtIdUsuario.Text = v.IDVISITANTE.ToString();
                        txtTipoUsuario.Text = v.TIPOUSUARIO;
                        txtNombre.Text = v.NOMBRES;
                        txtApellidos.Text = v.APELLIDOS;
                        txtIdentificacion.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra ninguna persona con esta identificación.");
                    }
                    visitante = null; v = null;
                }
            }
        }

        private void btCargarVisitante_Click(object sender, EventArgs e)
        {
            Formularios.buscarvisitante.frm_retornar = 1;
            Formularios.buscarvisitante.ShowDialog();
            txtIdentificacion.Focus();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Formularios.prestamo.dtRegistro.DataSource = (from lib in Formularios.libros_a_prestar select new { REGISTRO = lib.Registro, TIPODEDOCUMENTO = lib.Libro.TipoDocumento, TIPOREGISTRO = lib.Libro.TipoRegistro, TITULO = lib.Libro.Titulo, AUTOR = "", IDIOMA = lib.Libro.Idioma.Descripcion, ISBN = lib.Libro.Isbn, SIGNATURA = lib.Libro.Signatura, EDICION = lib.Libro.Edicion, COLACION = lib.Libro.Colacion }).ToList();
        }

        private void dtRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (dtRegistro.SelectedRows.Count > 0)
                {
                    var id = Guid.Parse(dtRegistro.SelectedRows[0].Cells[0].Value.ToString());
                    var d = Formularios.libros_a_prestar.Where(c=> c.IdInventario == id).FirstOrDefault();
                    if (d != null)
                    {
                        Formularios.libros_a_prestar.Remove(d);
                    }
                    dtRegistro.Rows.Remove(dtRegistro.SelectedRows[0]);
                }
            }
        }
    }
}