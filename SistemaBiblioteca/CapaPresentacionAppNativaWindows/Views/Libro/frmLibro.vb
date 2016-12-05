Public Class frmLibro
    Public Imagen As Image
    Public ImagenBand As Boolean = False
    Public IdLibro As Guid = Guid.Empty
    Dim FormLoad As Boolean = False
    Public Encabezados As New List(Of Display)
    Public Copias As New List(Of Display)
    Sub Limpiar()
        Me.IdLibro = Guid.Empty
        Me.ImagenBand = False : btBorrarImagen.Enabled = False
        cmbTipoDocumento.DataSource = VarGlobales.TipoDocumento.ToList : cmbTipoDocumento.ValueMember = "Key" : cmbTipoDocumento.DisplayMember = "Name" : cmbTipoDocumento.SelectedIndex = -1
        cmbTipoRegistro.DataSource = VarGlobales.TipoRegistro.ToList : cmbTipoRegistro.ValueMember = "Key" : cmbTipoRegistro.DisplayMember = "Name" : cmbTipoRegistro.SelectedIndex = -1
        cmbTipoInvestigacion.DataSource = VarGlobales.TipoInvestigacion.ToList : cmbTipoInvestigacion.ValueMember = "Key" : cmbTipoInvestigacion.DisplayMember = "Name" : cmbTipoInvestigacion.SelectedIndex = -1
        txtTitulo.Clear()
        txtOtroTitulo.Clear()
        txtAutor1.Clear()
        txtAutor2.Clear()
        txtAutor3.Clear()
        : cmbAutorInstitucional.SelectedIndex = -1 : btActualizarInstitucion.Enabled = False
        cmbIdioma.SelectedIndex = -1
        txtColacion.Clear()
        txtIsbn.Clear()
        txtSignatura.Clear()
        txtOtroCodigo.Clear()
        txtNotas.Clear()
        txtResumen.Clear()
        txtIdCiudad.Clear()
        txtCiudad.Clear()
        cmbEditor.SelectedIndex = -1
        txtFechaPublicacion.Clear()
        txtEdicion.Clear()
        cmbTipoInvestigacion.SelectedIndex = -1
        : cmbGrado.SelectedIndex = -1 : btActualizarGrado.Enabled = False
        txtIdTutor.Clear()
        txtTutor.Clear()
        dtEncabezados.DataSource = Nothing
        cmbEncabezado.SelectedIndex = -1
        dtCopias.DataSource = Nothing
        txtImagen.Clear()
        picImagenLibro.Image = Nothing
        txtNorma.Clear()
        txtEstilo.Clear()
        txtCita.Clear()
        TabControl1.SelectedTabIndex = 0
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        Try
            Using institucion As New InstitucionServicio.InstitucionServicioClient
                cmbAutorInstitucional.DataSource = institucion.Lista() : cmbAutorInstitucional.ValueMember = "IdInstitucion" : cmbAutorInstitucional.DisplayMember = "Descripcion"
            End Using
            Using idioma As New IdiomaServicio.IdiomaServicioClient
                cmbIdioma.DataSource = idioma.Lista() : cmbIdioma.ValueMember = "IdIdioma" : cmbIdioma.DisplayMember = "Descripcion"
            End Using
            Using editor As New EditorServicio.EditorServicioClient
                cmbEditor.DataSource = editor.Lista() : cmbEditor.ValueMember = "IdEditor" : cmbEditor.DisplayMember = "Descripcion"
            End Using
            Using grado As New GradoServicio.GradoServicioClient
                cmbGrado.DataSource = grado.Lista() : cmbGrado.ValueMember = "IdGrado" : cmbGrado.DisplayMember = "Descripcion"
            End Using
            Using encabezado As New EncabezadoServicio.EncabezadoServicioClient
                cmbEncabezado.DataSource = encabezado.Lista() : cmbEncabezado.ValueMember = "IdEncabezado" : cmbEncabezado.DisplayMember = "Descripcion"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        cmbTipoDocumento.Focus()
    End Sub
    Public Sub cargarImagen(ByVal fileName As String, Optional ByVal tipo As Integer = 0)
        Try
            txtImagen.Text = fileName 'If(tipo.Equals(0), fileName, Me.pathProductos & fileName)
            Dim fs As New System.IO.FileStream(txtImagen.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Me.Imagen = Image.FromStream(fs)
            picImagenLibro.Image = Me.Imagen

            fs.Close()
            fs.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la Imagen. Descripción: " & ex.Message)
        End Try
    End Sub

    Private Sub frmLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTipoDocumento.DataSource = VarGlobales.TipoDocumento.ToList : cmbTipoDocumento.ValueMember = "Key" : cmbTipoDocumento.DisplayMember = "Name" : cmbTipoDocumento.SelectedIndex = -1
            cmbTipoRegistro.DataSource = VarGlobales.TipoRegistro.ToList : cmbTipoRegistro.ValueMember = "Key" : cmbTipoRegistro.DisplayMember = "Name" : cmbTipoRegistro.SelectedIndex = -1
            cmbTipoInvestigacion.DataSource = VarGlobales.TipoInvestigacion.ToList : cmbTipoInvestigacion.ValueMember = "Key" : cmbTipoInvestigacion.DisplayMember = "Name" : cmbTipoInvestigacion.SelectedIndex = -1
            Using institucion As New InstitucionServicio.InstitucionServicioClient
                cmbAutorInstitucional.DataSource = institucion.Lista() : cmbAutorInstitucional.ValueMember = "IdInstitucion" : cmbAutorInstitucional.DisplayMember = "Descripcion" : cmbAutorInstitucional.SelectedIndex = -1
            End Using
            Using idioma As New IdiomaServicio.IdiomaServicioClient
                cmbIdioma.DataSource = idioma.Lista() : cmbIdioma.ValueMember = "IdIdioma" : cmbIdioma.DisplayMember = "Descripcion" : cmbIdioma.SelectedIndex = -1
            End Using
            Using editor As New EditorServicio.EditorServicioClient
                cmbEditor.DataSource = editor.Lista() : cmbEditor.ValueMember = "IdEditor" : cmbEditor.DisplayMember = "Descripcion" : cmbEditor.SelectedIndex = -1
            End Using
            Using grado As New GradoServicio.GradoServicioClient
                cmbGrado.DataSource = grado.Lista() : cmbGrado.ValueMember = "IdGrado" : cmbGrado.DisplayMember = "Descripcion" : cmbGrado.SelectedIndex = -1
            End Using
            Using encabezado As New EncabezadoServicio.EncabezadoServicioClient
                cmbEncabezado.DataSource = encabezado.Lista() : cmbEncabezado.ValueMember = "IdEncabezado" : cmbEncabezado.DisplayMember = "Descripcion" : cmbEncabezado.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Me.FormLoad = True
    End Sub

    Private Sub cmbTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipoDocumento.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbTipoDocumento.SelectedValue Is Nothing Then
                cmbTipoRegistro.Focus()
            Else
                MessageBox.Show("Ingresar el atributo 'Tipo de Documento'")
            End If
        End If
    End Sub

    Private Sub cmbTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoDocumento.SelectedIndexChanged
        If Me.FormLoad Then
            If Not cmbTipoDocumento.SelectedValue Is Nothing And cmbTipoDocumento.SelectedIndex <> -1 Then
                If cmbTipoDocumento.SelectedValue.ToString = "Monog" Then
                    cmbTipoInvestigacion.Enabled = True
                    cmbGrado.Enabled = True : btActualizarGrado.Enabled = True
                    txtTutor.Enabled = True : btBuscarTutor.Enabled = True
                Else
                    cmbTipoInvestigacion.Enabled = False : cmbTipoInvestigacion.SelectedIndex = -1
                    cmbGrado.Enabled = False : btActualizarGrado.Enabled = False
                    txtTutor.Enabled = False : btBuscarTutor.Enabled = False
                    txtIdTutor.Clear()
                End If
            Else
                cmbTipoInvestigacion.Enabled = False
                cmbGrado.Enabled = False
                btBuscarTutor.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbTipoRegistro_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipoRegistro.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbTipoRegistro.SelectedValue Is Nothing Then
                txtSignatura.Focus()
            Else
                MessageBox.Show("Ingresar el atributo 'Tipo de Registro'")
            End If
        End If
    End Sub

    Private Sub cmbTipoRegistro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoRegistro.SelectedIndexChanged
        If Me.FormLoad Then
            If Not cmbTipoRegistro.SelectedValue Is Nothing And cmbTipoRegistro.SelectedIndex <> -1 Then
                Select Case cmbTipoRegistro.SelectedValue.ToString
                    Case "TI"
                        txtAutor1.Enabled = False : txtAutor1.Clear()
                        txtAutor2.Enabled = False : txtAutor2.Clear()
                        txtAutor3.Enabled = False : txtAutor3.Clear()
                        cmbAutorInstitucional.Enabled = False : cmbAutorInstitucional.SelectedIndex = -1 : btActualizarInstitucion.Enabled = False
                    Case "PE"
                        txtAutor1.Enabled = True
                        txtAutor2.Enabled = True
                        txtAutor3.Enabled = True
                        cmbAutorInstitucional.Enabled = False : cmbAutorInstitucional.SelectedIndex = -1 : btActualizarInstitucion.Enabled = False
                    Case "IN"
                        txtAutor1.Enabled = False : txtAutor1.Clear()
                        txtAutor2.Enabled = False : txtAutor2.Clear()
                        txtAutor3.Enabled = False : txtAutor3.Clear()
                        cmbAutorInstitucional.Enabled = True : btActualizarInstitucion.Enabled = True
                    Case Else
                        txtAutor1.Enabled = False : txtAutor1.Clear()
                        txtAutor2.Enabled = False : txtAutor2.Clear()
                        txtAutor3.Enabled = False : txtAutor3.Clear()
                        cmbAutorInstitucional.Enabled = False : cmbAutorInstitucional.SelectedIndex = -1 : btActualizarInstitucion.Enabled = False
                End Select
            End If
        End If
    End Sub

    Private Sub txtTitulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTitulo.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtTitulo.Text.Trim <> "" Then
                txtOtroTitulo.Focus()
            Else
                MessageBox.Show("Ingresar el atributo 'Título'")
            End If
        End If
    End Sub

    Private Sub txtOtroTitulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtroTitulo.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtAutor1.Enabled Then
                txtAutor1.Focus()
            ElseIf cmbAutorInstitucional.Enabled Then
                cmbAutorInstitucional.Focus()
            Else
                cmbIdioma.Focus()
            End If
        End If
    End Sub



    Private Sub cmbIdioma_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbIdioma.KeyDown
        If e.KeyData = Keys.Enter Then
            If cmbIdioma.SelectedValue Is Nothing Then
                If cmbIdioma.Text.Trim <> "" Then
                    Try
                        Dim temp = cmbIdioma.Text.Trim
                        Using idioma As New IdiomaServicio.IdiomaServicioClient
                            If idioma.Existe(cmbIdioma.Text.Trim) Then
                                cmbIdioma.DataSource = idioma.Lista() : cmbIdioma.ValueMember = "IdIdioma" : cmbIdioma.DisplayMember = "Descripcion"
                            Else
                                If MessageBox.Show("No se encuentra este Idioma ¿Desea crearlo?", "Pregunta de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    idioma.Guardar(New IdiomaServicio.DIdioma With {.Descripcion = cmbIdioma.Text})
                                    cmbIdioma.DataSource = idioma.Lista() : cmbIdioma.ValueMember = "IdIdioma" : cmbIdioma.DisplayMember = "Descripcion"
                                End If
                            End If
                        End Using
                        cmbIdioma.Text = temp : temp = Nothing
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End If
            End If
            txtColacion.Focus()
            'If Not cmbIdioma.SelectedValue Is Nothing Then
            '    txtColacion.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Idioma'")
            'End If
        End If
    End Sub

    Private Sub txtColacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtColacion.KeyDown
        If e.KeyData = Keys.Enter Then
            txtIsbn.Focus()
        End If
    End Sub

    Private Sub txtIsbn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIsbn.KeyDown
        If e.KeyData = Keys.Enter Then
            txtOtroCodigo.Focus()
        End If
    End Sub

    Private Sub txtSignatura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSignatura.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtSignatura.Text.Trim <> "" Then
                txtTitulo.Focus()
            Else
                MessageBox.Show("Ingresar el atributo 'Signatura Topográfica'")
            End If
        End If
    End Sub

    Private Sub txtOtroCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtroCodigo.KeyDown
        If e.KeyData = Keys.Enter Then
            txtNotas.Focus()
        End If
    End Sub

    Private Sub txtNotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotas.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNotas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotas.KeyDown
        If e.KeyData = Keys.Enter Then
            txtResumen.Focus()
        End If
    End Sub

    Private Sub txtResumen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResumen.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtResumen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResumen.KeyDown
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedTabIndex = 1
            txtCiudad.Focus()
        End If
    End Sub

    Private Sub txtCiudad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCiudad.KeyDown
        If e.KeyData = Keys.Enter Then
            cmbEditor.Focus()
        End If
    End Sub

    Private Sub cmbEditor_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbEditor.KeyDown
        If e.KeyData = Keys.Enter Then
            If cmbEditor.SelectedValue Is Nothing Then
                If cmbEditor.Text.Trim <> "" Then
                    Try
                        Dim temp = cmbEditor.Text.Trim
                        Using editor As New EditorServicio.EditorServicioClient
                            If editor.Existe(cmbEditor.Text.Trim) Then
                                cmbEditor.DataSource = editor.Lista() : cmbEditor.ValueMember = "IdEditor" : cmbEditor.DisplayMember = "Descripcion"
                            Else
                                If MessageBox.Show("No se encuentra este Editor ¿Desea crearlo?", "Pregunta de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    editor.Guardar(New EditorServicio.DEditor With {.Descripcion = cmbEditor.Text})
                                    cmbEditor.DataSource = editor.Lista() : cmbEditor.ValueMember = "IdEditor" : cmbEditor.DisplayMember = "Descripcion"
                                End If
                            End If
                        End Using
                        cmbIdioma.Text = temp : temp = Nothing
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End If
            End If
            txtFechaPublicacion.Focus()
            'If Not cmbEditor.SelectedValue Is Nothing Then
            '    txtFechaPublicacion.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Editor'")
            'End If
        End If
    End Sub

    Private Sub txtFechaPublicacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaPublicacion.KeyDown
        If e.KeyData = Keys.Enter Then
            txtEdicion.Focus()
        End If
    End Sub

    Private Sub txtEdicion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEdicion.KeyDown
        If e.KeyData = Keys.Enter Then
            If cmbTipoInvestigacion.Enabled Then
                cmbTipoInvestigacion.Focus()
            Else
                cmbEncabezado.Focus()
            End If
        End If
    End Sub

    Private Sub cmbTipoInvestigacion_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipoInvestigacion.KeyDown
        If e.KeyData = Keys.Enter Then
            cmbGrado.Focus()
            'If Not cmbTipoInvestigacion.SelectedValue Is Nothing Then
            '    cmbGradoAcademico.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Tipo de Investigación'")
            'End If
        End If
    End Sub

    Private Sub cmbGradoAcademico_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbGrado.KeyDown
        If e.KeyData = Keys.Enter Then
            If cmbGrado.SelectedValue Is Nothing Then
                If cmbGrado.Text.Trim <> "" Then
                    Try
                        Dim temp = cmbGrado.Text.Trim
                        Using grado As New GradoServicio.GradoServicioClient
                            If grado.Existe(cmbIdioma.Text.Trim) Then
                                cmbGrado.DataSource = grado.Lista() : cmbGrado.ValueMember = "IdGrado" : cmbGrado.DisplayMember = "Descripcion"
                            Else
                                If MessageBox.Show("No se encuentra este Grado ¿Desea crearlo?", "Pregunta de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    grado.Guardar(New GradoServicio.DGrado With {.Descripcion = cmbGrado.Text})
                                    cmbGrado.DataSource = grado.Lista() : cmbGrado.ValueMember = "IdGrado" : cmbGrado.DisplayMember = "Descripcion"
                                End If
                            End If
                        End Using
                        cmbGrado.Text = temp : temp = Nothing
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End If
            End If
            txtTutor.Focus()
            'If Not cmbGradoAcademico.SelectedValue Is Nothing Then
            '    txtTutor.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Grado Académico'")
            'End If
        End If
    End Sub

    Private Sub txtTutor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTutor.KeyDown
        If e.KeyData = Keys.Enter Then
            cmbEncabezado.Focus()
            'If txtIdTutor.Text.Trim <> "" Then
            '    cmbEncabezado.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Tutor'")
            'End If
        End If
    End Sub

    Private Sub cmbEncabezado_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbEncabezado.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbEncabezado.SelectedValue Is Nothing Then
                If Me.Encabezados.Where(Function(f) f.Key = cmbEncabezado.SelectedValue.ToString()).FirstOrDefault Is Nothing Then
                    Me.Encabezados.Add(New Display With {.Key = cmbEncabezado.SelectedValue.ToString, .Name = cmbEncabezado.Text})
                    dtEncabezados.DataSource = Me.Encabezados.ToList
                End If
                If dtEncabezados.Columns.Count > 0 Then
                    dtEncabezados.Columns(0).Visible = False
                    dtEncabezados.Columns(1).Width = 300
                    dtEncabezados.Columns(1).HeaderText = "Encabezado / Epígrafe"
                End If
                cmbEncabezado.SelectedIndex = -1
            Else
                If cmbEncabezado.Text.Trim <> "" Then
                    Try
                        Dim temp = cmbEncabezado.Text.Trim
                        Using encabezado As New EncabezadoServicio.EncabezadoServicioClient
                            If encabezado.Existe(cmbEncabezado.Text.Trim) Then
                                cmbEncabezado.DataSource = encabezado.Lista() : cmbEncabezado.ValueMember = "IdEncabezado" : cmbEncabezado.DisplayMember = "Descripcion"
                            Else
                                If MessageBox.Show("No se encuentra este Encabezado ¿Desea crearlo?", "Pregunta de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    encabezado.Guardar(New EncabezadoServicio.DEncabezado With {.Descripcion = cmbEncabezado.Text})
                                    cmbEncabezado.DataSource = encabezado.Lista() : cmbEncabezado.ValueMember = "IdEncabezado" : cmbEncabezado.DisplayMember = "Descripcion"
                                End If
                            End If
                        End Using
                        cmbEncabezado.Text = temp : temp = Nothing
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                Else
                    If chkInventarioInicial.Checked Then
                        txtNRegistro.Focus()
                    Else
                        chkInventarioInicial.Focus()
                    End If
                    txtNRegistro.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtAutor1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAutor1.KeyDown
        If e.KeyData = Keys.Enter Then
            txtAutor2.Focus()
            'If txtAutor1.Text.Trim <> "" Then
            '    txtAutor2.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Primer Autor'")
            'End If
        End If
    End Sub

    Private Sub txtAutor2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAutor2.KeyDown
        If e.KeyData = Keys.Enter Then
            txtAutor3.Focus()
        End If
    End Sub

    Private Sub txtAutor3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAutor3.KeyDown
        If e.KeyData = Keys.Enter Then
            cmbIdioma.Focus()
        End If
    End Sub

    Private Sub cmbAutorInstitucional_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbAutorInstitucional.KeyDown
        If e.KeyData = Keys.Enter Then
            If cmbAutorInstitucional.SelectedValue Is Nothing Then
                If cmbAutorInstitucional.Text.Trim <> "" Then
                    Try
                        Dim temp = cmbAutorInstitucional.Text.Trim
                        Using institucion As New InstitucionServicio.InstitucionServicioClient
                            If institucion.Existe(cmbAutorInstitucional.Text.Trim) Then
                                cmbAutorInstitucional.DataSource = institucion.Lista() : cmbAutorInstitucional.ValueMember = "IdInstitucion" : cmbAutorInstitucional.DisplayMember = "Descripcion"
                            Else
                                If MessageBox.Show("No se encuentra esta Institución ¿Desea crearlo?", "Pregunta de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    institucion.Guardar(New InstitucionServicio.DInstitucion With {.Descripcion = cmbAutorInstitucional.Text})
                                    cmbAutorInstitucional.DataSource = institucion.Lista() : cmbAutorInstitucional.ValueMember = "IdInstitucion" : cmbAutorInstitucional.DisplayMember = "Descripcion"
                                End If
                            End If
                        End Using
                        cmbAutorInstitucional.Text = temp : temp = Nothing
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End If
            End If
            cmbIdioma.Focus()
            'If Not cmbAutorInstitucional.SelectedValue Is Nothing Then
            '    cmbIdioma.Focus()
            'Else
            '    MessageBox.Show("Ingresar el atributo 'Autor Institucional'")
            'End If
        End If
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            If cmbTipoDocumento.SelectedValue Is Nothing Then
                MessageBox.Show("Ingresar el atributo 'Tipo de Documento'")
                Exit Sub
            End If
            If cmbTipoRegistro.SelectedValue Is Nothing Then
                MessageBox.Show("Ingresar el atributo 'Tipo de Registro'")
                Exit Sub
            End If
            If txtTitulo.Text.Trim = "" Then
                MessageBox.Show("Ingresar el atributo 'Título'")
                Exit Sub
            End If
            Using db As New LibroServicio.LibroServicioClient
                Dim encabezados As New List(Of LibroServicio.DDetalle_Encabezado)
                If dtEncabezados.Rows.Count > 0 Then
                    For Each item As DataGridViewRow In dtEncabezados.Rows
                        encabezados.Add(New LibroServicio.DDetalle_Encabezado With {.ID_ENCABEZADO = Guid.Parse(item.Cells(0).Value.ToString())})
                    Next
                End If
                Dim copias As New List(Of LibroServicio.DInventario)
                If chkInventarioInicial.Checked Then
                    If Me.Copias.Count > 0 Then
                        For Each item In Me.Copias
                            copias.Add(New LibroServicio.DInventario With {.Registro = item.Key})
                        Next
                    Else
                        MessageBox.Show("Ingresar el inventario inicial")
                        txtNRegistro.Focus()
                    End If
                End If
                Dim imgByte As Byte()
                If Me.ImagenBand Then
                    Dim Imagen = Image.FromFile(txtImagen.Text)
                    If Not Imagen Is Nothing Then
                        Dim imgConverter As New ImageConverter()
                        Try
                            imgByte = DirectCast(imgConverter.ConvertTo(Imagen, GetType(Byte())), Byte())
                        Catch ex As Exception
                            MessageBox.Show("Problemas con la carga de la Imagen. Descripción: " & ex.Message)
                        End Try
                        Imagen.Dispose()
                        imgConverter = Nothing
                    End If
                End If
                If db.Guardar(New LibroServicio.DLibro With {.TIPODEDOCUMENTO = cmbTipoDocumento.SelectedValue.ToString(), .TIPOREGISTRO = cmbTipoRegistro.SelectedValue.ToString(), .TITULO = txtTitulo.Text, .OTRO_TITULO = txtOtroTitulo.Text, .AUTOR1 = txtAutor1.Text, .AUTOR2 = txtAutor2.Text, .AUTOR3 = txtAutor3.Text, .ID_INSTITUCION = If(Not cmbAutorInstitucional.SelectedValue Is Nothing, Guid.Parse(cmbAutorInstitucional.SelectedValue.ToString()), Nothing), .ID_IDIOMA = If(Not cmbIdioma.SelectedValue Is Nothing, Guid.Parse(cmbIdioma.SelectedValue.ToString), Nothing), .COLACION = txtColacion.Text, .ISBN = txtIsbn.Text, .SIGNATURA = txtSignatura.Text, .OTRO_CODIGO = txtOtroCodigo.Text, .NOTAS = txtNotas.Text, .RESUMEN = txtResumen.Text, .ID_CIUDAD = If(txtIdCiudad.Text.Trim <> "", Guid.Parse(txtIdCiudad.Text), Nothing), .ID_EDITORA = If(Not cmbEditor.SelectedValue Is Nothing, Guid.Parse(cmbEditor.SelectedValue.ToString()), Nothing), .FECHAPUBLICACION = txtFechaPublicacion.Text, .EDICION = txtEdicion.Text, .TIPOINVESTIGACION = If(Not cmbTipoInvestigacion.SelectedValue Is Nothing, cmbTipoInvestigacion.SelectedValue.ToString, ""), .ID_GRADO = If(Not cmbGrado.SelectedValue Is Nothing, Guid.Parse(cmbGrado.SelectedValue.ToString), Nothing), .ID_TUTOR = If(txtIdTutor.Text.Trim <> "", Guid.Parse(txtIdTutor.Text), Nothing), .Norma = txtNorma.Text, .Estilo = txtEstilo.Text, .Cita = txtCita.Text, .IdUsuario = VarGlobales.Sesion.IdUsuario}, encabezados, copias, imgByte) Then
                    MessageBox.Show("Guardado!!")
                    Limpiar()
                End If
                encabezados = Nothing : copias = Nothing : imgByte = Nothing
            End Using
            Limpiar()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Try
            If cmbTipoDocumento.SelectedValue Is Nothing Then
                MessageBox.Show("Ingresar el atributo 'Tipo de Documento'")
                Exit Sub
            End If
            If cmbTipoRegistro.SelectedValue Is Nothing Then
                MessageBox.Show("Ingresar el atributo 'Tipo de Registro'")
                Exit Sub
            End If
            If txtTitulo.Text.Trim = "" Then
                MessageBox.Show("Ingresar el atributo 'Título'")
                Exit Sub
            End If
            Using db As New LibroServicio.LibroServicioClient
                Dim encabezados As New List(Of LibroServicio.DDetalle_Encabezado)
                If dtEncabezados.Rows.Count > 0 Then
                    For Each item As DataGridViewRow In dtEncabezados.Rows
                        encabezados.Add(New LibroServicio.DDetalle_Encabezado With {.ID_ENCABEZADO = Guid.Parse(item.Cells(0).Value.ToString())})
                    Next
                End If
                Dim copias As New List(Of LibroServicio.DInventario)
                If chkInventarioInicial.Checked Then
                    If Me.Copias.Count > 0 Then
                        For Each item In Me.Copias
                            copias.Add(New LibroServicio.DInventario With {.Registro = item.Key})
                        Next
                    Else
                        MessageBox.Show("Ingresar el inventario inicial")
                        txtNRegistro.Focus()
                    End If
                End If
                Dim imgByte As Byte()
                If Me.ImagenBand Then
                    Dim Imagen = Image.FromFile(txtImagen.Text)
                    If Not Imagen Is Nothing Then
                        Dim imgConverter As New ImageConverter()
                        Try
                            imgByte = DirectCast(imgConverter.ConvertTo(Imagen, GetType(Byte())), Byte())
                        Catch ex As Exception
                            MessageBox.Show("Problemas con la carga de la Imagen. Descripción: " & ex.Message)
                        End Try
                        Imagen.Dispose()
                        imgConverter = Nothing
                    End If
                End If
                If db.Editar(New LibroServicio.DLibro With {.ID_LIBRO = Me.IdLibro, .TIPODEDOCUMENTO = cmbTipoDocumento.SelectedValue.ToString(), .TIPOREGISTRO = cmbTipoRegistro.SelectedValue.ToString(), .TITULO = txtTitulo.Text, .OTRO_TITULO = txtOtroTitulo.Text, .AUTOR1 = txtAutor1.Text, .AUTOR2 = txtAutor2.Text, .AUTOR3 = txtAutor3.Text, .ID_INSTITUCION = If(Not cmbAutorInstitucional.SelectedValue Is Nothing, Guid.Parse(cmbAutorInstitucional.SelectedValue.ToString()), Nothing), .ID_IDIOMA = If(Not cmbIdioma.SelectedValue Is Nothing, Guid.Parse(cmbIdioma.SelectedValue.ToString), Nothing), .COLACION = txtColacion.Text, .ISBN = txtIsbn.Text, .SIGNATURA = txtSignatura.Text, .OTRO_CODIGO = txtOtroCodigo.Text, .NOTAS = txtNotas.Text, .RESUMEN = txtResumen.Text, .ID_CIUDAD = If(txtIdCiudad.Text.Trim <> "", Guid.Parse(txtIdCiudad.Text), Nothing), .ID_EDITORA = If(Not cmbEditor.SelectedValue Is Nothing, Guid.Parse(cmbEditor.SelectedValue.ToString()), Nothing), .FECHAPUBLICACION = txtFechaPublicacion.Text, .EDICION = txtEdicion.Text, .TIPOINVESTIGACION = If(Not cmbTipoInvestigacion.SelectedValue Is Nothing, cmbTipoInvestigacion.SelectedValue.ToString, ""), .ID_GRADO = If(Not cmbGrado.SelectedValue Is Nothing, Guid.Parse(cmbGrado.SelectedValue.ToString), Nothing), .ID_TUTOR = If(txtIdTutor.Text.Trim <> "", Guid.Parse(txtIdTutor.Text), Nothing), .Norma = txtNorma.Text, .Estilo = txtEstilo.Text, .Cita = txtCita.Text, .IdUsuario = VarGlobales.Sesion.IdUsuario}, encabezados, copias, imgByte) Then
                    MessageBox.Show("Editado!!")
                    Limpiar()
                End If
                encabezados = Nothing : copias = Nothing : imgByte = Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        frmBuscarLibro.RLibro = True
        frmBuscarLibro.ShowDialog()
    End Sub


    Private Sub btActualizarIdioma_Click(sender As Object, e As EventArgs) Handles btActualizarIdioma.Click
        Try
            If cmbIdioma.Text.Trim <> "" Then
                Dim temp = cmbIdioma.Text.Trim
                Using idioma As New IdiomaServicio.IdiomaServicioClient
                    cmbIdioma.DataSource = idioma.Lista() : cmbIdioma.ValueMember = "IdIdioma" : cmbIdioma.DisplayMember = "Descripcion"
                End Using
                cmbIdioma.Text = temp
                temp = Nothing
            Else
                Using idioma As New IdiomaServicio.IdiomaServicioClient
                    cmbIdioma.DataSource = idioma.Lista() : cmbIdioma.ValueMember = "IdIdioma" : cmbIdioma.DisplayMember = "Descripcion"
                End Using
            End If
            cmbIdioma.Focus()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btActualizarEditor_Click(sender As Object, e As EventArgs) Handles btActualizarEditor.Click
        Try
            If cmbEditor.Text.Trim <> "" Then
                Dim temp = cmbEditor.Text.Trim
                Using editor As New EditorServicio.EditorServicioClient
                    cmbEditor.DataSource = editor.Lista() : cmbEditor.ValueMember = "IdEditor" : cmbEditor.DisplayMember = "Descripcion"
                End Using
                cmbEditor.Text = temp
                temp = Nothing
            Else
                Using editor As New EditorServicio.EditorServicioClient
                    cmbEditor.DataSource = editor.Lista() : cmbEditor.ValueMember = "IdEditor" : cmbEditor.DisplayMember = "Descripcion"
                End Using
            End If
            cmbEditor.Focus()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btActualizarGrado_Click(sender As Object, e As EventArgs) Handles btActualizarGrado.Click
        Try
            If cmbGrado.Text.Trim <> "" Then
                Dim temp = cmbGrado.Text.Trim
                Using grado As New GradoServicio.GradoServicioClient
                    cmbGrado.DataSource = grado.Lista() : cmbGrado.ValueMember = "IdGrado" : cmbGrado.DisplayMember = "Descripcion"
                End Using
                cmbGrado.Text = temp
                temp = Nothing
            Else
                Using grado As New GradoServicio.GradoServicioClient
                    cmbGrado.DataSource = grado.Lista() : cmbGrado.ValueMember = "IdGrado" : cmbGrado.DisplayMember = "Descripcion"
                End Using
            End If
            cmbGrado.Focus()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btActualizarEncabezado_Click(sender As Object, e As EventArgs) Handles btActualizarEncabezado.Click
        Try
            If cmbEncabezado.Text.Trim <> "" Then
                Dim temp = cmbEncabezado.Text.Trim
                Using encabezado As New EncabezadoServicio.EncabezadoServicioClient
                    cmbEncabezado.DataSource = encabezado.Lista() : cmbEncabezado.ValueMember = "IdEncabezado" : cmbEncabezado.DisplayMember = "Descripcion"
                End Using
                cmbEncabezado.Text = temp
                temp = Nothing
            Else
                Using encabezado As New EncabezadoServicio.EncabezadoServicioClient
                    cmbEncabezado.DataSource = encabezado.Lista() : cmbEncabezado.ValueMember = "IdEncabezado" : cmbEncabezado.DisplayMember = "Descripcion"
                End Using
            End If
            cmbEncabezado.Focus()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btActualizarInstitucion_Click(sender As Object, e As EventArgs) Handles btActualizarInstitucion.Click
        Try
            If cmbAutorInstitucional.Text.Trim <> "" Then
                Dim temp = cmbAutorInstitucional.Text.Trim
                Using institucion As New InstitucionServicio.InstitucionServicioClient
                    cmbAutorInstitucional.DataSource = institucion.Lista() : cmbAutorInstitucional.ValueMember = "IdInstitucion" : cmbAutorInstitucional.DisplayMember = "Descripcion"
                End Using
                cmbAutorInstitucional.Text = temp
                temp = Nothing
            Else
                Using institucion As New InstitucionServicio.InstitucionServicioClient
                    cmbAutorInstitucional.DataSource = institucion.Lista() : cmbAutorInstitucional.ValueMember = "IdInstitucion" : cmbAutorInstitucional.DisplayMember = "Descripcion"
                End Using
            End If
            cmbAutorInstitucional.Focus()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmLibro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub btBuscarCiudad_Click(sender As Object, e As EventArgs) Handles btBuscarCiudad.Click
        frmBuscarCiudad.Frm = 2
        frmBuscarCiudad.ShowDialog()
    End Sub

    Private Sub chkInventarioInicial_CheckedChanged(sender As Object, e As EventArgs) Handles chkInventarioInicial.CheckedChanged
        If chkInventarioInicial.Checked Then
            dtCopias.DataSource = Nothing
            txtNRegistro.Enabled = True
            btAgregarRegistro.Enabled = True
            txtNRegistro.Focus()
        Else
            txtNRegistro.Enabled = False
            txtNRegistro.Clear()
            btAgregarRegistro.Enabled = False
        End If
    End Sub

    Private Sub txtNRegistro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNRegistro.KeyDown
        If e.KeyData = Keys.Enter Then
            btAgregarRegistro_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub btExaminar_Click(sender As Object, e As EventArgs) Handles btExaminar.Click
        Try
            If opExaminar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.cargarImagen(fileName:=opExaminar.FileName)
                Me.ImagenBand = True : btBorrarImagen.Enabled = True
                txtNorma.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtImagen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtImagen.KeyDown
        If e.KeyData = Keys.Enter Then
            btExaminar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtNorma_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNorma.KeyDown
        If e.KeyData = Keys.Enter Then
            txtEstilo.Focus()
        End If
    End Sub

    Private Sub txtEstilo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEstilo.KeyDown
        If e.KeyData = Keys.Enter Then
            txtCita.Focus()
        End If
    End Sub

    Private Sub txtCita_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCita.KeyDown
        If e.KeyData = Keys.Enter Then
            If btGuardar.Enabled Then
                btGuardar_Click(Nothing, Nothing)
            ElseIf btEditar.Enabled Then
                btEditar_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btAgregarRegistro.Click
        If txtNRegistro.Text.Trim <> "" Then
            If Copias.Where(Function(f) f.Key = txtNRegistro.Text.Trim).FirstOrDefault() Is Nothing Then
                Copias.Add(New Display With {.Key = txtNRegistro.Text, .Name = txtNRegistro.Text})
                txtNRegistro.Clear()
                dtCopias.DataSource = Copias.ToList()
            End If
            If dtCopias.Columns.Count > 0 Then
                dtCopias.Columns(0).Visible = False
                dtCopias.Columns(1).Width = 300
                dtCopias.Columns(1).HeaderText = "Registros de Copia"
            End If
            txtNRegistro.Focus()
        Else
            TabControl1.SelectedTabIndex = 2
            txtImagen.Focus()
        End If
    End Sub

    Private Sub chkInventarioInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles chkInventarioInicial.KeyDown
        If e.KeyData = Keys.Enter Then
            If chkInventarioInicial.Checked Then
                txtNRegistro.Focus()
            Else
                TabControl1.SelectedTabIndex = 2
                txtImagen.Focus()
            End If
        ElseIf e.KeyData = Keys.Add Then
            chkInventarioInicial.Checked = True
        ElseIf e.KeyData = Keys.Subtract Then
            chkInventarioInicial.Checked = False
            TabControl1.SelectedTabIndex = 2
            txtImagen.Focus()
        End If
    End Sub

    Private Sub btBorrarImagen_Click(sender As Object, e As EventArgs) Handles btBorrarImagen.Click
        picImagenLibro.Image = Nothing
        txtImagen.Clear()
        Me.ImagenBand = False
    End Sub
End Class