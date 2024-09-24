<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultados
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
        LblTotalVacunas = New Label()
        DgvPedidos = New DataGridView()
        CType(DgvPedidos, ComponentModel.ISupportInitialize).BeginInit()
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
        ' LblTotalVacunas
        ' 
        LblTotalVacunas.AutoSize = True
        LblTotalVacunas.Font = New Font("Segoe UI", 12F)
        LblTotalVacunas.Location = New Point(12, 9)
        LblTotalVacunas.Name = "LblTotalVacunas"
        LblTotalVacunas.Size = New Size(56, 21)
        LblTotalVacunas.TabIndex = 5
        LblTotalVacunas.Text = "Label1"
        ' 
        ' DgvPedidos
        ' 
        DgvPedidos.AllowUserToAddRows = False
        DgvPedidos.AllowUserToDeleteRows = False
        DgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvPedidos.Location = New Point(12, 49)
        DgvPedidos.Name = "DgvPedidos"
        DgvPedidos.ReadOnly = True
        DgvPedidos.Size = New Size(776, 360)
        DgvPedidos.TabIndex = 6
        ' 
        ' FormResultados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DgvPedidos)
        Controls.Add(LblTotalVacunas)
        Controls.Add(BtnSalir)
        Name = "FormResultados"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormResultados"
        CType(DgvPedidos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblTotalVacunas As Label
    Friend WithEvents DgvPedidos As DataGridView
End Class
