Public Class NEnt
    Private n As Integer
    Public Sub NEnt()
        n = 0
    End Sub
    Public Sub cargar(nu As Integer)
        n = nu
    End Sub
    Public Function descargar()
        Return n
    End Function
    Public Function ContDig() As Integer
        Dim na, c As Integer
        na = n
        c = 0
        While na > 0
            na = na \ 10
            c = c + 1
        End While
        'n = na
        Return c
    End Function
    Public Sub Unir2nOK(n2 As Integer)
        Dim nd As Integer
        Dim nu As Nent
        nu = New Nent
        nu.n = n2
        nd = nu.ContDig()
        n = (n * 10 ^ nd) + nu.n
        'n = nd
    End Sub
    Public Function frecuencia(ele As Integer)
        Dim i, d, na, fre As Integer
        Dim b As Boolean
        b = True : na = n : i = 0 : fre = 0
        While (na > 0) And (b = True)
            i = i + 1
            d = na Mod 10
            na = na \ 10
            If d = ele Then
                fre = fre + 1
            End If
        End While
        Return fre
    End Function
    Public Sub segmetrRepNORep()
        Dim i, d, j, na, c As Integer
        Dim n2, n3 As NEnt
        n2 = New NEnt
        n3 = New NEnt
        na = n : j = -1 : c = -1
        While na > 0
            d = na Mod 10
            na = na \ 10
            If frecuencia(d) > 1 Then
                c = c + 1
                n2.n = n2.n + d * 10 ^ c

            End If
            If frecuencia(d) = 1 Then
                j = j + 1
                n3.n = n3.n + d * 10 ^ j
            End If

        End While
        n2.Unir2nOK(n3.n)
        n = n2.n
    End Sub


    Public Function Vfibo(ele As Integer) As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1
        Do
            c = a + b
            a = b : b = c
        Loop Until (c = ele) Or (c > ele)
        Return c = ele
    End Function
   
    Public Function buscarFiboMenor()
        Dim d1, d2, na As Integer
        Dim b As Boolean
        While (na > 0) And (b = True)
            d1 = na Mod 10
            na = na \ 10
            If Vfibo(d1) Then
                b = False
            End If
        End While
        While na > 0
            d2 = na Mod 10
            na = na \ 10
            If Vfibo(d2) Then
                If d2 < d1 Then
                    d1 = d2
                End If
            End If

        End While
        Return d1
    End Function
    Public Function buscarnoFiboMenor()
        Dim d1, d2, na As Integer
        Dim b As Boolean
        While (na > 0) And (b = True)
            d1 = na Mod 10
            na = na \ 10
            If Not (Vfibo(d1)) Then
                b = False
            End If
        End While
        While na > 0
            d2 = na Mod 10
            na = na \ 10
            If Not (Vfibo(d2)) Then
                If d2 < d1 Then
                    d1 = d2
                End If
            End If

        End While
        Return d1
    End Function
    Public Function fus_2n(ByVal n1 As Integer) As Integer
        Dim nr, c, m As Integer
        nr = n
        c = 0
        m = n1
        While m > 0
            m = m \ 10
            c = c + 1
        End While
        nr = nr * (10 ^ c) + n1
        Return nr
    End Function
    Public Sub cortar_dig(dig As Integer)
        Dim n1, c, d As Integer
        n1 = 0
        c = -1
        Do
            d = n Mod 10
            n = n \ 10
            If d <> dig Then
                c = c + 1
                n1 = n1 + d * (10 ^ c)
            End If
        Loop Until (d = dig) Or (n = 0)
        n = fus_2n(n1)
    End Sub
    Public Sub IntercalarFiboyNOfibo()
        Dim df, dnf, s As Integer
        Dim b As Boolean
        b = True
        While n > 0
            If b Then
                df = buscarFiboMenor()
                cortar_dig(df)
                s = s * 10 + df
            Else
                dnf = buscarnoFiboMenor()
                cortar_dig(dnf)
                s = s * 10 + dnf
            End If
            b = Not b
        End While
    End Sub
End Class
