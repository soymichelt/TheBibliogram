Imports System.Web.Script.Services

Namespace AppWeb
    Public Class RecomendacionController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Recomendacion

        Function Index() As ActionResult
            Return View()
        End Function

        Function CantidadAnual() As JsonResult
            Using Recomendacion As New RecomendacionServicio.RecomendacionServicioClient
                Dim meses = Recomendacion.CantidadAnual().ToList()
                Dim rows(meses.Count - 1) As Object
                Dim i As Integer = 0
                For Each c In meses
                    rows(i) = New Object() {c.Mes, c.Cantidad}
                    i = i + 1
                Next
                Return New JsonResult With {.Data = rows, .JsonRequestBehavior = JsonRequestBehavior.AllowGet}
            End Using
        End Function

    End Class
End Namespace