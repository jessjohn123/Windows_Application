using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace TileEditorSkeleton
{
    public partial class Form1 : Form
    {
        // The current tile set.
        Bitmap bitmap = Properties.Resources._default;

        // Width and height of the current tile set in tiles.
        Size tileSetSize = new Size(4, 2);

        // Width and height of a single tile in pixels.
        Size tileSize = new Size(64, 64);

        // The current map.
        Tile[,] map = new Tile[10,10];

        // Width and height of the current map in tiles.
        Size mapSize = new Size(10,10);

        // The currently selected tile.
        Tile selectedTile;

        Point Selected = Point.Empty;
        TileSizeEdit toolWindow = null;
        Size Panel2Map = Size.Empty;
        
        public Form1()
        {
            InitializeComponent();

            Graphics g = graphicsPanel1.CreateGraphics();
            bitmap.SetResolution(g.DpiX, g.DpiY);
            g.Dispose();
            
            tileSetSize.Height = bitmap.Size.Height / 64;
            tileSetSize.Width = bitmap.Size.Width / 64;

            g = graphicsPanel2.CreateGraphics();
            bitmap.SetResolution(g.DpiX, g.DpiY);
            g.Dispose();

            graphicsPanel1.AutoScrollMinSize = bitmap.Size;
            Panel2Map.Height = tileSize.Height * mapSize.Height;
            Panel2Map.Width = tileSize.Width * mapSize.Width;
            graphicsPanel2.AutoScrollMinSize = Panel2Map;
        }

        /// <summary>
        /// Handles the Paint event of the splitContainer1.Panel1 control.
        /// </summary>
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, new Point(0, 0));

            //// Iterate through all the tiles in the map.
            //for (int x = 0; x < tileSetSize.Width; x++)
            //{
            //    for (int y = 0; y < tileSetSize.Height; y++)
            //    {
            //        // Calculate where the tile is going to be drawn in the map.
            //        Rectangle destRect = Rectangle.Empty;
            //        destRect.X = x * tileSize.Width;
            //        destRect.Y = y * tileSize.Height;
            //        destRect.Size = tileSize;

            //        // Draw the grid.
            //        e.Graphics.DrawRectangle(Pens.Black, destRect);
            //    }
            //}
            //for (int x = 0; x < tileSetSize.Width; x++)
            //{
            //    for (int y = 0; y < tileSetSize.Height; y++)
            //    {
                    
            //        Rectangle destRect = Rectangle.Empty;
            //        destRect.X = x * tileSize.Width;
            //        destRect.Y = y * tileSize.Height;
            //        destRect.Size = tileSize;

            //        // Draw the grid.
            //        if (destRect.Contains(Selected))
            //        {
            //            e.Graphics.DrawRectangle(Pens.Red, destRect);
            //            break;
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the splitContainer1.Panel1 control.
        /// </summary>
        private void splitContainer1_Panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //// Calculate the selected tile.
            //selectedTile.X = e.X / tileSize.Width;
            //selectedTile.Y = e.Y / tileSize.Height;

            //Selected.X = e.X;
            //Selected.Y = e.Y;

            //graphicsPanel1.Invalidate();
        }

        /// <summary>
        /// Handles the Paint event of the splitContainer1.Panel2 control.
        /// </summary>
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //// Iterate through all the tiles in the map.
            //for (int x = 0; x < mapSize.Width; x++)
            //{
            //    for (int y = 0; y < mapSize.Height; y++)
            //    {
            //        // Calculate where the tile is going to be drawn in the map.
            //        Rectangle destRect = Rectangle.Empty;
            //        destRect.X = x * tileSize.Width;
            //        destRect.Y = y * tileSize.Height;
            //        destRect.Size = tileSize;

            //        // Calculate where the tile is in the bitmap.
            //        Rectangle srcRect = Rectangle.Empty;
            //        srcRect.X = map[x, y].X * tileSize.Width;
            //        srcRect.Y = map[x, y].Y * tileSize.Height;
            //        srcRect.Size = tileSize;

            //        // Draw the tile.
            //        e.Graphics.DrawImage(bitmap, destRect, srcRect, GraphicsUnit.Pixel);
                    
                        
            //        // Draw the grid.
            //        e.Graphics.DrawRectangle(Pens.Black, destRect);
            //    }
            //}
        }

        /// <summary>
        /// Handles the MouseClick event of the splitContainer1.Panel2 control.
        /// </summary>
        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //// Calculate the tile in which the mouse click occured.
            //int x = e.X / tileSize.Width;
            //int y = e.Y / tileSize.Height;

            //// Set the selected tile in the map.
            //map[x, y] = selectedTile;

            //graphicsPanel2.Invalidate();
        }

        private void importTileSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All Files(*.*)|*.*|My Files(*.bmp)|*.bmp";
            dlg.DefaultExt = "bmp";

            if (DialogResult.OK == dlg.ShowDialog())
            {

                Bitmap picture = new Bitmap(dlg.FileName);

                bitmap = picture;
                
                Graphics g = graphicsPanel1.CreateGraphics();
                bitmap.SetResolution(g.DpiX, g.DpiY);
                g.Dispose();

                tileSetSize.Width = picture.Width / 64;
                tileSetSize.Height = picture.Height / 64;
                graphicsPanel1.AutoScrollMinSize = bitmap.Size;

                graphicsPanel1.Invalidate();
                graphicsPanel2.Invalidate();
                
            }
            //graphicsPanel1.AutoScrollPosition = bitmap.Size;
            dlg.Dispose();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolWindow == null)
            {
                toolWindow = new TileSizeEdit();

                toolWindow.TileSizeEdit_MapSize_Height = mapSize.Height;
                toolWindow.TileSizeEdit_MapSize_Width = mapSize.Width;

                toolWindow.TileSizeEdit_TileSet_Height = tileSetSize.Height;
                toolWindow.TileSizeEdit_TileSet_Width = tileSetSize.Width;

                toolWindow.TileSizeEdit_TileSize_Height = tileSize.Height;
                toolWindow.TileSizeEdit_TileSize_Width = tileSize.Width;


                toolWindow.FormClosed += toolWindow_FormClosed;
                toolWindow.Update += toolWindow_Update;

                toolWindow.Show(this);

            }
        }

        void toolWindow_Update(object sender, EventArgs e)
        {
            mapSize.Height = (int)toolWindow.TileSizeEdit_MapSize_Height;
            mapSize.Width = (int)toolWindow.TileSizeEdit_MapSize_Width;

            map = new Tile[(int)toolWindow.TileSizeEdit_MapSize_Width, (int)toolWindow.TileSizeEdit_MapSize_Width];

            Panel2Map.Height = tileSize.Height * mapSize.Height;
            Panel2Map.Width = tileSize.Width * mapSize.Width;
            graphicsPanel2.AutoScrollMinSize = Panel2Map;
            
            tileSetSize.Height = (int)toolWindow.TileSizeEdit_TileSet_Height;
            tileSetSize.Width = (int)toolWindow.TileSizeEdit_TileSet_Width;

            tileSize.Height = (int)toolWindow.TileSizeEdit_TileSize_Height;
            tileSize.Width = (int)toolWindow.TileSizeEdit_TileSize_Width;

            graphicsPanel2.Invalidate();
            graphicsPanel1.Invalidate();

        }

        void toolWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolWindow = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
           
            //Calc where normally drawn if not scrolled
            Point offset = new Point(0, 0);

            // Add AutoScrollPosition
            offset.X += graphicsPanel1.AutoScrollPosition.X;
            offset.Y += graphicsPanel1.AutoScrollPosition.Y;
            
            e.Graphics.DrawImage(bitmap, offset);

            // Iterate through all the tiles in the map.
            for (int x = 0; x < tileSetSize.Width; x++)
            {
                for (int y = 0; y < tileSetSize.Height; y++)
                {
                    
                    // Calculate where the tile is going to be drawn in the map.
                    Rectangle destRect = Rectangle.Empty;
                    destRect.X = x * tileSize.Width + offset.X;
                    destRect.Y = y * tileSize.Height + offset.Y;
                    destRect.Size = tileSize;

                    // Draw the grid.
                    e.Graphics.DrawRectangle(Pens.Black, destRect);
                }
            }

            //for (int x = 0; x < tileSetSize.Width; x++)
            //{
            //    for (int y = 0; y < tileSetSize.Height; y++)
            //    {

            //        Rectangle destRect = Rectangle.Empty;
            //        destRect.X = x * tileSize.Width;
            //        destRect.Y = y * tileSize.Height;
            //        destRect.Size = tileSize;

            //        // Draw the grid.
            //        //if (destRect.Contains(Selected))
            //        //{
                       
            //            break;
            //       // }
            //    }
            //}

            Pen pen = new Pen(Color.Red,5);
            //e.Graphics.DrawRectangle(Pens.Red, destRect);
            e.Graphics.DrawRectangle(pen, new Rectangle((selectedTile.X * tileSize.Width) + offset.X, 
                (selectedTile.Y * tileSize.Height) + offset.Y, tileSize.Height, tileSize.Width));
        }

        private void graphicsPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Calc where normally drawn if not scrolled
            Point offset = new Point(0, 0);

            // Add AutoScrollPosition
            offset.X -= graphicsPanel1.AutoScrollPosition.X;
            offset.Y -= graphicsPanel1.AutoScrollPosition.Y;

            int x = (e.X + offset.X) / tileSize.Width;
            int y = (e.Y + offset.Y) / tileSize.Height;
            // Calculate the selected tile.
            //selectedTile.X = (e.X) / tileSize.Width;
            //selectedTile.Y = (e.Y) / tileSize.Height;

            if (x < tileSetSize.Width && y < tileSetSize.Height)
            {
                selectedTile.X = x;
                selectedTile.Y = y;
            }

            Selected.X = e.X;
            Selected.Y = e.Y;

            graphicsPanel1.Invalidate();
        }

        private void graphicsPanel2_Paint(object sender, PaintEventArgs e)
        {
            


            // Iterate through all the tiles in the map.
            for (int x = 0; x < mapSize.Width; x++)
            {
                for (int y = 0; y < mapSize.Height; y++)
                {
                    
                    // Calc where normally drawn if not scrolled
                     Point offset = new Point(0,0);

                    // Add AutoScrollPosition
                    offset.X += graphicsPanel2.AutoScrollPosition.X;
                    offset.Y += graphicsPanel2.AutoScrollPosition.Y;



                    // Calculate where the tile is going to be drawn in the map.
                    Rectangle destRect = Rectangle.Empty;
                    destRect.X = x * tileSize.Width + offset.X;
                    destRect.Y = y * tileSize.Height + offset.Y;
                    destRect.Size = tileSize;

                    // Calculate where the tile is in the bitmap.
                    Rectangle srcRect = Rectangle.Empty;
                    srcRect.X = map[x, y].X * tileSize.Width;
                    srcRect.Y = map[x, y].Y * tileSize.Height;
                    srcRect.Size = tileSize;

                    // Draw the tile.
                    e.Graphics.DrawImage(bitmap, destRect, srcRect, GraphicsUnit.Pixel);


                    // Draw the grid.
                    e.Graphics.DrawRectangle(Pens.Black, destRect);
                }
            }
        }

        private void graphicsPanel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Calc where normally drawn if not scrolled
            Point offset = new Point(0, 0);

            // Add AutoScrollPosition
            offset.X -= graphicsPanel2.AutoScrollPosition.X;
            offset.Y -= graphicsPanel2.AutoScrollPosition.Y;


            // Calculate the tile in which the mouse click occured.
            int x = (e.X + offset.X) / tileSize.Width;
            int y = (e.Y + offset.Y) / tileSize.Height;

            // Set the selected tile in the map.
            if (x < mapSize.Width && y < mapSize.Height)
            {
                map[x, y] = selectedTile;

                graphicsPanel2.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            
            dlg.Filter = "All Files | *.* | csv Files | *.csv";
            dlg.FilterIndex = 2;
            dlg.DefaultExt = "csv";

            if(DialogResult.OK == dlg.ShowDialog())
            {
               //List<Tile> list = new List<Tile>();
               //
               //for (int x = 0; x < mapSize.Width; x++)
			   //{
			   //    for (int y = 0; y < mapSize.Height; y++)
			   //    {
			   //        list.Add(map[x,y]);
			   //    }
			   //}
               StreamWriter writer = new StreamWriter(dlg.FileName);
               //XmlSerializer serializer = new XmlSerializer(list.GetType());
               //serializer.Serialize(writer, list);
               
               writer.WriteLine(mapSize.Width + "," + mapSize.Height + "," + tileSize.Width + "," + 
                   tileSize.Height + "," +tileSetSize.Width +"," +tileSetSize.Height);
               int[] index = new int[mapSize.Width];
               for (int x = 0; x < mapSize.Width; x++)
               {
                   for (int y = 0; y < mapSize.Height; y++)
                   {
                       index[y] = map[y,x].X + (tileSetSize.Width * map[y,x].Y);
                       writer.Write(index[y]+",");
                       if (mapSize.Height - 1 == y)
                       {
                           writer.WriteLine();
                       }
                   }
               }
                writer.Close();


            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All Files | *.* | CSV Files | *.csv";
            dlg.FilterIndex = 2;
            dlg.DefaultExt = "csv";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);
              

                //XmlSerializer serializer = new XmlSerializer(typeof(List<Tile>));
                //
                //List<Tile> list =(List<Tile>) serializer.Deserialize(reader);
                //int i = 0;
                //
                //for (int x = 0; x < mapSize.Width; x++)
                //{
                //    for (int y = 0; y < mapSize.Height; y++)
                //    {
                //        //list.Add(map[x, y]);
                //        map[x, y] = list[i];
                //        i++;
                //    }
                //}
                
                string words = reader.ReadLine();
                string[] split = words.ToString().Split(new char[] { ',' });

                mapSize.Width = int.Parse(split[0]);
                mapSize.Height = int.Parse(split[1]);
                map = new Tile[int.Parse(split[0]) , int.Parse(split[1])];
                
                tileSize.Width = int.Parse(split[2]);
                tileSize.Height = int.Parse(split[3]);

                tileSetSize.Width = int.Parse(split[4]);
                tileSetSize.Height = int.Parse(split[5]);
                int y = 0;
                while (!reader.EndOfStream)
                {

                    string words1 = reader.ReadLine();
                    string[] splitting = words1.ToString().Split(new char[] { ',' });


                    
                    for (int i = 0; i < mapSize.Width; i++)
                    {
                        map[i, y].Y = int.Parse(splitting[i]) / tileSetSize.Width;
                        map[i, y].X = int.Parse(splitting[i]) % tileSetSize.Width;


                        if (i == mapSize.Width - 1)
                            y++;
                    }
                    
                }
                
                graphicsPanel2.Invalidate();
                reader.Close();

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bitmap = Properties.Resources._default;
            Graphics g = graphicsPanel1.CreateGraphics();
            bitmap.SetResolution(g.DpiX, g.DpiY);
            g.Dispose();
            

            tileSetSize.Width = bitmap.Width / 64;
            tileSetSize.Height = bitmap.Height / 64;
            graphicsPanel1.AutoScrollMinSize = bitmap.Size;


            map = new Tile[10, 10];
            tileSetSize = new Size(4, 2);
            tileSize = new Size(64, 64);

            Panel2Map.Height = tileSize.Height * mapSize.Height;
            Panel2Map.Width = tileSize.Width * mapSize.Width;
            graphicsPanel2.AutoScrollMinSize = Panel2Map;

            graphicsPanel1.Invalidate();
            graphicsPanel2.Invalidate();
        }


    }
}
