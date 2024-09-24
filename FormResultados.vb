Public Class FormResultados
    ' Variables privadas para almacenar la lista de pedidos y el total de vacunas restantes
    Private pedidos As List(Of InfoPedido)
    Private totalVacunasRestantes As Integer

    ' Constructor de la clase que se ejecuta al crear una nueva instancia del formulario
    Public Sub New(pedidos As List(Of InfoPedido), totalVacunasRestantes As Integer)

        ' Inicializar los componentes visuales del formulario
        InitializeComponent()

        ' Asignar la lista de pedidos y el total de vacunas restantes pasados al formulario
        Me.pedidos = pedidos
        Me.totalVacunasRestantes = totalVacunasRestantes

        ' Llamar al método para mostrar los resultados
        MostrarResultados()

    End Sub

    ' Método para mostrar los resultados de los pedidos
    Private Sub MostrarResultados()

        ' Filtrar los pedidos entregados y rechazados
        Dim entregados = pedidos.Where(Function(p) p.Estado = "Entregado").ToList()
        Dim rechazados = pedidos.Where(Function(p) p.Estado = "Rechazado").ToList()

        ' Mostrar el total de vacunas restantes en la etiqueta
        LblTotalVacunas.Text = $"Vacunas restantes: {totalVacunasRestantes}"

        ' Asignar la lista de pedidos como fuente de datos del DataGridView
        DgvPedidos.DataSource = pedidos

    End Sub

    ' Evento que se ejecuta al hacer clic en el botón "Salir"
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        ' Cerrar la aplicación por completo
        Application.Exit()

    End Sub

End Class
