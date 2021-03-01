Imports System.Speech.Recognition.SrgsGrammar

Public Class ConfigSrgs
    Public Property Nombre As String
    Public Property Idioma As String
    Public Property AlfabetoFonetico As SrgsPhoneticAlphabet

    Public Sub New(nombre As String, idioma As String, alfabetoFonetico As SrgsPhoneticAlphabet)
        Me.Nombre = nombre
        Me.Idioma = idioma
        Me.AlfabetoFonetico = alfabetoFonetico
    End Sub
End Class
