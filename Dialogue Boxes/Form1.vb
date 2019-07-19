Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        fbd.ShowDialog()
        Label1.Text = fbd.SelectedPath
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        ofd.ShowDialog()
        If ofd.FileName = "" Then
            Exit Sub
        End If
        ' this part loads the file
        Dim Tmp As String
        Tmp = ""
        FileSystem.FileOpen(1, ofd.FileName, OpenMode.Input)
        Do While Not FileSystem.EOF(1)
            Tmp = Tmp & FileSystem.LineInput(1)
            If Not FileSystem.EOF(1) Then
                Tmp = Tmp & Chr(13) & Chr(10)
            End If
        Loop
        FileSystem.FileClose(1)
        TextBox2.Text = Tmp
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        TextBox1.Text = "This is a example of saving things in a text box"
        sfd.Title = "Save a File"
        sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        trm.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        sfd.ShowDialog()
        If sfd.FileName = "" Then
            Exit Sub
        End If
        FileSystem.FileOpen(1, sfd.FileName, OpenMode.Output)
        FileSystem.Print(1, TextBox1.Text)
        FileSystem.FileClose(1)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        fd.ShowDialog()
        trm.Enabled = True
    End Sub

    Private Sub trm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trm.Tick
        On Error Resume Next
        Button1.Font = fd.Font
        Button2.Font = fd.Font
        Button3.Font = fd.Font
        Button4.Font = fd.Font
        Button5.Font = fd.Font
        Label1.Font = fd.Font
        TextBox1.Font = fd.Font
        TextBox2.Font = fd.Font
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cd.ShowDialog()
        trm1.Enabled = True
    End Sub

    Private Sub trm1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trm1.Tick
        Button1.BackColor = cd.Color
        Button2.BackColor = cd.Color
        Button3.BackColor = cd.Color
        Button4.BackColor = cd.Color
        Button5.BackColor = cd.Color
        Label1.BackColor = cd.Color
        TextBox1.BackColor = cd.Color
        TextBox2.BackColor = cd.Color
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
