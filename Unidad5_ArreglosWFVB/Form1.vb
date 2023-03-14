Public Class Form1
    Dim arreglo(2, 2) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar el arreglo con algunos valores
        arreglo(0, 0) = 1
        arreglo(0, 1) = 2
        arreglo(0, 2) = 3
        arreglo(1, 0) = 4
        arreglo(1, 1) = 5
        arreglo(1, 2) = 6
        arreglo(2, 0) = 7
        arreglo(2, 1) = 8
        arreglo(2, 2) = 9

        ' Enlazar el arreglo con la cuadrícula de datos
        DataGridView1.DataSource = arreglo
    End Sub
    Private Sub btnSumarFilas_Click(sender As Object, e As EventArgs) Handles btnSumarFilas.Click
        ' Sumar los valores en cada fila del arreglo y mostrar el resultado en un mensaje
        Dim sumaFilas(2) As Integer
        For fila As Integer = 0 To 2
            For columna As Integer = 0 To 2
                sumaFilas(fila) += arreglo(fila, columna)
            Next
        Next
        MessageBox.Show("La suma de las filas es: " & String.Join(", ", sumaFilas))
    End Sub

    Private Sub btnSumarColumnas_Click(sender As Object, e As EventArgs) Handles btnSumarColumnas.Click
        ' Sumar los valores en cada columna del arreglo y mostrar el resultado en un mensaje
        Dim sumaColumnas(2) As Integer
        For columna As Integer = 0 To 2
            For fila As Integer = 0 To 2
                sumaColumnas(columna) += arreglo(fila, columna)
            Next
        Next
        MessageBox.Show("La suma de las columnas es: " & String.Join(", ", sumaColumnas))
    End Sub
End Class
