Imports System

' start đóng gói
Public Class Person ()
    Private name As String
    Private age As Integer

    Public Sub New(pName As String, pAge As Integer)
        Me.name = pName
        Me.age = pAge
    End Sub

    Public Function GetName() As String
        return name
    End Function

    Public Function SetName(pName As String)
        name = pName
    End Function

    Public Function GetAge() As Integer
        Return age
    End Function

    Public Function SetAge(pAge As Integer)
        If pAge >= 0 Then
            age = pAge
        Else
            Console.WriteLine("Tuổi phải lớn hơn hoặc bằng 0")
        End If
    End Function
End Class
' end đóng gối

' start kế thừa
Public Class Parent
    Public Sub Eat
        Console.WriteLine("Chán chằng muốn nói")
    End Sub
End Class

Public Class Child
    Inherits Parent ' dùng Inherits để kế thừa
    Public Sub Speak
        Console.WriteLine("Mày muốn gì")
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
Public Class calculator
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
        Console.WriteLine("Chó chau")
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
        Dim dog = New Dog()
        dog.Eat()  'Output: Chó ăn thịt
    End Sub
End Module
