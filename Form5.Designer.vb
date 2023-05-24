<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label1 = New Label()
        Panel1Leg = New Panel()
        TextBox1 = New TextBox()
        ButNumAle = New Button()
        ButMudCorFunForm = New Button()
        ButMudCorFundLeg = New Button()
        ButMostrar = New Button()
        ButEsconder = New Button()
        Panel1Leg.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Location = New Point(133, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Panel1Leg
        ' 
        Panel1Leg.Controls.Add(TextBox1)
        Panel1Leg.Controls.Add(ButNumAle)
        Panel1Leg.Controls.Add(ButMudCorFunForm)
        Panel1Leg.Controls.Add(ButMudCorFundLeg)
        Panel1Leg.Controls.Add(ButMostrar)
        Panel1Leg.Controls.Add(ButEsconder)
        Panel1Leg.Controls.Add(Label1)
        Panel1Leg.Location = New Point(221, 12)
        Panel1Leg.Name = "Panel1Leg"
        Panel1Leg.Size = New Size(363, 390)
        Panel1Leg.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(101, 81)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(169, 23)
        TextBox1.TabIndex = 6
        TextBox1.Text = "Isto é uma legenda"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' ButNumAle
        ' 
        ButNumAle.Location = New Point(20, 290)
        ButNumAle.Name = "ButNumAle"
        ButNumAle.Size = New Size(322, 22)
        ButNumAle.TabIndex = 5
        ButNumAle.Text = "Escrever na legenda um número aleatório ente 1 e 1000"
        ButNumAle.UseVisualStyleBackColor = True
        ' 
        ' ButMudCorFunForm
        ' 
        ButMudCorFunForm.BackColor = Color.Black
        ButMudCorFunForm.ForeColor = Color.White
        ButMudCorFunForm.Location = New Point(68, 261)
        ButMudCorFunForm.Name = "ButMudCorFunForm"
        ButMudCorFunForm.Size = New Size(234, 23)
        ButMudCorFunForm.TabIndex = 4
        ButMudCorFunForm.Text = "Mudar a cor de fundo do formulário"
        ButMudCorFunForm.UseVisualStyleBackColor = False
        ' 
        ' ButMudCorFundLeg
        ' 
        ButMudCorFundLeg.BackColor = Color.Transparent
        ButMudCorFundLeg.ForeColor = Color.IndianRed
        ButMudCorFundLeg.Location = New Point(68, 232)
        ButMudCorFundLeg.Name = "ButMudCorFundLeg"
        ButMudCorFundLeg.Size = New Size(234, 23)
        ButMudCorFundLeg.TabIndex = 3
        ButMudCorFundLeg.Text = "Mudar a cor de fundo da legenda"
        ButMudCorFundLeg.UseVisualStyleBackColor = False
        ' 
        ' ButMostrar
        ' 
        ButMostrar.Location = New Point(68, 203)
        ButMostrar.Name = "ButMostrar"
        ButMostrar.Size = New Size(234, 23)
        ButMostrar.TabIndex = 2
        ButMostrar.Text = "Mostrar a legenda"
        ButMostrar.UseVisualStyleBackColor = True
        ' 
        ' ButEsconder
        ' 
        ButEsconder.Location = New Point(68, 174)
        ButEsconder.Name = "ButEsconder"
        ButEsconder.Size = New Size(234, 23)
        ButEsconder.TabIndex = 1
        ButEsconder.Text = "Esconder a legenda"
        ButEsconder.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1Leg)
        Name = "Form5"
        Text = "Form5"
        Panel1Leg.ResumeLayout(False)
        Panel1Leg.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1Leg As Panel
    Friend WithEvents ButNumAle As Button
    Friend WithEvents ButMudCorFunForm As Button
    Friend WithEvents ButMudCorFundLeg As Button
    Friend WithEvents ButMostrar As Button
    Friend WithEvents ButEsconder As Button
    Friend WithEvents TextBox1 As TextBox
End Class
