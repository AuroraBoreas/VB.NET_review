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
    
    ' abs
    dim a: a = abs(-10)
    pprint(a) ' 10

    'atn: Returns a Double specifying the arctangent of a number.
    dim arc
    arc = atn(3/4)
    pprint(arc)

    ' cos
    dim c
    c = cos(3/5)
    pprint(c)

    ' exp: Returns a Double specifying e (the base of natural logarithms) raised to a power.
    dim e
    e = exp(2)
    pprint(e)

    ' int
    i = int(-99.8)
    pprint(i)
    f = fix(-99.8)
    pprint(f)

    ' log: Returns a Double specifying the natural logarithm of a number.
    dim log10
    log10 = log(8) / log(10#)
    pprint(log10)

    ' rnd
    dim r
    r = rnd()
    pprint(r)

    ' sgn: Returns a Variant (Integer) indicating the sign of a number.
    dim s
    s = sgn(-12)
    pprint(s)

    ' sqr: Returns a Double specifying the square root of a number.
    dim sqrt
    sqrt = sqr(4)
    pprint(sqrt)


exitSub:
    Exit Sub
catchError:
    '// add error handling
    GoTo exitSub
End Sub
