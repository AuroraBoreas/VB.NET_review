VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Account"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private m_number As Long
Private m_name As String
Private m_balance As Double


' constructor
Public Sub Init(ByVal n As Long, ByRef s As String, ByRef b As Double)
    m_number = n
    m_name = s
    m_balance = b
End Sub

' getter
Public Property Get number() As Long
    number = m_number
End Property

Public Property Get name() As String
    name = m_name
End Property

Public Property Get balance() As Double
    balance = m_balance
End Property

' setter
Public Property Let number(ByVal n As Long)
    m_number = n
End Property

Public Property Let name(ByVal s As String)
    m_name = s
End Property

Public Property Let balance(ByVal b As Double)
    m_balance = b
End Property

' repr
Public Sub display()
    Debug.Print "------Account Info------"
    Debug.Print "number : " & m_number
    Debug.Print "name     : " & m_name
    Debug.Print "balance  : " & m_balance
    Debug.Print vbNullString
    
End Sub


