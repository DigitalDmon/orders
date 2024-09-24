<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrden
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
        CmbInstitucion = New ComboBox()
        NudCantidad = New NumericUpDown()
        BtnRealizarPedido = New Button()
        BtnFinalizarJornada = New Button()
        LblVacunasRestantes = New Label()
        CType(NudCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(713, 415)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 4
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' CmbInstitucion
        ' 
        CmbInstitucion.FormattingEnabled = True
        CmbInstitucion.Location = New Point(289, 143)
        CmbInstitucion.Name = "CmbInstitucion"
        CmbInstitucion.Size = New Size(121, 23)
        CmbInstitucion.TabIndex = 5
        CmbInstitucion.Text = "Elija la institución"
        ' 
        ' NudCantidad
        ' 
        NudCantidad.Location = New Point(289, 192)
        NudCantidad.Name = "NudCantidad"
        NudCantidad.Size = New Size(120, 23)
        NudCantidad.TabIndex = 6
        NudCantidad.Tag = ""
        ' 
        ' BtnRealizarPedido
        ' 
        BtnRealizarPedido.AutoSize = True
        BtnRealizarPedido.Location = New Point(289, 241)
        BtnRealizarPedido.Name = "BtnRealizarPedido"
        BtnRealizarPedido.Size = New Size(97, 25)
        BtnRealizarPedido.TabIndex = 7
        BtnRealizarPedido.Text = "Realizar pedido"
        BtnRealizarPedido.UseVisualStyleBackColor = True
        ' 
        ' BtnFinalizarJornada
        ' 
        BtnFinalizarJornada.AutoSize = True
        BtnFinalizarJornada.Location = New Point(408, 241)
        BtnFinalizarJornada.Name = "BtnFinalizarJornada"
        BtnFinalizarJornada.Size = New Size(103, 25)
        BtnFinalizarJornada.TabIndex = 8
        BtnFinalizarJornada.Text = "Finalizar jornada"
        BtnFinalizarJornada.UseVisualStyleBackColor = True
        ' 
        ' LblVacunasRestantes
        ' 
        LblVacunasRestantes.AutoSize = True
        LblVacunasRestantes.Location = New Point(289, 292)
        LblVacunasRestantes.Name = "LblVacunasRestantes"
        LblVacunasRestantes.Size = New Size(100, 15)
        LblVacunasRestantes.TabIndex = 9
        LblVacunasRestantes.Text = "Vacunas restantes"
        ' 
        ' FormOrden
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblVacunasRestantes)
        Controls.Add(BtnFinalizarJornada)
        Controls.Add(BtnRealizarPedido)
        Controls.Add(NudCantidad)
        Controls.Add(CmbInstitucion)
        Controls.Add(BtnSalir)
        Name = "FormOrden"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOrden"
        CType(NudCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents CmbInstitucion As ComboBox
    Friend WithEvents NudCantidad As NumericUpDown
    Friend WithEvents BtnRealizarPedido As Button
    Friend WithEvents BtnFinalizarJornada As Button
    Friend WithEvents LblVacunasRestantes As Label
End Class
