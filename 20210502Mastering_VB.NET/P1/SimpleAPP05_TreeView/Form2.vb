Public Class Form2
    Dim i As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Label1.Text = "FORM2"
            .Button1.Text = "Add node"
            .Text = "TreeView"
        End With
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = (i + 1) Mod 4
        Dim str As String
        str = InputBox("Enter your node: ")
        With Me
            If .TreeView1.SelectedNode Is Nothing Then
                .TreeView1.Nodes.Add(str, str, i, i)
            Else
                .TreeView1.SelectedNode.Nodes.Add(str, str, i, i)
            End If
        End With
    End Sub
End Class