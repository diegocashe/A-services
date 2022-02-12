Imports System.Management
Imports Dominio
Imports Comun
Public Class FormAgregarComputadora
    Dim datatemp As New DataSet
    Dim BinRedesClientes As New BindingSource

    Private Sub FormAgregarComputadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colores()

        Datos()
        LlenarBindings()

    End Sub

    Private Sub LlenarBindings()
        Dim dom As New DatosCompletos
        dom.SolicitarRedesClientes(datatemp)
        BinRedesClientes.DataSource = datatemp.Tables("redesclientes")
        BinRedesClientes.Filter = " empresacliente = '" + Empresa.ToString + "'"
        DropdownRedes.DataSource = BinRedesClientes
        DropdownRedes.DisplayMember = "red"
        DropdownRedes.ValueMember = "idred"
        Me.TBipv41.DataBindings.Add("TEXT", BinRedesClientes, "IP1")
        Me.TB_IPV42.DataBindings.Add("TEXT", BinRedesClientes, "IP2")
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Me.TB_direccionxml.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Dim dom As New Inserciones
        Try
            Dim NombreEquipo, DIRMAC, DIRXML, ipv43, ipv44, idred, idpropietario As String
            NombreEquipo = TB_NombreComputadora.Text
            DIRMAC = TB_MAC.Text
            DIRXML = TB_direccionxml.Text
            ipv43 = TB_IPV43.Text
            ipv44 = TB_IPV44.Text
            idpropietario = id
            idred = DropdownRedes.SelectedValue
            Try
                Dim a = MsgBox("Esta seguro de agregar la computadora?", vbYesNo + vbQuestion, "Confirmacion")
                Select Case a
                    Case vbYes
                        Try
                            dom.InsertareEquipoEscritorioDom(NombreEquipo, DIRMAC, DIRXML, ipv43, ipv44, idred, idpropietario)
                            MsgBox("Proceso Exitoso")
                        Catch ex As Exception
                            MsgBox("Disculpa Amigo, no puedes tener dos maquinas asociadas :(" + vbOKOnly + vbExclamation + "Error")
                        End Try

                    Case vbNo

                End Select

            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox("Por Favor Revise los datos")
        End Try
    End Sub
    Private Sub Datos()
        Dim consultaSQLArquitectura As String = "SELECT *  FROM Win32_NetworkAdapterConfiguration"
        Dim objArquitectura As New ManagementObjectSearcher(consultaSQLArquitectura)
        Dim INTER As String
        Dim random As New Random
        For Each info As ManagementObject In objArquitectura.Get()
            INTER = info.Properties("MACAddress").Value
        Next info
        Me.TB_NombreComputadora.Text = My.Computer.Name
        Me.TB_MAC.Text = INTER
        Me.TB_direccionxml.Text = ""
        Me.TB_IPV43.Text = random.Next(0, 255).ToString()
        Me.TB_IPV44.Text = random.Next(0, 255).ToString()

    End Sub
    Private Sub colores()

        Me.BackColor = TemaActual.Fondo
        Dim a = Me.Controls.OfType(Of Label)
        For Each lb In a
            PropiedadesLabel(a)
        Next
        PropiedadesIconButton(Me.IconButton1)


    End Sub


End Class