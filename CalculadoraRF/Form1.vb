Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calculadora de Radiofrequência"

        ' Cria o MenuStrip principal
        Dim menuPrincipal As New MenuStrip()
        Me.MainMenuStrip = menuPrincipal
        Me.Controls.Add(menuPrincipal)

        ' ================== Menu Arquivo ==================
        Dim menuArquivo As New ToolStripMenuItem("Arquivo")
        menuPrincipal.Items.Add(menuArquivo)

        Dim itemSair As New ToolStripMenuItem("Sair")
        AddHandler itemSair.Click, AddressOf Sair_Click
        menuArquivo.DropDownItems.Add(itemSair)

        ' ================== Menu Ferramentas ==================
        Dim menuFerramentas As New ToolStripMenuItem("Ferramentas")
        menuPrincipal.Items.Add(menuFerramentas)

        Dim itemComprimentoOnda As New ToolStripMenuItem("Comprimento de Onda (Tanque LC)")
        AddHandler itemComprimentoOnda.Click, AddressOf AbrirComprimentoOnda_Click
        menuFerramentas.DropDownItems.Add(itemComprimentoOnda)

        Dim itemBobinaAr As New ToolStripMenuItem("Enrolamento Bobina com Núcleo de Ar")
        AddHandler itemBobinaAr.Click, AddressOf AbrirBobina_Click
        menuFerramentas.DropDownItems.Add(itemBobinaAr)

        'Dim itemImpedancia As New ToolStripMenuItem("Impedância (Tanque LC)")
        'AddHandler itemImpedancia.Click, AddressOf AbrirImpedancia_Click
        'menuFerramentas.DropDownItems.Add(itemImpedancia)

        ' ================== Menu Bobina ==================
        'Dim menuBobina As New ToolStripMenuItem("Bobina")
        'menuPrincipal.Items.Add(menuBobina)

        'Dim itemEnrolamento As New ToolStripMenuItem("Enrolamento Bobina com Núcleo de Ar")
        'AddHandler itemEnrolamento.Click, AddressOf AbrirBobina_Click
        'menuBobina.DropDownItems.Add(itemEnrolamento)

        ' (Você pode adicionar mais itens no menu Bobina no futuro aqui)


        ' Você pode adicionar mais ferramentas aqui no futuro:
        ' Dim itemNovaFerramenta As New ToolStripMenuItem("Nova Ferramenta")
        ' AddHandler itemNovaFerramenta.Click, AddressOf NovaFerramenta_Click
        ' menuFerramentas.DropDownItems.Add(itemNovaFerramenta)
    End Sub

    Private Sub Sair_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub AbrirComprimentoOnda_Click(sender As Object, e As EventArgs)
        Dim frm As New frmComprimentoOnda()
        frm.ShowDialog()
    End Sub
    Private Sub AbrirBobina_Click(sender As Object, e As EventArgs)
        Dim frm As New frmBobina()
        frm.ShowDialog()
    End Sub

    Public Class Form1
        ' =========================================
        ' ===== A PARTIR DAQUI você cola esses procedimentos =====

        Private Sub Sair_Click(sender As Object, e As EventArgs)
            Application.Exit()
        End Sub

        Private Sub AbrirComprimentoOnda_Click(sender As Object, e As EventArgs)
            Dim frm As New frmComprimentoOnda()
            frm.ShowDialog()
        End Sub

        'Private Sub AbrirImpedancia_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmImpedancia()
        '    frm.ShowDialog()
        'End Sub

        Private Sub AbrirBobina_Click(sender As Object, e As EventArgs)
            Dim frm As New frmBobina()
            frm.ShowDialog()
        End Sub

        ' =========================================

    End Class
End Class