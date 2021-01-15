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
    
    ' ascii: char <-> int
    Dim n
    n = asc("a")
    pprint(n)

    Dim c
    c = chr(64)
    pprint(c)

    ' format
    Dim f
    f = format(3144, "#,#0.00")
    pprint(f)

    ' int - hex - oct - binary
    dim h
    h = hex(15) ' 0xF
    h = hex(10) ' 0xA
    pprint(h)

    dim o
    o = oct(17) ' 0o0101
    pprint(o)

    dim s
    s = str(3.14)
    pprint(s)
    
    dim v
    ' The Val function stops reading the string at the first character that it can't recognize as part of a number
    v = Val("2.71828")
    ' However, the function recognizes the radix prefixes &O (for octal) and &H (for hexadecimal)
    v = Val("&FFF")
    pprint(v)

exitSub:
    Exit Sub
catchError:
    '// add error handling
    GoTo exitSub
End Sub
