Public Class FormDevolver
    Public Shared libro As Libro = FormPrestar.libro
    Public Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        If txtTitulo.Text = libro.Titulo AndAlso txtAutor.Text = libro.Autor Then
            If libro.Devolver() Then
                txtResultado.Text = "Libro devuelto con éxito."
            Else
                txtResultado.Text = "El libro ya está disponible."
            End If
        Else
            txtResultado.Text = "Título o autor incorrectos."
        End If
    End Sub
End Class
