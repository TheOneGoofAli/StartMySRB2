Public Class MainThing
    Function CheckFileType(ext)
        Dim SRB2FileType As New List(Of String) From {".pk3", ".wad", ".soc", ".lua"}
        If SRB2FileType.Contains(ext) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function NotABaseFile(procfile)
        Dim SRB2BaseFiles As New List(Of String) From {"zones.pk3", "srb2.pk3"}
        If SRB2BaseFiles.Contains(procfile) Then
            Return False
        Else
            Return True
        End If
    End Function

    Function MoveListItem(listbox, direction)
        If listbox.items.count <= 1 Then
            Return False
        End If
        Dim newIndex As Integer = listbox.SelectedIndex + direction

        If newIndex < 0 Or newIndex >= listbox.Items.Count Then
            Return False
        End If

        Dim selected = listbox.SelectedItem
        listbox.Items.Remove(selected)
        listbox.Items.Insert(newIndex, selected)
        listbox.SetSelected(newIndex, True)
        Return True
    End Function

    Private Sub AddonListCheck()
        Console.WriteLine("amogus")
        Return
    End Sub
    Private Sub MainThing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddonList.AllowDrop = True
        AddonList.SelectedItem = 0
        If My.Settings.LastEXEUsed <> "" Then
            GameEXE.Text = My.Settings.LastEXEUsed
        End If
    End Sub

    Private Sub LoadAddons_CheckedChanged(sender As Object, e As EventArgs) Handles LoadAddons.CheckedChanged
        If LoadAddons.Checked = True Then
            AddonList.Enabled = True
            AddAddon.Enabled = True
            RemAddon.Enabled = True
        Else
            AddonList.Enabled = False
            AddAddon.Enabled = False
            RemAddon.Enabled = False
            MoveUpBtn.Enabled = False
            MoveDownBtn.Enabled = False
        End If
    End Sub

    Private Sub HostServer_CheckedChanged(sender As Object, e As EventArgs) Handles HostServer.CheckedChanged
        If HostServer.Checked = True Then
            Listen.Enabled = True
            Dedicated.Enabled = True
            SkipIntro.Enabled = False
        Else
            Listen.Enabled = False
            Dedicated.Enabled = False
            If WarpMap.Checked = False Then
                SkipIntro.Enabled = True
            End If
        End If
    End Sub

    Private Sub WarpMap_CheckedChanged(sender As Object, e As EventArgs) Handles WarpMap.CheckedChanged
        If WarpMap.Checked = True Then
            SkipIntro.Enabled = False
            MapID.Enabled = True
        Else
            If HostServer.Checked = False Then
                SkipIntro.Enabled = True
            End If
            MapID.Enabled = False
        End If
    End Sub

    Private Sub SelectEXE_Click(sender As Object, e As EventArgs) Handles SelectEXE.Click
        Dim result As DialogResult = EXEDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim exe = EXEDialog.FileName
            Try
                Dim Extension As String = My.Computer.FileSystem.GetFileInfo(exe).Extension
                If Extension = ".exe" Then
                    GameEXE.Text = exe
                Else
                    MessageBox.Show("That is not an executable.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occured when selecting the game executable.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub AddonList_DragDrop(sender As Object, e As DragEventArgs) Handles AddonList.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Extension As String = My.Computer.FileSystem.GetFileInfo(path).Extension
            Dim FileName As String = My.Computer.FileSystem.GetName(path)
            If CheckFileType(Extension) And NotABaseFile(FileName) Then
                AddonList.Items.Add(FileName)
            End If
        Next
        AddonList.SelectedIndex = 1
    End Sub

    Private Sub AddonList_DragEnter(sender As Object, e As DragEventArgs) Handles AddonList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub AddAddon_Click(sender As Object, e As EventArgs) Handles AddAddon.Click
        Dim result As DialogResult = SRB2Addons.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim files = SRB2Addons.FileNames
            For Each path In files
                Dim Extension As String = My.Computer.FileSystem.GetFileInfo(path).Extension
                Dim FileName As String = My.Computer.FileSystem.GetName(path)
                If CheckFileType(Extension) And NotABaseFile(FileName) Then
                    AddonList.Items.Add(FileName)
                End If
            Next
        End If
        AddonList.SelectedItem = 1
    End Sub

    Private Sub RemAddon_Click(sender As Object, e As EventArgs) Handles RemAddon.Click
        If My.Computer.Keyboard.ShiftKeyDown Then
            AddonList.Items.Clear()
        ElseIf AddonList.SelectedItem <> "" Then
            AddonList.Items.Remove(AddonList.SelectedItem)
        End If
    End Sub

    Private Sub MoveUpBtn_Click(sender As Object, e As EventArgs) Handles MoveUpBtn.Click
        If AddonList.SelectedItem <> "" Then
            MoveListItem(AddonList, -1)
        End If
    End Sub

    Private Sub MoveDownBtn_Click(sender As Object, e As EventArgs) Handles MoveDownBtn.Click
        If AddonList.SelectedItem <> "" Then
            MoveListItem(AddonList, 1)
        End If
    End Sub

    Private Sub AddonList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddonList.SelectedIndexChanged
        If AddonList.Items.Count <= 1 Then
            MoveUpBtn.Enabled = False
            MoveDownBtn.Enabled = False
        Else
            MoveUpBtn.Enabled = True
            MoveDownBtn.Enabled = True
        End If
    End Sub

    Private Sub PortChange_CheckedChanged(sender As Object, e As EventArgs) Handles PortChange.CheckedChanged
        If PortChange.Checked = True Then
            PortNumber.Enabled = True
        Else
            PortNumber.Enabled = False
        End If
    End Sub

    Private Sub ConnectIP_CheckedChanged(sender As Object, e As EventArgs) Handles ConnectIP.CheckedChanged
        If ConnectIP.Checked = True Then
            LoadAddons.Enabled = False
            HostServer.Enabled = False
            SkipIntro.Enabled = False
            WarpMap.Enabled = False
            LoadAddons.Checked = False
            HostServer.Checked = False
            WarpMap.Checked = False
            IPAddress.Enabled = True
            SkipIntro.Enabled = False
            SkipIntro.Checked = False
        Else
            LoadAddons.Enabled = True
            HostServer.Enabled = True
            WarpMap.Enabled = True
            IPAddress.Enabled = False
            SkipIntro.Enabled = True
        End If
    End Sub

    Function ValidToggle([module])
        If [module].Enabled And [module].Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub LaunchButton_Click(sender As Object, e As EventArgs) Handles LaunchButton.Click
        Dim ExecGame As String
        Dim CmdArgs As String
        Dim sb As New System.Text.StringBuilder()
        'Do we have a valid executable?
        If My.Computer.FileSystem.FileExists(GameEXE.Text) Then
            ExecGame = GameEXE.Text
        Else
            'We don't, huh?
            MsgBox("Game executable not defined.", vbOKOnly + vbExclamation, "Whoa there, buddy!")
            Return
        End If
        'Are we going for addons?
        If ValidToggle(LoadAddons) Then
            CmdArgs = sb.Append("-file ").ToString
            For Each addon As String In AddonList.Items
                CmdArgs = sb.Append(addon).Append(" ").ToString
            Next
        End If
        'Server?
        If ValidToggle(HostServer) Then
            'Type of server.
            If ValidToggle(Listen) Then
                CmdArgs = sb.Append("-server ").ToString
            ElseIf ValidToggle(Dedicated) Then
                CmdArgs = sb.Append("-dedicated ").ToString
            End If
            'We changing port?
            If ValidToggle(PortChange) And PortNumber.Text <> 5029 Then
                CmdArgs = sb.Append("-port ").Append(PortNumber.Text).Append(" ").ToString
            End If
        End If
        If ValidToggle(SkipIntro) Then
            CmdArgs = sb.Append("-skipintro ").ToString
        End If
        If ValidToggle(WarpMap) And MapID.Enabled And MapID.Text <> "" Then
            Dim WarpFlag As String = "-warp " + MapID.Text
            CmdArgs = sb.Append(WarpFlag).ToString
        End If
        If CmdArgs <> "" Then
            CmdArgs.TrimEnd()
        End If
        Try
            Dim filePath As String = My.Computer.FileSystem.GetFileInfo(ExecGame).FullName
            Dim GameStart As New ProcessStartInfo With {
                .FileName = filePath,
                .Arguments = CmdArgs,
                .WorkingDirectory = IO.Path.GetDirectoryName(filePath)
            }
            Process.Start(GameStart)
        Catch
            MsgBox("An error has occured.", vbCritical + vbOKOnly, "Whoops!")
        End Try
    End Sub

    Private Sub GameEXE_TextChanged(sender As Object, e As EventArgs) Handles GameEXE.TextChanged
        If GameEXE.Text <> "" Then
            My.Settings.LastEXEUsed = GameEXE.Text
        End If
    End Sub

    Private Sub GameEXE_DoubleClick(sender As Object, e As EventArgs) Handles GameEXE.DoubleClick
        If My.Computer.Keyboard.ShiftKeyDown Then
            GameEXE.Clear()
            My.Settings.LastEXEUsed = ""
        End If
    End Sub
End Class
