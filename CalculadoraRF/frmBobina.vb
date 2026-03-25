Public Class frmBobina

    Private Sub frmBobina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Bobina de Ressonância com Capacitor (Núcleo de Ar)"
    End Sub

    ' Bloqueia vírgula e permite apenas números e ponto
    Private Sub ApenasNumeroEPonto(sender As Object, e As KeyPressEventArgs) Handles txtFrequencia.KeyPress, txtCapacitancia.KeyPress, txtDiamFio.KeyPress, txtDiamBobina.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
        If e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        txtResultado.Text = ""

        If String.IsNullOrWhiteSpace(txtFrequencia.Text) OrElse
           String.IsNullOrWhiteSpace(txtCapacitancia.Text) OrElse
           String.IsNullOrWhiteSpace(txtDiamFio.Text) OrElse
           String.IsNullOrWhiteSpace(txtDiamBobina.Text) Then
            MessageBox.Show("Preencha todos os valores.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Lê valores corrigindo vírgula
            Dim f_MHz As Double = Double.Parse(txtFrequencia.Text.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)
            Dim C_pF As Double = Double.Parse(txtCapacitancia.Text.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)
            Dim diam_fio_mm As Double = Double.Parse(txtDiamFio.Text.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)
            Dim diam_bobina_cm As Double = Double.Parse(txtDiamBobina.Text.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)

            If f_MHz <= 0 Or C_pF <= 0 Or diam_fio_mm <= 0 Or diam_bobina_cm <= 0 Then
                MessageBox.Show("Os valores devem ser maiores que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' PASSO 1: Indutância para ressonância
            Dim f_Hz As Double = f_MHz * 1000000
            Dim C_farad As Double = C_pF * 0.000000000001
            Dim L_henry As Double = 1 / ((2 * Math.PI * f_Hz) ^ 2 * C_farad)
            Dim L_uH As Double = L_henry * 1000000

            ' PASSO 2: Número de espiras - Fórmula de Wheeler CORRIGIDA (equação quadrática)
            Dim D_inch As Double = diam_bobina_cm / 2.54
            Dim wire_inch As Double = diam_fio_mm / 25.4

            Dim a As Double = D_inch ^ 2
            Dim b As Double = -40 * L_uH * wire_inch   ' Negativo!
            Dim c As Double = -18 * L_uH * D_inch      ' Negativo!

            Dim discriminante As Double = b ^ 2 - 4 * a * c

            If discriminante < 0 Then
                txtResultado.Text = "Impossível calcular: valores incompatíveis com bobina real."
                Return
            End If

            ' Raízes - pegamos a positiva maior
            Dim n1 As Double = (-b + Math.Sqrt(discriminante)) / (2 * a)
            Dim n2 As Double = (-b - Math.Sqrt(discriminante)) / (2 * a)
            Dim n As Double = Math.Max(n1, n2)

            Dim n_arredondado As Integer = Math.Round(n)

            ' Comprimento da bobina
            Dim comprimento_cm As Double = n * diam_fio_mm / 10

            ' Skin depth (cobre)
            Dim skin_mm As Double = 0.066 / Math.Sqrt(f_MHz)
            Dim skin_info As String = If(diam_fio_mm < 2 * skin_mm,
                                        "ATENÇÃO: fio muito fino para esta frequência (perdas altas)",
                                        "BOM: fio adequado")

            ' RESULTADO FINAL BEM CLARO
            txtResultado.Text = "=== BOBINA DE RESSONÂNCIA ===" & vbCrLf & vbCrLf &
                                $"Frequência: {f_MHz:F2} MHz" & vbCrLf &
                                $"Capacitor: {C_pF:F2} pF" & vbCrLf & vbCrLf &
                                $"Indutância necessária: {L_uH:F2} μH" & vbCrLf & vbCrLf &
                                $"NÚMERO DE ESPIRAS: {n_arredondado} espiras" & vbCrLf &
                                $"Comprimento total da bobina: {comprimento_cm:F1} cm" & vbCrLf &
                                $"Diâmetro da bobina: {diam_bobina_cm:F1} cm" & vbCrLf &
                                $"Diâmetro do fio: {diam_fio_mm:F1} mm" & vbCrLf & vbCrLf &
                                $"Skin depth: {skin_mm:F3} mm → {skin_info}"

        Catch ex As Exception
            MessageBox.Show("Erro no cálculo: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class