' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "LibroController" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione LibroController.svc o LibroController.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Imports System.IO

Public Class LibroServicio
    Implements ILibroServicio

    Public Function Guardar(ByVal libro As DLibro, ByVal Encabezados As List(Of DDetalle_Encabezado), ByVal Copias As List(Of DInventario), ByVal Imagen As Byte()) As Boolean Implements ILibroServicio.Guardar
        Try
            If libro.TIPODEDOCUMENTO Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Documento"))
            ElseIf libro.TIPODEDOCUMENTO.Trim <> "Colec" And libro.TIPODEDOCUMENTO.Trim <> "Medic" And libro.TIPODEDOCUMENTO.Trim <> "Monog" And libro.TIPODEDOCUMENTO.Trim <> "Autor" And libro.TIPODEDOCUMENTO.Trim <> "Refer" And libro.TIPODEDOCUMENTO.Trim <> "Extrj" Then
                    Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Documento"))
            End If
            If libro.TIPOREGISTRO Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Registro"))
            ElseIf libro.TIPOREGISTRO <> "TI" And libro.TIPOREGISTRO <> "PE" And libro.TIPOREGISTRO <> "IN" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Registro"))
            End If
            If libro.TITULO Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            ElseIf libro.TITULO.Trim = "" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            End If
            If libro.SIGNATURA Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            ElseIf libro.SIGNATURA.Trim = "" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            End If
            Using db As New ContextoBiblioteca
                If Not db.Libros.Where(Function(f) f.Signatura = libro.SIGNATURA).FirstOrDefault Is Nothing Then
                    If libro.SIGNATURA.Trim = "" Then
                        Throw New Exception(GlobalSistema.ExisteRegAtributo("Libro", "Signatura", libro.SIGNATURA))
                    End If
                End If
                libro.ID_LIBRO = Guid.NewGuid
                db.Libros.Add(New Libro With {.IdLibro = libro.ID_LIBRO, .FechaReg = DateTime.Now, .FechaMod = DateTime.Now, .TipoDocumento = libro.TIPODEDOCUMENTO, .TipoRegistro = libro.TIPOREGISTRO, .Titulo = libro.TITULO, .OtroTitulo = libro.OTRO_TITULO, .IdTutor = If(libro.ID_TUTOR <> Guid.Empty, libro.ID_TUTOR, Nothing), .IdInstitucion = If(libro.ID_INSTITUCION <> Guid.Empty, libro.ID_INSTITUCION, Nothing), .Autor1 = libro.AUTOR1, .Autor2 = libro.AUTOR2, .Autor3 = libro.AUTOR3, .IdIdioma = If(libro.ID_IDIOMA <> Guid.Empty, libro.ID_IDIOMA, Nothing), .IdEditor = If(libro.ID_EDITORA <> Guid.Empty, libro.ID_EDITORA, Nothing), .IdCiudad = If(libro.ID_CIUDAD <> Guid.Empty, libro.ID_CIUDAD, Nothing), .Edicion = libro.EDICION, .FechaPublicacion = libro.FECHAPUBLICACION, .Colacion = libro.COLACION, .Isbn = libro.ISBN, .Notas = libro.NOTAS, .TipoInvestigacion = libro.TIPOINVESTIGACION, .IdGrado = If(libro.ID_GRADO <> Guid.Empty, libro.ID_GRADO, Nothing), .Signatura = libro.SIGNATURA, .Adquisicion = libro.ADQUISICION, .ValorOriginal = libro.VALORORIGINAL, .ValorDolar = libro.VALORDOLAR, .ValorCordoba = libro.VALORCORDOBA, .Resumen = libro.RESUMEN, .OtroCodigo = libro.OTRO_CODIGO, .ImagenPerfilUrl = If(Imagen Is Nothing, "", .IdLibro.ToString()), .Norma = libro.Norma, .Estilo = libro.Estilo, .Cita = libro.Cita, .Activo = True, .IdUsuario = libro.IdUsuario})
                If Not Encabezados Is Nothing Then
                    For Each item In Encabezados
                        db.DetallesEncabezados.Add(New DetalleEncabezado With {.IdDetalle = Guid.NewGuid, .IdLibro = libro.ID_LIBRO, .IdEncabezado = item.ID_ENCABEZADO})
                    Next
                End If
                If Not Copias Is Nothing Then
                    If Copias.Count > 0 Then
                        Dim adquisicion = New Adquisicion With {.IdAdquisicion = Guid.NewGuid(), .FechaReg = DateTime.Now, .Observacion = "Inventario Inicial", .Activo = True}
                        db.Adquisiciones.Add(adquisicion)
                        For Each item In Copias
                            db.Inventarios.Add(New Inventario With {.IdInventario = Guid.NewGuid(), .Registro = item.Registro, .IdLibro = libro.ID_LIBRO, .IdAdquisicion = adquisicion.IdAdquisicion, .Prestado = False, .Activo = True})
                        Next
                    End If
                End If
                db.SaveChanges()
                If Not Imagen Is Nothing Then
                    If Imagen.Length > 0 Then
                        Try
                            Dim path = GlobalSistema.PathImageBibliografia & libro.ID_LIBRO.ToString() & ".jpeg"
                            If System.IO.File.Exists(path) Then
                                System.IO.File.Delete(path)
                            End If
                            Dim stream = File.Create(path, Imagen.Length, FileOptions.RandomAccess)
                            Dim writer = New BinaryWriter(stream)
                            writer.Write(Imagen)
                            stream.Close()
                            writer.Close()
                        Catch ex As Exception
                            Throw New Exception("Error, No se pudo guardar la Imagen. Descripción: " & ex.Message)
                        End Try
                    End If
                End If
                Return True
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function Detalle(ByVal IdLibro As Guid) As DLibro Implements ILibroServicio.Detalle
        Using db As New ContextoBiblioteca
            Dim libro = db.Libros.Where(Function(f) f.IdLibro = IdLibro And f.Activo).FirstOrDefault
            If Not libro Is Nothing Then
                Return New DLibro With {.ID_LIBRO = libro.IdLibro, .TIPODEDOCUMENTO = libro.TipoDocumento, .TIPOREGISTRO = libro.TipoRegistro, .TITULO = libro.Titulo, .OTRO_TITULO = libro.OtroTitulo, .ID_TUTOR = libro.IdTutor, .TUTOR = If(Not libro.Tutor Is Nothing, libro.Tutor.Nombres & " " & libro.Tutor.Apellidos, ""), .ID_INSTITUCION = libro.IdInstitucion, .INSTITUCION = If(Not libro.Institucion Is Nothing, libro.Institucion.Descripcion, ""), .AUTOR1 = libro.Autor1, .AUTOR2 = libro.Autor2, .AUTOR3 = libro.Autor3, .ID_IDIOMA = libro.IdIdioma, .IDIOMA = If(Not libro.Idioma Is Nothing, libro.Idioma.Descripcion, ""), .ID_EDITORA = libro.IdEditor, .EDITORA = If(Not libro.Editor Is Nothing, libro.Editor.Descripcion, ""), .ID_CIUDAD = libro.IdCiudad, .CIUDAD = If(Not libro.Ciudad Is Nothing, libro.Ciudad.Descripcion & ", " & libro.Ciudad.Pais.Descripcion, ""), .EDICION = libro.Edicion, .FECHAPUBLICACION = libro.FechaPublicacion, .COLACION = libro.Colacion, .ISBN = libro.Isbn, .NOTAS = libro.Notas, .TIPOINVESTIGACION = libro.TipoInvestigacion, .ID_GRADO = libro.IdGrado, .GRADO = If(Not libro.Grado Is Nothing, libro.Grado.Descripcion, ""), .SIGNATURA = libro.Signatura, .VALORORIGINAL = libro.ValorOriginal, .VALORDOLAR = libro.ValorDolar, .VALORCORDOBA = libro.ValorCordoba, .RESUMEN = libro.Resumen, .OTRO_CODIGO = libro.OtroCodigo}
            Else
                Return Nothing
            End If
        End Using
    End Function

    Public Function Editar(ByVal libro As DLibro, ByVal Encabezados As List(Of DDetalle_Encabezado), ByVal Copias As List(Of DInventario), ByVal Imagen As Byte()) As Boolean Implements ILibroServicio.Editar
        Try
            'validaciones
            If libro.TIPODEDOCUMENTO Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Documento"))
            ElseIf libro.TIPODEDOCUMENTO.Trim <> "Colec" And libro.TIPODEDOCUMENTO.Trim <> "Medic" And libro.TIPODEDOCUMENTO.Trim <> "Monog" And libro.TIPODEDOCUMENTO.Trim <> "Autor" And libro.TIPODEDOCUMENTO.Trim <> "Refer" And libro.TIPODEDOCUMENTO.Trim <> "Extrj" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Documento"))
            End If
            If libro.TIPOREGISTRO Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Registro"))
            ElseIf libro.TIPOREGISTRO <> "TI" And libro.TIPOREGISTRO <> "PE" And libro.TIPOREGISTRO <> "IN" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Tipo de Registro"))
            End If
            If libro.TITULO Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            ElseIf libro.TITULO.Trim = "" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            End If
            If libro.SIGNATURA Is Nothing Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            ElseIf libro.SIGNATURA.Trim = "" Then
                Throw New Exception(GlobalSistema.IngresarAtributo("Título de la Bibliografía"))
            End If
            'editar
            Using db As New ContextoBiblioteca
                Dim L = db.Libros.Where(Function(f) f.IdLibro = libro.ID_LIBRO).FirstOrDefault()
                If Not L Is Nothing Then
                    With L
                        .FechaReg = DateTime.Now : .FechaMod = DateTime.Now : .TipoDocumento = libro.TIPODEDOCUMENTO : .TipoRegistro = libro.TIPOREGISTRO : .Titulo = libro.TITULO : .OtroTitulo = libro.OTRO_TITULO : .IdTutor = If(libro.ID_TUTOR <> Guid.Empty, libro.ID_TUTOR, Nothing) : .IdInstitucion = If(libro.ID_INSTITUCION <> Guid.Empty, libro.ID_INSTITUCION, Nothing) : .Autor1 = libro.AUTOR1 : .Autor2 = libro.AUTOR2 : .Autor3 = libro.AUTOR3 : .IdIdioma = If(libro.ID_IDIOMA <> Guid.Empty, libro.ID_IDIOMA, Nothing) : .IdEditor = If(libro.ID_EDITORA <> Guid.Empty, libro.ID_EDITORA, Nothing) : .IdCiudad = If(libro.ID_CIUDAD <> Guid.Empty, libro.ID_CIUDAD, Nothing) : .Edicion = libro.EDICION : .FechaPublicacion = libro.FECHAPUBLICACION : .Colacion = libro.COLACION : .Isbn = libro.ISBN : .Notas = libro.NOTAS : .TipoInvestigacion = libro.TIPOINVESTIGACION : .IdGrado = If(libro.ID_GRADO <> Guid.Empty, libro.ID_GRADO, Nothing) : .Signatura = libro.SIGNATURA : .Adquisicion = libro.ADQUISICION : .ValorOriginal = libro.VALORORIGINAL : .ValorDolar = libro.VALORDOLAR : .ValorCordoba = libro.VALORCORDOBA : .Resumen = libro.RESUMEN : .OtroCodigo = libro.OTRO_CODIGO : .ImagenPerfilUrl = If(Imagen Is Nothing, "", .IdLibro.ToString()) : .Norma = libro.Norma : .Estilo = libro.Estilo : .Cita = libro.Cita : .Activo = True : .IdUsuario = libro.IdUsuario
                    End With
                    db.Entry(L).State = Entity.EntityState.Modified
                    db.SaveChanges()
                    If Not Imagen Is Nothing Then
                        If Imagen.Length > 0 Then
                            Try
                                Dim path = GlobalSistema.PathImageBibliografia & libro.ID_LIBRO.ToString() & ".jpeg"
                                If System.IO.File.Exists(path) Then
                                    System.IO.File.Delete(path)
                                End If
                                Dim stream = File.Create(path, Imagen.Length, FileOptions.RandomAccess)
                                Dim writer = New BinaryWriter(stream)
                                writer.Write(Imagen)
                                stream.Close()
                                writer.Close()
                            Catch ex As Exception
                                Throw New Exception("Error, No se pudo guardar la Imagen. Descripción: " & ex.Message)
                            End Try
                        End If
                    End If
                    Return True
                Else
                    Throw New ArgumentException(GlobalSistema.NoEncontrado("Bibliografía"))
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function Eliminar(ByVal IdLibro As Guid) As Boolean Implements ILibroServicio.Eliminar
        Using db As New ContextoBiblioteca
            Dim L = db.Libros.Where(Function(f) f.IdLibro = IdLibro).FirstOrDefault()
            If Not L Is Nothing Then
                L.Activo = False
                db.Entry(L).State = Entity.EntityState.Modified
                db.SaveChanges()
                Return True
            Else
                Throw New ArgumentException(GlobalSistema.NoEncontrado("Bibliografía"))
            End If
        End Using
    End Function

    Public Function BuscarId(ByVal IdLibro As Guid) As DLibro Implements ILibroServicio.BuscarId
        Using db As New ContextoBiblioteca
            Dim libro = db.Libros.Where(Function(f) f.IdLibro = IdLibro).FirstOrDefault
            If Not libro Is Nothing Then
                Return New DLibro With {.ID_LIBRO = libro.IdLibro, .FechaReg = libro.FechaReg, .FechaMod = libro.FechaMod, .TIPODEDOCUMENTO = libro.TipoDocumento, .TIPOREGISTRO = libro.TipoRegistro, .TITULO = libro.Titulo, .OTRO_TITULO = libro.OtroCodigo, .ID_TUTOR = libro.IdTutor, .TUTOR = If(Not libro.Tutor Is Nothing, libro.Tutor.Nombres & " " & libro.Tutor.Apellidos, ""), .ID_INSTITUCION = libro.IdInstitucion, .INSTITUCION = If(Not libro.Institucion Is Nothing, libro.Institucion.Descripcion, ""), .AUTOR1 = libro.Autor1, .AUTOR2 = libro.Autor2, .AUTOR3 = libro.Autor3, .ID_IDIOMA = libro.IdIdioma, .IDIOMA = If(Not libro.Idioma Is Nothing, libro.Idioma.Descripcion, ""), .ID_EDITORA = libro.IdEditor, .EDITORA = If(Not libro.Editor Is Nothing, libro.Editor.Descripcion, ""), .ID_CIUDAD = libro.IdCiudad, .CIUDAD = If(Not libro.Ciudad Is Nothing, libro.Ciudad.Descripcion & ", " & libro.Ciudad.Pais.Descripcion, ""), .EDICION = libro.Edicion, .FECHAPUBLICACION = libro.FechaPublicacion, .COLACION = libro.Colacion, .ISBN = libro.Isbn, .NOTAS = libro.Notas, .TIPOINVESTIGACION = libro.TipoInvestigacion, .ID_GRADO = libro.IdGrado, .GRADO = If(Not libro.Grado Is Nothing, libro.Grado.Descripcion, ""), .SIGNATURA = libro.Signatura, .VALORORIGINAL = libro.ValorOriginal, .VALORDOLAR = libro.ValorDolar, .VALORCORDOBA = libro.ValorCordoba, .RESUMEN = libro.Resumen, .OTRO_CODIGO = libro.OtroCodigo, .Norma = libro.Norma, .Estilo = libro.Estilo, .Cita = libro.Cita, .ImagenPerfilUrl = libro.ImagenPerfilUrl, .Activo = libro.Activo, .IdUsuario = libro.IdUsuario}
            Else
                Return Nothing
            End If
        End Using
    End Function

    Public Function BuscarEncabezadoPorLibro(ByVal IdLibro As Guid) As List(Of DEncabezado) Implements ILibroServicio.BuscarEncabezadoPorLibro
        Try
            Using db As New ContextoBiblioteca
                Return (From enc In db.Encabezados Join det In db.DetallesEncabezados On enc.IdEncabezado Equals det.IdEncabezado Where det.IdLibro = IdLibro Select New DEncabezado With {.IdEncabezado = enc.IdEncabezado, .Descripcion = enc.Descripcion}).ToList()
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function BuscarInventarioPorLibro(ByVal IdLibro As Guid) As List(Of DInventario) Implements ILibroServicio.BuscarCopiaPorLibro
        Try
            Using db As New ContextoBiblioteca
                Return (From inv In db.Inventarios Join libr In db.Libros On inv.IdLibro Equals libr.IdLibro Where libr.IdLibro = IdLibro Select New DInventario With {.IdInventario = inv.IdInventario, .Registro = inv.Registro, .IdLibro = libr.IdLibro, .Prestado = inv.Prestado, .Activo = inv.Activo, .TipoDocumento = libr.TipoDocumento, .TipoRegistro = libr.TipoRegistro, .Titulo = libr.Titulo, .OtroTitulo = libr.OtroTitulo, .Institucion = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .Autor1 = libr.Autor1, .Autor2 = libr.Autor2, .Autor3 = libr.Autor3, .Idioma = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .Editor = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .Edicion = libr.Edicion, .Isbn = libr.Isbn, .Signatura = libr.Signatura}).ToList()
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function BuscarSigTop(ByVal Signatura As String) As DLibro Implements ILibroServicio.BuscarSigTop
        Using db As New ContextoBiblioteca
            Dim libro = db.Libros.Where(Function(f) f.Signatura = Signatura).FirstOrDefault
            If Not libro Is Nothing Then
                Return New DLibro With {.ID_LIBRO = libro.IdLibro, .TIPODEDOCUMENTO = libro.TipoDocumento, .TIPOREGISTRO = libro.TipoRegistro, .TITULO = libro.Titulo, .OTRO_TITULO = libro.OtroTitulo, .ID_TUTOR = libro.IdTutor, .TUTOR = If(Not libro.Tutor Is Nothing, libro.Tutor.Nombres & " " & libro.Tutor.Apellidos, ""), .ID_INSTITUCION = libro.IdInstitucion, .INSTITUCION = If(Not libro.Institucion Is Nothing, libro.Institucion.Descripcion, ""), .AUTOR1 = libro.Autor1, .AUTOR2 = libro.Autor2, .AUTOR3 = libro.Autor3, .ID_IDIOMA = libro.IdIdioma, .IDIOMA = If(Not libro.Idioma Is Nothing, libro.Idioma.Descripcion, ""), .ID_EDITORA = libro.IdEditor, .EDITORA = If(Not libro.Editor Is Nothing, libro.Editor.Descripcion, ""), .ID_CIUDAD = libro.IdCiudad, .CIUDAD = If(Not libro.Ciudad Is Nothing, libro.Ciudad.Descripcion & ", " & libro.Ciudad.Pais.Descripcion, ""), .EDICION = libro.Edicion, .FECHAPUBLICACION = libro.FechaPublicacion, .COLACION = libro.Colacion, .ISBN = libro.Isbn, .NOTAS = libro.Notas, .TIPOINVESTIGACION = libro.TipoInvestigacion, .ID_GRADO = libro.IdGrado, .GRADO = If(Not libro.Grado Is Nothing, libro.Grado.Descripcion, ""), .SIGNATURA = libro.Signatura, .VALORORIGINAL = libro.ValorOriginal, .VALORDOLAR = libro.ValorDolar, .VALORCORDOBA = libro.ValorCordoba, .RESUMEN = libro.Resumen, .OTRO_CODIGO = libro.OtroCodigo}
            Else
                Return Nothing
            End If
        End Using
    End Function

    Public Function Lista() As List(Of DLibro) Implements ILibroServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From libro In db.Libros Select New DLibro With {.ID_LIBRO = libro.IdLibro, .TIPODEDOCUMENTO = libro.TipoDocumento, .TIPOREGISTRO = libro.TipoRegistro, .TITULO = libro.Titulo, .OTRO_TITULO = libro.OtroTitulo, .ID_TUTOR = libro.IdTutor, .TUTOR = If(Not libro.Tutor Is Nothing, libro.Tutor.Nombres & " " & libro.Tutor.Apellidos, ""), .ID_INSTITUCION = libro.IdInstitucion, .INSTITUCION = If(Not libro.Institucion Is Nothing, libro.Institucion.Descripcion, ""), .AUTOR1 = libro.Autor1, .AUTOR2 = libro.Autor2, .AUTOR3 = libro.Autor3, .ID_IDIOMA = libro.IdIdioma, .IDIOMA = If(Not libro.Idioma Is Nothing, libro.Idioma.Descripcion, ""), .ID_EDITORA = libro.IdEditor, .EDITORA = If(Not libro.Editor Is Nothing, libro.Editor.Descripcion, ""), .ID_CIUDAD = libro.IdCiudad, .CIUDAD = If(Not libro.Ciudad Is Nothing, libro.Ciudad.Descripcion & ", " & libro.Ciudad.Pais.Descripcion, ""), .EDICION = libro.Edicion, .FECHAPUBLICACION = libro.FechaPublicacion, .COLACION = libro.Colacion, .ISBN = libro.Isbn, .NOTAS = libro.Notas, .TIPOINVESTIGACION = libro.TipoInvestigacion, .ID_GRADO = libro.IdGrado, .GRADO = If(Not libro.Grado Is Nothing, libro.Grado.Descripcion, ""), .SIGNATURA = libro.Signatura, .VALORORIGINAL = libro.ValorOriginal, .VALORDOLAR = libro.ValorDolar, .VALORCORDOBA = libro.ValorCordoba, .RESUMEN = libro.Resumen, .OTRO_CODIGO = libro.OtroCodigo}).ToList()
        End Using
    End Function

    Public Function Busqueda(ByVal Libro As DLibro, ByVal Encabezado As String) As List(Of DLibro) Implements ILibroServicio.Busqueda
        If Libro Is Nothing Then
            Throw New Exception("No se han optenido los parámetros")
        End If
        Using db As New ContextoBiblioteca
            Dim reglib = (From libr In db.Libros Where libr.TipoDocumento.Contains(Libro.TIPODEDOCUMENTO) And libr.TipoRegistro.Contains(Libro.TIPOREGISTRO) And libr.Titulo.Contains(Libro.TITULO) And libr.Signatura.Contains(Libro.SIGNATURA) And libr.Isbn.Contains(Libro.ISBN) And libr.OtroCodigo.Contains(Libro.OTRO_CODIGO) Select New DLibro With {.FechaReg = libr.FechaReg, .FechaMod = libr.FechaMod, .ID_LIBRO = libr.IdLibro, .TIPODEDOCUMENTO = libr.TipoDocumento, .TIPOREGISTRO = libr.TipoRegistro, .TITULO = libr.Titulo, .OTRO_TITULO = libr.OtroTitulo, .ID_TUTOR = libr.IdTutor, .TUTOR = If(Not libr.Tutor Is Nothing, libr.Tutor.Nombres & " " & libr.Tutor.Apellidos, ""), .ID_INSTITUCION = libr.IdInstitucion, .INSTITUCION = If(Not libr.Institucion Is Nothing, libr.Institucion.Descripcion, ""), .AUTOR1 = libr.Autor1, .AUTOR2 = libr.Autor2, .AUTOR3 = libr.Autor3, .ID_IDIOMA = libr.IdIdioma, .IDIOMA = If(Not libr.Idioma Is Nothing, libr.Idioma.Descripcion, ""), .ID_EDITORA = libr.IdEditor, .EDITORA = If(Not libr.Editor Is Nothing, libr.Editor.Descripcion, ""), .ID_CIUDAD = libr.IdCiudad, .CIUDAD = If(Not libr.Ciudad Is Nothing, libr.Ciudad.Descripcion & ", " & libr.Ciudad.Pais.Descripcion, ""), .EDICION = libr.Edicion, .FECHAPUBLICACION = libr.FechaPublicacion, .COLACION = libr.Colacion, .ISBN = libr.Isbn, .NOTAS = libr.Notas, .TIPOINVESTIGACION = libr.TipoInvestigacion, .ID_GRADO = libr.IdGrado, .GRADO = If(Not libr.Grado Is Nothing, libr.Grado.Descripcion, ""), .SIGNATURA = libr.Signatura, .VALORORIGINAL = libr.ValorOriginal, .VALORDOLAR = libr.ValorDolar, .VALORCORDOBA = libr.ValorCordoba, .RESUMEN = libr.Resumen, .OTRO_CODIGO = libr.OtroCodigo})
            If Not Libro.AUTOR1 Is Nothing Then
                If Libro.AUTOR1.Trim <> "" Then
                    reglib = (From libr In reglib Where libr.TIPOREGISTRO = "PE" And libr.AUTOR1.Contains(Libro.AUTOR1)).Union(From libr In reglib Where libr.TIPOREGISTRO = "PE" And libr.INSTITUCION.Contains(Libro.AUTOR2)).Union(From libr In reglib Where libr.TIPOREGISTRO = "PE" And libr.INSTITUCION.Contains(Libro.AUTOR3))
                End If
            End If
            If Not Libro.INSTITUCION Is Nothing Then
                If Libro.INSTITUCION.Trim <> "" Then
                    reglib = (From libr In reglib Where libr.TIPOREGISTRO = "IN" And libr.INSTITUCION.Contains(Libro.AUTOR1))
                End If
            End If
            'If Not Encabezado Is Nothing Then
            '    If Encabezado.Trim <> "" Then

            '    End If
            'End If
            Return reglib.ToList()
        End Using
    End Function

    Public Function BuscarImagen(ByVal Url As String) As Byte() Implements ILibroServicio.BuscarImagen
        Try
            Url = GlobalSistema.PathImageBibliografia & Url & ".jpeg"
            If File.Exists(Url) Then
                Using db As New ContextoBiblioteca
                    Using Stream As New FileStream(Url, FileMode.Open, FileAccess.Read)
                        Using br As New BinaryReader(Stream)
                            Dim ImagenByte = br.ReadBytes(CInt(Stream.Length))
                            Stream.Close()
                            br.Close()
                            Return ImagenByte
                        End Using
                    End Using
                End Using
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function


End Class