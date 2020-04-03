Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        MsgBox("Hola mundo")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_primervalor.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_segundovalor.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim val1 As Integer = Integer.Parse(txt_primervalor.Text)
        Dim val2 As Integer = Integer.Parse(txt_segundovalor.Text)
        Dim resultado As Double = 0
        Dim operador As String = cnb_operador.Text

        Select Case operador

            Case "Suma"
                resultado = val1 + val2

            Case "Resta"
                resultado = val1 - val2

            Case "Division"
                If val2 <> 0 Then
                    resultado = val1 / val2
                Else
                    MsgBox("No se puede dividir entre 0")
                End If

            Case "Multiplicacion"
                resultado = val1 * val2

            Case Else
                MsgBox("Debe seleccionar un operador")
        End Select

        txt_resultado.Text = resultado

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_segundovalor.TextChanged

    End Sub

    Private Sub lbl_operador_Click(sender As Object, e As EventArgs) Handles lbl_operador.Click

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_primervalor.Text = " "
        txt_segundovalor.Text = " "
        txt_resultado.Text = " "


    End Sub
End Class
