<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Panel1 = New Panel()
        TextBoxResult = New TextBox()
        Label3 = New Label()
        TextBoxV2 = New TextBox()
        TextBoxV1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Dividir = New Button()
        Subtrair = New Button()
        Multiplicar = New Button()
        Somar = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBoxResult)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBoxV2)
        Panel1.Controls.Add(TextBoxV1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(248, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(307, 218)
        Panel1.TabIndex = 0
        ' 
        ' TextBoxResult
        ' 
        TextBoxResult.Location = New Point(124, 132)
        TextBoxResult.Name = "TextBoxResult"
        TextBoxResult.Size = New Size(100, 23)
        TextBoxResult.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 4
        Label3.Text = "Resultado:"
        ' 
        ' TextBoxV2
        ' 
        TextBoxV2.Location = New Point(124, 91)
        TextBoxV2.Name = "TextBoxV2"
        TextBoxV2.Size = New Size(100, 23)
        TextBoxV2.TabIndex = 3
        ' 
        ' TextBoxV1
        ' 
        TextBoxV1.Location = New Point(124, 63)
        TextBoxV1.Name = "TextBoxV1"
        TextBoxV1.Size = New Size(100, 23)
        TextBoxV1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 1
        Label2.Text = "Valor 2:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 0
        Label1.Text = "Valor 1:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Dividir)
        Panel2.Controls.Add(Subtrair)
        Panel2.Controls.Add(Multiplicar)
        Panel2.Controls.Add(Somar)
        Panel2.Location = New Point(288, 315)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(224, 91)
        Panel2.TabIndex = 1
        ' 
        ' Dividir
        ' 
        Dividir.Location = New Point(124, 53)
        Dividir.Name = "Dividir"
        Dividir.Size = New Size(75, 23)
        Dividir.TabIndex = 3
        Dividir.Text = "Dividir"
        Dividir.UseVisualStyleBackColor = True
        ' 
        ' Subtrair
        ' 
        Subtrair.Location = New Point(17, 53)
        Subtrair.Name = "Subtrair"
        Subtrair.Size = New Size(75, 23)
        Subtrair.TabIndex = 2
        Subtrair.Text = "Subtrair"
        Subtrair.UseVisualStyleBackColor = True
        ' 
        ' Multiplicar
        ' 
        Multiplicar.Location = New Point(124, 14)
        Multiplicar.Name = "Multiplicar"
        Multiplicar.Size = New Size(75, 23)
        Multiplicar.TabIndex = 1
        Multiplicar.Text = "Multiplicar"
        Multiplicar.UseVisualStyleBackColor = True
        ' 
        ' Somar
        ' 
        Somar.Location = New Point(17, 14)
        Somar.Name = "Somar"
        Somar.Size = New Size(75, 23)
        Somar.TabIndex = 0
        Somar.Text = "Soma"
        Somar.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxV2 As TextBox
    Friend WithEvents TextBoxV1 As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dividir As Button
    Friend WithEvents Subtrair As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Somar As Button
End Class
