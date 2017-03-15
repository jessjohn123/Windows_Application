using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileEditorSkeleton
{
    public partial class TileSizeEdit : Form
    {
        public event EventHandler Update;

        public TileSizeEdit()
        {
            InitializeComponent();
            
        }
        private decimal tileSizeEdit_MapSize_Width;

        public decimal TileSizeEdit_MapSize_Width
        {
            get { return numericUpDownMapWidth.Value; }
            set { numericUpDownMapWidth.Value = value; }
        }
        private decimal tileSizeEdit_MapSize_Height;

        public decimal TileSizeEdit_MapSize_Height
        {
            get { return numericUpDownMapHeight.Value; }
            set { numericUpDownMapHeight.Value = value; }
        }

        private decimal tileSizeEdit_TileSet_Width;

        public decimal TileSizeEdit_TileSet_Width
        {
            get { return numericUpDownSetWidth.Value; }
            set { numericUpDownSetWidth.Value = value; }
        }

        private decimal tileSizeEdit_TileSet_Height;

        public decimal TileSizeEdit_TileSet_Height
        {
            get { return numericUpDownSetHeight.Value; }
            set { numericUpDownSetHeight.Value = value; }
        }

        private decimal tileSizeEdit_TileSize_Width;

        public decimal TileSizeEdit_TileSize_Width
        {
            get { return numericUpDownTileWidth.Value; }
            set { numericUpDownTileWidth.Value = value; }
        }

        private decimal tileSizeEdit_TileSize_Height;

        public decimal TileSizeEdit_TileSize_Height
        {
            get { return numericUpDownTileHeight.Value; }
            set { numericUpDownTileHeight.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Update != null)
            {
                Update(this, EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
