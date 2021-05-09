Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Simple APP07, v0.01 @ZL, 20210509"
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As String
        With Me
            .OpenFileDialog1.Filter = "PDF FILE | *.pdf"
            .OpenFileDialog1.Multiselect = True

            If .OpenFileDialog1.Multiselect = True Then
                If .OpenFileDialog1.ShowDialog = DialogResult.OK Then
                    For Each f In .OpenFileDialog1.FileNames
                        .ListBox1.Items.Add(f)
                    Next f
                End If
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            .OpenFileDialog1.Filter = "EXE FILES | *.exe"
            If .OpenFileDialog1.ShowDialog = DialogResult.OK Then
                'os.startfile() in Python
                MessageBox.Show(.OpenFileDialog1.FileName)
                Try
                    Process.Start(.OpenFileDialog1.FileName)
                Catch ex As Exception
                    MessageBox.Show(e.ToString())
                End Try
            End If
        End With
    End Sub
End Class
