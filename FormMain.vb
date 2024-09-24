Public Class FormMain

    ' Crear un inventario y una lista de pedidos
    Private inventario As New InfoInventario()
    Private pedidos As New List(Of InfoPedido)()

    ' Evento que se ejecuta al cargar el formulario principal
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar los valores mínimos y máximos del control NumericUpDown
        NudCantidadInventario.Minimum = 4500 ' Establecer el valor mínimo a 100
        NudCantidadInventario.Maximum = Integer.MaxValue ' Establecer el valor máximo a un número muy grande

    End Sub

    ' Botón para iniciar la jornada
    Private Sub BtnIniciarJornada_Click(sender As Object, e As EventArgs) Handles BtnIniciarJornada.Click

        Dim cantidadInicial As Integer

        ' Verificar que la cantidad inicial sea mayor a 4500
        If Integer.TryParse(NudCantidadInventario.Value, cantidadInicial) AndAlso cantidadInicial >= 4500 Then
            ' Inicializar el inventario
            inventario.TotalVacunas = cantidadInicial
            ' Mostrar la cantidad inicial en el label que muestra el inventario
            LblInventario.Text = "Inventario: " & inventario.TotalVacunas.ToString()
        Else
            ' Mostrar un mensaje de error
            MessageBox.Show("Ingrese un valor mayor o igual a 4500.")
        End If

    End Sub

    ' Botón para realizar un pedido
    Private Sub BtnRealizarPedido_Click(sender As Object, e As EventArgs) Handles BtnRealizarPedido.Click

        ' Verificar si el Label no tiene un valor o si es menor a 4500
        If NudCantidadInventario.Value < 4500 Then
            MessageBox.Show("Debe ingresar un valor de 4500 o más.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del método si la condición no se cumple
        Else
            inventario.TotalVacunas = CInt(NudCantidadInventario.Value)
        End If

        ' Crear un nuevo formulario de pedido y mostrarlo
        Dim orderForm As New FormOrden(inventario, pedidos)

        ' Mostrar el formulario de pedido
        orderForm.ShowDialog()

        ' Actualizar el inventario en el label
        LblInventario.Text = "Inventario: " & inventario.TotalVacunas.ToString()

        ' Pasar el total de vacunas restantes a FormResultados
        Dim totalVacunasRestantes As Integer = inventario.TotalVacunas

        ' Crear un formulario de resultados y mostrarlo
        Dim resultsForm As New FormResultados(pedidos, totalVacunasRestantes)

        ' Mostrar los resultados
        resultsForm.ShowDialog()

    End Sub



    ' Botón para finalizar la jornada
    Private Sub BtnFinalizarJornada_Click(sender As Object, e As EventArgs) Handles BtnFinalizarJornada.Click

        ' Calcular el total de vacunas restantes después de realizar pedidos
        Dim totalVacunasRestantes As Integer = inventario.TotalVacunas

        ' Crear un formulario de resultados y mostrarlo
        Dim resultsForm As New FormResultados(pedidos, totalVacunasRestantes)

        ' Mostrar los resultados
        resultsForm.ShowDialog()

    End Sub

    ' Botón para salir de la aplicación
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        ' Cerrar la aplicación
        Application.Exit()

    End Sub

End Class