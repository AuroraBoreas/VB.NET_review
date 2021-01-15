Attribute VB_Name = "Module2"
Option Explicit

Type meme
    x As Integer
    y As Integer
End Type


Sub test_cls_account()
    ' array doesnt work..
    ' no. it works when using set keyword
    Dim arrAcc1(2) As Account
    
    ' tuple-like container works
    Dim arrAcc2 As New Collection
    Dim acc1 As New Account
    acc1.Init 12345, "ZL", 999.99
    arrAcc2.Add acc1
   Set arrAcc1(0) = acc1

    Dim acc2 As New Account
    acc2.Init 54321, "SCY", 9.99
    arrAcc2.Add acc2
    Set arrAcc1(1) = acc2

    Dim acc3 As New Account
    acc3.Init 11111, "LL", 11119.99
    arrAcc2.Add acc3
    Set arrAcc1(2) = acc3
    
    Dim item
    For Each item In arrAcc1
        item.display
    Next item
    
    For Each item In arrAcc2
        item.display
    Next item
    
    ' user defined types
    Dim a As meme
    a.x = 2.718
    a.y = 3.141
    Debug.Print a.x, a.y
    
End Sub
