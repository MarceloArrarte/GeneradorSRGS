<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOtroIdioma = New System.Windows.Forms.Button()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelarCambiosDatosArchivo = New System.Windows.Forms.Button()
        Me.btnGuardarCambiosDatosArchivo = New System.Windows.Forms.Button()
        Me.btnSeleccionarOtroArchivo = New System.Windows.Forms.Button()
        Me.btnEditarDatosArchivo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radFonemasUPS = New System.Windows.Forms.RadioButton()
        Me.radFonemasSAPI = New System.Windows.Forms.RadioButton()
        Me.radFonemasIPA = New System.Windows.Forms.RadioButton()
        Me.txtNombreArchivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabNodos = New System.Windows.Forms.TabPage()
        Me.tabXML = New System.Windows.Forms.TabPage()
        Me.arbNodos = New System.Windows.Forms.TreeView()
        Me.txtVistaXML = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIDRegla = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabItem = New System.Windows.Forms.TabPage()
        Me.tabOneOf = New System.Windows.Forms.TabPage()
        Me.tabRuleRef = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnAgregarFrase = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabNodos.SuspendLayout()
        Me.tabXML.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnOtroIdioma)
        Me.GroupBox1.Controls.Add(Me.txtIdioma)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.btnCancelarCambiosDatosArchivo)
        Me.GroupBox1.Controls.Add(Me.btnGuardarCambiosDatosArchivo)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarOtroArchivo)
        Me.GroupBox1.Controls.Add(Me.btnEditarDatosArchivo)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtNombreArchivo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de archivo"
        '
        'btnOtroIdioma
        '
        Me.btnOtroIdioma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOtroIdioma.Enabled = False
        Me.btnOtroIdioma.Location = New System.Drawing.Point(391, 53)
        Me.btnOtroIdioma.Name = "btnOtroIdioma"
        Me.btnOtroIdioma.Size = New System.Drawing.Size(63, 23)
        Me.btnOtroIdioma.TabIndex = 12
        Me.btnOtroIdioma.Text = "Otro..."
        Me.btnOtroIdioma.UseVisualStyleBackColor = True
        '
        'txtIdioma
        '
        Me.txtIdioma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdioma.Location = New System.Drawing.Point(69, 54)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.ReadOnly = True
        Me.txtIdioma.Size = New System.Drawing.Size(312, 20)
        Me.txtIdioma.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(6, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(448, 2)
        Me.Panel3.TabIndex = 10
        '
        'btnCancelarCambiosDatosArchivo
        '
        Me.btnCancelarCambiosDatosArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCambiosDatosArchivo.Enabled = False
        Me.btnCancelarCambiosDatosArchivo.Location = New System.Drawing.Point(305, 115)
        Me.btnCancelarCambiosDatosArchivo.Name = "btnCancelarCambiosDatosArchivo"
        Me.btnCancelarCambiosDatosArchivo.Size = New System.Drawing.Size(59, 23)
        Me.btnCancelarCambiosDatosArchivo.TabIndex = 9
        Me.btnCancelarCambiosDatosArchivo.Text = "Cancelar"
        Me.btnCancelarCambiosDatosArchivo.UseVisualStyleBackColor = True
        '
        'btnGuardarCambiosDatosArchivo
        '
        Me.btnGuardarCambiosDatosArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarCambiosDatosArchivo.Enabled = False
        Me.btnGuardarCambiosDatosArchivo.Location = New System.Drawing.Point(391, 115)
        Me.btnGuardarCambiosDatosArchivo.Name = "btnGuardarCambiosDatosArchivo"
        Me.btnGuardarCambiosDatosArchivo.Size = New System.Drawing.Size(60, 23)
        Me.btnGuardarCambiosDatosArchivo.TabIndex = 8
        Me.btnGuardarCambiosDatosArchivo.Text = "Guardar"
        Me.btnGuardarCambiosDatosArchivo.UseVisualStyleBackColor = True
        '
        'btnSeleccionarOtroArchivo
        '
        Me.btnSeleccionarOtroArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarOtroArchivo.Location = New System.Drawing.Point(305, 157)
        Me.btnSeleccionarOtroArchivo.Name = "btnSeleccionarOtroArchivo"
        Me.btnSeleccionarOtroArchivo.Size = New System.Drawing.Size(146, 23)
        Me.btnSeleccionarOtroArchivo.TabIndex = 7
        Me.btnSeleccionarOtroArchivo.Text = "Seleccionar otro archivo"
        Me.btnSeleccionarOtroArchivo.UseVisualStyleBackColor = True
        '
        'btnEditarDatosArchivo
        '
        Me.btnEditarDatosArchivo.Enabled = False
        Me.btnEditarDatosArchivo.Location = New System.Drawing.Point(6, 115)
        Me.btnEditarDatosArchivo.Name = "btnEditarDatosArchivo"
        Me.btnEditarDatosArchivo.Size = New System.Drawing.Size(60, 23)
        Me.btnEditarDatosArchivo.TabIndex = 6
        Me.btnEditarDatosArchivo.Text = "Editar"
        Me.btnEditarDatosArchivo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.radFonemasUPS)
        Me.Panel2.Controls.Add(Me.radFonemasSAPI)
        Me.Panel2.Controls.Add(Me.radFonemasIPA)
        Me.Panel2.Location = New System.Drawing.Point(99, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 22)
        Me.Panel2.TabIndex = 5
        '
        'radFonemasUPS
        '
        Me.radFonemasUPS.AutoSize = True
        Me.radFonemasUPS.Enabled = False
        Me.radFonemasUPS.Location = New System.Drawing.Point(217, 3)
        Me.radFonemasUPS.Name = "radFonemasUPS"
        Me.radFonemasUPS.Size = New System.Drawing.Size(47, 17)
        Me.radFonemasUPS.TabIndex = 2
        Me.radFonemasUPS.Text = "UPS"
        Me.radFonemasUPS.UseVisualStyleBackColor = True
        '
        'radFonemasSAPI
        '
        Me.radFonemasSAPI.AutoSize = True
        Me.radFonemasSAPI.Enabled = False
        Me.radFonemasSAPI.Location = New System.Drawing.Point(1, 2)
        Me.radFonemasSAPI.Name = "radFonemasSAPI"
        Me.radFonemasSAPI.Size = New System.Drawing.Size(49, 17)
        Me.radFonemasSAPI.TabIndex = 1
        Me.radFonemasSAPI.Text = "SAPI"
        Me.radFonemasSAPI.UseVisualStyleBackColor = True
        '
        'radFonemasIPA
        '
        Me.radFonemasIPA.AutoSize = True
        Me.radFonemasIPA.Checked = True
        Me.radFonemasIPA.Enabled = False
        Me.radFonemasIPA.Location = New System.Drawing.Point(107, 3)
        Me.radFonemasIPA.Name = "radFonemasIPA"
        Me.radFonemasIPA.Size = New System.Drawing.Size(42, 17)
        Me.radFonemasIPA.TabIndex = 0
        Me.radFonemasIPA.TabStop = True
        Me.radFonemasIPA.Text = "IPA"
        Me.radFonemasIPA.UseVisualStyleBackColor = True
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreArchivo.Location = New System.Drawing.Point(69, 27)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.ReadOnly = True
        Me.txtNombreArchivo.Size = New System.Drawing.Size(385, 20)
        Me.txtNombreArchivo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alfabeto fonético"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Idioma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabNodos)
        Me.TabControl1.Controls.Add(Me.tabXML)
        Me.TabControl1.Location = New System.Drawing.Point(479, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(397, 554)
        Me.TabControl1.TabIndex = 1
        '
        'tabNodos
        '
        Me.tabNodos.Controls.Add(Me.arbNodos)
        Me.tabNodos.Location = New System.Drawing.Point(4, 22)
        Me.tabNodos.Name = "tabNodos"
        Me.tabNodos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNodos.Size = New System.Drawing.Size(389, 528)
        Me.tabNodos.TabIndex = 0
        Me.tabNodos.Text = "Vista de nodos"
        Me.tabNodos.UseVisualStyleBackColor = True
        '
        'tabXML
        '
        Me.tabXML.Controls.Add(Me.txtVistaXML)
        Me.tabXML.Location = New System.Drawing.Point(4, 22)
        Me.tabXML.Name = "tabXML"
        Me.tabXML.Padding = New System.Windows.Forms.Padding(3)
        Me.tabXML.Size = New System.Drawing.Size(389, 399)
        Me.tabXML.TabIndex = 1
        Me.tabXML.Text = "Vista XML"
        Me.tabXML.UseVisualStyleBackColor = True
        '
        'arbNodos
        '
        Me.arbNodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.arbNodos.Location = New System.Drawing.Point(6, 6)
        Me.arbNodos.Name = "arbNodos"
        Me.arbNodos.Size = New System.Drawing.Size(377, 516)
        Me.arbNodos.TabIndex = 0
        '
        'txtVistaXML
        '
        Me.txtVistaXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVistaXML.Location = New System.Drawing.Point(6, 6)
        Me.txtVistaXML.Multiline = True
        Me.txtVistaXML.Name = "txtVistaXML"
        Me.txtVistaXML.ReadOnly = True
        Me.txtVistaXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVistaXML.Size = New System.Drawing.Size(377, 387)
        Me.txtVistaXML.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl2)
        Me.GroupBox2.Controls.Add(Me.TreeView1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtIDRegla)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 340)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nueva regla"
        '
        'txtIDRegla
        '
        Me.txtIDRegla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDRegla.Location = New System.Drawing.Point(100, 30)
        Me.txtIDRegla.Name = "txtIDRegla"
        Me.txtIDRegla.Size = New System.Drawing.Size(348, 20)
        Me.txtIDRegla.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID de regla:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Resumen de regla:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabItem)
        Me.TabControl2.Controls.Add(Me.tabOneOf)
        Me.TabControl2.Controls.Add(Me.tabRuleRef)
        Me.TabControl2.Location = New System.Drawing.Point(14, 68)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(198, 207)
        Me.TabControl2.TabIndex = 1
        '
        'tabItem
        '
        Me.tabItem.Controls.Add(Me.btnAgregarFrase)
        Me.tabItem.Controls.Add(Me.TextBox2)
        Me.tabItem.Controls.Add(Me.TextBox1)
        Me.tabItem.Controls.Add(Me.Label7)
        Me.tabItem.Controls.Add(Me.Label6)
        Me.tabItem.Location = New System.Drawing.Point(4, 22)
        Me.tabItem.Name = "tabItem"
        Me.tabItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItem.Size = New System.Drawing.Size(190, 181)
        Me.tabItem.TabIndex = 1
        Me.tabItem.Text = "Frase"
        Me.tabItem.UseVisualStyleBackColor = True
        '
        'tabOneOf
        '
        Me.tabOneOf.Location = New System.Drawing.Point(4, 22)
        Me.tabOneOf.Name = "tabOneOf"
        Me.tabOneOf.Size = New System.Drawing.Size(190, 181)
        Me.tabOneOf.TabIndex = 2
        Me.tabOneOf.Text = "Múltiple opción"
        Me.tabOneOf.UseVisualStyleBackColor = True
        '
        'tabRuleRef
        '
        Me.tabRuleRef.Location = New System.Drawing.Point(4, 22)
        Me.tabRuleRef.Name = "tabRuleRef"
        Me.tabRuleRef.Size = New System.Drawing.Size(190, 181)
        Me.tabRuleRef.TabIndex = 3
        Me.tabRuleRef.Text = "Referencia a regla"
        Me.tabRuleRef.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(255, 90)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(193, 181)
        Me.TreeView1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Palabra o frase:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Pronunciación (opcional):"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 3
        '
        'btnAgregarFrase
        '
        Me.btnAgregarFrase.Location = New System.Drawing.Point(54, 139)
        Me.btnAgregarFrase.Name = "btnAgregarFrase"
        Me.btnAgregarFrase.Size = New System.Drawing.Size(80, 23)
        Me.btnAgregarFrase.TabIndex = 4
        Me.btnAgregarFrase.Text = "Insertar frase"
        Me.btnAgregarFrase.UseVisualStyleBackColor = True
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 579)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmInicio"
        Me.Text = "Generador de gramática SRGS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabNodos.ResumeLayout(False)
        Me.tabXML.ResumeLayout(False)
        Me.tabXML.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tabItem.ResumeLayout(False)
        Me.tabItem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreArchivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardarCambiosDatosArchivo As Button
    Friend WithEvents btnSeleccionarOtroArchivo As Button
    Friend WithEvents btnEditarDatosArchivo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radFonemasUPS As RadioButton
    Friend WithEvents radFonemasSAPI As RadioButton
    Friend WithEvents radFonemasIPA As RadioButton
    Friend WithEvents btnCancelarCambiosDatosArchivo As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOtroIdioma As Button
    Friend WithEvents txtIdioma As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabNodos As TabPage
    Friend WithEvents arbNodos As TreeView
    Friend WithEvents tabXML As TabPage
    Friend WithEvents txtVistaXML As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIDRegla As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tabItem As TabPage
    Friend WithEvents btnAgregarFrase As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tabOneOf As TabPage
    Friend WithEvents tabRuleRef As TabPage
    Friend WithEvents TreeView1 As TreeView
End Class
