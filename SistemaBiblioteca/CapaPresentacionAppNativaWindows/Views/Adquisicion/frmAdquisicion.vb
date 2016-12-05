Public Class frmAdquisicion
    Public ListadoLibros As New List(Of PrestamoServicio.DInventario)
    Public IdPrestamo As Guid = Guid.Empty

    Sub Limpiar()
        txtNPrestamo.Text = "0000000000"
        dtpFecha.Value = DateTime.Now
        txtDescripcion.Clear()
        txtIdPersona.Clear()
        txtNombrePersona.Clear()
        dtRegistro.DataSource = Nothing
        btGuardar.Enabled = True
        btEditar.Enabled = False
        btEliminar.Enabled = False
        btImprimir.Enabled = False
        txtNPrestamo.Focus()
    End Sub

    Private Sub frmAdquisicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = DateTime.Now
        txtNPrestamo.Focus()
    End Sub

    Private Sub frmAdquisicion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnSeleccionar.Width = pnDetalle.Width - (pnSeleccionar.Location.X * 2)
        txtLibro.Width = pnSeleccionar.Width - txtLibro.Location.X - 6
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub

    Private Sub frmAdquisicion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Keys.F1
                btNuevo_Click(Nothing, Nothing)
            Case Keys.F2
                If btGuardar.Enabled Then
                    btGuardar_Click(Nothing, Nothing)
                End If
            Case Keys.F3
                If btEditar.Enabled Then
                    'btEditar_Click(Nothing, Nothing)
                End If
            Case Keys.F4
                If btEliminar.Enabled Then
                    'btEliminar_Click(Nothing, Nothing)
                End If
            Case Keys.F5
                btBuscar_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

    End Sub
End Class