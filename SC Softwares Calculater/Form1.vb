Public Class Form1

    Dim Expression As String
    Dim choice As Boolean = False
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim operations As Integer
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "1"
        Else
            inputbx.Text = "1"
        End If
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "2"
        Else
            inputbx.Text = "2"
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "3"
        Else
            inputbx.Text = "3"
        End If
    End Sub

    Private Sub BunifuImageButton9_Click(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "4"
        Else
            inputbx.Text = "4"
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "5"
        Else
            inputbx.Text = "5"
        End If
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "6"
        Else
            inputbx.Text = "6"
        End If
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "7"
        Else
            inputbx.Text = "7"
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "8"
        Else
            inputbx.Text = "8"
        End If
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "9"
        Else
            inputbx.Text = "9"
        End If
    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click
        If inputbx.Text <> "0" Then
            inputbx.Text += "0"
        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        If Not (inputbx.Text.Contains(".")) Then
            inputbx.Text += "."
        End If
    End Sub

    Private Sub BunifuImageButton12_Click(sender As Object, e As EventArgs) Handles BunifuImageButton12.Click
        'inputbx.Text = inputbx.Text.Substring(0, inputbx.Text.Length - 1)
        inputbx.Text = "0"
    End Sub

    Private Sub BunifuImageButton14_Click(sender As Object, e As EventArgs) Handles BunifuImageButton14.Click
        num1 = inputbx.Text
        inputbx.Text = "0"
        choice = True
        operations = 1 'this is the addition
    End Sub

    Private Sub BunifuImageButton13_Click(sender As Object, e As EventArgs) Handles BunifuImageButton13.Click
        num1 = inputbx.Text
        inputbx.Text = "0"
        choice = True
        operations = 2 'this is the division
    End Sub

    Private Sub BunifuImageButton15_Click(sender As Object, e As EventArgs) Handles BunifuImageButton15.Click
        num1 = inputbx.Text
        inputbx.Text = "0"
        choice = True
        operations = 3 'this is the subtraction
    End Sub

    Private Sub BunifuImageButton16_Click(sender As Object, e As EventArgs) Handles BunifuImageButton16.Click
        num1 = inputbx.Text
        inputbx.Text = "0"
        choice = True
        operations = 4 'this is the multiplication
    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        If choice = True Then
            num2 = inputbx.Text
            If operations = 1 Then
                inputbx.Text = num1 + num2
            ElseIf operations = 3 Then
                inputbx.Text = num1 - num2
            ElseIf operations = 4 Then
                inputbx.Text = num1 * num2
            Else
                If inputbx.Text = "0" Then
                    inputbx.Text = "Isai Nhamber iri valid!!!"
                Else
                    inputbx.Text = num1 / num2
                End If
            End If
        End If
        choice = False

    End Sub

    Private Sub BunifuImageButton17_Click(sender As Object, e As EventArgs) Handles BunifuImageButton17.Click
        Me.Dispose()
        Environment.Exit(0)
    End Sub

End Class
