Imports Capadedatos.Models
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "RecomendacionServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RecomendacionServicio.svc o RecomendacionServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class RecomendacionServicio
    Implements IRecomendacionServicio

    Public Sub DoWork() Implements IRecomendacionServicio.DoWork

    End Sub

    Public Function Guardar(ByVal Recomendacion As DRecomendacion) As Guid Implements IRecomendacionServicio.Guardar
        Try
            If Recomendacion.AreaDirigida.Trim <> "" And Recomendacion.Titulo.Trim <> "" And Recomendacion.Autores.Trim <> "" Then
                Using db As New ContextoBiblioteca
                    If db.Usuarios.Where(Function(f) f.IdUsuario = Recomendacion.IdUsuario And f.Activo).Count > 0 Then
                        Recomendacion.IdRecomendacion = Guid.NewGuid
                        db.Recomendaciones.Add(New Recomendacion With {.IdRecomendacion = Recomendacion.IdRecomendacion, .FechaReg = DateTime.Now, .FechaMod = DateTime.Now, .AreaDirigida = Recomendacion.AreaDirigida, .Titulo = Recomendacion.Titulo, .OtroTitulo = Recomendacion.OtroTitulo, .Autores = Recomendacion.Autores, .Isbn = Recomendacion.Isbn, .Volumen = Recomendacion.Volumen, .Edicion = Recomendacion.Edicion, .Nota = Recomendacion.Nota, .Activo = True, .IdUsuario = Recomendacion.IdUsuario})
                        db.SaveChanges()
                        Return Recomendacion.IdRecomendacion
                    Else
                        Throw New Exception("Usuario no encontrado.")
                    End If
                End Using
            Else
                Throw New Exception("Ingresar todos los campos de orden obligatorio (*).")
            End If
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function Busqueda(ByVal Inicio As DateTime, ByVal Fin As DateTime, ByVal NombreUsuario As String) As List(Of DRecomendacion) Implements IRecomendacionServicio.Busqueda
        Try
            Using db As New ContextoBiblioteca
                Return (From rec In db.Recomendaciones Join usu In db.Usuarios On rec.IdUsuario Equals usu.IdUsuario Where rec.FechaMod >= Inicio And rec.FechaMod <= Fin And (usu.Nombres & " " & usu.Apellidos).Contains(NombreUsuario) Select New DRecomendacion With {.IdRecomendacion = rec.IdRecomendacion, .FechaReg = rec.FechaReg, .FechaMod = rec.FechaMod, .AreaDirigida = rec.AreaDirigida, .Titulo = rec.Titulo, .OtroTitulo = rec.OtroTitulo, .Autores = rec.Autores, .Isbn = rec.Isbn, .Volumen = rec.Volumen, .Edicion = rec.Edicion, .Nota = rec.Nota, .Activo = rec.Activo, .IdUsuario = rec.IdUsuario, .Usuario = rec.Usuario.Nombres & " " & rec.Usuario.Apellidos}).ToList()
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function CantidadAnoActual() As List(Of DCantidadMensual) Implements IRecomendacionServicio.CantidadAnual
        Try
            Using db As New ContextoBiblioteca
                Dim meses As New List(Of DCantidadMensual)
                Dim año = DateTime.Now.Year
                meses.Add(New DCantidadMensual With {.Id = 1, .Mes = "Ene", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 1 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 2, .Mes = "Feb", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 2 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 3, .Mes = "Mar", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 3 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 4, .Mes = "Abr", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 4 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 5, .Mes = "May", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 5 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 6, .Mes = "Jun", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 6 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 7, .Mes = "Jul", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 7 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 8, .Mes = "Ago", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 8 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 9, .Mes = "Sep", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 9 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 10, .Mes = "Oct", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 10 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 11, .Mes = "Nov", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 11 And f.FechaReg.Year = año).Count()})
                meses.Add(New DCantidadMensual With {.Id = 12, .Mes = "Dic", .Cantidad = db.Recomendaciones.Where(Function(f) f.FechaReg.Month = 12 And f.FechaReg.Year = año).Count()})
                Return meses
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function RecomendacionesUsers(ByVal Inicio As DateTime, ByVal Fin As DateTime, ByVal IdUsuario As Guid) As List(Of DRecomendacion) Implements IRecomendacionServicio.RecomendacionesUsers
        Try
            Using db As New ContextoBiblioteca
                Return (From rec In db.Recomendaciones Join usu In db.Usuarios On rec.IdUsuario Equals usu.IdUsuario Where rec.Activo And rec.FechaMod >= Inicio And rec.FechaMod <= Fin And usu.IdUsuario = IdUsuario Select New DRecomendacion With {.IdRecomendacion = rec.IdRecomendacion, .FechaReg = rec.FechaReg, .FechaMod = rec.FechaMod, .AreaDirigida = rec.AreaDirigida, .Titulo = rec.Titulo, .OtroTitulo = rec.OtroTitulo, .Autores = rec.Autores, .Isbn = rec.Isbn, .Volumen = rec.Volumen, .Edicion = rec.Edicion, .Nota = rec.Nota, .Activo = rec.Activo, .IdUsuario = rec.IdUsuario, .Usuario = rec.Usuario.Nombres & " " & rec.Usuario.Apellidos}).ToList()
            End Using
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

End Class