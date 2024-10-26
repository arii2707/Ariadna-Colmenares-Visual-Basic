
Public Class FormPrestar
    Public Shared libro As Libro = New Libro("Trono de Cristal", "Sarah J. Maas") ' Instancia única del libro

    Public Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        If txtTitulo.Text = libro.Titulo AndAlso txtAutor.Text = libro.Autor Then
            If libro.Prestar() Then
                txtResultado.Text = "Libro prestado con éxito."
            Else
                txtResultado.Text = "El libro no está disponible."
            End If
        Else
            txtResultado.Text = "Título o autor incorrectos."
        End If
    End Sub
End Class

