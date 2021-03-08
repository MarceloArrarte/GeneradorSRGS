Imports System.Reflection
Imports System.Speech.Recognition.SrgsGrammar

Public Class FrmInicio
#Region "Gestión de archivos"
    Private _editandoDatosArchivo As Boolean = False
    Private _documentoActual As DocumentoSrgs

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

    Private Property DocumentoActual As DocumentoSrgs
        Get
            'Return _documentoActual

            If _documentoActual Is Nothing Then
                _documentoActual = DocumentoSrgs.DesdeArchivo("confirmation.srgs")
            End If

            Return _documentoActual
        End Get
        Set(value As DocumentoSrgs)
            _documentoActual = value
            txtNombreArchivo.Text = _documentoActual.ToString
            txtIdioma.Text = _documentoActual.Documento.Language
            Select Case _documentoActual.Documento.PhoneticAlphabet
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

    Private Sub btnEditarDatosArchivo_Click(sender As Object, e As EventArgs) Handles btnEditarDatosArchivo.Click
        EditandoDatosArchivo = True
    End Sub

    Private Sub btnCancelarCambiosDatosArchivo_Click(sender As Object, e As EventArgs) Handles btnCancelarCambiosDatosArchivo.Click
        EditandoDatosArchivo = False
        DocumentoActual = DocumentoActual
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
        DocumentoActual.Configuracion = nuevaConfiguracion
        DocumentoActual.Guardar()
        EditandoDatosArchivo = False
    End Sub

    Private Sub btnSeleccionarOtroArchivo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOtroArchivo.Click
        Dim frm As New FrmAdministrarArchivos With {
            .ArchivoActual = DocumentoActual
        }
        If frm.ShowDialog() = DialogResult.OK Then
            DocumentoActual = frm.ArchivoActual
        End If
    End Sub
#End Region

    Private Property ReglaActual As ReglaSrgs

    Private Sub FrmInicio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ActiveControl = Nothing
    End Sub

    Private Sub btnCrearRegla_Click(sender As Object, e As EventArgs) Handles btnCrearRegla.Click
        Try
            ReglaActual = New ReglaSrgs(txtIDRegla.Text, treeResumenRegla)
        Catch ex As FormatException
            MsgBox("Debe ingresar un ID de regla válido.", MsgBoxStyle.Critical, "ID inválido")
        End Try
    End Sub

    Private Sub btnAgregarFrase_Click(sender As Object, e As EventArgs) Handles btnAgregarFrase.Click
        If ReglaActual Is Nothing Then
            MsgBox("Debe crear la regla primero.", MsgBoxStyle.Critical, "Regla no creada.")
            Return
        End If

        'If treeResumenRegla.SelectedNode Is Nothing Then
        '    MsgBox("Debe seleccionar el nodo al cual se agregará la frase.", MsgBoxStyle.Critical, "Nodo no seleccionado")
        '    Return
        'End If

        If txtNuevaFrase.Text.Trim = "" Then
            MsgBox("No se ingresó ninguna frase.", MsgBoxStyle.Critical, "Frase faltante")
            Return
        End If

        Dim minRepeticiones, maxRepeticiones As Integer
        If radRepeticionesPersonalizado.Checked And
            (Not Integer.TryParse(txtMinRepeticiones.Text, minRepeticiones) Or
            Not Integer.TryParse(txtMaxRepeticiones.Text, maxRepeticiones)) Then

            MsgBox("Para un rango de repeticiones personalizado, ambos límites deben ser números enteros no negativos.", MsgBoxStyle.Critical, "Rango de repeticiones inválido.")
            Return
        End If

        Dim texto As String = txtNuevaFrase.Text
        Dim pronunciacion As String = txtPronunciacion.Text.Trim
        Dim especificaPronunciacion As Boolean = pronunciacion <> ""
        Select Case True
            Case radRepeticionesUnaVez.Checked And Not especificaPronunciacion
                ReglaActual.AgregarToken(texto)

            Case radRepeticionesUnaVez.Checked And especificaPronunciacion
                ReglaActual.AgregarToken(texto, pronunciacion)

            Case radRepeticionesOpcional.Checked And Not especificaPronunciacion
                ReglaActual.AgregarToken(texto, 0, 1)

            Case radRepeticionesOpcional.Checked And especificaPronunciacion
                ReglaActual.AgregarToken(texto, pronunciacion, 0, 1)

            Case radRepeticionesPersonalizado.Checked And Not especificaPronunciacion
                ReglaActual.AgregarToken(texto, minRepeticiones, maxRepeticiones)

            Case radRepeticionesPersonalizado.Checked And especificaPronunciacion
                ReglaActual.AgregarToken(texto, pronunciacion, minRepeticiones, maxRepeticiones)
        End Select
    End Sub

    Private Sub btnAgregarOneof_Click(sender As Object, e As EventArgs) Handles btnAgregarOneof.Click
        If ReglaActual Is Nothing Then
            MsgBox("Debe crear la regla primero.", MsgBoxStyle.Critical, "Regla no creada.")
            Return
        End If

        'If treeResumenRegla.SelectedNode Is Nothing Then
        '    MsgBox("Debe seleccionar el nodo al cual se agregará la múltiple opción.", MsgBoxStyle.Critical, "Nodo no seleccionado")
        '    Return
        'End If

        If txtOpcionesOneof.Text.Trim = "" Then
            MsgBox("No se ingresó ninguna opción.", MsgBoxStyle.Critical, "Opciones faltantes")
            Return
        End If

        Dim minRepeticiones, maxRepeticiones As Integer
        If radRepeticionesPersonalizado.Checked And
            (Not Integer.TryParse(txtMinRepeticiones.Text, minRepeticiones) Or
            Not Integer.TryParse(txtMaxRepeticiones.Text, maxRepeticiones)) Then

            MsgBox("Para un rango de repeticiones personalizado, ambos límites deben ser números enteros no negativos.", MsgBoxStyle.Critical, "Rango de repeticiones inválido.")
            Return
        End If

        Dim lineas() As String = txtOpcionesOneof.Text.Split(vbNewLine)

        Select Case True
            Case radRepeticionesUnaVez.Checked
                ReglaActual.AgregarOneOf(lineas)

            Case radRepeticionesOpcional.Checked
                ReglaActual.AgregarOneOf(0, 1, lineas)

            Case radRepeticionesPersonalizado.Checked
                ReglaActual.AgregarOneOf(minRepeticiones, maxRepeticiones, lineas)
        End Select
    End Sub

    Private Sub cbxReglaReferenciada_VisibleChanged(sender As Object, e As EventArgs) Handles cbxReglaReferenciada.VisibleChanged
        Dim bindingSourceReglasDocumento As New BindingSource With {.DataSource = DocumentoActual.Documento.Rules}

        With cbxReglaReferenciada
            .DataSource = bindingSourceReglasDocumento
            .DisplayMember = "Id"
        End With
    End Sub

    Private Sub btnAgregarReferencia_Click(sender As Object, e As EventArgs) Handles btnAgregarReferencia.Click
        If ReglaActual Is Nothing Then
            MsgBox("Debe crear la regla primero.", MsgBoxStyle.Critical, "Regla no creada.")
            Return
        End If

        'If treeResumenRegla.SelectedNode Is Nothing Then
        '    MsgBox("Debe seleccionar el nodo al cual se agregará la múltiple opción.", MsgBoxStyle.Critical, "Nodo no seleccionado")
        '    Return
        'End If

        If cbxReglaReferenciada.SelectedIndex = -1 Then
            MsgBox("No se seleccionó ninguna regla.", MsgBoxStyle.Critical, "Opciones faltantes")
            Return
        End If

        ' TODO: una regla no puede referenciarse a sí misma

        Dim minRepeticiones, maxRepeticiones As Integer
        If radRepeticionesPersonalizado.Checked And
            (Not Integer.TryParse(txtMinRepeticiones.Text, minRepeticiones) Or
            Not Integer.TryParse(txtMaxRepeticiones.Text, maxRepeticiones)) Then

            MsgBox("Para un rango de repeticiones personalizado, ambos límites deben ser números enteros no negativos.", MsgBoxStyle.Critical, "Rango de repeticiones inválido.")
            Return
        End If

        Dim reglaReferenciada As SrgsRule = CType(cbxReglaReferenciada.SelectedItem, SrgsRule)

        Select Case True
            Case radRepeticionesUnaVez.Checked
                ReglaActual.AgregarRuleRef(reglaReferenciada)

            Case radRepeticionesOpcional.Checked
                ReglaActual.AgregarRuleRef(reglaReferenciada, 0, 1)

            Case radRepeticionesPersonalizado.Checked
                ReglaActual.AgregarRuleRef(reglaReferenciada, minRepeticiones, maxRepeticiones)
        End Select
    End Sub

    Private Sub radRepeticionesPersonalizado_CheckedChanged(sender As Object, e As EventArgs) Handles radRepeticionesPersonalizado.CheckedChanged
        With radRepeticionesPersonalizado
            txtMinRepeticiones.ReadOnly = Not .Checked
            txtMaxRepeticiones.ReadOnly = Not .Checked
        End With
    End Sub

    Private Sub btnModificarItemRegla_Click(sender As Object, e As EventArgs) Handles btnModificarItemRegla.Click

    End Sub

    Private Sub btnEliminarItemRegla_Click(sender As Object, e As EventArgs) Handles btnEliminarItemRegla.Click
        If treeResumenRegla.SelectedNode Is Nothing Then
            MsgBox("Seleccione un item para eliminarlo de la regla.", MsgBoxStyle.Information)
            Return
        End If

        Dim itemSeleccionado As SrgsItem = treeResumenRegla.SelectedNode.Tag
        ReglaActual.EliminarItem(itemSeleccionado)
    End Sub
End Class
