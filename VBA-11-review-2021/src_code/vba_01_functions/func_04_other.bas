'''
'
' vba review 01 @ZL, 20210113
'
' link: https://docs.microsoft.com/en-us/office/vba/Language/Reference/functions-visual-basic-for-applications
'
' builtin functions(4 categories):
' + conversion functions
' + math functions
' + type conversion functions
' + other functions
'
'
'''
Sub pprint(ByRef x)
    Debug.Print x
End Sub

Sub demo_conversion_functions()
    '// add declarations
    On Error GoTo catchError

    ' array
    Dim A, B, i
    A = array(10, 20, 30)
    B = A(2)    ' 30
    ReDim Preserve A(4)
    A(4) = 40

    For i = LBound(A) To UBound(A)
        pprint ("A(" & i & ") = " & A(i)) & " " & TypeName(A(i))
    Next i
    
    ReDim Preserve A(10)    ' extend to index 10
    A(9) = 100
     For i = LBound(A) To UBound(A)
        pprint ("A(" & i & ") = " & A(i)) & vbTab & TypeName(A(i))
    Next i

    ' choose
    dim x
    x = choose(1, "speed low", "speed midian", "speed high")
    pprint(x)

    ' curdir
    x = curdir
    pprint(x)
    ' datetime: date, datevalue, datediff, year, month, day, cdate, weekday, weekdayname, workday,
    ' time: hour, minute, second

    x = monthname(1, false)
    pprint(x)

    x = weekdayname(2, false, 2)
    pprint(x)

    ' color: RGB, QBColor
    x = QBColor(3)
    pprint(x)

    ' string comp, conv, reverse,
    dim s
    s = "hello world!"
    x = strReverse(s)
    pprint(x)

    ' reflection: VarType, TypeName
    pprint(typename(x))
    pprint(Vartype(x))

exitSub:
    Exit Sub
catchError:
    '// add error handling
    GoTo exitSub
End Sub
