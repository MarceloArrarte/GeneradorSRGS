Imports System.CodeDom
Imports System.Speech.Recognition.SrgsGrammar

Public Class ReglaSrgs
    Public Property Regla As SrgsRule
    Public Property TreeView As TreeView
    Private Property UltimoItemModificado As SrgsItem

    Public Sub New(idRegla As String, treeView As TreeView)
        Regla = New SrgsRule(idRegla)
        Me.TreeView = treeView
        RecrearTreeview()
    End Sub

    Private Sub AgregarItem(item As SrgsItem)
        Regla.Add(item)
        UltimoItemModificado = item
        RecrearTreeview()
    End Sub

    Public Sub EliminarItem(item As SrgsItem)
        Dim itemEliminado As Boolean = Regla.Elements.Remove(item)          ' El elemento seleccionado es atómico (token o ruleref)

        If Not itemEliminado Then                                           ' El elemento seleccionado es una opción de un OneOf
            Dim todosLosNodos As List(Of TreeNode) = TreeView.TodosLosNodos
            Dim nodoAEliminar As TreeNode = todosLosNodos.Where(Function(x) x.Tag Is item).Single
            Dim nodoOneOf As TreeNode = nodoAEliminar.Parent
            Dim itemOneOf As SrgsItem = CType(nodoOneOf.Tag, SrgsItem)
            Dim oneOf As SrgsOneOf = itemOneOf.Elements(0)
            oneOf.Items.Remove(item)

            UltimoItemModificado = itemOneOf
        End If

        RecrearTreeview()
    End Sub

    Public Sub AgregarToken(texto As String)
        AgregarToken(texto, Nothing, 1, 1)
    End Sub

    Public Sub AgregarToken(texto As String, minRepeticiones As Integer, maxRepeticiones As Integer)
        AgregarToken(texto, Nothing, minRepeticiones, maxRepeticiones)
    End Sub

    Public Sub AgregarToken(texto As String, pronunciacion As String)
        AgregarToken(texto, pronunciacion, 1, 1)
    End Sub

    Public Sub AgregarToken(texto As String, pronunciacion As String, minRepeticiones As Integer, maxRepeticiones As Integer)
        If minRepeticiones > maxRepeticiones Then minRepeticiones.IntercambiarCon(maxRepeticiones)

        Dim tokenSrgs As New SrgsToken(texto)
        If pronunciacion <> Nothing Then
            tokenSrgs.Pronunciation = pronunciacion
        End If

        Dim itemSrgs As New SrgsItem(minRepeticiones, maxRepeticiones, tokenSrgs)
        AgregarItem(itemSrgs)
    End Sub

    Public Sub AgregarOneOf(ParamArray opciones As String())
        AgregarOneOf(1, 1, opciones)
    End Sub

    Public Sub AgregarOneOf(minRepeticiones As Integer, maxRepeticiones As Integer, ParamArray opciones As String())
        If minRepeticiones > maxRepeticiones Then minRepeticiones.IntercambiarCon(maxRepeticiones)

        Dim oneOfSrgs As New SrgsOneOf(opciones)
        Dim itemSrgs As New SrgsItem(minRepeticiones, maxRepeticiones, oneOfSrgs)
        AgregarItem(itemSrgs)
    End Sub

    Public Sub AgregarRuleRef(reglaReferenciada As SrgsRule)
        AgregarRuleRef(reglaReferenciada, 1, 1)
    End Sub

    Public Sub AgregarRuleRef(reglaReferenciada As SrgsRule, minRepeticiones As Integer, maxRepeticiones As Integer)
        If minRepeticiones > maxRepeticiones Then minRepeticiones.IntercambiarCon(maxRepeticiones)

        Dim ruleRef As New SrgsRuleRef(reglaReferenciada)
        Dim itemSrgs As New SrgsItem(minRepeticiones, maxRepeticiones, ruleRef)
        AgregarItem(itemSrgs)
    End Sub

    Private Sub RecrearTreeview()
        TreeView.Nodes.Clear()
        TreeView.Nodes.Add(Regla.Id)

        For Each item As SrgsItem In Regla.Elements.Cast(Of SrgsItem)
            Dim nodoItem As New TreeNode(item.VistaPreviaTreeView) With {.Tag = item}

            If TypeOf item.Elements(0) Is SrgsOneOf Then
                Dim oneOf As SrgsOneOf = item.Elements(0)
                For Each opcion As SrgsItem In oneOf.Items
                    Dim nodoOpcion As New TreeNode(opcion.VistaPreviaTreeView) With {.Tag = opcion}
                    nodoItem.Nodes.Add(nodoOpcion)
                Next
            End If

            TreeView.Nodes(0).Nodes.Add(nodoItem)

            If item Is UltimoItemModificado Then
                nodoItem.EnsureVisible()
                nodoItem.Expand()
            End If
        Next
    End Sub
End Class
