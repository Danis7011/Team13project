<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiseaseManager
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
        Me.grdDisplay = New UJGrid.UJGrid()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnCInput = New System.Windows.Forms.Button()
        Me.btnDInput = New System.Windows.Forms.Button()
        Me.btntreatment = New System.Windows.Forms.Button()
        Me.btnTotals = New System.Windows.Forms.Button()
        Me.btnSymptoms = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCommonHIV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLcommonMalaria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCovidexpense = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTreatmentPrice = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdDisplay
        '
        Me.grdDisplay.FixedCols = 1
        Me.grdDisplay.FixedRows = 1
        Me.grdDisplay.Location = New System.Drawing.Point(322, 33)
        Me.grdDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdDisplay.Name = "grdDisplay"
        Me.grdDisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplay.Size = New System.Drawing.Size(1301, 342)
        Me.grdDisplay.TabIndex = 0
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(35, 33)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(230, 41)
        Me.btnInit.TabIndex = 1
        Me.btnInit.Text = "Initialise"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnCInput
        '
        Me.btnCInput.Location = New System.Drawing.Point(35, 98)
        Me.btnCInput.Name = "btnCInput"
        Me.btnCInput.Size = New System.Drawing.Size(230, 41)
        Me.btnCInput.TabIndex = 2
        Me.btnCInput.Text = "Country Input"
        Me.btnCInput.UseVisualStyleBackColor = True
        '
        'btnDInput
        '
        Me.btnDInput.Location = New System.Drawing.Point(35, 157)
        Me.btnDInput.Name = "btnDInput"
        Me.btnDInput.Size = New System.Drawing.Size(230, 41)
        Me.btnDInput.TabIndex = 3
        Me.btnDInput.Text = " Disease Input"
        Me.btnDInput.UseVisualStyleBackColor = True
        '
        'btntreatment
        '
        Me.btntreatment.Location = New System.Drawing.Point(35, 334)
        Me.btntreatment.Name = "btntreatment"
        Me.btntreatment.Size = New System.Drawing.Size(230, 41)
        Me.btntreatment.TabIndex = 4
        Me.btntreatment.Text = "Treatment"
        Me.btntreatment.UseVisualStyleBackColor = True
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(35, 214)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(230, 41)
        Me.btnTotals.TabIndex = 5
        Me.btnTotals.Text = "Calculating Totals"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'btnSymptoms
        '
        Me.btnSymptoms.Location = New System.Drawing.Point(35, 272)
        Me.btnSymptoms.Name = "btnSymptoms"
        Me.btnSymptoms.Size = New System.Drawing.Size(230, 41)
        Me.btnSymptoms.TabIndex = 6
        Me.btnSymptoms.Text = "Symptoms"
        Me.btnSymptoms.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Most common country infected with HIV:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtCommonHIV
        '
        Me.TxtCommonHIV.Location = New System.Drawing.Point(359, 469)
        Me.TxtCommonHIV.Name = "TxtCommonHIV"
        Me.TxtCommonHIV.ReadOnly = True
        Me.TxtCommonHIV.Size = New System.Drawing.Size(190, 26)
        Me.TxtCommonHIV.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 509)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Least common country infected with Malaria:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtLcommonMalaria
        '
        Me.txtLcommonMalaria.Location = New System.Drawing.Point(359, 509)
        Me.txtLcommonMalaria.Name = "txtLcommonMalaria"
        Me.txtLcommonMalaria.ReadOnly = True
        Me.txtLcommonMalaria.Size = New System.Drawing.Size(190, 26)
        Me.txtLcommonMalaria.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 544)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total number of people with TB:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalTB
        '
        Me.txtTotalTB.Location = New System.Drawing.Point(359, 541)
        Me.txtTotalTB.Name = "txtTotalTB"
        Me.txtTotalTB.ReadOnly = True
        Me.txtTotalTB.Size = New System.Drawing.Size(190, 26)
        Me.txtTotalTB.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 616)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total covid expense in Dollars:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCovidexpense
        '
        Me.txtCovidexpense.Location = New System.Drawing.Point(359, 610)
        Me.txtCovidexpense.Name = "txtCovidexpense"
        Me.txtCovidexpense.ReadOnly = True
        Me.txtCovidexpense.Size = New System.Drawing.Size(190, 26)
        Me.txtCovidexpense.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 576)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 40)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cost per person to treat Covid19 in Dollars:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTreatmentPrice
        '
        Me.txtTreatmentPrice.Location = New System.Drawing.Point(359, 573)
        Me.txtTreatmentPrice.Name = "txtTreatmentPrice"
        Me.txtTreatmentPrice.Size = New System.Drawing.Size(190, 26)
        Me.txtTreatmentPrice.TabIndex = 16
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(35, 405)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(518, 52)
        Me.btnDisplay.TabIndex = 17
        Me.btnDisplay.Text = "Display answers"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmDiseaseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1714, 682)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtTreatmentPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCovidexpense)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLcommonMalaria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCommonHIV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSymptoms)
        Me.Controls.Add(Me.btnTotals)
        Me.Controls.Add(Me.btntreatment)
        Me.Controls.Add(Me.btnDInput)
        Me.Controls.Add(Me.btnCInput)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.grdDisplay)
        Me.Name = "frmDiseaseManager"
        Me.Text = "Disease Manager "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdDisplay As UJGrid.UJGrid
    Friend WithEvents btnInit As Button
    Friend WithEvents btnCInput As Button
    Friend WithEvents btnDInput As Button
    Friend WithEvents btntreatment As Button
    Friend WithEvents btnTotals As Button
    Friend WithEvents btnSymptoms As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCommonHIV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLcommonMalaria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCovidexpense As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTreatmentPrice As TextBox
    Friend WithEvents btnDisplay As Button
End Class
