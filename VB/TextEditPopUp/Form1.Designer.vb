Imports Microsoft.VisualBasic
Imports System
Namespace TEPopUp
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textEditPopUp1 = New TEPopUp.TextEditPopUp()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEditPopUp1 = New TEPopUp.RepositoryItemTextEditPopUp()
			CType(Me.textEditPopUp1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEditPopUp1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEditPopUp1
			' 
			Me.textEditPopUp1.DataSource = Nothing
			Me.textEditPopUp1.DisplayMember = Nothing
			Me.textEditPopUp1.Location = New System.Drawing.Point(12, 12)
			Me.textEditPopUp1.Name = "textEditPopUp1"
			Me.textEditPopUp1.Properties.DataSource = Nothing
			Me.textEditPopUp1.Properties.DisplayMember = Nothing
			Me.textEditPopUp1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.textEditPopUp1.Size = New System.Drawing.Size(260, 20)
			Me.textEditPopUp1.TabIndex = 3
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(13, 39)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEditPopUp1})
			Me.gridControl1.Size = New System.Drawing.Size(259, 213)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "gridColumn1"
			Me.gridColumn1.ColumnEdit = Me.repositoryItemTextEditPopUp1
			Me.gridColumn1.FieldName = "Fruit"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' repositoryItemTextEditPopUp1
			' 
			Me.repositoryItemTextEditPopUp1.AutoHeight = False
			Me.repositoryItemTextEditPopUp1.DataSource = Nothing
			Me.repositoryItemTextEditPopUp1.DisplayMember = Nothing
			Me.repositoryItemTextEditPopUp1.Name = "repositoryItemTextEditPopUp1"
			Me.repositoryItemTextEditPopUp1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(520, 299)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.textEditPopUp1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.textEditPopUp1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEditPopUp1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private textEditPopUp1 As TextEditPopUp
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTextEditPopUp1 As RepositoryItemTextEditPopUp
	End Class
End Namespace

