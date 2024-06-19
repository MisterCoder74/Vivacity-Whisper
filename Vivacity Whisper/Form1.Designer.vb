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
        Me.loadbtn = New System.Windows.Forms.Button()
        Me.resulttxt = New System.Windows.Forms.TextBox()
        Me.apikeytxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.transcrbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.logtxt = New System.Windows.Forms.TextBox()
        Me.LabelLoad = New System.Windows.Forms.Label()
        Me.filenamelabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loadbtn
        '
        Me.loadbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadbtn.Location = New System.Drawing.Point(25, 25)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(175, 27)
        Me.loadbtn.TabIndex = 0
        Me.loadbtn.Text = "Browse File"
        Me.loadbtn.UseVisualStyleBackColor = True
        '
        'resulttxt
        '
        Me.resulttxt.Location = New System.Drawing.Point(12, 165)
        Me.resulttxt.Multiline = True
        Me.resulttxt.Name = "resulttxt"
        Me.resulttxt.Size = New System.Drawing.Size(527, 385)
        Me.resulttxt.TabIndex = 1
        '
        'apikeytxt
        '
        Me.apikeytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apikeytxt.Location = New System.Drawing.Point(12, 136)
        Me.apikeytxt.Name = "apikeytxt"
        Me.apikeytxt.Size = New System.Drawing.Size(527, 23)
        Me.apikeytxt.TabIndex = 2
        Me.apikeytxt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "OpenAI API key"
        '
        'transcrbtn
        '
        Me.transcrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transcrbtn.Location = New System.Drawing.Point(318, 25)
        Me.transcrbtn.Name = "transcrbtn"
        Me.transcrbtn.Size = New System.Drawing.Size(175, 27)
        Me.transcrbtn.TabIndex = 4
        Me.transcrbtn.Text = "Transcribe"
        Me.transcrbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(611, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Browse File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'logtxt
        '
        Me.logtxt.Location = New System.Drawing.Point(546, 165)
        Me.logtxt.Multiline = True
        Me.logtxt.Name = "logtxt"
        Me.logtxt.Size = New System.Drawing.Size(241, 385)
        Me.logtxt.TabIndex = 6
        '
        'LabelLoad
        '
        Me.LabelLoad.AutoSize = True
        Me.LabelLoad.Location = New System.Drawing.Point(25, 69)
        Me.LabelLoad.Name = "LabelLoad"
        Me.LabelLoad.Size = New System.Drawing.Size(71, 15)
        Me.LabelLoad.TabIndex = 7
        Me.LabelLoad.Text = "Loaded file:"
        '
        'filenamelabel
        '
        Me.filenamelabel.AutoSize = True
        Me.filenamelabel.Location = New System.Drawing.Point(102, 69)
        Me.filenamelabel.Name = "filenamelabel"
        Me.filenamelabel.Size = New System.Drawing.Size(0, 15)
        Me.filenamelabel.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 562)
        Me.Controls.Add(Me.filenamelabel)
        Me.Controls.Add(Me.LabelLoad)
        Me.Controls.Add(Me.logtxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.transcrbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.apikeytxt)
        Me.Controls.Add(Me.resulttxt)
        Me.Controls.Add(Me.loadbtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loadbtn As System.Windows.Forms.Button
    Friend WithEvents resulttxt As System.Windows.Forms.TextBox
    Friend WithEvents apikeytxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents transcrbtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents logtxt As System.Windows.Forms.TextBox
    Friend WithEvents LabelLoad As System.Windows.Forms.Label
    Friend WithEvents filenamelabel As System.Windows.Forms.Label

End Class
