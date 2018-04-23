using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.WinExplorer.ViewInfo;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;

namespace MyXtraGrid
{
    public class MyTileViewInfo : TileViewInfo
    {
        public MyTileViewInfo(TileView view)
            : base(view)
        {
            
        }
    }
}
