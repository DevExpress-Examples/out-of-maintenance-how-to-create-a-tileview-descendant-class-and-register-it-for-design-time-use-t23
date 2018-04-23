Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace MyXtraGrid
    <ToolboxItem(True)> _
    Public Class MyGridControl
        Inherits GridControl

        Protected Overrides Function CreateDefaultView() As BaseView
            Return CreateView("MyTileView")
        End Function
        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyTileViewInfoRegistrator())
        End Sub
    End Class
End Namespace
