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

' table: collection vs dict

' | ds         | pair     | subscript op              | update v        | delete                      | namespace  |
' |------------|----------|---------------------------|-----------------|-----------------------------|------------|
' | collection | v:k      | coll(i) or coll(key)      | n/a. bitwise OK | remove(v), RemoveAt(key)    | system     |
' | dictionary | k:v      | coll(key)                 | OK              | remove(k)                   | scrrun.dll |

' collection is a weird data structure... 

'''

Sub pprint(ByRef x)
    Debug.Print x
End Sub

Sub demo()

    ' create and initialize an array
    ' store homegeneous elements
    Dim dict As Object
    Set dict = CreateObject("scripting.dictionary")

    ' add item
    dict.add "hello", "world"
    dict.add 3, 4

    ' exists
    dict.exists (3)

    ' count
    Dim x
    x = dict.count


    ' delete
    dict.Remove 3

    ' clear
    ' dict.removeall
    ' set dict = nothing

    ' subscript operator
    Dim i
    For Each i In dict.keys
        pprint (i)
    Next i

    For Each i In dict.items
        pprint (i)
    Next i



End Sub
