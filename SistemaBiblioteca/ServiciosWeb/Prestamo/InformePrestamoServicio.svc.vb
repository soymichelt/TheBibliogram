' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "InformePrestamoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione InformePrestamoServicio.svc o InformePrestamoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class InformePrestamoServicio
    Implements IInformePrestamoServicio

    Public Sub DoWork() Implements IInformePrestamoServicio.DoWork
    End Sub

    Public Function PrestamosPorDepartamento(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal Departamento As Byte) As List(Of DCantidadMensual3Columnas) Implements IInformePrestamoServicio.PrestamosPorDepartamento
        Dim Lista As New List(Of DCantidadMensual3Columnas)
        Dim inicio, final As Integer
        If Anual <= 1990 Or Anual > DateTime.Now.Year Then
            Throw New Exception("El año es un valor mayor que 1990 y menor que " & DateTime.Now.Year)
        End If
        Select Case Modalidad
            Case 1 'todos los meses
                inicio = 1 : final = 12
            Case 2 'primer semestre
                inicio = 1 : final = 6
            Case 3 'segundo semestre
                inicio = 7 : final = 12
            Case 4 'primer trimestre
                inicio = 1 : final = 4
            Case 5 'segundo trimestre
                inicio = 5 : final = 8
            Case 6 'tercer trimestre
                inicio = 9 : final = 12
            Case 7 'primeros 2 meses
                inicio = 1 : final = 2
            Case 8 'segundos 2 meses
                inicio = 3 : final = 4
            Case 9 'terceros 2 meses
                inicio = 5 : final = 6
            Case 10 'cuartos 2 meses
                inicio = 7 : final = 8
            Case 11 'quintos 2 meses
                inicio = 9 : final = 10
            Case 12 'sextos 2 meses
                inicio = 11 : final = 12
            Case 13 'enero
                inicio = 1 : final = 1
            Case 14 'febrero
                inicio = 2 : final = 2
            Case 15 'marzo
                inicio = 3 : final = 3
            Case 16 'abril
                inicio = 4 : final = 4
            Case 17 'mayo
                inicio = 5 : final = 5
            Case 18 'junio
                inicio = 6 : final = 6
            Case 19 'julio
                inicio = 7 : final = 7
            Case 20 'agosto
                inicio = 8 : final = 8
            Case 21 'septiembre
                inicio = 9 : final = 9
            Case 22 'octubre
                inicio = 10 : final = 10
            Case 23 'noviembre
                inicio = 11 : final = 11
            Case 24 'diciembre
                inicio = 12 : final = 12
            Case Else
                Throw New Exception("Ingreso un valor al atributo 'Modalidad' inválido.")
        End Select
        Dim dpto = ""
        If Departamento = 1 Then
            dpto = "Ciencias, Tecnología y Salud"
        ElseIf Departamento = 2 Then
            dpto = "Ciencias Economicas y Administrativas"
        ElseIf Departamento = 3 Then
            dpto = "Ciencias de la Educación y Humanidades"
        Else
            Throw New Exception("Departamento inválido")
        End If
        Try
            Using db As New ContextoBiblioteca
                For i As Integer = inicio To final
                    Dim item As New DCantidadMensual3Columnas
                    item.Id = i
                    item.Mes = If(i = 1, "Enero", If(i = 2, "Febrero", If(i = 3, "Marzo", If(i = 4, "Abríl", If(i = 5, "Mayo", If(i = 6, "Junio", If(i = 7, "Julio", If(i = 8, "Agosto", If(i = 9, "Septiembre", If(i = 10, "Octubre", If(i = 11, "Noviembre", "Diciembre")))))))))))
                    Dim Prestamos = (From pre In db.Prestamos Where pre.Activo And (pre.DepartamentoAcademicoDocente = dpto Or pre.DepartamentoAcademicoEstudiante = dpto) And pre.FechaPrestamo.Year = Anual And pre.FechaPrestamo.Month = i Select pre).ToList()
                    item.C1 = Prestamos.Where(Function(f) f.Sexo).ToList().Count
                    item.C2 = Prestamos.Where(Function(f) f.Sexo = False).ToList().Count
                    item.C3 = Prestamos.Count
                    Lista.Add(item)
                Next
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try

        Return Lista
    End Function

    Public Function PrestamosPorCarrera(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal Carrera As Guid) As List(Of DCantidadMensual3Columnas) Implements IInformePrestamoServicio.PrestamosPorCarrera
        Dim Lista As New List(Of DCantidadMensual3Columnas)
        Dim inicio, final As Integer
        If Anual <= 1990 Or Anual > DateTime.Now.Year Then
            Throw New Exception("El año es un valor mayor que 1990 y menor que " & DateTime.Now.Year)
        End If
        Select Case Modalidad
            Case 1 'todos los meses
                inicio = 1 : final = 12
            Case 2 'primer semestre
                inicio = 1 : final = 6
            Case 3 'segundo semestre
                inicio = 7 : final = 12
            Case 4 'primer trimestre
                inicio = 1 : final = 4
            Case 5 'segundo trimestre
                inicio = 5 : final = 8
            Case 6 'tercer trimestre
                inicio = 9 : final = 12
            Case 7 'primeros 2 meses
                inicio = 1 : final = 2
            Case 8 'segundos 2 meses
                inicio = 3 : final = 4
            Case 9 'terceros 2 meses
                inicio = 5 : final = 6
            Case 10 'cuartos 2 meses
                inicio = 7 : final = 8
            Case 11 'quintos 2 meses
                inicio = 9 : final = 10
            Case 12 'sextos 2 meses
                inicio = 11 : final = 12
            Case 13 'enero
                inicio = 1 : final = 1
            Case 14 'febrero
                inicio = 2 : final = 2
            Case 15 'marzo
                inicio = 3 : final = 3
            Case 16 'abril
                inicio = 4 : final = 4
            Case 17 'mayo
                inicio = 5 : final = 5
            Case 18 'junio
                inicio = 6 : final = 6
            Case 19 'julio
                inicio = 7 : final = 7
            Case 20 'agosto
                inicio = 8 : final = 8
            Case 21 'septiembre
                inicio = 9 : final = 9
            Case 22 'octubre
                inicio = 10 : final = 10
            Case 23 'noviembre
                inicio = 11 : final = 11
            Case 24 'diciembre
                inicio = 12 : final = 12
            Case Else
                Throw New Exception("Ingreso un valor al atributo 'Modalidad' inválido.")
        End Select
        Try
            Using db As New ContextoBiblioteca
                Dim c = db.Carreras.Where(Function(f) f.IdCarrera = Carrera).FirstOrDefault()
                If Not c Is Nothing Then
                    For i As Integer = inicio To final
                        Dim item As New DCantidadMensual3Columnas
                        item.Id = i
                        item.Mes = If(i = 1, "Enero", If(i = 2, "Febrero", If(i = 3, "Marzo", If(i = 4, "Abríl", If(i = 5, "Mayo", If(i = 6, "Junio", If(i = 7, "Julio", If(i = 8, "Agosto", If(i = 9, "Septiembre", If(i = 10, "Octubre", If(i = 11, "Noviembre", "Diciembre")))))))))))
                        Dim Prestamos = (From pre In db.Prestamos Where pre.Activo And (pre.Carrera = c.NombreCarrera) And pre.FechaPrestamo.Year = Anual And pre.FechaPrestamo.Month = i Select pre).ToList()
                        item.C1 = Prestamos.Where(Function(f) f.Sexo).ToList().Count
                        item.C2 = Prestamos.Where(Function(f) f.Sexo = False).ToList().Count
                        item.C3 = Prestamos.Count
                        Lista.Add(item)
                    Next
                Else
                    Throw New Exception(GlobalSistema.NoEncontrado("Carrera"))
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try

        Return Lista
    End Function

    Public Function PrestamosPorTipoPersona(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal TipoPersona As Byte) As List(Of DCantidadMensual3Columnas) Implements IInformePrestamoServicio.PrestamosPorTipoPersona
        Dim Lista As New List(Of DCantidadMensual3Columnas)
        Dim inicio, final As Integer
        If Anual <= 1990 Or Anual > DateTime.Now.Year Then
            Throw New Exception("El año es un valor mayor que 1990 y menor que " & DateTime.Now.Year)
        End If
        Select Case Modalidad
            Case 1 'todos los meses
                inicio = 1 : final = 12
            Case 2 'primer semestre
                inicio = 1 : final = 6
            Case 3 'segundo semestre
                inicio = 7 : final = 12
            Case 4 'primer trimestre
                inicio = 1 : final = 4
            Case 5 'segundo trimestre
                inicio = 5 : final = 8
            Case 6 'tercer trimestre
                inicio = 9 : final = 12
            Case 7 'primeros 2 meses
                inicio = 1 : final = 2
            Case 8 'segundos 2 meses
                inicio = 3 : final = 4
            Case 9 'terceros 2 meses
                inicio = 5 : final = 6
            Case 10 'cuartos 2 meses
                inicio = 7 : final = 8
            Case 11 'quintos 2 meses
                inicio = 9 : final = 10
            Case 12 'sextos 2 meses
                inicio = 11 : final = 12
            Case 13 'enero
                inicio = 1 : final = 1
            Case 14 'febrero
                inicio = 2 : final = 2
            Case 15 'marzo
                inicio = 3 : final = 3
            Case 16 'abril
                inicio = 4 : final = 4
            Case 17 'mayo
                inicio = 5 : final = 5
            Case 18 'junio
                inicio = 6 : final = 6
            Case 19 'julio
                inicio = 7 : final = 7
            Case 20 'agosto
                inicio = 8 : final = 8
            Case 21 'septiembre
                inicio = 9 : final = 9
            Case 22 'octubre
                inicio = 10 : final = 10
            Case 23 'noviembre
                inicio = 11 : final = 11
            Case 24 'diciembre
                inicio = 12 : final = 12
            Case Else
                Throw New Exception("Ingreso un valor al atributo 'Modalidad' inválido.")
        End Select
        Dim TP = ""
        If TipoPersona = 1 Then
            TP = "Estudiante"
        ElseIf TipoPersona = 2 Then
            TP = "Docente"
        ElseIf TipoPersona = 3 Then
            TP = "Egresado"
        ElseIf TipoPersona = 4 Then
            TP = "Público en General"
        ElseIf TipoPersona = 5 Then
            TP = "Administrativo"
        ElseIf TipoPersona = 6 Then
            TP = "Docente-Administrativo"
        ElseIf TipoPersona = 7 Then
            TP = "Docente-Estudiante"
        ElseIf TipoPersona = 8 Then
            TP = "Estudiante-Administrativo"
        ElseIf TipoPersona = 9 Then
            TP = "Estudiante-Administrativo-Docente"
        Else
            Throw New Exception("Tipo de Persona inválido")
        End If
        Try
            Using db As New ContextoBiblioteca
                For i As Integer = inicio To final
                    Dim item As New DCantidadMensual3Columnas
                    item.Id = i
                    item.Mes = If(i = 1, "Enero", If(i = 2, "Febrero", If(i = 3, "Marzo", If(i = 4, "Abríl", If(i = 5, "Mayo", If(i = 6, "Junio", If(i = 7, "Julio", If(i = 8, "Agosto", If(i = 9, "Septiembre", If(i = 10, "Octubre", If(i = 11, "Noviembre", "Diciembre")))))))))))
                    Dim Prestamos = (From pre In db.Prestamos Where pre.Activo And pre.TipoPersona = TP And pre.FechaPrestamo.Year = Anual And pre.FechaPrestamo.Month = i Select pre).ToList()
                    item.C1 = Prestamos.Where(Function(f) f.Sexo).ToList().Count
                    item.C2 = Prestamos.Where(Function(f) f.Sexo = False).ToList().Count
                    item.C3 = Prestamos.Count
                    Lista.Add(item)
                Next
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try

        Return Lista
    End Function

End Class
