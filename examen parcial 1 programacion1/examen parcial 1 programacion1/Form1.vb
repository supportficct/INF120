Public Class Form1
    Dim n1 As NEnt

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.cargar(introd.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        respuest.Text = n1.descargar()

    End Sub

    
    Private Sub ExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenToolStripMenuItem.Click
        n1.segmetrRepNORep()
    End Sub
End Class
