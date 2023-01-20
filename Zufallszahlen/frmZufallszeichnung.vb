Public Class frmZufallszeichnung

    Dim Obergrenze As Integer
    Dim Untergrenze As Integer
    Private Sub Btnrandomnumber_Click(sender As Object, e As EventArgs) Handles btnrandomnumber.Click
        Dim Zufallszahl As Decimal
        Zufallszahl = Rnd() 'diese Funktion generiert eine Zufallszahl zwischen 0 und 1.0
        Zufallszahl = Int(Rnd() * (Untergrenze + Obergrenze) + 1)
        lblrandomnumber.Text = Zufallszahl
    End Sub

    Private Sub FrmZufallszeichnung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize() 'Dieser Befehl 
        lblUGrenze.Text = hsbUGrenze.Value
        lblOGrenze.Text = HsbOGrenze.Value

    End Sub

    Private Sub Hsb_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbUGrenze.Scroll
        lblUGrenze.Text = hsbUGrenze.Value
        hsbUGrenze.Value = Untergrenze
    End Sub

    Private Sub HsbOGrenze_Scroll(sender As Object, e As ScrollEventArgs) Handles HsbOGrenze.Scroll
        lblOGrenze.Text = HsbOGrenze.Value
        HsbOGrenze.Value = Obergrenze
    End Sub
End Class
