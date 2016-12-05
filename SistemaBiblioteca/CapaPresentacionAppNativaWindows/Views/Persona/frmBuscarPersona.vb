Public Class frmBuscarPersona
    Dim LoadForm As Boolean = False
    Public Frm As Integer = 0

    Sub Llenar()
        Try
            Using Persona As New PersonaServicio.PersonaServicioClient
                dtRegistro.DataSource = (From per In Persona.Busqueda(New PersonaServicio.DPersona With {.NCarnet = txtNCarnet.Text.Trim, .Identificacion = txtIdentificacion.Text.Trim, .Nombres = txtNombres.Text.Trim, .Apellidos = txtApellidos.Text.Trim}) Select per.IdPersona, per.TipoPersona, per.TipoIdentificacion, per.Identificacion, per.Nombres, per.Apellidos, Sexo = If(per.Sexo, "Masculino", "Femenino"), per.FechaNacimiento, per.NCarnet, per.Turno, per.Area, per.DepartamentoAcademicoEstudiante, per.DepartamentoAcademicoDocente, per.Carrera, per.Departamento, per.Municipio, per.Telefono, per.Domicilio).ToList()
                If dtRegistro.Columns.Count > 0 Then
                    dtRegistro.Columns(0).Visible = False
                    dtRegistro.Columns(1).Width = 110 : dtRegistro.Columns(1).HeaderText = vbNewLine & "T. Persona" & vbNewLine
                    dtRegistro.Columns(2).Width = 80 : dtRegistro.Columns(2).HeaderText = "T. Id"
                    dtRegistro.Columns(3).Width = 250 : dtRegistro.Columns(3).HeaderText = "Identificación"
                    dtRegistro.Columns(4).Width = 150 : dtRegistro.Columns(4).HeaderText = "Nombres"
                    dtRegistro.Columns(5).Width = 150 : dtRegistro.Columns(5).HeaderText = "Apellidos"
                    dtRegistro.Columns(6).Width = 150 : dtRegistro.Columns(6).HeaderText = "Sexo"
                    dtRegistro.Columns(7).Width = 200 : dtRegistro.Columns(7).HeaderText = "F. Nacimiento"
                    dtRegistro.Columns(8).Width = 170 : dtRegistro.Columns(8).HeaderText = "Nº Carnet"
                    dtRegistro.Columns(9).Width = 170 : dtRegistro.Columns(9).HeaderText = "Turno"
                    dtRegistro.Columns(10).Width = 170 : dtRegistro.Columns(10).HeaderText = "Área Laboral"
                    dtRegistro.Columns(11).Width = 80 : dtRegistro.Columns(11).HeaderText = "Dpt. Estudiante"
                    dtRegistro.Columns(12).Width = 100 : dtRegistro.Columns(12).HeaderText = "Dpt. Docente"
                    dtRegistro.Columns(13).Width = 120 : dtRegistro.Columns(13).HeaderText = "Carrera"
                    dtRegistro.Columns(14).Width = 120 : dtRegistro.Columns(14).HeaderText = "Departamento"
                    dtRegistro.Columns(15).Width = 120 : dtRegistro.Columns(15).HeaderText = "Municipio"
                    dtRegistro.Columns(16).Width = 80 : dtRegistro.Columns(16).HeaderText = "Teléfono"
                    dtRegistro.Columns(17).Width = 120 : dtRegistro.Columns(17).HeaderText = "Domicilio"
                    For Each c As DataGridViewColumn In dtRegistro.Columns
                        c.HeaderCell.Style.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
                        c.HeaderText = c.HeaderText.ToUpper
                    Next
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmBuscarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Llenar()
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        txtNCarnet.Clear()
        txtIdentificacion.Clear()
        txtNombres.Clear()
        txtApellidos.Clear()
        dtRegistro.DataSource = Nothing
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNCarnet.KeyDown, txtNombres.KeyDown, txtIdentificacion.KeyDown, txtApellidos.KeyDown
        If e.KeyData = Keys.Enter Then
            Llenar()
        End If
    End Sub

    Private Sub dtRegistro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtRegistro.CellDoubleClick
        Try
            If dtRegistro.SelectedRows.Count > 0 Then
                Using Persona As New PersonaServicio.PersonaServicioClient
                    Dim per = Persona.BuscarPorId(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString()))
                    Select Case Me.Frm
                        Case 1
                            If per.Identificacion.Trim <> "" Then
                                frmPrestamo.txtPersona.Text = per.Identificacion
                            ElseIf per.NCarnet.Trim <> "" Then
                                frmPrestamo.txtPersona.Text = per.NCarnet
                            End If
                        Case 0
                            With frmPersona
                                .Limpiar()
                                .cmbTipoPersona.Text = per.TipoPersona
                                .txtNCarnet.Text = per.NCarnet
                                .cmbId.Text = per.TipoIdentificacion
                                .txtId.Text = per.Identificacion
                                .txtNombres.Text = per.Nombres
                                .txtApellidos.Text = per.Apellidos
                                .cmbTurno.Text = per.Turno
                                If per.Sexo Then
                                    .rdMasculino.Checked = True
                                Else
                                    .rdFemenino.Checked = True
                                End If
                                .dtpFechaNacimiento.Value = per.FechaNacimiento
                                .cmbCarrera.Text = per.Carrera
                                .cmbDepartamentoEstudiante.Text = per.DepartamentoAcademicoDocente
                                .cmbDepartamentoDocente.Text = per.DepartamentoAcademicoEstudiante
                                .txtDepartamento.Text = per.Departamento
                                .txtMunicipio.Text = per.Municipio
                                .txtArea.Text = per.Area
                                .txtObservacion.Text = per.Observacion
                                .btGuardar.Enabled = False
                                .btEditar.Enabled = True
                                .btEliminar.Enabled = True
                                frmPersona.MdiParent = frmPrincipal
                                frmPersona.BringToFront()
                                frmPersona.Show()
                            End With
                        Case 3

                    End Select
                    Me.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dtRegistro_KeyDown(sender As Object, e As KeyEventArgs) Handles dtRegistro.KeyDown
        If e.KeyData = Keys.Enter Then
            dtRegistro_CellDoubleClick(Nothing, Nothing)
        End If
    End Sub
End Class