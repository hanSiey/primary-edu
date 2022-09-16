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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnWorkDone = New System.Windows.Forms.Button()
        Me.btnAvgPassRate = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcCritical = New System.Windows.Forms.Button()
        Me.btnCalcDanger = New System.Windows.Forms.Button()
        Me.txtCritical = New System.Windows.Forms.TextBox()
        Me.txtDanger = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdEducation
        '
        Me.grdEducation.FixedCols = 1
        Me.grdEducation.FixedRows = 1
        Me.grdEducation.Location = New System.Drawing.Point(164, 34)
        Me.grdEducation.Name = "grdEducation"
        Me.grdEducation.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdEducation.Size = New System.Drawing.Size(566, 219)
        Me.grdEducation.TabIndex = 0
        '
        'btnInitialze
        '
        Me.btnInitialze.Location = New System.Drawing.Point(12, 47)
        Me.btnInitialze.Name = "btnInitialze"
        Me.btnInitialze.Size = New System.Drawing.Size(135, 23)
        Me.btnInitialze.TabIndex = 1
        Me.btnInitialze.Text = "INITIALZE"
        Me.btnInitialze.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(350, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Primary School"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 86)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(135, 23)
        Me.btnInput.TabIndex = 3
        Me.btnInput.Text = "INPUT DATA"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnWorkDone
        '
        Me.btnWorkDone.Location = New System.Drawing.Point(12, 126)
        Me.btnWorkDone.Name = "btnWorkDone"
        Me.btnWorkDone.Size = New System.Drawing.Size(135, 23)
        Me.btnWorkDone.TabIndex = 4
        Me.btnWorkDone.Text = "WORK DONE"
        Me.btnWorkDone.UseVisualStyleBackColor = True
        '
        'btnAvgPassRate
        '
        Me.btnAvgPassRate.Location = New System.Drawing.Point(12, 165)
        Me.btnAvgPassRate.Name = "btnAvgPassRate"
        Me.btnAvgPassRate.Size = New System.Drawing.Size(135, 23)
        Me.btnAvgPassRate.TabIndex = 5
        Me.btnAvgPassRate.Text = "AVERAGE PASS RATE"
        Me.btnAvgPassRate.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(12, 205)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(135, 23)
        Me.btnStatus.TabIndex = 6
        Me.btnStatus.Text = "STATUS"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number Of School Critical"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Number Of School in the Danger Zone"
        '
        'btnCalcCritical
        '
        Me.btnCalcCritical.Location = New System.Drawing.Point(12, 271)
        Me.btnCalcCritical.Name = "btnCalcCritical"
        Me.btnCalcCritical.Size = New System.Drawing.Size(135, 23)
        Me.btnCalcCritical.TabIndex = 9
        Me.btnCalcCritical.Text = "CRITICAL SCHOOLS"
        Me.btnCalcCritical.UseVisualStyleBackColor = True
        '
        'btnCalcDanger
        '
        Me.btnCalcDanger.Location = New System.Drawing.Point(12, 300)
        Me.btnCalcDanger.Name = "btnCalcDanger"
        Me.btnCalcDanger.Size = New System.Drawing.Size(135, 23)
        Me.btnCalcDanger.TabIndex = 10
        Me.btnCalcDanger.Text = "DANGER ZONE"
        Me.btnCalcDanger.UseVisualStyleBackColor = True
        '
        'txtCritical
        '
        Me.txtCritical.Location = New System.Drawing.Point(243, 287)
        Me.txtCritical.Name = "txtCritical"
        Me.txtCritical.Size = New System.Drawing.Size(100, 20)
        Me.txtCritical.TabIndex = 11
        '
        'txtDanger
        '
        Me.txtDanger.Location = New System.Drawing.Point(434, 287)
        Me.txtDanger.Name = "txtDanger"
        Me.txtDanger.Size = New System.Drawing.Size(100, 20)
        Me.txtDanger.TabIndex = 12
        '
        'frmEducation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 332)
        Me.Controls.Add(Me.txtDanger)
        Me.Controls.Add(Me.txtCritical)
        Me.Controls.Add(Me.btnCalcDanger)
        Me.Controls.Add(Me.btnCalcCritical)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnAvgPassRate)
        Me.Controls.Add(Me.btnWorkDone)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInitialze)
        Me.Controls.Add(Me.grdEducation)
        Me.Name = "frmEducation"
        Me.Text = "Primary Schools Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdEducation As UJGrid.UJGrid
    Friend WithEvents btnInitialze As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents btnWorkDone As Button
    Friend WithEvents btnAvgPassRate As Button
    Friend WithEvents btnStatus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcCritical As Button
    Friend WithEvents btnCalcDanger As Button
    Friend WithEvents txtCritical As TextBox
    Friend WithEvents txtDanger As TextBox
End Class
