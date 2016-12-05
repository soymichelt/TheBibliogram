Namespace CapaPresentacionAppWebMvc
    Public Class AccountSecurityController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /AccountAdmin

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Signin() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken()>
        Public Function Signin(ByVal Usuario As String, ByVal Password As String) As ActionResult
            Try
                If Usuario.Trim() <> "" And Password.Trim() <> "" Then
                    Using Account As New AccountServicio.AccountServicioClient
                        Dim UsuarioR = Account.Signin(New AccountServicio.DUsuario With {.Email = Usuario, .Password = Password})
                        If Not UsuarioR Is Nothing Then
                            Session("_AuthenticationState") = "1"
                            Session("_IdUsuario") = UsuarioR.IdUsuario.ToString()
                            Session("Name") = UsuarioR.Nombres.Split(" ")(0).ToString() & " " & UsuarioR.Apellidos.Split(" ")(0).ToString()
                            Session("Email") = UsuarioR.Email
                            Session("Rol") = UsuarioR.Rol.ToString()
                            Return RedirectToAction("SearchBooksLibrary", "Home")
                        Else
                            ViewData("Mensaje") = "El nombre de usuario y la contraseña que ingresaste no coinciden con nuestros registros. Por favor, revisa e inténtalo de nuevo."
                        End If
                    End Using
                Else
                    ViewData("Mensaje") = "El nombre de usuario y la contraseña que ingresaste no coinciden con nuestros registros. Por favor, revisa e inténtalo de nuevo."
                End If
            Catch ex As Exception
                ViewData("Mensaje") = ex.Message
            End Try
            Response.Redirect(Request.Url.ToString(), False)
            Return View()
        End Function

        <HttpGet()>
        Public Function Signout()
            Session.Remove("_IdUsuarioSistemaBiblioteca")
            Session.Remove("Name")
            Session.Remove("Email")
            Session.Remove("Rol")
            Return RedirectToAction("Signin", "AccountSecurity")
        End Function

        Public Function Register() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Public Function Register(ByVal Usuario As AccountServicio.DUsuario) As ActionResult
            Try
                If Not Usuario Is Nothing Then
                    'validaciones
                    If Not Usuario.Nombres Is Nothing Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' son necesarios sus 'Nombres'.")
                    ElseIf Usuario.Nombres.Trim <> "" Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' son necesarios sus 'Nombres'.")
                    End If
                    If Not Usuario.Apellidos Is Nothing Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' son necesarios sus 'Apellidos'.")
                    ElseIf Usuario.Apellidos.Trim <> "" Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' son necesarios sus 'Apellidos'.")
                    End If
                    If Usuario.FechaNacimiento.Year < 1900 Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' es necesario ingresar una 'Fecha de Nacimiento' mayor a 31/12/1899.")
                    End If
                    If Not Usuario.Email Is Nothing Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' es necesario su 'E-mail'.")
                    ElseIf Usuario.Email.Trim <> "" Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' es necesario su 'E-mail'.")
                    End If
                    If Not Usuario.Password Is Nothing Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' es necesario su 'Password'.")
                    ElseIf Usuario.Password.Trim <> "" Then
                        ViewData("Mensaje") = ("Para registrar un 'Usuario' es necesario su 'Password'.")
                    End If

                    'registrar
                    Using Account As New AccountServicio.AccountServicioClient
                        Dim Users = Account.Register(Usuario:=Usuario)
                        Return RedirectToAction("Signin", "AccountSecurity")
                    End Using
                Else
                    ViewData("Mensaje") = "No se ingresaron los datos del Usuario."
                End If
            Catch ex As Exception
                ViewData("Mensaje") = ex.Message
            End Try
            'Response.Redirect(Request.Url.ToString(), False)
            Return View()
        End Function
    End Class
End Namespace