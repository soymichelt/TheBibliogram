Imports System.Web.HttpSessionStateBase
Imports System.Web.Mvc.Controller

Public Class Globales
    Public Shared Function Modalidad() As List(Of Modalidad)
        Dim m = New List(Of Modalidad)
        m.Add(New Modalidad With {.N = 1, .Nombre = "Todos los meses"})
        m.Add(New Modalidad With {.N = 2, .Nombre = "Primer Semestre"})
        m.Add(New Modalidad With {.N = 3, .Nombre = "Segundo Semestre"})
        m.Add(New Modalidad With {.N = 4, .Nombre = "Primer Trimestre"})
        m.Add(New Modalidad With {.N = 5, .Nombre = "Segundo Trimestre"})
        m.Add(New Modalidad With {.N = 6, .Nombre = "Tercer Trimestre"})
        m.Add(New Modalidad With {.N = 7, .Nombre = "Primeros 2 meses"})
        m.Add(New Modalidad With {.N = 8, .Nombre = "Segundos 2 meses"})
        m.Add(New Modalidad With {.N = 9, .Nombre = "Terceros 2 meses"})
        m.Add(New Modalidad With {.N = 10, .Nombre = "Cuartos 2 meses"})
        m.Add(New Modalidad With {.N = 11, .Nombre = "Quintos 2 meses"})
        m.Add(New Modalidad With {.N = 12, .Nombre = "Sextos 2 meses"})
        m.Add(New Modalidad With {.N = 13, .Nombre = "Enero"})
        m.Add(New Modalidad With {.N = 14, .Nombre = "Febrero"})
        m.Add(New Modalidad With {.N = 15, .Nombre = "Marzo"})
        m.Add(New Modalidad With {.N = 16, .Nombre = "Abril"})
        m.Add(New Modalidad With {.N = 17, .Nombre = "Mayo"})
        m.Add(New Modalidad With {.N = 18, .Nombre = "Junio"})
        m.Add(New Modalidad With {.N = 19, .Nombre = "Julio"})
        m.Add(New Modalidad With {.N = 20, .Nombre = "Agosto"})
        m.Add(New Modalidad With {.N = 21, .Nombre = "Septiembre"})
        m.Add(New Modalidad With {.N = 22, .Nombre = "Octubre"})
        m.Add(New Modalidad With {.N = 23, .Nombre = "Noviembre"})
        m.Add(New Modalidad With {.N = 24, .Nombre = "Diciembre"})
        Return m
    End Function

    Public Shared Function TipoPersona() As List(Of Modalidad)
        Dim tipo As New List(Of Modalidad)
        tipo.Add(New Modalidad With {.N = 1, .Nombre = "Estudiante"})
        tipo.Add(New Modalidad With {.N = 2, .Nombre = "Docente"})
        tipo.Add(New Modalidad With {.N = 3, .Nombre = "Egresado"})
        tipo.Add(New Modalidad With {.N = 4, .Nombre = "Público en General"})
        tipo.Add(New Modalidad With {.N = 5, .Nombre = "Administrativo"})
        tipo.Add(New Modalidad With {.N = 6, .Nombre = "Docente-Administrativo"})
        tipo.Add(New Modalidad With {.N = 7, .Nombre = "Docente-Estudiante"})
        tipo.Add(New Modalidad With {.N = 8, .Nombre = "Estudiante-Administrativo"})
        tipo.Add(New Modalidad With {.N = 9, .Nombre = "Estudiante-Administrativo-Docente"})
        Return tipo
    End Function
End Class

Public Class Modalidad
    Public Property N As Integer
    Public Property Nombre As String
End Class

Public Class AuthenticationSecurity
    Inherits System.Web.Mvc.Controller
    Public Function SessionAutentification() As Boolean
        If Session("_AuthenticationState") Is Nothing Then
            Return False
        ElseIf Session("_AuthenticationState").ToString() <> "1" Then
            Return False
        End If
        Return True
    End Function
End Class