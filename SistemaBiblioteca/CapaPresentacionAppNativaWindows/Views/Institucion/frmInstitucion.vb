Public Class frmInstitucion

    Public Id As Guid = Guid.Empty
    Public LoadForm As Boolean = False

    Sub Limpiar()
        txtNombre.Clear()
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
    End Sub

    Private Sub frmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

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
                        Using Pais As New PaisServicio.PaisServicioClient
                            Dim pai = Pais.BuscarPorNombre(txtNombre.Text.Trim)
                            If Not pai Is Nothing Then
                                Me.Id = pai.IdPais
                                btGuardar.Enabled = False
                                btEditar.Enabled = True
                                btEliminar.Enabled = True
                            Else
                                If btGuardar.Enabled Then
                                    btGuardar_Click(Nothing, Nothing)
                                End If
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

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            If txtNombre.Text.Trim <> "" Then
                Using Pais As New PaisServicio.PaisServicioClient
                    Pais.Guardar(New PaisServicio.DPais With {.Descripcion = txtNombre.Text})
                    Limpiar()
                    MessageBox.Show("Guardado!!!")
                End Using
            Else
                MessageBox.Show("Ingresar Nombre.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Try
            If txtNombre.Text.Trim <> "" And Me.Id <> Guid.Empty Then
                Using Pais As New PaisServicio.PaisServicioClient
                    Pais.Editar(New PaisServicio.DPais With {.IdPais = Me.Id, .Descripcion = txtNombre.Text})
                    Limpiar()
                    MessageBox.Show("Editado!!!")
                End Using
            Else
                MessageBox.Show("Ingresar Nombre.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If MessageBox.Show("¿Desea Eliminar?", "Pregunta de seguridad.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes And Me.Id <> Guid.Empty Then
            Try
                Using Pais As New PaisServicio.PaisServicioClient
                    Pais.Eliminar(Me.Id)
                    Limpiar()
                    MessageBox.Show("Eliminado!!!")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        frmBuscarPais.ShowDialog()
    End Sub
End Class