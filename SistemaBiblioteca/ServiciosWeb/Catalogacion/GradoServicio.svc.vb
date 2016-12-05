' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "GradoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GradoServicio.svc o GradoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class GradoServicio
    Implements IGradoServicio

    Public Sub DoWork() Implements IGradoServicio.DoWork
    End Sub

    Public Sub Guardar(ByVal Grado As DGrado) Implements IGradoServicio.Guardar
        Using db As New ContextoBiblioteca
            db.Grados.Add(New Grado With {.IdGrado = Guid.NewGuid, .Descripcion = Grado.Descripcion})
            db.SaveChanges()
        End Using
    End Sub

    Public Function Lista() As List(Of DGrado) Implements IGradoServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From gra In db.Grados Select New DGrado With {.IdGrado = gra.IdGrado, .Descripcion = gra.Descripcion}).ToList()
        End Using
    End Function

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DGrado Implements IGradoServicio.BuscarPorDescripcion
        Using db As New ContextoBiblioteca
            Return (From gra In db.Grados Where gra.Descripcion = Descripcion Select New DGrado With {.IdGrado = gra.IdGrado, .Descripcion = gra.Descripcion}).FirstOrDefault
        End Using
    End Function

    Public Function Existe(ByVal Descripcion As String) As Boolean Implements IGradoServicio.Existe
        Using db As New ContextoBiblioteca
            If Not (From gra In db.Grados Where gra.Descripcion = Descripcion Select New DGrado With {.IdGrado = gra.IdGrado, .Descripcion = gra.Descripcion}).FirstOrDefault Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

End Class
