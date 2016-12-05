Public Class frmBuscarPais
    Dim LoadForm As Boolean = False
    Public Frm As Integer = 0

    Sub Llenar()
        Try
            Using Pais As New PaisServicio.PaisServicioClient
                dtRegistro.DataSource = (From per In Pais.Filtrar(txtNombre.Text.Trim) Select per.IdPais, per.Descripcion).ToList()
                If dtRegistro.Columns.Count > 0 Then
                    dtRegistro.Columns(0).Visible = False
                    dtRegistro.Columns(1).Width = 300 : dtRegistro.Columns(1).HeaderText = vbNewLine & "Nombre del País" & vbNewLine
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
                Using Pais As New PaisServicio.PaisServicioClient
                    Dim pai = Pais.BuscarPorId(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString()))
                    Select Case Me.Frm
                        Case 1
                            
                        Case 2

                        Case Else
                            frmPais.IdPais = pai.IdPais
                            frmPais.txtNombre.Text = pai.Descripcion
                            frmPais.btGuardar.Enabled = False
                            frmPais.btEditar.Enabled = True
                            frmPais.btEliminar.Enabled = True
                    End Select
                    Me.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class