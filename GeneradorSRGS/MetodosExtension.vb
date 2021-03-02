Imports System.Runtime.CompilerServices
Imports System.Speech.Recognition.SrgsGrammar

Friend Module MetodosExtension
    <Extension>
    Public Function VistaPreviaTreeView(frase As SrgsItem) As String
        Dim token As SrgsToken = CType(frase.Elements(0), SrgsToken)
        Dim salida As String = token.Text & " "

        If token.Pronunciation <> "" Then
            salida &= $"({token.Pronunciation}) "
        End If

        salida &= $"{frase.MinRepeat}..{frase.MaxRepeat}"
        Return salida
    End Function

    <Extension>
    Public Function VistaPreviaTreeView(oneof As SrgsOneOf) As String
        Dim salida As String = ""
        For i As Integer = 0 To oneof.Items.Count - 1
            If i <> 0 Then
                salida &= " | "
            End If
            Dim opcion As SrgsText = CType(oneof.Items(i).Elements(0), SrgsText)
            salida &= opcion.Text
        Next
        salida = "{ " & salida & " }"

        'Dim tokens As IEnumerable(Of String) = From i As SrgsItem In oneof.Items
        '                                       Select CType(i.Elements(0), SrgsToken).Text
        'Dim tokens As IEnumerable(Of String) = oneof.Items
        'Dim salida As String = "{ " & String.Join(" | ", oneof.Items) & " }"
        Return salida
    End Function
End Module
