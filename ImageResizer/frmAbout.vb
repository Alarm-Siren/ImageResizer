Public NotInheritable Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Application.Info
            Me.Text = String.Format("About {0}", .Title)
            lblTitle.Text = .Title
            lblVersion.Text = String.Format("Version {0}.{1}.{2}", .Version.Major, .Version.Minor, .Version.Build)
            lblDescription.Text = .Description
            lblCopyright.Text = .Copyright & vbCrLf & "This application is licensed under the terms of the GNU Lesser General Public License; either version 2.1, or (at your option) any later version. Click the Read License button for full details."
        End With
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnReadme_Click(sender As Object, e As EventArgs) Handles btnReadme.Click
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & IO.Path.DirectorySeparatorChar & "README.txt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation And MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/Alarm-Siren/ImageResizer")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation And MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnUpdates_Click(sender As Object, e As EventArgs) Handles btnUpdates.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/Alarm-Siren/ImageResizer/releases")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation And MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnLicense_Click(sender As Object, e As EventArgs) Handles btnLicense.Click
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & IO.Path.DirectorySeparatorChar & "LICENSE.txt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation And MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class
