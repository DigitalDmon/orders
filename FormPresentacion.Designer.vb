<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPresentacion))
        BtnIniciar = New Button()
        BtnSalir = New Button()
        LblUsuario = New Label()
        LblPc = New Label()
        LblVersion = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BtnIniciar
        ' 
        BtnIniciar.Location = New Point(632, 415)
        BtnIniciar.Name = "BtnIniciar"
        BtnIniciar.Size = New Size(75, 23)
        BtnIniciar.TabIndex = 0
        BtnIniciar.Text = "Iniciar"
        BtnIniciar.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(713, 415)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 1
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Location = New Point(12, 380)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(47, 15)
        LblUsuario.TabIndex = 2
        LblUsuario.Text = "Usuario"
        ' 
        ' LblPc
        ' 
        LblPc.AutoSize = True
        LblPc.Location = New Point(12, 403)
        LblPc.Name = "LblPc"
        LblPc.Size = New Size(81, 15)
        LblPc.TabIndex = 3
        LblPc.Text = "Computadora"
        ' 
        ' LblVersion
        ' 
        LblVersion.AutoSize = True
        LblVersion.Location = New Point(12, 426)
        LblVersion.Name = "LblVersion"
        LblVersion.Size = New Size(132, 15)
        LblVersion.TabIndex = 4
        LblVersion.Text = "Versión de Visual Studio"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(776, 320)
        Label1.TabIndex = 5
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(632, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 83)
        Label2.TabIndex = 6
        Label2.Text = "Taller #2" & vbCrLf & vbCrLf & "Pequeño sistema de gestión de pedidos de vacunas que muestra los pedidos realizados con la cantidad restante" & vbCrLf
        ' 
        ' FormPresentacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LblVersion)
        Controls.Add(LblPc)
        Controls.Add(LblUsuario)
        Controls.Add(BtnSalir)
        Controls.Add(BtnIniciar)
        Name = "FormPresentacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPresentacion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnIniciar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblPc As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
