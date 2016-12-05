' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "InventarioServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione InventarioServicio.svc o InventarioServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class InventarioServicio
    Implements IInventarioServicio

    Public Sub DoWork() Implements IInventarioServicio.DoWork

    End Sub

    Public Sub Guardar(ByVal Inventario As DInventario) Implements IInventarioServicio.Guardar

    End Sub

    Public Sub Editar(ByVal Inventario As DInventario) Implements IInventarioServicio.Editar

    End Sub

    Public Sub Eliminar(ByVal IdInventario As Guid) Implements IInventarioServicio.Eliminar

    End Sub

    Public Function BuscarPorId(ByVal IdInventario As Guid) As DInventario Implements IInventarioServicio.BuscarPorId
        Using db As New ContextoBiblioteca
            Return (From libr In db.Libros Join inv In db.Inventarios On libr.IdLibro Equals inv.IdLibro Where inv.Activo And inv.IdInventario = IdInventario And libr.Activo Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura}).FirstOrDefault
        End Using
    End Function

    Public Function BuscarPorRegistro(ByVal Registro As String) As DInventario Implements IInventarioServicio.BuscarPorRegistro
        Using db As New ContextoBiblioteca
            Return (From libr In db.Libros Join inv In db.Inventarios On libr.IdLibro Equals inv.IdLibro Where inv.Activo And libr.Activo And inv.Registro = Registro Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura}).FirstOrDefault
        End Using
    End Function

    Public Function Busqueda(ByVal Libro As DLibro, ByVal Registro As String) As List(Of DInventario) Implements IInventarioServicio.Busqueda
        If Libro Is Nothing Then
            Throw New Exception("No se han optenido los parámetros")
        End If
        Using db As New ContextoBiblioteca
            Dim reginv = (From libr In db.Libros Join inv In db.Inventarios On libr.IdLibro Equals inv.IdLibro Where libr.Activo And inv.Activo And libr.TipoDocumento.Contains(Libro.TIPODEDOCUMENTO) And libr.TipoRegistro.Contains(Libro.TIPOREGISTRO) And libr.Titulo.Contains(Libro.TITULO) And libr.Signatura.Contains(Libro.SIGNATURA) And libr.Isbn.Contains(Libro.ISBN) And libr.OtroCodigo.Contains(Libro.OTRO_CODIGO) Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura})
            If Not Libro.Autor1 Is Nothing Then
                If Libro.Autor1.Trim <> "" Then
                    reginv = (From libr In reginv Where libr.TIPOREGISTRO = "PE" And libr.AUTOR1.Contains(Libro.Autor1)).Union(From libr In reginv Where libr.TIPOREGISTRO = "PE" And libr.INSTITUCION.Contains(Libro.Autor2)).Union(From libr In reginv Where libr.TIPOREGISTRO = "PE" And libr.INSTITUCION.Contains(Libro.Autor3))
                End If
            End If
            If Not Libro.Institucion Is Nothing Then
                If Libro.Institucion.Trim <> "" Then
                    reginv = (From libr In reginv Where libr.TIPOREGISTRO = "IN" And libr.INSTITUCION.Contains(Libro.Autor1))
                End If
            End If
            Return reginv.ToList()
        End Using
    End Function

    Public Function CopiasDeLibro(ByVal IdLibro As Guid) As List(Of DInventario) Implements IInventarioServicio.CopiasDeLibro
        Using db As New ContextoBiblioteca
            Dim libro = db.Libros.Where(Function(f) f.IdLibro = IdLibro).FirstOrDefault
            If Not libro Is Nothing Then
                If libro.activo Then
                    Return (From libr In db.Libros Join inv In db.Inventarios On libr.IdLibro Equals inv.IdLibro Where inv.Activo And libr.Activo And libr.IdLibro = IdLibro Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura}).ToList
                Else
                    Throw New Exception(GlobalSistema.Eliminado("Libro"))
                End If
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("Libro"))
            End If
        End Using
    End Function

End Class
