<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngWorkflowTree
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnDrawingsOnly = New System.Windows.Forms.Button()
        Me.btnDrawAndReport = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(1091, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(96, 23)
        Me.btnExport.TabIndex = 10
        Me.btnExport.Text = "Export To Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnDrawingsOnly
        '
        Me.btnDrawingsOnly.Location = New System.Drawing.Point(525, 13)
        Me.btnDrawingsOnly.Name = "btnDrawingsOnly"
        Me.btnDrawingsOnly.Size = New System.Drawing.Size(109, 23)
        Me.btnDrawingsOnly.TabIndex = 9
        Me.btnDrawingsOnly.Text = "Drawings Only"
        Me.btnDrawingsOnly.UseVisualStyleBackColor = True
        '
        'btnDrawAndReport
        '
        Me.btnDrawAndReport.Location = New System.Drawing.Point(410, 13)
        Me.btnDrawAndReport.Name = "btnDrawAndReport"
        Me.btnDrawAndReport.Size = New System.Drawing.Size(109, 23)
        Me.btnDrawAndReport.TabIndex = 8
        Me.btnDrawAndReport.Text = "Drawings + Reports"
        Me.btnDrawAndReport.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(2, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(126, 23)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "Show Selected Record"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'TreeList2
        '
        Me.TreeList2.Location = New System.Drawing.Point(2, 40)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.OptionsCustomization.AllowSort = False
        Me.TreeList2.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.TreeList2.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search
        Me.TreeList2.Size = New System.Drawing.Size(1597, 678)
        Me.TreeList2.TabIndex = 11
        Me.TreeList2.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'frmEngWorkflowTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 721)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnDrawingsOnly)
        Me.Controls.Add(Me.btnDrawAndReport)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "frmEngWorkflowTree"
        Me.Text = "frmEngWorkflowTree"
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExport As Button
    Friend WithEvents btnDrawingsOnly As Button
    Friend WithEvents btnDrawAndReport As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
