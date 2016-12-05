Imports System.Text.RegularExpressions

Public Class frmRegistrer

    Sub Limpiar()
        txtNombres.Clear()
        txtApellidos.Clear()
        dtpFecha.Value = Nothing
        rdHombre.Checked = True
        cmbRol.SelectedIndex = -1
        txtEmail.Clear()
        txtPassword.Clear()
        txtDescripcion.Clear()
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        txtNombres.Focus()
    End Sub

    Private Sub frmRegistrer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRol.DataSource = VarGlobales.RolUsuario : cmbRol.ValueMember = "Key" : cmbRol.DisplayMember = "Name" : cmbRol.SelectedIndex = -1
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            If txtNombres.Text.Trim = "" Or txtApellidos.Text.Trim = "" Then
                MessageBox.Show("Ingresar Nombres y Apellidos")
                txtNombres.Focus()
                Exit Sub
            End If
            If dtpFecha.Value.Year < 1900 Then
                MessageBox.Show("La Fecha de Nacimiento debe ser mayor de 31/12/1899")
                dtpFecha.Focus()
                Exit Sub
            End If
            If cmbRol.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione el Rol de Usuario")
                cmbRol.Focus()
                Exit Sub
            End If
            If txtEmail.Text.Trim = "" Then
                MessageBox.Show("Ingresar E-Mail")
                txtEmail.Focus()
                Exit Sub
            ElseIf Not Me.IsValidEmail(txtEmail.Text) Then
                MessageBox.Show("Formato de E-Mail inválido")
                Exit Sub
            End If
            If txtPassword.Text.Trim = "" Then
                MessageBox.Show("Ingresar Contraseña")
                txtPassword.Focus()
                Exit Sub
            End If
            Using Usuario As New AccountServicio.AccountServicioClient
                Usuario.Register(New AccountServicio.DUsuario With {.Nombres = txtNombres.Text, .Apellidos = txtApellidos.Text, .FechaNacimiento = dtpFecha.Value, .Email = txtEmail.Text, .Password = txtPassword.Text, .Rol = Integer.Parse(cmbRol.SelectedValue.ToString()), .Descripcion = txtDescripcion.Text})
                Limpiar()
                MessageBox.Show("Guardado Correctamente")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rdMujer_CheckedChanged(sender As Object, e As EventArgs) Handles rdMujer.CheckedChanged

    End Sub
End Class