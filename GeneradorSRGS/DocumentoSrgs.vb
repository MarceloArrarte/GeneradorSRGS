Imports System.IO
Imports System.Speech.Recognition.SrgsGrammar
Imports System.Xml

Public Class DocumentoSrgs
    Public Property Documento As New SrgsDocument
    Public Property NombreArchivo As String
    Public WriteOnly Property Configuracion As ConfigSrgs
        Set(value As ConfigSrgs)
            NombreArchivo = value.Nombre
            'Documento.Language = value.Idioma
            Documento.PhoneticAlphabet = value.AlfabetoFonetico
        End Set
    End Property

    Public Sub New(nombre As String)
        Configuracion = New ConfigSrgs(nombre, "es-ES", SrgsPhoneticAlphabet.Ipa)
    End Sub

    Private Sub New()
    End Sub

    Public Shared Function DesdeArchivo(ruta As String) As DocumentoSrgs
        Dim doc As New DocumentoSrgs
        Dim lector As XmlReader = XmlReader.Create(ruta)
        With doc
            .Documento = New SrgsDocument(lector)
            .NombreArchivo = Path.GetFileName(ruta)
        End With
        Return doc
    End Function

    Public Sub Guardar()
        Dim configEscritor As New XmlWriterSettings With {.Indent = True}
        If Not NombreArchivo.ToLower.EndsWith(".srgs") Then
            NombreArchivo &= ".srgs"
        End If
        Using escritor As XmlWriter = XmlWriter.Create(NombreArchivo, configEscritor)
            Documento.WriteSrgs(escritor)
        End Using
    End Sub

    Public Overrides Function ToString() As String
        Return Path.GetFileNameWithoutExtension(NombreArchivo)
    End Function
End Class
