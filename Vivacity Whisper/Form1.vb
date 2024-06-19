Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization ' Per il parsing JSON
Imports System.Windows.Forms ' Per MessageBox
Imports System.IO ' Per StreamReader
Imports System.Threading.Tasks
Public Class Form1

    Private Sub loadbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadbtn.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Audio Files|*.wav;*.m4a;*.mp3"
        openFileDialog.Title = "Select an audio file"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim filename = Path.GetFileName(filePath)
            filenamelabel.Text = filePath
        End If
    End Sub

    Private Sub transcrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transcrbtn.Click
        Dim apikey As String = apikeytxt.Text
        Dim audioFilePath As String = filenamelabel.Text
        Dim filename As String = Path.GetFileName(audioFilePath)
        Dim response As String
        System.Net.ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

        If Not String.IsNullOrEmpty(audioFilePath) Then
            Dim client As New WebClient()
            client.Headers.Add("Authorization", "Bearer " & apikey)

            Try
                ' Read the audio file content
                Dim fileBytes As Byte() = File.ReadAllBytes(audioFilePath)

                ' Convert the file content to Base64 string
                Dim fileBase64 As String = Convert.ToBase64String(fileBytes)

                ' Create the JSON request body with the model and file content
                Dim requestBody As String = "{""model"": ""whisper-1"", ""file"": """ & audioFilePath & """}"
                logtxt.Text = "Request grammar: " & requestBody.ToString & vbCrLf
                ' Set the content type for the request
                client.Headers.Add("Content-Type", "application/json")

                ' Send the POST request with the file content
                response = client.UploadString("https://api.openai.com/v1/audio/transcriptions", "POST", requestBody)

                resulttxt.Text = response.ToString
                MessageBox.Show("Transcription successful.")
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select an audio file before converting.")
        End If
    End Sub
End Class
