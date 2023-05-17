<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBoxComprim = New TextBox()
        TextBoxLargura = New TextBox()
        TextBoxAltura = New TextBox()
        CalcVolume = New Button()
        txtResultado = New TextBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 15)
        Label1.TabIndex = 0
        Label1.Text = "Calcular o volume de um tanque: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 1
        Label2.Text = "Comprimento:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 2
        Label3.Text = "Largura:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 3
        Label4.Text = "Altura:"
        ' 
        ' TextBoxComprim
        ' 
        TextBoxComprim.Location = New Point(165, 103)
        TextBoxComprim.Name = "TextBoxComprim"
        TextBoxComprim.Size = New Size(137, 23)
        TextBoxComprim.TabIndex = 4
        ' 
        ' TextBoxLargura
        ' 
        TextBoxLargura.Location = New Point(165, 148)
        TextBoxLargura.Name = "TextBoxLargura"
        TextBoxLargura.Size = New Size(137, 23)
        TextBoxLargura.TabIndex = 5
        ' 
        ' TextBoxAltura
        ' 
        TextBoxAltura.Location = New Point(165, 187)
        TextBoxAltura.Name = "TextBoxAltura"
        TextBoxAltura.Size = New Size(137, 23)
        TextBoxAltura.TabIndex = 6
        ' 
        ' CalcVolume
        ' 
        CalcVolume.Location = New Point(135, 248)
        CalcVolume.Name = "CalcVolume"
        CalcVolume.Size = New Size(127, 23)
        CalcVolume.TabIndex = 7
        CalcVolume.Text = "Calcular Volume"
        CalcVolume.UseVisualStyleBackColor = True
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(146, 277)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(100, 23)
        txtResultado.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtResultado)
        Panel1.Controls.Add(CalcVolume)
        Panel1.Controls.Add(TextBoxAltura)
        Panel1.Controls.Add(TextBoxLargura)
        Panel1.Controls.Add(TextBoxComprim)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(163, 93)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(393, 338)
        Panel1.TabIndex = 9
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxComprim As TextBox
    Friend WithEvents TextBoxLargura As TextBox
    Friend WithEvents TextBoxAltura As TextBox
    Friend WithEvents CalcVolume As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Panel1 As Panel
End Class
