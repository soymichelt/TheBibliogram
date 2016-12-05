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

End Class
