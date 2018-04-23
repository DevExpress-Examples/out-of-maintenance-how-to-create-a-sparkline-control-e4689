Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Sparkline
Imports DevExpress.XtraEditors
#End Region ' #usings

Namespace SparklineSample

	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.Controls.Add(CreateSparkline())
		End Sub

		#Region "#Sparkline"
		Private Function CreateSparkline() As SparklineEdit
			' Create a Sparkline editor and set its dock style.
			Dim sparkline As New SparklineEdit()
			sparkline.Dock = DockStyle.Fill

			sparkline.EditValue = CreateData()

			' Create an Area view and assign it to the sparkline.
			Dim view As New AreaSparklineView()
			sparkline.Properties.View = view

			' Customize area appearance.
			view.Color = Color.Aqua
			view.AreaOpacity = 50

			' Show markerks.
			view.HighlightStartPoint = True
			view.HighlightEndPoint = True
			view.HighlightMaxPoint = True
			view.HighlightMinPoint = True
			view.HighlightNegativePoints = True
			view.SetSizeForAllMarkers(10)

			Return sparkline
		End Function

		Private Function CreateData() As Double()
			Return New Double() { 2, 4, 5, 1, -1, -2, -1, 2, 4, 5, 6, 3, 5, 4, 8, -1, 6 }
		End Function
		#End Region ' #Sparkline
	End Class

End Namespace
