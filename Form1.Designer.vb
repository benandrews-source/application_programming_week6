<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstIncome = New System.Windows.Forms.ListBox()
        Me.lstExpense = New System.Windows.Forms.ListBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstIncome
        '
        Me.lstIncome.FormattingEnabled = True
        Me.lstIncome.Location = New System.Drawing.Point(121, 76)
        Me.lstIncome.Name = "lstIncome"
        Me.lstIncome.Size = New System.Drawing.Size(189, 238)
        Me.lstIncome.TabIndex = 0
        Me.lstIncome.TabStop = False
        '
        'lstExpense
        '
        Me.lstExpense.FormattingEnabled = True
        Me.lstExpense.Location = New System.Drawing.Point(555, 69)
        Me.lstExpense.Name = "lstExpense"
        Me.lstExpense.Size = New System.Drawing.Size(189, 238)
        Me.lstExpense.TabIndex = 1
        Me.lstExpense.TabStop = False
        '
        'lblAmount
        '
        Me.lblAmount.Location = New System.Drawing.Point(371, 36)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(89, 35)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Amount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncome
        '
        Me.lblIncome.Location = New System.Drawing.Point(373, 304)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(89, 35)
        Me.lblIncome.TabIndex = 3
        Me.lblIncome.Text = "Total Income"
        Me.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(353, 76)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(136, 96)
        Me.txtAmount.TabIndex = 0
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(353, 342)
        Me.txtIncome.Multiline = True
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.ReadOnly = True
        Me.txtIncome.Size = New System.Drawing.Size(136, 96)
        Me.txtIncome.TabIndex = 5
        Me.txtIncome.TabStop = False
        '
        'btnIncome
        '
        Me.btnIncome.Location = New System.Drawing.Point(374, 179)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(98, 46)
        Me.btnIncome.TabIndex = 1
        Me.btnIncome.Text = "Total &Income"
        Me.btnIncome.UseVisualStyleBackColor = True
        '
        'btnExpense
        '
        Me.btnExpense.Location = New System.Drawing.Point(374, 231)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(98, 46)
        Me.btnExpense.TabIndex = 2
        Me.btnExpense.Text = "Total E&xpense"
        Me.btnExpense.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExpense)
        Me.Controls.Add(Me.btnIncome)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lstExpense)
        Me.Controls.Add(Me.lstIncome)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstIncome As ListBox
    Friend WithEvents lstExpense As ListBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents btnIncome As Button
    Friend WithEvents btnExpense As Button
End Class
