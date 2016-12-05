' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "EncabezadoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EncabezadoServicio.svc o EncabezadoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class EncabezadoServicio
    Implements IEncabezadoServicio

    Public Sub DoWork() Implements IEncabezadoServicio.DoWork
    End Sub

    Public Sub Guardar(ByVal Encabezado As DEncabezado) Implements IEncabezadoServicio.Guardar
        Using db As New ContextoBiblioteca
            db.Encabezados.Add(New Encabezado With {.IdEncabezado = Guid.NewGuid, .Descripcion = Encabezado.Descripcion})
            db.SaveChanges()
        End Using
    End Sub

    Public Function Lista() As List(Of DEncabezado) Implements IEncabezadoServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From enc In db.Encabezados Select New DEncabezado With {.IdEncabezado = enc.IdEncabezado, .Descripcion = enc.Descripcion}).ToList()
        End Using
    End Function

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DEncabezado Implements IEncabezadoServicio.BuscarPorDescripcion
        Using db As New ContextoBiblioteca
            Return (From enc In db.Encabezados Where enc.Descripcion = Descripcion Select New DEncabezado With {.IdEncabezado = enc.IdEncabezado, .Descripcion = enc.Descripcion}).FirstOrDefault
        End Using
    End Function

    Public Function Existe(ByVal Descripcion As String) As Boolean Implements IEncabezadoServicio.Existe
        Using db As New ContextoBiblioteca
            If Not (From enc In db.Encabezados Where enc.Descripcion = Descripcion Select New DEncabezado With {.IdEncabezado = enc.IdEncabezado, .Descripcion = enc.Descripcion}).FirstOrDefault Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

End Class
