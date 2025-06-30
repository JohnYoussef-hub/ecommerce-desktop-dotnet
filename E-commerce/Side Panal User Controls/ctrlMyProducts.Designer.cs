namespace E_commerce.Side_Panal_User_Controls
{
    partial class ctrlMyProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlMyProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblRecords = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvMyProducts = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalProducts = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddNewProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AllowParentOverrides = false;
            this.lblRecords.AutoEllipsis = false;
            this.lblRecords.CursorType = null;
            this.lblRecords.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblRecords.Location = new System.Drawing.Point(19, 45);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecords.Size = new System.Drawing.Size(135, 19);
            this.lblRecords.TabIndex = 88;
            this.lblRecords.Text = "Total Products:";
            this.lblRecords.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRecords.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvMyProducts
            // 
            this.dgvMyProducts.AllowCustomTheming = false;
            this.dgvMyProducts.AllowUserToAddRows = false;
            this.dgvMyProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMyProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMyProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMyProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMyProducts.ColumnHeadersHeight = 40;
            this.dgvMyProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMyProducts.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvMyProducts.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMyProducts.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMyProducts.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMyProducts.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMyProducts.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvMyProducts.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMyProducts.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMyProducts.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvMyProducts.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMyProducts.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvMyProducts.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMyProducts.CurrentTheme.Name = null;
            this.dgvMyProducts.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyProducts.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMyProducts.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMyProducts.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMyProducts.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMyProducts.EnableHeadersVisualStyles = false;
            this.dgvMyProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMyProducts.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMyProducts.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMyProducts.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMyProducts.Location = new System.Drawing.Point(17, 70);
            this.dgvMyProducts.Name = "dgvMyProducts";
            this.dgvMyProducts.ReadOnly = true;
            this.dgvMyProducts.RowHeadersVisible = false;
            this.dgvMyProducts.RowTemplate.Height = 40;
            this.dgvMyProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyProducts.Size = new System.Drawing.Size(1106, 564);
            this.dgvMyProducts.TabIndex = 87;
            this.dgvMyProducts.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvMyProducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMyProducts_RowsAdded);
            this.dgvMyProducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvMyProducts_RowsRemoved);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Image = global::E_commerce.Properties.Resources.pen;
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Image = global::E_commerce.Properties.Resources.bin;
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AllowParentOverrides = false;
            this.lblTotalProducts.AutoEllipsis = false;
            this.lblTotalProducts.CursorType = null;
            this.lblTotalProducts.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTotalProducts.Location = new System.Drawing.Point(157, 45);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalProducts.Size = new System.Drawing.Size(18, 19);
            this.lblTotalProducts.TabIndex = 89;
            this.lblTotalProducts.Text = "55";
            this.lblTotalProducts.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalProducts.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.AllowAnimations = true;
            this.btnAddNewProduct.AllowMouseEffects = true;
            this.btnAddNewProduct.AllowToggling = false;
            this.btnAddNewProduct.AnimationSpeed = 200;
            this.btnAddNewProduct.AutoGenerateColors = false;
            this.btnAddNewProduct.AutoRoundBorders = true;
            this.btnAddNewProduct.AutoSizeLeftIcon = true;
            this.btnAddNewProduct.AutoSizeRightIcon = true;
            this.btnAddNewProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewProduct.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.BackgroundImage")));
            this.btnAddNewProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnAddNewProduct.ButtonText = "Add new product";
            this.btnAddNewProduct.ButtonTextMarginLeft = 0;
            this.btnAddNewProduct.ColorContrastOnClick = 45;
            this.btnAddNewProduct.ColorContrastOnHover = 45;
            this.btnAddNewProduct.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddNewProduct.CustomizableEdges = borderEdges1;
            this.btnAddNewProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Kelson Sans Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNewProduct.IconMarginLeft = 11;
            this.btnAddNewProduct.IconPadding = 10;
            this.btnAddNewProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewProduct.IconSize = 25;
            this.btnAddNewProduct.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.IdleBorderRadius = 39;
            this.btnAddNewProduct.IdleBorderThickness = 1;
            this.btnAddNewProduct.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.IdleIconLeftImage = global::E_commerce.Properties.Resources.plus;
            this.btnAddNewProduct.IdleIconRightImage = null;
            this.btnAddNewProduct.IndicateFocus = false;
            this.btnAddNewProduct.Location = new System.Drawing.Point(886, 15);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewProduct.OnDisabledState.BorderRadius = 1;
            this.btnAddNewProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.OnDisabledState.BorderThickness = 1;
            this.btnAddNewProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewProduct.OnDisabledState.IconLeftImage = null;
            this.btnAddNewProduct.OnDisabledState.IconRightImage = null;
            this.btnAddNewProduct.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnAddNewProduct.onHoverState.BorderRadius = 1;
            this.btnAddNewProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.onHoverState.BorderThickness = 1;
            this.btnAddNewProduct.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnAddNewProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.onHoverState.IconLeftImage = null;
            this.btnAddNewProduct.onHoverState.IconRightImage = null;
            this.btnAddNewProduct.OnIdleState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.OnIdleState.BorderRadius = 1;
            this.btnAddNewProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnAddNewProduct.OnIdleState.BorderThickness = 1;
            this.btnAddNewProduct.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.OnIdleState.IconLeftImage = global::E_commerce.Properties.Resources.plus;
            this.btnAddNewProduct.OnIdleState.IconRightImage = null;
            this.btnAddNewProduct.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.OnPressedState.BorderRadius = 1;
            this.btnAddNewProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewProduct.OnPressedState.BorderThickness = 1;
            this.btnAddNewProduct.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.OnPressedState.IconLeftImage = null;
            this.btnAddNewProduct.OnPressedState.IconRightImage = null;
            this.btnAddNewProduct.Size = new System.Drawing.Size(217, 41);
            this.btnAddNewProduct.TabIndex = 90;
            this.btnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewProduct.TextMarginLeft = 0;
            this.btnAddNewProduct.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAddNewProduct.UseDefaultRadiusAndThickness = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // ctrlMyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvMyProducts);
            this.Controls.Add(this.lblTotalProducts);
            this.Name = "ctrlMyProducts";
            this.Size = new System.Drawing.Size(1141, 688);
            this.Load += new System.EventHandler(this.ctrlMyProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblRecords;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMyProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalProducts;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewProduct;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
    }
}
