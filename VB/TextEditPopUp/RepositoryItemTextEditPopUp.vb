Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Win

Namespace TEPopUp
	<UserRepositoryItem("RegisterTextEditPopUp")> _
	Friend Class RepositoryItemTextEditPopUp
		Inherits RepositoryItemPopupContainerEdit
		Private _dataSource As Object
		Private lb As ListBoxControl
		Private dv As DataView
		Private _displayMember As String, editValue As String = ""
		Private splitEditValue(-1) As String
		Private separator As Char = ";"c

		Public Const TextEditPopUpName As String = "TextEditPopUp"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return TextEditPopUpName
			End Get
		End Property

		Public Shared Sub RegisterTextEditPopUp()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(TextEditPopUpName, GetType(TextEditPopUp), GetType(RepositoryItemTextEditPopUp), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True))
		End Sub

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			MyBase.Assign(item)
			Dim source As RepositoryItemTextEditPopUp = TryCast(item, RepositoryItemTextEditPopUp)
			If source Is Nothing Then
				Return
			End If
			Me.DataSource = source.DataSource
			Me.DisplayMember = source.DisplayMember
			EndUpdate()
		End Sub

		Shared Sub New()
			RegisterTextEditPopUp()
		End Sub
		Public Sub New()
			MyBase.New()
			' Create PopupContainerControl with a ListBoxControl and bind it
			' to the editor
			lb = New ListBoxControl()
			lb.Dock = System.Windows.Forms.DockStyle.Fill
			AddHandler lb.Click, AddressOf lb_Click

			Dim pc As New PopupContainerControl()
			pc.Controls.Add(lb)

			Me.PopupControl = pc
			Me.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			AddHandler EditValueChanging, AddressOf RepositoryItemTextEditPopUp_EditValueChanging
			AddHandler KeyDown, AddressOf RepositoryItemTextEditPopUp_KeyDown
		End Sub

		Private Sub RepositoryItemTextEditPopUp_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
			If e.NewValue IsNot Nothing Then
				editValue = e.NewValue.ToString()
			End If

			splitEditValue = editValue.Split(separator)

			If editValue.EndsWith(";") Then
				HidePopupHint(sender)
			End If
			ShowPopupHint(sender, splitEditValue(splitEditValue.Length - 1).TrimStart())
		End Sub

		Protected Overrides Sub OnOwnerEditChanged()
			AddHandler KeyDown, AddressOf RepositoryItemTextEditPopUp_KeyDown
			AddHandler OwnerEdit.Validating, AddressOf OwnerEdit_Validated
			MyBase.OnOwnerEditChanged()
		End Sub

		Private Sub OwnerEdit_Validated(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			If (TryCast(sender, TextEditPopUp)).EditValue IsNot Nothing Then
				UpdateDataSource(Me.OwnerEdit.EditValue.ToString())
			End If
		End Sub

		Private Sub RepositoryItemTextEditPopUp_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If Not(TryCast(sender, TextEditPopUp)).IsPopupOpen Then
				Return
			End If
			PopupNavigation(sender, e.KeyValue)
			e.Handled = True
		End Sub

		Private Sub PopupNavigation(ByVal sender As Object, ByVal keyValue As Integer)
			Select Case keyValue
				Case 38
					' Arrow up key
					If lb.SelectedIndex > 0 Then
						lb.SelectedIndex -= 1
					End If
				Case 40
					' Arrow down key
					lb.SelectedIndex += 1
				Case 13
					' Enter key
					AppendToEditValue(sender, lb.Text)
					HidePopupHint(sender)
				Case 27
					' ESC key
					HidePopupHint(sender)
			End Select
		End Sub

		Private Sub lb_Click(ByVal sender As Object, ByVal e As EventArgs)
			If TypeOf sender Is ListBoxControl Then
				AppendToEditValue((TryCast((TryCast(sender, Control)).Parent, PopupContainerControl)).OwnerEdit, lb.Text)
				HidePopupHint((TryCast((TryCast(sender, Control)).Parent, PopupContainerControl)).OwnerEdit)
				Return
			End If
			AppendToEditValue(sender, lb.Text)
			HidePopupHint(sender)
		End Sub

		' Skip default button creation
		Public Overrides Sub CreateDefaultButton()
		End Sub

		Private Sub ShowPopupHint(ByVal sender As Object, ByVal word As String)
			If word.Length = 0 Then
				Return
			End If

			If SetDataViewFilter(word) Then
				TryCast(sender, TextEditPopUp).ShowPopup()
				TryCast(sender, TextEditPopUp).Focus()
				TryCast(sender, TextEditPopUp).SelectionStart = editValue.Length
			Else
				HidePopupHint(sender)
			End If
		End Sub

		Private Function SetDataViewFilter(ByVal word As String) As Boolean
			If DisplayMember Is Nothing OrElse dv Is Nothing Then
				Return False
			End If
			If word.Contains("'") Then
				Return False
			End If

			dv.RowFilter = "[" & DisplayMember & "] LIKE '" & word & "*'"
			Return If(dv.Count > 0, True, False)
		End Function

		Private Sub HidePopupHint(ByVal sender As Object)
			TryCast(sender, TextEditPopUp).ClosePopup()
			lb.SelectedIndex = -1
			TryCast(sender, TextEditPopUp).SelectionStart = editValue.Length
		End Sub

		Private Sub UpdateDataSource(ByVal value As String)
			If value.Length = 0 OrElse Me.DataSource Is Nothing Then
				Return
			End If

			Dim word As String
			For Each line As String In splitEditValue
				word = line.TrimStart()
				If word.Length = 0 Then
					Continue For
				End If

				If (Not ValueExistsInDataSource(word)) Then
					AddValueToDataSource(word)
				End If
			Next line
		End Sub

		Private Function ValueExistsInDataSource(ByVal word As String) As Boolean
			For Each dr As DataRow In (TryCast(Me.DataSource, DataTable)).Rows
				Dim str As String = dr(DisplayMember).ToString()
				If String.Compare(dr(DisplayMember).ToString(), word, True) = 0 Then
					Return True
				End If
			Next dr
			Return False
		End Function

		Private Sub AddValueToDataSource(ByVal value As String)
			Dim row As DataRow = (TryCast(Me.DataSource, DataTable)).NewRow()
			row(DisplayMember) = value
			TryCast(Me.DataSource, DataTable).Rows.Add(row)
		End Sub

		Private Sub AppendToEditValue(ByVal sender As Object, ByVal word As String)
			Dim value As String = ""
			For i As Integer = 0 To splitEditValue.Length - 2
				value &= splitEditValue(i).TrimStart() & "; "
			Next i

			value &= word
			If TypeOf sender Is TextEditPopUp Then
				TryCast(sender, TextEditPopUp).Text = value
			Else
				TryCast((TryCast(sender, Control)).Parent, PopupContainerControl).OwnerEdit.Text = value
			End If
		End Sub

		Public Overridable Property DataSource() As Object
			Get
				Return _dataSource
			End Get
			Set(ByVal value As Object)
				If value Is DataSource Then
					Return
				End If
				If value IsNot Nothing AndAlso DataSource IsNot Nothing AndAlso DataSource.Equals(value) Then
					Return
				End If
				_dataSource = value
				OnDataSourceChanged()
			End Set
		End Property

		Private Sub OnDataSourceChanged()
			If Me.DataSource Is Nothing Then
				Return
			End If
			dv = New DataView(TryCast(Me.DataSource, DataTable))
			lb.DataSource = dv
		End Sub

		Public Property DisplayMember() As String
			Get
				Return _displayMember
			End Get
			Set(ByVal value As String)
				If value Is Nothing OrElse value = DisplayMember Then
					Return
				End If
				_displayMember = value
				OnDisplayMemberChanged()
			End Set
		End Property

		Private Sub OnDisplayMemberChanged()
			lb.DisplayMember = _displayMember
		End Sub
	End Class
End Namespace
