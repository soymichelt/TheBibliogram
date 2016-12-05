' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "PaisServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PaisServicio.svc o PaisServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class PaisServicio
    Implements IPaisServicio

    Public Sub DoWork() Implements IPaisServicio.DoWork
    End Sub

    Public Function Lista() As List(Of DPais) Implements IPaisServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From pai In db.Paises Select New DPais With {.IdPais = pai.IdPais, .Descripcion = pai.Descripcion}).ToList()
        End Using
    End Function

    Public Function Filtrar(ByVal Nombre As String) As List(Of DPais) Implements IPaisServicio.Filtrar
        Using db As New ContextoBiblioteca
            Return (From pai In db.Ciudades Where pai.Descripcion.Contains(Nombre) Select New DPais With {.IdPais = pai.IdPais, .Descripcion = pai.Descripcion}).ToList()
        End Using
    End Function

    Public Sub Guardar(ByVal Pais As DPais) Implements IPaisServicio.Guardar
        Using db As New ContextoBiblioteca
            If Not Me.BuscarPorNombre(Pais.Descripcion.Trim) Is Nothing Then
                Throw New Exception("Ya existe un país con este nombre.")
            End If
            db.Paises.Add(New Pais With {.IdPais = Guid.NewGuid, .CodPais = Pais.CodPais, .Descripcion = Pais.Descripcion})
            db.SaveChanges()
        End Using
    End Sub

    Public Sub Editar(ByVal Pais As DPais) Implements IPaisServicio.Editar
        Using db As New ContextoBiblioteca
            If Not db.Paises.Where(Function(f) f.Descripcion = Pais.Descripcion.Trim And f.IdPais <> Pais.IdPais).FirstOrDefault Is Nothing Then
                Throw New Exception("Ya existe un país con este nombre.")
            End If
            Dim pai = db.Paises.Where(Function(f) f.IdPais = Pais.IdPais).FirstOrDefault
            If Not pai Is Nothing Then
                pai.Descripcion = Pais.Descripcion
                db.Entry(pai).State = Entity.EntityState.Modified
                db.SaveChanges()
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("País"))
            End If
        End Using
    End Sub

    Public Sub Eliminar(ByVal IdPais As Guid) Implements IPaisServicio.Eliminar
        Using db As New ContextoBiblioteca
            Dim pai = db.Paises.Where(Function(f) f.IdPais = IdPais).FirstOrDefault
            If Not pai Is Nothing Then
                db.Entry(pai).State = Entity.EntityState.Modified
                db.SaveChanges()
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("País"))
            End If
        End Using
    End Sub

    Public Function BuscarPorNombre(ByVal Nombre As String) As DPais Implements IPaisServicio.BuscarPorNombre
        Using db As New ContextoBiblioteca
            Return (From pai In db.Paises Where pai.Descripcion = Nombre Select New DPais With {.IdPais = pai.IdPais, .Descripcion = pai.Descripcion}).FirstOrDefault()
        End Using
    End Function

    Public Function BuscarPorId(ByVal IdPais As Guid) As DPais Implements IPaisServicio.BuscarPorId
        Using db As New ContextoBiblioteca
            Return (From pai In db.Paises Where pai.IdPais = IdPais Select New DPais With {.IdPais = pai.IdPais, .Descripcion = pai.Descripcion}).FirstOrDefault()
        End Using
    End Function

End Class