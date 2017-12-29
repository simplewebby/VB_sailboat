Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtBoat1Race1.Focus()
        lblMessage.Text = String.Empty
        Try
            Dim intBoat1Race1 As Integer = CInt(txtBoat1Race1.Text)
            Dim intBoat2Race1 As Integer = CInt(txtBoat2Race1.Text)
            Dim intBoat3Race1 As Integer = CInt(txtBoat3Race1.Text)

            Dim intBoat1Race2 As Integer = CInt(txtBoat1Race2.Text)
            Dim intBoat2Race2 As Integer = CInt(txtBoat2Race2.Text)
            Dim intBoat3Race2 As Integer = CInt(txtBoat3Race2.Text)

            Dim intBoat1Race3 As Integer = CInt(txtBoat1Race3.Text)
            Dim intBoat2Race3 As Integer = CInt(txtBoat2Race3.Text)
            Dim intBoat3Race3 As Integer = CInt(txtBoat3Race3.Text)

            Dim intBoat1Race4 As Integer = CInt(txtBoat1Race4.Text)
            Dim intBoat2Race4 As Integer = CInt(txtBoat2Race4.Text)
            Dim intBoat3Race4 As Integer = CInt(txtBoat3Race4.Text)





            'constant
            Const NUM_RANK As Integer = 4

            ' Sum total for each boat
            lblBoat1Total.Text = (intBoat1Race1 + intBoat1Race2 + intBoat1Race3 + intBoat1Race4).ToString
            lblBoat2Total.Text = (intBoat2Race1 + intBoat2Race2 + intBoat2Race3 + intBoat2Race4).ToString
            lblBoat3Total.Text = (intBoat3Race1 + intBoat3Race2 + intBoat3Race3 + intBoat3Race4).ToString

            ' Calculate rank for each boat
            lblBoat1Rank.Text = (intBoat1Race1 + intBoat1Race2 + intBoat1Race3 + intBoat1Race4) / NUM_RANK
            lblBoat2Rank.Text = (intBoat2Race1 + intBoat2Race2 + intBoat2Race3 + intBoat2Race4) / NUM_RANK
            lblBoat3Rank.Text = (intBoat3Race1 + intBoat3Race2 + intBoat3Race3 + intBoat3Race4) / NUM_RANK


            Dim intBoat1Rank As Integer = CInt(lblBoat1Rank.Text)
            Dim intBoat2Rank As Integer = CInt(lblBoat2Rank.Text)
            Dim intBoat3Rank As Integer = CInt(lblBoat3Rank.Text)



            Dim Color As Color = Color.HotPink
            'opion 1
            If lblBoat1Rank.Text < lblBoat3Rank.Text And lblBoat1Rank.Text < lblBoat2Rank.Text And lblBoat2Rank.Text < lblBoat3Rank.Text Then

                lblBoat1Rank.Text = 1
                lblBoat2Rank.Text = 2
                lblBoat3Rank.Text = 3
                'option 2
            ElseIf lblBoat1Rank.Text < lblBoat3Rank.Text And lblBoat1Rank.Text < lblBoat2Rank.Text And lblBoat3Rank.Text < lblBoat2Rank.Text Then

                lblBoat1Rank.Text = 1
                lblBoat2Rank.Text = 3
                lblBoat3Rank.Text = 2
                'option 3
            ElseIf lblBoat2Rank.Text < lblBoat1Rank.Text And lblBoat2Rank.Text < lblBoat3Rank.Text And lblBoat1Rank.Text < lblBoat3Rank.Text Then
                lblBoat1Rank.Text = 2
                lblBoat2Rank.Text = 1
                lblBoat3Rank.Text = 3

                'option 4
            ElseIf lblBoat3Rank.Text < lblBoat1Rank.Text And lblBoat3Rank.Text < lblBoat2Rank.Text And lblBoat1Rank.Text < lblBoat2Rank.Text Then

                lblBoat1Rank.Text = 2
                lblBoat2Rank.Text = 3
                lblBoat3Rank.Text = 1


                'option 5
            ElseIf lblBoat2Rank.Text < lblBoat1Rank.Text And lblBoat2Rank.Text < lblBoat3Rank.Text And lblBoat3Rank.Text < lblBoat1Rank.Text Then

                lblBoat1Rank.Text = 3
                lblBoat2Rank.Text = 1
                lblBoat3Rank.Text = 2

                'option 6
            ElseIf lblBoat3Rank.Text < lblBoat1Rank.Text And lblBoat3Rank.Text < lblBoat2Rank.Text And lblBoat2Rank.Text < lblBoat1Rank.Text Then

                lblBoat1Rank.Text = 3
                lblBoat2Rank.Text = 2
                lblBoat3Rank.Text = 1

                'display tie score
            ElseIf lblBoat3Rank.Text = lblBoat2Rank.Text And lblBoat3Rank.Text = lblBoat1Rank.Text And lblBoat2Rank.Text = lblBoat1Rank.Text And lblBoat2Rank.Text = lblBoat3Rank.Text And lblBoat1Rank.Text = lblBoat2Rank.Text And lblBoat1Rank.Text = lblBoat3Rank.Text Then
                lblBoat1Rank.BackColor = Color
                lblBoat2Rank.BackColor = Color
                lblBoat3Rank.BackColor = Color

            ElseIf lblBoat3Rank.Text = lblBoat2Rank.Text Or lblBoat3Rank.Text = lblBoat1Rank.Text Or lblBoat2Rank.Text = lblBoat1Rank.Text Or lblBoat2Rank.Text = lblBoat3Rank.Text Or lblBoat1Rank.Text = lblBoat2Rank.Text Or lblBoat1Rank.Text = lblBoat3Rank.Text Then


                lblMessage.Text = "TIE"
            End If

        Catch
            lblMessage.Text = "Please, enter an integer"
        End Try


    End Sub

    Private Function Red() As Color
        Throw New NotImplementedException()
    End Function

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoat1Race1.Focus()
        txtBoat1Race1.Clear()
        txtBoat2Race1.Clear()
        txtBoat3Race1.Clear()


        txtBoat1Race2.Clear()
        txtBoat2Race2.Clear()
        txtBoat3Race2.Clear()


        txtBoat1Race3.Clear()
        txtBoat2Race3.Clear()
        txtBoat3Race3.Clear()


        txtBoat1Race4.Clear()
        txtBoat2Race4.Clear()
        txtBoat3Race4.Clear()

        lblBoat1Rank.Text = String.Empty
        lblBoat2Rank.Text = String.Empty
        lblBoat3Rank.Text = String.Empty



        lblBoat1Total.Text = String.Empty
        lblBoat2Total.Text = String.Empty
        lblBoat3Total.Text = String.Empty

        lblBoat1Rank.BackColor = Nothing
        lblBoat2Rank.BackColor = Nothing
        lblBoat3Rank.BackColor = Nothing
        lblMessage.Text = String.Empty

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SailBoat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

