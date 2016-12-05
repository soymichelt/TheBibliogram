Public Class frmEditor

    Public Id As Guid = Guid.Empty
    Public LoadForm As Boolean = False

    Sub Limpiar()
        txtNombre.Clear()
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
    End Sub

    Sub Lista(Optional ByVal DescripcionP As String = "")
        Try
            Using Editor As New EditorServicio.EditorServicioClient
                dtRegistro.DataSource = (From edit In Editor.Busqueda(txtNombre.Text.Trim) Select edit.IdEditor, edit.Descripcion).ToList()
                If dtRegistro.Columns.Count > 0 Then
                    dtRegistro.Columns(0).Visible = False
                    dtRegistro.Columns(1).HeaderText = vbNewLine & "Descripción del Editor" & vbNewLine
                    dtRegistro.Columns(1).Width = 530
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista()
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
                Using Editor As New EditorServicio.EditorServicioClient
                    Editor.Guardar(New EditorServicio.DEditor With {.Descripcion = txtNombre.Text})
                    Limpiar()
                    MessageBox.Show("Guardado!!!")
                    Lista(txtBuscar.Text.Trim())
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
                Using Editor As New EditorServicio.EditorServicioClient
                    Editor.Editar(New EditorServicio.DEditor With {.IdEditor = Me.Id, .Descripcion = txtNombre.Text})
                    Limpiar()
                    MessageBox.Show("Editado!!!")
                    Lista(txtBuscar.Text.Trim())
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
                Using Editor As New EditorServicio.EditorServicioClient
                    Editor.Eliminar(Me.Id)
                    Limpiar()
                    MessageBox.Show("Eliminado!!!")
                    Lista(txtBuscar.Text.Trim())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        txtBuscar.Focus()
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyData = Keys.Enter Then
            Lista(txtBuscar.Text.Trim)
        End If
    End Sub

    Private Sub frmEditor_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Keys.F1
                btNuevo_Click(Nothing, Nothing)
            Case Keys.F2
                If btGuardar.Enabled Then
                    btGuardar_Click(Nothing, Nothing)
                End If
            Case Keys.F3
                If btEditar.Enabled Then
                    btEditar_Click(Nothing, Nothing)
                End If
            Case Keys.F4
                If btEliminar.Enabled Then
                    btEliminar_Click(Nothing, Nothing)
                End If
            Case Keys.F5
                btBuscar_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub dtRegistro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtRegistro.CellDoubleClick
        If dtRegistro.SelectedRows.Count > 0 Then
            Try
                Using Editor As New EditorServicio.EditorServicioClient
                    Dim Ed = Editor.BuscarPorId(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString()))
                    If Not Ed Is Nothing Then
                        Me.Id = Ed.IdEditor
                        txtNombre.Text = Ed.Descripcion
                        btGuardar.Enabled = False
                        btEditar.Enabled = True
                        btEliminar.Enabled = True
                        txtNombre.Focus()
                    Else
                        MessageBox.Show("No se encuentra este editor.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class