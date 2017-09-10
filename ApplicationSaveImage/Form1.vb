Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg)|*.jpg|(*.jpeg)|*.JPEG|(*.gif)|*.gif|(*.png)|*.png|All Files (*.*)|*.*"
            fopen.ShowDialog()
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(fopen.FileName)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile(Application.StartupPath & "\NoImage\" & "noimage.gif")

    End Sub
End Class
