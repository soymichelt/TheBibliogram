Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Index"
        Return View()
    End Function

    Function About() As ActionResult

        Return View()
    End Function

    Function Contact() As ActionResult
        Return View()
    End Function

    Function Busqueda(Optional ByVal _Titulo As String = "", Optional ByVal _Autor As String = "", Optional ByVal _Institucion As String = "", Optional ByVal _TipoDocumento As String = "", Optional ByVal _TipoRegistro As String = "", Optional ByVal _Signatura As String = "", Optional ByVal _ISBN As String = "", Optional ByVal _OtroCodigo As String = "") As ActionResult
        Using Libr As New LibroServicio.LibroServicioClient
            If _Titulo <> String.Empty Or _Autor <> String.Empty Or _Institucion <> String.Empty Or _TipoDocumento <> String.Empty Or _TipoRegistro <> String.Empty Or _Signatura <> String.Empty Or _ISBN <> String.Empty Or _OtroCodigo <> String.Empty Then
                Dim resultados = (From libro In Libr.Busqueda(New LibroServicio.DLibro With {.TIPODEDOCUMENTO = _TipoDocumento, .TIPOREGISTRO = _TipoRegistro, .TITULO = _Titulo, .SIGNATURA = _Signatura, .AUTOR1 = _Autor, .INSTITUCION = _Institucion, .ISBN = _ISBN, .OTRO_CODIGO = _OtroCodigo}, "") Select New LibroServicio.DLibro With {.ID_LIBRO = libro.ID_LIBRO, .TIPODEDOCUMENTO = libro.TIPODEDOCUMENTO, .TIPOREGISTRO = libro.TIPOREGISTRO, .TITULO = libro.TITULO, .OTRO_TITULO = libro.OTRO_TITULO, .SIGNATURA = libro.SIGNATURA, .OTRO_CODIGO = libro.OTRO_CODIGO, .INSTITUCION = libro.INSTITUCION, .AUTOR1 = libro.AUTOR1, .AUTOR2 = libro.AUTOR2, .AUTOR3 = libro.AUTOR3, .IDIOMA = libro.IDIOMA, .EDITORA = libro.EDITORA, .CIUDAD = libro.CIUDAD, .EDICION = libro.EDICION, .FECHAPUBLICACION = libro.FECHAPUBLICACION, .COLACION = libro.COLACION, .ISBN = libro.ISBN, .TIPOINVESTIGACION = libro.TIPOINVESTIGACION, .TUTOR = libro.TUTOR, .GRADO = libro.GRADO, .ADQUISICION = libro.ADQUISICION, .VALORORIGINAL = libro.VALORORIGINAL, .VALORCORDOBA = libro.VALORCORDOBA, .VALORDOLAR = libro.VALORDOLAR, .NOTAS = libro.NOTAS, .RESUMEN = libro.RESUMEN})
                If resultados.Count > 0 Then
                    Return View(resultados.ToList())
                Else
                    Return View()
                End If
            Else
                Return View()
            End If
        End Using
    End Function

    Function Usuarios() As ActionResult
        Return View()
    End Function

    Function Search() As ActionResult
        Return View()
    End Function

    Function SearchBooksLibrary(Optional ByVal _Titulo As String = "", Optional ByVal _Autor As String = "", Optional ByVal _Institucion As String = "", Optional ByVal _TipoDocumento As String = "", Optional ByVal _TipoRegistro As String = "", Optional ByVal _Signatura As String = "", Optional ByVal _ISBN As String = "", Optional ByVal _OtroCodigo As String = "") As ActionResult
        If Session("_AuthenticationState") Is Nothing Then
            Return RedirectToAction("Signin", "AccountSecurity")
        ElseIf Session("_AuthenticationState").ToString() <> "1" Then
            Return RedirectToAction("Signin", "AccountSecurity")
        End If

        Using Libr As New LibroServicio.LibroServicioClient
            If _Titulo <> String.Empty Or _Autor <> String.Empty Or _Institucion <> String.Empty Or _TipoDocumento <> String.Empty Or _TipoRegistro <> String.Empty Or _Signatura <> String.Empty Or _ISBN <> String.Empty Or _OtroCodigo <> String.Empty Then
                Dim resultados = (From libro In Libr.Busqueda(New LibroServicio.DLibro With {.TIPODEDOCUMENTO = _TipoDocumento, .TIPOREGISTRO = _TipoRegistro, .TITULO = _Titulo, .SIGNATURA = _Signatura, .AUTOR1 = _Autor, .INSTITUCION = _Institucion, .ISBN = _ISBN, .OTRO_CODIGO = _OtroCodigo}, "") Select New LibroServicio.DLibro With {.FechaReg = libro.FechaReg, .FechaMod = libro.FechaMod, .ID_LIBRO = libro.ID_LIBRO, .TIPODEDOCUMENTO = libro.TIPODEDOCUMENTO, .TIPOREGISTRO = libro.TIPOREGISTRO, .TITULO = libro.TITULO, .OTRO_TITULO = libro.OTRO_TITULO, .SIGNATURA = libro.SIGNATURA, .OTRO_CODIGO = libro.OTRO_CODIGO, .INSTITUCION = libro.INSTITUCION, .AUTOR1 = libro.AUTOR1, .AUTOR2 = libro.AUTOR2, .AUTOR3 = libro.AUTOR3, .IDIOMA = libro.IDIOMA, .EDITORA = libro.EDITORA, .CIUDAD = libro.CIUDAD, .EDICION = libro.EDICION, .FECHAPUBLICACION = libro.FECHAPUBLICACION, .COLACION = libro.COLACION, .ISBN = libro.ISBN, .TIPOINVESTIGACION = libro.TIPOINVESTIGACION, .TUTOR = libro.TUTOR, .GRADO = libro.GRADO, .ADQUISICION = libro.ADQUISICION, .VALORORIGINAL = libro.VALORORIGINAL, .VALORCORDOBA = libro.VALORCORDOBA, .VALORDOLAR = libro.VALORDOLAR, .NOTAS = libro.NOTAS, .RESUMEN = libro.RESUMEN, .Norma = libro.Norma, .Estilo = libro.Estilo, .Cita = libro.Cita})
                If resultados.Count > 0 Then
                    Return View(resultados.ToList())
                Else
                    Return View()
                End If
            Else
                Return View()
            End If
        End Using
    End Function

    Function Recomendar() As ActionResult
        If Session("_IdUsuarioSistemaBiblioteca") Is Nothing Then
            Return RedirectToAction("Signin", "AccountSecurity")
        ElseIf Session("_IdUsuarioSistemaBiblioteca").ToString() <> "1" Then
            Return RedirectToAction("Signin", "AccountSecurity")
        End If
        Return View()
    End Function

    <HttpPost>
    Function Recomendar(ByVal Recomendacion As RecomendacionServicio.DRecomendacion) As ActionResult
        Using Aut As New AuthenticationSecurity
            If Not Aut.SessionAutentification() Then

            End If
        End Using
        If Not Recomendacion Is Nothing Then
            If Recomendacion.AreaDirigida Is Nothing Then
                ViewBag("infomessage") = "Necesitas ingresar a quien va dirigida esta recomendación."
                Return View()
            ElseIf Recomendacion.AreaDirigida <> "Ciencias Economicas y Administrativas" And Recomendacion.AreaDirigida <> "Ciencia, Tecnología y Salud" And Recomendacion.AreaDirigida <> "Ciencia, Tecnología y Salud" Then
                ViewBag("infomessage") = "Selecciona un elemento de la lista a quien va dirigido."
                Return View()
            End If
            If Recomendacion.Titulo = "" Then
                ViewBag("infomessage") = "Se requiere que ingreses el título de la bibliografía"
                Return View()
            End If
            If Recomendacion.Autores = "" Then
                ViewBag("infomessage") = "Se requiere que ingreses los nombres de los autores de la bibliografía"
                Return View()
            End If
            Try
                Using Rec As New RecomendacionServicio.RecomendacionServicioClient
                    Rec.Guardar(Recomendacion)
                End Using
            Catch ex As Exception
                ViewBag("infomessage") = ex.Message
                Return View()
            End Try
        End If
        Return RedirectToAction("Recomendaciones", "Home")
    End Function

    Function Recomendaciones(Optional ByVal Inicio As DateTime = Nothing, Optional ByVal Fin As DateTime = Nothing) As ActionResult
        Try
            If Session("_IdUsuarioSistemaBiblioteca") Is Nothing Then
                Return RedirectToAction("Signin", "AccountSecurity")
            ElseIf Session("_IdUsuarioSistemaBiblioteca").ToString() <> "1" Then
                Return RedirectToAction("Signin", "AccountSecurity")
            End If

            Using Rec As New RecomendacionServicio.RecomendacionServicioClient
                Return View(Rec.RecomendacionesUsers(Inicio, Fin, Guid.Parse(Session("_IdUsuario"))))
            End Using
        Catch ex As Exception
            ViewBag("infomessage") = ex.Message
            Return View()
        End Try
    End Function

End Class