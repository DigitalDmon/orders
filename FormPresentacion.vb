Public Class FormPresentacion
    Private Sub FormPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre del usuario
        LblUsuario.Text = "Usuario: " & Environ("USERNAME")
        ' Mostrar la computadora
        LblPc.Text = "Computadora: " & Environ("COMPUTERNAME")
        ' Versión de la aplicación
        LblVersion.Text = "Versión de .NET: " & System.Environment.Version.ToString()
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        ' Mostrar el formulario principal
        FormMain.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        ' Cerrar la aplicación
        Application.Exit()
    End Sub
End Class