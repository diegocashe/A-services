Imports System.Drawing

Public Module Tema
    Public TemaActual As New TemaEstructura
    Public elegida As Integer = My.Settings.TemaComun
    Public Sub RetornarColores(x As Integer)
        Select Case x
            Case 1
                '-- Panel Top
                TemaActual.PanelTop = Drawing.Color.FromArgb(45, 45, 48)
                '--Panel Lateral
                TemaActual.PanelLateral = Drawing.Color.FromArgb(63, 63, 70)
                '-- Fondo
                TemaActual.Fondo = Drawing.Color.FromArgb(30, 30, 30)
                '-- Letra
                TemaActual.letra = Drawing.Color.FromArgb(245, 245, 245)
                '-- PARA EVENTOS CLICK
                '-- Hover
                TemaActual.Sobre = Drawing.Color.FromArgb(45, 45, 48)
                '--Click
                TemaActual.AlHacerClick = Drawing.Color.FromArgb(64, 64, 64)
                '-- se verifica si el tema es del tipo dark
                TemaActual.IsDark = True

                Exit Select
            Case 2
                '-- Panel Top
                TemaActual.PanelTop = Drawing.Color.FromArgb(237, 237, 237)
                '--Panel Lateral
                TemaActual.PanelLateral = Drawing.Color.FromArgb(245, 245, 245)
                '-- Fondo
                TemaActual.Fondo = Drawing.Color.FromArgb(220, 220, 220)
                '-- Letra
                TemaActual.Letra = Drawing.Color.FromArgb(14, 22, 33)
                '-- PARA EVENTOS CLICK
                '-- Hover
                TemaActual.Sobre = Drawing.Color.FromArgb(187, 192, 198)
                '--Click
                TemaActual.AlHacerClick = Drawing.Color.FromArgb(229, 221, 213)
                '-- se verifica si el tema es del tipo dark
                TemaActual.IsDark = False
                Exit Select

            Case 3
                '-- Panel Top
                TemaActual.PanelTop = Drawing.Color.FromArgb(237, 237, 237)
                '--Panel Lateral
                TemaActual.PanelLateral = Drawing.Color.FromArgb(245, 245, 245)
                '-- Fondo
                TemaActual.Fondo = Drawing.Color.FromArgb(220, 220, 220)
                '-- Letra
                TemaActual.Letra = Drawing.Color.FromArgb(14, 22, 33)
                '-- PARA EVENTOS CLICK
                '-- Hover
                TemaActual.Sobre = Drawing.Color.FromArgb(187, 192, 198)
                '--Click
                TemaActual.AlHacerClick = Drawing.Color.FromArgb(229, 221, 213)
                '-- se verifica si el tema es del tipo dark
                TemaActual.IsDark = True
                Exit Select

            Case Else


                '-- Panel Top
                TemaActual.PanelTop = Drawing.Color.FromArgb(34, 44, 56)
                '--Panel Lateral
                TemaActual.PanelLateral = Drawing.Color.FromArgb(51, 67, 85)
                '-- Fondo
                TemaActual.Fondo = Drawing.Color.FromArgb(14, 22, 33)
                '-- Letra
                TemaActual.Letra = Drawing.Color.FromArgb(255, 255, 255)
                '-- PARA EVENTOS CLICK
                '-- Hover
                TemaActual.Sobre = Drawing.Color.FromArgb(14, 22, 33)
                '--Click
                TemaActual.AlHacerClick = Drawing.Color.FromArgb(34, 44, 56)
                '-- se verifica si el tema es del tipo dark
                TemaActual.IsDark = True
        End Select
    End Sub
End Module
