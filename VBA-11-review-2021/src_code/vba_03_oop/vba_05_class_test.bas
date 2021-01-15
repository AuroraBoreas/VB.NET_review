'''
'
' vba review 2021 @ZL
'
' make vba great again
'
'
'
'
'''

Sub test2()
    Dim emp1 As New Employee
    emp1.init "ZL", "123 main street", 40000

    Dim emp2 As New Employee
    emp2.init "SYC", "321 sub street", 30000
    
    
    Dim emps As New Collection
    emps.Add emp1
    emps.Add emp2
    
    Dim item As Employee
    For Each item In emps
        item.repr
        Debug.Print
    Next item
    

End Sub