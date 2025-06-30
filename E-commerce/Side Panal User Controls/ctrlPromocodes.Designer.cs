namespace E_commerce.Side_Panal_User_Controls
{
    partial class ctrlPromocodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPromocodes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblRecords = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvPromocodes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblTotalPromocodes = new Bunifu.UI.WinForms.BunifuLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewPromocodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePromocodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewPromocode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocodes)).BeginInit();
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
            this.lblRecords.Location = new System.Drawing.Point(27, 77);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecords.Size = new System.Drawing.Size(153, 19);
            this.lblRecords.TabIndex = 92;
            this.lblRecords.Text = "Total Promocodes:";
            this.lblRecords.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRecords.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvPromocodes
            // 
            this.dgvPromocodes.AllowCustomTheming = false;
            this.dgvPromocodes.AllowUserToAddRows = false;
            this.dgvPromocodes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPromocodes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromocodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromocodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPromocodes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPromocodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromocodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromocodes.ColumnHeadersHeight = 40;
            this.dgvPromocodes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPromocodes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvPromocodes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPromocodes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPromocodes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPromocodes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPromocodes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPromocodes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPromocodes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPromocodes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPromocodes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPromocodes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvPromocodes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPromocodes.CurrentTheme.Name = null;
            this.dgvPromocodes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPromocodes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPromocodes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPromocodes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPromocodes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromocodes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPromocodes.EnableHeadersVisualStyles = false;
            this.dgvPromocodes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPromocodes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPromocodes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPromocodes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPromocodes.Location = new System.Drawing.Point(17, 106);
            this.dgvPromocodes.Name = "dgvPromocodes";
            this.dgvPromocodes.ReadOnly = true;
            this.dgvPromocodes.RowHeadersVisible = false;
            this.dgvPromocodes.RowTemplate.Height = 40;
            this.dgvPromocodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromocodes.Size = new System.Drawing.Size(1106, 376);
            this.dgvPromocodes.TabIndex = 91;
            this.dgvPromocodes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvPromocodes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPromocodes_RowsAdded);
            this.dgvPromocodes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPromocodes_RowsRemoved);
            // 
            // lblTotalPromocodes
            // 
            this.lblTotalPromocodes.AllowParentOverrides = false;
            this.lblTotalPromocodes.AutoEllipsis = false;
            this.lblTotalPromocodes.CursorType = null;
            this.lblTotalPromocodes.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPromocodes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTotalPromocodes.Location = new System.Drawing.Point(189, 77);
            this.lblTotalPromocodes.Name = "lblTotalPromocodes";
            this.lblTotalPromocodes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPromocodes.Size = new System.Drawing.Size(18, 19);
            this.lblTotalPromocodes.TabIndex = 93;
            this.lblTotalPromocodes.Text = "55";
            this.lblTotalPromocodes.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalPromocodes.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPromocodeToolStripMenuItem,
            this.deletePromocodeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 48);
            // 
            // addNewPromocodeToolStripMenuItem
            // 
            this.addNewPromocodeToolStripMenuItem.Image = global::E_commerce.Properties.Resources.plus1;
            this.addNewPromocodeToolStripMenuItem.Name = "addNewPromocodeToolStripMenuItem";
            this.addNewPromocodeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addNewPromocodeToolStripMenuItem.Text = "Add new Promocode";
            this.addNewPromocodeToolStripMenuItem.Click += new System.EventHandler(this.btnAddNewPromocode_Click);
            // 
            // deletePromocodeToolStripMenuItem
            // 
            this.deletePromocodeToolStripMenuItem.Image = global::E_commerce.Properties.Resources.bin1;
            this.deletePromocodeToolStripMenuItem.Name = "deletePromocodeToolStripMenuItem";
            this.deletePromocodeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deletePromocodeToolStripMenuItem.Text = "Delete Promocode";
            this.deletePromocodeToolStripMenuItem.Click += new System.EventHandler(this.deletePromocodeToolStripMenuItem_Click);
            // 
            // btnAddNewPromocode
            // 
            this.btnAddNewPromocode.AllowAnimations = true;
            this.btnAddNewPromocode.AllowMouseEffects = true;
            this.btnAddNewPromocode.AllowToggling = false;
            this.btnAddNewPromocode.AnimationSpeed = 200;
            this.btnAddNewPromocode.AutoGenerateColors = false;
            this.btnAddNewPromocode.AutoRoundBorders = true;
            this.btnAddNewPromocode.AutoSizeLeftIcon = true;
            this.btnAddNewPromocode.AutoSizeRightIcon = true;
            this.btnAddNewPromocode.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPromocode.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewPromocode.BackgroundImage")));
            this.btnAddNewPromocode.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnAddNewPromocode.ButtonText = "Add new Promocode";
            this.btnAddNewPromocode.ButtonTextMarginLeft = 0;
            this.btnAddNewPromocode.ColorContrastOnClick = 45;
            this.btnAddNewPromocode.ColorContrastOnHover = 45;
            this.btnAddNewPromocode.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddNewPromocode.CustomizableEdges = borderEdges1;
            this.btnAddNewPromocode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewPromocode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewPromocode.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewPromocode.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewPromocode.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewPromocode.Font = new System.Drawing.Font("Kelson Sans Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPromocode.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPromocode.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPromocode.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewPromocode.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNewPromocode.IconMarginLeft = 11;
            this.btnAddNewPromocode.IconPadding = 10;
            this.btnAddNewPromocode.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewPromocode.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewPromocode.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewPromocode.IconSize = 25;
            this.btnAddNewPromocode.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.IdleBorderRadius = 39;
            this.btnAddNewPromocode.IdleBorderThickness = 1;
            this.btnAddNewPromocode.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.IdleIconLeftImage = global::E_commerce.Properties.Resources.plus;
            this.btnAddNewPromocode.IdleIconRightImage = null;
            this.btnAddNewPromocode.IndicateFocus = false;
            this.btnAddNewPromocode.Location = new System.Drawing.Point(850, 45);
            this.btnAddNewPromocode.Name = "btnAddNewPromocode";
            this.btnAddNewPromocode.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewPromocode.OnDisabledState.BorderRadius = 1;
            this.btnAddNewPromocode.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewPromocode.OnDisabledState.BorderThickness = 1;
            this.btnAddNewPromocode.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewPromocode.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewPromocode.OnDisabledState.IconLeftImage = null;
            this.btnAddNewPromocode.OnDisabledState.IconRightImage = null;
            this.btnAddNewPromocode.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnAddNewPromocode.onHoverState.BorderRadius = 1;
            this.btnAddNewPromocode.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewPromocode.onHoverState.BorderThickness = 1;
            this.btnAddNewPromocode.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnAddNewPromocode.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPromocode.onHoverState.IconLeftImage = null;
            this.btnAddNewPromocode.onHoverState.IconRightImage = null;
            this.btnAddNewPromocode.OnIdleState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.OnIdleState.BorderRadius = 1;
            this.btnAddNewPromocode.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnAddNewPromocode.OnIdleState.BorderThickness = 1;
            this.btnAddNewPromocode.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPromocode.OnIdleState.IconLeftImage = global::E_commerce.Properties.Resources.plus;
            this.btnAddNewPromocode.OnIdleState.IconRightImage = null;
            this.btnAddNewPromocode.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.OnPressedState.BorderRadius = 1;
            this.btnAddNewPromocode.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewPromocode.OnPressedState.BorderThickness = 1;
            this.btnAddNewPromocode.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewPromocode.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPromocode.OnPressedState.IconLeftImage = null;
            this.btnAddNewPromocode.OnPressedState.IconRightImage = null;
            this.btnAddNewPromocode.Size = new System.Drawing.Size(251, 41);
            this.btnAddNewPromocode.TabIndex = 94;
            this.btnAddNewPromocode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewPromocode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewPromocode.TextMarginLeft = 0;
            this.btnAddNewPromocode.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAddNewPromocode.UseDefaultRadiusAndThickness = true;
            this.btnAddNewPromocode.Click += new System.EventHandler(this.btnAddNewPromocode_Click);
            // 
            // ctrlPromocodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddNewPromocode);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvPromocodes);
            this.Controls.Add(this.lblTotalPromocodes);
            this.Name = "ctrlPromocodes";
            this.Size = new System.Drawing.Size(1141, 688);
            this.Load += new System.EventHandler(this.ctrlPromocodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocodes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewPromocode;
        private Bunifu.UI.WinForms.BunifuLabel lblRecords;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPromocodes;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalPromocodes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewPromocodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePromocodeToolStripMenuItem;
    }
}
