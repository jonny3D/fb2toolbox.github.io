namespace FB2Toolbox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.filesView = new System.Windows.Forms.ListView();
            this.columnBookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBookSequence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBookSequenceNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthorFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthorMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthorLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEncoding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSelectFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.metadataSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.commandContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksImages = new System.Windows.Forms.ImageList(this.components);
            this.messagesTextBox = new System.Windows.Forms.RichTextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderRecursiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearFilesListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameInPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEditBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameAllZIPTofFB2ZIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGuidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCancelProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelectedFilesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            resources.ApplyResources(this.mainSplitContainer.Panel1, "mainSplitContainer.Panel1");
            this.mainSplitContainer.Panel1.Controls.Add(this.filesView);
            // 
            // mainSplitContainer.Panel2
            // 
            resources.ApplyResources(this.mainSplitContainer.Panel2, "mainSplitContainer.Panel2");
            this.mainSplitContainer.Panel2.Controls.Add(this.messagesTextBox);
            this.mainSplitContainer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messagesTextBox_KeyUp);
            // 
            // filesView
            // 
            resources.ApplyResources(this.filesView, "filesView");
            this.filesView.AllowColumnReorder = true;
            this.filesView.AllowDrop = true;
            this.filesView.CheckBoxes = true;
            this.filesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBookTitle,
            this.columnBookSequence,
            this.columnBookSequenceNr,
            this.columnAuthorFirstName,
            this.columnAuthorMiddleName,
            this.columnAuthorLastName,
            this.columnGenre,
            this.columnEncoding,
            this.columnFileSize,
            this.columnVersion});
            this.filesView.ContextMenuStrip = this.contextMenuStrip1;
            this.filesView.FullRowSelect = true;
            this.filesView.HideSelection = false;
            this.filesView.Name = "filesView";
            this.filesView.ShowItemToolTips = true;
            this.filesView.SmallImageList = this.booksImages;
            this.filesView.UseCompatibleStateImageBehavior = false;
            this.filesView.View = System.Windows.Forms.View.Details;
            this.filesView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filesView_ItemCheck);
            this.filesView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.filesView_ItemChecked);
            this.filesView.DragDrop += new System.Windows.Forms.DragEventHandler(this.filesView_DragDrop);
            this.filesView.DragEnter += new System.Windows.Forms.DragEventHandler(this.filesView_DragEnter);
            this.filesView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messagesTextBox_KeyUp);
            // 
            // columnBookTitle
            // 
            resources.ApplyResources(this.columnBookTitle, "columnBookTitle");
            // 
            // columnBookSequence
            // 
            resources.ApplyResources(this.columnBookSequence, "columnBookSequence");
            // 
            // columnBookSequenceNr
            // 
            resources.ApplyResources(this.columnBookSequenceNr, "columnBookSequenceNr");
            // 
            // columnAuthorFirstName
            // 
            resources.ApplyResources(this.columnAuthorFirstName, "columnAuthorFirstName");
            // 
            // columnAuthorMiddleName
            // 
            resources.ApplyResources(this.columnAuthorMiddleName, "columnAuthorMiddleName");
            // 
            // columnAuthorLastName
            // 
            resources.ApplyResources(this.columnAuthorLastName, "columnAuthorLastName");
            // 
            // columnGenre
            // 
            resources.ApplyResources(this.columnGenre, "columnGenre");
            // 
            // columnEncoding
            // 
            resources.ApplyResources(this.columnEncoding, "columnEncoding");
            // 
            // columnFileSize
            // 
            resources.ApplyResources(this.columnFileSize, "columnFileSize");
            // 
            // columnVersion
            // 
            resources.ApplyResources(this.columnVersion, "columnVersion");
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDescriptionToolStripMenuItem,
            this.toolStripSeparator1,
            this.openFileToolStripMenuItem,
            this.openSelectFileMenuItem,
            this.openFolderMenuItem,
            this.toolStripMenuItem2,
            this.metadataSingleToolStripMenuItem,
            this.toolStripMenuItem9,
            this.commandContextToolStripMenuItem,
            this.toolStripMenuItem5,
            this.reloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // viewDescriptionToolStripMenuItem
            // 
            resources.ApplyResources(this.viewDescriptionToolStripMenuItem, "viewDescriptionToolStripMenuItem");
            this.viewDescriptionToolStripMenuItem.Name = "viewDescriptionToolStripMenuItem";
            this.viewDescriptionToolStripMenuItem.Click += new System.EventHandler(this.viewDescriptionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // openFileToolStripMenuItem
            // 
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openSelectFileMenuItem
            // 
            resources.ApplyResources(this.openSelectFileMenuItem, "openSelectFileMenuItem");
            this.openSelectFileMenuItem.Name = "openSelectFileMenuItem";
            this.openSelectFileMenuItem.Click += new System.EventHandler(this.openSelectFileMenuItem_Click);
            // 
            // openFolderMenuItem
            // 
            resources.ApplyResources(this.openFolderMenuItem, "openFolderMenuItem");
            this.openFolderMenuItem.Name = "openFolderMenuItem";
            this.openFolderMenuItem.Click += new System.EventHandler(this.openFolderMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // metadataSingleToolStripMenuItem
            // 
            resources.ApplyResources(this.metadataSingleToolStripMenuItem, "metadataSingleToolStripMenuItem");
            this.metadataSingleToolStripMenuItem.Name = "metadataSingleToolStripMenuItem";
            this.metadataSingleToolStripMenuItem.Click += new System.EventHandler(this.metadataSingleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            // 
            // commandContextToolStripMenuItem
            // 
            resources.ApplyResources(this.commandContextToolStripMenuItem, "commandContextToolStripMenuItem");
            this.commandContextToolStripMenuItem.Name = "commandContextToolStripMenuItem";
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // reloadToolStripMenuItem
            // 
            resources.ApplyResources(this.reloadToolStripMenuItem, "reloadToolStripMenuItem");
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // booksImages
            // 
            this.booksImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("booksImages.ImageStream")));
            this.booksImages.TransparentColor = System.Drawing.Color.Transparent;
            this.booksImages.Images.SetKeyName(0, "Junior Icon 85.png");
            this.booksImages.Images.SetKeyName(1, "Junior Icon 89.png");
            this.booksImages.Images.SetKeyName(2, "Junior Icon 96.png");
            // 
            // messagesTextBox
            // 
            resources.ApplyResources(this.messagesTextBox, "messagesTextBox");
            this.messagesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.ShowSelectionMargin = true;
            // 
            // menuMain
            // 
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.addFolderRecursiveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearFilesListMenuItem,
            this.clearLogOnlyToolStripMenuItem,
            this.toolStripMenuItem4,
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // addFilesToolStripMenuItem
            // 
            resources.ApplyResources(this.addFilesToolStripMenuItem, "addFilesToolStripMenuItem");
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            resources.ApplyResources(this.addFolderToolStripMenuItem, "addFolderToolStripMenuItem");
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Tag = "false";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // addFolderRecursiveToolStripMenuItem
            // 
            resources.ApplyResources(this.addFolderRecursiveToolStripMenuItem, "addFolderRecursiveToolStripMenuItem");
            this.addFolderRecursiveToolStripMenuItem.Name = "addFolderRecursiveToolStripMenuItem";
            this.addFolderRecursiveToolStripMenuItem.Tag = "true";
            this.addFolderRecursiveToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // clearFilesListMenuItem
            // 
            resources.ApplyResources(this.clearFilesListMenuItem, "clearFilesListMenuItem");
            this.clearFilesListMenuItem.Name = "clearFilesListMenuItem";
            this.clearFilesListMenuItem.Click += new System.EventHandler(this.clearFilesListMenuItem_Click);
            // 
            // clearLogOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.clearLogOnlyToolStripMenuItem, "clearLogOnlyToolStripMenuItem");
            this.clearLogOnlyToolStripMenuItem.Name = "clearLogOnlyToolStripMenuItem";
            this.clearLogOnlyToolStripMenuItem.Click += new System.EventHandler(this.clearLogOnlyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // checkAllToolStripMenuItem
            // 
            resources.ApplyResources(this.checkAllToolStripMenuItem, "checkAllToolStripMenuItem");
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            resources.ApplyResources(this.uncheckAllToolStripMenuItem, "uncheckAllToolStripMenuItem");
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            resources.ApplyResources(this.actionsToolStripMenuItem, "actionsToolStripMenuItem");
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.copyToToolStripMenuItem,
            this.moveToToolStripMenuItem,
            this.renameInPlaceToolStripMenuItem,
            this.toolStripMenuItem6,
            this.compressToolStripMenuItem,
            this.extractToolStripMenuItem,
            this.toolStripMenuItem8,
            this.toolStripEditBooks,
            this.toolStripSeparator2,
            this.validateToolStripMenuItem,
            this.toolStripMenuItem7,
            this.commandsToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            // 
            // encodeToolStripMenuItem
            // 
            resources.ApplyResources(this.encodeToolStripMenuItem, "encodeToolStripMenuItem");
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // copyToToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToToolStripMenuItem, "copyToToolStripMenuItem");
            this.copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            // 
            // moveToToolStripMenuItem
            // 
            resources.ApplyResources(this.moveToToolStripMenuItem, "moveToToolStripMenuItem");
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            // 
            // renameInPlaceToolStripMenuItem
            // 
            resources.ApplyResources(this.renameInPlaceToolStripMenuItem, "renameInPlaceToolStripMenuItem");
            this.renameInPlaceToolStripMenuItem.Name = "renameInPlaceToolStripMenuItem";
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // compressToolStripMenuItem
            // 
            resources.ApplyResources(this.compressToolStripMenuItem, "compressToolStripMenuItem");
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Click += new System.EventHandler(this.compressToolStripMenuItem_Click);
            // 
            // extractToolStripMenuItem
            // 
            resources.ApplyResources(this.extractToolStripMenuItem, "extractToolStripMenuItem");
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            // 
            // toolStripEditBooks
            // 
            resources.ApplyResources(this.toolStripEditBooks, "toolStripEditBooks");
            this.toolStripEditBooks.Name = "toolStripEditBooks";
            this.toolStripEditBooks.Click += new System.EventHandler(this.toolStripEditBooks_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // validateToolStripMenuItem
            // 
            resources.ApplyResources(this.validateToolStripMenuItem, "validateToolStripMenuItem");
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.validateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // commandsToolStripMenuItem
            // 
            resources.ApplyResources(this.commandsToolStripMenuItem, "commandsToolStripMenuItem");
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            // 
            // otherToolStripMenuItem
            // 
            resources.ApplyResources(this.otherToolStripMenuItem, "otherToolStripMenuItem");
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameAllZIPTofFB2ZIPToolStripMenuItem,
            this.createGuidToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            // 
            // renameAllZIPTofFB2ZIPToolStripMenuItem
            // 
            resources.ApplyResources(this.renameAllZIPTofFB2ZIPToolStripMenuItem, "renameAllZIPTofFB2ZIPToolStripMenuItem");
            this.renameAllZIPTofFB2ZIPToolStripMenuItem.Name = "renameAllZIPTofFB2ZIPToolStripMenuItem";
            this.renameAllZIPTofFB2ZIPToolStripMenuItem.Click += new System.EventHandler(this.renameAllZIPTofFB2ZIPToolStripMenuItem_Click);
            // 
            // createGuidToolStripMenuItem
            // 
            resources.ApplyResources(this.createGuidToolStripMenuItem, "createGuidToolStripMenuItem");
            this.createGuidToolStripMenuItem.Name = "createGuidToolStripMenuItem";
            this.createGuidToolStripMenuItem.Click += new System.EventHandler(this.createGuidToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view1ToolStripMenuItem,
            this.view3ToolStripMenuItem,
            this.view2ToolStripMenuItem,
            this.view4ToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // view1ToolStripMenuItem
            // 
            resources.ApplyResources(this.view1ToolStripMenuItem, "view1ToolStripMenuItem");
            this.view1ToolStripMenuItem.Checked = true;
            this.view1ToolStripMenuItem.CheckOnClick = true;
            this.view1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view1ToolStripMenuItem.Name = "view1ToolStripMenuItem";
            this.view1ToolStripMenuItem.Tag = "0";
            this.view1ToolStripMenuItem.Click += new System.EventHandler(this.view1ToolStripMenuItem_Click);
            // 
            // view3ToolStripMenuItem
            // 
            resources.ApplyResources(this.view3ToolStripMenuItem, "view3ToolStripMenuItem");
            this.view3ToolStripMenuItem.CheckOnClick = true;
            this.view3ToolStripMenuItem.Name = "view3ToolStripMenuItem";
            this.view3ToolStripMenuItem.Tag = "2";
            this.view3ToolStripMenuItem.Click += new System.EventHandler(this.view1ToolStripMenuItem_Click);
            // 
            // view2ToolStripMenuItem
            // 
            resources.ApplyResources(this.view2ToolStripMenuItem, "view2ToolStripMenuItem");
            this.view2ToolStripMenuItem.CheckOnClick = true;
            this.view2ToolStripMenuItem.Name = "view2ToolStripMenuItem";
            this.view2ToolStripMenuItem.Tag = "1";
            this.view2ToolStripMenuItem.Click += new System.EventHandler(this.view1ToolStripMenuItem_Click);
            // 
            // view4ToolStripMenuItem
            // 
            resources.ApplyResources(this.view4ToolStripMenuItem, "view4ToolStripMenuItem");
            this.view4ToolStripMenuItem.Name = "view4ToolStripMenuItem";
            this.view4ToolStripMenuItem.Tag = "3";
            this.view4ToolStripMenuItem.Click += new System.EventHandler(this.view1ToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusCancelProgressLabel,
            this.statusSelectedFilesLabel});
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Spring = true;
            // 
            // statusCancelProgressLabel
            // 
            resources.ApplyResources(this.statusCancelProgressLabel, "statusCancelProgressLabel");
            this.statusCancelProgressLabel.IsLink = true;
            this.statusCancelProgressLabel.Name = "statusCancelProgressLabel";
            this.statusCancelProgressLabel.Click += new System.EventHandler(this.statusCancelProgressLabel_Click);
            // 
            // statusSelectedFilesLabel
            // 
            resources.ApplyResources(this.statusSelectedFilesLabel, "statusSelectedFilesLabel");
            this.statusSelectedFilesLabel.Name = "statusSelectedFilesLabel";
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.Multiselect = true;
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messagesTextBox_KeyUp);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearFilesListMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openSelectFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ImageList booksImages;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem encodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel statusSelectedFilesLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem renameInPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGuidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderRecursiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripStatusLabel statusCancelProgressLabel;
        private System.Windows.Forms.ToolStripMenuItem clearLogOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameAllZIPTofFB2ZIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem viewDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem metadataSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.RichTextBox messagesTextBox;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view4ToolStripMenuItem;
        private System.Windows.Forms.ListView filesView;
        private System.Windows.Forms.ColumnHeader columnBookTitle;
        private System.Windows.Forms.ColumnHeader columnBookSequence;
        private System.Windows.Forms.ColumnHeader columnBookSequenceNr;
        private System.Windows.Forms.ColumnHeader columnAuthorFirstName;
        private System.Windows.Forms.ColumnHeader columnAuthorMiddleName;
        private System.Windows.Forms.ColumnHeader columnAuthorLastName;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnEncoding;
        private System.Windows.Forms.ColumnHeader columnFileSize;
        private System.Windows.Forms.ColumnHeader columnVersion;
    }
}

