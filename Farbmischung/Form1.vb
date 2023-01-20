Public Class Form1

    Dim R As Integer
    Dim G As Integer
    Dim B As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        End
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        lblfarbeR.Text = HScrollBar1.Value
        lblFafrbeChema1.BackColor = Sc
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        lblFarbeB.Text = HScrollBar3.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        lblFarbeB.Text = HScrollBar2.Value
    End Sub


End Class
