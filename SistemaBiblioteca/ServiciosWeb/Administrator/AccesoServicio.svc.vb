' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "AccesoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AccesoServicio.svc o AccesoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class AccesoServicio
    Implements IAccesoServicio

    Public Sub DoWork() Implements IAccesoServicio.DoWork

    End Sub

    Public Sub RegistrarAcceso(ByVal IdUsuario As Nullable(Of Guid)) Implements IAccesoServicio.RegistrarVisita
        Try
            Using db As New ContextoBiblioteca
                If IdUsuario Is Nothing Then
                    db.Visitas.Add(New Visita With {.IdVisita = Guid.NewGuid, .FechaReg = DateTime.Now, .IdUsuario = Nothing})
                Else
                    Dim usuario = db.Usuarios.Where(Function(f) f.Activo And f.IdUsuario = IdUsuario)
                    db.Visitas.Add(New Visita With {.IdVisita = Guid.NewGuid, .FechaReg = DateTime.Now, .IdUsuario = IdUsuario})
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Sub

End Class
