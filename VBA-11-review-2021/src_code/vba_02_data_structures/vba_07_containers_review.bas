Attribute VB_Name = "Module1"
Option Explicit

Public Sub demo()
    ' dict
    Dim dict As Object
    Set dict = CreateObject("Scripting.dictionary")
    
    dict.Add item:=1, Key:="hello"
    dict.Add item:=2, Key:="world"
    
    Dim item
    Debug.Print "===========dict behavior=============="
    For Each item In dict.items
        Debug.Print item
    Next item
    
    ' system.collections.queue
    Dim q As Object
    Set q = CreateObject("system.collections.queue")
    q.enqueue "Chinese"
    q.enqueue "English"
    q.enqueue "Japanese"
    q.enqueue "French"
    
    Dim b
    b = q.Count
    Debug.Print "===========queue behavior=============="
    While b > 0
        Debug.Print q.peek()
        q.dequeue
        b = b - 1
    Wend
    
    ' system.collections.stack
    Dim s As Object
    Set s = CreateObject("system.collections.stack")
    
    s.push "Chinese"
    s.push "English"
    s.push "Japanese"
    s.push "French"
    
    b = s.Count
    Debug.Print "===========stack behavior=============="
    While b > 0
        Debug.Print s.pop()
        b = b - 1
    Wend
    
    
    ' array
    Debug.Print "===========array behavior=============="
    Dim monthnames(11) As String  ' declaration method 01
    Dim i
    For i = 1 To 12
        monthnames(i - 1) = Strings.MonthName(i, False)
    Next i
    
    For Each item In monthnames
        Debug.Print item
    Next item
    
    Dim names() As Variant  ' declaration method 02
    ReDim Preserve names(6)
    names(0) = "ZL"
    names(1) = "SCY"
    names(2) = "LL"
    names(3) = "WLL"
    names(4) = "LM"
    names(5) = 42
    names(6) = 3.14
    For Each item In names
        Debug.Print item
    Next item
    
    ' declaration method 03
    Dim mywaifus As Variant  'OK. compiler figures it out, mywaifus is an array. it may puzzle u when u read source code.
    'Dim mywaifus as sting ' not OK. compiler complaints
    mywaifus = Array("SCY", "LL", "XHY", "LL", "WLL", "LM")
    For Each item In mywaifus
        Debug.Print item
    Next item
    
    ' variant data type
    Dim myVar As Variant
    myVar = True
    myVar = 1
    myVar = 3.14
    myVar = Empty
    
    ' but if u do it like this
    Dim x As Integer
    x = 2.7 ' pass. but x is 3, ouch
    Debug.Print "x = ", x
    
    ' arrayList
    Debug.Print "===========list behavior=============="
    Dim list As Object
    Set list = CreateObject("system.collections.arraylist")
    list.Add "morning"
    list.Add "noon"
    list.Add "afternoon"
    list.Add "evening"
    list.Add "night"
    list.Sort 'sort
    For Each item In list
        Debug.Print item
    Next item
    
    ' collection
    Debug.Print "===========tuple-like behavior=============="
    Dim col As New Collection
    col.Add "iPhone"
    col.Add "XiaoMi"
    col.Add "Ooo"
    Debug.Print col.Count
    
    
End Sub
