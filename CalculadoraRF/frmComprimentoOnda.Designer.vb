<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprimentoOnda
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
        btnCalcular = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtResultado = New TextBox()
        txtIndutancia = New TextBox()
        txtCapacitancia = New TextBox()
        GroupBox1 = New GroupBox()
        rbModo3 = New RadioButton()
        rbModo2 = New RadioButton()
        rbModo1 = New RadioButton()
        Label4 = New Label()
        txtFrequencia = New TextBox()
        lblFrequencia = New Label()
        lblExplicacao = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(14, 321)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "Resultado:"
        Label1.UseWaitCursor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCalcular.ForeColor = Color.Green
        btnCalcular.Location = New Point(133, 171)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(79, 28)
        btnCalcular.TabIndex = 6
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        btnCalcular.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(14, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 17)
        Label2.TabIndex = 9
        Label2.Text = "Capacitância (pF):"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(23, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 17)
        Label3.TabIndex = 10
        Label3.Text = "Indutância (μH):"
        ' 
        ' txtResultado
        ' 
        txtResultado.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResultado.Location = New Point(14, 339)
        txtResultado.Multiline = True
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(377, 47)
        txtResultado.TabIndex = 11
        ' 
        ' txtIndutancia
        ' 
        txtIndutancia.Location = New Point(133, 93)
        txtIndutancia.Name = "txtIndutancia"
        txtIndutancia.Size = New Size(80, 23)
        txtIndutancia.TabIndex = 13
        ' 
        ' txtCapacitancia
        ' 
        txtCapacitancia.Location = New Point(133, 59)
        txtCapacitancia.Name = "txtCapacitancia"
        txtCapacitancia.Size = New Size(80, 23)
        txtCapacitancia.TabIndex = 14
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbModo3)
        GroupBox1.Controls.Add(rbModo2)
        GroupBox1.Controls.Add(rbModo1)
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(233, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 163)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Escolha o tipo de calculo"
        ' 
        ' rbModo3
        ' 
        rbModo3.AutoSize = True
        rbModo3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        rbModo3.ForeColor = Color.MidnightBlue
        rbModo3.Location = New Point(20, 108)
        rbModo3.Name = "rbModo3"
        rbModo3.Size = New Size(291, 21)
        rbModo3.TabIndex = 2
        rbModo3.TabStop = True
        rbModo3.Text = "Calcular Indutância (informe C e frequência)"
        rbModo3.UseVisualStyleBackColor = True
        ' 
        ' rbModo2
        ' 
        rbModo2.AutoSize = True
        rbModo2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        rbModo2.ForeColor = Color.MidnightBlue
        rbModo2.Location = New Point(20, 69)
        rbModo2.Name = "rbModo2"
        rbModo2.Size = New Size(301, 21)
        rbModo2.TabIndex = 1
        rbModo2.TabStop = True
        rbModo2.Text = "Calcular Capacitância (informe L e frequência)"
        rbModo2.UseVisualStyleBackColor = True
        ' 
        ' rbModo1
        ' 
        rbModo1.AutoSize = True
        rbModo1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        rbModo1.ForeColor = Color.MidnightBlue
        rbModo1.Location = New Point(20, 32)
        rbModo1.Name = "rbModo1"
        rbModo1.Size = New Size(304, 21)
        rbModo1.TabIndex = 0
        rbModo1.TabStop = True
        rbModo1.Text = "Calcular Comprimento de Onda (informe C e L)"
        rbModo1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(12, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 17)
        Label4.TabIndex = 16
        Label4.Text = "Frequência (MHz):"
        ' 
        ' txtFrequencia
        ' 
        txtFrequencia.Location = New Point(133, 127)
        txtFrequencia.Name = "txtFrequencia"
        txtFrequencia.Size = New Size(80, 23)
        txtFrequencia.TabIndex = 17
        ' 
        ' lblFrequencia
        ' 
        lblFrequencia.AutoSize = True
        lblFrequencia.Font = New Font("Bookman Old Style", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFrequencia.ForeColor = Color.DarkSeaGreen
        lblFrequencia.Location = New Point(12, 232)
        lblFrequencia.Name = "lblFrequencia"
        lblFrequencia.Size = New Size(402, 75)
        lblFrequencia.TabIndex = 18
        lblFrequencia.Text = "Frequência"
        ' 
        ' lblExplicacao
        ' 
        lblExplicacao.BackColor = SystemColors.ControlLight
        lblExplicacao.BorderStyle = BorderStyle.FixedSingle
        lblExplicacao.Font = New Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblExplicacao.Location = New Point(573, 22)
        lblExplicacao.MaximumSize = New Size(400, 280)
        lblExplicacao.MinimumSize = New Size(450, 280)
        lblExplicacao.Name = "lblExplicacao"
        lblExplicacao.Size = New Size(450, 280)
        lblExplicacao.TabIndex = 19
        lblExplicacao.Text = "Label5"
        ' 
        ' frmComprimentoOnda
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1055, 446)
        Controls.Add(lblExplicacao)
        Controls.Add(lblFrequencia)
        Controls.Add(txtFrequencia)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(txtCapacitancia)
        Controls.Add(txtIndutancia)
        Controls.Add(txtResultado)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCalcular)
        ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmComprimentoOnda"
        Text = "Calculadora de Tanque LC Resistente"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFrequencia As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtIndutancia As TextBox
    Friend WithEvents txtCapacitancia As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbModo2 As RadioButton
    Friend WithEvents rbModo1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFrequencia As Label
    Friend WithEvents rbModo3 As RadioButton
    Friend WithEvents lblExplicacao As Label
End Class
