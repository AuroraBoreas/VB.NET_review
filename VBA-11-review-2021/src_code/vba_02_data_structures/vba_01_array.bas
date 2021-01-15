'''
' vba review 2021 @ZL
'
' data structures:
' + array
' + arraylist
' + collection(list)
' + dict
' + queue
' + stack

' table: array vs arraylist vs collection

' | data structures | capacity        | dimensions  | elements of type      | namespace     | Write Read               | sort          |
' |-----------------|-----------------|-------------|-----------------------|---------------|--------------------------|---------------|
' | array           | fixed or known  | multiple    | same(vba may differ)  | system        | W, R                     | no            |
' | arraylist       | dynamic         | only one    | different types       | collections   | W, R                     | yes           |
' | collection      | dynamic         | only one    | different types       | system        | element is read-only     | no            |
'''

Sub pprint(ByRef x)
    Debug.Print x
End Sub

Sub demo()

    ' create and initialize an array
    ' store homegeneous elements
    dim curExpense(365) as Currency
    ' or
    dim strWeekday(7 to 13) as string ' specify lbound, ubound

    ' using array as list to hold elemetns of different types
    dim varData(3) as variant
    varData(0) = "SYC"
    varData(1) = "4242 Maple Bldv"
    varData(2) = 38
    varData(3) = Format("06-09-2021", "General Date")
    ' or
    dim varDataa as variant
    varDataa = Array("SYC", "4242 Maple Bldv", 38, Format("06-09-2021", "General Date"))

    ' subscript operator
    dim index: index = 1
    pprint(varDataa(index))

    varDataa(index) = 10

    ' extend to index...
    redim preserve varDataa(10)

    ' ' sort
    ' Array.sort(varDataa)

    ' arrays are useful when u have a fixed size


End Sub