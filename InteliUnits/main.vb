Public Class main

    Function Convert(ByVal valorDeEntrada As Double, ByVal unidadeDeEntrada As String, _
                     ByVal unidadeDeSaida As String) As Double

        If unidadeDeEntrada = unidadeDeSaida Then
            Return txtVlEnt.Text

        ElseIf unidadeDeEntrada = "b" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text / 8



        ElseIf unidadeDeEntrada = "KB" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text * 1024

        ElseIf unidadeDeEntrada = "Kb" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text * 128



        ElseIf unidadeDeEntrada = "MB" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text * (1024 * 1024)

        ElseIf unidadeDeEntrada = "Mb" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text * 128 * 1024



        ElseIf unidadeDeEntrada = "GB" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text * (1024 * 1024 * 1024)

        ElseIf unidadeDeEntrada = "Gb" And unidadeDeSaida = "B" Then
            Return txtVlEnt.Text * 128 * (1024 * 1024)



        End If
        '
        If unidadeDeEntrada = "B" And unidadeDeSaida = "KB" Then
            Return txtVlEnt.Text / 1024

        ElseIf unidadeDeEntrada = "b" And unidadeDeSaida = "KB" Then
            Return txtVlEnt.Text * (txtEnt.Text / 8) * 1024



        ElseIf unidadeDeEntrada = unidadeDeSaida Then
            Return txtVlEnt.Text



        ElseIf unidadeDeEntrada = "Mb" And unidadeDeSaida = "KB" Then
            Return txtVlEnt.Text * 128

        ElseIf unidadeDeEntrada = "MB" And unidadeDeSaida = "KB" Then
            Return txtVlEnt.Text * 1024



        ElseIf unidadeDeEntrada = "Gb" And unidadeDeSaida = "KB" Then
            Return txtEnt.Text * 128 * 1024

        ElseIf unidadeDeEntrada = "GB" And unidadeDeSaida = "KB" Then
            Return txtVlEnt.Text * (1024 * 1024)



        End If
        '
        If unidadeDeEntrada = "B" And unidadeDeSaida = "MB" Then
            Return txtVlEnt.Text / (1024 * 1024)

        ElseIf unidadeDeEntrada = "KB" And unidadeDeSaida = "MB" Then
            Return txtVlEnt.Text / 1024

        ElseIf unidadeDeEntrada = unidadeDeSaida Then
            Return txtVlEnt.Text

        ElseIf unidadeDeEntrada = "GB" And unidadeDeSaida = "MB" Then
            Return txtVlEnt.Text * 1024

        End If
        '
        If unidadeDeEntrada = "B" And unidadeDeSaida = "GB" Then
            Return txtVlEnt.Text / (1024 * 1024 * 1024)

        ElseIf unidadeDeEntrada = "KB" And unidadeDeSaida = "GB" Then
            Return txtVlEnt.Text / (1024 * 1024)

        ElseIf unidadeDeEntrada = "MB" And unidadeDeSaida = "GB" Then
            Return txtVlEnt.Text / 1024

        ElseIf unidadeDeEntrada = unidadeDeSaida = "GB" Then
            Return txtVlEnt.Text

        End If

    End Function

    Private Sub txtVlEnt_TextChanged(sender As Object, e As EventArgs) Handles txtVlEnt.TextChanged
        Try
            If txtVlEnt.Text = "" Then txtVlEnt.Text = 0
            txtVlSd.Text = Convert(txtVlEnt.Text, txtEnt.Text, txtSd.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtEnt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtEnt.SelectedIndexChanged
        Try
            If txtVlEnt.Text = "" Then txtVlEnt.Text = 0
            txtVlSd.Text = Convert(txtVlEnt.Text, txtEnt.Text, txtSd.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSd.SelectedIndexChanged
        Try
            If txtVlEnt.Text = "" Then txtVlEnt.Text = 0
            txtVlSd.Text = Convert(txtVlEnt.Text, txtEnt.Text, txtSd.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class
