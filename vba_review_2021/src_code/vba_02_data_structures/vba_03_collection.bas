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

' | data structures | capacity        | dimensions  | elements of type      | namespace     | Write Read               | sort          | index start at |
' |-----------------|-----------------|-------------|-----------------------|---------------|--------------------------|---------------|----------------|
' | array           | fixed or known  | multiple    | same(vba may differ)  | system        | W, R                     | no            |    0           |
' | arraylist       | dynamic         | only one    | different types       | collections   | W, R                     | yes           |    0           |
' | collection      | dynamic         | only one    | different types       | system        | element is read-only     | no            |    1           |

'''

Sub pprint(ByRef x)
    Debug.Print x
End Sub

Sub demo()

    ' create and initialize an array
    ' store homegeneous elements
    Dim coll As New collection

    ' add item
    coll.Add "apple"
    coll.Add "pearl"
    coll.Add "orange"
    coll.Add "watermelon"

    ' delete
    coll.Remove 1

    ' clear
    ' Set coll = New collection

    ' subscript operator
    Dim i
    For i = 1 To coll.Count
        'pprint (coll.Item(i))
        ' or
        pprint (coll(i))
    Next i
    ' or
    pprint (coll.Item(2))

    ' read-only?
    ' coll.Item(1) = 1 ' not OK. but bitwise write is OK
    

    ' add key, value
    Dim collMark As New collection
    collMark.Add 45, "bill"
    collMark.Add 60, "ZL"
    collMark.Add 70, "XY"
    ' or
    collMark.Add Item:=89, key:="betty"

    pprint (collMark("Betty"))





End Sub