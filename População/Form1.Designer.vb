<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lblnome = New System.Windows.Forms.Label()
        Me.Lblfilhos = New System.Windows.Forms.Label()
        Me.Lblsalario = New System.Windows.Forms.Label()
        Me.Txtsalario = New System.Windows.Forms.TextBox()
        Me.Txtnome = New System.Windows.Forms.TextBox()
        Me.Txtfilhos = New System.Windows.Forms.TextBox()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.Btnlimpar = New System.Windows.Forms.Button()
        Me.Lstnome = New System.Windows.Forms.ListBox()
        Me.Lstfilhos = New System.Windows.Forms.ListBox()
        Me.Lstsalario = New System.Windows.Forms.ListBox()
        Me.Lblnome2 = New System.Windows.Forms.Label()
        Me.Lblfilhos2 = New System.Windows.Forms.Label()
        Me.Lblsalario2 = New System.Windows.Forms.Label()
        Me.LblmdSalario = New System.Windows.Forms.Label()
        Me.LblmdFilhos = New System.Windows.Forms.Label()
        Me.LblmaiorSalario = New System.Windows.Forms.Label()
        Me.Lblpercent = New System.Windows.Forms.Label()
        Me.LblmdValorSalario = New System.Windows.Forms.Label()
        Me.LblmdValorFilhos = New System.Windows.Forms.Label()
        Me.LblvalorMaiorSalario = New System.Windows.Forms.Label()
        Me.LblvalorPercent = New System.Windows.Forms.Label()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lblnome
        '
        Me.Lblnome.AutoSize = True
        Me.Lblnome.Location = New System.Drawing.Point(12, 23)
        Me.Lblnome.Name = "Lblnome"
        Me.Lblnome.Size = New System.Drawing.Size(38, 13)
        Me.Lblnome.TabIndex = 0
        Me.Lblnome.Text = "Nome:"
        '
        'Lblfilhos
        '
        Me.Lblfilhos.AutoSize = True
        Me.Lblfilhos.Location = New System.Drawing.Point(12, 49)
        Me.Lblfilhos.Name = "Lblfilhos"
        Me.Lblfilhos.Size = New System.Drawing.Size(73, 13)
        Me.Lblfilhos.TabIndex = 1
        Me.Lblfilhos.Text = "Filhos (qntde):"
        '
        'Lblsalario
        '
        Me.Lblsalario.AutoSize = True
        Me.Lblsalario.Location = New System.Drawing.Point(12, 75)
        Me.Lblsalario.Name = "Lblsalario"
        Me.Lblsalario.Size = New System.Drawing.Size(42, 13)
        Me.Lblsalario.TabIndex = 2
        Me.Lblsalario.Text = "Salário:"
        '
        'Txtsalario
        '
        Me.Txtsalario.Location = New System.Drawing.Point(97, 72)
        Me.Txtsalario.Name = "Txtsalario"
        Me.Txtsalario.Size = New System.Drawing.Size(180, 20)
        Me.Txtsalario.TabIndex = 3
        '
        'Txtnome
        '
        Me.Txtnome.Location = New System.Drawing.Point(97, 20)
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(180, 20)
        Me.Txtnome.TabIndex = 4
        '
        'Txtfilhos
        '
        Me.Txtfilhos.Location = New System.Drawing.Point(97, 46)
        Me.Txtfilhos.Name = "Txtfilhos"
        Me.Txtfilhos.Size = New System.Drawing.Size(180, 20)
        Me.Txtfilhos.TabIndex = 5
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(12, 107)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(84, 39)
        Me.Btnadd.TabIndex = 6
        Me.Btnadd.Text = "Adicionar"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(193, 107)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(84, 39)
        Me.BtnSair.TabIndex = 7
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'Btnlimpar
        '
        Me.Btnlimpar.Location = New System.Drawing.Point(102, 107)
        Me.Btnlimpar.Name = "Btnlimpar"
        Me.Btnlimpar.Size = New System.Drawing.Size(84, 39)
        Me.Btnlimpar.TabIndex = 8
        Me.Btnlimpar.Text = "Limpar"
        Me.Btnlimpar.UseVisualStyleBackColor = True
        '
        'Lstnome
        '
        Me.Lstnome.FormattingEnabled = True
        Me.Lstnome.Location = New System.Drawing.Point(12, 187)
        Me.Lstnome.Name = "Lstnome"
        Me.Lstnome.Size = New System.Drawing.Size(79, 108)
        Me.Lstnome.TabIndex = 9
        '
        'Lstfilhos
        '
        Me.Lstfilhos.FormattingEnabled = True
        Me.Lstfilhos.Location = New System.Drawing.Point(107, 187)
        Me.Lstfilhos.Name = "Lstfilhos"
        Me.Lstfilhos.Size = New System.Drawing.Size(79, 108)
        Me.Lstfilhos.TabIndex = 10
        '
        'Lstsalario
        '
        Me.Lstsalario.FormattingEnabled = True
        Me.Lstsalario.Location = New System.Drawing.Point(198, 187)
        Me.Lstsalario.Name = "Lstsalario"
        Me.Lstsalario.Size = New System.Drawing.Size(79, 108)
        Me.Lstsalario.TabIndex = 11
        '
        'Lblnome2
        '
        Me.Lblnome2.AutoSize = True
        Me.Lblnome2.Location = New System.Drawing.Point(12, 162)
        Me.Lblnome2.Name = "Lblnome2"
        Me.Lblnome2.Size = New System.Drawing.Size(38, 13)
        Me.Lblnome2.TabIndex = 12
        Me.Lblnome2.Text = "Nome:"
        '
        'Lblfilhos2
        '
        Me.Lblfilhos2.AutoSize = True
        Me.Lblfilhos2.Location = New System.Drawing.Point(104, 162)
        Me.Lblfilhos2.Name = "Lblfilhos2"
        Me.Lblfilhos2.Size = New System.Drawing.Size(73, 13)
        Me.Lblfilhos2.TabIndex = 13
        Me.Lblfilhos2.Text = "Filhos (qntde):"
        '
        'Lblsalario2
        '
        Me.Lblsalario2.AutoSize = True
        Me.Lblsalario2.Location = New System.Drawing.Point(195, 162)
        Me.Lblsalario2.Name = "Lblsalario2"
        Me.Lblsalario2.Size = New System.Drawing.Size(42, 13)
        Me.Lblsalario2.TabIndex = 14
        Me.Lblsalario2.Text = "Salário:"
        '
        'LblmdSalario
        '
        Me.LblmdSalario.AutoSize = True
        Me.LblmdSalario.Location = New System.Drawing.Point(9, 326)
        Me.LblmdSalario.Name = "LblmdSalario"
        Me.LblmdSalario.Size = New System.Drawing.Size(87, 13)
        Me.LblmdSalario.TabIndex = 15
        Me.LblmdSalario.Text = "Média de salário:"
        '
        'LblmdFilhos
        '
        Me.LblmdFilhos.AutoSize = True
        Me.LblmdFilhos.Location = New System.Drawing.Point(9, 357)
        Me.LblmdFilhos.Name = "LblmdFilhos"
        Me.LblmdFilhos.Size = New System.Drawing.Size(81, 13)
        Me.LblmdFilhos.TabIndex = 16
        Me.LblmdFilhos.Text = "Média de filhos:"
        '
        'LblmaiorSalario
        '
        Me.LblmaiorSalario.AutoSize = True
        Me.LblmaiorSalario.Location = New System.Drawing.Point(9, 388)
        Me.LblmaiorSalario.Name = "LblmaiorSalario"
        Me.LblmaiorSalario.Size = New System.Drawing.Size(69, 13)
        Me.LblmaiorSalario.TabIndex = 17
        Me.LblmaiorSalario.Text = "Maior salário:"
        '
        'Lblpercent
        '
        Me.Lblpercent.AllowDrop = True
        Me.Lblpercent.AutoSize = True
        Me.Lblpercent.Location = New System.Drawing.Point(50, 419)
        Me.Lblpercent.Name = "Lblpercent"
        Me.Lblpercent.Size = New System.Drawing.Size(197, 13)
        Me.Lblpercent.TabIndex = 18
        Me.Lblpercent.Text = "Pessoas com menos de R$ 150 ( em %):"
        '
        'LblmdValorSalario
        '
        Me.LblmdValorSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblmdValorSalario.Location = New System.Drawing.Point(107, 325)
        Me.LblmdValorSalario.Name = "LblmdValorSalario"
        Me.LblmdValorSalario.Size = New System.Drawing.Size(140, 23)
        Me.LblmdValorSalario.TabIndex = 19
        '
        'LblmdValorFilhos
        '
        Me.LblmdValorFilhos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblmdValorFilhos.Location = New System.Drawing.Point(107, 357)
        Me.LblmdValorFilhos.Name = "LblmdValorFilhos"
        Me.LblmdValorFilhos.Size = New System.Drawing.Size(140, 23)
        Me.LblmdValorFilhos.TabIndex = 20
        '
        'LblvalorMaiorSalario
        '
        Me.LblvalorMaiorSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblvalorMaiorSalario.Location = New System.Drawing.Point(107, 387)
        Me.LblvalorMaiorSalario.Name = "LblvalorMaiorSalario"
        Me.LblvalorMaiorSalario.Size = New System.Drawing.Size(142, 23)
        Me.LblvalorMaiorSalario.TabIndex = 21
        '
        'LblvalorPercent
        '
        Me.LblvalorPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblvalorPercent.Location = New System.Drawing.Point(76, 444)
        Me.LblvalorPercent.Name = "LblvalorPercent"
        Me.LblvalorPercent.Size = New System.Drawing.Size(142, 23)
        Me.LblvalorPercent.TabIndex = 22
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(51, 470)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(186, 75)
        Me.Btncalcular.TabIndex = 23
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 551)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.LblvalorPercent)
        Me.Controls.Add(Me.LblvalorMaiorSalario)
        Me.Controls.Add(Me.LblmdValorFilhos)
        Me.Controls.Add(Me.LblmdValorSalario)
        Me.Controls.Add(Me.Lblpercent)
        Me.Controls.Add(Me.LblmaiorSalario)
        Me.Controls.Add(Me.LblmdFilhos)
        Me.Controls.Add(Me.LblmdSalario)
        Me.Controls.Add(Me.Lblsalario2)
        Me.Controls.Add(Me.Lblfilhos2)
        Me.Controls.Add(Me.Lblnome2)
        Me.Controls.Add(Me.Lstsalario)
        Me.Controls.Add(Me.Lstfilhos)
        Me.Controls.Add(Me.Lstnome)
        Me.Controls.Add(Me.Btnlimpar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Txtfilhos)
        Me.Controls.Add(Me.Txtnome)
        Me.Controls.Add(Me.Txtsalario)
        Me.Controls.Add(Me.Lblsalario)
        Me.Controls.Add(Me.Lblfilhos)
        Me.Controls.Add(Me.Lblnome)
        Me.Name = "Form1"
        Me.Text = "Média da população"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblnome As System.Windows.Forms.Label
    Friend WithEvents Lblfilhos As System.Windows.Forms.Label
    Friend WithEvents Lblsalario As System.Windows.Forms.Label
    Friend WithEvents Txtsalario As System.Windows.Forms.TextBox
    Friend WithEvents Txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Txtfilhos As System.Windows.Forms.TextBox
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents Btnlimpar As System.Windows.Forms.Button
    Friend WithEvents Lstnome As System.Windows.Forms.ListBox
    Friend WithEvents Lstfilhos As System.Windows.Forms.ListBox
    Friend WithEvents Lstsalario As System.Windows.Forms.ListBox
    Friend WithEvents Lblnome2 As System.Windows.Forms.Label
    Friend WithEvents Lblfilhos2 As System.Windows.Forms.Label
    Friend WithEvents Lblsalario2 As System.Windows.Forms.Label
    Friend WithEvents LblmdSalario As System.Windows.Forms.Label
    Friend WithEvents LblmdFilhos As System.Windows.Forms.Label
    Friend WithEvents LblmaiorSalario As System.Windows.Forms.Label
    Friend WithEvents Lblpercent As System.Windows.Forms.Label
    Friend WithEvents LblmdValorSalario As System.Windows.Forms.Label
    Friend WithEvents LblmdValorFilhos As System.Windows.Forms.Label
    Friend WithEvents LblvalorMaiorSalario As System.Windows.Forms.Label
    Friend WithEvents LblvalorPercent As System.Windows.Forms.Label
    Friend WithEvents Btncalcular As System.Windows.Forms.Button

End Class
