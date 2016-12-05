' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "PrestamoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PrestamoServicio.svc o PrestamoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class PrestamoServicio
    Implements IPrestamoServicio

    Public Sub DoWork() Implements IPrestamoServicio.DoWork

    End Sub

    Public Sub Guardar(ByVal Prestamo As DPrestamo, ByVal BibliografiaPrestar As List(Of DInventario)) Implements IPrestamoServicio.Guardar
        If Prestamo Is Nothing Then
            Throw New Exception("Ingresar los valores del prestamo.")
        End If
        If Prestamo.Tipo Is Nothing Then
            Throw New Exception("Ingresar el Tipo de Préstamo.")
        Else
            If Prestamo.Tipo.Trim <> "Interno" And Prestamo.Tipo.Trim <> "Externo" Then
                Throw New Exception("El tipo de préstamo debe ser 'Interno' o 'Externo'.")
            End If
        End If
        If BibliografiaPrestar.Count = 0 Then
            Throw New Exception("No se puede crear préstamo sin la lista de copias bibliográficas.")
        End If
        Using db As New ContextoBiblioteca
            Dim persona = db.Personas.Where(Function(f) f.IdPersona = Prestamo.IdPersona And f.Activo).FirstOrDefault
            If Not persona Is Nothing Then
                Prestamo.IdPrestamo = Guid.NewGuid()
                db.Prestamos.Add(New Prestamo With {.IdPrestamo = Prestamo.IdPrestamo, .FechaPrestamo = Prestamo.FechaPrestamo, .Tipo = Prestamo.Tipo, .Observacion = Prestamo.Observacion, .IdPersona = Prestamo.IdPersona, .Activo = True, .TipoPersona = persona.TipoPersona, .TipoIdentificacion = persona.TipoIdentificacion, .Identificacion = persona.TipoIdentificacion, .Sexo = persona.Sexo, .Edad = DateDiff(DateInterval.Year, persona.FechaNacimiento, DateTime.Parse(DateTime.Now.ToShortDateString())), .NCarnet = persona.NCarnet, .Turno = persona.Turno, .Area = persona.Area, .DepartamentoAcademicoEstudiante = persona.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = persona.DepartamentoAcademicoDocente, .Carrera = If(Not persona.Carrera Is Nothing, persona.Carrera.NombreCarrera, ""), .Departamento = persona.Departamento, .Municipio = persona.Municipio})
                Dim detalle As Inventario
                For Each d In BibliografiaPrestar
                    detalle = db.Inventarios.Where(Function(f) f.Activo And f.IdInventario = d.IdInventario).FirstOrDefault()
                    If Not detalle Is Nothing Then
                        If Not detalle.Prestado Then
                            detalle.Prestado = True
                            db.DetallesPrestamos.Add(New DetallePrestamo With {.IdDetallePrestamo = Guid.NewGuid, .IdInventario = d.IdInventario, .IdPrestamo = Prestamo.IdPrestamo})
                        Else
                            Throw New Exception("La Copia Bibliográfica: '" & detalle.Registro & "' se encuentra prestada actualmente.")
                        End If
                    Else
                        Throw New Exception(GlobalSistema.NoEncontrado(If(Not d.Registro Is Nothing, d.Registro, "Copia Bibliográfica")))
                    End If
                Next
                db.SaveChanges()
            Else
                Throw New Exception("No se encuentra esta persona en la base de datos.")
            End If
        End Using
    End Sub

    Public Sub Editar(ByVal Prestamo As DPrestamo, ByVal BibliografiaPrestar As List(Of DInventario)) Implements IPrestamoServicio.Editar

    End Sub

    Public Sub Eliminar(ByVal IdPrestamo As Guid) Implements IPrestamoServicio.Eliminar

    End Sub

    Public Function Lista(ByVal Prestamo As DPrestamo, ByVal Inicio As DateTime, ByVal Final As DateTime, ByVal EdadMinima As Integer, ByVal EdadMaxima As Integer) As List(Of DPrestamo) Implements IPrestamoServicio.Lista
        If Not Prestamo Is Nothing Then
            Using db As New ContextoBiblioteca
                Dim Listado = (From pre In db.Prestamos Where pre.Activo And (pre.FechaPrestamo >= Inicio And pre.FechaPrestamo <= Final) And pre.NCarnet.Contains(If(Not Prestamo.NCarnet Is Nothing, pre.NCarnet, "")) And pre.Identificacion.Contains(If(Not Prestamo.Identificacion Is Nothing, pre.Identificacion, "")) And pre.Turno.Contains(If(Not Prestamo.Turno Is Nothing, pre.Turno, "")) And pre.Area.Contains(If(Not Prestamo.Area Is Nothing, pre.Area, "")) And pre.DepartamentoAcademicoEstudiante.Contains(If(Not Prestamo.DepartamentoAcademicoEstudiante Is Nothing, pre.DepartamentoAcademicoEstudiante, "")) And pre.DepartamentoAcademicoDocente.Contains(If(Not Prestamo.DepartamentoAcademicoDocente Is Nothing, pre.DepartamentoAcademicoDocente, "")) And pre.Carrera.Contains(If(Not Prestamo.Carrera Is Nothing, pre.Carrera, "")) Select New DPrestamo With {.IdPrestamo = pre.IdPrestamo, .N = pre.N, .FechaPrestamo = pre.FechaPrestamo, .Tipo = pre.Tipo, .Observacion = pre.Observacion, .Activo = pre.Activo, .TipoPersona = pre.TipoPersona, .TipoIdentificacion = pre.TipoIdentificacion, .Identificacion = pre.Identificacion, .Sexo = pre.Sexo, .Edad = pre.Edad, .NCarnet = pre.NCarnet, .Turno = pre.Turno, .Area = pre.Area, .DepartamentoAcademicoEstudiante = pre.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = pre.DepartamentoAcademicoDocente, .Carrera = pre.Carrera})
                If EdadMinima > 0 And EdadMaxima > 0 Then
                    If EdadMinima <= EdadMaxima Then
                        Listado = Listado.Where(Function(f) f.Edad >= EdadMinima And f.Edad <= EdadMaxima)
                    Else
                        Throw New Exception("La edad máxima debe ser mayor que la edad mínima para optener un listado con rango de edades.")
                    End If
                End If
                Return Listado
            End Using
        Else
            Throw New Exception("Ingresar los parámetros")
        End If
    End Function

    Public Function Busqueda(ByVal Inicio As Date, ByVal Final As Date, ByVal Persona As String) As List(Of DPrestamo) Implements IPrestamoServicio.Busqueda
        Using db As New ContextoBiblioteca
            Return (From pre In db.Prestamos Where pre.Activo And (pre.FechaPrestamo >= Inicio And pre.FechaPrestamo <= Final) And (pre.Persona.Nombres & " " & pre.Persona.Apellidos).Contains(Persona) Select New DPrestamo With {.IdPrestamo = pre.IdPrestamo, .N = pre.N, .FechaPrestamo = pre.FechaPrestamo, .Tipo = pre.Tipo, .Observacion = pre.Observacion, .NombrePersona = pre.Persona.Nombres & " " & pre.Persona.Apellidos, .Activo = pre.Activo, .TipoPersona = pre.TipoPersona, .TipoIdentificacion = pre.TipoIdentificacion, .Identificacion = pre.Identificacion, .Sexo = pre.Sexo, .Edad = pre.Edad, .NCarnet = pre.NCarnet, .Turno = pre.Turno, .Area = pre.Area, .DepartamentoAcademicoEstudiante = pre.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = pre.DepartamentoAcademicoDocente, .Carrera = pre.Carrera, .Departamento = pre.Departamento, .Municipio = pre.Municipio}).ToList()
        End Using
    End Function

    Public Function BuscarPorId(ByVal IdPrestamo As Guid) As DPrestamo Implements IPrestamoServicio.BuscarPorId
        Return Nothing
    End Function

    Public Function BuscarPorN(ByVal N As Integer) As DPrestamo Implements IPrestamoServicio.BuscarPorN
        Using db As New ContextoBiblioteca
            Return (From pre In db.Prestamos Where pre.N = N And pre.Activo Select New DPrestamo With {.IdPrestamo = pre.IdPrestamo, .N = pre.N, .FechaPrestamo = pre.FechaPrestamo, .Tipo = pre.Tipo, .Observacion = pre.Observacion, .Activo = pre.Activo, .TipoPersona = pre.TipoPersona, .TipoIdentificacion = pre.TipoIdentificacion, .Identificacion = pre.Identificacion, .Sexo = pre.Sexo, .Edad = pre.Edad, .NCarnet = pre.NCarnet, .Turno = pre.Turno, .Area = pre.Area, .DepartamentoAcademicoEstudiante = pre.DepartamentoAcademicoEstudiante, .DepartamentoAcademicoDocente = pre.DepartamentoAcademicoDocente, .Carrera = pre.Carrera}).FirstOrDefault
        End Using
    End Function

    Public Function ListadoDetalle(ByVal IdPrestamo As Guid) As List(Of DDetallePrestamo) Implements IPrestamoServicio.ListadoDetalle
        Using db As New ContextoBiblioteca
            Return (From det In db.DetallesPrestamos Join inv In db.Inventarios On det.IdInventario Equals inv.IdInventario Join libr In db.Libros On inv.IdLibro Equals libr.IdLibro Where det.IdPrestamo = det.IdPrestamo Select New DDetallePrestamo With {.IdDetallePrestamo = det.IdDetallePrestamo, .IdInventario = det.IdInventario, .Registro = inv.Registro, .IdPrestamo = det.IdPrestamo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Signatura = libr.Signatura, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Isbn = libr.Isbn, .Edicion = libr.Edicion}).ToList()
        End Using
    End Function

    Public Function BuscarPorRegistro(ByVal Registro As String) As DInventario Implements IPrestamoServicio.BuscarPorRegistro
        Using db As New ContextoBiblioteca
            Return (From libr In db.Libros Join inv In db.Inventarios On libr.IdLibro Equals inv.IdLibro Where inv.Activo And libr.Activo And inv.Registro = Registro Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura}).FirstOrDefault
        End Using
    End Function

    Public Sub Entrega(ByVal IdInventario As Guid) Implements IPrestamoServicio.Entregar
        Using db As New ContextoBiblioteca
            Dim inv = db.Inventarios.Where(Function(f) f.IdInventario = IdInventario).FirstOrDefault
            If Not inv Is Nothing Then
                inv.Prestado = False
                db.Entry(inv).State = Entity.EntityState.Modified
                db.SaveChanges()
            End If
        End Using
    End Sub

    Public Function Solvencia() As List(Of DInventario) Implements IPrestamoServicio.Solvencia
        Using db As New ContextoBiblioteca
            Return (From libr In db.Libros Join inv In db.Inventarios On libr.IdLibro Equals inv.IdLibro Where inv.Prestado = True Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura}).ToList()
        End Using
    End Function


End Class
