Imports System

' start đóng gói
Public Class Person
    Private _name As String
    Private _age As Integer

    Public Sub New(pName As String, pAge As Integer)
        Me._name = pName
        Me._age = pAge
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _age = value
            Else
                Console.WriteLine("Tuổi phải lớn hơn hoặc bằng 0")
            End If
        End Set
    End Property
End Class
' end đóng gối

' start kế thừa
Public Class Parent
    Public Sub Eat
        Console.WriteLine("muốn nói")
    End Sub
End Class

Public Class Child
    Inherits Parent ' dùng Inherits để kế thừa
    Public Sub Speak
        Console.WriteLine("gì")
    End Sub
End Class
' end kế thừa

' start đa hình
' ghi đè
Public Class Animal 
    Public Overridable Sub Eat
        Console.WriteLine("oam")
    End Sub
End Class

Public Class Dog
    Inherits Animal
    Public Overrides Sub Eat
        Console.WriteLine("Chó ăn thịt")
    End Sub
End Class

' nạp trồng
Public Class Calculator
    Public Function Add(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    Public Function Add(a As Double, b As Double) As Double
        Return a + b
    End Function

    Public Function Add(a As String, b As String) As String
        Return a + b
    End Function
End Class
'end đa hình

' start Trừu tượng
Public MustInherit Class AbstractAnimal
    Public MustOverride Sub Speak()
End Class

Public Class AbstractDog
    Inherits AbstractAnimal
    Public Overrides Sub Speak()
        Console.WriteLine("Cho nhau")
    End Sub
End Class
'end trừu tượng

' stat implements interface
' Định nghĩa một Interface
Public Interface IFlyable
    Sub Fly()
End Interface

' Lớp Duck triển khai IFlyable
Public Class Duck
    Implements IFlyable

    Public Sub Fly() Implements IFlyable.Fly
        Console.WriteLine("Duck is flying...")
    End Sub
End Class
'end implements

Module Program
    Sub Main(args As String())
        Dim person As New Person("Dung", 5)
        Console.WriteLine(person.Name)
        person.Age = -10
        Console.WriteLine(person.Age)

        Dim child As New Child()

        Dim dog = New Dog()
        dog.Eat()  'Output: Chó ăn thịt

        Dim calculator As New Calculator()
        Console.WriteLine(calculator.Add(3, 2))

        ' using date
        Dim date1 As DateTime = New DateTime(2025, 3, 1)
        Dim date2 As DateTime = New DateTime(2025, 3, 10)

        Dim daysDiff As Integer = (date2 - date1).Days
        Console.WriteLine("Số ngày chênh lệch: " & daysDiff)

    End Sub
End Module
