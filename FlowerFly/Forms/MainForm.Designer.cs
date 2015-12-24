namespace FlowerFly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radMenuComboItem1 = new Telerik.WinControls.UI.RadMenuComboItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.notePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.routinePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.toolPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.linkPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.tweakPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.settingPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.themeManager1 = new FlowerFly.Controllers.ThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.radMenuComboItem1.ComboBoxElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.settingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMenuComboItem1
            // 
            this.radMenuComboItem1.AccessibleDescription = "radMenuComboItem1";
            this.radMenuComboItem1.AccessibleName = "radMenuComboItem1";
            // 
            // 
            // 
            this.radMenuComboItem1.ComboBoxElement.AutoCompleteAppend = null;
            this.radMenuComboItem1.ComboBoxElement.AutoCompleteDataSource = null;
            this.radMenuComboItem1.ComboBoxElement.AutoCompleteSuggest = null;
            this.radMenuComboItem1.ComboBoxElement.DataMember = "";
            this.radMenuComboItem1.ComboBoxElement.DataSource = null;
            this.radMenuComboItem1.ComboBoxElement.DefaultValue = null;
            this.radMenuComboItem1.ComboBoxElement.DisplayMember = "";
            this.radMenuComboItem1.ComboBoxElement.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.Default;
            this.radMenuComboItem1.ComboBoxElement.DropDownAnimationEnabled = true;
            this.radMenuComboItem1.ComboBoxElement.EditableElementText = "";
            this.radMenuComboItem1.ComboBoxElement.EditorElement = this.radMenuComboItem1.ComboBoxElement;
            this.radMenuComboItem1.ComboBoxElement.EditorManager = null;
            this.radMenuComboItem1.ComboBoxElement.Filter = null;
            this.radMenuComboItem1.ComboBoxElement.FilterExpression = "";
            this.radMenuComboItem1.ComboBoxElement.Focusable = true;
            this.radMenuComboItem1.ComboBoxElement.FormatString = "";
            this.radMenuComboItem1.ComboBoxElement.FormattingEnabled = true;
            this.radMenuComboItem1.ComboBoxElement.ItemHeight = 18;
            this.radMenuComboItem1.ComboBoxElement.MaxDropDownItems = 0;
            this.radMenuComboItem1.ComboBoxElement.MaxLength = 65535;
            this.radMenuComboItem1.ComboBoxElement.MaxValue = null;
            this.radMenuComboItem1.ComboBoxElement.MinValue = null;
            this.radMenuComboItem1.ComboBoxElement.NullValue = null;
            this.radMenuComboItem1.ComboBoxElement.OwnerOffset = 0;
            this.radMenuComboItem1.ComboBoxElement.ShowImageInEditorArea = true;
            this.radMenuComboItem1.ComboBoxElement.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            this.radMenuComboItem1.ComboBoxElement.Value = null;
            this.radMenuComboItem1.ComboBoxElement.ValueMember = "";
            this.radMenuComboItem1.Name = "radMenuComboItem1";
            this.radMenuComboItem1.Text = "radMenuComboItem1";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radListControl1
            // 
            this.radListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radListControl1.Location = new System.Drawing.Point(3, 3);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(554, 273);
            this.radListControl1.TabIndex = 0;
            this.radListControl1.Text = "radListControl1";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(447, 282);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Apply Theme";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.notePage);
            this.radPageView1.Controls.Add(this.routinePage);
            this.radPageView1.Controls.Add(this.toolPage);
            this.radPageView1.Controls.Add(this.linkPage);
            this.radPageView1.Controls.Add(this.tweakPage);
            this.radPageView1.Controls.Add(this.settingPage);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.settingPage;
            this.radPageView1.Size = new System.Drawing.Size(584, 361);
            this.radPageView1.TabIndex = 2;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "Office2010Black";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.ItemList;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemDragMode = Telerik.WinControls.UI.PageViewItemDragMode.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemSpacing = 0;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Auto;
            // 
            // notePage
            // 
            this.notePage.ItemSize = new System.Drawing.SizeF(91F, 30F);
            this.notePage.Location = new System.Drawing.Point(12, 40);
            this.notePage.Name = "notePage";
            this.notePage.Size = new System.Drawing.Size(560, 309);
            this.notePage.Text = "Notes";
            this.notePage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // routinePage
            // 
            this.routinePage.ItemSize = new System.Drawing.SizeF(91F, 30F);
            this.routinePage.Location = new System.Drawing.Point(12, 40);
            this.routinePage.Name = "routinePage";
            this.routinePage.Size = new System.Drawing.Size(560, 309);
            this.routinePage.Text = "Routine";
            this.routinePage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolPage
            // 
            this.toolPage.ItemSize = new System.Drawing.SizeF(91F, 30F);
            this.toolPage.Location = new System.Drawing.Point(12, 40);
            this.toolPage.Name = "toolPage";
            this.toolPage.Size = new System.Drawing.Size(560, 309);
            this.toolPage.Text = "Tools";
            this.toolPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkPage
            // 
            this.linkPage.ItemSize = new System.Drawing.SizeF(91F, 30F);
            this.linkPage.Location = new System.Drawing.Point(12, 40);
            this.linkPage.Name = "linkPage";
            this.linkPage.Size = new System.Drawing.Size(560, 309);
            this.linkPage.Text = "Links";
            this.linkPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tweakPage
            // 
            this.tweakPage.ItemSize = new System.Drawing.SizeF(91F, 30F);
            this.tweakPage.Location = new System.Drawing.Point(12, 40);
            this.tweakPage.Name = "tweakPage";
            this.tweakPage.Size = new System.Drawing.Size(560, 309);
            this.tweakPage.Text = "Tweaks";
            this.tweakPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.radListControl1);
            this.settingPage.Controls.Add(this.radButton1);
            this.settingPage.Description = "Configure FlowerFly in your taste";
            this.settingPage.ItemSize = new System.Drawing.SizeF(91F, 30F);
            this.settingPage.Location = new System.Drawing.Point(12, 40);
            this.settingPage.Name = "settingPage";
            this.settingPage.Size = new System.Drawing.Size(560, 309);
            this.settingPage.Text = "Settings";
            this.settingPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingPage.Title = "Settings";
            this.settingPage.ToolTipText = "Configure FlowerFly in your taste";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.radPageView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowerFly - Your own desktop aide";
            ((System.ComponentModel.ISupportInitialize)(this.radMenuComboItem1.ComboBoxElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuComboItem radMenuComboItem1;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Controllers.ThemeManager themeManager1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage notePage;
        private Telerik.WinControls.UI.RadPageViewPage routinePage;
        private Telerik.WinControls.UI.RadPageViewPage toolPage;
        private Telerik.WinControls.UI.RadPageViewPage linkPage;
        private Telerik.WinControls.UI.RadPageViewPage tweakPage;
        private Telerik.WinControls.UI.RadPageViewPage settingPage;
    }
}