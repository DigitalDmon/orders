<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        BtnSalir = New Button()
        BtnFinalizarJornada = New Button()
        BtnIniciarJornada = New Button()
        BtnRealizarPedido = New Button()
        LblInventario = New Label()
        NudCantidadInventario = New NumericUpDown()
        CType(NudCantidadInventario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(713, 415)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 3
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' BtnFinalizarJornada
        ' 
        BtnFinalizarJornada.AutoSize = True
        BtnFinalizarJornada.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnFinalizarJornada.Location = New Point(462, 271)
        BtnFinalizarJornada.Name = "BtnFinalizarJornada"
        BtnFinalizarJornada.Size = New Size(103, 25)
        BtnFinalizarJornada.TabIndex = 5
        BtnFinalizarJornada.Text = "Finalizar jornada"
        BtnFinalizarJornada.UseVisualStyleBackColor = True
        ' 
        ' BtnIniciarJornada
        ' 
        BtnIniciarJornada.AutoSize = True
        BtnIniciarJornada.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnIniciarJornada.Location = New Point(235, 271)
        BtnIniciarJornada.Name = "BtnIniciarJornada"
        BtnIniciarJornada.Size = New Size(92, 25)
        BtnIniciarJornada.TabIndex = 6
        BtnIniciarJornada.Text = "Iniciar jornada"
        BtnIniciarJornada.UseVisualStyleBackColor = True
        ' 
        ' BtnRealizarPedido
        ' 
        BtnRealizarPedido.AutoSize = True
        BtnRealizarPedido.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnRealizarPedido.Location = New Point(346, 271)
        BtnRealizarPedido.Name = "BtnRealizarPedido"
        BtnRealizarPedido.Size = New Size(97, 25)
        BtnRealizarPedido.TabIndex = 7
        BtnRealizarPedido.Text = "Realizar pedido"
        BtnRealizarPedido.UseVisualStyleBackColor = True
        ' 
        ' LblInventario
        ' 
        LblInventario.AutoSize = True
        LblInventario.Location = New Point(351, 218)
        LblInventario.Name = "LblInventario"
        LblInventario.Size = New Size(98, 15)
        LblInventario.TabIndex = 8
        LblInventario.Text = "Inventario actual:"
        ' 
        ' NudCantidadInventario
        ' 
        NudCantidadInventario.Location = New Point(346, 163)
        NudCantidadInventario.Name = "NudCantidadInventario"
        NudCantidadInventario.Size = New Size(120, 23)
        NudCantidadInventario.TabIndex = 9
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(NudCantidadInventario)
        Controls.Add(LblInventario)
        Controls.Add(BtnRealizarPedido)
        Controls.Add(BtnIniciarJornada)
        Controls.Add(BtnFinalizarJornada)
        Controls.Add(BtnSalir)
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMain"
        CType(NudCantidadInventario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnFinalizarJornada As Button
    Friend WithEvents BtnIniciarJornada As Button
    Friend WithEvents BtnRealizarPedido As Button
    Friend WithEvents LblInventario As Label
    Friend WithEvents NudCantidadInventario As NumericUpDown
End Class
