' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "InstitucionServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione InstitucionServicio.svc o InstitucionServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class InstitucionServicio
    Implements IInstitucionServicio

    Public Sub DoWork() Implements IInstitucionServicio.DoWork
    End Sub

    Public Sub Guardar(ByVal Institucion As DInstitucion) Implements IInstitucionServicio.Guardar
        Using db As New ContextoBiblioteca
            db.Instituciones.Add(New Institucion With {.IdInstitucion = Guid.NewGuid, .Descripcion = Institucion.Descripcion})
            db.SaveChanges()
        End Using
    End Sub

    Public Function Lista() As List(Of DInstitucion) Implements IInstitucionServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From ins In db.Instituciones Select New DInstitucion With {.IdInstitucion = ins.IdInstitucion, .Descripcion = ins.Descripcion}).ToList()
        End Using
    End Function

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DInstitucion Implements IInstitucionServicio.BuscarPorDescripcion
        Using db As New ContextoBiblioteca
            Return (From ins In db.Instituciones Where ins.Descripcion = Descripcion Select New DInstitucion With {.IdInstitucion = ins.IdInstitucion, .Descripcion = ins.Descripcion}).FirstOrDefault
        End Using
    End Function

    Public Function Existe(ByVal Descripcion As String) As Boolean Implements IInstitucionServicio.Existe
        Using db As New ContextoBiblioteca
            If Not (From ins In db.Instituciones Where ins.Descripcion = Descripcion Select New DInstitucion With {.IdInstitucion = ins.IdInstitucion, .Descripcion = ins.Descripcion}).FirstOrDefault Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

End Class
