Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar los ComboBox con las unidades de masa
        cmbUnidadOrigen.Items.AddRange(New String() {"Kilogramos", "Gramos", "Miligramos", "Metros", "Kilómetros", "Milímetros"})
        cmbUnidadDestino.Items.AddRange(New String() {"Kilogramos", "Gramos", "Miligramos", "Metros", "Kilómetros", "Milímetros"})
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim valor As Double

        ' Validar entrada
        If Not Double.TryParse(txtValor.Text, valor) Then
            MessageBox.Show("Ingrese un numero valido.")
            Return
        End If

        ' Verificar selección de unidades
        If cmbUnidadOrigen.SelectedItem Is Nothing OrElse cmbUnidadDestino.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione las unidades de origen y destino.")
            Return
        End If

        ' Realizar la conversión
        Dim resultado As Double = Convertir(valor, cmbUnidadOrigen.SelectedItem.ToString(), cmbUnidadDestino.SelectedItem.ToString())
        txtResultado.Text = $"Resultado: {resultado} {cmbUnidadDestino.SelectedItem.ToString()}"
    End Sub
    Private Function UnidadesCompatibles(unidadOrigen As String, unidadDestino As String) As Boolean
        ' Verificar si ambas unidades son de la misma categoría (masa o distancia)
        Dim masas As String() = {"Kilogramos", "Gramos", "Milimetros"}
        Dim distancias As String() = {"Metros", "Kilómetros", "Milímetros"}

        Return (masas.Contains(unidadOrigen) AndAlso masas.Contains(unidadDestino)) OrElse
               (distancias.Contains(unidadOrigen) AndAlso distancias.Contains(unidadDestino))
    End Function

    Private Function Convertir(valor As Double, unidadOrigen As String, unidadDestino As String) As Double
        ' Conversión de masa
        If unidadOrigen = "Kilogramos" Then
            If unidadDestino = "Gramos" Then Return valor * 1000
            If unidadDestino = "Milimetros" Then Return valor * 1000000
        ElseIf unidadOrigen = "Gramos" Then
            If unidadDestino = "Kilogramos" Then Return valor / 1000
            If unidadDestino = "Miligramos" Then Return valor * 1000
        ElseIf unidadOrigen = "Miligramos" Then
            If unidadDestino = "Kilogramos" Then Return valor / 1000000
            If unidadDestino = "Gramos" Then Return valor / 1000
        End If

        ' Conversión de distancia
        If unidadOrigen = "Metros" Then
            If unidadDestino = "Kilómetros" Then Return valor / 1000
            If unidadDestino = "Milímetros" Then Return valor * 1000
        ElseIf unidadOrigen = "Kilómetros" Then
            If unidadDestino = "Metros" Then Return valor * 1000
            If unidadDestino = "Milímetros" Then Return valor * 1000000
        ElseIf unidadOrigen = "Milímetros" Then
            If unidadDestino = "Metros" Then Return valor / 1000
            If unidadDestino = "Kilómetros" Then Return valor / 1000000
        End If

        ' Si las unidades son iguales, retornar el mismo valor
        Return valor
    End Function
End Class

