﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.rdoPDFChoose = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabSaveLoc = New System.Windows.Forms.TabControl()
        Me.tabPDF = New System.Windows.Forms.TabPage()
        Me.numRes = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSheets = New System.Windows.Forms.ComboBox()
        Me.chkPDFBW = New System.Windows.Forms.CheckBox()
        Me.chkLineWeights = New System.Windows.Forms.CheckBox()
        Me.chkPDFRev = New System.Windows.Forms.CheckBox()
        Me.txtPDFTag = New System.Windows.Forms.TextBox()
        Me.rdoPDFTag = New System.Windows.Forms.RadioButton()
        Me.btnPDFLocBrowse = New System.Windows.Forms.Button()
        Me.txtPDFSaveLoc = New System.Windows.Forms.TextBox()
        Me.rdoPDFSaveLoc = New System.Windows.Forms.RadioButton()
        Me.tabDXF = New System.Windows.Forms.TabPage()
        Me.chkCustDXFini = New System.Windows.Forms.CheckBox()
        Me.btnDXFiniBrowse = New System.Windows.Forms.Button()
        Me.txtCustDXFini = New System.Windows.Forms.TextBox()
        Me.chkDXFRev = New System.Windows.Forms.CheckBox()
        Me.txtDXFTag = New System.Windows.Forms.TextBox()
        Me.rdoDXFTag = New System.Windows.Forms.RadioButton()
        Me.btnDXFLocBrowse = New System.Windows.Forms.Button()
        Me.rdoDXFChoose = New System.Windows.Forms.RadioButton()
        Me.txtDXFSaveLoc = New System.Windows.Forms.TextBox()
        Me.rdoDXFSaveLoc = New System.Windows.Forms.RadioButton()
        Me.tabDWG = New System.Windows.Forms.TabPage()
        Me.chkCustDWGini = New System.Windows.Forms.CheckBox()
        Me.btnDWGiniBrowse = New System.Windows.Forms.Button()
        Me.txtCustDWGini = New System.Windows.Forms.TextBox()
        Me.chkDWGRev = New System.Windows.Forms.CheckBox()
        Me.txtDWGTag = New System.Windows.Forms.TextBox()
        Me.rdoDWGTag = New System.Windows.Forms.RadioButton()
        Me.btnDWGBrowse = New System.Windows.Forms.Button()
        Me.rdoDWGChoose = New System.Windows.Forms.RadioButton()
        Me.txtDWGSaveLoc = New System.Windows.Forms.TextBox()
        Me.rdoDWGSaveLoc = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.chkArchive = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.tabSaveLoc.SuspendLayout()
        Me.tabPDF.SuspendLayout()
        CType(Me.numRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDXF.SuspendLayout()
        Me.tabDWG.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoPDFChoose
        '
        resources.ApplyResources(Me.rdoPDFChoose, "rdoPDFChoose")
        Me.rdoPDFChoose.Checked = True
        Me.rdoPDFChoose.Name = "rdoPDFChoose"
        Me.rdoPDFChoose.TabStop = True
        Me.rdoPDFChoose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabSaveLoc)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'tabSaveLoc
        '
        Me.tabSaveLoc.Controls.Add(Me.tabPDF)
        Me.tabSaveLoc.Controls.Add(Me.tabDXF)
        Me.tabSaveLoc.Controls.Add(Me.tabDWG)
        resources.ApplyResources(Me.tabSaveLoc, "tabSaveLoc")
        Me.tabSaveLoc.Name = "tabSaveLoc"
        Me.tabSaveLoc.SelectedIndex = 0
        '
        'tabPDF
        '
        Me.tabPDF.Controls.Add(Me.numRes)
        Me.tabPDF.Controls.Add(Me.Label2)
        Me.tabPDF.Controls.Add(Me.Label1)
        Me.tabPDF.Controls.Add(Me.cmbSheets)
        Me.tabPDF.Controls.Add(Me.chkPDFBW)
        Me.tabPDF.Controls.Add(Me.chkLineWeights)
        Me.tabPDF.Controls.Add(Me.chkPDFRev)
        Me.tabPDF.Controls.Add(Me.txtPDFTag)
        Me.tabPDF.Controls.Add(Me.rdoPDFTag)
        Me.tabPDF.Controls.Add(Me.btnPDFLocBrowse)
        Me.tabPDF.Controls.Add(Me.rdoPDFChoose)
        Me.tabPDF.Controls.Add(Me.txtPDFSaveLoc)
        Me.tabPDF.Controls.Add(Me.rdoPDFSaveLoc)
        resources.ApplyResources(Me.tabPDF, "tabPDF")
        Me.tabPDF.Name = "tabPDF"
        Me.tabPDF.UseVisualStyleBackColor = True
        '
        'numRes
        '
        resources.ApplyResources(Me.numRes, "numRes")
        Me.numRes.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.numRes.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numRes.Name = "numRes"
        Me.numRes.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cmbSheets
        '
        Me.cmbSheets.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("cmbSheets.AutoCompleteCustomSource"), resources.GetString("cmbSheets.AutoCompleteCustomSource1"), resources.GetString("cmbSheets.AutoCompleteCustomSource2")})
        Me.cmbSheets.DisplayMember = "All Sheets"
        Me.cmbSheets.FormattingEnabled = True
        Me.cmbSheets.Items.AddRange(New Object() {resources.GetString("cmbSheets.Items"), resources.GetString("cmbSheets.Items1"), resources.GetString("cmbSheets.Items2")})
        resources.ApplyResources(Me.cmbSheets, "cmbSheets")
        Me.cmbSheets.Name = "cmbSheets"
        '
        'chkPDFBW
        '
        resources.ApplyResources(Me.chkPDFBW, "chkPDFBW")
        Me.chkPDFBW.Name = "chkPDFBW"
        Me.chkPDFBW.UseVisualStyleBackColor = True
        '
        'chkLineWeights
        '
        resources.ApplyResources(Me.chkLineWeights, "chkLineWeights")
        Me.chkLineWeights.Checked = True
        Me.chkLineWeights.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLineWeights.Name = "chkLineWeights"
        Me.chkLineWeights.UseVisualStyleBackColor = True
        '
        'chkPDFRev
        '
        resources.ApplyResources(Me.chkPDFRev, "chkPDFRev")
        Me.chkPDFRev.Checked = True
        Me.chkPDFRev.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPDFRev.Name = "chkPDFRev"
        Me.chkPDFRev.UseVisualStyleBackColor = True
        '
        'txtPDFTag
        '
        resources.ApplyResources(Me.txtPDFTag, "txtPDFTag")
        Me.txtPDFTag.Name = "txtPDFTag"
        '
        'rdoPDFTag
        '
        resources.ApplyResources(Me.rdoPDFTag, "rdoPDFTag")
        Me.rdoPDFTag.Name = "rdoPDFTag"
        Me.rdoPDFTag.UseVisualStyleBackColor = True
        '
        'btnPDFLocBrowse
        '
        resources.ApplyResources(Me.btnPDFLocBrowse, "btnPDFLocBrowse")
        Me.btnPDFLocBrowse.Name = "btnPDFLocBrowse"
        Me.btnPDFLocBrowse.UseVisualStyleBackColor = True
        '
        'txtPDFSaveLoc
        '
        resources.ApplyResources(Me.txtPDFSaveLoc, "txtPDFSaveLoc")
        Me.txtPDFSaveLoc.Name = "txtPDFSaveLoc"
        '
        'rdoPDFSaveLoc
        '
        resources.ApplyResources(Me.rdoPDFSaveLoc, "rdoPDFSaveLoc")
        Me.rdoPDFSaveLoc.Name = "rdoPDFSaveLoc"
        Me.rdoPDFSaveLoc.UseVisualStyleBackColor = True
        '
        'tabDXF
        '
        Me.tabDXF.Controls.Add(Me.chkCustDXFini)
        Me.tabDXF.Controls.Add(Me.btnDXFiniBrowse)
        Me.tabDXF.Controls.Add(Me.txtCustDXFini)
        Me.tabDXF.Controls.Add(Me.chkDXFRev)
        Me.tabDXF.Controls.Add(Me.txtDXFTag)
        Me.tabDXF.Controls.Add(Me.rdoDXFTag)
        Me.tabDXF.Controls.Add(Me.btnDXFLocBrowse)
        Me.tabDXF.Controls.Add(Me.rdoDXFChoose)
        Me.tabDXF.Controls.Add(Me.txtDXFSaveLoc)
        Me.tabDXF.Controls.Add(Me.rdoDXFSaveLoc)
        resources.ApplyResources(Me.tabDXF, "tabDXF")
        Me.tabDXF.Name = "tabDXF"
        Me.tabDXF.UseVisualStyleBackColor = True
        '
        'chkCustDXFini
        '
        resources.ApplyResources(Me.chkCustDXFini, "chkCustDXFini")
        Me.chkCustDXFini.Name = "chkCustDXFini"
        Me.chkCustDXFini.UseVisualStyleBackColor = True
        '
        'btnDXFiniBrowse
        '
        resources.ApplyResources(Me.btnDXFiniBrowse, "btnDXFiniBrowse")
        Me.btnDXFiniBrowse.Name = "btnDXFiniBrowse"
        Me.btnDXFiniBrowse.UseVisualStyleBackColor = True
        '
        'txtCustDXFini
        '
        resources.ApplyResources(Me.txtCustDXFini, "txtCustDXFini")
        Me.txtCustDXFini.Name = "txtCustDXFini"
        '
        'chkDXFRev
        '
        resources.ApplyResources(Me.chkDXFRev, "chkDXFRev")
        Me.chkDXFRev.Checked = True
        Me.chkDXFRev.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDXFRev.Name = "chkDXFRev"
        Me.chkDXFRev.UseVisualStyleBackColor = True
        '
        'txtDXFTag
        '
        resources.ApplyResources(Me.txtDXFTag, "txtDXFTag")
        Me.txtDXFTag.Name = "txtDXFTag"
        '
        'rdoDXFTag
        '
        resources.ApplyResources(Me.rdoDXFTag, "rdoDXFTag")
        Me.rdoDXFTag.Name = "rdoDXFTag"
        Me.rdoDXFTag.UseVisualStyleBackColor = True
        '
        'btnDXFLocBrowse
        '
        resources.ApplyResources(Me.btnDXFLocBrowse, "btnDXFLocBrowse")
        Me.btnDXFLocBrowse.Name = "btnDXFLocBrowse"
        Me.btnDXFLocBrowse.UseVisualStyleBackColor = True
        '
        'rdoDXFChoose
        '
        resources.ApplyResources(Me.rdoDXFChoose, "rdoDXFChoose")
        Me.rdoDXFChoose.Checked = True
        Me.rdoDXFChoose.Name = "rdoDXFChoose"
        Me.rdoDXFChoose.TabStop = True
        Me.rdoDXFChoose.UseVisualStyleBackColor = True
        '
        'txtDXFSaveLoc
        '
        resources.ApplyResources(Me.txtDXFSaveLoc, "txtDXFSaveLoc")
        Me.txtDXFSaveLoc.Name = "txtDXFSaveLoc"
        '
        'rdoDXFSaveLoc
        '
        resources.ApplyResources(Me.rdoDXFSaveLoc, "rdoDXFSaveLoc")
        Me.rdoDXFSaveLoc.Name = "rdoDXFSaveLoc"
        Me.rdoDXFSaveLoc.UseVisualStyleBackColor = True
        '
        'tabDWG
        '
        Me.tabDWG.Controls.Add(Me.chkCustDWGini)
        Me.tabDWG.Controls.Add(Me.btnDWGiniBrowse)
        Me.tabDWG.Controls.Add(Me.txtCustDWGini)
        Me.tabDWG.Controls.Add(Me.chkDWGRev)
        Me.tabDWG.Controls.Add(Me.txtDWGTag)
        Me.tabDWG.Controls.Add(Me.rdoDWGTag)
        Me.tabDWG.Controls.Add(Me.btnDWGBrowse)
        Me.tabDWG.Controls.Add(Me.rdoDWGChoose)
        Me.tabDWG.Controls.Add(Me.txtDWGSaveLoc)
        Me.tabDWG.Controls.Add(Me.rdoDWGSaveLoc)
        resources.ApplyResources(Me.tabDWG, "tabDWG")
        Me.tabDWG.Name = "tabDWG"
        Me.tabDWG.UseVisualStyleBackColor = True
        '
        'chkCustDWGini
        '
        resources.ApplyResources(Me.chkCustDWGini, "chkCustDWGini")
        Me.chkCustDWGini.Name = "chkCustDWGini"
        Me.chkCustDWGini.UseVisualStyleBackColor = True
        '
        'btnDWGiniBrowse
        '
        resources.ApplyResources(Me.btnDWGiniBrowse, "btnDWGiniBrowse")
        Me.btnDWGiniBrowse.Name = "btnDWGiniBrowse"
        Me.btnDWGiniBrowse.UseVisualStyleBackColor = True
        '
        'txtCustDWGini
        '
        resources.ApplyResources(Me.txtCustDWGini, "txtCustDWGini")
        Me.txtCustDWGini.Name = "txtCustDWGini"
        '
        'chkDWGRev
        '
        resources.ApplyResources(Me.chkDWGRev, "chkDWGRev")
        Me.chkDWGRev.Checked = True
        Me.chkDWGRev.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDWGRev.Name = "chkDWGRev"
        Me.chkDWGRev.UseVisualStyleBackColor = True
        '
        'txtDWGTag
        '
        resources.ApplyResources(Me.txtDWGTag, "txtDWGTag")
        Me.txtDWGTag.Name = "txtDWGTag"
        '
        'rdoDWGTag
        '
        resources.ApplyResources(Me.rdoDWGTag, "rdoDWGTag")
        Me.rdoDWGTag.Name = "rdoDWGTag"
        Me.rdoDWGTag.UseVisualStyleBackColor = True
        '
        'btnDWGBrowse
        '
        resources.ApplyResources(Me.btnDWGBrowse, "btnDWGBrowse")
        Me.btnDWGBrowse.Name = "btnDWGBrowse"
        Me.btnDWGBrowse.UseVisualStyleBackColor = True
        '
        'rdoDWGChoose
        '
        resources.ApplyResources(Me.rdoDWGChoose, "rdoDWGChoose")
        Me.rdoDWGChoose.Checked = True
        Me.rdoDWGChoose.Name = "rdoDWGChoose"
        Me.rdoDWGChoose.TabStop = True
        Me.rdoDWGChoose.UseVisualStyleBackColor = True
        '
        'txtDWGSaveLoc
        '
        resources.ApplyResources(Me.txtDWGSaveLoc, "txtDWGSaveLoc")
        Me.txtDWGSaveLoc.Name = "txtDWGSaveLoc"
        '
        'rdoDWGSaveLoc
        '
        resources.ApplyResources(Me.rdoDWGSaveLoc, "rdoDWGSaveLoc")
        Me.rdoDWGSaveLoc.Name = "rdoDWGSaveLoc"
        Me.rdoDWGSaveLoc.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkArchive
        '
        resources.ApplyResources(Me.chkArchive, "chkArchive")
        Me.chkArchive.Name = "chkArchive"
        Me.chkArchive.UseVisualStyleBackColor = True
        '
        'Settings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkArchive)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.tabSaveLoc.ResumeLayout(False)
        Me.tabPDF.ResumeLayout(False)
        Me.tabPDF.PerformLayout()
        CType(Me.numRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDXF.ResumeLayout(False)
        Me.tabDXF.PerformLayout()
        Me.tabDWG.ResumeLayout(False)
        Me.tabDWG.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoPDFChoose As Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents tabSaveLoc As Windows.Forms.TabControl
    Friend WithEvents tabPDF As Windows.Forms.TabPage
    Friend WithEvents btnPDFLocBrowse As Windows.Forms.Button
    Friend WithEvents txtPDFSaveLoc As Windows.Forms.TextBox
    Friend WithEvents rdoPDFSaveLoc As Windows.Forms.RadioButton
    Friend WithEvents tabDXF As Windows.Forms.TabPage
    Friend WithEvents btnDXFLocBrowse As Windows.Forms.Button
    Friend WithEvents rdoDXFChoose As Windows.Forms.RadioButton
    Friend WithEvents txtDXFSaveLoc As Windows.Forms.TextBox
    Friend WithEvents rdoDXFSaveLoc As Windows.Forms.RadioButton
    Friend WithEvents tabDWG As Windows.Forms.TabPage
    Friend WithEvents btnDWGBrowse As Windows.Forms.Button
    Friend WithEvents rdoDWGChoose As Windows.Forms.RadioButton
    Friend WithEvents txtDWGSaveLoc As Windows.Forms.TextBox
    Friend WithEvents rdoDWGSaveLoc As Windows.Forms.RadioButton
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents txtPDFTag As Windows.Forms.TextBox
    Friend WithEvents rdoPDFTag As Windows.Forms.RadioButton
    Friend WithEvents txtDXFTag As Windows.Forms.TextBox
    Friend WithEvents rdoDXFTag As Windows.Forms.RadioButton
    Friend WithEvents txtDWGTag As Windows.Forms.TextBox
    Friend WithEvents rdoDWGTag As Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialog1 As Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkPDFRev As Windows.Forms.CheckBox
    Friend WithEvents chkDXFRev As Windows.Forms.CheckBox
    Friend WithEvents chkDWGRev As Windows.Forms.CheckBox
    Friend WithEvents chkArchive As Windows.Forms.CheckBox
    Friend WithEvents chkCustDXFini As Windows.Forms.CheckBox
    Friend WithEvents btnDXFiniBrowse As Windows.Forms.Button
    Friend WithEvents txtCustDXFini As Windows.Forms.TextBox
    Friend WithEvents chkCustDWGini As Windows.Forms.CheckBox
    Friend WithEvents btnDWGiniBrowse As Windows.Forms.Button
    Friend WithEvents txtCustDWGini As Windows.Forms.TextBox
    Friend WithEvents numRes As Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cmbSheets As Windows.Forms.ComboBox
    Friend WithEvents chkLineWeights As Windows.Forms.CheckBox
    Friend WithEvents chkPDFBW As Windows.Forms.CheckBox
End Class
