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
using Capadenegocio.UBICACION;
using Capadedatos.Models;

namespace SistemaBiblioteca.PERSONAL.VISITANTE
{
    public partial class frmVisitante : //Form
        DevComponents.DotNetBar.Office2007Form
    {
        public Guid id;
        NegVISITANTE visitante = new NegVISITANTE();
        NegCIUDAD ciudad = new NegCIUDAD();

        void limpiar()
        {
            cmbTipo.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            txtNInss.Clear();
            cmbDepartamento.SelectedIndex = -1;
            cmbDepartamento.Enabled = false;
            txtArea.Clear();
            txtArea.Enabled = false;
            txtIdentificacion.Text = "";
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            txtTelefono.Text = "";
            txtDomicilio.Clear();
            txtObservacion.Clear();
            btGuardar.Enabled = true;
            btEditar.Enabled = false;
            btEliminar.Enabled = false;
        }

        public frmVisitante()
        {
            InitializeComponent();

        }

        private void frmVisitante_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCiudad.DataSource = ciudad.CIUDADES(); cmbCiudad.DisplayMember = "DESCRIPCION"; cmbCiudad.ValueMember = "ID_CIUDAD";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if ((cmbTipo.SelectedItem != null && cmbTipo.SelectedIndex != -1) && (cmbUsuario.SelectedItem != null && cmbUsuario.SelectedIndex != -1) && txtIdentificacion.Text.Trim() != "" && txtNombres.Text.Trim() != "" && txtApellidos.Text.Trim() != "" && (cmbCiudad.SelectedValue != null && cmbCiudad.SelectedIndex != -1))
            {
                var v = new Capadedatos.Models.Persona();
                if (cmbUsuario.SelectedItem.ToString() == "DOCENTE HORARIO" || cmbUsuario.SelectedItem.ToString() == "DOCENTE FIJO")
                {
                    if (cmbDepartamento.SelectedItem != null && cmbDepartamento.SelectedIndex != -1)
                    {
                        v.DEPARTAMENTO_ACADEMICO = cmbDepartamento.SelectedItem.ToString();
                        v.AREA = "";
                    }
                    else
                    {
                        MessageBox.Show("Ingresar el departamento académico del docente.");
                        return;
                    }
                }
                else if (cmbUsuario.SelectedItem.ToString() == "TRABAJADOR ADMINISTRATIVO")
                {
                    if (txtArea.Text.Trim() != "")
                    {
                        v.DEPARTAMENTO_ACADEMICO = "";
                        v.AREA = txtArea.Text;
                    }
                    else
                    {
                        MessageBox.Show("Ingresar el Área Laboral del Trabajador.");
                    }
                }
                else
                {
                    v.DEPARTAMENTO_ACADEMICO = "";
                    v.AREA = "";
                }
                v.TIPOIDENTIFICACION = cmbTipo.SelectedItem.ToString();
                v.IDENTIFICACION = txtIdentificacion.Text;
                v.TipoPersona = cmbUsuario.SelectedItem.ToString();
                v.N_INSS = txtNInss.Text;
                v.NOMBRES = txtNombres.Text;
                v.APELLIDOS = txtApellidos.Text;
                v.FECHANACIMIENTO = dtpFechaNacimiento.Value;
                v.TELEFONO = txtTelefono.Text;
                v.DOMICILIO = txtDomicilio.Text;
                v.OBSERVACION = txtObservacion.Text;
                v.ID_CIUDAD = Guid.Parse(cmbCiudad.SelectedValue.ToString());
                v.ACTIVO = true;
                if (visitante.Guardar(v))
                {
                    MessageBox.Show("Guardado");
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Formularios.buscarvisitante.frm_retornar = 0;
            Formularios.buscarvisitante.ShowDialog();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if ((cmbTipo.SelectedItem != null && cmbTipo.SelectedIndex != -1) && (cmbUsuario.SelectedItem != null && cmbUsuario.SelectedIndex != -1) && txtIdentificacion.Text.Trim() != "" && txtNombres.Text.Trim() != "" && txtApellidos.Text.Trim() != "" && (cmbCiudad.SelectedValue != null && cmbCiudad.SelectedIndex != -1))
            {
                var v = visitante.buscar(this.id);
                if (v != null)
                {
                    if (cmbUsuario.SelectedItem.ToString() == "DOCENTE HORARIO" || cmbUsuario.SelectedItem.ToString() == "DOCENTE FIJO")
                    {
                        if (cmbDepartamento.SelectedItem != null && cmbDepartamento.SelectedIndex != -1)
                        {
                            v.DEPARTAMENTO_ACADEMICO = cmbDepartamento.SelectedItem.ToString();
                            v.AREA = "";
                        }
                        else
                        {
                            MessageBox.Show("Ingresar el departamento académico del docente.");
                            return;
                        }
                    }
                    else if (cmbUsuario.SelectedItem.ToString() == "TRABAJADOR ADMINISTRATIVO")
                    {
                        if (txtArea.Text.Trim() != "")
                        {
                            v.DEPARTAMENTO_ACADEMICO = "";
                            v.AREA = txtArea.Text;
                        }
                        else
                        {
                            MessageBox.Show("Ingresar el Área Laboral del Trabajador.");
                        }
                    }
                    else
                    {
                        v.DEPARTAMENTO_ACADEMICO = "";
                        v.AREA = "";
                    }
                    v.TIPOIDENTIFICACION = cmbTipo.SelectedItem.ToString();
                    v.IDENTIFICACION = txtIdentificacion.Text;
                    v.TIPOUSUARIO = cmbUsuario.SelectedItem.ToString();
                    v.N_INSS = txtNInss.Text;
                    v.NOMBRES = txtNombres.Text;
                    v.APELLIDOS = txtApellidos.Text;
                    v.FECHANACIMIENTO = dtpFechaNacimiento.Value;
                    v.TELEFONO = txtTelefono.Text;
                    v.DOMICILIO = txtDomicilio.Text;
                    v.OBSERVACION = txtObservacion.Text;
                    v.ID_CIUDAD = Guid.Parse(cmbCiudad.SelectedValue.ToString());
                    v.ACTIVO = true;
                    if (visitante.Editar(v))
                    {
                        MessageBox.Show("Editado");
                        limpiar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Los campos de orden obligatorio (*) no pueden estar vacios.");
            }
        }

        private void frmVisitante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.visitante = new frmVisitante();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            var v = visitante.buscar(this.id);
            if (v != null)
            {
                if (btEliminar.Text == "Desactivar")
                {
                    v.ACTIVO = false;
                    if (visitante.Eliminar(v))
                    {
                        MessageBox.Show("Desactivado");
                        limpiar();
                    }
                }
                else if(btEliminar.Text == "Activar")
                {
                    v.ACTIVO = true;
                    if (visitante.Eliminar(v))
                    {
                        MessageBox.Show("Activado");
                        limpiar();
                    }
                }
            }
        }

        private void btActualizarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                cmbCiudad.DataSource = ciudad.CIUDADES(); cmbCiudad.DisplayMember = "DESCRIPCION"; cmbCiudad.ValueMember = "ID_CIUDAD";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, " + error.Message);
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem != null && cmbUsuario.SelectedIndex != -2)
            {
                if (cmbUsuario.SelectedItem.ToString() == "DOCENTE HORARIO" || cmbUsuario.SelectedItem.ToString() == "DOCENTE FIJO")
                {
                    cmbDepartamento.Enabled = true;
                    txtArea.Enabled = false;
                    txtArea.Clear();
                }
                else if (cmbUsuario.SelectedItem.ToString() == "TRABAJADOR ADMINISTRATIVO")
                {
                    txtArea.Enabled = true;
                    cmbDepartamento.Enabled = false;
                    cmbDepartamento.SelectedIndex = -1;
                }
                else
                {
                    cmbDepartamento.Enabled = false;
                    cmbDepartamento.SelectedIndex = -1;
                    txtArea.Enabled = false;
                    txtArea.Clear();
                }
            }
        }
    }
}
