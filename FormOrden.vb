Public Class FormOrden

    ' Variables privadas para almacenar el inventario y la lista de pedidos
    Private inventario As InfoInventario
    Private pedidos As List(Of InfoPedido)

    ' Constructor de la clase, se ejecuta al crear una nueva instancia del formulario
    Public Sub New(inventario As InfoInventario, pedidos As List(Of InfoPedido))

        ' Inicializar los componentes visuales del formulario
        InitializeComponent()
        Me.inventario = inventario ' Asignar el inventario pasado al formulario
        Me.pedidos = pedidos ' Asignar la lista de pedidos pasada al formulario

    End Sub

    ' Evento que se ejecuta cuando el formulario se carga
    Private Sub FormOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Agregar las opciones de institución al ComboBox
        CmbInstitucion.Items.AddRange({"Institución 1", "Institución 2", "Institución 3", "Institución 4"})

        ' Seleccionar la primera opción del ComboBox
        CmbInstitucion.SelectedIndex = 0

        ' Configurar los valores mínimos y máximos del control NumericUpDown
        NudCantidad.Minimum = 100 ' Establecer el valor mínimo a 100
        NudCantidad.Maximum = inventario.TotalVacunas ' Establecer el valor máximo según el total de vacunas en inventario
        NudCantidad.Value = 100 ' Valor inicial por defecto de 100

    End Sub

    ' Evento que se ejecuta al hacer clic en el botón "Realizar Pedido"
    Private Sub BtnRealizarPedido_Click(sender As Object, e As EventArgs) Handles BtnRealizarPedido.Click

        ' Obtener la cantidad de vacunas solicitadas del control NumericUpDown
        Dim cantidadSolicitada As Integer = CInt(NudCantidad.Value)

        ' Obtener la institución seleccionada del ComboBox
        Dim institucion As String = CmbInstitucion.SelectedItem.ToString()

        ' Crear un nuevo pedido con los datos proporcionados
        Dim pedido As New InfoPedido With {
        .Numero = pedidos.Count + 1,
        .Institucion = institucion,
        .Cantidad = cantidadSolicitada
        }

        ' Verificar si la cantidad solicitada está dentro del rango permitido
        If cantidadSolicitada >= 100 AndAlso cantidadSolicitada <= inventario.TotalVacunas Then
            inventario.ActualizarInventario(cantidadSolicitada) ' Actualizar el inventario
            pedido.Estado = "Entregado"
        Else
            pedido.Estado = "Rechazado"
        End If

        ' Agregar el pedido a la lista de pedidos
        pedidos.Add(pedido)

        ' Actualizar el valor del inventario
        LblVacunasRestantes.Text = "Vacunas restantes: " & inventario.TotalVacunas.ToString()

        ' Mostrar un mensaje indicando el estado del pedido al usuario
        MessageBox.Show($"Pedido {pedido.Estado}. Total de vacunas restantes: {inventario.TotalVacunas}.")

        ' Limpiar los campos para el siguiente pedido
        NudCantidad.Value = 100 ' O establece un valor predeterminado
        CmbInstitucion.SelectedIndex = 0 ' O selecciona la primera opción

    End Sub

    ' Evento que se ejecuta al hacer clic en el botón "Finalizar Jornada"
    Private Sub BtnFinalizarJornada_Click(sender As Object, e As EventArgs) Handles BtnFinalizarJornada.Click

        ' Crear un formulario de resultados y mostrarlo
        Dim formResultado As New FormResultados(pedidos, inventario.TotalVacunas.ToString())

        ' Mostrar el formulario de resultados
        formResultado.ShowDialog()

    End Sub


    ' Evento que se ejecuta al hacer clic en el botón "Salir"
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        ' Cerrar la aplicación por completo
        Application.Exit()

    End Sub

End Class
