Public Class Matriz
    Const MAXf = 30
    Const MAXc = 30
    Private x(MAXf, MAXc) As Integer
    Private f As Integer
    Private c As Integer
    Public Sub Matriz()
        f = 0 : c = 0
    End Sub
    Public Sub cargarRND(df As Integer, dc As Integer, a As Integer, b As Integer)
        Dim fi, ci, ele As Integer
        f = df
        c = dc
        For fi = 1 To f
            For ci = 1 To c
                ele = a + Rnd() * (b - a)
                x(fi, ci) = ele
            Next
        Next
    End Sub
    Public Sub CargaManual(df As Integer, dc As Integer)
        Dim fi, ci As Integer
        f = df : c = dc
        For fi = 1 To f
            For ci = 1 To c
                x(fi, ci) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Function VerEle(pf As Integer, pc As Integer)
        Return x(pf, pc)
    End Function

    Public Function Descargar()
        Dim s As String
        Dim fi, ci As Integer
        s = ""
        For fi = 1 To f
            For ci = 1 To c

                s = s + Str(x(fi, ci)) + " "
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function
    Public Sub SumaMatrices(x1 As Matriz, x2 As Matriz)
        Dim fi, ci As Integer
        For fi = 1 To f
            For ci = 1 To c
                x2.x(fi, ci) = x(fi, ci) + x1.x(fi, ci)
            Next
        Next
        x2.f = f : x2.c = c
    End Sub
    Public Function verifOrden()
        Dim fi, ci, aux As Integer
        Dim b As Boolean
        Dim s As String
        s = ""
        b = True : aux = x(1, 1) : fi = 1
        While (fi <= f) And (b = True)
            ci = 1
            While (ci <= c) And (b = True)
                If Not (x(fi, ci) >= aux) Then
                    b = False
                Else
                    aux = x(fi, ci)
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        If b Then
            s = "SI está Ordenado"
        Else
            s = "NO está Ordenado"
        End If
        Return s
    End Function
    Public Function AcumularConPrimos()
        Dim fi, ci As Integer
        Dim AUX As Double
        Dim b As Boolean
        Dim n1 As NEnt
        n1 = New NEnt
        b = True
        For fi = f To 1 Step -1
            For ci = c To 1 Step -1
                n1.Cargar(x(fi, ci))
                If n1.Vprim Then
                    If b Then
                        AUX = AUX - Math.Sqrt(x(fi, ci))
                    Else
                        AUX = AUX + Math.Sqrt(x(fi, ci))
                    End If
                    b = Not b
                End If
            Next
        Next
        Return AUX
    End Function
    Public Function BuscarElementoMayor()
        Dim fi, ci, may, a, b As Integer
        Dim s As String
        may = x(1, 1) : a = 1 : b = 1
        For fi = 1 To f
            For ci = 1 To c
                If may < x(fi, ci) Then
                    may = x(fi, ci) : a = fi : b = ci
                End If
            Next
        Next
        s = "Fila :" + Str(a) + Chr(13) + Chr(10) + "Columna :" + Str(b)
        Return s
    End Function
    Public Function FrecuenciaDeElementoEnUnRango(ele As Integer, fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim f1, c1, fr As Integer
        fr = 0
        For f1 = fi To ff
            For c1 = ci To cf
                If ele = x(f1, c1) Then
                    fr = fr + 1
                End If
            Next
        Next
        Return fr
    End Function
    Public Function EncontrarElmentoDeMayorFrecuenciaDeUNRango(fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim f1, c1, ele, fr, Mfr As Integer
        Mfr = 0 : fr = 0
        For f1 = fi To ff
            For c1 = ci To cf
                fr = FrecuenciaDeElementoEnUnRango(x(f1, c1), fi, ci, ff, cf)
                If Mfr < fr Then
                    ele = x(f1, c1) : Mfr = fr
                End If
            Next
        Next
        Return ele
    End Function
    Public Sub Inter(f1 As Integer, c1 As Integer, f2 As Integer, c2 As Integer)
        Dim aux As Integer
        aux = x(f1, c1)
        x(f1, c1) = x(f2, c2)
        x(f2, c2) = aux
    End Sub
    Public Function VerifOrdenDesendente()
        Dim fi, ci, aux As Integer
        Dim b As Boolean
        Dim s As String
        b = True : fi = 1 : s = ""
        aux = x(1, 1)
        While (fi <= f) And (b = True)
            ci = 1
            While (ci <= c) And (b = True)
                If aux >= x(fi, ci) Then
                    aux = x(fi, ci)
                Else
                    b = False
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        If b Then
            s = "SI está Ordenado"
        Else
            s = "NO está Ordenado"
        End If
        Return s
    End Function
    Public Function VerifEle(ele As Integer)
        Dim fi, ci As Integer
        Dim b As Boolean
        b = False : fi = 1
        While (fi <= f) And (b = False)
            ci = 1
            While (ci <= c) And (b = False)
                If ele = x(fi, ci) Then
                    b = True
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        Return b
    End Function
    Public Function VerificarSiMatrizEstaIncluidaEnOtra(x2 As Matriz)
        Dim fi, ci As Integer
        Dim b As Boolean
        b = True : fi = 1
        While (fi <= f) And (b = True)
            ci = 1
            While (ci <= c) And (b = True)
                If Not (x2.VerifEle(x(fi, ci))) Then
                    b = False
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        Return b
    End Function
    Public Sub FREC()
        Dim f1, c1, fr As Integer
        fr = 0
        For f1 = 1 To f

            fr = EncontrarElmentoDeMayorFrecuenciaDeUNRango(f1, c1, f1, c)
            x(f1, f + 1) = fr

        Next
        c = c + 1
    End Sub
    Public Sub Intercolumna(ByVal f1 As Integer, ByVal c1 As Integer, ByVal f2 As Integer, ByVal c2 As Integer)
        Dim aux As Integer

        For f1 = f1 To f2
            For c1 = c1 To c2
                aux = x(f1, c1)
                x(f1, c1) = x(f1, c1 + 1)
                x(f1, c1 + 1) = aux
            Next
        Next
        
    End Sub
    Public Sub interfin(ByVal cr As Integer)

        For fi = 1 To f
            Intercolumna(fi, cr, f, c)

        Next
        c = c - 1
    End Sub
    Public Sub interfila(ByVal f1 As Integer, ByVal c1 As Integer, ByVal f2 As Integer, ByVal c2 As Integer)
        Dim aux As Integer

        For c1 = c1 To c2
            For f1 = f1 To f2
                aux = x(f1, c1)
                x(f1, c1) = x(f1 + 1, c1)
                x(f1 + 1, c1) = aux
            Next

        Next
    End Sub
    Public Sub interfin2(ByVal cf As Integer)

        For c1 = 1 To c
            interfila(cf, c1, f, c)
        Next

        f = f - 1
    End Sub
    Public Sub OrdenarFilasAsendentemente()
        Dim fi, ci, cd As Integer
        For fi = 1 To f
            For ci = 1 To c
                For cd = ci To c
                    If x(fi, cd) < x(fi, ci) Then
                        Inter(fi, cd, fi, ci)
                    End If
                Next
            Next
        Next
    End Sub
    Public Sub parimp()
        Dim aux, sep, c1 As Integer
        OrdenarFilasAsendentemente()
        For f1 = 1 To f
            sep = 1
            For sep = 1 To c
                c1 = 1
                For c1 = 1 To c - 1
                    If (x(f1, c1) Mod 2 = 1) And (x(f1, c1 + 1) Mod 2 = 0) Then
                        aux = x(f1, c1)
                        x(f1, c1) = x(f1, c1 + 1)
                        x(f1, c1 + 1) = aux
                    End If
                Next
            Next
        Next
    End Sub

End Class

