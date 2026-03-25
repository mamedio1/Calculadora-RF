<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBobina
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtFrequencia = New TextBox()
        txtCapacitancia = New TextBox()
        txtDiamFio = New TextBox()
        txtDiamBobina = New TextBox()
        btnCalcular = New Button()
        txtResultado = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(77, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 15)
        Label1.TabIndex = 0
        Label1.Text = "Frequência (MHz):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 15)
        Label2.TabIndex = 1
        Label2.Text = "Capacitância do capacitor (pF)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 15)
        Label3.TabIndex = 2
        Label3.Text = "Diâmetro do fio (mm):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 15)
        Label4.TabIndex = 3
        Label4.Text = "Diâmetro da bobina (cm):"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 4
        Label5.Text = "Resultado:"
        ' 
        ' txtFrequencia
        ' 
        txtFrequencia.Location = New Point(187, 73)
        txtFrequencia.Name = "txtFrequencia"
        txtFrequencia.Size = New Size(100, 23)
        txtFrequencia.TabIndex = 5
        ' 
        ' txtCapacitancia
        ' 
        txtCapacitancia.Location = New Point(187, 110)
        txtCapacitancia.Name = "txtCapacitancia"
        txtCapacitancia.Size = New Size(100, 23)
        txtCapacitancia.TabIndex = 6
        ' 
        ' txtDiamFio
        ' 
        txtDiamFio.Location = New Point(187, 149)
        txtDiamFio.Name = "txtDiamFio"
        txtDiamFio.Size = New Size(100, 23)
        txtDiamFio.TabIndex = 7
        ' 
        ' txtDiamBobina
        ' 
        txtDiamBobina.Location = New Point(187, 189)
        txtDiamBobina.Name = "txtDiamBobina"
        txtDiamBobina.Size = New Size(100, 23)
        txtDiamBobina.TabIndex = 8
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalcular.Location = New Point(119, 311)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(103, 28)
        btnCalcular.TabIndex = 10
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(325, 64)
        txtResultado.Multiline = True
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(355, 275)
        txtResultado.TabIndex = 11
        ' 
        ' frmBobina
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(800, 450)
        Controls.Add(txtResultado)
        Controls.Add(btnCalcular)
        Controls.Add(txtDiamBobina)
        Controls.Add(txtDiamFio)
        Controls.Add(txtCapacitancia)
        Controls.Add(txtFrequencia)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmBobina"
        Text = "Bobina"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFrequencia As TextBox
    Friend WithEvents txtCapacitancia As TextBox
    Friend WithEvents txtDiamFio As TextBox
    Friend WithEvents txtDiamBobina As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
End Class
