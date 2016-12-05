' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "PersonaServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PersonaServicio.svc o PersonaServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class PersonaServicio
    Implements IPersonaServicio

    Public Sub DoWork() Implements IPersonaServicio.DoWork

    End Sub

    Public Sub Guardar(ByVal Persona As DPersona) Implements IPersonaServicio.Guardar
        Try
            Using db As New ContextoBiblioteca
                With Persona
                    If .TipoPersona = "Estudiante" Or .TipoPersona = "Docente" Or .TipoPersona = "Egresado" Or .TipoPersona = "Público en General" Or .TipoPersona = "Administrativo" Or .TipoPersona = "Docente-Administrativo" Or .TipoPersona = "Docente-Estudiante" Or .TipoPersona = "Estudiante-Administrativo" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                        'validaciones
                        If .Nombres.Trim = "" Or .Apellidos.Trim = "" Then
                            Throw New Exception("Especificar los atributos 'Nombres' y 'Apellidos'.")
                        End If
                        'If .Sexo <> "Masculino" And .Sexo <> "Femenino" Then
                        '    Throw New Exception("Especificar el atributo Sexo como 'Masculino' o 'Femenino'.")
                        'End If
                        If DateDiff(DateInterval.Year, DateTime.Parse(.FechaNacimiento.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString())) < 9 Then
                            Throw New Exception("Los usuarios del EDULAP deben ser mayores de 9 años.")
                        End If
                        If .TipoPersona = "Estudiante" Or .TipoPersona = "Docente-Estudiante" Or .TipoPersona = "Estudiante-Administrativo" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                            If .NCarnet.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Nº Carnet'.")
                            End If
                            If .IdCarrera = Guid.Empty Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Carrera'.")
                            Else
                                Dim Carrera = db.Carreras.Where(Function(f) f.IdCarrera = .IdCarrera).FirstOrDefault
                                If Carrera Is Nothing Then
                                    Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Carrera'.")
                                End If
                                Carrera = Nothing
                            End If
                            If .DepartamentoAcademicoEstudiante.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Departamento Académico de Estudiante'.")
                            End If
                            If .Turno.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Turno'.")
                            End If
                        Else
                            If .TipoIdentificacion.Trim = "" Or .Identificacion.Trim = "" Then
                                Throw New Exception("Las Personas que no son clasificadas como estudiantes deben especificar los atributos 'Tipo Identificación' e 'Identificación'.")
                            End If
                            .IdCarrera = Nothing
                        End If
                        If .TipoPersona = "Docente" Or .TipoPersona = "Docente-Administrativo" Or .TipoPersona = "Docente-Estudiante" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                            If .DepartamentoAcademicoDocente.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como docentes deben especificar un atributo 'Departamento Académico de Docencia'.")
                            End If
                        End If
                        If .TipoPersona = "Administrativo" Or .TipoPersona = "Docente-Administrativo" Or .TipoPersona = "Estudiante-Administrativo" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                            If .Area.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como administrativos deben especificar un atributo 'Área'.")
                            End If
                        End If
                        If Persona.NCarnet.Trim() <> "" Then
                            If Not db.Personas.Where(Function(f) f.NCarnet.Equals(Persona.NCarnet)).FirstOrDefault() Is Nothing Then
                                Throw New Exception("Ya existe un(a) 'Estudiante' con este N° de Carnet.")
                            End If
                        End If
                        If Persona.Identificacion.Trim() <> "" Then
                            If Not db.Personas.Where(Function(f) f.Identificacion.Equals(Persona.Identificacion)).FirstOrDefault() Is Nothing Then
                                Throw New Exception("Ya existe un(a) 'Estudiante' con este N° de Identificación.")
                            End If
                        End If
                        If Persona.Departamento.Trim() = "" Then
                            Throw New Exception("Falto ingresar el Departamento")
                        End If
                        If Persona.Municipio.Trim() = "" Then
                            Throw New Exception("Falto ingresar el Municipio")
                        End If
                        'guardar
                        Dim per As New Persona
                        per.IdPersona = Guid.NewGuid() : per.FechaRegistro = DateTime.Now : per.FechaUltimaModificacion = DateTime.Now : per.TipoPersona = .TipoPersona : per.TipoIdentificacion = .TipoIdentificacion : per.Identificacion = .Identificacion : per.Nombres = .Nombres : per.Apellidos = .Apellidos : per.NCarnet = .NCarnet : per.Sexo = .Sexo : per.FechaNacimiento = .FechaNacimiento : per.Turno = .Turno : per.Area = .Area : per.DepartamentoAcademicoEstudiante = .DepartamentoAcademicoEstudiante : per.DepartamentoAcademicoDocente = .DepartamentoAcademicoDocente : per.Departamento = .Departamento : per.Municipio = .Municipio : per.IdCarrera = .IdCarrera : per.Observacion = .Observacion : per.Activo = True
                        db.Personas.Add(per)
                        db.SaveChanges()
                    Else
                        Throw New Exception("Especificar un atributo 'Tipo Persona' válido.")
                    End If
                End With
            End Using
        Catch ex As Exception
            Throw New Exception("Se ha producido un error inesperado. " & ex.Message)
        End Try
    End Sub

    Public Sub Editar(ByVal Persona As DPersona) Implements IPersonaServicio.Editar
        Try
            Using db As New ContextoBiblioteca
                'validaciones
                With Persona
                    If .TipoPersona = "Estudiante" Or .TipoPersona = "Docente" Or .TipoPersona = "Egresado" Or .TipoPersona = "Público en General" Or .TipoPersona = "Administrativo" Or .TipoPersona = "Docente-Administrativo" Or .TipoPersona = "Docente-Estudiante" Or .TipoPersona = "Estudiante-Administrativo" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                        If .Nombres.Trim = "" Or .Apellidos.Trim = "" Then
                            Throw New Exception("Especificar los atributos 'Nombres' y 'Apellidos'.")
                        End If
                        If .Sexo <> "Masculino" And .Sexo <> "Femenino" Then
                            Throw New Exception("Especificar el atributo Sexo como 'Masculino' o 'Femenino'.")
                        End If
                        If DateDiff(DateInterval.Year, DateTime.Parse(.FechaNacimiento.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString())) < 9 Then
                            Throw New Exception("Los usuarios del EDULAP deben ser mayores de 9 años.")
                        End If
                        If .TipoPersona = "Estudiante" Or .TipoPersona = "Docente-Estudiante" Or .TipoPersona = "Estudiante-Administrativo" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                            If .NCarnet.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Nº Carnet'.")
                            End If
                            If .IdCarrera = Guid.Empty Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Carrera'.")
                            Else
                                Dim Carrera = db.Carreras.Where(Function(f) f.IdCarrera = .IdCarrera).FirstOrDefault
                                If Carrera Is Nothing Then
                                    Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Carrera'.")
                                End If
                                Carrera = Nothing
                            End If
                            If .DepartamentoAcademicoEstudiante.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Departamento Académico de Estudiante'.")
                            End If
                            If .Turno.Trim = "" Then
                                Throw New Exception("Las Personas que son clasificadas como estudiantes deben especificar un atributo 'Turno'.")
                            End If
                        Else
                            If .TipoIdentificacion.Trim = "" Or .Identificacion.Trim = "" Then
                                Throw New Exception("Las Personas que no son clasificadas como estudiantes deben especificar los atributos 'Tipo Identificación' e 'Identificación'.")
                            End If
                        End If
                        If .TipoPersona = "Docente" Or .TipoPersona = "Docente-Administrativo" Or .TipoPersona = "Docente-Estudiante" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                            Throw New Exception("Las Personas que son clasificadas como docentes deben especificar un atributo 'Departamento Académico de Docencia'.")
                        End If
                        If .TipoPersona = "Administrativo" Or .TipoPersona = "Docente-Administrativo" Or .TipoPersona = "Estudiante-Administrativo" Or .TipoPersona = "Estudiante-Administrativo-Docente" Then
                            Throw New Exception("Las Personas que son clasificadas como administrativos deben especificar un atributo 'Área'.")
                        End If
                        If Persona.NCarnet.Trim() <> "" Then
                            If Not db.Personas.Where(Function(f) f.NCarnet.Equals(Persona.NCarnet)).FirstOrDefault() Is Nothing Then
                                Throw New Exception("Ya existe un(a) 'Estudiante' con este N° de Carnet.")
                            End If
                        End If
                        If Persona.Identificacion.Trim() <> "" Then
                            If Not db.Personas.Where(Function(f) f.IdPersona <> Persona.IdPersona And f.Identificacion.Equals(Persona.Identificacion)).FirstOrDefault() Is Nothing Then
                                Throw New Exception("Ya existe un(a) 'Estudiante' con este N° de Identificación.")
                            End If
                        End If
                        'guardar
                        Dim per = db.Personas.Where(Function(f) f.IdPersona <> Persona.IdPersona And f.IdPersona = Persona.IdPersona).FirstOrDefault
                        If Not per Is Nothing Then
                            per.TipoPersona = Persona.TipoPersona : per.TipoIdentificacion = Persona.TipoIdentificacion : per.Identificacion = Persona.Identificacion : per.Nombres = Persona.Nombres : per.Apellidos = Persona.Apellidos : per.NCarnet = Persona.NCarnet : per.Sexo = .Sexo : per.FechaNacimiento = .FechaNacimiento : per.Turno = Persona.NCarnet : per.Turno = Persona.Turno : per.Area = Persona.Area : per.DepartamentoAcademicoEstudiante = Persona.DepartamentoAcademicoEstudiante : per.DepartamentoAcademicoDocente = Persona.DepartamentoAcademicoDocente : per.IdCarrera = Persona.IdCarrera : per.Observacion = per.Observacion : per.Activo = True
                            db.Personas.Add(per)
                            db.SaveChanges()
                        Else
                            Throw New Exception("No se encontró esta 'Persona'.")
                        End If
                    Else
                        Throw New Exception("Especificar un atributo 'Tipo Persona' válido.")
                    End If
                End With
            End Using
        Catch ex As Exception
            Throw New Exception("Se ha producido un error inesperado. " & ex.Message)
        End Try
    End Sub

    Public Sub Eliminar(ByVal IdPersona As Guid) Implements IPersonaServicio.Eliminar
        Try
            Using db As New ContextoBiblioteca
                'validaciones

                'guardar
                Dim per = db.Personas.Where(Function(f) f.IdPersona = IdPersona).FirstOrDefault
                If Not per Is Nothing Then
                    per.Activo = False
                    db.Entry(per).State = Entity.EntityState.Modified
                    db.SaveChanges()
                Else
                    Throw New Exception("No se encontro esta 'Persona'.")
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Se ha producido un error inesperado. " & ex.Message)
        End Try
    End Sub

    Public Function Lista() As List(Of DPersona) Implements IPersonaServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From per In db.Personas Where per.Activo Select New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .NCarnet = per.NCarnet, .Turno = per.Turno, .Departamento = per.Departamento, .Municipio = per.Municipio, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Observacion = per.Observacion, .Activo = per.Activo}).ToList()
        End Using
    End Function

    Public Function Filtrar(ByVal Carnet As String, ByVal Id As String, ByVal Nombres As String, ByVal Apellidos As String) As List(Of DPersona) Implements IPersonaServicio.Filtrar
        Using db As New ContextoBiblioteca
            Return (From per In db.Personas Where per.Activo And per.NCarnet.Contains(Carnet) And per.Identificacion.Contains(Id) And per.Nombres.Contains(Nombres) And per.Apellidos.Contains(Apellidos) Select New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .NCarnet = per.NCarnet, .Turno = per.Turno, .Departamento = per.Departamento, .Municipio = per.Municipio, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Observacion = per.Observacion, .Activo = per.Activo}).ToList()
        End Using
    End Function

    Public Function Busqueda(ByVal Persona As DPersona) As List(Of DPersona) Implements IPersonaServicio.Busqueda
        If Not Persona Is Nothing Then
            Using db As New ContextoBiblioteca
                Dim consulta = (From per In db.Personas Where per.Activo And per.NCarnet.Contains(Persona.NCarnet) And per.Identificacion.Contains(Persona.Identificacion) And per.Nombres.Contains(Persona.Nombres) And per.Apellidos.Contains(Persona.Apellidos) Select New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .FechaUltimaModificacion = per.FechaUltimaModificacion, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .Sexo = per.Sexo, .FechaNacimiento = per.FechaNacimiento, .Telefono = per.Telefono, .Domicilio = per.Domicilio, .NCarnet = per.NCarnet, .Turno = per.Turno, .Departamento = per.Departamento, .Municipio = per.Municipio, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Carrera = If(Not per.Carrera Is Nothing, per.Carrera.NombreCarrera, ""), .IdCiudad = per.IdCiudad, .Ciudad = "", .Pais = ""}).ToList()
                Return consulta
            End Using
        Else
            Throw New Exception(GlobalSistema.ParametrosNoEnviados("Persona"))
        End If
    End Function

    Function BuscarPorCarnet(ByVal Carnet As String) As DPersona Implements IPersonaServicio.BuscarPorCarnet
        Using db As New ContextoBiblioteca
            Return (From per In db.Personas Where per.Activo = True And per.NCarnet = Carnet Select New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .NCarnet = per.NCarnet, .Turno = per.Turno, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Observacion = per.Observacion, .Activo = per.Activo}).FirstOrDefault()
        End Using
    End Function

    Function BuscarPorIdentificacion(ByVal Id As String) As DPersona Implements IPersonaServicio.BuscarPorIdentificacion
        Using db As New ContextoBiblioteca
            Return (From per In db.Personas Where per.Activo = True And per.Identificacion = Id Select New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .NCarnet = per.NCarnet, .Turno = per.Turno, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Observacion = per.Observacion, .Activo = per.Activo}).FirstOrDefault
        End Using
    End Function

    Public Function BuscarPorId(ByVal IdPersona As Guid) As DPersona Implements IPersonaServicio.BuscarPorId
        Using db As New ContextoBiblioteca
            Dim per = db.Personas.Where(Function(f) f.IdPersona = IdPersona).FirstOrDefault
            If Not per Is Nothing Then
                If per.Activo Then
                    Return New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .FechaUltimaModificacion = per.FechaUltimaModificacion, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .Telefono = "", .Domicilio = "", .Sexo = per.Sexo, .FechaNacimiento = per.FechaNacimiento, .NCarnet = per.NCarnet, .Turno = per.Turno, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Carrera = If(Not per.Carrera Is Nothing, per.Carrera.NombreCarrera, ""), .IdCiudad = per.IdCiudad, .Ciudad = "", .Pais = "", .Departamento = per.Departamento, .Municipio = per.Municipio}
                Else
                    Throw New Exception(GlobalSistema.Eliminado("Persona"))
                End If
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("Persona"))
            End If
        End Using
    End Function

    Function BuscarPorCarnetOIdentificacion(ByVal Id As String) As DPersona Implements IPersonaServicio.BuscarPorCarnetOIdentificacion
        Using db As New ContextoBiblioteca
            Dim persona = (From per In db.Personas Where per.Activo = True And (per.NCarnet = Id Or per.Identificacion = Id) Select New DPersona With {.IdPersona = per.IdPersona, .N = per.N, .FechaRegistro = per.FechaRegistro, .FechaUltimaModificacion = per.FechaUltimaModificacion, .TipoPersona = per.TipoPersona, .TipoIdentificacion = per.TipoIdentificacion, .Identificacion = per.Identificacion, .Nombres = per.Nombres, .Apellidos = per.Apellidos, .Sexo = per.Sexo, .FechaNacimiento = per.FechaNacimiento, .Telefono = per.Telefono, .Domicilio = per.Domicilio, .NCarnet = per.NCarnet, .Turno = per.Turno, .Area = per.Area, .DepartamentoAcademicoEstudiante = per.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = per.DepartamentoAcademicoDocente, .IdCarrera = per.IdCarrera, .Carrera = If(Not per.Carrera Is Nothing, per.Carrera.NombreCarrera, ""), .IdCiudad = per.IdCiudad, .Ciudad = "", .Pais = "", .Departamento = per.Departamento, .Municipio = per.Municipio}).FirstOrDefault
            If Not persona Is Nothing Then
                Return persona
            Else
                Throw New Exception("No se encuentra ningun(a) 'Persona' con este Nº de Carnet o Identificación")
            End If
        End Using
    End Function

End Class
