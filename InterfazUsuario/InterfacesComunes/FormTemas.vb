Imports Comun
Public Class FormTemas
    Private Sub FormTemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colores()
        filtrartema()


    End Sub
    Private Sub tools()
        MetroToolTip1.SetToolTip(Panel1, "Para elegir el Tema Dale click al icono al lado del nombre")
        MetroToolTip1.SetToolTip(Panel7, "Para elegir el Tema Dale click al icono al lado del nombre")
        MetroToolTip1.SetToolTip(Panel4, "Para elegir el Tema Dale click al icono al lado del nombre")
    End Sub
    Private Sub filtrartema()
        Dim a As Integer = My.Settings.Tema
        Select Case a
            Case 1

                IconButton3.Enabled = False
                Exit Select
            Case 2

                IconButton2.Enabled = False
                Exit Select
            Case Else

                IconButton1.Enabled = False
                Exit Select
        End Select
    End Sub

    Private Sub colores()
        Dim a = Me.Controls.OfType(Of Label)
        For Each LB In a
            PropiedadesLabel(LB)
        Next
        Dim b = Me.Panel10.Controls.OfType(Of Label)
        For Each LB2 In b
            PropiedadesLabel(LB2)
        Next
        Dim bts = Me.Controls.OfType(Of FontAwesome.Sharp.IconButton)
        For Each bt In bts
            PropiedadesIconButton(bt)
        Next
        Me.BackColor = TemaActual.Fondo
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim a = MsgBox("Esta seguro de Cambiar el tema al tema original?, tendra que reiniciarse la aplicacion", vbYesNo + vbQuestion, "Confirmacion")
        Select Case a
            Case vbYes
                Try
                    My.Settings.Tema = 0
                    Application.Restart()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Exit Select
            Case vbNo
                Exit Select
        End Select
    End Sub



    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim a = MsgBox("Esta seguro de Cambiar el tema al tema LIGTH?, tendra que reiniciarse la aplicacion", vbYesNo + vbQuestion, "Confirmacion")
        Select Case a
            Case vbYes
                Try
                    My.Settings.Tema = 2
                    Application.Restart()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Exit Select
            Case vbNo
                Exit Select
        End Select
    End Sub


    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim a = MsgBox("Esta seguro de Cambiar el tema al tema dark?, tendra que reiniciarse la aplicacion", vbYesNo + vbQuestion, "Confirmacion")
        Select Case a
            Case vbYes
                Try
                    My.Settings.Tema = 1
                    Application.Restart()
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Exit Select
            Case vbNo
                Exit Select
        End Select
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class