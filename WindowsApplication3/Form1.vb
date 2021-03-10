Imports Microsoft.VisualBasic.PowerPacks

Public Class f

    Public Shared q1 As Quadrado = New Quadrado
    Public Shared q2 As Quadrado = New Quadrado
    Public Shared q3 As Quadrado = New Quadrado
    Public Shared q4 As Quadrado = New Quadrado
    Public Shared q5 As Quadrado = New Quadrado
    Public Shared q6 As Quadrado = New Quadrado
    Public Shared q7 As Quadrado = New Quadrado
    Public Shared q8 As Quadrado = New Quadrado
    Public Shared q9 As Quadrado = New Quadrado
    Public Shared q10 As Quadrado = New Quadrado
    Public Shared q11 As Quadrado = New Quadrado
    Public Shared q12 As Quadrado = New Quadrado
    Public Shared q13 As Quadrado = New Quadrado
    Public Shared q14 As Quadrado = New Quadrado
    Public Shared q15 As Quadrado = New Quadrado
    Public Shared q16 As Quadrado = New Quadrado
    '
    Public lista(0 To 16) As Quadrado

    Public Sub init(ByRef q1, ByRef q2, ByRef q3, ByRef q4, ByRef q5, ByRef q6, ByRef q7, ByRef q8, ByRef q9, ByRef q10, ByRef q11, ByRef q12, ByRef q13, ByRef q14, ByRef q15, ByRef q16)

        rs1.BackgroundImage = My.Resources.i1
        q1.rs = rs1
        q1.numero = 1
        q1.isBlack = True

        rs2.BackgroundImage = My.Resources.i2
        q2.rs = rs2
        q2.numero = 2

        rs3.BackgroundImage = My.Resources.i3
        q3.rs = rs3
        q3.numero = 3

        rs4.BackgroundImage = My.Resources.i4
        q4.rs = rs4
        q4.numero = 4


        rs5.BackgroundImage = My.Resources.i5
        q5.rs = rs5
        q5.numero = 5

        rs6.BackgroundImage = My.Resources.i6
        q6.rs = rs6
        q6.numero = 6

        rs7.BackgroundImage = My.Resources.i7
        q7.rs = rs7
        q7.numero = 7

        rs8.BackgroundImage = My.Resources.i8
        q8.rs = rs8
        q8.numero = 8

        rs9.BackgroundImage = My.Resources.i9
        q9.rs = rs9
        q9.numero = 9

        rs10.BackgroundImage = My.Resources.i10
        q10.rs = rs10
        q10.numero = 10

        rs11.BackgroundImage = My.Resources.i11
        q11.rs = rs11
        q11.numero = 11

        rs12.BackgroundImage = My.Resources.i12
        q12.rs = rs12
        q12.numero = 12

        rs13.BackgroundImage = My.Resources.i13
        q13.rs = rs13
        q13.numero = 13

        rs14.BackgroundImage = My.Resources.i14
        q14.rs = rs14
        q14.numero = 14

        rs15.BackgroundImage = My.Resources.i15
        q15.rs = rs15
        q15.numero = 15

        rs16.BackgroundImage = My.Resources.i16
        q16.rs = rs16
        q16.numero = 16

        ' peças que estao ao lado de q1
        q1.down = q5.rs
        q1.right = q2.rs
        ' peças que estao ao lado de q2
        q2.right = q3.rs
        q2.left = q1.rs
        q2.down = q6.rs
        ' peças que estao ao lado de q3
        q3.down = q7.rs
        q3.left = q2.rs
        q3.right = q4.rs
        ' peças que estao ao lado de q4
        q4.down = q8.rs
        q4.left = q3.rs
        ' peças que estao ao lado de q5
        q5.up = q1.rs
        q5.down = q9.rs
        q5.right = q6.rs
        ' peças que estaoao lado de q6
        q6.up = q2.rs
        q6.down = q10.rs
        q6.left = q5.rs
        q6.right = q7.rs
        'peças que estao ao lado de q7
        q7.up = q3.rs
        q7.down = q11.rs
        q7.left = q6.rs
        q7.right = q8.rs
        'peças que estao ao lado de q8
        q8.up = q4.rs
        q8.down = q12.rs
        q8.left = q7.rs
        'peças que estao ao lado de q9
        q9.up = q5.rs
        q9.down = q13.rs
        q9.right = q10.rs
        'peças que estao ao lado de q10
        q10.up = q6.rs
        q10.down = q14.rs
        q10.left = q9.rs
        q10.right = q11.rs
        'peças que estao ao lado de q11
        q11.up = q7.rs
        q11.down = q15.rs
        q11.left = q10.rs
        q11.right = q12.rs
        'peças que estao ao lado de q12
        q12.up = q8.rs
        q12.down = q16.rs
        q12.left = q11.rs
        'peças que estao ao lado de q13
        q13.up = q9.rs
        q13.right = q14.rs
        'peças que estao ao lado de q14
        q14.up = q10.rs
        q14.left = q13.rs
        q14.right = q15.rs
        'peças que estao ao lado de q15
        q15.up = q11.rs
        q15.left = q14.rs
        q15.right = q16.rs
        'peças que estao ao lado de q16
        q16.up = q12.rs
        q16.left = q15.rs

        Try
            lista(1) = q1
            lista(2) = q2
            lista(3) = q3
            lista(4) = q4
            lista(5) = q5
            lista(6) = q6
            lista(7) = q7
            lista(8) = q8
            lista(9) = q9
            lista(10) = q10
            lista(11) = q11
            lista(12) = q12
            lista(13) = q13
            lista(14) = q14
            lista(15) = q15
            lista(16) = q16
        Catch ex As NullReferenceException
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        init(q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16)
    End Sub

    Private Sub rs1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs1.Click
        q1.movimento()
    End Sub
    Private Sub rs2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs2.Click
        q2.movimento()
    End Sub
    Private Sub rs3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs3.Click
        q3.movimento()
    End Sub
    Private Sub rs4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs4.Click
        q4.movimento()
    End Sub
    Private Sub rs5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs5.Click
        q5.movimento()
    End Sub
    Private Sub rs6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs6.Click
        q6.movimento()
    End Sub
    Private Sub rs7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs7.Click
        q7.movimento()
    End Sub
    Private Sub rs8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs8.Click
        q8.movimento()
    End Sub
    Private Sub rs9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs9.Click
        q9.movimento()
    End Sub
    Private Sub rs10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs10.Click
        q10.movimento()
    End Sub
    Private Sub rs11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs11.Click
        q11.movimento()
    End Sub
    Private Sub rs12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs12.Click
        q12.movimento()
    End Sub
    Private Sub rs13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs13.Click
        q13.movimento()
    End Sub
    Private Sub rs14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs14.Click
        q14.movimento()
    End Sub
    Private Sub rs15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs15.Click
        q15.movimento()
    End Sub
    Private Sub rs16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rs16.Click
        q16.movimento()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.troca()
        Me.troca()
        Me.troca()
        Me.troca()
        Me.troca()

    End Sub
    Sub troca() 'Troca apenas 2 quadrados de posição
        Dim x1, x2 As Integer
        x1 = 0
        x2 = 0
        Randomize()
        While x1 = x2
            x1 = CInt(Int((16 * Rnd()) + 1))
            x2 = CInt(Int((16 * Rnd()) + 1))
        End While
        'troca imagem
        Dim aux As Quadrado = New Quadrado
        Dim t1 As Quadrado = New Quadrado
        Dim t2 As Quadrado = New Quadrado

        t1 = lista(x1)
        t2 = lista(x2)

        ' isso troca tambem o fato da peça ser vazia
        If t1.isBlack = True Then

            t1.isBlack = False
            t2.isBlack = True
            t1.rs.BackgroundImage = t2.rs.BackgroundImage
            t2.rs.BackgroundImage = My.Resources.i1

        ElseIf t2.isBlack = True Then
            t1.isBlack = True
            t2.isBlack = False
            t2.rs.BackgroundImage = t1.rs.BackgroundImage
            t1.rs.BackgroundImage = My.Resources.i1

        Else
            Try
                aux.rs.BackgroundImage = t1.rs.BackgroundImage
                t1.rs.BackgroundImage = t2.rs.BackgroundImage
                t2.rs.BackgroundImage = aux.rs.BackgroundImage

            Catch ex As NullReferenceException
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

End Class
