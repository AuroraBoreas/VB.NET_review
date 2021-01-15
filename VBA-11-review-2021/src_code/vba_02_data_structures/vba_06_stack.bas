'''
' vba review 2021 @ZL
'
' data structures:
' + array
' + arraylist
' + collection(list)
' + stack
' + queue
' + stack

' table: collection vs stack

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
    Dim stack As Object
    Set stack = CreateObject("system.collections.stack")

    ' add item
    stack.push "hello"
    stack.push 3
    stack.push 2.718

    ' pop
    Dim top
    top = stack.pop() ' 2.718
    pprint (top)

    ' clear
    stack.clear
    Set stack = Nothing





End Sub

