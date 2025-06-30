namespace E_commerce.User
{
    partial class frmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblQuantity = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBecomeASeller = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnChangePassword = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEditThePersonalInfo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AllowParentOverrides = false;
            this.lblUsername.AutoEllipsis = false;
            this.lblUsername.CursorType = null;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUsername.Location = new System.Drawing.Point(233, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(94, 23);
            this.lblUsername.TabIndex = 179;
            this.lblUsername.Text = "John618";
            this.lblUsername.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AllowParentOverrides = false;
            this.lblQuantity.AutoEllipsis = false;
            this.lblQuantity.CursorType = null;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblQuantity.Location = new System.Drawing.Point(94, 36);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuantity.Size = new System.Drawing.Size(126, 25);
            this.lblQuantity.TabIndex = 178;
            this.lblQuantity.Text = "Username:";
            this.lblQuantity.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblQuantity.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = true;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.IndianRed;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnLogout.ButtonText = "Log out";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges1;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogout.Font = new System.Drawing.Font("Kelson Sans Normal", 18F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 10;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.IndianRed;
            this.btnLogout.IdleBorderRadius = 39;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.IndianRed;
            this.btnLogout.IdleIconLeftImage = global::E_commerce.Properties.Resources.logout;
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(150, 325);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.OnDisabledState.BorderRadius = 1;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.Brown;
            this.btnLogout.onHoverState.BorderRadius = 1;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.Brown;
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.IndianRed;
            this.btnLogout.OnIdleState.BorderRadius = 1;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.IndianRed;
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnIdleState.IconLeftImage = global::E_commerce.Properties.Resources.logout;
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.IndianRed;
            this.btnLogout.OnPressedState.BorderRadius = 1;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.IndianRed;
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(147, 41);
            this.btnLogout.TabIndex = 183;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBecomeASeller
            // 
            this.btnBecomeASeller.AllowAnimations = true;
            this.btnBecomeASeller.AllowMouseEffects = true;
            this.btnBecomeASeller.AllowToggling = false;
            this.btnBecomeASeller.AnimationSpeed = 200;
            this.btnBecomeASeller.AutoGenerateColors = false;
            this.btnBecomeASeller.AutoRoundBorders = false;
            this.btnBecomeASeller.AutoSizeLeftIcon = true;
            this.btnBecomeASeller.AutoSizeRightIcon = true;
            this.btnBecomeASeller.BackColor = System.Drawing.Color.Transparent;
            this.btnBecomeASeller.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBecomeASeller.BackgroundImage")));
            this.btnBecomeASeller.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBecomeASeller.ButtonText = "Become a Seller";
            this.btnBecomeASeller.ButtonTextMarginLeft = 0;
            this.btnBecomeASeller.ColorContrastOnClick = 45;
            this.btnBecomeASeller.ColorContrastOnHover = 45;
            this.btnBecomeASeller.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnBecomeASeller.CustomizableEdges = borderEdges2;
            this.btnBecomeASeller.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBecomeASeller.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBecomeASeller.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBecomeASeller.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBecomeASeller.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBecomeASeller.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBecomeASeller.ForeColor = System.Drawing.Color.White;
            this.btnBecomeASeller.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBecomeASeller.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBecomeASeller.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBecomeASeller.IconMarginLeft = 11;
            this.btnBecomeASeller.IconPadding = 10;
            this.btnBecomeASeller.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBecomeASeller.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBecomeASeller.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBecomeASeller.IconSize = 25;
            this.btnBecomeASeller.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.IdleBorderRadius = 1;
            this.btnBecomeASeller.IdleBorderThickness = 1;
            this.btnBecomeASeller.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.IdleIconLeftImage = null;
            this.btnBecomeASeller.IdleIconRightImage = null;
            this.btnBecomeASeller.IndicateFocus = false;
            this.btnBecomeASeller.Location = new System.Drawing.Point(104, 241);
            this.btnBecomeASeller.Name = "btnBecomeASeller";
            this.btnBecomeASeller.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBecomeASeller.OnDisabledState.BorderRadius = 1;
            this.btnBecomeASeller.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBecomeASeller.OnDisabledState.BorderThickness = 1;
            this.btnBecomeASeller.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBecomeASeller.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBecomeASeller.OnDisabledState.IconLeftImage = null;
            this.btnBecomeASeller.OnDisabledState.IconRightImage = null;
            this.btnBecomeASeller.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBecomeASeller.onHoverState.BorderRadius = 1;
            this.btnBecomeASeller.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBecomeASeller.onHoverState.BorderThickness = 1;
            this.btnBecomeASeller.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnBecomeASeller.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBecomeASeller.onHoverState.IconLeftImage = null;
            this.btnBecomeASeller.onHoverState.IconRightImage = null;
            this.btnBecomeASeller.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.OnIdleState.BorderRadius = 1;
            this.btnBecomeASeller.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBecomeASeller.OnIdleState.BorderThickness = 1;
            this.btnBecomeASeller.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBecomeASeller.OnIdleState.IconLeftImage = null;
            this.btnBecomeASeller.OnIdleState.IconRightImage = null;
            this.btnBecomeASeller.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.OnPressedState.BorderRadius = 1;
            this.btnBecomeASeller.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBecomeASeller.OnPressedState.BorderThickness = 1;
            this.btnBecomeASeller.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBecomeASeller.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBecomeASeller.OnPressedState.IconLeftImage = null;
            this.btnBecomeASeller.OnPressedState.IconRightImage = null;
            this.btnBecomeASeller.Size = new System.Drawing.Size(233, 33);
            this.btnBecomeASeller.TabIndex = 182;
            this.btnBecomeASeller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBecomeASeller.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBecomeASeller.TextMarginLeft = 0;
            this.btnBecomeASeller.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBecomeASeller.UseDefaultRadiusAndThickness = true;
            this.btnBecomeASeller.Click += new System.EventHandler(this.btnBecomeASeller_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AllowAnimations = true;
            this.btnChangePassword.AllowMouseEffects = true;
            this.btnChangePassword.AllowToggling = false;
            this.btnChangePassword.AnimationSpeed = 200;
            this.btnChangePassword.AutoGenerateColors = false;
            this.btnChangePassword.AutoRoundBorders = false;
            this.btnChangePassword.AutoSizeLeftIcon = true;
            this.btnChangePassword.AutoSizeRightIcon = true;
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.BackgroundImage")));
            this.btnChangePassword.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangePassword.ButtonText = "change password";
            this.btnChangePassword.ButtonTextMarginLeft = 0;
            this.btnChangePassword.ColorContrastOnClick = 45;
            this.btnChangePassword.ColorContrastOnHover = 45;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnChangePassword.CustomizableEdges = borderEdges3;
            this.btnChangePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChangePassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChangePassword.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChangePassword.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChangePassword.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnChangePassword.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnChangePassword.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnChangePassword.IconMarginLeft = 11;
            this.btnChangePassword.IconPadding = 10;
            this.btnChangePassword.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnChangePassword.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnChangePassword.IconSize = 25;
            this.btnChangePassword.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.IdleBorderRadius = 1;
            this.btnChangePassword.IdleBorderThickness = 1;
            this.btnChangePassword.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.IdleIconLeftImage = null;
            this.btnChangePassword.IdleIconRightImage = null;
            this.btnChangePassword.IndicateFocus = false;
            this.btnChangePassword.Location = new System.Drawing.Point(128, 147);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnChangePassword.OnDisabledState.BorderRadius = 1;
            this.btnChangePassword.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangePassword.OnDisabledState.BorderThickness = 1;
            this.btnChangePassword.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChangePassword.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnChangePassword.OnDisabledState.IconLeftImage = null;
            this.btnChangePassword.OnDisabledState.IconRightImage = null;
            this.btnChangePassword.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePassword.onHoverState.BorderRadius = 1;
            this.btnChangePassword.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangePassword.onHoverState.BorderThickness = 1;
            this.btnChangePassword.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePassword.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.onHoverState.IconLeftImage = null;
            this.btnChangePassword.onHoverState.IconRightImage = null;
            this.btnChangePassword.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.OnIdleState.BorderRadius = 1;
            this.btnChangePassword.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangePassword.OnIdleState.BorderThickness = 1;
            this.btnChangePassword.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.OnIdleState.IconLeftImage = null;
            this.btnChangePassword.OnIdleState.IconRightImage = null;
            this.btnChangePassword.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.OnPressedState.BorderRadius = 1;
            this.btnChangePassword.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnChangePassword.OnPressedState.BorderThickness = 1;
            this.btnChangePassword.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnChangePassword.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.OnPressedState.IconLeftImage = null;
            this.btnChangePassword.OnPressedState.IconRightImage = null;
            this.btnChangePassword.Size = new System.Drawing.Size(185, 33);
            this.btnChangePassword.TabIndex = 181;
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangePassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChangePassword.TextMarginLeft = 0;
            this.btnChangePassword.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnChangePassword.UseDefaultRadiusAndThickness = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnEditThePersonalInfo
            // 
            this.btnEditThePersonalInfo.AllowAnimations = true;
            this.btnEditThePersonalInfo.AllowMouseEffects = true;
            this.btnEditThePersonalInfo.AllowToggling = false;
            this.btnEditThePersonalInfo.AnimationSpeed = 200;
            this.btnEditThePersonalInfo.AutoGenerateColors = false;
            this.btnEditThePersonalInfo.AutoRoundBorders = false;
            this.btnEditThePersonalInfo.AutoSizeLeftIcon = true;
            this.btnEditThePersonalInfo.AutoSizeRightIcon = true;
            this.btnEditThePersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnEditThePersonalInfo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditThePersonalInfo.BackgroundImage")));
            this.btnEditThePersonalInfo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditThePersonalInfo.ButtonText = "edit the personal information";
            this.btnEditThePersonalInfo.ButtonTextMarginLeft = 0;
            this.btnEditThePersonalInfo.ColorContrastOnClick = 45;
            this.btnEditThePersonalInfo.ColorContrastOnHover = 45;
            this.btnEditThePersonalInfo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnEditThePersonalInfo.CustomizableEdges = borderEdges4;
            this.btnEditThePersonalInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditThePersonalInfo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEditThePersonalInfo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditThePersonalInfo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditThePersonalInfo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEditThePersonalInfo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditThePersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditThePersonalInfo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditThePersonalInfo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditThePersonalInfo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEditThePersonalInfo.IconMarginLeft = 11;
            this.btnEditThePersonalInfo.IconPadding = 10;
            this.btnEditThePersonalInfo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditThePersonalInfo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditThePersonalInfo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEditThePersonalInfo.IconSize = 25;
            this.btnEditThePersonalInfo.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.IdleBorderRadius = 1;
            this.btnEditThePersonalInfo.IdleBorderThickness = 1;
            this.btnEditThePersonalInfo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.IdleIconLeftImage = null;
            this.btnEditThePersonalInfo.IdleIconRightImage = null;
            this.btnEditThePersonalInfo.IndicateFocus = false;
            this.btnEditThePersonalInfo.Location = new System.Drawing.Point(62, 95);
            this.btnEditThePersonalInfo.Name = "btnEditThePersonalInfo";
            this.btnEditThePersonalInfo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEditThePersonalInfo.OnDisabledState.BorderRadius = 1;
            this.btnEditThePersonalInfo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditThePersonalInfo.OnDisabledState.BorderThickness = 1;
            this.btnEditThePersonalInfo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditThePersonalInfo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditThePersonalInfo.OnDisabledState.IconLeftImage = null;
            this.btnEditThePersonalInfo.OnDisabledState.IconRightImage = null;
            this.btnEditThePersonalInfo.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditThePersonalInfo.onHoverState.BorderRadius = 1;
            this.btnEditThePersonalInfo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditThePersonalInfo.onHoverState.BorderThickness = 1;
            this.btnEditThePersonalInfo.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditThePersonalInfo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditThePersonalInfo.onHoverState.IconLeftImage = null;
            this.btnEditThePersonalInfo.onHoverState.IconRightImage = null;
            this.btnEditThePersonalInfo.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.OnIdleState.BorderRadius = 1;
            this.btnEditThePersonalInfo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditThePersonalInfo.OnIdleState.BorderThickness = 1;
            this.btnEditThePersonalInfo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEditThePersonalInfo.OnIdleState.IconLeftImage = null;
            this.btnEditThePersonalInfo.OnIdleState.IconRightImage = null;
            this.btnEditThePersonalInfo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.OnPressedState.BorderRadius = 1;
            this.btnEditThePersonalInfo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEditThePersonalInfo.OnPressedState.BorderThickness = 1;
            this.btnEditThePersonalInfo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditThePersonalInfo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEditThePersonalInfo.OnPressedState.IconLeftImage = null;
            this.btnEditThePersonalInfo.OnPressedState.IconRightImage = null;
            this.btnEditThePersonalInfo.Size = new System.Drawing.Size(316, 33);
            this.btnEditThePersonalInfo.TabIndex = 180;
            this.btnEditThePersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditThePersonalInfo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditThePersonalInfo.TextMarginLeft = 0;
            this.btnEditThePersonalInfo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEditThePersonalInfo.UseDefaultRadiusAndThickness = true;
            this.btnEditThePersonalInfo.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 394);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBecomeASeller);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnEditThePersonalInfo);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserProfile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblUsername;
        private Bunifu.UI.WinForms.BunifuLabel lblQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditThePersonalInfo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChangePassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBecomeASeller;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
    }
}