Imports System

Module Program
    Function add(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    Function add(ByVal a As String, ByVal b As String) As String
        Return String.Concat(a, " ", b).ToString()
    End Function

    Function CountFiles(minSize As Integer, maxSize As Integer) As Integer
        Debug.WriteLine($"you have requested the file size between {minSize} and {maxSize} bytes")
        Dim files() As String
        files = System.IO.Directory.GetFiles("C:\windows")
        Dim fi As System.IO.FileInfo
        Dim i, c As Integer
        For i = 0 To files.GetUpperBound(0)
            fi = New System.IO.FileInfo(files(i))
            If fi.Length >= minSize And fi.Length <= maxSize Then
                c = c + 1
            End If
        Next
        Return c
    End Function

    Function CountFiles(fromDate As Date, toDate As Date) As Integer
        '''<summary>simple function demonstrates how to count files</summary>
        '''<param>fromDate</param>
        '''<param>toDate</param>
        '''<remarks>nothing biggy</remarks>
        Debug.WriteLine($"you have requested files created from {fromDate} to {toDate}")
        Dim i, c As Integer
        Dim fi As System.IO.FileInfo
        Dim files() As String
        files = System.IO.Directory.GetFiles("C:\windows")
        For i = 0 To files.GetUpperBound(0)
            fi = New System.IO.FileInfo(files(i))
            If fi.CreationTime.Date >= fromDate And fi.CreationTime.Date <= toDate Then
                c += 1
            End If
        Next i
        Return c
    End Function

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
