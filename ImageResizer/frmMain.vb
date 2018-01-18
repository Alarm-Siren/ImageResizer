Public Class frmMain

    Friend WithEvents Resizer As New clsResizeThread(Me)
    Private ResizerThread As Threading.Thread

    Private Sub cmdSetInputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetInputFolder.Click
        dlgFolder.Description = String.Format("{1}{0}{2}", Environment.NewLine, "Source Folder", "All recognised image files in the folder you select will be processed.")
        dlgFolder.ShowNewFolderButton = False
        If dlgFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtInputFolder.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmdSetOutputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetOutputFolder.Click
        dlgFolder.Description = String.Format("{1}{0}{2}", Environment.NewLine, "Destination Folder", "All processed files will be saved to the folder you select with the new size appended to the filename.")
        dlgFolder.ShowNewFolderButton = True
        If dlgFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtOutputFolder.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Function StringToFormat(ByRef format As String) As Imaging.ImageFormat
        Select Case format
            Case "BMP"
                Return Imaging.ImageFormat.Bmp
            Case "GIF"
                Return Imaging.ImageFormat.Gif
            Case "PNG"
                Return Imaging.ImageFormat.Png
            Case "JPEG"
                Return Imaging.ImageFormat.Jpeg
            Case "TIFF"
                Return Imaging.ImageFormat.Tiff
            Case Else
                Throw New ArgumentException("Invalid format string passed to StringToFormat", "format")
        End Select
    End Function

    Private Function StringToInterpolationMode(ByRef mode As String) As Drawing2D.InterpolationMode
        Select Case mode
            Case "Low"
                Return Drawing2D.InterpolationMode.Bicubic
            Case "Medium"
                Return Drawing2D.InterpolationMode.Bilinear
            Case "High"
                Return Drawing2D.InterpolationMode.HighQualityBicubic
            Case "Ultra"
                Return Drawing2D.InterpolationMode.HighQualityBilinear
            Case Else
                Throw New ArgumentException("Invalid interpolation mode string passed to StringToInterpolationMode", "format")
        End Select
    End Function

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        'lblInformation.Text = "Stopped by user; " & CStr(prgProgress.Value) & " files processed before cancellation."
        'StopProcess = True

        If IO.Directory.Exists(txtInputFolder.Text) = False Then
            Throw New IO.DirectoryNotFoundException(String.Format("Input folder '{0}' not found.", txtInputFolder.Text))
        End If
        If IO.Directory.Exists(txtOutputFolder.Text) = False Then
            Throw New IO.DirectoryNotFoundException(String.Format("Output folder '{0}' not found.", txtInputFolder.Text))
        End If

        Dim ThreadParams As New clsResizeThread.FolderInfo
        ThreadParams.source = New IO.DirectoryInfo(txtInputFolder.Text)
        ThreadParams.destination = New IO.DirectoryInfo(txtOutputFolder.Text)

        If Not IsNothing(ResizerThread) Then
            If ResizerThread.IsAlive Then
                Try
                    ResizerThread.Abort()
                    ResizerThread.Join()
                Catch ex As Exception
                    'Ignore exceptions; they're almost certainly
                    'telling us the thread is already aborted, because synchronisation issues, which is fine.
                End Try
            End If
        End If

        ResizerThread = New Threading.Thread(AddressOf Resizer.ProcessFolder)
        ResizerThread.IsBackground = True
        ResizerThread.Start(ThreadParams)

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        With My.Settings
            .DefaultOutputFormat = cmbOutputFormat.SelectedItem.ToString
            .DefaultOutputQuality = cmbQuality.SelectedItem.ToString
            .Save()
        End With
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title
        With My.Settings
            .Reload()
            cmbOutputFormat.SelectedItem = .DefaultOutputFormat
            cmbQuality.SelectedItem = .DefaultOutputQuality
        End With
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

    End Sub

    Private Sub chkUseInputFormat_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseInputFormat.CheckedChanged
        cmbOutputFormat.Enabled = Not chkUseInputFormat.Checked
    End Sub

    Private Sub ResizeThread_FileError(ByVal sender As System.Object, ByVal e As clsResizeThread.FileErrorEventArgs) Handles Resizer.FileError
        lblInformation.Text &= "Error"
    End Sub

    Private Sub ResizeThread_FileStart(ByVal sender As System.Object, ByVal e As clsResizeThread.FileStartEventArgs) Handles Resizer.FileStart
        lblInformation.Text &= "FileStart"
    End Sub

    Private Sub ResizeThread_FileDone(ByVal sender As System.Object, ByVal e As clsResizeThread.FileDoneEventArgs) Handles Resizer.FileDone
        lblInformation.Text &= "FileDone"
    End Sub

    Private Sub ResizeThread_ProcessingEnd(ByVal sender As System.Object, ByVal e As clsResizeThread.ProcessingEndEventArgs) Handles Resizer.ProcessingEnd
        lblInformation.Text &= "ProcessingEnd"
    End Sub

    Private Sub ResizeThread_ProcessingStart(ByVal sender As System.Object, ByVal e As clsResizeThread.ProcessingStartEventArgs) Handles Resizer.ProcessingStart
        lblInformation.Text &= "ProcessingStart"
    End Sub

End Class
