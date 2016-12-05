' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "IdiomaServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione IdiomaServicio.svc o IdiomaServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class IdiomaServicio
    Implements IIdiomaServicio

    Public Sub DoWork() Implements IIdiomaServicio.DoWork
    End Sub

    Public Sub Guardar(ByVal Idioma As DIdioma) Implements IIdiomaServicio.Guardar
        Using db As New ContextoBiblioteca
            db.Idiomas.Add(New Idioma With {.IdIdioma = Guid.NewGuid, .Descripcion = Idioma.Descripcion})
            db.SaveChanges()
        End Using
    End Sub

    Public Function Lista() As List(Of DIdioma) Implements IIdiomaServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From idi In db.Idiomas Select New DIdioma With {.IdIdioma = idi.IdIdioma, .Descripcion = idi.Descripcion}).ToList()
        End Using
    End Function

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DIdioma Implements IIdiomaServicio.BuscarPorDescripcion
        Using db As New ContextoBiblioteca
            Return (From idi In db.Idiomas Where idi.Descripcion = Descripcion Select New DIdioma With {.IdIdioma = idi.IdIdioma, .Descripcion = idi.Descripcion}).FirstOrDefault
        End Using
    End Function

    Public Function Existe(ByVal Descripcion As String) As Boolean Implements IIdiomaServicio.Existe
        Using db As New ContextoBiblioteca
            If Not (From idi In db.Idiomas Where idi.Descripcion = Descripcion Select New DIdioma With {.IdIdioma = idi.IdIdioma, .Descripcion = idi.Descripcion}).FirstOrDefault Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

End Class