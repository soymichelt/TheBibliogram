' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "CarreraServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CarreraServicio.svc o CarreraServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class CarreraServicio
    Implements ICarreraServicio

    Public Sub DoWork() Implements ICarreraServicio.DoWork
    End Sub

    Public Function Lista() As List(Of DCarrera) Implements ICarreraServicio.Lista
        Using db As New ContextoBiblioteca
            Return (From car In db.Carreras Select New DCarrera With {.IdCarrera = car.IdCarrera, .N = car.N, .NombreCarrera = car.NombreCarrera}).ToList()
        End Using
    End Function

    Public Function Filtrar(ByVal Nombre As String) As List(Of DCarrera) Implements ICarreraServicio.Filtrar
        Using db As New ContextoBiblioteca
            Return (From car In db.Carreras Where car.NombreCarrera.Contains(Nombre) Select New DCarrera With {.IdCarrera = car.IdCarrera, .N = car.N, .NombreCarrera = car.NombreCarrera}).ToList()
        End Using
    End Function

    Public Sub Guardar(ByVal Carrera As DCarrera) Implements ICarreraServicio.Guardar
        Using db As New ContextoBiblioteca
            Dim car As New Carrera
            car.IdCarrera = Guid.NewGuid : car.NombreCarrera = Carrera.NombreCarrera : db.Carreras.Add(car)
            db.SaveChanges()
        End Using
    End Sub

    Public Function BuscarPorNombre(ByVal Nombre As String) As DCarrera Implements ICarreraServicio.BuscarPorNombre
        Using db As New ContextoBiblioteca
            Return (From car In db.Carreras Where car.NombreCarrera.Contains(Nombre) Select New DCarrera With {.IdCarrera = car.IdCarrera, .N = car.N, .NombreCarrera = car.NombreCarrera}).FirstOrDefault()
        End Using
    End Function

    Public Function BuscarPorId(ByVal IdCarrera As Guid) As DCarrera Implements ICarreraServicio.BuscarPorId
        Using db As New ContextoBiblioteca
            Return (From car In db.Carreras Where car.IdCarrera = IdCarrera Select New DCarrera With {.IdCarrera = car.IdCarrera, .N = car.N, .NombreCarrera = car.NombreCarrera}).FirstOrDefault()
        End Using
    End Function

End Class
