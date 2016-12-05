Imports System.IO

Public Class frmBuscarLibro
    Dim LoadForm As Boolean = False
    Public RLibro As Boolean = False
    Public RInventario As Boolean = False
    Public Frm As Integer = 0
    Sub Llenar()
        Try
            Using libr As New LibroServicio.LibroServicioClient
                dtRegistro.DataSource = (From libro In libr.Busqueda(New LibroServicio.DLibro With {.TIPODEDOCUMENTO = If(Not cmbTipoDocumento.SelectedValue Is Nothing, cmbTipoDocumento.SelectedValue.ToString(), ""), .TIPOREGISTRO = If(Not cmbTipoRegistro.SelectedValue Is Nothing, cmbTipoRegistro.SelectedValue.ToString(), ""), .TITULO = txtTitulo.Text.Trim, .SIGNATURA = txtSignatura.Text.Trim, .AUTOR1 = txtAutor.Text.Trim, .INSTITUCION = txtInstitucion.Text.Trim, .ISBN = txtIsbn.Text.Trim, .OTRO_CODIGO = txtOtroCodigo.Text.Trim}, "") Select libro.ID_LIBRO, libro.TIPODEDOCUMENTO, libro.TIPOREGISTRO, libro.TITULO, libro.OTRO_TITULO, libro.SIGNATURA, libro.OTRO_CODIGO, libro.INSTITUCION, libro.AUTOR1, libro.AUTOR2, libro.AUTOR3, libro.IDIOMA, libro.EDITORA, libro.CIUDAD, libro.EDICION, libro.FECHAPUBLICACION, libro.COLACION, libro.ISBN, libro.TIPOINVESTIGACION, libro.TUTOR, libro.GRADO, libro.ADQUISICION, libro.VALORORIGINAL, libro.VALORCORDOBA, libro.VALORDOLAR, libro.NOTAS, libro.RESUMEN).ToList()
                If dtRegistro.Columns.Count > 0 Then
                    dtRegistro.Columns(0).Visible = False
                    dtRegistro.Columns(1).Width = 80 : dtRegistro.Columns(1).HeaderText = vbNewLine & "T. Doc." & vbNewLine
                    dtRegistro.Columns(2).Width = 80 : dtRegistro.Columns(2).HeaderText = "T. Registro"
                    dtRegistro.Columns(3).Width = 250 : dtRegistro.Columns(3).HeaderText = "Título de la Bibliografía"
                    dtRegistro.Columns(4).Width = 150 : dtRegistro.Columns(4).HeaderText = "Otro Título"
                    dtRegistro.Columns(5).Width = 150 : dtRegistro.Columns(5).HeaderText = "Signatura"
                    dtRegistro.Columns(6).Width = 150 : dtRegistro.Columns(6).HeaderText = "Otro Código"
                    dtRegistro.Columns(7).Width = 200 : dtRegistro.Columns(7).HeaderText = "Institución"
                    dtRegistro.Columns(8).Width = 170 : dtRegistro.Columns(8).HeaderText = "Autor Personal 1"
                    dtRegistro.Columns(9).Width = 170 : dtRegistro.Columns(9).HeaderText = "Autor Personal 2"
                    dtRegistro.Columns(10).Width = 170 : dtRegistro.Columns(10).HeaderText = "Autor Personal 3"
                    dtRegistro.Columns(11).Width = 80 : dtRegistro.Columns(11).HeaderText = "Idioma"
                    dtRegistro.Columns(12).Width = 100 : dtRegistro.Columns(12).HeaderText = "Editor"
                    dtRegistro.Columns(13).Width = 120 : dtRegistro.Columns(13).HeaderText = "Ciudad"
                    dtRegistro.Columns(14).Width = 80 : dtRegistro.Columns(14).HeaderText = "Edición"
                    dtRegistro.Columns(15).Width = 120 : dtRegistro.Columns(15).HeaderText = "Publicado"
                    dtRegistro.Columns(16).Width = 80 : dtRegistro.Columns(16).HeaderText = "Colación"
                    dtRegistro.Columns(17).Width = 120 : dtRegistro.Columns(17).HeaderText = "ISBN"
                    dtRegistro.Columns(18).Width = 80 : dtRegistro.Columns(18).HeaderText = "T. Invest."
                    dtRegistro.Columns(19).Width = 200 : dtRegistro.Columns(19).HeaderText = "Tutor"
                    dtRegistro.Columns(20).Width = 200 : dtRegistro.Columns(20).HeaderText = "Grado"
                    dtRegistro.Columns(21).Width = 150 : dtRegistro.Columns(21).HeaderText = "Adquisición"
                    dtRegistro.Columns(22).Width = 120 : dtRegistro.Columns(22).HeaderText = "V. Original"
                    dtRegistro.Columns(23).Width = 120 : dtRegistro.Columns(23).HeaderText = "V. Córdoba"
                    dtRegistro.Columns(24).Width = 120 : dtRegistro.Columns(24).HeaderText = "V. Dólar"
                    dtRegistro.Columns(25).Width = 250 : dtRegistro.Columns(25).HeaderText = "Notas"
                    dtRegistro.Columns(26).Width = 250 : dtRegistro.Columns(26).HeaderText = "Resumen"
                    For Each c As DataGridViewColumn In dtRegistro.Columns
                        c.HeaderCell.Style.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
                        c.HeaderText = c.HeaderText.ToUpper
                    Next
                End If
                If dtRegistro.Rows.Count > 0 Then
                    dtDetalle.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub LlenarCopias(ByVal IdLibro As Guid)
        Try
            Using Inventario As New InventarioServicio.InventarioServicioClient

                dtDetalle.DataSource = (From inv In Inventario.CopiasDeLibro(IdLibro) Select inv.IdInventario, inv.Signatura, inv.Titulo, inv.Registro).ToList()
                If dtDetalle.Columns.Count > 0 Then
                    dtDetalle.Columns(0).Visible = False
                    dtDetalle.Columns(1).Width = 150 : dtDetalle.Columns(1).HeaderText = vbNewLine & "Signatura" & vbNewLine
                    dtDetalle.Columns(2).Width = 350 : dtDetalle.Columns(2).HeaderText = "Título de la Bibliografía"
                    dtDetalle.Columns(3).Width = 100 : dtDetalle.Columns(3).HeaderText = "Nº Registro"
                    For Each c As DataGridViewColumn In dtDetalle.Columns
                        c.HeaderCell.Style.Font = New Font("Arial", Me.Font.Size, FontStyle.Bold)
                        c.DefaultCellStyle.Font = New Font("Arial", Me.Font.Size, FontStyle.Regular)
                        c.HeaderText = c.HeaderText.ToUpper
                    Next
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbTipoRegistro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoRegistro.SelectedIndexChanged
        If Me.LoadForm Then

        End If
    End Sub

    Private Sub frmBuscarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoDocumento.DataSource = VarGlobales.TipoDocumento.ToList : cmbTipoDocumento.ValueMember = "Key" : cmbTipoDocumento.DisplayMember = "Name" : cmbTipoDocumento.SelectedIndex = -1
        cmbTipoRegistro.DataSource = VarGlobales.TipoRegistro.ToList : cmbTipoRegistro.ValueMember = "Key" : cmbTipoRegistro.DisplayMember = "Name" : cmbTipoRegistro.SelectedIndex = -1
        Me.LoadForm = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Llenar()
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        cmbTipoDocumento.SelectedIndex = -1
        cmbTipoRegistro.SelectedIndex = -1
        txtTitulo.Clear()
        txtSignatura.Clear()
        txtAutor.Clear()
        txtInstitucion.Clear()
        txtIsbn.Clear()
        txtOtroCodigo.Clear()
        dtRegistro.DataSource = Nothing
        dtDetalle.DataSource = Nothing
    End Sub

    Private Sub btReporte_Click(sender As Object, e As EventArgs) Handles btReporte.Click

    End Sub

    Private Sub dtRegistro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtRegistro.CellDoubleClick
        If Me.RLibro Then
            Try
                If dtRegistro.SelectedRows.Count > 0 Then
                    Using libro As New LibroServicio.LibroServicioClient
                        Dim l = libro.BuscarId(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString()))
                        If Not l Is Nothing Then
                            Select Case Me.Frm
                                Case 0
                                    With frmLibro
                                        .Limpiar()
                                        .IdLibro = l.ID_LIBRO
                                        .cmbTipoDocumento.Text = l.TIPODEDOCUMENTO
                                        .cmbTipoRegistro.Text = l.TIPOREGISTRO
                                        .txtSignatura.Text = l.SIGNATURA
                                        .txtTitulo.Text = l.TITULO
                                        .txtOtroTitulo.Text = l.OTRO_TITULO
                                        If l.TIPOREGISTRO = "PE" Then
                                            .txtAutor1.Text = l.AUTOR1 : .txtAutor1.Enabled = True
                                            .txtAutor2.Text = l.AUTOR2 : .txtAutor2.Enabled = True
                                            .txtAutor3.Text = l.AUTOR3 : .txtAutor3.Enabled = True
                                        ElseIf l.TIPOREGISTRO = "IN" Then
                                            .cmbAutorInstitucional.Text = l.INSTITUCION : .cmbAutorInstitucional.Enabled = True
                                        End If
                                        .cmbIdioma.Text = l.IDIOMA
                                        .txtColacion.Text = l.COLACION
                                        .txtIsbn.Text = l.ISBN
                                        .txtOtroCodigo.Text = l.OTRO_CODIGO
                                        .txtNotas.Text = l.NOTAS
                                        .txtResumen.Text = l.RESUMEN
                                        .txtIdCiudad.Text = l.ID_CIUDAD.ToString()
                                        .txtCiudad.Text = l.CIUDAD
                                        .cmbEditor.Text = l.EDITORA
                                        .txtFechaPublicacion.Text = l.FECHAPUBLICACION
                                        .txtEdicion.Text = l.EDICION
                                        If l.TIPODEDOCUMENTO = "Monog" Then
                                            .cmbTipoInvestigacion.Text = l.TIPOINVESTIGACION : .cmbTipoInvestigacion.Enabled = True
                                            .cmbGrado.Text = l.GRADO : .cmbGrado.Enabled = True
                                            .txtIdTutor.Text = l.ID_TUTOR.ToString
                                            .txtTutor.Text = l.TUTOR : .btBuscarTutor.Enabled = True
                                        End If
                                        Try
                                            .dtEncabezados.DataSource = (From enc In libro.BuscarEncabezadoPorLibro(l.ID_LIBRO) Select enc.IdEncabezado, enc.Descripcion).ToList()
                                            If .dtEncabezados.Columns.Count > 0 Then
                                                .dtEncabezados.Columns(0).Visible = False
                                                .dtEncabezados.Columns(1).Width = 300
                                                .dtEncabezados.Columns(1).HeaderText = "Encabezado / Epígrafe"
                                            End If
                                        Catch ex As Exception
                                            MessageBox.Show("No se puede cargar Encabezados. " & ex.Message)
                                        End Try
                                        Try
                                            .dtCopias.DataSource = (From inv In libro.BuscarCopiaPorLibro(l.ID_LIBRO) Select inv.IdInventario, inv.Registro).ToList()
                                            If .dtCopias.Columns.Count > 0 Then
                                                .dtCopias.Columns(0).Visible = False
                                                .dtCopias.Columns(1).Width = 300
                                                .dtCopias.Columns(1).HeaderText = "Registros de Copia"
                                            End If
                                        Catch ex As Exception
                                            MessageBox.Show("No se puede cargar Copias de Inventario. " & ex.Message)
                                        End Try
                                        Try
                                            Dim b = libro.BuscarImagen(l.ImagenPerfilUrl)
                                            If Not b Is Nothing Then
                                                Using ms As New MemoryStream(b)
                                                    .Imagen = Image.FromStream(ms)
                                                    .picImagenLibro.Image = .Imagen
                                                End Using
                                            End If
                                        Catch ex As Exception
                                            MessageBox.Show("No se puede cargar Imagen. " & ex.Message)
                                        End Try
                                        .txtNorma.Text = l.Norma
                                        .txtEstilo.Text = l.Estilo
                                        .txtCita.Text = l.Cita
                                        .btGuardar.Enabled = False
                                        .btEditar.Enabled = True
                                        .btEliminar.Enabled = True
                                    End With
                                    frmLibro.MdiParent = frmPrincipal
                                    frmLibro.BringToFront()
                                    frmLibro.Show()
                                Case 1
                                    
                                Case 2

                                Case 3

                            End Select
                            Me.Close()
                        Else
                            MessageBox.Show("No se encuentra esta Bibliografía.")
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Buscar_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipoDocumento.KeyDown, txtTitulo.KeyDown, txtSignatura.KeyDown, txtOtroCodigo.KeyDown, txtIsbn.KeyDown, txtInstitucion.KeyDown, txtAutor.KeyDown, cmbTipoRegistro.KeyDown
        If e.KeyData = Keys.Enter Then
            Llenar()
        End If
    End Sub

    Private Sub frmBuscarLibro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Keys.F1
                btBuscar_Click(Nothing, Nothing)
            Case Keys.F2
                btBorrar_Click(Nothing, Nothing)
            Case Keys.F3
                btReporte_Click(Nothing, Nothing)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub


    Private Sub dtRegistro_SelectionChanged(sender As Object, e As EventArgs) Handles dtRegistro.SelectionChanged
        Try
            If dtRegistro.SelectedRows.Count > 0 Then
                LlenarCopias(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString))
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dtDetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalle.CellDoubleClick
        Try
            If dtDetalle.SelectedRows.Count > 0 Then
                If Me.RInventario Then
                    Using Inventario As New InventarioServicio.InventarioServicioClient
                        Dim inv = Inventario.BuscarPorId(Guid.Parse(dtDetalle.SelectedRows(0).Cells(0).Value.ToString()))
                        If Not inv Is Nothing Then
                            Select Case Me.Frm
                                Case 1
                                    frmPrestamo.txtLibro.Text = inv.Registro
                                Case 2

                                Case 3

                            End Select
                            Me.Close()
                        Else
                            MessageBox.Show("No se encontró esta copia de libro.")
                        End If
                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmBuscarLibro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.RLibro = False
        Me.RInventario = False
    End Sub
End Class