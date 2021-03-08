Imports System.Runtime.CompilerServices
Imports System.Speech.Recognition.SrgsGrammar

<Extension>
Friend Module MetodosExtension
    <Extension>
    Public Function VistaPreviaTreeView(item As SrgsItem) As String
        Dim salida As String = ""
        Select Case item.Elements(0).GetType
            Case GetType(SrgsToken)
                Dim token As SrgsToken = CType(item.Elements(0), SrgsToken)
                salida &= token.VistaPreviaTreeView

            Case GetType(SrgsText)
                Dim texto As SrgsText = CType(item.Elements(0), SrgsText)
                salida &= texto.VistaPreviaTreeView

            Case GetType(SrgsRuleRef)
                Dim referencia As SrgsRuleRef = CType(item.Elements(0), SrgsRuleRef)
                salida &= referencia.VistaPreviaTreeView

            Case GetType(SrgsOneOf)
                Dim oneOf As SrgsOneOf = CType(item.Elements(0), SrgsOneOf)
                salida &= oneOf.VistaPreviaTreeView

        End Select

        If Not (item.MinRepeat = 1 And item.MaxRepeat = 1) Then
            salida &= $" {item.MinRepeat}..{item.MaxRepeat}"
        End If

        Return salida
    End Function

    <Extension>
    Private Function VistaPreviaTreeView(token As SrgsToken) As String
        Dim salida As String = token.Text

        If token.Pronunciation <> "" Then
            salida &= $" ({token.Pronunciation})"
        End If

        Return salida
    End Function

    <Extension>
    Private Function VistaPreviaTreeView(texto As SrgsText) As String
        Return texto.Text
    End Function

    <Extension>
    Private Function VistaPreviaTreeView(referencia As SrgsRuleRef) As String
        Return referencia.Uri.OriginalString
    End Function

    <Extension>
    Private Function VistaPreviaTreeView(oneOf As SrgsOneOf) As String
        Dim salida As String = ""
        For i As Integer = 0 To oneOf.Items.Count - 1
            If i <> 0 Then
                salida &= " | "
            End If
            Dim opcion As SrgsText = CType(oneOf.Items(i).Elements(0), SrgsText)
            salida &= opcion.Text
        Next
        salida = "{ " & salida & " }"

        Return salida
    End Function

    <Extension>
    Public Sub IntercambiarCon(ByRef a As Integer, ByRef b As Integer)
        a = a + b
        b = a - b
        a = a - b
    End Sub

    <Extension>
    Public Function BuscarNodoPorTag(item As SrgsItem) As TreeNode

    End Function

    <Extension>
    Public Function TodosLosNodos(treeview As TreeView) As List(Of TreeNode)
        Dim listaNodos As New List(Of TreeNode)

        For Each n As TreeNode In treeview.Nodes
            listaNodos.AddRange(n.NodosHijos)
        Next

        Return listaNodos
    End Function

    <Extension>
    Private Function NodosHijos(nodo As TreeNode) As List(Of TreeNode)
        Dim listaNodos As New List(Of TreeNode)
        listaNodos.Add(nodo)

        For Each n As TreeNode In nodo.Nodes
            If n.Nodes.Count > 0 Then
                listaNodos.AddRange(n.NodosHijos)
            Else
                listaNodos.Add(n)
            End If
        Next

        Return listaNodos
    End Function
End Module
