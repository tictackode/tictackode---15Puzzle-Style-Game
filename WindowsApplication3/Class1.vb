Imports Microsoft.VisualBasic.PowerPacks
Public Class Quadrado
    Public rs As RectangleShape = New RectangleShape
    Public numero As Byte
    Public up As RectangleShape = New RectangleShape
    Public down As RectangleShape = New RectangleShape
    Public left As RectangleShape = New RectangleShape
    Public right As RectangleShape = New RectangleShape
    Public isBlack As Boolean = False ' atributo para identificar o espaço vazio
    Public Shared nulo As Quadrado = New Quadrado
    Public Enum D
        UP
        DOWN
        LEFT
        RIGHT
    End Enum

    Public Function retornaNumero() As Byte
        Return Me.numero
    End Function
    Public Sub movimento()

        Dim control As Boolean = False
        If Me.isBlack = True Then
            If (Me.up.Focused = True) Then

                TrocaImagem(Me.up, Me)
                TrocaBlocoVazio(Me, D.UP)
                control = True

            ElseIf (Me.down.Focused = True) Then
                TrocaImagem(Me.down, Me)
                TrocaBlocoVazio(Me, D.DOWN)
                control = True
            ElseIf (Me.left.Focused = True) Then

                TrocaImagem(Me.left, Me)
                TrocaBlocoVazio(Me, D.LEFT)
                control = True

            ElseIf (Me.right.Focused = True) Then
                TrocaImagem(Me.right, Me)
                TrocaBlocoVazio(Me, D.RIGHT)
                control = True

            End If
        End If

    End Sub
    Public Function confereVazio(ByVal atual As Quadrado, ByVal dir As D) As Boolean
        ' essafuncao recebe um quadrado e uma direção e retorna se o tal quadrado adjacente é vazio

        Dim aux As Byte = atual.retornaNumero()
        Dim b As Boolean = False

        Select Case dir
            Case D.UP
                If (aux > 4) Then
                    aux -= 4

                End If
            Case D.DOWN
                If (aux < 13) Then
                    aux += 4

                End If
            Case D.LEFT
                If (aux <> 9 AndAlso aux <> 5 AndAlso aux <> 1 AndAlso aux <> 13) Then
                    aux -= 1

                End If
            Case D.RIGHT
                If (aux <> 4 AndAlso aux <> 8 AndAlso aux <> 12 AndAlso aux <> 16) Then
                    aux += 1

                End If
        End Select

        ' confere se o bloco e vazio, seta b=true se for   e retorna b

        Select Case aux
            Case 1
                If f.q1.isBlack = True Then
                    b = True
                End If
            Case 2
                If f.q2.isBlack = True Then
                    b = True
                End If
            Case 3
                If f.q3.isBlack = True Then
                    b = True
                End If
            Case 4
                If f.q4.isBlack = True Then
                    b = True
                End If
            Case 5
                If f.q5.isBlack = True Then
                    b = True
                End If
            Case 6
                If f.q6.isBlack = True Then
                    b = True
                End If
            Case 7
                If f.q7.isBlack = True Then
                    b = True
                End If
            Case 8
                If f.q8.isBlack = True Then
                    b = True
                End If
            Case 9
                If f.q9.isBlack = True Then
                    b = True
                End If
            Case 10
                If f.q10.isBlack = True Then
                    b = True
                End If
            Case 11
                If f.q11.isBlack = True Then
                    b = True
                End If
            Case 12
                If f.q12.isBlack = True Then
                    b = True
                End If
            Case 13
                If f.q13.isBlack = True Then
                    b = True
                End If
            Case 14
                If f.q14.isBlack = True Then
                    b = True
                End If
            Case 15
                If f.q15.isBlack = True Then
                    b = True
                End If
            Case 16
                If f.q16.isBlack = True Then
                    b = True
                End If
            Case Else
                b = False
        End Select
        Return b
    End Function
    Public Sub TrocaImagem(ByRef r1 As RectangleShape, ByRef r2 As Quadrado)
        Dim aux As Image

        aux = r1.BackgroundImage
        r1.BackgroundImage = r2.rs.BackgroundImage
        r2.rs.BackgroundImage = aux
        r2.rs.Update()
        r1.Update()

    End Sub
    Sub TrocaBlocoVazio(ByRef atual As Quadrado, ByVal dir As D)
        Dim aux As Byte = atual.retornaNumero()
        Select Case dir
            Case D.UP
                If (aux > 4) Then
                    aux -= 4
                    atual.isBlack = False
                End If
            Case D.DOWN
                If (aux < 13) Then
                    aux += 4
                    atual.isBlack = False
                End If
            Case D.LEFT
                If (aux <> 9 AndAlso aux <> 5 AndAlso aux <> 1 AndAlso aux <> 13) Then
                    aux -= 1
                    atual.isBlack = False
                End If
            Case D.RIGHT
                If (aux <> 4 AndAlso aux <> 8 AndAlso aux <> 12 AndAlso aux <> 16) Then
                    aux += 1
                    atual.isBlack = False
                End If
        End Select

        ' essa parte vai setar o bloco para ser vazio

        Select Case aux
            Case 1
                f.q1.isBlack = True
            Case 2
                f.q2.isBlack = True
            Case 3
                f.q3.isBlack = True
            Case 4
                f.q4.isBlack = True
            Case 5
                f.q5.isBlack = True
            Case 6
                f.q6.isBlack = True
            Case 7
                f.q7.isBlack = True
            Case 8
                f.q8.isBlack = True
            Case 9
                f.q9.isBlack = True
            Case 10
                f.q10.isBlack = True
            Case 11
                f.q11.isBlack = True
            Case 12
                f.q12.isBlack = True
            Case 13
                f.q13.isBlack = True
            Case 14
                f.q14.isBlack = True
            Case 15
                f.q15.isBlack = True
            Case 16
                f.q16.isBlack = True
        End Select

    End Sub
End Class
