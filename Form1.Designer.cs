namespace SM1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mapQueryToolStrip1 = new SharpMap.Forms.ToolBar.MapQueryToolStrip(this.components);
            this.mapVariableLayerToolStrip1 = new SharpMap.Forms.ToolBar.MapVariableLayerToolStrip(this.components);
            this.mapZoomToolStrip1 = new SharpMap.Forms.ToolBar.MapZoomToolStrip(this.components);
            this.mapBox1 = new SharpMap.Forms.MapBox();
            this.mapDigitizeGeometriesToolStrip1 = new SharpMap.Forms.ToolBar.MapDigitizeGeometriesToolStrip(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mapBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(816, 407);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(816, 457);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mapQueryToolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mapVariableLayerToolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mapZoomToolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mapDigitizeGeometriesToolStrip1);
            // 
            // mapQueryToolStrip1
            // 
            this.mapQueryToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mapQueryToolStrip1.Enabled = false;
            this.mapQueryToolStrip1.Location = new System.Drawing.Point(3, 0);
            this.mapQueryToolStrip1.MapControl = this.mapBox1;
            this.mapQueryToolStrip1.Name = "mapQueryToolStrip1";
            this.mapQueryToolStrip1.Size = new System.Drawing.Size(216, 25);
            this.mapQueryToolStrip1.TabIndex = 0;
            // 
            // mapVariableLayerToolStrip1
            // 
            this.mapVariableLayerToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mapVariableLayerToolStrip1.Enabled = false;
            this.mapVariableLayerToolStrip1.Location = new System.Drawing.Point(538, 0);
            this.mapVariableLayerToolStrip1.MapControl = this.mapBox1;
            this.mapVariableLayerToolStrip1.Name = "mapVariableLayerToolStrip1";
            this.mapVariableLayerToolStrip1.Size = new System.Drawing.Size(137, 25);
            this.mapVariableLayerToolStrip1.TabIndex = 1;
            // 
            // mapZoomToolStrip1
            // 
            this.mapZoomToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mapZoomToolStrip1.Enabled = false;
            this.mapZoomToolStrip1.Location = new System.Drawing.Point(224, 0);
            this.mapZoomToolStrip1.MapControl = this.mapBox1;
            this.mapZoomToolStrip1.Name = "mapZoomToolStrip1";
            this.mapZoomToolStrip1.Size = new System.Drawing.Size(314, 25);
            this.mapZoomToolStrip1.TabIndex = 2;
            this.mapZoomToolStrip1.Text = "MapZoomToolStrip";
            // 
            // mapBox1
            // 
            this.mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
            this.mapBox1.BackColor = System.Drawing.Color.White;
            this.mapBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mapBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBox1.FineZoomFactor = 10D;
            this.mapBox1.Location = new System.Drawing.Point(0, 0);
            this.mapBox1.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.AllLayers;
            this.mapBox1.Name = "mapBox1";
            this.mapBox1.QueryGrowFactor = 5F;
            this.mapBox1.QueryLayerIndex = 0;
            this.mapBox1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox1.ShowProgressUpdate = false;
            this.mapBox1.Size = new System.Drawing.Size(816, 407);
            this.mapBox1.TabIndex = 1;
            this.mapBox1.Text = "mapBox1";
            this.mapBox1.WheelZoomMagnitude = -2D;
            // 
            // mapDigitizeGeometriesToolStrip1
            // 
            this.mapDigitizeGeometriesToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mapDigitizeGeometriesToolStrip1.Enabled = false;
            this.mapDigitizeGeometriesToolStrip1.Location = new System.Drawing.Point(675, 0);
            this.mapDigitizeGeometriesToolStrip1.MapControl = null;
            this.mapDigitizeGeometriesToolStrip1.Name = "mapDigitizeGeometriesToolStrip1";
            this.mapDigitizeGeometriesToolStrip1.Size = new System.Drawing.Size(110, 25);
            this.mapDigitizeGeometriesToolStrip1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 457);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private SharpMap.Forms.ToolBar.MapQueryToolStrip mapQueryToolStrip1;
        private SharpMap.Forms.ToolBar.MapVariableLayerToolStrip mapVariableLayerToolStrip1;
        private SharpMap.Forms.ToolBar.MapZoomToolStrip mapZoomToolStrip1;
        private SharpMap.Forms.MapBox mapBox1;
        private SharpMap.Forms.ToolBar.MapDigitizeGeometriesToolStrip mapDigitizeGeometriesToolStrip1;
    }
}

