Public Class frmPersona
    Dim LoadForm As Boolean = False
    Public eTipoPersona As Integer = 0
    Dim IdPersona As Guid
    Public Sub Limpiar()
        cmbTipoPersona.SelectedIndex = -1
        txtNCarnet.Clear() : txtNCarnet.Enabled = True
        cmbId.SelectedIndex = 0
        txtId.Clear()
        txtNombres.Clear()
        txtApellidos.Clear()
        cmbTurno.SelectedIndex = -1 : cmbTurno.Enabled = True
        cmbCarrera.SelectedIndex = -1 : cmbCarrera.Enabled = True
        cmbDepartamentoEstudiante.SelectedIndex = -1 : cmbDepartamentoEstudiante.Enabled = True
        cmbDepartamentoDocente.SelectedIndex = -1 : cmbDepartamentoDocente.Enabled = True
        txtDepartamento.Clear()
        txtMunicipio.Clear()
        txtArea.Clear() : txtArea.Enabled = True
        txtObservacion.Clear()
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        If txtNCarnet.Enabled Then
            txtNCarnet.Focus()
        Else
            txtId.Focus()
        End If
    End Sub

    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tipo As New List(Of String) : tipo.AddRange(New String() {"Estudiante", "Docente", "Egresado", "Público en General", "Administrativo", "Docente-Administrativo", "Docente-Estudiante", "Estudiante-Administrativo", "Estudiante-Administrativo-Docente"})
        cmbTipoPersona.DataSource = tipo : cmbTipoPersona.SelectedIndex = -1
        Dim id As New List(Of String) : id.AddRange(New String() {"Cédula", "Pasaporte"})
        cmbId.DataSource = id
        Dim turno As New List(Of String) : turno.AddRange(New String() {"Matutino", "Vespertino", "Nocturno", "Sabatino", "Dominical", "Diurno", "Por Encuentro"})
        cmbTurno.DataSource = turno : cmbTurno.SelectedIndex = -1
        Dim DepEst As New List(Of String) : DepEst.AddRange(New String() {"Ciencias Economicas y Administrativas", "Ciencias, Tecnología y Salud", "Ciencias de la Educación y Humanidades"})
        cmbDepartamentoEstudiante.DataSource = DepEst : cmbDepartamentoEstudiante.SelectedIndex = -1
        Dim DepDoc As New List(Of String) : DepDoc.AddRange(New String() {"Ciencias Economicas y Administrativas", "Ciencias, Tecnología y Salud", "Ciencias de la Educación y Humanidades"})
        cmbDepartamentoDocente.DataSource = DepDoc : cmbDepartamentoDocente.SelectedIndex = -1
        Try
            Using Carrera As New CarreraServicio.CarreraServicioClient
                cmbCarrera.DataSource = Carrera.Lista() : cmbCarrera.ValueMember = "IdCarrera" : cmbCarrera.DisplayMember = "NombreCarrera" : cmbCarrera.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error, " & ex.Message)
        End Try
        Me.LoadForm = True
    End Sub

    Private Sub cmbCarrera_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCarrera.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbCarrera.SelectedValue Is Nothing Then
                If cmbDepartamentoEstudiante.Enabled Then
                    cmbDepartamentoEstudiante.Focus()
                ElseIf cmbDepartamentoDocente.Enabled Then
                    cmbDepartamentoDocente.Focus()
                Else
                    txtDepartamento.Focus()
                End If
            Else
                Try
                    If cmbCarrera.Text.Trim <> "" Then
                        Dim NombreCarrera = cmbCarrera.Text
                        Using carrera As New CarreraServicio.CarreraServicioClient
                            If Not carrera.BuscarPorNombre(NombreCarrera) Is Nothing Then
                                cmbCarrera.DataSource = carrera.Lista().ToList() : cmbCarrera.ValueMember = "IdCarrera" : cmbCarrera.DisplayMember = "NombreCarrera" : cmbCarrera.Text = NombreCarrera : NombreCarrera = Nothing
                            Else
                                If MessageBox.Show("No se encuentra esta 'Carrera' ¿Desea creala como '" & cmbCarrera.Text & "'?", "Pregunta de Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    carrera.Guardar(New CarreraServicio.DCarrera With {.NombreCarrera = NombreCarrera})
                                    cmbCarrera.DataSource = carrera.Lista().ToList() : cmbCarrera.ValueMember = "IdCarrera" : cmbCarrera.DisplayMember = "NombreCarrera" : cmbCarrera.Text = NombreCarrera : NombreCarrera = Nothing
                                End If
                            End If
                        End Using
                    Else
                        MessageBox.Show("Ingresar la 'Carrera'.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cmbDepartamentoEstudiante_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDepartamentoEstudiante.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbDepartamentoEstudiante.SelectedValue Is Nothing Then
                If cmbDepartamentoDocente.Enabled Then
                    cmbDepartamentoDocente.Focus()
                ElseIf txtArea.Enabled Then
                    txtArea.Focus()
                Else
                    txtDepartamento.Focus()
                End If
            Else
                MessageBox.Show("Seleccionar departamento correctamente")
            End If
        End If
    End Sub

    Private Sub cmbDepartamentoDocente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDepartamentoDocente.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbDepartamentoDocente.SelectedValue Is Nothing Then
                txtDepartamento.Focus()
            Else
                MessageBox.Show("Seleccionar departamento correctamente")
            End If
        End If
    End Sub

    Private Sub txtNCarnet_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNCarnet.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtNCarnet.Text.Trim <> "" Then
                cmbId.Focus()
                'Try
                '    Using per As New PersonaServicio.PersonaServicioClient
                '        Dim persona As PersonaServicio.DPersona = per.BuscarPorCarnet(txtNCarnet.Text.Trim())
                '        If Not persona Is Nothing Then
                '            Me.IdPersona = persona.IdPersona
                '            cmbId.Text = persona.TipoIdentificacion
                '            txtId.Text = persona.Identificacion
                '            txtNombres.Text = persona.Nombres
                '            txtApellidos.Text = persona.Apellidos
                '            Dim CarreraPersona As CarreraServicio.DCarrera
                '            Using Carrera As New CarreraServicio.CarreraServicioClient
                '                CarreraPersona = Carrera.BuscarPorId(persona.IdCarrera)
                '            End Using
                '            Select Case persona.TipoPersona
                '                Case "Estudiante"
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                Case "Docente"
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                Case "Egresado"
                '                    'nada
                '                Case "Público en General"
                '                    'nada
                '                Case "Administrativo"
                '                    txtArea.Text = persona.Area
                '                Case "Docente-Administrativo"
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                    txtArea.Text = persona.Area
                '                Case "Docente-Estudiante"
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                Case "Estudiante-Administrativo"
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                    txtArea.Text = persona.Area
                '                Case "Estudiante-Administrativo-Docente"
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                    txtArea.Text = persona.Area
                '            End Select
                '            txtDepartamento.Text = persona.Departamento
                '            txtMunicipio.Text = persona.Municipio
                '            txtObservacion.Text = persona.Observacion
                '            btGuardar.Enabled = False
                '            btEditar.Enabled = True
                '            btEliminar.Enabled = True
                '            Beep()
                '            txtId.Focus()
                '        Else
                '            txtId.Focus()
                '        End If
                '    End Using
                'Catch ex As Exception
                '    MessageBox.Show("Error: " & ex.Message)
                'End Try
            Else
                MessageBox.Show("Ingresar Carnet")
            End If
        End If
    End Sub

    Private Sub cmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbId.SelectedIndexChanged
        If Me.LoadForm Then
            txtId.Focus()
        End If
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtId.Text.Trim <> "" Then
                txtNombres.Focus()
                'Try
                '    Using per As New PersonaServicio.PersonaServicioClient
                '        Dim persona = per.BuscarPorIdentificacion(txtId.Text.Trim())
                '        If Not persona Is Nothing Then
                '            Me.IdPersona = persona.IdPersona
                '            cmbId.Text = persona.TipoIdentificacion
                '            txtNombres.Text = persona.Nombres
                '            txtApellidos.Text = persona.Apellidos
                '            Dim CarreraPersona As CarreraServicio.DCarrera
                '            Using Carrera As New CarreraServicio.CarreraServicioClient
                '                CarreraPersona = Carrera.BuscarPorId(persona.IdCarrera)
                '            End Using
                '            Select Case Me.eTipoPersona
                '                Case 1
                '                    txtNCarnet.Text = persona.NCarnet
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                Case 2
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                Case 3
                '                    'nada
                '                Case 4
                '                    'nada
                '                Case 5
                '                    txtArea.Text = persona.Area
                '                Case 6
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                    txtArea.Text = persona.Area
                '                Case 7
                '                    txtNCarnet.Text = persona.NCarnet
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                Case 8
                '                    txtNCarnet.Text = persona.NCarnet
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                    txtArea.Text = persona.Area
                '                Case 9
                '                    txtNCarnet.Text = persona.NCarnet
                '                    cmbTurno.Text = persona.Turno
                '                    cmbCarrera.Text = If(Not CarreraPersona Is Nothing, CarreraPersona.NombreCarrera, "")
                '                    cmbDepartamentoEstudiante.Text = persona.DepartamentoAcademicoEstudiante
                '                    cmbDepartamentoDocente.Text = persona.DepartamentoAcademicoDocente
                '                    txtArea.Text = persona.Area
                '            End Select
                '            txtObservacion.Text = persona.Observacion
                '            btGuardar.Enabled = False
                '            btEditar.Enabled = True
                '            btEliminar.Enabled = True
                '            txtNombres.Focus()
                '        Else
                '            txtNombres.Focus()
                '        End If
                '    End Using
                'Catch ex As Exception
                '    MessageBox.Show("Error: " & ex.Message)
                'End Try
            Else
                If txtNCarnet.Enabled Then
                    MessageBox.Show("Es necesario ingresar una identificación.")
                End If
            End If
        End If
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try

            If txtNombres.Text.Trim = "" Then
                MessageBox.Show("Ingresar Nombres")
                txtNombres.Focus()
                Exit Sub
            End If
            If txtApellidos.Text.Trim = "" Then
                MessageBox.Show("Ingresar Apellidos")
                txtApellidos.Focus()
                Exit Sub
            End If
            If dtpFechaNacimiento.Text = "" Then
                MessageBox.Show("Ingresar Fecha de Nacimiento")
                dtpFechaNacimiento.Focus()
                Exit Sub
            End If
            If DateDiff(DateInterval.Year, DateTime.Parse(dtpFechaNacimiento.Value.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString)) < 10 Then
                MessageBox.Show("Los usuarios del EDULAP deben ser mayores de 9 años")
                dtpFechaNacimiento.Focus()
                Exit Sub
            End If
            Select Case Me.eTipoPersona
                Case 1
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                Case 2
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                Case 3
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                Case 4
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                Case 5
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
                Case 6
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
                Case 7
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Estudiante")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Docencia")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                Case 8
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
                Case 9
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Estudiante")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Docencia")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
            End Select

            If txtDepartamento.Text.Trim = "" Then
                MessageBox.Show("Es necesario ingresar el Departamento")
                Exit Sub
                txtDepartamento.Focus()
            End If
            If txtMunicipio.Text.Trim = "" Then
                MessageBox.Show("Es necesario ingresar el Municipio")
                Exit Sub
                txtMunicipio.Focus()
            End If

            'guardar
            Using per As New PersonaServicio.PersonaServicioClient
                per.Guardar(New PersonaServicio.DPersona With {.NCarnet = txtNCarnet.Text, .TipoPersona = If(Me.eTipoPersona.Equals(1), "Estudiante", If(Me.eTipoPersona.Equals(2), "Docente", If(Me.eTipoPersona.Equals(3), "Egresado", If(Me.eTipoPersona.Equals(4), "Público en General", If(Me.eTipoPersona.Equals(5), "Administrativo", If(Me.eTipoPersona.Equals(6), "Docente-Administrativo", If(Me.eTipoPersona.Equals(7), "Docente-Estudiante", If(Me.eTipoPersona.Equals(8), "Estudiante-Administrativo", If(Me.eTipoPersona.Equals(9), "Estudiante-Administrativo-Docente", ""))))))))), .TipoIdentificacion = cmbId.SelectedValue.ToString(), .Identificacion = txtId.Text, .Nombres = txtNombres.Text, .Apellidos = txtApellidos.Text, .Telefono = "", .Domicilio = "", .Sexo = If(rdMasculino.Checked, 1, 0), .FechaNacimiento = dtpFechaNacimiento.Value, .Turno = If(cmbTurno.Enabled, cmbTurno.SelectedValue.ToString(), ""), .IdCarrera = If(cmbCarrera.Enabled, Guid.Parse(cmbCarrera.SelectedValue.ToString()), Nothing), .DepartamentoAcademicoEstudiante = If(cmbDepartamentoEstudiante.Enabled, cmbDepartamentoEstudiante.SelectedValue.ToString(), ""), .DepartamentoAcademicoDocente = If(cmbDepartamentoDocente.Enabled, cmbDepartamentoDocente.SelectedValue.ToString(), ""), .Departamento = txtDepartamento.Text, .Municipio = txtMunicipio.Text, .Area = txtArea.Text, .Observacion = txtObservacion.Text, .Activo = True})
                Me.Limpiar()
                MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtNombres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombres.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtNombres.Text.Trim <> "" Then
                txtApellidos.Focus()
            Else
                MessageBox.Show("Ingresar Nombres")
            End If
        End If
    End Sub

    Private Sub txtApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApellidos.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtApellidos.Text.Trim <> "" Then
                If cmbTurno.Enabled Then
                    cmbTurno.Focus()
                Else
                    dtpFechaNacimiento.Focus()
                End If
            Else
                MessageBox.Show("Ingresar Apellidos")
            End If
        End If
    End Sub

    Private Sub cmbTurno_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTurno.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbTurno.SelectedValue Is Nothing Then
                dtpFechaNacimiento.Focus()
            Else
                MessageBox.Show("Ingresar Turno")
            End If
        End If
    End Sub

    Private Sub txtArea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArea.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtArea.Text.Trim <> "" Then
                txtObservacion.Focus()
            Else
                MessageBox.Show("Ingresar Área")
            End If
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Try
            If txtNombres.Text.Trim = "" Then
                MessageBox.Show("Ingresar Nombres")
                txtNombres.Focus()
                Exit Sub
            End If
            If txtApellidos.Text.Trim = "" Then
                MessageBox.Show("Ingresar Apellidos")
                txtApellidos.Focus()
                Exit Sub
            End If
            Select Case Me.eTipoPersona
                Case 1
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                Case 2
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                Case 3
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                Case 4
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                Case 5
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
                Case 6
                    If txtId.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Identificación")
                        txtId.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
                Case 7
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Estudiante")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Docencia")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                Case 8
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
                Case 9
                    If txtNCarnet.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carnet")
                        txtNCarnet.Focus()
                        Exit Sub
                    End If
                    If cmbTurno.SelectedValue Is Nothing Then
                        MessageBox.Show("Ingresar Turno")
                        cmbTurno.Focus()
                        Exit Sub
                    End If
                    If cmbCarrera.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Carrera")
                        cmbCarrera.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoEstudiante.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Estudiante")
                        cmbDepartamentoEstudiante.Focus()
                        Exit Sub
                    End If
                    If cmbDepartamentoDocente.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Departamento Académico de Docencia")
                        cmbDepartamentoDocente.Focus()
                        Exit Sub
                    End If
                    If txtArea.Text.Trim = "" Then
                        MessageBox.Show("Ingresar Área")
                        txtArea.Focus()
                        Exit Sub
                    End If
            End Select

            'guardar
            Using per As New PersonaServicio.PersonaServicioClient
                per.Editar(New PersonaServicio.DPersona With {.IdPersona = Me.IdPersona, .NCarnet = txtNCarnet.Text, .TipoPersona = If(Me.eTipoPersona.Equals(1), "Estudiante", If(Me.eTipoPersona.Equals(2), "Docente", If(Me.eTipoPersona.Equals(3), "Egresado", If(Me.eTipoPersona.Equals(4), "Público en General", If(Me.eTipoPersona.Equals(5), "Administrativo", If(Me.eTipoPersona.Equals(6), "Docente-Administrativo", If(Me.eTipoPersona.Equals(7), "Docente-Estudiante", If(Me.eTipoPersona.Equals(8), "Estudiante-Administrativo", If(Me.eTipoPersona.Equals(9), "Estudiante-Administrativo-Docente", ""))))))))), .TipoIdentificacion = cmbId.SelectedValue.ToString(), .Identificacion = txtId.Text, .Nombres = txtNombres.Text, .Apellidos = txtApellidos.Text, .Turno = If(cmbTurno.Enabled, cmbTurno.SelectedValue.ToString(), ""), .IdCarrera = If(cmbCarrera.Enabled, Guid.Parse(cmbCarrera.SelectedValue.ToString()), Nothing), .DepartamentoAcademicoEstudiante = If(cmbDepartamentoEstudiante.Enabled, cmbDepartamentoEstudiante.SelectedValue.ToString(), ""), .DepartamentoAcademicoDocente = If(cmbDepartamentoDocente.Enabled, cmbDepartamentoDocente.SelectedValue.ToString(), ""), .Area = txtArea.Text, .Observacion = txtObservacion.Text, .Activo = True})
                Me.Limpiar()
                MessageBox.Show("Editado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            If MessageBox.Show("¿Desea eliminar esta 'Persona'?", "Pregunta de seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Using Persona As New PersonaServicio.PersonaServicioClient
                    Persona.Eliminar(Me.IdPersona)
                    Limpiar()
                    MessageBox.Show("Eliminado correctamente")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaNacimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaNacimiento.KeyDown
        If e.KeyData = Keys.Enter Then
            If dtpFechaNacimiento.Text = "" Then
                MessageBox.Show("Ingresar Fecha de Nacimiento")
                dtpFechaNacimiento.Focus()
                Exit Sub
            End If
            If DateDiff(DateInterval.Year, DateTime.Parse(dtpFechaNacimiento.Value.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString())) < 9 Then
                MessageBox.Show("Los usuarios del EDULAP deben ser mayores de 9 años")
                dtpFechaNacimiento.Focus()
                Exit Sub
            End If
            If cmbCarrera.Enabled Then
                cmbCarrera.Focus()
            ElseIf cmbDepartamentoDocente.Enabled Then
                cmbDepartamentoDocente.Focus()
            Else
                txtDepartamento.Focus()
            End If
        End If
    End Sub

    Private Sub rdMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles rdMasculino.CheckedChanged
        If rdMasculino.Checked Then
            dtpFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub rdFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemenino.CheckedChanged
        If rdFemenino.Checked Then
            dtpFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtObservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObservacion.KeyDown
        If e.KeyData = Keys.Enter Then
            If btGuardar.Enabled Then
                btGuardar_Click(Nothing, Nothing)
            ElseIf btEditar.Enabled Then
                btEditar_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        frmBuscarPersona.Frm = 0
        frmBuscarPersona.ShowDialog()
    End Sub

    Private Sub txtNCiudad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNCiudad.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtNCiudad.Text.Trim <> "" Then
                Try
                    Using Ciudad As New CiudadServicio.CiudadServicioClient
                        Dim ciu = Ciudad.BuscarPorNombre(txtCiudad.Text.Trim)
                        If Not ciu Is Nothing Then
                            txtIdCiudad.Text = ciu.IdCiudad.ToString
                            txtCiudad.Text = ciu.Descripcion & "; " & ciu.Pais & ";"
                            If txtArea.Enabled = True Then
                                txtArea.Focus()
                            Else
                                txtObservacion.Focus()
                            End If
                        Else
                            MessageBox.Show("No se encuentra esta ciudad.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                frmBuscarCiudad.Frm = 1
                frmBuscarCiudad.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cmbTipoPersona_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipoPersona.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not cmbTipoPersona.SelectedValue Is Nothing And cmbTipoPersona.SelectedIndex <> -1 Then
                Select Case cmbTipoPersona.SelectedValue.ToString
                    Case "Estudiante"
                        txtNCarnet.Focus()
                    Case "Docente"
                        cmbId.Focus()
                    Case "Egresado"
                        cmbId.Focus()
                    Case "Público General"
                        cmbId.Focus()
                    Case "Administrativo"
                        cmbId.Focus()
                    Case "Docente-Administrativo"
                        cmbId.Focus()
                    Case "Docente-Estudiante"
                        txtNCarnet.Focus()
                    Case "Estudiante-Administrativo"
                        txtNCarnet.Focus()
                    Case "Estudiante-Administrativo-Docente"
                        txtNCarnet.Focus()
                End Select
            Else
                MessageBox.Show("Seleccione el tipo de persona.")
            End If
        End If
    End Sub

    Private Sub cmbTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPersona.SelectedIndexChanged
        If Me.LoadForm Then
            If Not cmbTipoPersona.SelectedValue Is Nothing And cmbTipoPersona.SelectedIndex <> -1 Then
                Select Case cmbTipoPersona.SelectedValue.ToString
                    Case "Estudiante"
                        Me.eTipoPersona = 1
                        txtNCarnet.Enabled = True
                        cmbCarrera.Enabled = True
                        cmbTurno.Enabled = True
                        cmbDepartamentoEstudiante.Enabled = True
                        cmbDepartamentoDocente.Enabled = False : cmbDepartamentoDocente.SelectedIndex = -1
                        txtArea.Enabled = False : txtArea.Clear()
                    Case "Docente"
                        Me.eTipoPersona = 2
                        txtNCarnet.Enabled = False : txtNCarnet.Clear()
                        cmbCarrera.Enabled = False : cmbCarrera.SelectedIndex = -1
                        cmbTurno.Enabled = False : cmbTurno.SelectedIndex = -1
                        cmbDepartamentoEstudiante.Enabled = False : cmbDepartamentoEstudiante.SelectedIndex = -1
                        cmbDepartamentoDocente.Enabled = True
                        txtArea.Enabled = False : txtArea.Clear()
                    Case "Egresado"
                        Me.eTipoPersona = 3
                        txtNCarnet.Enabled = False : txtNCarnet.Clear()
                        cmbCarrera.Enabled = False : cmbCarrera.SelectedIndex = -1
                        cmbTurno.Enabled = False : cmbTurno.SelectedIndex = -1
                        cmbDepartamentoEstudiante.Enabled = False : cmbDepartamentoEstudiante.SelectedIndex = -1
                        cmbDepartamentoDocente.Enabled = False : cmbDepartamentoDocente.SelectedIndex = -1
                        txtArea.Enabled = False : txtArea.Clear()
                    Case "Público General"
                        Me.eTipoPersona = 4
                        txtNCarnet.Enabled = False : txtNCarnet.Clear()
                        cmbCarrera.Enabled = False : cmbCarrera.SelectedIndex = -1
                        cmbTurno.Enabled = False : cmbTurno.SelectedIndex = -1
                        cmbDepartamentoEstudiante.Enabled = False : cmbDepartamentoEstudiante.SelectedIndex = -1
                        cmbDepartamentoDocente.Enabled = False : cmbDepartamentoDocente.SelectedIndex = -1
                        txtArea.Enabled = False : txtArea.Clear()
                    Case "Administrativo"
                        Me.eTipoPersona = 5
                        txtNCarnet.Enabled = False : txtNCarnet.Clear()
                        cmbCarrera.Enabled = False : cmbCarrera.SelectedIndex = -1
                        cmbTurno.Enabled = False : cmbTurno.SelectedIndex = -1
                        cmbDepartamentoEstudiante.Enabled = False : cmbDepartamentoEstudiante.SelectedIndex = -1
                        cmbDepartamentoDocente.Enabled = False : cmbDepartamentoEstudiante.SelectedIndex = -1
                        txtArea.Enabled = True
                    Case "Docente-Administrativo"
                        Me.eTipoPersona = 6
                        txtNCarnet.Enabled = False : txtNCarnet.Clear()
                        cmbCarrera.Enabled = False : cmbCarrera.SelectedIndex = -1
                        cmbTurno.Enabled = False : cmbTurno.SelectedIndex = -1
                        cmbDepartamentoEstudiante.Enabled = False : cmbDepartamentoEstudiante.SelectedIndex = -1
                        cmbDepartamentoDocente.Enabled = True
                        txtArea.Enabled = True
                    Case "Docente-Estudiante"
                        Me.eTipoPersona = 7
                        txtNCarnet.Enabled = True
                        cmbCarrera.Enabled = True
                        cmbTurno.Enabled = True
                        cmbDepartamentoEstudiante.Enabled = True
                        cmbDepartamentoDocente.Enabled = True
                        txtArea.Enabled = False : txtArea.Clear()
                    Case "Estudiante-Administrativo"
                        Me.eTipoPersona = 8
                        txtNCarnet.Enabled = True
                        cmbCarrera.Enabled = True
                        cmbTurno.Enabled = True
                        cmbDepartamentoEstudiante.Enabled = True
                        cmbDepartamentoDocente.Enabled = False : cmbDepartamentoDocente.SelectedIndex = -1
                        txtArea.Enabled = True
                    Case "Estudiante-Administrativo-Docente"
                        Me.eTipoPersona = 9
                        txtNCarnet.Enabled = True
                        cmbCarrera.Enabled = True
                        cmbTurno.Enabled = True
                        cmbDepartamentoEstudiante.Enabled = True
                        cmbDepartamentoDocente.Enabled = True
                        txtArea.Enabled = True
                End Select
            End If
        End If
    End Sub

    Private Sub txtDepartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepartamento.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtDepartamento.Text.Trim <> "" Then
                txtMunicipio.Focus()
            Else
                MessageBox.Show("Ingresar el Departamento en que vive.")
            End If
        End If
    End Sub

    Private Sub txtMunicipio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMunicipio.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtMunicipio.Text.Trim <> "" Then
                If txtArea.Enabled Then
                    txtArea.Focus()
                Else
                    txtObservacion.Focus()
                End If
            Else
                MessageBox.Show("Ingresar el Municipio en que vive.")
            End If
        End If
    End Sub



End Class