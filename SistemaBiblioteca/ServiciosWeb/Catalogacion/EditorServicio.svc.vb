' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "EditorServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EditorServicio.svc o EditorServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class EditorServicio
    Implements IEditorServicio

    Public Sub DoWork() Implements IEditorServicio.DoWork
    End Sub

    Public Sub Guardar(ByVal Editor As DEditor) Implements IEditorServicio.Guardar
        Try
            Using db As New ContextoBiblioteca
                If Not db.Editores.Where(Function(f) f.Descripcion = Editor.Descripcion.Trim).FirstOrDefault Is Nothing Then
                    Throw New Exception("Ya existe un editor con este nombre.")
                End If
                db.Editores.Add(New Editor With {.IdEditor = Guid.NewGuid, .Descripcion = Editor.Descripcion})
                db.SaveChanges()
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Sub

    Public Function Lista() As List(Of DEditor) Implements IEditorServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From edi In db.Editores Select New DEditor With {.IdEditor = edi.IdEditor, .Descripcion = edi.Descripcion}).ToList()
        End Using
    End Function

    Public Sub Editar(ByVal Editor As DEditor) Implements IEditorServicio.Editar
        Using db As New ContextoBiblioteca
            If Not db.Editores.Where(Function(f) f.Descripcion = Editor.Descripcion.Trim And f.IdEditor <> Editor.IdEditor).FirstOrDefault Is Nothing Then
                Throw New Exception("Ya existe un editor con este nombre.")
            End If
            Dim edi = db.Paises.Where(Function(f) f.IdPais = Editor.IdEditor).FirstOrDefault
            If Not edi Is Nothing Then
                edi.Descripcion = Editor.Descripcion
                db.Entry(edi).State = Entity.EntityState.Modified
                db.SaveChanges()
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("Editor"))
            End If
        End Using
    End Sub

    Public Sub Eliminar(ByVal IdEditor As Guid) Implements IEditorServicio.Eliminar
        Using db As New ContextoBiblioteca
            Dim edi = db.Editores.Where(Function(f) f.IdEditor = IdEditor).FirstOrDefault
            If Not edi Is Nothing Then
                'db.Entry(edi).State = Entity.EntityState.Modified
                For Each c In db.Libros.Where(Function(f) f.IdEditor = edi.IdEditor)
                    c.IdEditor = Nothing
                Next
                db.Editores.Remove(edi)
                db.SaveChanges()
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("País"))
            End If
        End Using
    End Sub

    Public Function BuscarPorId(ByVal IdEditor As Guid) As DEditor Implements IEditorServicio.BuscarPorId
        Try
            Using db As New ContextoBiblioteca
                Return (From edi In db.Editores Where edi.IdEditor = IdEditor Select New DEditor With {.IdEditor = edi.IdEditor, .Descripcion = edi.Descripcion}).FirstOrDefault()
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function Busqueda(ByVal Descripcion As String) As List(Of DEditor) Implements IEditorServicio.Busqueda
        Using db As New ContextoBiblioteca
            Return (From edi In db.Editores Where edi.Descripcion.Contains(Descripcion) Select New DEditor With {.IdEditor = edi.IdEditor, .Descripcion = edi.Descripcion}).ToList()
        End Using
    End Function

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DEditor Implements IEditorServicio.BuscarPorDescripcion
        Using db As New ContextoBiblioteca
            Return (From edi In db.Editores Where edi.Descripcion = Descripcion Select New DEditor With {.IdEditor = edi.IdEditor, .Descripcion = edi.Descripcion}).FirstOrDefault
        End Using
    End Function

    Public Function Existe(ByVal Descripcion As String) As Boolean Implements IEditorServicio.Existe
        Using db As New ContextoBiblioteca
            If Not (From edi In db.Editores Where edi.Descripcion = Descripcion Select New DEditor With {.IdEditor = edi.IdEditor, .Descripcion = edi.Descripcion}).FirstOrDefault Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

End Class
