namespace E_commerce.Returns
{
    partial class frmReturnOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnOrder));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtReason = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnReturn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.lblMainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 68);
            this.panel1.TabIndex = 161;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.lblMainTitle.Location = new System.Drawing.Point(179, 13);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(278, 41);
            this.lblMainTitle.TabIndex = 4;
            this.lblMainTitle.Text = "RETURN ORDER";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(54, 115);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(202, 25);
            this.bunifuLabel1.TabIndex = 162;
            this.bunifuLabel1.Text = "Return Reason* :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtReason
            // 
            this.txtReason.AcceptsReturn = false;
            this.txtReason.AcceptsTab = false;
            this.txtReason.AnimationSpeed = 200;
            this.txtReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtReason.BackColor = System.Drawing.Color.Transparent;
            this.txtReason.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtReason.BackgroundImage")));
            this.txtReason.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtReason.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtReason.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtReason.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtReason.BorderRadius = 1;
            this.txtReason.BorderThickness = 1;
            this.txtReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtReason.DefaultText = "";
            this.txtReason.FillColor = System.Drawing.Color.White;
            this.txtReason.HideSelection = true;
            this.txtReason.IconLeft = null;
            this.txtReason.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.IconPadding = 10;
            this.txtReason.IconRight = null;
            this.txtReason.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.Lines = new string[0];
            this.txtReason.Location = new System.Drawing.Point(272, 115);
            this.txtReason.MaxLength = 32767;
            this.txtReason.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtReason.Modified = false;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReason.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtReason.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReason.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReason.OnIdleState = stateProperties4;
            this.txtReason.Padding = new System.Windows.Forms.Padding(3);
            this.txtReason.PasswordChar = '\0';
            this.txtReason.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtReason.PlaceholderText = "Enter text";
            this.txtReason.ReadOnly = false;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.SelectedText = "";
            this.txtReason.SelectionLength = 0;
            this.txtReason.SelectionStart = 0;
            this.txtReason.ShortcutsEnabled = true;
            this.txtReason.Size = new System.Drawing.Size(347, 142);
            this.txtReason.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtReason.TabIndex = 164;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReason.TextMarginBottom = 0;
            this.txtReason.TextMarginLeft = 3;
            this.txtReason.TextMarginTop = 0;
            this.txtReason.TextPlaceholder = "Enter text";
            this.txtReason.UseSystemPasswordChar = false;
            this.txtReason.WordWrap = true;
            // 
            // btnReturn
            // 
            this.btnReturn.AllowAnimations = true;
            this.btnReturn.AllowMouseEffects = true;
            this.btnReturn.AllowToggling = false;
            this.btnReturn.AnimationSpeed = 200;
            this.btnReturn.AutoGenerateColors = false;
            this.btnReturn.AutoRoundBorders = true;
            this.btnReturn.AutoSizeLeftIcon = true;
            this.btnReturn.AutoSizeRightIcon = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackColor1 = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnReturn.ButtonText = "Return";
            this.btnReturn.ButtonTextMarginLeft = 0;
            this.btnReturn.ColorContrastOnClick = 45;
            this.btnReturn.ColorContrastOnHover = 45;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReturn.CustomizableEdges = borderEdges1;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReturn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReturn.Font = new System.Drawing.Font("Kelson Sans Normal", 18F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReturn.IconMarginLeft = 11;
            this.btnReturn.IconPadding = 10;
            this.btnReturn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReturn.IconSize = 25;
            this.btnReturn.IdleBorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.IdleBorderRadius = 39;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.IdleIconLeftImage = null;
            this.btnReturn.IdleIconRightImage = null;
            this.btnReturn.IndicateFocus = false;
            this.btnReturn.Location = new System.Drawing.Point(480, 324);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.OnDisabledState.BorderRadius = 1;
            this.btnReturn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.OnDisabledState.BorderThickness = 1;
            this.btnReturn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReturn.OnDisabledState.IconLeftImage = null;
            this.btnReturn.OnDisabledState.IconRightImage = null;
            this.btnReturn.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.onHoverState.BorderRadius = 1;
            this.btnReturn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.onHoverState.BorderThickness = 1;
            this.btnReturn.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.onHoverState.IconLeftImage = null;
            this.btnReturn.onHoverState.IconRightImage = null;
            this.btnReturn.OnIdleState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.OnIdleState.BorderRadius = 1;
            this.btnReturn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnReturn.OnIdleState.BorderThickness = 1;
            this.btnReturn.OnIdleState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.OnIdleState.IconLeftImage = null;
            this.btnReturn.OnIdleState.IconRightImage = null;
            this.btnReturn.OnPressedState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.OnPressedState.BorderRadius = 1;
            this.btnReturn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.OnPressedState.BorderThickness = 1;
            this.btnReturn.OnPressedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnReturn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.OnPressedState.IconLeftImage = null;
            this.btnReturn.OnPressedState.IconRightImage = null;
            this.btnReturn.Size = new System.Drawing.Size(124, 41);
            this.btnReturn.TabIndex = 198;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.TextMarginLeft = 0;
            this.btnReturn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReturn.UseDefaultRadiusAndThickness = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmReturnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 390);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReturnOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturnOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainTitle;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtReason;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReturn;
    }
}