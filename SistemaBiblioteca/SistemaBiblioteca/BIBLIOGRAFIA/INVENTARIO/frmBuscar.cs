using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadenegocio.BIBLIOGRAFIA;

namespace SistemaBiblioteca.BIBLIOGRAFIA.INVENTARIO
{
    public partial class frmBuscar : DevComponents.DotNetBar.Office2007Form
        //Form
    {
        public int frm_retornar = 0;
        NegINVENTARIO inventario = new NegINVENTARIO();
        public void listar(string autor = "", string titulo = "", string signatura = "")
        {
            try
            {
                if (dtRegistro.Visible)
                {
                    dtRegistro.DataSource = inventario.listar(autor, titulo, signatura);
                    if (dtRegistro.Columns.Count > 0)
                    {
                        dtRegistro.Columns[0].Visible = false;
                        dtRegistro.Columns[1].HeaderText = "REGISTRO"; dtRegistro.Columns[1].Width = 120;
                        dtRegistro.Columns[2].HeaderText = "TIPO DE DOC."; dtRegistro.Columns[2].Width = 120;
                        dtRegistro.Columns[3].HeaderText = "TIPO DE REG."; dtRegistro.Columns[3].Width = 120;
                        dtRegistro.Columns[4].HeaderText = "TÍTUTLO"; dtRegistro.Columns[4].Width = 400;
                        dtRegistro.Columns[5].HeaderText = "AUTOR (ES)"; dtRegistro.Columns[5].Width = 400;
                        dtRegistro.Columns[6].HeaderText = "IDIOMA"; dtRegistro.Columns[6].Width = 120;
                        dtRegistro.Columns[7].HeaderText = "ISBN"; dtRegistro.Columns[7].Width = 120;
                        dtRegistro.Columns[8].HeaderText = "SIGNATURA"; dtRegistro.Columns[8].Width = 120;
                        dtRegistro.Columns[9].HeaderText = "EDICIÓN"; dtRegistro.Columns[9].Width = 120;
                        dtRegistro.Columns[10].HeaderText = "COLACIÓN"; dtRegistro.Columns[10].Width = 120;
                    }
                }
                else
                {
                    //cargar el reporte
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
        }
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            listar(txtAutor.Text.Trim(), txtTitulo.Text.Trim(), txtSignatura.Text.Trim());
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtRegistro.Visible = true;
            crvReporte.Visible = false;
            listar(txtAutor.Text.Trim(), txtTitulo.Text.Trim(), txtSignatura.Text.Trim());
        }

        private void btReporte_Click(object sender, EventArgs e)
        {
            dtRegistro.Visible = false;
            crvReporte.Visible = true;
            listar(txtAutor.Text.Trim(), txtTitulo.Text.Trim(), txtSignatura.Text.Trim());
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtSignatura.Clear();
            txtAutor.Clear();
            listar();
        }

        private void dtRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtRegistro.SelectedRows.Count > 0)
                {
                    var v = this.inventario.buscar(Guid.Parse(dtRegistro.SelectedRows[0].Cells[0].Value.ToString()));
                    if (v != null)
                    {
                        switch (frm_retornar)
                        {
                            case 0:
                                if (Formularios.libros_a_prestar.Where(c => c.IdInventario == v.ID_INVENTARIO).FirstOrDefault() == null)
                                {
                                    Formularios.libros_a_prestar.Add(v);
                                }
                                Formularios.prestamo.dtRegistro.DataSource = (from lib in Formularios.libros_a_prestar select new { REGISTRO = lib.Registro, TIPODEDOCUMENTO = lib.Libro.TipoDocumento, TIPOREGISTRO = lib.Libro.TipoRegistro, TITULO = lib.Libro.Titulo, AUTOR = "", IDIOMA = lib.Libro.Idioma.Descripcion, ISBN = lib.Libro.Isbn, SIGNATURA = lib.Libro.Signatura, EDICION = lib.Libro.Edicion, COLACION = lib.Libro.Colacion }).ToList();
                                MessageBox.Show("Agregado a la lista!!!!...");
                                break;
                            case 1:

                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra esta copia de libro. Probablemente ha sido eliminado.");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
        }

        private void frmBuscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.buscarbibliografia = new frmBuscar();
        }
    }
}