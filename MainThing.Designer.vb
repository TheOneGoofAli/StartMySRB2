<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainThing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainThing))
        Me.AddonList = New System.Windows.Forms.ListBox()
        Me.GameEXE = New System.Windows.Forms.TextBox()
        Me.SelectEXE = New System.Windows.Forms.Button()
        Me.LaunchButton = New System.Windows.Forms.Button()
        Me.RemAddon = New System.Windows.Forms.Button()
        Me.AddAddon = New System.Windows.Forms.Button()
        Me.LoadAddons = New System.Windows.Forms.CheckBox()
        Me.HostServer = New System.Windows.Forms.CheckBox()
        Me.Listen = New System.Windows.Forms.RadioButton()
        Me.Dedicated = New System.Windows.Forms.RadioButton()
        Me.SkipIntro = New System.Windows.Forms.CheckBox()
        Me.WarpMap = New System.Windows.Forms.CheckBox()
        Me.MapID = New System.Windows.Forms.TextBox()
        Me.EXEDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SRB2Addons = New System.Windows.Forms.OpenFileDialog()
        Me.MoveUpBtn = New System.Windows.Forms.Button()
        Me.MoveDownBtn = New System.Windows.Forms.Button()
        Me.AddonListListen = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuThing = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InfoTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PortChange = New System.Windows.Forms.CheckBox()
        Me.PortNumber = New System.Windows.Forms.TextBox()
        Me.ConnectIP = New System.Windows.Forms.CheckBox()
        Me.IPAddress = New System.Windows.Forms.TextBox()
        Me.OtherTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'AddonList
        '
        Me.AddonList.AllowDrop = True
        Me.AddonList.FormattingEnabled = True
        Me.AddonList.Location = New System.Drawing.Point(12, 38)
        Me.AddonList.Name = "AddonList"
        Me.AddonList.Size = New System.Drawing.Size(160, 238)
        Me.AddonList.TabIndex = 0
        '
        'GameEXE
        '
        Me.GameEXE.Location = New System.Drawing.Point(12, 12)
        Me.GameEXE.Name = "GameEXE"
        Me.GameEXE.ReadOnly = True
        Me.GameEXE.Size = New System.Drawing.Size(160, 20)
        Me.GameEXE.TabIndex = 1
        Me.OtherTip.SetToolTip(Me.GameEXE, "The path in this text box is saved automatically upon selection. If you wish to c" &
        "lear this out, double-click while holding the SHIFT key.")
        '
        'SelectEXE
        '
        Me.SelectEXE.Location = New System.Drawing.Point(177, 11)
        Me.SelectEXE.Name = "SelectEXE"
        Me.SelectEXE.Size = New System.Drawing.Size(115, 22)
        Me.SelectEXE.TabIndex = 2
        Me.SelectEXE.Text = "Choose..."
        Me.OtherTip.SetToolTip(Me.SelectEXE, resources.GetString("SelectEXE.ToolTip"))
        Me.SelectEXE.UseVisualStyleBackColor = True
        '
        'LaunchButton
        '
        Me.LaunchButton.Location = New System.Drawing.Point(177, 282)
        Me.LaunchButton.Name = "LaunchButton"
        Me.LaunchButton.Size = New System.Drawing.Size(115, 48)
        Me.LaunchButton.TabIndex = 3
        Me.LaunchButton.Text = "Launch"
        Me.LaunchButton.UseVisualStyleBackColor = True
        '
        'RemAddon
        '
        Me.RemAddon.Enabled = False
        Me.RemAddon.Location = New System.Drawing.Point(95, 282)
        Me.RemAddon.Name = "RemAddon"
        Me.RemAddon.Size = New System.Drawing.Size(77, 23)
        Me.RemAddon.TabIndex = 4
        Me.RemAddon.Text = "Remove"
        Me.InfoTip.SetToolTip(Me.RemAddon, "Hold SHIFT to clear the list.")
        Me.RemAddon.UseVisualStyleBackColor = True
        '
        'AddAddon
        '
        Me.AddAddon.Enabled = False
        Me.AddAddon.Location = New System.Drawing.Point(12, 282)
        Me.AddAddon.Name = "AddAddon"
        Me.AddAddon.Size = New System.Drawing.Size(77, 23)
        Me.AddAddon.TabIndex = 5
        Me.AddAddon.Text = "Add"
        Me.AddAddon.UseVisualStyleBackColor = True
        '
        'LoadAddons
        '
        Me.LoadAddons.AutoSize = True
        Me.LoadAddons.Location = New System.Drawing.Point(178, 37)
        Me.LoadAddons.Name = "LoadAddons"
        Me.LoadAddons.Size = New System.Drawing.Size(83, 17)
        Me.LoadAddons.TabIndex = 6
        Me.LoadAddons.Text = "Use addons"
        Me.OtherTip.SetToolTip(Me.LoadAddons, "Load addons in the order of their position in list.")
        Me.LoadAddons.UseVisualStyleBackColor = True
        '
        'HostServer
        '
        Me.HostServer.AutoSize = True
        Me.HostServer.Location = New System.Drawing.Point(178, 60)
        Me.HostServer.Name = "HostServer"
        Me.HostServer.Size = New System.Drawing.Size(57, 17)
        Me.HostServer.TabIndex = 7
        Me.HostServer.Text = "Server"
        Me.OtherTip.SetToolTip(Me.HostServer, "Automatically host a netgame/multiplayer server.")
        Me.HostServer.UseVisualStyleBackColor = True
        '
        'Listen
        '
        Me.Listen.AutoSize = True
        Me.Listen.Checked = True
        Me.Listen.Enabled = False
        Me.Listen.Location = New System.Drawing.Point(193, 78)
        Me.Listen.Name = "Listen"
        Me.Listen.Size = New System.Drawing.Size(85, 17)
        Me.Listen.TabIndex = 8
        Me.Listen.TabStop = True
        Me.Listen.Text = "Listen server"
        Me.Listen.UseVisualStyleBackColor = True
        '
        'Dedicated
        '
        Me.Dedicated.AutoSize = True
        Me.Dedicated.Enabled = False
        Me.Dedicated.Location = New System.Drawing.Point(193, 96)
        Me.Dedicated.Name = "Dedicated"
        Me.Dedicated.Size = New System.Drawing.Size(74, 17)
        Me.Dedicated.TabIndex = 9
        Me.Dedicated.Text = "Dedicated"
        Me.Dedicated.UseVisualStyleBackColor = True
        '
        'SkipIntro
        '
        Me.SkipIntro.AutoSize = True
        Me.SkipIntro.Location = New System.Drawing.Point(178, 142)
        Me.SkipIntro.Name = "SkipIntro"
        Me.SkipIntro.Size = New System.Drawing.Size(71, 17)
        Me.SkipIntro.TabIndex = 10
        Me.SkipIntro.Text = "Skip Intro"
        Me.SkipIntro.UseVisualStyleBackColor = True
        '
        'WarpMap
        '
        Me.WarpMap.AutoSize = True
        Me.WarpMap.Location = New System.Drawing.Point(178, 165)
        Me.WarpMap.Name = "WarpMap"
        Me.WarpMap.Size = New System.Drawing.Size(73, 17)
        Me.WarpMap.TabIndex = 11
        Me.WarpMap.Text = "Warp to..."
        Me.InfoTip.SetToolTip(Me.WarpMap, "The map can be supplied either in the integer representation (e.g., 101) or in th" &
        "e extended map number representation (e.g., MAPA1).")
        Me.WarpMap.UseVisualStyleBackColor = True
        '
        'MapID
        '
        Me.MapID.Enabled = False
        Me.MapID.Location = New System.Drawing.Point(248, 163)
        Me.MapID.Name = "MapID"
        Me.MapID.Size = New System.Drawing.Size(44, 20)
        Me.MapID.TabIndex = 12
        Me.InfoTip.SetToolTip(Me.MapID, "The map can be supplied either in the integer representation (e.g., 101) or in th" &
        "e extended map number representation (e.g., MAPA1).")
        '
        'EXEDialog
        '
        Me.EXEDialog.FileName = "Select the game executable..."
        '
        'SRB2Addons
        '
        Me.SRB2Addons.Filter = "All usable files|*.wad; *.pk3; *.soc; *.lua|WAD files|*.wad|PK3 archives|*.pk3|So" &
    "nic Object Configuration|*.soc|Lua scripts|*.lua"
        Me.SRB2Addons.Multiselect = True
        Me.SRB2Addons.SupportMultiDottedExtensions = True
        '
        'MoveUpBtn
        '
        Me.MoveUpBtn.Enabled = False
        Me.MoveUpBtn.Location = New System.Drawing.Point(12, 307)
        Me.MoveUpBtn.Name = "MoveUpBtn"
        Me.MoveUpBtn.Size = New System.Drawing.Size(77, 23)
        Me.MoveUpBtn.TabIndex = 13
        Me.MoveUpBtn.Text = "Move Up"
        Me.MoveUpBtn.UseVisualStyleBackColor = True
        '
        'MoveDownBtn
        '
        Me.MoveDownBtn.Enabled = False
        Me.MoveDownBtn.Location = New System.Drawing.Point(95, 307)
        Me.MoveDownBtn.Name = "MoveDownBtn"
        Me.MoveDownBtn.Size = New System.Drawing.Size(77, 23)
        Me.MoveDownBtn.TabIndex = 14
        Me.MoveDownBtn.Text = "Move Down"
        Me.MoveDownBtn.UseVisualStyleBackColor = True
        '
        'ContextMenuThing
        '
        Me.ContextMenuThing.Name = "ContextMenuThing"
        Me.ContextMenuThing.Size = New System.Drawing.Size(61, 4)
        '
        'InfoTip
        '
        Me.InfoTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.InfoTip.ToolTipTitle = "Note:"
        '
        'PortChange
        '
        Me.PortChange.AutoSize = True
        Me.PortChange.Location = New System.Drawing.Point(178, 119)
        Me.PortChange.Name = "PortChange"
        Me.PortChange.Size = New System.Drawing.Size(45, 17)
        Me.PortChange.TabIndex = 15
        Me.PortChange.Text = "Port"
        Me.InfoTip.SetToolTip(Me.PortChange, "5029 is the default port SRB2 listens on. If you already have something using tha" &
        "t port, you can use a different one.")
        Me.PortChange.UseVisualStyleBackColor = True
        '
        'PortNumber
        '
        Me.PortNumber.Enabled = False
        Me.PortNumber.Location = New System.Drawing.Point(248, 117)
        Me.PortNumber.MaxLength = 5
        Me.PortNumber.Name = "PortNumber"
        Me.PortNumber.Size = New System.Drawing.Size(44, 20)
        Me.PortNumber.TabIndex = 16
        Me.PortNumber.Text = "5029"
        Me.InfoTip.SetToolTip(Me.PortNumber, "5029 is the default port SRB2 listens on. If you already have something using tha" &
        "t port, you can use a different one.")
        '
        'ConnectIP
        '
        Me.ConnectIP.AutoSize = True
        Me.ConnectIP.Location = New System.Drawing.Point(178, 188)
        Me.ConnectIP.Name = "ConnectIP"
        Me.ConnectIP.Size = New System.Drawing.Size(87, 17)
        Me.ConnectIP.TabIndex = 17
        Me.ConnectIP.Text = "Connect to..."
        Me.InfoTip.SetToolTip(Me.ConnectIP, "Input IP address of known server you wish to connect. If the server is hosted on " &
        "a different port, change the Port value above as well.")
        Me.ConnectIP.UseVisualStyleBackColor = True
        '
        'IPAddress
        '
        Me.IPAddress.Enabled = False
        Me.IPAddress.Location = New System.Drawing.Point(178, 211)
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.Size = New System.Drawing.Size(114, 20)
        Me.IPAddress.TabIndex = 18
        Me.InfoTip.SetToolTip(Me.IPAddress, "Input IP address of known server you wish to connect. If the server is hosted on " &
        "a different port, change the Port value above as well.")
        '
        'MainThing
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 341)
        Me.Controls.Add(Me.IPAddress)
        Me.Controls.Add(Me.ConnectIP)
        Me.Controls.Add(Me.PortNumber)
        Me.Controls.Add(Me.PortChange)
        Me.Controls.Add(Me.MoveDownBtn)
        Me.Controls.Add(Me.MoveUpBtn)
        Me.Controls.Add(Me.MapID)
        Me.Controls.Add(Me.WarpMap)
        Me.Controls.Add(Me.SkipIntro)
        Me.Controls.Add(Me.Dedicated)
        Me.Controls.Add(Me.Listen)
        Me.Controls.Add(Me.HostServer)
        Me.Controls.Add(Me.LoadAddons)
        Me.Controls.Add(Me.AddAddon)
        Me.Controls.Add(Me.RemAddon)
        Me.Controls.Add(Me.LaunchButton)
        Me.Controls.Add(Me.SelectEXE)
        Me.Controls.Add(Me.GameEXE)
        Me.Controls.Add(Me.AddonList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainThing"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Start Robo Blasting 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddonList As ListBox
    Friend WithEvents GameEXE As TextBox
    Friend WithEvents SelectEXE As Button
    Friend WithEvents LaunchButton As Button
    Friend WithEvents RemAddon As Button
    Friend WithEvents AddAddon As Button
    Friend WithEvents LoadAddons As CheckBox
    Friend WithEvents HostServer As CheckBox
    Friend WithEvents Listen As RadioButton
    Friend WithEvents Dedicated As RadioButton
    Friend WithEvents SkipIntro As CheckBox
    Friend WithEvents WarpMap As CheckBox
    Friend WithEvents MapID As TextBox
    Friend WithEvents EXEDialog As OpenFileDialog
    Friend WithEvents SRB2Addons As OpenFileDialog
    Friend WithEvents MoveUpBtn As Button
    Friend WithEvents MoveDownBtn As Button
    Friend WithEvents AddonListListen As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuThing As ContextMenuStrip
    Friend WithEvents InfoTip As ToolTip
    Friend WithEvents OtherTip As ToolTip
    Friend WithEvents PortChange As CheckBox
    Friend WithEvents PortNumber As TextBox
    Friend WithEvents ConnectIP As CheckBox
    Friend WithEvents IPAddress As TextBox
End Class
