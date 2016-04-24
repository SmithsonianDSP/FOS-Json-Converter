Imports FOSJC.Json

Public Class Form1
    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles btnBrowseInput.Click
        If OpenFileDialog1.ShowDialog(Me) <> DialogResult.Cancel Then
            MetroTextBox1.Text = OpenFileDialog1.FileName

            MetroTextBox2.Text = MetroTextBox1.Text.Replace(".sav", ".csv").Replace(".bak", ".csv").Replace(".backup", ".csv")

            If MetroTextBox2.Text.EndsWith(".csv") = False Then
                MetroTextBox2.Text = MetroTextBox2.Text.Replace(".", "_") & ".csv"
            End If

        End If
    End Sub


    Private Sub btnBrowseOutput_Click() Handles btnBrowseOutput.Click
        Try
            SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(MetroTextBox2.Text)
            SaveFileDialog1.FileName = My.Computer.FileSystem.GetName(MetroTextBox2.Text)
        Catch
            'SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.
            SaveFileDialog1.FileName = My.Computer.FileSystem.GetName(MetroTextBox1.Text).Replace(".sav", ".csv").Replace(".bak", ".csv").Replace(".backup", ".csv")
        End Try

        If SaveFileDialog1.ShowDialog(Me) <> DialogResult.Cancel Then
            MetroTextBox2.Text = SaveFileDialog1.FileName
        End If
    End Sub



    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click


        Dim inputFilePath As String = MetroTextBox1.Text
        Dim TempFilePath As String = My.Computer.FileSystem.GetTempFileName
        My.Computer.FileSystem.CopyFile(inputFilePath, TempFilePath, True)
        Dim inputJsonPath As String = vbNullString

        If inputFilePath.EndsWith(".json") Then
            inputJsonPath = inputFilePath
        Else
            Dim VDecryptExePath As String = $"{My.Application.Info.DirectoryPath}\VaultDecrypt.exe"

            If Not My.Computer.FileSystem.FileExists(VDecryptExePath) Then Stop

            Dim pr As New Process()
            pr.StartInfo.FileName = VDecryptExePath
            pr.StartInfo.Arguments = <String>"<%= TempFilePath %>"</String>
            pr.StartInfo.CreateNoWindow = True
            pr.Start()

            If Not pr.HasExited Then
                pr.WaitForExit()
            End If

            inputJsonPath = TempFilePath.Replace(".tmp", ".json")


        End If

        Try
            Dim NewTest As New ProcessJson(inputJsonPath, MetroTextBox2.Text)
            lblFailed.Visible = False
            Process.Start(MetroTextBox2.Text)
        Catch
            lblFailed.Visible = True
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(TempFilePath)
            My.Computer.FileSystem.DeleteFile(TempFilePath.Replace(".tmp", ".json"))
        Catch
        End Try
    End Sub

    Private Sub btnConvert_MouseMove(sender As Object, e As MouseEventArgs) Handles btnConvert.MouseMove
        If FilePathsValidated = False Then
            If VerifyFilePaths() = False Then
                btnConvert.Enabled = False
            Else
                btnConvert.Enabled = True
            End If
        Else
            btnConvert.Enabled = True
        End If
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged, MetroTextBox2.TextChanged
        If VerifyFilePaths() Then
            btnConvert.Enabled = True
        Else
            btnConvert.Enabled = False
        End If

    End Sub

    Private FilePathsValidated As Boolean = False

    Private Function VerifyFilePaths() As Boolean
        FilePathsValidated = False
        If MetroTextBox1.Text.Trim.Length = 0 OrElse MetroTextBox2.Text.Trim.Length = 0 Then
            Return False
        ElseIf My.Computer.FileSystem.FileExists(MetroTextBox1.Text) = False Then
            Return False
        ElseIf My.Computer.FileSystem.GetName(MetroTextBox2.Text).Length = 0 OrElse (Not MetroTextBox2.Text.EndsWith(".csv")) Then
            Return False
        ElseIf My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.GetParentPath(MetroTextBox2.Text)) = False Then
            Return False
        End If
        FilePathsValidated = True
        Return True
    End Function



End Class
