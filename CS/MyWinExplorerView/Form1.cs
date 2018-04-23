using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MyWinExplorerView.Properties;
using DevExpress.XtraGrid.Views.Tile;

namespace MyXtraGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Resources.img;            
            for (int i = 0; i < 10; i++)
            {
                dataTable1.Rows.Add("Item" + i, image);
            }
            myGridControl1.DataSource = dataTable1;
            myTileView1.ColumnSet.BackgroundImageColumn = myTileView1.Columns["Column2"];
            TileViewItemElement tileViewItemElement = new TileViewItemElement();
            tileViewItemElement.Column = myTileView1.Columns["Column1"];
            tileViewItemElement.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement.Text = "element1";
            myTileView1.TileTemplate.Add(tileViewItemElement);
        }
    }
}
