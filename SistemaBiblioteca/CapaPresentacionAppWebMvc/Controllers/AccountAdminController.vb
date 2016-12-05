Namespace CapaPresentacionAppWebMvc
    Public Class AccountAdminController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /AccountAdmin

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Signin() As ActionResult
            ViewData("Title") = "Iniciar Sesión"
            Return View()
        End Function

        <HttpPost()>
        Public Function Signout()
            Return View()
        End Function

        <HttpGet>
        Public Function Register() As ActionResult
            Return View()
        End Function

    End Class
End Namespace