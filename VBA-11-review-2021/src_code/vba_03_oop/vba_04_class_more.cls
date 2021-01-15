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

' data member
private m_name as string
private m_addr as string
private m_salary as double

' "constructor"
public sub Init(x as string, y as string, z as double)
    m_name = x
    m_addr = y
    m_salary = z
end sub

' getter

public property get name() as string
    name = m_name
end property

public property get addr() as string
    addr = m_addr
end property

public property get salary() as string
    salary = m_salary
end property

' setter

public property let name(byval s as string)
    m_name = s
end property

public property let addr(byval ad as string)
    m_addr = ad
end property

public property let salary(byval sa as string)
    if(sa > 0) then
        m_salary = sa
    else
        '... error code
    end if
end property

public sub repr()
    debug.print "name: " & m_name
    debug.print "addr: " & m_addr
    debug.print "salary: " & m_salary
end sub