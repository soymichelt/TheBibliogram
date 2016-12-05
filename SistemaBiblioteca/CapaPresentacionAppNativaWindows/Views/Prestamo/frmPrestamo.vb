Public Class frmPrestamo
    Public ListadoLibros As New List(Of PrestamoServicio.DInventario)
    Public IdPrestamo As Guid = Guid.Empty
    Sub Limpiar()
        txtNPrestamo.Text = "0000000000"
        dtpFecha.Value = DateTime.Now
        cmbTipo.SelectedIndex = -1
        txtDescripcion.Clear()
        txtIdPersona.Clear()
        txtNombrePersona.Clear()
        dtRegistro.DataSource = Nothing
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        btImprimir.Enabled = False
        txtNPrestamo.Focus()
    End Sub

    Private Sub frmPrestamo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnSeleccionar.Width = pnDetalle.Width - (pnSeleccionar.Location.X * 2)
        txtLibro.Width = pnSeleccionar.Width - txtLibro.Location.X - 6
    End Sub

    Private Sub frmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.DataSource = VarGlobales.TipoPrestamo.ToList : cmbTipo.ValueMember = "Key" : cmbTipo.DisplayMember = "Name" : cmbTipo.SelectedIndex = -1
        dtpFecha.Value = DateTime.Now
        txtNPrestamo.Focus()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub

    Private Sub frmPrestamo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Keys.F1
                btNuevo_Click(Nothing, Nothing)
            Case Keys.F2
                If btGuardar.Enabled Then
                    btGuardar_Click(Nothing, Nothing)
                End If
            Case Keys.F3
                If btEditar.Enabled Then
                    'btEditar_Click(Nothing, Nothing)
                End If
            Case Keys.F4
                If btEliminar.Enabled Then
                    'btEliminar_Click(Nothing, Nothing)
                End If
            Case Keys.F5
                btBuscar_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub txtLibro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLibro.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtLibro.Text.Trim <> "" Then
                Try
                    Using Inventario As New PrestamoServicio.PrestamoServicioClient
                        Dim inv = Inventario.BuscarPorRegistro(txtLibro.Text.Trim)
                        If Not inv Is Nothing Then
                            If Me.ListadoLibros.Where(Function(f) f.IdInventario = inv.IdInventario).FirstOrDefault Is Nothing Then
                                Me.ListadoLibros.Add(inv)
                            End If
                            Me.llenar()
                            txtLibro.Clear()
                            txtLibro.Focus()
                        Else
                            MessageBox.Show("No existe ninguna copia de libro con este Nº de Registro.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                frmBuscarLibro.rinventario = True
                frmBuscarLibro.Frm = 1
                frmBuscarLibro.ShowDialog()
            End If
        End If
    End Sub

    Public Sub llenar()
        dtRegistro.DataSource = (From inv In Me.ListadoLibros Select inv.IdInventario, inv.Registro, inv.TipoDocumento, inv.TipoRegistro, inv.Signatura, inv.Titulo, inv.OtroTitulo, inv.Autor1, inv.Autor2, inv.Autor3, inv.Institucion, inv.Idioma, inv.Isbn, inv.Editor, inv.Edicion).ToList
        If dtRegistro.Columns.Count > 0 Then
            dtRegistro.Columns(0).Visible = False
            dtRegistro.Columns(1).HeaderText = "Nº Registro"
            dtRegistro.Columns(2).Width = 110 : dtRegistro.Columns(2).HeaderText = vbNewLine & "T. Documento" & vbNewLine
            dtRegistro.Columns(3).Width = 100 : dtRegistro.Columns(3).HeaderText = "T. Registro"
            dtRegistro.Columns(4).Width = 150 : dtRegistro.Columns(4).HeaderText = "Signatura"
            dtRegistro.Columns(5).Width = 250 : dtRegistro.Columns(5).HeaderText = "Título de la Bibliografía"
            dtRegistro.Columns(6).Width = 150 : dtRegistro.Columns(6).HeaderText = "Otro Título"
            dtRegistro.Columns(7).Width = 170 : dtRegistro.Columns(7).HeaderText = "Autor Personal 1"
            dtRegistro.Columns(8).Width = 170 : dtRegistro.Columns(8).HeaderText = "Autor Personal 2"
            dtRegistro.Columns(9).Width = 170 : dtRegistro.Columns(9).HeaderText = "Autor Personal 3"
            dtRegistro.Columns(10).Width = 200 : dtRegistro.Columns(10).HeaderText = "Institución"
            dtRegistro.Columns(11).Width = 80 : dtRegistro.Columns(11).HeaderText = "Idioma"
            dtRegistro.Columns(12).Width = 120 : dtRegistro.Columns(12).HeaderText = "ISBN"
            dtRegistro.Columns(13).Width = 100 : dtRegistro.Columns(13).HeaderText = "Editor"
            dtRegistro.Columns(14).Width = 80 : dtRegistro.Columns(14).HeaderText = "Edición"
        End If
    End Sub

    Private Sub txtNPrestamo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNPrestamo.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtNPrestamo.Text.Trim <> "" Then
                Try
                    Using Prestamo As New PrestamoServicio.PrestamoServicioClient
                        Dim pre = Prestamo.BuscarPorN(Integer.Parse(txtNPrestamo.Text.Trim))
                        If Not pre Is Nothing Then

                        Else
                            dtpFecha.Focus()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                txtNPrestamo.Text = "0000000000"
                dtpFecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtNPrestamo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNPrestamo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyData = Keys.Enter Then
            cmbTipo.Focus()
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbTipo.SelectedValue Is Nothing Then
                txtDescripcion.Focus()
            Else
                MessageBox.Show("Seleccionar el tipo de prestamo.")
            End If
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyData = Keys.Enter Then
            txtPersona.Focus()
        End If
    End Sub

    Private Sub txtPersona_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPersona.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtPersona.Text.Trim <> "" Then
                Try
                    Using Persona As New PersonaServicio.PersonaServicioClient
                        Dim Per = Persona.BuscarPorCarnetOIdentificacion(txtPersona.Text.Trim())
                        If Not Per Is Nothing Then
                            Using Prestamo As New PrestamoServicio.PrestamoServicioClient
                                txtIdPersona.Text = Per.IdPersona.ToString()
                                txtNombrePersona.Text = txtPersona.Text & " - " & Per.Nombres & " " & Per.Apellidos
                                txtPersona.Clear()
                                txtLibro.Focus()
                            End Using
                        Else
                            MessageBox.Show("No se encuentra ningun(a) 'Persona' con este Nº de Carnet o Identificación")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                frmBuscarPersona.Frm = 1
                frmBuscarPersona.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            If cmbTipo.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccionar el tipo de préstamo.")
                cmbTipo.Focus()
                Exit Sub
            End If
            If txtIdPersona.Text.Trim = "" Then
                MessageBox.Show("Ingresar el Solicitante.")
                txtPersona.Focus()
                Exit Sub
            End If
            If Me.ListadoLibros.Count = 0 Then
                MessageBox.Show("Ingresar la Bibliografía a Prestar.")
                txtLibro.Focus()
                Exit Sub
            End If
            Using Prestamo As New PrestamoServicio.PrestamoServicioClient
                Prestamo.Guardar(New PrestamoServicio.DPrestamo With {.Tipo = cmbTipo.SelectedValue.ToString(), .Observacion = txtDescripcion.Text, .FechaPrestamo = dtpFecha.Value, .IdPersona = Guid.Parse(txtIdPersona.Text)}, Me.ListadoLibros)
            End Using
            Me.Limpiar()
            MessageBox.Show("Guardado!!.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btBuscarPersona_Click(sender As Object, e As EventArgs) Handles btBuscarPersona.Click
        frmBuscarPersona.Frm = 1
        frmBuscarPersona.ShowDialog()
    End Sub

    Private Sub btAgregarPersona_Click(sender As Object, e As EventArgs) Handles btAgregarPersona.Click
        frmPersona.MdiParent = frmPrincipal
        frmPersona.BringToFront()
        frmPersona.Show()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        frmBuscarPrestamo.ShowDialog()
    End Sub

    Private Sub dtRegistro_KeyDown(sender As Object, e As KeyEventArgs) Handles dtRegistro.KeyDown
        Try
            If e.KeyData = Keys.Delete Then
                Dim IdInventario = Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString())
                Me.ListadoLibros.Remove(Me.ListadoLibros.Where(Function(f) f.IdInventario = IdInventario).FirstOrDefault)
                dtRegistro.DataSource = Me.ListadoLibros.ToList
                txtLibro.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class