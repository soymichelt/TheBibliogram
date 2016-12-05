Namespace AppWeb
    Public Class PrestamoFondoBibliograficoController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /PrestamoFondoBibliografico

        Function Departamento() As ActionResult
            Return View()
        End Function

        Function TablaResultados(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal Departamento As Byte) As JsonResult
            Using Prestamo As New InformePrestamoServicio.InformePrestamoServicioClient
                Dim meses = Prestamo.PrestamosPorDepartamento(Anual, Modalidad, Departamento).ToList()
                Dim rows(meses.Count - 1) As Object
                Dim i As Integer = 0
                For Each c In meses
                    rows(i) = New Object() {c.Mes, c.C1, c.C2, c.C3}
                    i = i + 1
                Next
                Return New JsonResult With {.Data = rows, .JsonRequestBehavior = JsonRequestBehavior.AllowGet}
            End Using
        End Function

        Function Carrera() As ActionResult
            Return View()
        End Function

        Function TablaResultadosCarrera(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal Carrera As Guid) As JsonResult
            Using Prestamo As New InformePrestamoServicio.InformePrestamoServicioClient
                Dim meses = Prestamo.PrestamosPorCarrera(Anual, Modalidad, Carrera).ToList()
                Dim rows(meses.Count - 1) As Object
                Dim i As Integer = 0
                For Each c In meses
                    rows(i) = New Object() {c.Mes, c.C1, c.C2, c.C3}
                    i = i + 1
                Next
                Return New JsonResult With {.Data = rows, .JsonRequestBehavior = JsonRequestBehavior.AllowGet}
            End Using
        End Function

        Function TipoPersona() As ActionResult
            Return View()
        End Function

        Function TablaResultadosTipoPersona(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal TipoPersona As Byte) As JsonResult
            Using Prestamo As New InformePrestamoServicio.InformePrestamoServicioClient
                Dim meses = Prestamo.PrestamosPorTipoPersona(Anual, Modalidad, TipoPersona).ToList()
                Dim rows(meses.Count - 1) As Object
                Dim i As Integer = 0
                For Each c In meses
                    rows(i) = New Object() {c.Mes, c.C1, c.C2, c.C3}
                    i = i + 1
                Next
                Return New JsonResult With {.Data = rows, .JsonRequestBehavior = JsonRequestBehavior.AllowGet}
            End Using
        End Function

    End Class
End Namespace