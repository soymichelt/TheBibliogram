' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "AccountServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AccountServicio.svc o AccountServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Capadedatos.Models
Public Class AccountServicio
    Implements IAccountServicio

    Public Sub DoWork() Implements IAccountServicio.DoWork
    End Sub

    Public Function Signin(ByVal Usuario As DUsuario) As DUsuario Implements IAccountServicio.Signin
        Try
            If Not Usuario Is Nothing Then
                If Usuario.Email Is Nothing Then
                    Throw New Exception("Ingrsar 'Usuario'.")
                Else
                    If Usuario.Email.Trim = "" Then
                        Throw New Exception("Ingrsar 'Usuario'.")
                    End If
                End If
                If Usuario.Password Is Nothing Then
                    Throw New Exception("Ingrsar 'Contraseña'.")
                Else
                    If Usuario.Password.Trim = "" Then
                        Throw New Exception("Ingrsar 'Contraseña'.")
                    End If
                End If

                Using db As New ContextoBiblioteca
                    Dim user = db.Usuarios.Where(Function(f) f.Email = Usuario.Email).FirstOrDefault
                    If Not user Is Nothing Then
                        Dim Password = CryptoSecurityInfo.PasswordDecoding(user.Password)
                        If Password = Usuario.Password Then
                            Return New DUsuario With {.IdUsuario = user.IdUsuario, .FechaReg = user.FechaReg, .FechaMod = user.FechaMod, .Nombres = user.Nombres, .Apellidos = user.Apellidos, .FechaNacimiento = user.FechaNacimiento, .Email = user.Email, .Password = "xxxxxxxxxxxxx", .Sexo = user.Sexo, .Rol = user.Rol, .Descripcion = user.Descripcion, .Activo = user.Activo}
                        Else
                            Throw New Exception("La contraseña que ingresastes es incorrecta.")
                        End If
                    Else
                        Throw New Exception("El correo electrónico que ingresastes no coincide con ninguna cuenta.")
                    End If
                End Using
            Else
                Throw New Exception("Ingresar 'Usuario' y 'Contraseña'.")
            End If
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Function Register(ByVal Usuario As DUsuario) As DUsuario Implements IAccountServicio.Register
        Try
            If Not Usuario Is Nothing Then
                'validaciones
                If Usuario.Nombres Is Nothing Then
                    Throw New Exception("Para registrar un 'Usuario' son necesarios sus 'Nombres'.")
                ElseIf Usuario.Nombres.Trim = "" Then
                    Throw New Exception("Para registrar un 'Usuario' son necesarios sus 'Nombres'.")
                End If
                If Usuario.Apellidos Is Nothing Then
                    Throw New Exception("Para registrar un 'Usuario' son necesarios sus 'Apellidos'.")
                ElseIf Usuario.Apellidos.Trim = "" Then
                    Throw New Exception("Para registrar un 'Usuario' son necesarios sus 'Apellidos'.")
                End If
                If Usuario.FechaNacimiento.Year < 1900 Then
                    Throw New Exception("Para registrar un 'Usuario' es necesario ingresar una 'Fecha de Nacimiento' mayor a 31/12/1899.")
                End If
                If Usuario.Email Is Nothing Then
                    Throw New Exception("Para registrar un 'Usuario' es necesario su 'E-mail'.")
                ElseIf Usuario.Email.Trim = "" Then
                    Throw New Exception("Para registrar un 'Usuario' es necesario su 'E-mail'.")
                End If
                If Usuario.Password Is Nothing Then
                    Throw New Exception("Para registrar un 'Usuario' es necesario su 'Password'.")
                ElseIf Usuario.Password.Trim = "" Then
                    Throw New Exception("Para registrar un 'Usuario' es necesario su 'Password'.")
                End If

                'guardar al usuario
                Usuario.IdUsuario = Guid.NewGuid : Usuario.FechaReg = DateTime.Now : Usuario.FechaMod = Usuario.FechaReg
                Using db As New ContextoBiblioteca
                    db.Usuarios.Add(New Usuario With {.IdUsuario = Usuario.IdUsuario, .FechaReg = Usuario.FechaReg, .FechaMod = Usuario.FechaMod, .Nombres = Usuario.Nombres, .Apellidos = Usuario.Apellidos, .Sexo = Usuario.Sexo, .FechaNacimiento = Usuario.FechaNacimiento, .Email = Usuario.Email, .Password = CryptoSecurityInfo.PasswordEnconding(Usuario.Password), .Descripcion = "", .Rol = Usuario.Rol, .Activo = True})
                    db.SaveChanges()
                End Using
                Return Usuario
            Else
                Throw New Exception("No se ingresaron los datos del usuario.")
            End If
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

End Class
