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
    dim arrList as object
    set arrList = CreateObject("System.Collections.ArrayList")
    
    arrList.add "hello"
    arrList.add "You"
    arrList.add "there"
    arrList.add "man"
    arrList.add "dude"
    arrList.add "efma"

    ' remove element
    arrList.remove "You"
    ' or
    dim index as integer
    index = 1
    arrList.removeat(index)

    ' subscript op
    arrList(1)
    ' or
    arrList.item(1)

    ' sort
    arrList.sort

    ' clear
    arrList.clear



End Sub