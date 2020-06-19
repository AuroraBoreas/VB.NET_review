'add reference: extensions->Microsoft.Office.Interop.Excel->version are depending on Office in pc
'import reference
Imports Microsoft.Office.Interop

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlApp As New Excel.Application
        Dim xlWB As Excel.Workbook
        Dim xlWS As Excel.Worksheet
        Dim xlRng As Excel.Range
        Dim xlRow As Integer

        Dim strFilePath As String

        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx"
            .ShowDialog()
            strFilePath = .FileName
        End With

        If FileExists(strFilePath) Then
            xlWB = xlApp.Workbooks.Open(strFilePath)
            xlWS = xlWB.Worksheets("Data")
            xlRng = xlWS.UsedRange

            For xlRow = 2 To xlRng.Rows.Count
                DataGridView_01.Rows.Add(xlRng.Cells(xlRow, 1).value,
                                         xlRng.Cells(xlRow, 2).value,
                                         xlRng.Cells(xlRow, 3).value,
                                         xlRng.Cells(xlRow, 4).value,
                                         xlRng.Cells(xlRow, 5).value,
                                         xlRng.Cells(xlRow, 6).value
                )

            Next

            xlWB.Close()
            xlApp.Quit()
            MessageBox.Show("Done")
        End If
    End Sub


    Private Function FileExists(p As String) As Boolean
        'check if a given path exists
        FileExists = False
        If Dir(p) <> vbNullString Then FileExists = True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim headers = (From header As DataGridViewColumn In DataGridView_01.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DataGridView_01.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("csv.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start("csv.txt")
    End Sub
End Class
