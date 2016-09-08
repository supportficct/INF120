Public Class Form1
    Dim x1, x2, x3 As Matriz
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x1 = New Matriz
        x2 = New Matriz
        x3 = New Matriz
    End Sub

    Private Sub CargarRandomicamentefcabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomicamentefcabToolStripMenuItem.Click
        x1.cargarRND(Ftex.Text, Ctex.Text, Atex.Text, btex.Text)
    End Sub

    Private Sub CargarManualmentefcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualmentefcToolStripMenuItem.Click
        x1.CargaManual(Ftex.Text, Ctex.Text)
    End Sub

    Private Sub VerElementoFCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerElementoFCToolStripMenuItem.Click
        x1tex.Text = x1.VerEle(Ftex.Text, Ctex.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        x1tex.Text = x1.Descargar
    End Sub

    Private Sub SumaDeMatricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDeMatricesToolStripMenuItem.Click
        x1.SumaMatrices(x2, x3)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        x2.cargarRND(Ftex.Text, Ctex.Text, Atex.Text, btex.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        respuestaX2.Text = x2.Descargar
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        respuestax3.Text = x3.Descargar
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        x3.cargarRND(Ftex.Text, Ctex.Text, Atex.Text, btex.Text)
    End Sub

    Private Sub VerificarOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarOrdenToolStripMenuItem.Click
        respuesta.Text = x1.verifOrden
    End Sub

    Private Sub Ejercicio1AcumularConPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1AcumularConPrimosToolStripMenuItem.Click
        respuesta.Text = x1.AcumularConPrimos()
    End Sub

    Private Sub Ejercicio2BuscarPosicionElementoMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2BuscarPosicionElementoMayorToolStripMenuItem.Click
        respuesta.Text = x1.BuscarElementoMayor
    End Sub

    Private Sub Ejercicio3EncontrarElementoDeMayorFrecuenciaFiciffcfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3EncontrarElementoDeMayorFrecuenciaFiciffcfToolStripMenuItem.Click
        respuesta.Text = x1.EncontrarElmentoDeMayorFrecuenciaDeUNRango(Ftex.Text, Ctex.Text, ffTex.Text, cfTex.Text)
    End Sub

    Private Sub Ejercicio4OrdenarFilasAscendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4OrdenarFilasAscendentementeToolStripMenuItem.Click
        x1.OrdenarFilasAsendentemente()
    End Sub

    Private Sub Ejercicio5VerificarOrdenDeescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5VerificarOrdenDeescendenteToolStripMenuItem.Click
        respuesta.Text = x1.VerifOrdenDesendente
    End Sub

    Private Sub Ejercicio6VerificarSiUnaMatrizEstaIncluidaEnOtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6VerificarSiUnaMatrizEstaIncluidaEnOtraToolStripMenuItem.Click
        respuesta.Text = x1.VerificarSiMatrizEstaIncluidaEnOtra(x2)
    End Sub

    Private Sub CargarManualmenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualmenteToolStripMenuItem.Click
        x2.CargaManual(Ftex.Text, Ctex.Text)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        x1.FREC()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        x1.interfin(Atex.Text)
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        x1.interfin2(Atex.Text)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        x1.parimp()
    End Sub

End Class
