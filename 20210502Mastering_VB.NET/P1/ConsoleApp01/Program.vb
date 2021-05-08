Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine(DateDiff(DateInterval.Day, #3/9/2000#, #5/5/2021#))
        Console.WriteLine("press Enter to continue")
        Console.ReadKey()
    End Sub
End Module
