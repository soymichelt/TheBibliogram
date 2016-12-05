Public Class frmSignin

    Private Sub frmSignin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        'PictureBox1.Controls.Add(gbIniciarSesion)
        'gbIniciarSesion.BringToFront()
        'gbIniciarSesion.Left = (PictureBox1.Width / 2) - (gbIniciarSesion.Width / 2)
        'gbIniciarSesion.Top = (PictureBox1.Height / 2) - (gbIniciarSesion.Height / 2)
        txtUsuario.Focus()
    End Sub

    Private Sub picUsuario_Click(sender As Object, e As EventArgs) Handles picUsuario.Click
        txtUsuario.Focus()
    End Sub

    Private Sub picPass_Click(sender As Object, e As EventArgs) Handles picPass.Click
        txtContraseña.Focus()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtUsuario.Text.Trim <> "" Then
                txtContraseña.Focus()
                ErrorProvider1.SetError(Me.picUsuario, "")
            Else
                'MessageBox.Show("Ingresar Usuario")
                ErrorProvider1.SetError(Me.picUsuario, "Ingresar Usuario")
            End If
        End If
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtContraseña.Text.Trim <> "" Then
                ErrorProvider1.SetError(Me.picPass, "")
                btEntrar.Focus()
            Else
                'MessageBox.Show("Ingresar Contraseña")
                ErrorProvider1.SetError(Me.picPass, "Ingresar Contraseña")
            End If
        End If
    End Sub

    Private Sub btEntrar_Click(sender As Object, e As EventArgs) Handles btEntrar.Click
        If txtUsuario.Text.Trim = "" Then
            'MessageBox.Show("Ingresar Usuario")
            ErrorProvider1.SetError(Me.picUsuario, "Ingresar Usuario")
            txtUsuario.Focus()
        Else
            ErrorProvider1.SetError(Me.picUsuario, "")
        End If
        If txtContraseña.Text.Trim = "" Then
            'MessageBox.Show("Ingresar Usuario")
            ErrorProvider1.SetError(Me.picPass, "Ingresar Contraseña")
            txtContraseña.Focus()
        Else
            ErrorProvider1.SetError(Me.picPass, "")
        End If
        Try
            Using Account As New AccountServicio.AccountServicioClient
                VarGlobales.Sesion = Account.Signin(New AccountServicio.DUsuario With {.Email = txtUsuario.Text, .Password = txtContraseña.Text})
                If Not VarGlobales.Sesion Is Nothing Then
                    frmPrincipal.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Usuario o Contraseña Incorrectos.")
                    txtContraseña.Clear()
                    txtUsuario.Focus()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        If MessageBox.Show("¿Desea Salir?", "Pregunta de seguridad...", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Class