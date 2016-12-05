using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadenegocio.PERSONAL;

namespace SistemaBiblioteca.PERSONAL.VISITANTE
{
    public partial class frmBuscar : DevComponents.DotNetBar.Office2007Form
        //Form
    {
        public int frm_retornar = 0;
        NegVISITANTE visitante = new NegVISITANTE();
        public void listar(string identificacion = "", string nombres = "", string apellidos = "")
        {
            try
            {
                if (dtRegistro.Visible)
                {
                    dtRegistro.DataSource = (from v in visitante.listar() where v.IDENTIFICACION.Contains(identificacion) && v.NOMBRES.Contains(nombres) && v.APELLIDOS.Contains(apellidos) select new { v.IDVISITANTE, ACTIVO = (v.ACTIVO ? "ACTIVO" : "INACTIVO"), v.TIPOUSUARIO, v.DEPARTAMENTO_ACADEMICO, v.AREA, v.N_INSS, v.IDENTIFICACION, v.NOMBRES, v.APELLIDOS, v.TELEFONO, CIUDAD = v.CIUDAD.DESCRIPCION, PAÍS = v.CIUDAD.PAIS.DESCRIPCION, v.DOMICILIO, v.OBSERVACION }).ToList();
                    if (dtRegistro.Columns.Count > 0)
                    {
                        dtRegistro.Columns[0].Visible = false;
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

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            listar(txtIdentificacion.Text.Trim(), txtNombres.Text.Trim(), txtApellidos.Text.Trim());
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtRegistro.Visible = true;
            crvReporte.Visible = false;
            listar(txtIdentificacion.Text.Trim(), txtNombres.Text.Trim(), txtApellidos.Text.Trim());
        }

        private void btReporte_Click(object sender, EventArgs e)
        {
            dtRegistro.Visible = false;
            crvReporte.Visible = true;
            listar(txtIdentificacion.Text.Trim(), txtNombres.Text.Trim(), txtApellidos.Text.Trim());
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            listar();
        }

        private void dtRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtRegistro.SelectedRows.Count > 0)
                {
                    var v = this.visitante.buscar(Guid.Parse(dtRegistro.SelectedRows[0].Cells[0].Value.ToString()));
                    if (v != null)
                    {
                        switch (frm_retornar)
                        {
                            case 0:
                                Formularios.visitante.id = v.IDVISITANTE;
                                Formularios.visitante.cmbTipo.Text = v.TIPOIDENTIFICACION;
                                Formularios.visitante.txtIdentificacion.Text = v.IDENTIFICACION;
                                Formularios.visitante.cmbUsuario.Text = v.TIPOUSUARIO;
                                if (v.TIPOUSUARIO == "DOCENTE HORARIO" || v.TIPOUSUARIO == "DOCENTE FIJO")
                                {
                                    Formularios.visitante.cmbDepartamento.Text = v.DEPARTAMENTO_ACADEMICO;
                                    Formularios.visitante.cmbDepartamento.Enabled = true;
                                    Formularios.visitante.txtArea.Clear();
                                    Formularios.visitante.txtArea.Enabled = false;
                                }
                                else if (v.TIPOUSUARIO == "TRABAJADOR ADMINISTRATIVO")
                                {
                                    Formularios.visitante.cmbDepartamento.SelectedIndex = -1;
                                    Formularios.visitante.cmbDepartamento.Enabled = false;
                                    Formularios.visitante.txtArea.Text = v.AREA;
                                    Formularios.visitante.txtArea.Enabled = true;
                                }
                                else
                                {
                                    Formularios.visitante.cmbDepartamento.Enabled = false;
                                    Formularios.visitante.txtArea.Enabled = false;
                                }
                                Formularios.visitante.txtNInss.Text = v.N_INSS;
                                Formularios.visitante.txtNombres.Text = v.NOMBRES;
                                Formularios.visitante.txtApellidos.Text = v.APELLIDOS;
                                Formularios.visitante.dtpFechaNacimiento.Value = v.FECHANACIMIENTO;
                                Formularios.visitante.txtTelefono.Text = v.TELEFONO;
                                Formularios.visitante.txtDomicilio.Text = v.DOMICILIO;
                                Formularios.visitante.txtObservacion.Text = v.OBSERVACION;
                                Formularios.visitante.cmbCiudad.Text = v.CIUDAD.DESCRIPCION;
                                Formularios.visitante.btGuardar.Enabled = false;
                                Formularios.visitante.btEditar.Enabled = true;
                                if (v.ACTIVO)
                                {
                                    Formularios.visitante.btEliminar.Text = "Desactivar";
                                }
                                else
                                {
                                    Formularios.visitante.btEliminar.Text = "Activar";
                                }
                                Formularios.visitante.btEliminar.Enabled = true;
                                this.Close();
                                break;
                            case 1:
                                Formularios.prestamo.txtIdUsuario.Text = v.IDVISITANTE.ToString();
                                Formularios.prestamo.txtTipoUsuario.Text = v.TIPOUSUARIO;
                                Formularios.prestamo.txtNombre.Text = v.NOMBRES;
                                Formularios.prestamo.txtApellidos.Text = v.APELLIDOS;
                                this.Close();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el visitante seleccionado.");
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
            Formularios.buscarvisitante = new frmBuscar();
        }
    }
}