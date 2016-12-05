Public Class frmBuscarCiudad
    Dim LoadForm As Boolean = False
    Public Frm As Integer = 0

    Sub Llenar()
        Try
            Using Ciudad As New CiudadServicio.CiudadServicioClient
                dtRegistro.DataSource = (From per In Ciudad.Filtrar(txtNombre.Text.Trim) Select per.IdCiudad, per.Descripcion, per.Pais).ToList()
                If dtRegistro.Columns.Count > 0 Then
                    dtRegistro.Columns(0).Visible = False
                    dtRegistro.Columns(1).Width = 200 : dtRegistro.Columns(1).HeaderText = vbNewLine & "Nombre de la Ciudad" & vbNewLine
                    dtRegistro.Columns(2).Width = 200 : dtRegistro.Columns(2).HeaderText = "Nombre del País"
                    For Each c As DataGridViewColumn In dtRegistro.Columns
                        c.HeaderCell.Style.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
                        c.HeaderText = c.HeaderText.ToUpper
                    Next
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmBuscarCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar()
    End Sub

    Private Sub dtRegistro_KeyDown(sender As Object, e As KeyEventArgs) Handles dtRegistro.KeyDown
        If e.KeyData = Keys.Enter Then
            dtRegistro_CellDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtRegistro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtRegistro.CellDoubleClick
        Try
            If dtRegistro.SelectedRows.Count > 0 Then
                Using Ciudad As New CiudadServicio.CiudadServicioClient
                    Dim ciu = Ciudad.BuscarPorId(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString()))
                    Select Case Me.Frm
                        Case 1
                            frmPersona.txtIdCiudad.Text = ciu.IdCiudad.ToString
                            frmPersona.txtCiudad.Text = ciu.Descripcion & "; " & ciu.Pais & ";"
                        Case 2
                            frmLibro.txtIdCiudad.Text = ciu.IdCiudad.ToString
                            frmLibro.txtCiudad.Text = ciu.Descripcion & "; " & ciu.Pais & ";"
                        Case 3

                        Case Else
                            frmCiudad.IdCiudad = ciu.IdCiudad
                            frmCiudad.txtNombre.Text = ciu.Descripcion
                            frmCiudad.cmbPais.Text = ciu.Pais
                            frmCiudad.btGuardar.Enabled = False
                            frmCiudad.btEditar.Enabled = True
                            frmCiudad.btEliminar.Enabled = True
                    End Select
                    Me.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class