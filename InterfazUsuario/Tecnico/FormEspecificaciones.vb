Imports System.IO
Imports System.Xml
Imports Comun

Public Class FormEspecificaciones
    Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Private Sub FormEspecificacionesCPU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colores()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonIniciarLectura.Click
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNode
        Dim fs As New FileStream(path, FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode = xmldoc.ChildNodes(1)
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(New TreeNode(xmldoc.DocumentElement.Name))
        Dim tNode As TreeNode
        tNode = TreeView1.Nodes(0)
        AddNode(xmlnode, tNode)
    End Sub

    Private Sub AddNode(ByVal inXmlNode As XmlNode, ByVal inTreeNode As TreeNode)
        Dim xNode As XmlNode
        Dim tNode As TreeNode
        Dim nodeList As XmlNodeList
        Dim i As Integer
        If inXmlNode.HasChildNodes Then
            nodeList = inXmlNode.ChildNodes
            For i = 0 To nodeList.Count - 1
                xNode = inXmlNode.ChildNodes(i)
                inTreeNode.Nodes.Add(New TreeNode(xNode.Name))
                tNode = inTreeNode.Nodes(i)
                AddNode(xNode, tNode)
            Next
        Else
            inTreeNode.Text = inXmlNode.InnerText.ToString
        End If
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles ButtonElegirCarpeta.Click
        Dim buscarArchivo As New OpenFileDialog
        buscarArchivo.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        buscarArchivo.ShowDialog()
        path = buscarArchivo.FileName
        MsgBox(path)
    End Sub
    Private Sub colores()
        Dim a = Me.Controls.OfType(Of Label)
        For Each lb In a
            PropiedadesLabel(lb)
        Next
        Dim b = Me.Controls.OfType(Of FontAwesome.Sharp.IconButton)
        For Each btn In b
            PropiedadesIconButton(btn)
        Next
        Me.RichTextBox1.BackColor = TemaActual.PanelTop
        Me.RichTextBox1.ForeColor = TemaActual.Letra
        Me.BackColor = TemaActual.Fondo
        Me.TreeView1.BackColor = TemaActual.PanelTop
        Me.TreeView1.ForeColor = TemaActual.Letra

    End Sub
End Class