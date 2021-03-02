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
End Module
