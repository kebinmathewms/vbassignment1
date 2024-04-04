Imports System
Public Class Student

    Public Property Name As String
    Public Property Age As Integer
    Public Property Grade As Integer
    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal grade As Integer)
        Me.Name = name
        Me.Age = age
        Me.Grade = grade
    End Sub
    Public Function DisplayDetails() As String
        Return $"Name: {Name}, Age: {Age}, Grade: {Grade}"
    End Function
End Class

Module Module1
    Sub Main()
        Dim students As New List(Of Student)
        For i As Integer = 1 To 3
            Console.WriteLine($"Enter details for student {i}:")
            Console.Write("Name: ")
            Dim name As String = Console.ReadLine()

            Console.Write("Age: ")
            Dim age As Integer = Integer.Parse(Console.ReadLine())

            Console.Write("Grade: ")
            Dim grade As Integer = Integer.Parse(Console.ReadLine())
            students.Add(New Student(name, age, grade))
        Next

        ' Displaying student details
        Console.WriteLine("Student details:")
        For Each student As Student In students
            Console.WriteLine(student.DisplayDetails())
        Next

        Console.ReadLine()
    End Sub
End Module