namespace _2._1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imglstTreeView = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tsbtnUp = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsDropView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmenuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPath = new System.Windows.Forms.ToolStrip();
            this.tslblPath = new System.Windows.Forms.ToolStripLabel();
            this.tscmbPath = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnGo = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.tsPath.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listView);
            this.splitContainer.Size = new System.Drawing.Size(982, 556);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imglstTreeView;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(300, 556);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imglstTreeView
            // 
            this.imglstTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTreeView.ImageStream")));
            this.imglstTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTreeView.Images.SetKeyName(0, "this_pc_icon__windows_11__by_satellitedish555_dgv3zid.png");
            this.imglstTreeView.Images.SetKeyName(1, "icons8-floppy-disk-48.png");
            this.imglstTreeView.Images.SetKeyName(2, "icons8-ssd-48.png");
            this.imglstTreeView.Images.SetKeyName(3, "icons8-cd-48.png");
            this.imglstTreeView.Images.SetKeyName(4, "icons8-google-drive-48.png");
            this.imglstTreeView.Images.SetKeyName(5, "icons8-folder-48.png");
            this.imglstTreeView.Images.SetKeyName(6, "icons8-opened-folder-48.png");
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colDateCreated,
            this.colDateModified});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(678, 556);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView_KeyPress);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSize.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date Created";
            this.colDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDateCreated.Width = 100;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date Modified";
            this.colDateModified.Width = 100;
            // 
            // toolbar
            // 
            this.toolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbar.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUp,
            this.tsbtnRefresh,
            this.toolStripSeparator2,
            this.tsbtnCopy,
            this.tsbtnCut,
            this.tsbtnPaste,
            this.tsbtnDelete,
            this.tsDropView});
            this.toolbar.Location = new System.Drawing.Point(0, 60);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(982, 37);
            this.toolbar.Stretch = true;
            this.toolbar.TabIndex = 2;
            this.toolbar.Text = "toolStrip1";
            // 
            // tsbtnUp
            // 
            this.tsbtnUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUp.Image")));
            this.tsbtnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUp.Name = "tsbtnUp";
            this.tsbtnUp.Size = new System.Drawing.Size(62, 34);
            this.tsbtnUp.Text = "Up";
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(92, 34);
            this.tsbtnRefresh.Text = "Refresh";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCopy.Image")));
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(77, 34);
            this.tsbtnCopy.Text = "Copy";
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCut.Image")));
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(65, 34);
            this.tsbtnCut.Text = "Cut";
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPaste.Image")));
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(77, 34);
            this.tsbtnPaste.Text = "Paste";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(87, 34);
            this.tsbtnDelete.Text = "Delete";
            // 
            // tsDropView
            // 
            this.tsDropView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuLarge,
            this.tsmenuSmall,
            this.tsmenuList,
            this.tsmenuDetails});
            this.tsDropView.Image = ((System.Drawing.Image)(resources.GetObject("tsDropView.Image")));
            this.tsDropView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropView.Name = "tsDropView";
            this.tsDropView.Size = new System.Drawing.Size(85, 34);
            this.tsDropView.Text = "View";
            // 
            // tsmenuLarge
            // 
            this.tsmenuLarge.Name = "tsmenuLarge";
            this.tsmenuLarge.Size = new System.Drawing.Size(167, 26);
            this.tsmenuLarge.Text = "Large Icons";
            // 
            // tsmenuSmall
            // 
            this.tsmenuSmall.Name = "tsmenuSmall";
            this.tsmenuSmall.Size = new System.Drawing.Size(167, 26);
            this.tsmenuSmall.Text = "Small Icons";
            // 
            // tsmenuList
            // 
            this.tsmenuList.Name = "tsmenuList";
            this.tsmenuList.Size = new System.Drawing.Size(167, 26);
            this.tsmenuList.Text = "List";
            // 
            // tsmenuDetails
            // 
            this.tsmenuDetails.Name = "tsmenuDetails";
            this.tsmenuDetails.Size = new System.Drawing.Size(167, 26);
            this.tsmenuDetails.Text = "Details";
            // 
            // tsPath
            // 
            this.tsPath.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPath.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPath,
            this.tscmbPath,
            this.tsbtnGo});
            this.tsPath.Location = new System.Drawing.Point(0, 28);
            this.tsPath.Name = "tsPath";
            this.tsPath.Size = new System.Drawing.Size(982, 32);
            this.tsPath.Stretch = true;
            this.tsPath.TabIndex = 3;
            this.tsPath.Text = "toolStrip1";
            // 
            // tslblPath
            // 
            this.tslblPath.Name = "tslblPath";
            this.tslblPath.Size = new System.Drawing.Size(44, 29);
            this.tslblPath.Text = "Path: ";
            // 
            // tscmbPath
            // 
            this.tscmbPath.Name = "tscmbPath";
            this.tscmbPath.Size = new System.Drawing.Size(400, 32);
            // 
            // tsbtnGo
            // 
            this.tsbtnGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGo.Image")));
            this.tsbtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGo.Name = "tsbtnGo";
            this.tsbtnGo.Size = new System.Drawing.Size(59, 29);
            this.tsbtnGo.Text = "GO";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(982, 556);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(982, 653);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsPath);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolbar);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRename,
            this.menuDelete,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "&File";
            // 
            // menuRename
            // 
            this.menuRename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuRename.Name = "menuRename";
            this.menuRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuRename.Size = new System.Drawing.Size(170, 26);
            this.menuRename.Text = "&Rename";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(170, 26);
            this.menuDelete.Text = "&Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(170, 26);
            this.menuExit.Text = "E&xit";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopy,
            this.menuCut,
            this.menuPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "&Edit";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(177, 26);
            this.menuCopy.Text = "&Copy";
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(177, 26);
            this.menuCut.Text = "Cu&t";
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(177, 26);
            this.menuPaste.Text = "&Paste";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLarge,
            this.menuSmall,
            this.menuList,
            this.menuDetails});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(55, 24);
            this.menuView.Text = "&View";
            // 
            // menuLarge
            // 
            this.menuLarge.Name = "menuLarge";
            this.menuLarge.Size = new System.Drawing.Size(167, 26);
            this.menuLarge.Text = "Lar&ge Icons";
            // 
            // menuSmall
            // 
            this.menuSmall.Name = "menuSmall";
            this.menuSmall.Size = new System.Drawing.Size(167, 26);
            this.menuSmall.Text = "S&mall Icons";
            // 
            // menuList
            // 
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(167, 26);
            this.menuList.Text = "&List";
            // 
            // menuDetails
            // 
            this.menuDetails.Name = "menuDetails";
            this.menuDetails.Size = new System.Drawing.Size(167, 26);
            this.menuDetails.Text = "&Details";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(55, 24);
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(133, 26);
            this.menuAbout.Text = "A&bout";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Explorer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.tsPath.ResumeLayout(false);
            this.tsPath.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imglstTreeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton tsbtnUp;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripDropDownButton tsDropView;
        private System.Windows.Forms.ToolStripMenuItem tsmenuLarge;
        private System.Windows.Forms.ToolStripMenuItem tsmenuSmall;
        private System.Windows.Forms.ToolStripMenuItem tsmenuList;
        private System.Windows.Forms.ToolStripMenuItem tsmenuDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip tsPath;
        private System.Windows.Forms.ToolStripLabel tslblPath;
        private System.Windows.Forms.ToolStripComboBox tscmbPath;
        private System.Windows.Forms.ToolStripButton tsbtnGo;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuRename;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuLarge;
        private System.Windows.Forms.ToolStripMenuItem menuSmall;
        private System.Windows.Forms.ToolStripMenuItem menuList;
        private System.Windows.Forms.ToolStripMenuItem menuDetails;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
    }
}

