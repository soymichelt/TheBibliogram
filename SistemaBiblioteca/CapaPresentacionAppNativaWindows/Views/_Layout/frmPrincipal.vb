Public Class frmPrincipal

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFecha.Text = DateTime.Now.ToShortDateString()
        lblHora.Text = DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub btLibro_Click(sender As Object, e As EventArgs) Handles btLibro.Click
        frmLibro.MdiParent = Me
        frmLibro.BringToFront()
        frmLibro.Show()
    End Sub

    Private Sub btVisitante_Click(sender As Object, e As EventArgs) Handles btVisitante.Click
        frmPersona.MdiParent = Me
        frmPersona.BringToFront()
        frmPersona.Show()
    End Sub

    Private Sub btPrestamos_Click(sender As Object, e As EventArgs) Handles btPrestamos.Click
        frmPrestamo.MdiParent = Me
        frmPrestamo.BringToFront()
        frmPrestamo.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblUsuario.Text = "Usuario: " & VarGlobales.Sesion.Apellidos & ", " & VarGlobales.Sesion.Nombres
            Select Case VarGlobales.Sesion.Rol
                Case 1
                    lblRol.Text = "Administrador"
                Case 2
                    lblRol.Text = "Analista Documental"
                    btLibro.Enabled = True : btInstitucion.Enabled = True : btEncabezados.Enabled = True : bt.Enabled = True : btIdioma.Enabled = True : btEditor.Enabled = True : btTutor.Enabled = True : btPais.Enabled = True : btCiudad.Enabled = True : btEntrada.Enabled = True : btSalida.Enabled = True
                Case 3
                    lblRol.Text = "Analista Referencial"
                    btVisitante.Enabled = True : btPrestamos.Enabled = True : btBusquedaPrestamos.Enabled = True : btSolvencia.Enabled = True
                Case 4
                    lblRol.Text = "Administración"
                    btSolvencia.Enabled = True
                Case 5
                    lblRol.Text = "Director de Biblioteca"
                    btSolvencia.Enabled = True : btInformeAcceso.Enabled = True : btInformePrestamos.Enabled = True : btInformeBibliografia.Enabled = True
                Case 6
                    lblRol.Text = "Decanatura"
                    btInformeAcceso.Enabled = True : btInformePrestamos.Enabled = True : btInformeBibliografia.Enabled = True
                Case Else
                    lblRol.Text = "Usuario Sin Privilegios"
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btInstitucion_Click(sender As Object, e As EventArgs) Handles btInstitucion.Click
        frmInstitucion.MdiParent = Me
        frmInstitucion.BringToFront()
        frmInstitucion.Show()
    End Sub

    Private Sub btEncabezados_Click(sender As Object, e As EventArgs) Handles btEncabezados.Click
        frmEncabezado.MdiParent = Me
        frmEncabezado.BringToFront()
        frmEncabezado.Show()
    End Sub

    Private Sub bt_Click(sender As Object, e As EventArgs) Handles btGrado.Click, bt.Click
        frmGrado.MdiParent = Me
        frmGrado.BringToFront()
        frmGrado.Show()
    End Sub

    Private Sub btIdioma_Click(sender As Object, e As EventArgs) Handles btIdioma.Click
        frmIdioma.MdiParent = Me
        frmIdioma.BringToFront()
        frmIdioma.Show()
    End Sub

    Private Sub btEditor_Click(sender As Object, e As EventArgs) Handles btEditor.Click
        frmEditor.MdiParent = Me
        frmEditor.BringToFront()
        frmEditor.Show()
    End Sub

    Private Sub btTutor_Click(sender As Object, e As EventArgs) Handles btTutor.Click
        frmTutor.MdiParent = Me
        frmTutor.BringToFront()
        frmTutor.Show()
    End Sub

    Private Sub btEntrada_Click(sender As Object, e As EventArgs) Handles btEntrada.Click
        frmAdquisicion.MdiParent = Me
        frmAdquisicion.BringToFront()
        frmAdquisicion.Show()
    End Sub

    Private Sub btSalida_Click(sender As Object, e As EventArgs) Handles btSalida.Click
        frmAdquisicion.MdiParent = Me
        frmAdquisicion.BringToFront()
        frmAdquisicion.Show()
    End Sub

    Private Sub btCiudad_Click(sender As Object, e As EventArgs) Handles btCiudad.Click
        frmCiudad.MdiParent = Me
        frmCiudad.BringToFront()
        frmCiudad.Show()
    End Sub

    Private Sub btPais_Click(sender As Object, e As EventArgs) Handles btPais.Click
        frmPais.MdiParent = Me
        frmPais.BringToFront()
        frmPais.Show()
    End Sub

    Private Sub expInformacion_Resize(sender As Object, e As EventArgs) Handles expInformacion.Resize
        pnEstado.Left = expInformacion.Width - pnEstado.Width - 10
    End Sub


    Private Sub btEntrega_Click(sender As Object, e As EventArgs)
        frmEntrega.MdiParent = Me
        frmEntrega.BringToFront()
        frmEntrega.Show()
    End Sub

    Private Sub btSolvencia_Click(sender As Object, e As EventArgs) Handles btSolvencia.Click
        CapaPresentacionAppNativaWindows.frmSolvencia.ShowDialog()
    End Sub

    Private Sub btBusquedaPrestamos_Click(sender As Object, e As EventArgs) Handles btBusquedaPrestamos.Click
        frmBuscarPrestamo.MdiParent = Me
        frmBuscarPrestamo.BringToFront()
        frmBuscarPrestamo.Show()
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        frmSignin.Show()
        Me.Close()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Application.ExitThread()
    End Sub

    Private Sub btCreditos_Click(sender As Object, e As EventArgs) Handles btCreditos.Click
        frmCreditos.MdiParent = Me
        frmCreditos.BringToFront()
        frmCreditos.Show()
        frmCreditos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btCatalogo_Click(sender As Object, e As EventArgs) Handles btCatalogo.Click
        frmBuscarLibro.MdiParent = Me
        frmBuscarLibro.BringToFront()
        frmBuscarLibro.Show()
    End Sub

    Private Sub btBusquedaRecomendacion_Click(sender As Object, e As EventArgs) Handles btBusquedaRecomendacion.Click
        frmBuscarRecomendacion.MdiParent = Me
        frmBuscarRecomendacion.BringToFront()
        frmBuscarRecomendacion.Show()
    End Sub

    Private Sub btRecomendacion_Click(sender As Object, e As EventArgs) Handles btRecomendacion.Click
        frmRecomendacion.MdiParent = Me
        frmRecomendacion.BringToFront()
        frmRecomendacion.Show()
    End Sub

    Private Sub btEdicionUsuario_Click(sender As Object, e As EventArgs) Handles btEdicionUsuario.Click
        frmRegistrer.MdiParent = Me
        frmRegistrer.BringToFront()
        frmRegistrer.Show()
    End Sub
End Class
