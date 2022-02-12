Imports Comun
Module EstablecerPropiedades
    Public Sub PropiedadesLabel(lab As Label)
        lab.BackColor = Color.Transparent
        lab.ForeColor = TemaActual.Letra
    End Sub
    Public Sub PropiedadesIconButton(Icon As FontAwesome.Sharp.IconButton)
        Icon.ForeColor = TemaActual.Letra
        Icon.IconColor = TemaActual.Letra
        Icon.FlatAppearance.MouseOverBackColor = TemaActual.Sobre
        Icon.FlatAppearance.MouseDownBackColor = TemaActual.AlHacerClick
        Icon.BackColor = Color.Transparent
    End Sub
    Public Sub PropiedadesPanelGradient(PG As Bunifu.Framework.UI.BunifuGradientPanel)
        PG.GradientBottomLeft = TemaActual.Fondo
        PG.GradientBottomRight = TemaActual.PanelLateral
        PG.GradientTopLeft = TemaActual.Fondo
        PG.GradientTopRight = TemaActual.PanelTop
    End Sub
End Module
