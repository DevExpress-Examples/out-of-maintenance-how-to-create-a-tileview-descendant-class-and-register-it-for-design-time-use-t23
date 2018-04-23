Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace MyXtraGrid
    Public Class MyTileViewInfoRegistrator
        Inherits TileViewInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyTileView"
            End Get
        End Property
        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyTileView()
        End Function
        Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
            Return New MyTileViewInfo(TryCast(view, MyTileView))
        End Function
    End Class
End Namespace
