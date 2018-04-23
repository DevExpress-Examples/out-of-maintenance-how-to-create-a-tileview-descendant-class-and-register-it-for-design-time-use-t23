using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyXtraGrid
{
    public class MyTileViewInfoRegistrator : TileViewInfoRegistrator
    {
        public override string ViewName { get { return "MyTileView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyTileView(); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyTileViewInfo(view as MyTileView); }
    }
}
