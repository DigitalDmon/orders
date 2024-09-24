' Clase que representa la información del inventario de vacunas
Public Class InfoInventario

    ' Propiedad para almacenar el total de vacunas disponibles
    Public Property TotalVacunas As Integer

    ' Método para actualizar el inventario reduciendo la cantidad de vacunas
    Public Sub ActualizarInventario(cantidad As Integer)
        TotalVacunas -= cantidad ' Restar la cantidad solicitada al total de vacunas
    End Sub

End Class
