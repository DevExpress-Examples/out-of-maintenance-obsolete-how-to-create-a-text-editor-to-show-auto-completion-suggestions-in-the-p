Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TEPopUp
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim table As DataTable = FillDataTable()
			gridControl1.DataSource = table

			textEditPopUp1.DataSource = table
			textEditPopUp1.DisplayMember = "Fruit"

			repositoryItemTextEditPopUp1.DataSource = table
			repositoryItemTextEditPopUp1.DisplayMember = "Fruit"
		End Sub

		Private Function FillDataTable() As DataTable
			Dim _dataTable As New DataTable()
			Dim col As DataColumn
			Dim row As DataRow

			col = New DataColumn()
			col.ColumnName = "Fruit"
			col.DataType = System.Type.GetType("System.String")
			_dataTable.Columns.Add(col)

			row = _dataTable.NewRow()
			row("Fruit") = "Apple"
			_dataTable.Rows.Add(row)

			row = _dataTable.NewRow()
			row("Fruit") = "Apricot"
			_dataTable.Rows.Add(row)

			row = _dataTable.NewRow()
			row("Fruit") = "Avocado"
			_dataTable.Rows.Add(row)

			Return _dataTable
		End Function
	End Class
End Namespace
