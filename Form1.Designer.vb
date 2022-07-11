<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblChooseSex = New System.Windows.Forms.Label()
        Me.lblNameSize = New System.Windows.Forms.Label()
        Me.lblFirstLetter = New System.Windows.Forms.Label()
        Me.lblSearchMode = New System.Windows.Forms.Label()
        Me.lbxChooseSex = New System.Windows.Forms.ListBox()
        Me.nudNameSize = New System.Windows.Forms.NumericUpDown()
        Me.tbxFirstLetter = New System.Windows.Forms.TextBox()
        Me.rbtRandom = New System.Windows.Forms.RadioButton()
        Me.rbtMin = New System.Windows.Forms.RadioButton()
        Me.rbtMax = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxUse = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.nudNameSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChooseSex
        '
        Me.lblChooseSex.AutoSize = True
        Me.lblChooseSex.Location = New System.Drawing.Point(14, 12)
        Me.lblChooseSex.Name = "lblChooseSex"
        Me.lblChooseSex.Size = New System.Drawing.Size(128, 20)
        Me.lblChooseSex.TabIndex = 0
        Me.lblChooseSex.Text = "Choisissez le sexe:"
        '
        'lblNameSize
        '
        Me.lblNameSize.AutoSize = True
        Me.lblNameSize.Location = New System.Drawing.Point(14, 42)
        Me.lblNameSize.Name = "lblNameSize"
        Me.lblNameSize.Size = New System.Drawing.Size(218, 20)
        Me.lblNameSize.TabIndex = 1
        Me.lblNameSize.Text = "Choisissez la longueur du prénom:"
        '
        'lblFirstLetter
        '
        Me.lblFirstLetter.AutoSize = True
        Me.lblFirstLetter.Location = New System.Drawing.Point(12, 74)
        Me.lblFirstLetter.Name = "lblFirstLetter"
        Me.lblFirstLetter.Size = New System.Drawing.Size(253, 20)
        Me.lblFirstLetter.TabIndex = 2
        Me.lblFirstLetter.Text = "(Optionnel) Choisissez la première lettre:"
        '
        'lblSearchMode
        '
        Me.lblSearchMode.AutoSize = True
        Me.lblSearchMode.Location = New System.Drawing.Point(12, 140)
        Me.lblSearchMode.Name = "lblSearchMode"
        Me.lblSearchMode.Size = New System.Drawing.Size(217, 20)
        Me.lblSearchMode.TabIndex = 3
        Me.lblSearchMode.Text = "Choisissez le mode de recherche:"
        '
        'lbxChooseSex
        '
        Me.lbxChooseSex.FormattingEnabled = True
        Me.lbxChooseSex.ItemHeight = 20
        Me.lbxChooseSex.Items.AddRange(New Object() {"Fille", "Garçon"})
        Me.lbxChooseSex.Location = New System.Drawing.Point(284, 12)
        Me.lbxChooseSex.Name = "lbxChooseSex"
        Me.lbxChooseSex.Size = New System.Drawing.Size(120, 24)
        Me.lbxChooseSex.TabIndex = 4
        '
        'nudNameSize
        '
        Me.nudNameSize.Location = New System.Drawing.Point(284, 42)
        Me.nudNameSize.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudNameSize.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudNameSize.Name = "nudNameSize"
        Me.nudNameSize.Size = New System.Drawing.Size(120, 26)
        Me.nudNameSize.TabIndex = 6
        Me.nudNameSize.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'tbxFirstLetter
        '
        Me.tbxFirstLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxFirstLetter.Location = New System.Drawing.Point(284, 74)
        Me.tbxFirstLetter.MaxLength = 1
        Me.tbxFirstLetter.Name = "tbxFirstLetter"
        Me.tbxFirstLetter.Size = New System.Drawing.Size(120, 26)
        Me.tbxFirstLetter.TabIndex = 7
        '
        'rbtRandom
        '
        Me.rbtRandom.AutoSize = True
        Me.rbtRandom.Checked = True
        Me.rbtRandom.Location = New System.Drawing.Point(284, 110)
        Me.rbtRandom.Name = "rbtRandom"
        Me.rbtRandom.Size = New System.Drawing.Size(80, 24)
        Me.rbtRandom.TabIndex = 8
        Me.rbtRandom.TabStop = True
        Me.rbtRandom.Text = "Aléatoire"
        Me.rbtRandom.UseVisualStyleBackColor = True
        '
        'rbtMin
        '
        Me.rbtMin.AutoSize = True
        Me.rbtMin.Location = New System.Drawing.Point(284, 140)
        Me.rbtMin.Name = "rbtMin"
        Me.rbtMin.Size = New System.Drawing.Size(120, 24)
        Me.rbtMin.TabIndex = 9
        Me.rbtMin.Text = "Le moins utilisé"
        Me.rbtMin.UseVisualStyleBackColor = True
        '
        'rbtMax
        '
        Me.rbtMax.AutoSize = True
        Me.rbtMax.Location = New System.Drawing.Point(284, 170)
        Me.rbtMax.Name = "rbtMax"
        Me.rbtMax.Size = New System.Drawing.Size(109, 24)
        Me.rbtMax.TabIndex = 10
        Me.rbtMax.Text = "Le plus utilisé"
        Me.rbtMax.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.ForeColor = System.Drawing.Color.Blue
        Me.lblResult.Location = New System.Drawing.Point(12, 223)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(151, 20)
        Me.lblResult.TabIndex = 11
        Me.lblResult.Text = "Lancer une recherche..."
        '
        'tbxName
        '
        Me.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxName.ForeColor = System.Drawing.Color.Green
        Me.tbxName.Location = New System.Drawing.Point(14, 263)
        Me.tbxName.MaxLength = 20
        Me.tbxName.Name = "tbxName"
        Me.tbxName.ReadOnly = True
        Me.tbxName.Size = New System.Drawing.Size(128, 26)
        Me.tbxName.TabIndex = 12
        Me.tbxName.Text = "Aucun"
        Me.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxUse
        '
        Me.tbxUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUse.ForeColor = System.Drawing.Color.Green
        Me.tbxUse.Location = New System.Drawing.Point(148, 263)
        Me.tbxUse.Name = "tbxUse"
        Me.tbxUse.ReadOnly = True
        Me.tbxUse.Size = New System.Drawing.Size(216, 26)
        Me.tbxUse.TabIndex = 13
        Me.tbxUse.Text = "A été utilisés xxxx depuis 2006"
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.Navy
        Me.btnSearch.Location = New System.Drawing.Point(380, 263)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 26)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 317)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbxUse)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.rbtMax)
        Me.Controls.Add(Me.rbtMin)
        Me.Controls.Add(Me.rbtRandom)
        Me.Controls.Add(Me.tbxFirstLetter)
        Me.Controls.Add(Me.nudNameSize)
        Me.Controls.Add(Me.lbxChooseSex)
        Me.Controls.Add(Me.lblSearchMode)
        Me.Controls.Add(Me.lblFirstLetter)
        Me.Controls.Add(Me.lblNameSize)
        Me.Controls.Add(Me.lblChooseSex)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Générateur de prénoms"
        CType(Me.nudNameSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChooseSex As Label
    Friend WithEvents lblNameSize As Label
    Friend WithEvents lblFirstLetter As Label
    Friend WithEvents lblSearchMode As Label
    Friend WithEvents lbxChooseSex As ListBox
    Friend WithEvents nudNameSize As NumericUpDown
    Friend WithEvents tbxFirstLetter As TextBox
    Friend WithEvents rbtRandom As RadioButton
    Friend WithEvents rbtMin As RadioButton
    Friend WithEvents rbtMax As RadioButton
    Friend WithEvents lblResult As Label
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxUse As TextBox
    Friend WithEvents btnSearch As Button
End Class
