Public Class clsResizeThread

    Public Event ProcessingStart(ByVal sender As System.Object, ByVal e As ProcessingStartEventArgs)
    Public Event FileStart(ByVal sender As System.Object, ByVal e As FileStartEventArgs)
    Public Event FileDone(ByVal sender As System.Object, ByVal e As FileDoneEventArgs)
    Public Event FileError(ByVal sender As System.Object, ByVal e As FileErrorEventArgs)
    Public Event ProcessingEnd(ByVal sender As System.Object, ByVal e As ProcessingEndEventArgs)

    Public Structure ProcessingStartEventArgs
        Public FilesFound As UInteger
    End Structure

    Public Structure FileStartEventArgs
        Public Filename As String
    End Structure

    Public Structure FileDoneEventArgs
        Public Filename As String
    End Structure

    Public Structure FileErrorEventArgs
        Public Filename As String
        Public Message As String
    End Structure

    Public Structure ProcessingEndEventArgs
        Public FilesProcessed As UInteger
    End Structure

    Public Structure FolderInfo
        Public SourceFolder As IO.DirectoryInfo
        Public DestinationFolder As IO.DirectoryInfo
        Public 
    End Structure

    Public Sub New(ByVal HostForm As frmMain)
        Me.HostForm = HostForm
    End Sub

    Public Sub ProcessFolder(ByVal params As FolderInfo)

        SendEvent(EventOptions.ProcessingStart, New ProcessingStartEventArgs With {.FilesFound = 1})
        SendEvent(EventOptions.FileStart, New FileStartEventArgs With {.Filename = "test.jpg"})
        SendEvent(EventOptions.FileDone, New FileDoneEventArgs With {.Filename = "test.jpg"})
        SendEvent(EventOptions.ProcessingEnd, New ProcessingEndEventArgs With {.FilesProcessed = 1})

        'RaiseEvent ProcessingStart(Me, New ProcessingStartEventArgs With {.FilesFound = 1})
        'RaiseEvent FileStart(Me, New FileStartEventArgs With {.Filename = "test.jpg"})
        'RaiseEvent FileDone(Me, New FileDoneEventArgs With {.Filename = "test.jpg"})
        'RaiseEvent ProcessingEnd(Me, New ProcessingEndEventArgs With {.FilesProcessed = 1})

        '        cmdStart.Enabled = True
        '        'cmdStart.Enabled = False
        '        cmdSetInputFolder.Enabled = False
        '        cmdSetOutputFolder.Enabled = False
        '        chkAspectRatio.Enabled = False
        '        chkSizeFilename.Enabled = False
        '        numHeight.Enabled = False
        '        numWidth.Enabled = False

        '        prgProgress.Style = ProgressBarStyle.Marquee
        '        lblInformation.Text = "Collecting file information..."

        '        Application.DoEvents()
        '        If StopProcess = True Then GoTo myError

        '        If IO.Directory.Exists(txtInputFolder.Text) = False Then
        '            lblInformation.Text = "Selected source folder '" & txtInputFolder.Text & "' does not exist."
        '            GoTo myError
        '        End If

        '        If IO.Directory.Exists(txtOutputFolder.Text) = False Then
        '            lblInformation.Text = "Selected destination folder '" & txtOutputFolder.Text & "' does not exist."
        '            GoTo myError
        '        End If


        '        Dim dirSrc As IO.DirectoryInfo = New IO.DirectoryInfo(txtInputFolder.Text)
        '        Dim dirDest As IO.DirectoryInfo = New IO.DirectoryInfo(txtOutputFolder.Text)

        '        Dim Files1 As IO.FileInfo() = dirSrc.GetFiles("*.bmp", IO.SearchOption.TopDirectoryOnly)
        '        Dim Files2 As IO.FileInfo() = dirSrc.GetFiles("*.gif", IO.SearchOption.TopDirectoryOnly)
        '        Dim Files3 As IO.FileInfo() = dirSrc.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)
        '        Dim Files4 As IO.FileInfo() = dirSrc.GetFiles("*.jpeg", IO.SearchOption.TopDirectoryOnly)
        '        Dim Files5 As IO.FileInfo() = dirSrc.GetFiles("*.tif", IO.SearchOption.TopDirectoryOnly)
        '        Dim Files6 As IO.FileInfo() = dirSrc.GetFiles("*.png", IO.SearchOption.TopDirectoryOnly)


        '        Dim Files As IO.FileInfo() = Files1 '.Union(Files2).ToArray
        '        'Files = Files.Union(Files3).ToArray
        '        'Files = Files.Union(Files4).ToArray
        '        'Files = Files.Union(Files5).ToArray
        '        'Files = Files.Union(Files6).ToArray

        '        If Files.Length = 0 Then
        '            lblInformation.Text = "Selected source folder '" & txtInputFolder.Text & "' contains no recognised image files."
        '            GoTo myError
        '        End If

        '        prgProgress.Maximum = Files.Length
        '        prgProgress.Style = ProgressBarStyle.Continuous
        '        lblInformation.Text = "Found " & CStr(Files.Length) & " files to process."

        '        For Each File As IO.FileInfo In Files

        '            prgProgress.Value = prgProgress.Value + 1
        '            lblInformation.Text = "Processing file " & CStr(prgProgress.Value) & " of " & Files.Length

        '            Dim img As Bitmap = CType(Bitmap.FromFile(File.FullName), Bitmap)

        '            Dim newWidth As Integer
        '            Dim newHeight As Integer
        '            img = ResizeImage(img, CInt(numWidth.Value), CInt(numHeight.Value), chkAspectRatio.Checked, Drawing2D.InterpolationMode.HighQualityBicubic, newWidth, newHeight)

        '            Dim outputformat As System.Drawing.Imaging.ImageFormat
        '            'If chkForcePNG.Checked = True Then
        '            'If chkSizeFilename.Checked = True Then
        '            'img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & "_" & CStr(newWidth) & "x" & CStr(newHeight) & ".png", Imaging.ImageFormat.Png)
        '            'Else
        '            'img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & ".png", Imaging.ImageFormat.Png)
        '            'End If
        '            'Else
        '            Select Case File.Extension
        '                Case ".jpeg", ".jpg"
        '                    outputformat = Imaging.ImageFormat.Jpeg
        '                Case ".bmp"
        '                    outputformat = Imaging.ImageFormat.Bmp
        '                Case ".gif"
        '                    outputformat = Imaging.ImageFormat.Gif
        '                Case ".tiff", ".tif"
        '                    outputformat = Imaging.ImageFormat.Tiff
        '                Case Else
        '                    outputformat = Imaging.ImageFormat.Png
        '            End Select

        '            If chkSizeFilename.Checked = True Then
        '                img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & "_" & CStr(newWidth) & "x" & CStr(newHeight) & File.Extension, outputformat)
        '            Else
        '                img.Save(txtOutputFolder.Text & System.IO.Path.DirectorySeparatorChar & Microsoft.VisualBasic.Left(File.Name, File.Name.Length - File.Extension.Length) & File.Extension, outputformat)
        '            End If
        '            'End If
        '            img = Nothing
        '        Next

        '        lblInformation.Text = CStr(Files.Length) & " files successfully processed."

        'myError:
        '        cmdSetInputFolder.Enabled = True
        '        cmdSetOutputFolder.Enabled = True
        '        chkAspectRatio.Enabled = True
        '        chkSizeFilename.Enabled = True
        '        numHeight.Enabled = True
        '        numWidth.Enabled = True
        '        prgProgress.Style = ProgressBarStyle.Continuous
        '        prgProgress.Value = 0
        '        'cmdStart.Enabled = True
        '        cmdStart.Enabled = False
        '        StopProcess = False
    End Sub

    Public Function ResizeImage(ByRef originalImage As Bitmap, _
                                ByVal maxWidth As Integer, _
                                ByVal maxHeight As Integer, _
                                ByVal PreserveAspect As Boolean, _
                                ByVal InterpolationMode As Drawing2D.InterpolationMode,
                                ByRef NewWidth As Integer, _
                                ByRef NewHeight As Integer) _
                                As Bitmap

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
        g.InterpolationMode = InterpolationMode
        g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height)
        g.Dispose()
        g = Nothing

        Return newImage

    End Function

    Private HostForm As frmMain

    Private Enum EventOptions
        ProcessingStart
        FileStart
        FileDone
        FileError
        ProcessingEnd
    End Enum

    Private Delegate Sub RaiseProcessingStartEvent(ByVal e As ProcessingStartEventArgs)
    Private Delegate Sub RaiseFileStartEvent(ByVal e As FileStartEventArgs)
    Private Delegate Sub RaiseFileDoneEvent(ByVal e As FileDoneEventArgs)
    Private Delegate Sub RaiseFileErrorEvent(ByVal e As FileErrorEventArgs)
    Private Delegate Sub RaiseProcessingEndEvent(ByVal e As ProcessingEndEventArgs)

    Private Sub DoRaiseProcessingStartEvent(ByVal e As ProcessingStartEventArgs)
        RaiseEvent ProcessingStart(Me, e)
    End Sub

    Private Sub DoRaiseFileStartEvent(ByVal e As FileStartEventArgs)
        RaiseEvent FileStart(Me, e)
    End Sub

    Private Sub DoRaiseFileDoneEvent(ByVal e As FileDoneEventArgs)
        RaiseEvent FileDone(Me, e)
    End Sub

    Private Sub DoRaiseFileErrorEvent(ByVal e As FileErrorEventArgs)
        RaiseEvent FileError(Me, e)
    End Sub

    Private Sub DoRaiseProcessingEndEvent(ByVal e As ProcessingEndEventArgs)
        RaiseEvent ProcessingEnd(Me, e)
    End Sub

    Private Sub SendEvent(ByVal action As EventOptions, ByVal args As Object)
        Select Case action
            Case EventOptions.ProcessingStart
                Dim drpse As New RaiseProcessingStartEvent(AddressOf DoRaiseProcessingStartEvent)
                If HostForm.InvokeRequired Then
                    HostForm.Invoke(drpse, args)
                Else
                    DoRaiseProcessingStartEvent(args)
                End If
            Case EventOptions.FileStart
                Dim drpse As New RaiseFileStartEvent(AddressOf DoRaiseFileStartEvent)
                If HostForm.InvokeRequired Then
                    HostForm.Invoke(drpse, args)
                Else
                    DoRaiseFileStartEvent(args)
                End If
            Case EventOptions.FileDone
                Dim drpse As New RaiseFileDoneEvent(AddressOf DoRaiseFileDoneEvent)
                If HostForm.InvokeRequired Then
                    HostForm.Invoke(drpse, args)
                Else
                    DoRaiseFileDoneEvent(args)
                End If
            Case EventOptions.FileError
                Dim drpse As New RaiseFileErrorEvent(AddressOf DoRaiseFileErrorEvent)
                If HostForm.InvokeRequired Then
                    HostForm.Invoke(drpse, args)
                Else
                    DoRaiseFileErrorEvent(args)
                End If
            Case EventOptions.ProcessingEnd
                Dim drpse As New RaiseProcessingEndEvent(AddressOf DoRaiseProcessingEndEvent)
                If HostForm.InvokeRequired Then
                    HostForm.Invoke(drpse, args)
                Else
                    DoRaiseProcessingEndEvent(args)
                End If
            Case Else
                Throw New ArgumentException("Invalid event option", "action")
        End Select
    End Sub

End Class
