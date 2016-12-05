Public Class frmCiudad

    Public IdCiudad As Guid = Guid.Empty
    Public LoadForm As Boolean = False

    Sub Limpiar()
        Me.IdCiudad = Guid.Empty
        txtNombre.Clear()
        cmbPais.SelectedIndex = -1
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub frmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using Pais As New PaisServicio.PaisServicioClient
                cmbPais.DataSource = Pais.Lista() : cmbPais.ValueMember = "IdPais" : cmbPais.DisplayMember = "Descripcion" : cmbPais.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtNombre.Text.Trim <> "" Then
                If txtNombre.Text.Trim.Length >= 4 Then
                    Try
                        Using Ciudad As New CiudadServicio.CiudadServicioClient
                            Dim ciu = Ciudad.BuscarPorNombre(txtNombre.Text.Trim)
                            If Not ciu Is Nothing Then
                                Me.IdCiudad = ciu.IdCiudad
                                cmbPais.Text = ciu.Pais
                                btGuardar.Enabled = False
                                btEditar.Enabled = True
                                btEliminar.Enabled = True
                            Else
                                cmbPais.Focus()
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                Else
                    MessageBox.Show("El nombre de la ciudad debe contener mas de 4 caracteres.")
                End If
            Else
                MessageBox.Show("Ingresar el Nombre de la Ciudad.")
            End If
        End If
    End Sub

    Private Sub cmbPais_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPais.KeyDown
        Try
            If Not cmbPais.SelectedValue Is Nothing Then
                If btGuardar.Enabled = True Then

                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            If txtNombre.Text.Trim <> "" And cmbPais.SelectedIndex <> -1 Then
                Using Ciudad As New CiudadServicio.CiudadServicioClient
                    Ciudad.Guardar(New CiudadServicio.DCiudad With {.Descripcion = txtNombre.Text, .IdPais = Guid.Parse(cmbPais.SelectedValue.ToString())})
                    Limpiar()
                    MessageBox.Show("Guardado!!!")
                End Using
            Else
                MessageBox.Show("Ingresar Nombre y Seleccionar Pais.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If Me.IdCiudad <> Guid.Empty Then
            Try
                If txtNombre.Text.Trim <> "" And cmbPais.SelectedIndex <> -1 Then
                    Using Ciudad As New CiudadServicio.CiudadServicioClient
                        Ciudad.Editar(New CiudadServicio.DCiudad With {.IdCiudad = Me.IdCiudad, .Descripcion = txtNombre.Text, .IdPais = Guid.Parse(cmbPais.SelectedValue.ToString())})
                        Limpiar()
                        MessageBox.Show("Editado!!!")
                    End Using
                Else
                    MessageBox.Show("Ingresar Nombre y Seleccionar Pais.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccionar una Ciudad.")
            Limpiar()
        End If
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If MessageBox.Show("¿Desea Eliminar?", "Pregunta de seguridad.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Me.IdCiudad <> Guid.Empty Then
                Try
                    Using Ciudad As New CiudadServicio.CiudadServicioClient
                        Ciudad.Eliminar(Me.IdCiudad)
                        Limpiar()
                        MessageBox.Show("Eliminado!!!")
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Seleccionar una Ciudad.")
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btActPais_Click(sender As Object, e As EventArgs) Handles btActPais.Click
        Try
            Using Pais As New PaisServicio.PaisServicioClient
                cmbPais.DataSource = Pais.Lista() : cmbPais.ValueMember = "IdPais" : cmbPais.DisplayMember = "Descripcion" : cmbPais.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        frmBuscarCiudad.ShowDialog()
    End Sub
End Class