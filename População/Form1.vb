Public Class Form1

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        End
    End Sub

    Private Sub Btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlimpar.Click
        Txtfilhos.Clear()
        Txtnome.Clear()
        Txtsalario.Clear()
        Lstnome.Items.Clear()
        Lstfilhos.Items.Clear()
        Lstsalario.Items.Clear()
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Lstnome.Items.Add(Txtnome.Text)
        Lstfilhos.Items.Add(Txtfilhos.Text)
        Lstsalario.Items.Add(Txtsalario.Text)
        Txtfilhos.Clear()
        Txtnome.Clear()
        Txtsalario.Clear()
    End Sub

    Private Sub Btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncalcular.Click
        Dim mediaSalario As Integer, indice As Integer, salario As Integer
        While (indice < Lstsalario.Items.Count)
            salario = salario + Lstsalario.Items.Item(indice)
            indice = indice + 1
        End While
        mediaSalario = salario / indice
        LblmdValorSalario.Text = mediaSalario.ToString("F")

        Dim mediaFilho As Integer, indice2 As Integer, filho As Integer
        While (indice2 < Lstfilhos.Items.Count)
            filho = filho + Lstfilhos.Items.Item(indice2)
            indice2 = indice2 + 1
        End While
        mediaFilho = filho / indice2
        LblmdValorFilhos.Text = mediaFilho.ToString("F")

        Dim maiorSalario As Integer, indice3 As Integer
        While (indice3 < Lstsalario.Items.Count)
            If maiorSalario < Lstsalario.Items.Item(indice3) Then
                maiorSalario = Lstsalario.Items.Item(indice3)
            Else
            End If
            indice3 = indice3 + 1
        End While
        LblvalorMaiorSalario.Text = maiorSalario.ToString("F")

        Dim mediaMenor As Double, indice4 As Double, indice5 As Double, contagem As Double
        While (indice4 < Lstsalario.Items.Count)
            If Lstsalario.Items.Item(indice4) < 150 Then
                mediaMenor = indice4 + 1
            End If
            indice4 = indice4 + 1
        End While
        While (indice5 < Lstsalario.Items.Count)
            indice5 = indice5 + 1
            contagem = indice5
        End While
        mediaMenor = mediaMenor / contagem
        mediaMenor = mediaMenor * 100
        LblvalorPercent.Text = mediaMenor.ToString("F")
    End Sub

    Private Sub Lblpercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lblpercent.Click

    End Sub
End Class
