Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.WinExplorer.ViewInfo
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports DevExpress.Utils

Namespace MyXtraGrid
    Public Class MyTileViewInfo
        Inherits TileViewInfo

        Public Sub New(ByVal view As TileView)
            MyBase.New(view)

        End Sub
    End Class
End Namespace
