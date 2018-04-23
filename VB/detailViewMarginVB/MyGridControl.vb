Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.Handler
Imports System.Drawing
Imports System.ComponentModel

Namespace detailViewMargin
	Friend Class MyGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As DevExpress.XtraGrid.Registrator.InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridInfoRegistrator())
		End Sub
	End Class

	Public Class MyGridView
		Inherits GridView
		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub New(ByVal ownerGrid As GridControl)
			MyBase.New(ownerGrid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
	End Class

	Public Class MyGridInfoRegistrator
		Inherits GridInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(grid)
		End Function

		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo
			Return New MyGridViewInfo(CType(view, MyGridView))
		End Function

		Public Overrides Function CreateHandler(ByVal view As BaseView) As DevExpress.XtraGrid.Views.Base.Handler.BaseViewHandler
			Return New GridHandler(CType(view, MyGridView))
		End Function
	End Class

	Public Class MyGridViewInfo
		Inherits GridViewInfo
		Private childViewMargin As Integer

		Public Sub New(ByVal gridView As GridView)
			MyBase.New(gridView)
		 If gridView.LevelName <> String.Empty Then
			 childViewMargin = 20
		 Else
			 childViewMargin = 0
		 End If
		End Sub

		Protected Overrides Function CalcBorderRect(ByVal bounds As System.Drawing.Rectangle) As System.Drawing.Rectangle
			Dim result As Rectangle = MyBase.CalcBorderRect(bounds)
			result.Width -= childViewMargin
			Return result
		End Function
	End Class
End Namespace
