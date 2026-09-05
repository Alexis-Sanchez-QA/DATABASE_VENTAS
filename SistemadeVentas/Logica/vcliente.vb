Public Class vcliente
    Dim idcliente As Integer
    Dim nombre, apellidos, direccion, telefono, rfc As String

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property grfc
        Get
            Return rfc
        End Get
        Set(ByVal value)
            rfc = value
        End Set
    End Property


    'CONSTRUCTORES


    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal rfc As String)
        gidcliente = idcliente
        gnombre = nombre
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        grfc = rfc
    End Sub
End Class
