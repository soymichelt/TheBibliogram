Public Class frmRecomendacion
    Public IdRecomendacion As Guid = Guid.Empty

    Sub Limpiar()
        IdRecomendacion = Guid.Empty
        cmbArea.SelectedIndex = -1
        txtTitulo.Clear()
        txtOtroTitulo.Clear()
        txtAutor.Clear()
        txtIsbn.Clear()
        txtVolumen.Clear()
        txtEdicion.Clear()
        txtNota.Clear()
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        cmbArea.Focus()
    End Sub
    Private Sub frmRecomendacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If cmbArea.Text.Trim = "" And txtTitulo.Text.Trim = "" And txtAutor.Text.Trim = "" Then
            MessageBox.Show("Ingresar los campos de orden obligatorio (*).")
        End If
        Try
            Using Recomendacion As New RecomendacionServicio.RecomendacionServicioClient
                Me.IdRecomendacion = Recomendacion.Guardar(New RecomendacionServicio.DRecomendacion With {.AreaDirigida = cmbArea.Text, .Titulo = txtTitulo.Text, .OtroTitulo = txtOtroTitulo.Text, .Autores = txtAutor.Text, .Isbn = txtIsbn.Text, .Volumen = txtVolumen.Text, .Edicion = txtEdicion.Text, .Nota = txtNota.Text, .IdUsuario = VarGlobales.Sesion.IdUsuario})
                Limpiar()
                MessageBox.Show("Guardado Correctamente")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNota.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
        End If
    End Sub
End Class