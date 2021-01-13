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
    Dim q As Object
    Set q = CreateObject("system.collections.queue")

    ' add item
    q.enqueue "hello"
    q.enqueue "there"
    q.enqueue "S"
    q.enqueue "C"
    q.enqueue "Y"

    ' peakAtFirst
    Dim first
    first = q.peek()    ' hello
    pprint (first)
    
    ' membership
    Dim doesContain
    doesContain = q.contains("hh")  ' false
    pprint (doesContain)
    doesContain = q.contains("hello") ' true
    pprint (doesContain)

    ' deque
    first = q.dequeue() ' hello
    pprint (first)
    
    ' count
    Dim x
    x = q.count
    pprint (x)
    
    ' delete
    q.clear
    Set q = Nothing


End Sub
