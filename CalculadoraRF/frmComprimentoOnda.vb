Public Class frmComprimentoOnda

    Private Sub frmComprimentoOnda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calculadora de Tanque LC"

        ' Inicia no modo clássico
        rbModo1.Checked = True
        AjustarControles()
    End Sub

    ' Ajusta quais campos ficam habilitados conforme o modo selecionado
    Private Sub AjustarControles()
        If rbModo1.Checked Then
            ' Modo 1: C + L → λ e f
            txtCapacitancia.Enabled = True
            txtIndutancia.Enabled = True
            txtFrequencia.Enabled = False

            txtCapacitancia.BackColor = Color.White
            txtIndutancia.BackColor = Color.White
            txtFrequencia.BackColor = Color.LightGray

            lblExplicacao.Text = "MODO: Calcular Comprimento de Onda e Frequência" & vbCrLf & vbCrLf &
                                 "Informe:" & vbCrLf &
                                 "• Capacitância em picofarads (pF)" & vbCrLf &
                                 "• Indutância em microhenries (μH)" & vbCrLf & vbCrLf &
                                 "O programa calculará:" & vbCrLf &
                                 "• Frequência de ressonância" & vbCrLf &
                                 "• Comprimento de onda no vácuo" & vbCrLf & vbCrLf &
                                 "Equações utilizadas:" & vbCrLf &
                                 "f = 1 / (2π √(L × C))" & vbCrLf &
                                 "λ = c / f" & vbCrLf & vbCrLf &
                                 "(c = 299.792.458 m/s - velocidade da luz)"
            lblExplicacao.ForeColor = Color.DarkBlue
            lblExplicacao.Font = New Font("Microsoft Sans Serif", 9.5, FontStyle.Regular)

        ElseIf rbModo2.Checked Then
            ' Modo 2: L + f → C
            txtCapacitancia.Enabled = False
            txtIndutancia.Enabled = True
            txtFrequencia.Enabled = True

            txtCapacitancia.BackColor = Color.LightGray
            txtIndutancia.BackColor = Color.White
            txtFrequencia.BackColor = Color.White

            lblExplicacao.Text = "MODO: Calcular Capacitância Necessária" & vbCrLf & vbCrLf &
                                 "Informe:" & vbCrLf &
                                 "• Indutância em microhenries (μH)" & vbCrLf &
                                 "• Frequência desejada em MHz" & vbCrLf & vbCrLf &
                                 "O programa calculará:" & vbCrLf &
                                 "• Capacitância em picofarads (pF)" & vbCrLf &
                                 "para ressonância na frequência informada" & vbCrLf & vbCrLf &
                                 "Equação utilizada:" & vbCrLf &
                                 "C = 1 / ((2πf)² × L)"
            lblExplicacao.ForeColor = Color.DarkGreen
            lblExplicacao.Font = New Font("Microsoft Sans Serif", 9.5, FontStyle.Regular)

        ElseIf rbModo3.Checked Then
            ' Modo 3: C + f → L
            txtCapacitancia.Enabled = True
            txtIndutancia.Enabled = False
            txtFrequencia.Enabled = True

            txtCapacitancia.BackColor = Color.White
            txtIndutancia.BackColor = Color.LightGray
            txtFrequencia.BackColor = Color.White

            lblExplicacao.Text = "MODO: Calcular Indutância Necessária" & vbCrLf & vbCrLf &
                                 "Informe:" & vbCrLf &
                                 "• Capacitância em picofarads (pF)" & vbCrLf &
                                 "• Frequência desejada em MHz" & vbCrLf & vbCrLf &
                                 "O programa calculará:" & vbCrLf &
                                 "• Indutância em microhenries (μH)" & vbCrLf &
                                 "para ressonância na frequência informada" & vbCrLf & vbCrLf &
                                 "Equação utilizada:" & vbCrLf &
                                 "L = 1 / ((2πf)² × C)"
            lblExplicacao.ForeColor = Color.DarkRed
            lblExplicacao.Font = New Font("Microsoft Sans Serif", 9.5, FontStyle.Regular)
        End If

        ' Limpa os campos e resultados ao mudar de modo
        txtCapacitancia.Text = ""
        txtIndutancia.Text = ""
        txtFrequencia.Text = ""
        txtResultado.Text = ""
        lblFrequencia.Text = ""
    End Sub

    Private Sub rbModo1_CheckedChanged(sender As Object, e As EventArgs) Handles rbModo1.CheckedChanged
        If rbModo1.Checked Then AjustarControles()
    End Sub

    Private Sub rbModo2_CheckedChanged(sender As Object, e As EventArgs) Handles rbModo2.CheckedChanged
        If rbModo2.Checked Then AjustarControles()
    End Sub

    Private Sub rbModo3_CheckedChanged(sender As Object, e As EventArgs) Handles rbModo3.CheckedChanged
        If rbModo3.Checked Then AjustarControles()
    End Sub

    ' Bloqueia vírgula e permite apenas números e ponto
    Private Sub ApenasNumeroEPonto(sender As Object, e As KeyPressEventArgs) Handles txtCapacitancia.KeyPress, txtIndutancia.KeyPress, txtFrequencia.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
        If e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        txtResultado.Text = ""
        lblFrequencia.Text = ""

        ' Corrige possível uso de vírgula regional
        Dim textoC As String = txtCapacitancia.Text.Replace(",", ".")
        Dim textoL As String = txtIndutancia.Text.Replace(",", ".")
        Dim textoF As String = txtFrequencia.Text.Replace(",", ".")

        Try
            If rbModo1.Checked Then
                ' ========= MODO 1: C + L → λ e f =========
                If String.IsNullOrWhiteSpace(textoC) OrElse String.IsNullOrWhiteSpace(textoL) Then
                    MessageBox.Show("Preencha Capacitância e Indutância.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim C_pF As Double = Double.Parse(textoC, Globalization.CultureInfo.InvariantCulture)
                Dim L_uH As Double = Double.Parse(textoL, Globalization.CultureInfo.InvariantCulture)

                Dim L As Double = L_uH * 0.000001
                Dim C As Double = C_pF * 0.000000000001

                Dim f_Hz As Double = 1 / (2 * Math.PI * Math.Sqrt(L * C))
                Dim f_MHz As Double = f_Hz / 1000000.0
                Dim lambda_m As Double = 299792458 / f_Hz

                txtResultado.Text = $"Comprimento de onda: {lambda_m:F2} metros"
                lblFrequencia.Text = $"{f_MHz:F3} MHz"
                lblFrequencia.ForeColor = Color.DarkBlue
                lblFrequencia.Font = New Font(lblFrequencia.Font, FontStyle.Bold)

            ElseIf rbModo2.Checked Then
                ' ========= MODO 2: L + f → C =========
                If String.IsNullOrWhiteSpace(textoL) OrElse String.IsNullOrWhiteSpace(textoF) Then
                    MessageBox.Show("Preencha Indutância e Frequência.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim L_uH As Double = Double.Parse(textoL, Globalization.CultureInfo.InvariantCulture)
                Dim f_MHz As Double = Double.Parse(textoF, Globalization.CultureInfo.InvariantCulture)

                Dim L As Double = L_uH * 0.000001
                Dim f As Double = f_MHz * 1000000.0

                Dim C_farads As Double = 1 / ((2 * Math.PI * f) ^ 2 * L)
                Dim C_pF As Double = C_farads * 1000000000000.0

                txtResultado.Text = $"Capacitância necessária: {C_pF:F4} pF"
                lblFrequencia.Text = $"{f_MHz:F3} MHz"
                lblFrequencia.ForeColor = Color.DarkGreen
                lblFrequencia.Font = New Font(lblFrequencia.Font, FontStyle.Bold)

            ElseIf rbModo3.Checked Then
                ' ========= MODO 3: C + f → L =========
                If String.IsNullOrWhiteSpace(textoC) OrElse String.IsNullOrWhiteSpace(textoF) Then
                    MessageBox.Show("Preencha Capacitância e Frequência.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim C_pF As Double = Double.Parse(textoC, Globalization.CultureInfo.InvariantCulture)
                Dim f_MHz As Double = Double.Parse(textoF, Globalization.CultureInfo.InvariantCulture)

                If C_pF <= 0 Or f_MHz <= 0 Then
                    MessageBox.Show("Os valores devem ser maiores que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim C As Double = C_pF * 0.000000000001
                Dim f As Double = f_MHz * 1000000.0

                ' L = 1 / ( (2πf)² C )
                Dim L_henry As Double = 1 / ((2 * Math.PI * f) ^ 2 * C)
                Dim L_uH As Double = L_henry * 1000000.0

                txtResultado.Text = $"Indutância necessária: {L_uH:F4} μH"
                lblFrequencia.Text = $"{f_MHz:F3} MHz"
                lblFrequencia.ForeColor = Color.DarkRed
                lblFrequencia.Font = New Font(lblFrequencia.Font, FontStyle.Bold)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro nos valores inseridos." & vbCrLf & "Use apenas números com ponto decimal (ex: 4.7)",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class