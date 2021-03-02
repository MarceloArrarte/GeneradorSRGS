Imports System.Speech.Recognition.SrgsGrammar

Public Class FrmInicio
    Private _editandoDatosArchivo As Boolean = False
    Private _archivoActual As DocumentoSrgs

#Region "Gestión de archivos"
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
#End Region

    Private Sub FrmInicio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ActiveControl = Nothing
    End Sub

    Private Sub txtIDRegla_TextChanged(sender As Object, e As EventArgs) Handles txtIDRegla.TextChanged
        If treeResumenRegla.Nodes.Count = 0 Then
            treeResumenRegla.Nodes.Add("")
        End If

        treeResumenRegla.Nodes(0).Text = txtIDRegla.Text
    End Sub

    Private Sub btnAgregarFrase_Click(sender As Object, e As EventArgs) Handles btnAgregarFrase.Click
        If treeResumenRegla.Nodes.Count = 0 Then
            MsgBox("Debe especificar el ID de la regla primero.", MsgBoxStyle.Critical, "ID de regla faltante.")
            Return
        End If

        If treeResumenRegla.SelectedNode Is Nothing Then
            MsgBox("Debe seleccionar el nodo al cual se agregará la frase.", MsgBoxStyle.Critical, "Nodo no seleccionado")
            Return
        End If

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

        If minRepeticiones > maxRepeticiones Then
            minRepeticiones = txtMaxRepeticiones.Text
            maxRepeticiones = txtMinRepeticiones.Text
        End If

        Dim tokenSrgs As New SrgsToken(txtNuevaFrase.Text)
        Dim especificaPronunciacion As Boolean = txtPronunciacion.Text.Trim <> ""
        If especificaPronunciacion Then
            tokenSrgs.Pronunciation = txtPronunciacion.Text
        End If
        Dim itemSrgs As New SrgsItem(tokenSrgs)

        Select Case True
            Case radRepeticionesOpcional.Checked
                itemSrgs.SetRepeat(0, 1)
            Case radRepeticionesPersonalizado.Checked
                itemSrgs.SetRepeat(minRepeticiones, maxRepeticiones)
        End Select

        Dim nodoFrase As New TreeNode(itemSrgs.VistaPreviaTreeView) With {.Tag = itemSrgs}
        treeResumenRegla.SelectedNode.Nodes.Add(nodoFrase)
        nodoFrase.EnsureVisible()
    End Sub

    Private Sub btnAgregarOneof_Click(sender As Object, e As EventArgs) Handles btnAgregarOneof.Click
        If treeResumenRegla.Nodes.Count = 0 Then
            MsgBox("Debe especificar el ID de la regla primero.", MsgBoxStyle.Critical, "ID de regla faltante.")
            Return
        End If

        If treeResumenRegla.SelectedNode Is Nothing Then
            MsgBox("Debe seleccionar el nodo al cual se agregará la frase.", MsgBoxStyle.Critical, "Nodo no seleccionado")
            Return
        End If

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

        If minRepeticiones > maxRepeticiones Then
            minRepeticiones = txtMaxRepeticiones.Text
            maxRepeticiones = txtMinRepeticiones.Text
        End If

        Dim lineas() As String = txtOpcionesOneof.Text.Split(vbNewLine)
        Dim items(lineas.Length - 1) As SrgsItem
        For i As Integer = 0 To lineas.Length - 1
            items(i) = New SrgsItem(lineas(i))
        Next

        Dim oneof As New SrgsOneOf(items)
        Dim nodoOneof As New TreeNode(oneof.VistaPreviaTreeView) With {.Tag = oneof}

        For Each i As SrgsItem In oneof.Items
            Dim opcion As SrgsText = CType(i.Elements(0), SrgsText)
            Dim nodoOpcion As New TreeNode(opcion.Text) With {.Tag = opcion}
            nodoOneof.Nodes.Add(nodoOpcion)
        Next

        treeResumenRegla.Nodes.Add(nodoOneof)
        nodoOneof.EnsureVisible()
        nodoOneof.Expand()
    End Sub
End Class
