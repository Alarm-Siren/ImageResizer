Public Class frmMain

    Private Enum ImageType
        bmp
        gif
        jpg
        tiff
        png
    End Enum

    Private StopProcess As Boolean = False

    Private Function ResizeImage(ByRef originalImage As Bitmap, ByVal maxWidth As Integer, ByVal maxHeight As Integer, ByVal PreserveAspect As Boolean, ByRef NewWidth As Integer, ByRef NewHeight As Integer) As Bitmap

        If PreserveAspect = True Then
            Dim heightRatio As Double = CDbl(maxHeight) / CDbl(originalImage.Height)
            Dim widthRatio As Double = CDbl(maxWidth) / CDbl(originalImage.Width)
            Dim scaleFactor As Double

            If heightRatio < widthRatio Then
                scaleFactor = heightRatio
            Else
                scaleFactor = widthRatio
            End If

            NewHeight = CInt(Math.Round(CDbl(originalImage.Height) * scaleFactor))
            NewWidth = CInt(Math.Round(CDbl(originalImage.Width) * scaleFactor))

            If NewHeight = 0 Then NewHeight = 1
            If NewWidth = 0 Then NewWidth = 1

        Else
            NewWidth = maxWidth
            NewHeight = maxHeight
        End If

        Dim newImage As Bitmap = New Bitmap(originalImage, NewWidth, NewHeight)

        Dim g As Graphics = Graphics.FromImage(newImage)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height)
        g = Nothing

        Return newImage

    End Function

    Private Sub cmdSetInputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetInputFolder.Click
        dlgFolder.Description = "Source Folder" & vbCrLf & "All recognised image files in the folder you select will be processed."
        dlgFolder.ShowNewFolderButton = False
        If dlgFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtInputFolder.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmdSetOutputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetOutputFolder.Click
        dlgFolder.Description = "Destination Folder" & vbCrLf & "All processed files will be saved to the folder you select with the new size appended to the filename."
        dlgFolder.ShowNewFolderButton = True
        If dlgFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtOutputFolder.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        cmdStart.Enabled = True
        'cmdStart.Enabled = False
        cmdSetInputFolder.Enabled = False
        cmdSetOutputFolder.Enabled = False
        chkAspectRatio.Enabled = False
        chkSizeFilename.Enabled = False
        numHeight.Enabled = False
        numWidth.Enabled = False

        prgProgress.Style = ProgressBarStyle.Marquee
        lblInformation.Text = "Collecting file information..."

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        If IO.Directory.Exists(txtInputFolder.Text) = False Then
            lblInformation.Text = "Selected source folder '" & txtInputFolder.Text & "' does not exist."
            GoTo myError
        End If

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        If IO.Directory.Exists(txtOutputFolder.Text) = False Then
            lblInformation.Text = "Selected destination folder '" & txtOutputFolder.Text & "' does not exist."
            GoTo myError
        End If

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        Dim dirSrc As IO.DirectoryInfo = New IO.DirectoryInfo(txtInputFolder.Text)
        Dim dirDest As IO.DirectoryInfo = New IO.DirectoryInfo(txtOutputFolder.Text)

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        Dim Files1 As IO.FileInfo() = dirSrc.GetFiles("*.bmp", IO.SearchOption.TopDirectoryOnly)
        Dim Files2 As IO.FileInfo() = dirSrc.GetFiles("*.gif", IO.SearchOption.TopDirectoryOnly)
        Dim Files3 As IO.FileInfo() = dirSrc.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)
        Dim Files4 As IO.FileInfo() = dirSrc.GetFiles("*.jpeg", IO.SearchOption.TopDirectoryOnly)
        Dim Files5 As IO.FileInfo() = dirSrc.GetFiles("*.tif", IO.SearchOption.TopDirectoryOnly)
        Dim Files6 As IO.FileInfo() = dirSrc.GetFiles("*.png", IO.SearchOption.TopDirectoryOnly)

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        Dim Files As IO.FileInfo() = Files1 '.Union(Files2).ToArray
        'Files = Files.Union(Files3).ToArray
        'Files = Files.Union(Files4).ToArray
        'Files = Files.Union(Files5).ToArray
        'Files = Files.Union(Files6).ToArray

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        If Files.Length = 0 Then
            lblInformation.Text = "Selected source folder '" & txtInputFolder.Text & "' contains no recognised image files."
            GoTo myError
        End If

        prgProgress.Maximum = Files.Length
        prgProgress.Style = ProgressBarStyle.Continuous
        lblInformation.Text = "Found " & CStr(Files.Length) & " files to process."



        Application.DoEvents()
        If StopProcess = True Then GoTo myError

        For Each File As IO.FileInfo In Files

            Application.DoEvents()
            If StopProcess = True Then GoTo myError

            prgProgress.Value = prgProgress.Value + 1
            lblInformation.Text = "Processing file " & CStr(prgProgress.Value) & " of " & Files.Length

            Application.DoEvents()
            If StopProcess = True Then GoTo myError

            Dim img As Bitmap = CType(Bitmap.FromFile(File.FullName), Bitmap)

            Application.DoEvents()
            If StopProcess = True Then GoTo myError

            Dim newWidth As Integer
            Dim newHeight As Integer
            img = ResizeImage(img, CInt(numWidth.Value), CInt(numHeight.Value), chkAspectRatio.Checked, newWidth, newHeight)

            Application.DoEvents()
            If StopProcess = True Then GoTo myError

            Dim outputformat As System.Drawing.Imaging.ImageFormat
            'If chkForcePNG.Checked = True Then
            'If chkSizeFilename.Checked = True Then
            'img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & "_" & CStr(newWidth) & "x" & CStr(newHeight) & ".png", Imaging.ImageFormat.Png)
            'Else
            'img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & ".png", Imaging.ImageFormat.Png)
            'End If
            'Else
            Select Case File.Extension
                Case ".jpeg", ".jpg"
                    outputformat = Imaging.ImageFormat.Jpeg
                Case ".bmp"
                    outputformat = Imaging.ImageFormat.Bmp
                Case ".gif"
                    outputformat = Imaging.ImageFormat.Gif
                Case ".tiff", ".tif"
                    outputformat = Imaging.ImageFormat.Tiff
                Case Else
                    outputformat = Imaging.ImageFormat.Png
            End Select

            If chkSizeFilename.Checked = True Then
                img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & "_" & CStr(newWidth) & "x" & CStr(newHeight) & File.Extension, outputformat)
            Else
                img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & File.Extension, outputformat)
            End If
            'End If
            img = Nothing
        Next

        lblInformation.Text = CStr(Files.Length) & " files successfully processed."

        Application.DoEvents()
        If StopProcess = True Then GoTo myError

myError:
        cmdSetInputFolder.Enabled = True
        cmdSetOutputFolder.Enabled = True
        chkAspectRatio.Enabled = True
        chkSizeFilename.Enabled = True
        numHeight.Enabled = True
        numWidth.Enabled = True
        prgProgress.Style = ProgressBarStyle.Continuous
        prgProgress.Value = 0
        'cmdStart.Enabled = True
        cmdStart.Enabled = False
        StopProcess = False
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        lblInformation.Text = "Stopped by user; " & CStr(prgProgress.Value) & " files processed before cancellation."
        StopProcess = True
    End Sub


    Private Sub cmdUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        System.Diagnostics.Process.Start("https://github.com/Alarm-Siren/ImageResizer/releases")
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("https://github.com/Alarm-Siren/ImageResizer/issues")
    End Sub

End Class
