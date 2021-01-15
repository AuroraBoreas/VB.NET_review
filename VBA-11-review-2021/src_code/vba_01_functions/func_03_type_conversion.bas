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

    dim x

    x = cbool(3.14) ' true
    pprint(x)

    x = cbyte(15.5678) ' 15
    pprint(x)

    x = ccur(9999.99) ' 9999.99
    pprint(x)

    x = cdate("2021-01-13") ' 2021/1/13
    pprint(x)

    x = cdbl(11)
    pprint(x)

    x = cdec(28)
    pprint(x)

    x = cint(3.14)
    pprint(x)

    x = clng(2.718281828)
    pprint(x)

    ' x = clnglng(123)
    ' pprint(x)

    ' x = clngptr(321)
    ' pprint(x)

    x = csng(-13)
    pprint(x)

    x = cstr(-2.1)
    pprint(x)

    x = cvar(4534 & 000)
    pprint(x) ' 4534000


exitSub:
    Exit Sub
catchError:
    '// add error handling
    GoTo exitSub
End Sub
