<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEducation
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
        Me.grdEducation = New UJGrid.UJGrid()
        Me.btnInitialze = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnWorkDone = New System.Windows.Forms.Button()
        Me.btnAvgPassRate = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCritical = New System.Windows.Forms.TextBox()
        Me.txtDangerZone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grdEducation
        '
        Me.grdEducation.FixedCols = 1
        Me.grdEducation.FixedRows = 1
        Me.grdEducation.Location = New System.Drawing.Point(294, 62)
        Me.grdEducation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdEducation.Name = "grdEducation"
        Me.grdEducation.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdEducation.Size = New System.Drawing.Size(872, 366)
        Me.grdEducation.TabIndex = 0
        '
        'btnInitialze
        '
        Me.btnInitialze.Location = New System.Drawing.Point(27, 82)
        Me.btnInitialze.Name = "btnInitialze"
        Me.btnInitialze.Size = New System.Drawing.Size(207, 38)
        Me.btnInitialze.TabIndex = 1
        Me.btnInitialze.Text = "INITIALZE"
        Me.btnInitialze.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(27, 151)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(207, 38)
        Me.btnInput.TabIndex = 2
        Me.btnInput.Text = "INPUT DATA"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnWorkDone
        '
        Me.btnWorkDone.Enabled = False
        Me.btnWorkDone.Location = New System.Drawing.Point(27, 220)
        Me.btnWorkDone.Name = "btnWorkDone"
        Me.btnWorkDone.Size = New System.Drawing.Size(207, 38)
        Me.btnWorkDone.TabIndex = 3
        Me.btnWorkDone.Text = "WORK DONE %"
        Me.btnWorkDone.UseVisualStyleBackColor = True
        '
        'btnAvgPassRate
        '
        Me.btnAvgPassRate.Enabled = False
        Me.btnAvgPassRate.Location = New System.Drawing.Point(27, 289)
        Me.btnAvgPassRate.Name = "btnAvgPassRate"
        Me.btnAvgPassRate.Size = New System.Drawing.Size(207, 38)
        Me.btnAvgPassRate.TabIndex = 4
        Me.btnAvgPassRate.Text = "AVERAGE PASS RATE"
        Me.btnAvgPassRate.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Enabled = False
        Me.btnStatus.Location = New System.Drawing.Point(27, 358)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(207, 38)
        Me.btnStatus.TabIndex = 5
        Me.btnStatus.Text = "STATUS"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(299, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Primary Schools"
        '
        'txtCritical
        '
        Me.txtCritical.Location = New System.Drawing.Point(328, 509)
        Me.txtCritical.Name = "txtCritical"
        Me.txtCritical.ReadOnly = True
        Me.txtCritical.Size = New System.Drawing.Size(194, 26)
        Me.txtCritical.TabIndex = 7
        '
        'txtDangerZone
        '
        Me.txtDangerZone.Location = New System.Drawing.Point(652, 509)
        Me.txtDangerZone.Name = "txtDangerZone"
        Me.txtDangerZone.ReadOnly = True
        Me.txtDangerZone.Size = New System.Drawing.Size(194, 26)
        Me.txtDangerZone.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number Of Schools Critical"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Number Of Schools in the Danger Zone"
        '
        'frmEducation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDangerZone)
        Me.Controls.Add(Me.txtCritical)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnAvgPassRate)
        Me.Controls.Add(Me.btnWorkDone)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnInitialze)
        Me.Controls.Add(Me.grdEducation)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEducation"
        Me.Text = "Primary Education"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdEducation As UJGrid.UJGrid
    Friend WithEvents btnInitialze As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnWorkDone As Button
    Friend WithEvents btnAvgPassRate As Button
    Friend WithEvents btnStatus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCritical As TextBox
    Friend WithEvents txtDangerZone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
