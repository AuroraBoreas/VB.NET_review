Imports System.Collections.Generic

Namespace VBMeta
    Public Module Meta
        Public Sub oTopic(ByVal s As String)
            Console.WriteLine($"{vbCrLf} === {s} === {vbCrLf}")
        End Sub

        Public Sub varDemo()
            ' pattern: TNV
            ' declare and define: early-binding, later-binding;
            ' cat: CSISL FD BBD
            ' type conversion: dynamic_cast, static_cast, reinterpret_cast, const_cast, C-style cast;
            ' storage: auto, register, static, const;
            ' customed-types: enum, struct, class
            ' pass By Ref, By Ptr, By Val
            ' key word: dim, as, const
            ' reflection
            ' constness of var

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

            Console.WriteLine("a = {0},type : {1}", a, VarType(a))
            Console.WriteLine("b = {0:F},type : {1}", b, VarType(b))
            Console.WriteLine("c = {0:G},type : {1}", c, VarType(c))
            Console.WriteLine("d = {0:N},type : {1}", d, VarType(d))
            Console.WriteLine("e = {0},type : {1}", e, VarType(e))
            Console.WriteLine("f = {0},type : {1}", f, VarType(f))
            Console.WriteLine("g = {0},type : {1}", g, VarType(g))
            Console.WriteLine("h = {0},type : {1}", h, VarType(h))
            Console.WriteLine("j = {0},type : {1}", j, VarType(j))
            Console.WriteLine("i = {0},type : {1}", i, VarType(i))
        End Sub

        Private Function fibonacci(ByVal n As Integer) As Integer
            If n < 2 Then
                Return 1
            Else
                Return fibonacci(n - 1) + fibonacci(n - 2)
            End If
        End Function

        Private Function factorial(ByVal n As Integer) As Integer
            If n < 2 Then
                Return 1
            Else
                Return n * factorial(n - 1)
            End If
        End Function

        Private Function _sum(ByVal n As Integer) As Double
            Return (n * (n + 1)) / 2
        End Function

        Public Delegate Function MyDg(ByVal n As Integer) As Integer
        Private d1 As MyDg = New MyDg(AddressOf factorial)

        Private Function paDemo(ByVal ParamArray args() As Integer) As Integer
            Dim rv As Integer = 0
            If args.Length <= 0 Then
                Return rv
            End If

            For i As Integer = 0 To UBound(args)
                rv += args(i)
            Next
            Return rv
        End Function

        Private Function addOne() As Object
            ' VB supports one-line statement
            Dim i As Integer = 0
            Dim d1 = Function() i + 1
            Return d1
        End Function

        Private Function multiplyTwo(ByVal x As Integer) As Integer
            x = x * 2
            Return x
        End Function

        Private Sub anotherMultiplyTwo(ByRef x As Integer)
            x = x * 2
        End Sub

        Private Function print(ByVal a As Integer, ByVal b As String,
                               ByVal Optional name As String = "TS",
                               ByVal Optional sex As String = "female") As String
            Return String.Format($"a = {a}, b = {b}, name={name}, sex={sex}")
        End Function

        Private Function plusOne(x As Integer) As Integer
            Return x + 1
        End Function

        Private Function plusOne(x As String) As String
            Return x + "1"
        End Function

        Private Sub testSub(Of T)(ByVal arg As T)
            Console.WriteLine("generic method: {0} type is {1}", arg, VarType(arg))
        End Sub

        Public Sub funcDemo()
            ' pattern: TNP
            ' cat: regular, anonymous, lambda, immediate, delegate(function pointer), decorator, generator, function template(generic), nested func, class in func, func in class
            ' return_type: regular types, tuple?, ptr, ref, val
            ' func_name: overwrite, overload
            ' declare and define: inline, #macro, property type
            ' args: paramarray, position args, keyword args, labels(parameter vs argument)<swift>
            ' keyword: function, sub, byval, byref, byptr
            ' privilage: private, public, shared(static in C++)
            ' constness of func
            ' scope: LEGB

            Console.WriteLine(String.Format("fibonacci(10) = {0}", fibonacci(10)))
            Console.WriteLine("factorial(10) = {0}", factorial(10))
            Console.WriteLine("delegate, d1(10) = {0}", factorial(10))
            Console.WriteLine("sum(10) = {0}", _sum(10))
            Console.WriteLine("sum(1, 4, 3, 12) = {0}", paDemo(1, 4, 3, 12))

            Dim g = Sub() Console.WriteLine("lambda!")
            g()

            Console.WriteLine(print(a:=42, b:="hello", name:="ZL", sex:="male"))

            Dim x As Integer = 42
            Console.WriteLine($"Before multiplyTwo({x}), x = {x}")
            multiplyTwo(x)
            Console.WriteLine($"After multiplyTwo({x}), x = {x}")
            anotherMultiplyTwo(x)
            Console.WriteLine($"After anotherMultiplyTwo({x}), x = {x}")

            testSub(Of String)("hello world")
            testSub(1)
            testSub(3.14)
            testSub(True)
            testSub(2.17D)
        End Sub

        Public Sub statementDemo()
            ' A R L A B A C O O
            Const a As Integer = 42
            Const b As Integer = 69

            Console.WriteLine($"a={a}, b={b}; a + b = {a + b};")
            Console.WriteLine($"a={a}, b={b}; a - b = {a - b};")
            Console.WriteLine($"a={a}, b={b}; a * b = {a * b};")
            Console.WriteLine($"a={a}, b={b}; a / b = {a / b};")
            Console.WriteLine($"a={a}, b={b}; a % b = {a Mod b};")

            Console.WriteLine($"a={a}, b={b}; a == b = { a = b };")
            Console.WriteLine($"a={a}, b={b}; a != b = { a <> b };")
            Console.WriteLine($"a={a}, b={b}; a > b = {a > b};")
            Console.WriteLine($"a={a}, b={b}; a >= b = {a >= b};")
            Console.WriteLine($"a={a}, b={b}; a < b = {a < b};")
            Console.WriteLine($"a={a}, b={b}; a <= b = {a <= b};")

            Console.WriteLine($"a={a}, b={b}; not a = { Not a };")
            Console.WriteLine($"a={a}, b={b}; a and b = {a And b};")
            Console.WriteLine($"a={a}, b={b}; a or b = {a Or b};")

            Console.WriteLine($"access operator: {ConsoleColor.Red}")

            Dim c As Integer
            c = a << 2
            Console.WriteLine($"a={a}, b={b}; a << 2 = { c };")
            c = a >> 2
            Console.WriteLine($"a={a}, b={b}; a >> 2 = { c };")
            c = a And b
            Console.WriteLine($"a={a}, b={b}; a & b = { c };")
            c = a Or b
            Console.WriteLine($"a={a}, b={b}; a | b = { c };")
            c = a Xor b
            Console.WriteLine($"a={a}, b={b}; a ^ b = { c };")

            Console.WriteLine(a.ToString())
            Console.WriteLine(CType(b, Double))
        End Sub

        Private Function isEven(ByVal n As Integer) As Boolean
            Return n Mod 2 = 0
        End Function

        Private Function isLeapYear(n As Integer) As Boolean
            Return (n Mod 4 = 0 And n Mod 100 <> 0) Or (n Mod 400 = 0)
        End Function

        Private Function isDate(y As Integer, m As Integer, d As Integer) As Boolean
            If (y < 1) Then Return False
            If (m < 1 Or m > 12) Then Return False
            If (d < 0 Or d > 31) Then Return False

            Select Case (m)
                Case 2
                    If isLeapYear(y) Then
                        If (d > 29) Then Return False
                    Else
                        If (d > 28) Then Return False
                    End If
                Case 4, 6, 9, 11
                    If (d > 30) Then Return False
            End Select

            Return True
        End Function
        Public Sub controlflowDemo()
            ' if...else if...else
            ' switch...case...default
            ' try...catch...finally
            Dim numbers() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}
            For Each number As Integer In numbers.Reverse
                If isEven(number) Then
                    Console.Write($"{number} ")
                End If
            Next

            Console.WriteLine($"{vbCrLf}isDate(2021, 2, 31): {isDate(2021, 2, 31)}")

            Const x As Integer = 42, y As Integer = 0
            Dim rv As Double
            Try
                rv = x / y
                Console.WriteLine(rv)
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try

        End Sub

        Public Sub loopDemo()
            ' for
            ' while
            ' do...while
            Dim numbers() As Integer = {1, 2, 3, 4, 5}
            Console.WriteLine("for each")
            For Each number As Integer In numbers
                Console.Write($"{number} ")
            Next

            Dim i As Integer

            Console.WriteLine($"{vbCrLf}for ...")
            For i = 0 To (numbers.Length - 1)
                Console.Write($"{ numbers(i) } ")
            Next

            Console.WriteLine($"{vbCrLf}while...")
            i = 4
            While (i >= 0)
                Console.Write($"{numbers(i)} ")
                i -= 1
            End While

            Console.WriteLine($"{vbCrLf}do...loop until")
            i = 0
            Do
                Console.Write($"{numbers(i)} ")
                i += 1
            Loop Until (i >= numbers.Length)

            Console.WriteLine($"{vbCrLf}do..loop while")
            i = 4
            Do
                Console.Write($"{numbers(i)} ")
                i -= 1
            Loop While (i >= 0)

        End Sub

        Public Class Person
            ReadOnly _name As String
            ReadOnly _sex As String
            Private _age As Integer = 18

            Public Sub New(name As String, sex As String)
                Me._name = name
                Me._sex = sex
            End Sub

            Public ReadOnly Property Name() As String
                Get
                    Return Me._name
                End Get
                'Set(value As String)
                '    Me._name = value
                'End Set
            End Property

            Public Property Age() As Integer
                Get
                    Return Me._age
                End Get
                Set(value As Integer)
                    Me._age = value
                End Set
            End Property

            Public Overrides Function ToString() As String
                Return $"name: {Me._name}, sex: {Me._sex}"
            End Function
        End Class

        Public Class PersonEx
            Inherits Person
            Public Sub New(name As String, sex As String)
                MyBase.New(name, sex)
            End Sub

            Public Function IsEquals(rhs As Person) As Boolean
                Return Me.ToString().Equals(rhs.ToString())
            End Function
        End Class

        Public Sub classDemo()
            ' pattern: sim
            ' principle: SRP, OCP, LSP, ISP, DIP
            ' structure: default ctor, copy ctor, copy assignment operator, default dtor
            ' feature: class template, interface
            ' pillars: Abstract, Encapsulation, Inheretance, Polymorphism;
            ' storage: static, auto, register, const
            ' privilage: private, public, intern, extern, friend, explicit, implicit, override, sealed
            ' MRO: diamond, TopDown, LeftRight
            Dim p1 As Person = New PersonEx("ZL", "Male")
            Dim p2 As Person = New PersonEx("SCY", "Female")
            Console.WriteLine(p1.ToString())
            Console.WriteLine(p2.ToString() + ", " + p2.Age.ToString())
            Console.WriteLine(p1.Equals(p2))
        End Sub

        Public Sub containerDemo()
            ' (seq)bi-direction containers: Array, Vector, List, Dequeue
            ' (adapter)mono-direction containers: queue, stack, priority_queue
            ' (associative)associative containers: map, multimap, set, multiset
            Dim wives As New List(Of Person) From {
                New PersonEx("WLL", "Female"),
                New Person("SCY", "Female"),
                New PersonEx("TS", "Female"),
                New PersonEx("TXY", "Female")
            }

            Dim p1 As Person = New PersonEx("ZL", "Male")

            For Each p As Person In wives
                Console.WriteLine($"{p.ToString}, {p.GetType()}")
                If p.GetType() = GetType(PersonEx) Then
                    Console.WriteLine($"wife: {p.Name} matches {p1.Name}? {p.Equals(p1)}")
                End If
            Next

            Dim citis As New Dictionary(Of String, Integer) From {
                {"Shang Hai", 1},
                {"New York", 2},
                {"Tokyo", 3},
                {"Toronto", 4}
            }
            For Each item In citis
                Console.WriteLine($"{item.Key} : {item.Value}")
            Next
        End Sub

        Public Sub algorithmDemo()
            ' algo_permutation_heap
            ' algo_permutation_sort
            ' algo_structure_changer
            ' algo_mover
            ' algo_value_modifier
            ' algo_set
            ' algo_query_property
            ' algo_query_value
            ' algo_raw_memory
            ' algo_secret_rune
            ' algo_lone_island
            ' Iterator; const iterator
            ' Capacity
            ' Access
            ' Modifier
            ' List observer
            ' Bucket
            ' Hash Policy
            Dim A As New HashSet(Of Integer) From {
                1, 2, 3, 4, 5, 5
            }
            Dim B As New HashSet(Of Integer) From {
                4, 5, 6, 7, 8, 8
            }

            ' umids
            Console.Write("std::set_union, S-> ")
            For Each item As Integer In A.Union(B)
                Console.Write($"{item}, ")
            Next

            'Linq
            Console.Write($"{vbCrLf}Linq, S-> ")
            Dim numbers As New List(Of Integer)
            For i As Integer = 0 To 10
                numbers.Add(i)
            Next

            Dim rv As IEnumerable(Of Integer) = From number In numbers Where number Mod 2 = 0 Select number
            For Each i As Integer In rv
                Console.Write($"{i}, ")
            Next
            Console.WriteLine()
        End Sub
    End Module
End Namespace