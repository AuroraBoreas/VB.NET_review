Imports System.IO

Namespace VBMeta
    Public Module Meta
        Sub oTopic(ByVal s As String)
            Console.WriteLine($"{vbCrLf} === {s} === {vbCrLf}")
        End Sub

        Sub varDemo()
            ' pattern: TNV
            ' declare and define: early-binding, later-binding;
            ' cat: CSISL FD BBD
            ' type conversion: dynamic_cast, static_cast, reinterpret_cast, const_cast, C-style cast;
            ' storage: auto, register, static, const;
            ' customed-types: enum, struct, class
            ' pass By Ref, By Ptr, By Val
            ' key word: dim, as, const
            ' reflection

            Dim a As Char = "a"c
            Dim b As Short = 69
            Dim c As Integer = 42
            Dim d As Long = 1234567890

            Dim e As Single = 255
            Dim f As Double = 2.718281828R
            Dim g As ULong = 1231241241231231

            Dim h As Boolean = True
            Static i As Byte = 128
            Const j As Decimal = 3.1415925D

            Console.WriteLine("a = {0}, type : {1}", a, VarType(a))
            Console.WriteLine("b = {0:F}, type : {1}", b, VarType(b))
            Console.WriteLine("c = {0:G}, type : {1}", c, VarType(c))
            Console.WriteLine("d = {0:N}, type : {1}", d, VarType(d))
            Console.WriteLine("e = {0}, type : {1}", e, VarType(e))
            Console.WriteLine("f = {0}, type : {1}", f, VarType(f))
            Console.WriteLine("g = {0}, type : {1}", g, VarType(g))
            Console.WriteLine("h = {0}, type : {1}", h, VarType(h))
            Console.WriteLine("j = {0}, type : {1}", j, VarType(j))
            Console.WriteLine("i = {0}, type : {1}", i, VarType(i))
        End Sub

        Public Sub funcDemo()
            ' pattern: TNP
            ' 
        End Sub
    End Module
End Namespace