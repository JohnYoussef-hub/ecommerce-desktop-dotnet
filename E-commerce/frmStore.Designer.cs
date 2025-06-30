using System.Windows.Forms;

namespace E_commerce
{
    partial class frmStore : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStore));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showProductInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToWishlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWishlist = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel18 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDateTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbUserProfile = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel16 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlManageUsers = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel14 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlSettings = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbSellerSettings = new System.Windows.Forms.PictureBox();
            this.lblSellerSettings = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlPromocodes = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbPromocodes = new System.Windows.Forms.PictureBox();
            this.lblPromocodes = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMyProducts = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbMyProducts = new System.Windows.Forms.PictureBox();
            this.lblMyProducts = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlDashboard = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel9 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel8 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlBalance = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbBalance = new System.Windows.Forms.PictureBox();
            this.lblBalance = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMyOrders = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbMyOrders = new System.Windows.Forms.PictureBox();
            this.lblMyOrders = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlCart = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.lblCart = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlStore = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbStore = new System.Windows.Forms.PictureBox();
            this.lblStore = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSellerSettings)).BeginInit();
            this.pnlPromocodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromocodes)).BeginInit();
            this.pnlMyProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyProducts)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            this.bunifuPanel9.SuspendLayout();
            this.bunifuPanel8.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalance)).BeginInit();
            this.pnlMyOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyOrders)).BeginInit();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            this.pnlStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStore)).BeginInit();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProductInformationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToCartToolStripMenuItem,
            this.addToWishlistToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 76);
            // 
            // showProductInformationToolStripMenuItem
            // 
            this.showProductInformationToolStripMenuItem.Name = "showProductInformationToolStripMenuItem";
            this.showProductInformationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.showProductInformationToolStripMenuItem.Text = "Show Product Information";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // addToCartToolStripMenuItem
            // 
            this.addToCartToolStripMenuItem.Name = "addToCartToolStripMenuItem";
            this.addToCartToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addToCartToolStripMenuItem.Text = "Add to Cart";
            // 
            // addToWishlistToolStripMenuItem
            // 
            this.addToWishlistToolStripMenuItem.Name = "addToWishlistToolStripMenuItem";
            this.addToWishlistToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addToWishlistToolStripMenuItem.Text = "Add to Wishlist";
            // 
            // lblWishlist
            // 
            this.lblWishlist.AllowParentOverrides = false;
            this.lblWishlist.AutoEllipsis = false;
            this.lblWishlist.CursorType = null;
            this.lblWishlist.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWishlist.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblWishlist.Location = new System.Drawing.Point(69, 12);
            this.lblWishlist.Name = "lblWishlist";
            this.lblWishlist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWishlist.Size = new System.Drawing.Size(96, 24);
            this.lblWishlist.TabIndex = 78;
            this.lblWishlist.Text = "WISHLIST";
            this.lblWishlist.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblWishlist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblWishlist.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 3;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Location = new System.Drawing.Point(236, 78);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1141, 688);
            this.pnlMain.TabIndex = 5;
            // 
            // bunifuPanel18
            // 
            this.bunifuPanel18.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel18.BackgroundImage")));
            this.bunifuPanel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel18.BorderRadius = 10;
            this.bunifuPanel18.BorderThickness = 5;
            this.bunifuPanel18.Controls.Add(this.lblDateTime);
            this.bunifuPanel18.Controls.Add(this.pbUserProfile);
            this.bunifuPanel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel18.Location = new System.Drawing.Point(225, 0);
            this.bunifuPanel18.Name = "bunifuPanel18";
            this.bunifuPanel18.ShowBorders = true;
            this.bunifuPanel18.Size = new System.Drawing.Size(1164, 65);
            this.bunifuPanel18.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AllowParentOverrides = false;
            this.lblDateTime.AutoEllipsis = false;
            this.lblDateTime.CursorType = null;
            this.lblDateTime.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateTime.Location = new System.Drawing.Point(18, 22);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateTime.Size = new System.Drawing.Size(90, 19);
            this.lblDateTime.TabIndex = 81;
            this.lblDateTime.Text = "yyyy-MM-dd";
            this.lblDateTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDateTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.AccessibleDescription = "Account";
            this.pbUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserProfile.Image = global::E_commerce.Properties.Resources.account;
            this.pbUserProfile.Location = new System.Drawing.Point(1098, 8);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.Size = new System.Drawing.Size(38, 50);
            this.pbUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserProfile.TabIndex = 80;
            this.pbUserProfile.TabStop = false;
            this.pbUserProfile.Click += new System.EventHandler(this.pbUserProfile_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel16);
            this.bunifuPanel1.Controls.Add(this.pnlManageUsers);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel14);
            this.bunifuPanel1.Controls.Add(this.pnlSettings);
            this.bunifuPanel1.Controls.Add(this.pnlPromocodes);
            this.bunifuPanel1.Controls.Add(this.pnlMyProducts);
            this.bunifuPanel1.Controls.Add(this.pnlDashboard);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel9);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel8);
            this.bunifuPanel1.Controls.Add(this.pnlMyOrders);
            this.bunifuPanel1.Controls.Add(this.pnlCart);
            this.bunifuPanel1.Controls.Add(this.pnlStore);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(225, 779);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuLabel16
            // 
            this.bunifuLabel16.AllowParentOverrides = false;
            this.bunifuLabel16.AutoEllipsis = false;
            this.bunifuLabel16.CursorType = null;
            this.bunifuLabel16.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuLabel16.Location = new System.Drawing.Point(40, 748);
            this.bunifuLabel16.Name = "bunifuLabel16";
            this.bunifuLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel16.Size = new System.Drawing.Size(144, 19);
            this.bunifuLabel16.TabIndex = 81;
            this.bunifuLabel16.Text = "by: john youssef";
            this.bunifuLabel16.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel16.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageUsers.BackgroundImage")));
            this.pnlManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlManageUsers.BorderRadius = 0;
            this.pnlManageUsers.BorderThickness = 0;
            this.pnlManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageUsers.Location = new System.Drawing.Point(0, 678);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.ShowBorders = true;
            this.pnlManageUsers.Size = new System.Drawing.Size(225, 68);
            this.pnlManageUsers.TabIndex = 14;
            this.pnlManageUsers.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // bunifuPanel14
            // 
            this.bunifuPanel14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel14.BackgroundImage")));
            this.bunifuPanel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel14.BorderRadius = 0;
            this.bunifuPanel14.BorderThickness = 0;
            this.bunifuPanel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel14.Location = new System.Drawing.Point(0, 665);
            this.bunifuPanel14.Name = "bunifuPanel14";
            this.bunifuPanel14.ShowBorders = true;
            this.bunifuPanel14.Size = new System.Drawing.Size(225, 13);
            this.bunifuPanel14.TabIndex = 12;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSettings.BackgroundImage")));
            this.pnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlSettings.BorderRadius = 0;
            this.pnlSettings.BorderThickness = 0;
            this.pnlSettings.Controls.Add(this.pbSellerSettings);
            this.pnlSettings.Controls.Add(this.lblSellerSettings);
            this.pnlSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 605);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.ShowBorders = true;
            this.pnlSettings.Size = new System.Drawing.Size(225, 60);
            this.pnlSettings.TabIndex = 11;
            this.pnlSettings.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbSellerSettings
            // 
            this.pbSellerSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSellerSettings.Image = global::E_commerce.Properties.Resources.settingWhite;
            this.pbSellerSettings.Location = new System.Drawing.Point(25, 3);
            this.pbSellerSettings.Name = "pbSellerSettings";
            this.pbSellerSettings.Size = new System.Drawing.Size(35, 40);
            this.pbSellerSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSellerSettings.TabIndex = 81;
            this.pbSellerSettings.TabStop = false;
            // 
            // lblSellerSettings
            // 
            this.lblSellerSettings.AllowParentOverrides = false;
            this.lblSellerSettings.AutoEllipsis = false;
            this.lblSellerSettings.CursorType = null;
            this.lblSellerSettings.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSettings.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSellerSettings.Location = new System.Drawing.Point(68, 10);
            this.lblSellerSettings.Name = "lblSellerSettings";
            this.lblSellerSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSellerSettings.Size = new System.Drawing.Size(96, 24);
            this.lblSellerSettings.TabIndex = 80;
            this.lblSellerSettings.Text = "SETTINGS";
            this.lblSellerSettings.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSellerSettings.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblSellerSettings.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlPromocodes
            // 
            this.pnlPromocodes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlPromocodes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPromocodes.BackgroundImage")));
            this.pnlPromocodes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPromocodes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlPromocodes.BorderRadius = 0;
            this.pnlPromocodes.BorderThickness = 0;
            this.pnlPromocodes.Controls.Add(this.pbPromocodes);
            this.pnlPromocodes.Controls.Add(this.lblPromocodes);
            this.pnlPromocodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPromocodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPromocodes.Location = new System.Drawing.Point(0, 545);
            this.pnlPromocodes.Name = "pnlPromocodes";
            this.pnlPromocodes.ShowBorders = true;
            this.pnlPromocodes.Size = new System.Drawing.Size(225, 60);
            this.pnlPromocodes.TabIndex = 10;
            this.pnlPromocodes.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbPromocodes
            // 
            this.pbPromocodes.BackColor = System.Drawing.Color.Transparent;
            this.pbPromocodes.Image = global::E_commerce.Properties.Resources.promoWhite;
            this.pbPromocodes.Location = new System.Drawing.Point(25, 3);
            this.pbPromocodes.Name = "pbPromocodes";
            this.pbPromocodes.Size = new System.Drawing.Size(35, 40);
            this.pbPromocodes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPromocodes.TabIndex = 81;
            this.pbPromocodes.TabStop = false;
            // 
            // lblPromocodes
            // 
            this.lblPromocodes.AllowParentOverrides = false;
            this.lblPromocodes.AutoEllipsis = false;
            this.lblPromocodes.CursorType = null;
            this.lblPromocodes.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocodes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPromocodes.Location = new System.Drawing.Point(68, 10);
            this.lblPromocodes.Name = "lblPromocodes";
            this.lblPromocodes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPromocodes.Size = new System.Drawing.Size(120, 24);
            this.lblPromocodes.TabIndex = 80;
            this.lblPromocodes.Text = "PROMOCODES";
            this.lblPromocodes.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPromocodes.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblPromocodes.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlMyProducts
            // 
            this.pnlMyProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlMyProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMyProducts.BackgroundImage")));
            this.pnlMyProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMyProducts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlMyProducts.BorderRadius = 0;
            this.pnlMyProducts.BorderThickness = 0;
            this.pnlMyProducts.Controls.Add(this.pbMyProducts);
            this.pnlMyProducts.Controls.Add(this.lblMyProducts);
            this.pnlMyProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMyProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMyProducts.Location = new System.Drawing.Point(0, 485);
            this.pnlMyProducts.Name = "pnlMyProducts";
            this.pnlMyProducts.ShowBorders = true;
            this.pnlMyProducts.Size = new System.Drawing.Size(225, 60);
            this.pnlMyProducts.TabIndex = 9;
            this.pnlMyProducts.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbMyProducts
            // 
            this.pbMyProducts.BackColor = System.Drawing.Color.Transparent;
            this.pbMyProducts.Image = global::E_commerce.Properties.Resources.myproductsWhite;
            this.pbMyProducts.Location = new System.Drawing.Point(25, 3);
            this.pbMyProducts.Name = "pbMyProducts";
            this.pbMyProducts.Size = new System.Drawing.Size(35, 40);
            this.pbMyProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMyProducts.TabIndex = 81;
            this.pbMyProducts.TabStop = false;
            // 
            // lblMyProducts
            // 
            this.lblMyProducts.AllowParentOverrides = false;
            this.lblMyProducts.AutoEllipsis = false;
            this.lblMyProducts.CursorType = null;
            this.lblMyProducts.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProducts.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMyProducts.Location = new System.Drawing.Point(68, 10);
            this.lblMyProducts.Name = "lblMyProducts";
            this.lblMyProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMyProducts.Size = new System.Drawing.Size(132, 24);
            this.lblMyProducts.TabIndex = 80;
            this.lblMyProducts.Text = "MY PRODUCTS";
            this.lblMyProducts.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMyProducts.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblMyProducts.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashboard.BackgroundImage")));
            this.pnlDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlDashboard.BorderRadius = 0;
            this.pnlDashboard.BorderThickness = 0;
            this.pnlDashboard.Controls.Add(this.pbDashboard);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 425);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.ShowBorders = true;
            this.pnlDashboard.Size = new System.Drawing.Size(225, 60);
            this.pnlDashboard.TabIndex = 8;
            this.pnlDashboard.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbDashboard
            // 
            this.pbDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pbDashboard.Image = global::E_commerce.Properties.Resources.dashboardWhite;
            this.pbDashboard.Location = new System.Drawing.Point(27, 7);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(30, 33);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 79;
            this.pbDashboard.TabStop = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AllowParentOverrides = false;
            this.lblDashboard.AutoEllipsis = false;
            this.lblDashboard.CursorType = null;
            this.lblDashboard.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDashboard.Location = new System.Drawing.Point(69, 10);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDashboard.Size = new System.Drawing.Size(108, 24);
            this.lblDashboard.TabIndex = 78;
            this.lblDashboard.Text = "DASHBOARD";
            this.lblDashboard.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDashboard.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDashboard.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // bunifuPanel9
            // 
            this.bunifuPanel9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel9.BackgroundImage")));
            this.bunifuPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel9.BorderRadius = 0;
            this.bunifuPanel9.BorderThickness = 1;
            this.bunifuPanel9.Controls.Add(this.bunifuLabel8);
            this.bunifuPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel9.Location = new System.Drawing.Point(0, 390);
            this.bunifuPanel9.Name = "bunifuPanel9";
            this.bunifuPanel9.ShowBorders = true;
            this.bunifuPanel9.Size = new System.Drawing.Size(225, 35);
            this.bunifuPanel9.TabIndex = 7;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuLabel8.Location = new System.Drawing.Point(58, 0);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(108, 19);
            this.bunifuLabel8.TabIndex = 1;
            this.bunifuLabel8.Text = "for sellers:";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel8
            // 
            this.bunifuPanel8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel8.BackgroundImage")));
            this.bunifuPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel8.BorderRadius = 0;
            this.bunifuPanel8.BorderThickness = 0;
            this.bunifuPanel8.Controls.Add(this.pnlBalance);
            this.bunifuPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel8.Location = new System.Drawing.Point(0, 327);
            this.bunifuPanel8.Name = "bunifuPanel8";
            this.bunifuPanel8.ShowBorders = true;
            this.bunifuPanel8.Size = new System.Drawing.Size(225, 63);
            this.bunifuPanel8.TabIndex = 6;
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBalance.BackgroundImage")));
            this.pnlBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlBalance.BorderRadius = 0;
            this.pnlBalance.BorderThickness = 0;
            this.pnlBalance.Controls.Add(this.pbBalance);
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBalance.Location = new System.Drawing.Point(0, 0);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.ShowBorders = true;
            this.pnlBalance.Size = new System.Drawing.Size(225, 60);
            this.pnlBalance.TabIndex = 12;
            this.pnlBalance.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbBalance
            // 
            this.pbBalance.BackColor = System.Drawing.Color.Transparent;
            this.pbBalance.Image = global::E_commerce.Properties.Resources.moneyWhite;
            this.pbBalance.Location = new System.Drawing.Point(25, 3);
            this.pbBalance.Name = "pbBalance";
            this.pbBalance.Size = new System.Drawing.Size(35, 40);
            this.pbBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBalance.TabIndex = 81;
            this.pbBalance.TabStop = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AllowParentOverrides = false;
            this.lblBalance.AutoEllipsis = false;
            this.lblBalance.CursorType = null;
            this.lblBalance.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBalance.Location = new System.Drawing.Point(68, 10);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBalance.Size = new System.Drawing.Size(84, 24);
            this.lblBalance.TabIndex = 80;
            this.lblBalance.Text = "BALANCE";
            this.lblBalance.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBalance.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblBalance.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlMyOrders
            // 
            this.pnlMyOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlMyOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMyOrders.BackgroundImage")));
            this.pnlMyOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMyOrders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlMyOrders.BorderRadius = 0;
            this.pnlMyOrders.BorderThickness = 0;
            this.pnlMyOrders.Controls.Add(this.pbMyOrders);
            this.pnlMyOrders.Controls.Add(this.lblMyOrders);
            this.pnlMyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMyOrders.Location = new System.Drawing.Point(0, 267);
            this.pnlMyOrders.Name = "pnlMyOrders";
            this.pnlMyOrders.ShowBorders = true;
            this.pnlMyOrders.Size = new System.Drawing.Size(225, 60);
            this.pnlMyOrders.TabIndex = 5;
            this.pnlMyOrders.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbMyOrders
            // 
            this.pbMyOrders.BackColor = System.Drawing.Color.Transparent;
            this.pbMyOrders.Image = global::E_commerce.Properties.Resources.ordersWhite;
            this.pbMyOrders.Location = new System.Drawing.Point(26, 5);
            this.pbMyOrders.Name = "pbMyOrders";
            this.pbMyOrders.Size = new System.Drawing.Size(34, 40);
            this.pbMyOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMyOrders.TabIndex = 79;
            this.pbMyOrders.TabStop = false;
            // 
            // lblMyOrders
            // 
            this.lblMyOrders.AllowParentOverrides = false;
            this.lblMyOrders.AutoEllipsis = false;
            this.lblMyOrders.CursorType = null;
            this.lblMyOrders.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyOrders.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMyOrders.Location = new System.Drawing.Point(69, 12);
            this.lblMyOrders.Name = "lblMyOrders";
            this.lblMyOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMyOrders.Size = new System.Drawing.Size(108, 24);
            this.lblMyOrders.TabIndex = 78;
            this.lblMyOrders.Text = "MY ORDERS";
            this.lblMyOrders.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMyOrders.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblMyOrders.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlCart
            // 
            this.pnlCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCart.BackgroundImage")));
            this.pnlCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlCart.BorderRadius = 0;
            this.pnlCart.BorderThickness = 0;
            this.pnlCart.Controls.Add(this.pbCart);
            this.pnlCart.Controls.Add(this.lblCart);
            this.pnlCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCart.Location = new System.Drawing.Point(0, 207);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.ShowBorders = true;
            this.pnlCart.Size = new System.Drawing.Size(225, 60);
            this.pnlCart.TabIndex = 3;
            this.pnlCart.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbCart
            // 
            this.pbCart.BackColor = System.Drawing.Color.Transparent;
            this.pbCart.Image = global::E_commerce.Properties.Resources.cartWhite;
            this.pbCart.Location = new System.Drawing.Point(26, 3);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(34, 40);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCart.TabIndex = 79;
            this.pbCart.TabStop = false;
            // 
            // lblCart
            // 
            this.lblCart.AllowParentOverrides = false;
            this.lblCart.AutoEllipsis = false;
            this.lblCart.CursorType = null;
            this.lblCart.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCart.Location = new System.Drawing.Point(69, 10);
            this.lblCart.Name = "lblCart";
            this.lblCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCart.Size = new System.Drawing.Size(48, 24);
            this.lblCart.TabIndex = 78;
            this.lblCart.Text = "CART";
            this.lblCart.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblCart.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pnlStore
            // 
            this.pnlStore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStore.BackgroundImage")));
            this.pnlStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pnlStore.BorderRadius = 0;
            this.pnlStore.BorderThickness = 0;
            this.pnlStore.Controls.Add(this.pbStore);
            this.pnlStore.Controls.Add(this.lblStore);
            this.pnlStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStore.Location = new System.Drawing.Point(0, 147);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlStore.ShowBorders = true;
            this.pnlStore.Size = new System.Drawing.Size(225, 60);
            this.pnlStore.TabIndex = 2;
            this.pnlStore.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // pbStore
            // 
            this.pbStore.BackColor = System.Drawing.Color.Transparent;
            this.pbStore.Image = global::E_commerce.Properties.Resources.storeOrange;
            this.pbStore.Location = new System.Drawing.Point(27, 3);
            this.pbStore.Name = "pbStore";
            this.pbStore.Size = new System.Drawing.Size(33, 40);
            this.pbStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStore.TabIndex = 80;
            this.pbStore.TabStop = false;
            // 
            // lblStore
            // 
            this.lblStore.AllowParentOverrides = false;
            this.lblStore.AutoEllipsis = false;
            this.lblStore.CursorType = null;
            this.lblStore.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStore.Location = new System.Drawing.Point(71, 8);
            this.lblStore.Name = "lblStore";
            this.lblStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStore.Size = new System.Drawing.Size(75, 32);
            this.lblStore.TabIndex = 79;
            this.lblStore.Tag = "";
            this.lblStore.Text = "STORE";
            this.lblStore.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStore.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblStore.Click += new System.EventHandler(this.ChangeMainPanal);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel3.BorderRadius = 0;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 112);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(225, 35);
            this.bunifuPanel3.TabIndex = 1;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuLabel3.Location = new System.Drawing.Point(48, 3);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(126, 19);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "for customers:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.pbPersonImage);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(225, 112);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(94, 16);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(43, 47);
            this.bunifuLabel1.TabIndex = 75;
            this.bunifuLabel1.Text = "E - ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonImage.Image = global::E_commerce.Properties.Resources.logo;
            this.pbPersonImage.Location = new System.Drawing.Point(21, 26);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(64, 61);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 74;
            this.pbPersonImage.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(93, 53);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(104, 37);
            this.bunifuLabel2.TabIndex = 76;
            this.bunifuLabel2.Text = "TECHNO";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 779);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.bunifuPanel18);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuPanel18.ResumeLayout(false);
            this.bunifuPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSellerSettings)).EndInit();
            this.pnlPromocodes.ResumeLayout(false);
            this.pnlPromocodes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromocodes)).EndInit();
            this.pnlMyProducts.ResumeLayout(false);
            this.pnlMyProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyProducts)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            this.bunifuPanel9.ResumeLayout(false);
            this.bunifuPanel9.PerformLayout();
            this.bunifuPanel8.ResumeLayout(false);
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalance)).EndInit();
            this.pnlMyOrders.ResumeLayout(false);
            this.pnlMyOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyOrders)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            this.pnlStore.ResumeLayout(false);
            this.pnlStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStore)).EndInit();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPanel pnlStore;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPanel pnlSettings;
        private Bunifu.UI.WinForms.BunifuPanel pnlPromocodes;
        private Bunifu.UI.WinForms.BunifuPanel pnlMyProducts;
        private Bunifu.UI.WinForms.BunifuPanel pnlDashboard;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel9;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel8;
        private Bunifu.UI.WinForms.BunifuPanel pnlMyOrders;
        private Bunifu.UI.WinForms.BunifuPanel pnlCart;
        private System.Windows.Forms.PictureBox pbDashboard;
        private Bunifu.UI.WinForms.BunifuLabel lblDashboard;
        private System.Windows.Forms.PictureBox pbMyOrders;
        private Bunifu.UI.WinForms.BunifuLabel lblMyOrders;
        private System.Windows.Forms.PictureBox pbCart;
        private Bunifu.UI.WinForms.BunifuLabel lblCart;
        private System.Windows.Forms.PictureBox pbStore;
        private Bunifu.UI.WinForms.BunifuLabel lblStore;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private System.Windows.Forms.PictureBox pbSellerSettings;
        private Bunifu.UI.WinForms.BunifuLabel lblSellerSettings;
        private System.Windows.Forms.PictureBox pbPromocodes;
        private Bunifu.UI.WinForms.BunifuLabel lblPromocodes;
        private System.Windows.Forms.PictureBox pbMyProducts;
        private Bunifu.UI.WinForms.BunifuLabel lblMyProducts;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel14;
        private Bunifu.UI.WinForms.BunifuPanel pnlManageUsers;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel16;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel18;
        private PictureBox pbUserProfile;
        private Bunifu.UI.WinForms.BunifuLabel lblDateTime;
        private Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showProductInformationToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem addToCartToolStripMenuItem;
        private ToolStripMenuItem addToWishlistToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuLabel lblWishlist;
        private Bunifu.UI.WinForms.BunifuPanel pnlBalance;
        private PictureBox pbBalance;
        private Bunifu.UI.WinForms.BunifuLabel lblBalance;
    }
}