Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Tile

Namespace MyXtraGrid
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim image As Image = My.Resources.img
            For i As Integer = 0 To 9
                dataTable1.Rows.Add("Item" & i, image)
            Next i
            myGridControl1.DataSource = dataTable1
            myTileView1.ColumnSet.BackgroundImageColumn = myTileView1.Columns("Column2")
            Dim tileViewItemElement As New TileViewItemElement()
            tileViewItemElement.Column = myTileView1.Columns("Column1")
            tileViewItemElement.ImageBorderColor = System.Drawing.Color.Empty
            tileViewItemElement.Text = "element1"
            myTileView1.TileTemplate.Add(tileViewItemElement)
        End Sub
    End Class
End Namespace
