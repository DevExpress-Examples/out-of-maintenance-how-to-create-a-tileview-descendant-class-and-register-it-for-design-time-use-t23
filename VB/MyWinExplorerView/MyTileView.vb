Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraGrid.Views.Tile

Namespace MyXtraGrid
    Public Class MyTileView
        Inherits TileView

        Public Sub New()

        End Sub
        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyTileView"
            End Get
        End Property
    End Class
End Namespace
