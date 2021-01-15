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

type Employee
    name as string
    addr as string
    salary as double
end type

sub test_UDT
    dim manager as Employee
    manager.name   = "ZL"
    manager.addr   = "123 main street"
    manager.salary = 40000

end sub