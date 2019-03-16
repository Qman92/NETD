Option Strict On
Public Class Car
    'Declare proporties
    Private Shared carCount As Integer
    Private carNew As Boolean
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer
    Private carPrice As Double
    'Default constructor
    Public Sub New()
        'Add 1 to carCount
        carCount += 1
        carIdentificationNumber = carCount
    End Sub

    'Constructor
    Public Sub New(isNew As Boolean, make As String, model As String, year As Integer, price As Double)
        Me.New()

        carNew = isNew
        carMake = make
        carModel = model
        carYear = year
        carPrice = price
    End Sub

    'Read only Count accessor
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    'Read only ID number accessor
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    'NewStatus accessor
    Public Property NewStatus() As Boolean
        Get
            Return carNew
        End Get
        Set(ByVal value As Boolean)
            carNew = value
        End Set
    End Property
    'Make accessor
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property
    'Model accessor
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property
    'Year accessor
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set
    End Property
    'Price accessor
    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set
    End Property
    'Car data function
    Public Function GetCarData() As String
        Return "Make: " & carMake & vbCrLf &
               "Model: " & carModel & vbCrLf &
               "Year: " & carYear & vbCrLf &
               "Price: " & carPrice & vbCrLf &
               "New: " & IIf(carNew, "New", "Not new").ToString()
    End Function
End Class
