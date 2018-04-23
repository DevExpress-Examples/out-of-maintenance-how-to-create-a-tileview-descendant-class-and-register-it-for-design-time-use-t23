using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraGrid.Views.Tile;

namespace MyXtraGrid
{
    public class MyTileView : TileView
    {
        public MyTileView()
        {
            
        }
        protected override string ViewName { get { return "MyTileView"; } }
    }
}
