Imports System.Speech.Recognition.SrgsGrammar

Public Class FrmInicio
    Private _editandoDatosArchivo As Boolean = False
    Private _archivoActual As DocumentoSrgs

    Private Property EditandoDatosArchivo As Boolean
        Get
            Return _editandoDatosArchivo
        End Get
        Set(value As Boolean)
            _editandoDatosArchivo = value
            For Each c As Control In {txtNombreArchivo, txtIdioma, btnOtroIdioma, radFonemasIPA, radFonemasSAPI, radFonemasUPS, btnCancelarCambiosDatosArchivo, btnGuardarCambiosDatosArchivo}
                c.Enabled = _editandoDatosArchivo
            Next
            For Each t As TextBox In {txtNombreArchivo, txtIdioma}
                t.ReadOnly = Not _editandoDatosArchivo
            Next

            For Each c As Control In {btnEditarDatosArchivo, btnSeleccionarOtroArchivo}
                c.Enabled = Not _editandoDatosArchivo
            Next
        End Set
    End Property

    Private Property ArchivoActual As DocumentoSrgs
        Get
            Return _archivoActual
        End Get
        Set(value As DocumentoSrgs)
            _archivoActual = value
            txtNombreArchivo.Text = _archivoActual.ToString
            txtIdioma.Text = _archivoActual.Documento.Language
            Select Case _archivoActual.Documento.PhoneticAlphabet
                Case SrgsPhoneticAlphabet.Ipa
                    radFonemasIPA.Checked = True

                Case SrgsPhoneticAlphabet.Sapi
                    radFonemasSAPI.Checked = True

                Case SrgsPhoneticAlphabet.Ups
                    radFonemasUPS.Checked = True
            End Select

            btnEditarDatosArchivo.Enabled = True
        End Set
    End Property

    Private Sub FrmInicio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ActiveControl = Nothing
    End Sub

    Private Sub btnEditarDatosArchivo_Click(sender As Object, e As EventArgs) Handles btnEditarDatosArchivo.Click
        EditandoDatosArchivo = True
    End Sub

    Private Sub btnCancelarCambiosDatosArchivo_Click(sender As Object, e As EventArgs) Handles btnCancelarCambiosDatosArchivo.Click
        EditandoDatosArchivo = False
        ArchivoActual = ArchivoActual
    End Sub

    Private Sub btnGuardarCambiosDatosArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosDatosArchivo.Click
        Dim nuevoNombre As String = txtNombreArchivo.Text
        Dim nuevoIdioma As String = txtIdioma.Text
        Dim nuevoAlfabeto As SrgsPhoneticAlphabet
        Select Case True
            Case radFonemasSAPI.Checked
                nuevoAlfabeto = SrgsPhoneticAlphabet.Sapi
            Case radFonemasIPA.Checked
                nuevoAlfabeto = SrgsPhoneticAlphabet.Ipa
            Case radFonemasUPS.Checked
                nuevoAlfabeto = SrgsPhoneticAlphabet.Ups
        End Select
        Dim nuevaConfiguracion As New ConfigSrgs(nuevoNombre, nuevoIdioma, nuevoAlfabeto)
        ArchivoActual.Configuracion = nuevaConfiguracion
        ArchivoActual.Guardar()
        EditandoDatosArchivo = False
    End Sub

    Private Sub btnSeleccionarOtroArchivo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOtroArchivo.Click
        Dim frm As New FrmAdministrarArchivos With {
            .ArchivoActual = ArchivoActual
        }
        If frm.ShowDialog() = DialogResult.OK Then
            ArchivoActual = frm.ArchivoActual
        End If
    End Sub
End Class
