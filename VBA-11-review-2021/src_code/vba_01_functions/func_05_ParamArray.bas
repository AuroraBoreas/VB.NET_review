'''
' vba review 2021 @ZL
'
'
' work paramarray with function
'
'
'''

sub pprint(name as string, paramarray intScores() as variant)
    dim i as integer

    debug.print name; "score"
    for i = 0 to ubound(intScores)
        debug.print vbtab; intScores(i)
    next i
end sub

sub demo()

    pprint "Jamie", 10, 26, 32, 15, 22, 24, 16
    pprint "Kelly", "High", "Low", "Average", "High"


end sub