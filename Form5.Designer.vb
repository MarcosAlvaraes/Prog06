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
        Panel1 = New Panel()
        ButNumAle = New Button()
        ButMudCorFunForm = New Button()
        ButMudCorFundLeg = New Button()
        ButMostrar = New Button()
        ButEsconder = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Location = New Point(131, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 0
        Label1.Text = "Isto é uma legenda"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ButNumAle)
        Panel1.Controls.Add(ButMudCorFunForm)
        Panel1.Controls.Add(ButMudCorFundLeg)
        Panel1.Controls.Add(ButMostrar)
        Panel1.Controls.Add(ButEsconder)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(221, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(365, 372)
        Panel1.TabIndex = 1
        ' 
        ' ButNumAle
        ' 
        ButNumAle.Location = New Point(20, 290)
        ButNumAle.Name = "ButNumAle"
        ButNumAle.Size = New Size(342, 23)
        ButNumAle.TabIndex = 5
        ButNumAle.Text = "Escrever na legenda um número aleatório ente 1 e 1000"
        ButNumAle.UseVisualStyleBackColor = True
        ' 
        ' ButMudCorFunForm
        ' 
        ButMudCorFunForm.Location = New Point(85, 261)
        ButMudCorFunForm.Name = "ButMudCorFunForm"
        ButMudCorFunForm.Size = New Size(234, 23)
        ButMudCorFunForm.TabIndex = 4
        ButMudCorFunForm.Text = "Mudar a cor de fundo do formulário"
        ButMudCorFunForm.UseVisualStyleBackColor = True
        ' 
        ' ButMudCorFundLeg
        ' 
        ButMudCorFundLeg.Location = New Point(85, 232)
        ButMudCorFundLeg.Name = "ButMudCorFundLeg"
        ButMudCorFundLeg.Size = New Size(234, 23)
        ButMudCorFundLeg.TabIndex = 3
        ButMudCorFundLeg.Text = "Mudar a cor de fundo da legenda"
        ButMudCorFundLeg.UseVisualStyleBackColor = True
        ' 
        ' ButMostrar
        ' 
        ButMostrar.Location = New Point(85, 203)
        ButMostrar.Name = "ButMostrar"
        ButMostrar.Size = New Size(234, 23)
        ButMostrar.TabIndex = 2
        ButMostrar.Text = "Mostrar a legenda"
        ButMostrar.UseVisualStyleBackColor = True
        ' 
        ' ButEsconder
        ' 
        ButEsconder.Location = New Point(85, 174)
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
        Controls.Add(Panel1)
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButNumAle As Button
    Friend WithEvents ButMudCorFunForm As Button
    Friend WithEvents ButMudCorFundLeg As Button
    Friend WithEvents ButMostrar As Button
    Friend WithEvents ButEsconder As Button
End Class
