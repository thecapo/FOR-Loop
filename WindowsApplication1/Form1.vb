Option Strict On
Public Class Form1
   
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        'store date to rand and num
        'rand for random numbers
        'num ranges from 0 to 49
        Dim rand As Integer
        Dim num As Integer

        For num = 0 To 49
            Randomize()
            rand = CInt(Int((11 * Rnd())))
            lstbxIntNum.Items.Add(rand.ToString)
        Next num
        MsgBox(lstbxIntNum.Items.Count)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'deletes selected item
        lstbxIntNum.Items.RemoveAt(lstbxIntNum.SelectedIndex)

    End Sub

   
    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click

        'deletes all items
        lstbxIntNum.Items.Clear()

    End Sub
End Class
