<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministrarArchivos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArchivoActual = New System.Windows.Forms.TextBox()
        Me.lstArchivos = New System.Windows.Forms.ListBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnCambiarNombre = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.exploradorCarpetas = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtCarpetaSeleccionada = New System.Windows.Forms.TextBox()
        Me.btnBuscarCarpeta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Archivo actual:"
        '
        'txtArchivoActual
        '
        Me.txtArchivoActual.Location = New System.Drawing.Point(131, 10)
        Me.txtArchivoActual.Name = "txtArchivoActual"
        Me.txtArchivoActual.ReadOnly = True
        Me.txtArchivoActual.Size = New System.Drawing.Size(215, 20)
        Me.txtArchivoActual.TabIndex = 1
        '
        'lstArchivos
        '
        Me.lstArchivos.FormattingEnabled = True
        Me.lstArchivos.Location = New System.Drawing.Point(13, 70)
        Me.lstArchivos.Name = "lstArchivos"
        Me.lstArchivos.Size = New System.Drawing.Size(333, 186)
        Me.lstArchivos.TabIndex = 2
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(363, 44)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(124, 23)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(363, 195)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(124, 23)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnCambiarNombre
        '
        Me.btnCambiarNombre.Location = New System.Drawing.Point(363, 82)
        Me.btnCambiarNombre.Name = "btnCambiarNombre"
        Me.btnCambiarNombre.Size = New System.Drawing.Size(124, 23)
        Me.btnCambiarNombre.TabIndex = 5
        Me.btnCambiarNombre.Text = "Cambiar nombre"
        Me.btnCambiarNombre.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(363, 120)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(363, 233)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(124, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCarpetaSeleccionada
        '
        Me.txtCarpetaSeleccionada.Location = New System.Drawing.Point(131, 44)
        Me.txtCarpetaSeleccionada.Name = "txtCarpetaSeleccionada"
        Me.txtCarpetaSeleccionada.ReadOnly = True
        Me.txtCarpetaSeleccionada.Size = New System.Drawing.Size(215, 20)
        Me.txtCarpetaSeleccionada.TabIndex = 9
        '
        'btnBuscarCarpeta
        '
        Me.btnBuscarCarpeta.Location = New System.Drawing.Point(12, 42)
        Me.btnBuscarCarpeta.Name = "btnBuscarCarpeta"
        Me.btnBuscarCarpeta.Size = New System.Drawing.Size(113, 23)
        Me.btnBuscarCarpeta.TabIndex = 10
        Me.btnBuscarCarpeta.Text = "Buscar en carpeta"
        Me.btnBuscarCarpeta.UseVisualStyleBackColor = True
        '
        'FrmAdministrarArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 268)
        Me.Controls.Add(Me.btnBuscarCarpeta)
        Me.Controls.Add(Me.txtCarpetaSeleccionada)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCambiarNombre)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lstArchivos)
        Me.Controls.Add(Me.txtArchivoActual)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdministrarArchivos"
        Me.Text = "Administrar archivos..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtArchivoActual As TextBox
    Friend WithEvents lstArchivos As ListBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnCambiarNombre As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents exploradorCarpetas As FolderBrowserDialog
    Friend WithEvents txtCarpetaSeleccionada As TextBox
    Friend WithEvents btnBuscarCarpeta As Button
End Class
