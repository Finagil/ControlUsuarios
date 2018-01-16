Partial Class SeguridadDS
    Partial Public Class USUARIOSDataTable
        Private Sub USUARIOSDataTable_USUARIOSRowChanging(sender As Object, e As USUARIOSRowChangeEvent) Handles Me.USUARIOSRowChanging

        End Sub

        Private Sub USUARIOSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FechaCaducidadColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
