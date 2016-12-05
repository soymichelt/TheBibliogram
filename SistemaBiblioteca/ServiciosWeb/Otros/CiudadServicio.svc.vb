' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "CiudadServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CiudadServicio.svc o CiudadServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class CiudadServicio
    Implements ICiudadServicio

    Public Sub DoWork() Implements ICiudadServicio.DoWork
    End Sub

    Public Function Lista() As List(Of DCiudad) Implements ICiudadServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From ciu In db.Ciudades Select New DCiudad With {.IdCiudad = ciu.IdCiudad, .Descripcion = ciu.Descripcion, .IdPais = ciu.IdPais, .Pais = ciu.Pais.Descripcion}).ToList()
        End Using
    End Function

    Public Function Filtrar(ByVal Nombre As String) As List(Of DCiudad) Implements ICiudadServicio.Filtrar
        Using db As New ContextoBiblioteca
            Return (From ciu In db.Ciudades Where ciu.Descripcion.Contains(Nombre) Select New DCiudad With {.IdCiudad = ciu.IdCiudad, .Descripcion = ciu.Descripcion, .IdPais = ciu.IdPais, .Pais = ciu.Pais.Descripcion}).ToList()
        End Using
    End Function

    Public Sub Guardar(ByVal Ciudad As DCiudad) Implements ICiudadServicio.Guardar
        Using db As New ContextoBiblioteca
            If Not Me.BuscarPorNombre(Ciudad.Descripcion.Trim) Is Nothing Then
                Throw New Exception("Ya existe una ciudad con este nombre.")
            End If
            db.Ciudades.Add(New Ciudad With {.IdCiudad = Guid.NewGuid, .Descripcion = Ciudad.Descripcion, .IdPais = Ciudad.IdPais})
            db.SaveChanges()
        End Using
    End Sub

    Public Sub Editar(ByVal Ciudad As DCiudad) Implements ICiudadServicio.Editar
        Using db As New ContextoBiblioteca
            If Not db.Ciudades.Where(Function(f) f.Descripcion = Ciudad.Descripcion.Trim And f.IdCiudad <> Ciudad.IdCiudad).FirstOrDefault Is Nothing Then
                Throw New Exception("Ya existe una ciudad con este nombre.")
            End If
            Dim ciu = db.Ciudades.Where(Function(f) f.IdCiudad = Ciudad.IdCiudad).FirstOrDefault
            If Not ciu Is Nothing Then
                ciu.Descripcion = Ciudad.Descripcion
                ciu.IdPais = Ciudad.IdPais
                db.Entry(ciu).State = Entity.EntityState.Modified
                db.SaveChanges()
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("Ciudad"))
            End If
        End Using
    End Sub

    Public Sub Eliminar(ByVal IdCiudad As Guid) Implements ICiudadServicio.Eliminar
        Using db As New ContextoBiblioteca
            Dim pai = db.Paises.Where(Function(f) f.IdPais = IdCiudad).FirstOrDefault
            If pai Is Nothing Then
                db.Entry(pai).State = Entity.EntityState.Modified
                db.SaveChanges()
            Else
                Throw New Exception(GlobalSistema.NoEncontrado("Ciudad"))
            End If
        End Using
    End Sub
    Public Function BuscarPorNombre(ByVal Nombre As String) As DCiudad Implements ICiudadServicio.BuscarPorNombre
        Using db As New ContextoBiblioteca
            Return (From ciu In db.Ciudades Where ciu.Descripcion = Nombre Select New DCiudad With {.IdCiudad = ciu.IdCiudad, .Descripcion = ciu.Descripcion, .IdPais = ciu.IdPais, .Pais = ciu.Pais.Descripcion}).FirstOrDefault()
        End Using
    End Function

    Public Function BuscarPorId(ByVal IdCiudad As Guid) As DCiudad Implements ICiudadServicio.BuscarPorId
        Using db As New ContextoBiblioteca
            Return (From ciu In db.Ciudades Where ciu.IdCiudad = IdCiudad Select New DCiudad With {.IdCiudad = ciu.IdCiudad, .Descripcion = ciu.Descripcion, .IdPais = ciu.IdPais, .Pais = ciu.Pais.Descripcion}).FirstOrDefault()
        End Using
    End Function

End Class