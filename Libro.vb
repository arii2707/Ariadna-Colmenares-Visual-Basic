Public Class Libro
    ' Atributos
    Public _titulo As String
    Public _autor As String
    Public _disponible As Boolean

    ' Constructor
    Public Sub New(titulo As String, autor As String)
        _titulo = titulo
        _autor = autor
        _disponible = True ' Por defecto, el libro está disponible
    End Sub

    ' Propiedades (Getters y Setters)
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property Autor As String
        Get
            Return _autor
        End Get
        Set(value As String)
            _autor = value
        End Set
    End Property

    Public Property Disponible As Boolean
        Get
            Return _disponible
        End Get
        Set(value As Boolean)
            _disponible = value
        End Set
    End Property

    ' Métodos para prestar y devolver el libro
    Public Function Prestar() As Boolean
        If _disponible Then
            _disponible = False
            Return True ' Prestado con éxito
        Else
            Return False ' No disponible para prestar
        End If
    End Function

    Public Function Devolver() As Boolean
        If Not _disponible Then
            _disponible = True
            Return True ' Devuelto con éxito
        Else
            Return False ' No se puede devolver porque ya está disponible
        End If
    End Function
End Class
