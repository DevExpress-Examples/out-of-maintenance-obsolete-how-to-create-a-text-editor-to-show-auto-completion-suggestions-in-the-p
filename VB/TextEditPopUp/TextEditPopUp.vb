Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace TEPopUp
	Friend Class TextEditPopUp
		Inherits PopupContainerEdit
		Shared Sub New()
			RepositoryItemTextEditPopUp.RegisterTextEditPopUp()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemTextEditPopUp.TextEditPopUpName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemTextEditPopUp
			Get
				Return TryCast(MyBase.Properties, RepositoryItemTextEditPopUp)
			End Get
		End Property

		Public Overridable Property DataSource() As Object
			Set(ByVal value As Object)
				Properties.DataSource = value
			End Set
			Get
				Return Properties.DataSource
			End Get
		End Property

		Public Overridable Property DisplayMember() As String
			Set(ByVal value As String)
				Properties.DisplayMember = value
			End Set
			Get
				Return Properties.DisplayMember
			End Get
		End Property
	End Class
End Namespace
