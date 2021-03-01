Imports System.IO

Public Class FrmAdministrarArchivos
    Public Property ArchivoActual As DocumentoSrgs

    Private Sub FrmAdministrarArchivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtArchivoActual.Text = If(ArchivoActual IsNot Nothing, ArchivoActual.NombreArchivo, "Ninguno")
        exploradorCarpetas.SelectedPath = Application.StartupPath
    End Sub

    Private Sub FrmAdministrarArchivos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ActiveControl = Nothing
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim carpetaSeleccionada As String
        exploradorCarpetas.Description = "Seleccione la carpeta donde se creará el archivo."
        If exploradorCarpetas.ShowDialog <> DialogResult.OK Then
            MsgBox("Debe seleccionar la carpeta donde se creará el archivo.")
            Return
        End If
        carpetaSeleccionada = exploradorCarpetas.SelectedPath

        Dim nombre As String = InputBox("Ingrese el nombre del nuevo archivo: ", "Nuevo archivo de gramática")
        If nombre = "" Then
            MsgBox("El nombre de archivo no puede estar en blanco.", MsgBoxStyle.Critical)
            Return
        End If

        Dim caracteresInvalidosDetectados As Char() = nombre.Intersect(Path.GetInvalidFileNameChars).ToArray
        If caracteresInvalidosDetectados.Any Then
            MsgBox("El nombre de archivo no puede contener los siguientes caracteres: " & String.Join(" "c, caracteresInvalidosDetectados))
            Return
        End If

        nombre = Path.Combine(carpetaSeleccionada, nombre)
        ArchivoActual = New DocumentoSrgs(nombre)
        ArchivoActual.Guardar()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnBuscarCarpeta_Click(sender As Object, e As EventArgs) Handles btnBuscarCarpeta.Click
        exploradorCarpetas.Description = "Seleccione la carpeta donde se encuentran los archivos SRGS."
        If exploradorCarpetas.ShowDialog <> DialogResult.OK Then
            Return
        End If

        BuscarArchivosEnCarpeta()
    End Sub

    Private Sub BuscarArchivosEnCarpeta()
        lstArchivos.Items.Clear()
        Dim carpetaSeleccionada As String = exploradorCarpetas.SelectedPath
        txtCarpetaSeleccionada.Text = carpetaSeleccionada
        For Each archivo As String In Directory.GetFiles(carpetaSeleccionada, "*.srgs")
            lstArchivos.Items.Add(Path.GetFileNameWithoutExtension(archivo))
        Next
    End Sub

    Private Sub lstArchivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArchivos.SelectedIndexChanged, lstArchivos.ControlAdded
        For Each c As Control In {btnCambiarNombre, btnEliminar, btnSeleccionar}
            c.Enabled = lstArchivos.SelectedIndex <> -1
        Next
    End Sub

    Private Sub btnCambiarNombre_Click(sender As Object, e As EventArgs) Handles btnCambiarNombre.Click
        Dim nuevoNombre As String = InputBox("Ingrese el nuevo nombre del archivo: ", "Cambiar nombre")
        If nuevoNombre = "" Then
            MsgBox("El nombre de archivo no puede estar en blanco.", MsgBoxStyle.Critical)
            Return
        End If

        Dim caracteresInvalidosDetectados As Char() = nuevoNombre.Intersect(Path.GetInvalidFileNameChars).ToArray
        If caracteresInvalidosDetectados.Any Then
            MsgBox("El nombre de archivo no puede contener los siguientes caracteres: " & String.Join(" "c, caracteresInvalidosDetectados))
            Return
        End If

        If lstArchivos.Items.Contains(nuevoNombre) Then
            MsgBox($"Ya existe un archivo en esta carpeta con este nombre. Elimine el archivo ""{nuevoNombre}"" y reintente.", MsgBoxStyle.Critical)
            Return
        End If

        Dim nuevaRuta As String = Path.Combine(exploradorCarpetas.SelectedPath, nuevoNombre)
        File.Move(lstArchivos.SelectedItem, nuevaRuta)
        MsgBox("¡Hecho!", MsgBoxStyle.Information)
        BuscarArchivosEnCarpeta()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim archivo As String = lstArchivos.SelectedItem
        If MsgBox($"¿Está seguro de que desea eliminar ""{archivo}.srgs""? Esta acción no se puede deshacer.",
                  MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

        Dim ruta As String = Path.Combine(exploradorCarpetas.SelectedPath, archivo)
        File.Delete(ruta)
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim rutaArchivo As String = Path.Combine(exploradorCarpetas.SelectedPath, lstArchivos.SelectedItem & ".srgs")
        ArchivoActual = DocumentoSrgs.DesdeArchivo(rutaArchivo)
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class