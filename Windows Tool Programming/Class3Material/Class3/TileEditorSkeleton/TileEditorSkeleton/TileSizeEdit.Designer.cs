namespace TileEditorSkeleton
{
    partial class TileSizeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMapWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMapHeight = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTileWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTileHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSetWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSetHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileHeight)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHeight);
            this.groupBox1.Controls.Add(this.labelWidth);
            this.groupBox1.Controls.Add(this.numericUpDownMapHeight);
            this.groupBox1.Controls.Add(this.numericUpDownMapWidth);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MapSize";
            // 
            // numericUpDownMapWidth
            // 
            this.numericUpDownMapWidth.Location = new System.Drawing.Point(58, 17);
            this.numericUpDownMapWidth.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownMapWidth.Name = "numericUpDownMapWidth";
            this.numericUpDownMapWidth.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownMapWidth.TabIndex = 0;
            this.numericUpDownMapWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownMapHeight
            // 
            this.numericUpDownMapHeight.Location = new System.Drawing.Point(58, 46);
            this.numericUpDownMapHeight.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownMapHeight.Name = "numericUpDownMapHeight";
            this.numericUpDownMapHeight.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownMapHeight.TabIndex = 1;
            this.numericUpDownMapHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(8, 19);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(44, 17);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(8, 48);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(49, 17);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownTileHeight);
            this.groupBox2.Controls.Add(this.numericUpDownTileWidth);
            this.groupBox2.Location = new System.Drawing.Point(24, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Size";
            // 
            // numericUpDownTileWidth
            // 
            this.numericUpDownTileWidth.Location = new System.Drawing.Point(58, 22);
            this.numericUpDownTileWidth.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownTileWidth.Name = "numericUpDownTileWidth";
            this.numericUpDownTileWidth.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownTileWidth.TabIndex = 0;
            this.numericUpDownTileWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numericUpDownTileHeight
            // 
            this.numericUpDownTileHeight.Location = new System.Drawing.Point(58, 51);
            this.numericUpDownTileHeight.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownTileHeight.Name = "numericUpDownTileHeight";
            this.numericUpDownTileHeight.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownTileHeight.TabIndex = 1;
            this.numericUpDownTileHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownSetHeight);
            this.groupBox3.Controls.Add(this.numericUpDownSetWidth);
            this.groupBox3.Location = new System.Drawing.Point(24, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TileSet Size";
            // 
            // numericUpDownSetWidth
            // 
            this.numericUpDownSetWidth.Location = new System.Drawing.Point(58, 22);
            this.numericUpDownSetWidth.Name = "numericUpDownSetWidth";
            this.numericUpDownSetWidth.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownSetWidth.TabIndex = 0;
            this.numericUpDownSetWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownSetHeight
            // 
            this.numericUpDownSetHeight.Location = new System.Drawing.Point(58, 51);
            this.numericUpDownSetHeight.Name = "numericUpDownSetHeight";
            this.numericUpDownSetHeight.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownSetHeight.TabIndex = 1;
            this.numericUpDownSetHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.button1_Click);
            this.button2.Leave += new System.EventHandler(this.button2_Click);
            // 
            // TileSizeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(218, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TileSizeEdit";
            this.Text = "TileSizeEdit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileHeight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownMapHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMapWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTileHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownTileWidth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSetHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSetWidth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}