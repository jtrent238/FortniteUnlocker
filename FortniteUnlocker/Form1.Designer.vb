<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Unlock = New System.Windows.Forms.Button()
        Me.ProcessPatcher = New System.Diagnostics.Process()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonPatch = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(543, 306)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button_Unlock
        '
        Me.Button_Unlock.Location = New System.Drawing.Point(998, 295)
        Me.Button_Unlock.Name = "Button_Unlock"
        Me.Button_Unlock.Size = New System.Drawing.Size(91, 23)
        Me.Button_Unlock.TabIndex = 1
        Me.Button_Unlock.Text = "Start Unlocking"
        Me.Button_Unlock.UseVisualStyleBackColor = True
        '
        'ProcessPatcher
        '
        Me.ProcessPatcher.StartInfo.Domain = ""
        Me.ProcessPatcher.StartInfo.LoadUserProfile = False
        Me.ProcessPatcher.StartInfo.Password = Nothing
        Me.ProcessPatcher.StartInfo.StandardErrorEncoding = Nothing
        Me.ProcessPatcher.StartInfo.StandardOutputEncoding = Nothing
        Me.ProcessPatcher.StartInfo.UserName = ""
        Me.ProcessPatcher.SynchronizingObject = Me
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(561, 295)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(431, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'ButtonPatch
        '
        Me.ButtonPatch.Location = New System.Drawing.Point(998, 266)
        Me.ButtonPatch.Name = "ButtonPatch"
        Me.ButtonPatch.Size = New System.Drawing.Size(91, 23)
        Me.ButtonPatch.TabIndex = 1
        Me.ButtonPatch.Text = "Patch Fortnite"
        Me.ButtonPatch.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(561, 266)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(431, 23)
        Me.ProgressBar2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 327)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonPatch)
        Me.Controls.Add(Me.Button_Unlock)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_Unlock As Button
    Friend WithEvents ProcessPatcher As Process
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ButtonPatch As Button
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
End Class
