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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.notePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.routinePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.toolPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.linkPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.tweakPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.settingPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.noteBox1 = new FlowerFly.Components.NoteBox();
            this.routineBox1 = new FlowerFly.Components.RoutineBox();
            this.toolBox1 = new FlowerFly.Components.ToolBox();
            this.linkBox1 = new FlowerFly.Components.LinkBox();
            this.tweakBox1 = new FlowerFly.Components.TweakBox();
            this.settingBox1 = new FlowerFly.Components.SettingBox();
            this.themeManager1 = new FlowerFly.Controllers.ThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.notePage.SuspendLayout();
            this.routinePage.SuspendLayout();
            this.toolPage.SuspendLayout();
            this.linkPage.SuspendLayout();
            this.tweakPage.SuspendLayout();
            this.settingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.radPageView1.SelectedPage = this.notePage;
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
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(3);
            // 
            // notePage
            // 
            this.notePage.Controls.Add(this.noteBox1);
            this.notePage.ItemSize = new System.Drawing.SizeF(92F, 30F);
            this.notePage.Location = new System.Drawing.Point(9, 37);
            this.notePage.Name = "notePage";
            this.notePage.Size = new System.Drawing.Size(566, 315);
            this.notePage.Text = "Notes";
            this.notePage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // routinePage
            // 
            this.routinePage.Controls.Add(this.routineBox1);
            this.routinePage.ItemSize = new System.Drawing.SizeF(92F, 30F);
            this.routinePage.Location = new System.Drawing.Point(12, 40);
            this.routinePage.Name = "routinePage";
            this.routinePage.Size = new System.Drawing.Size(560, 309);
            this.routinePage.Text = "Routine";
            this.routinePage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolPage
            // 
            this.toolPage.Controls.Add(this.toolBox1);
            this.toolPage.ItemSize = new System.Drawing.SizeF(92F, 30F);
            this.toolPage.Location = new System.Drawing.Point(12, 40);
            this.toolPage.Name = "toolPage";
            this.toolPage.Size = new System.Drawing.Size(560, 309);
            this.toolPage.Text = "Tools";
            this.toolPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkPage
            // 
            this.linkPage.Controls.Add(this.linkBox1);
            this.linkPage.ItemSize = new System.Drawing.SizeF(92F, 30F);
            this.linkPage.Location = new System.Drawing.Point(12, 40);
            this.linkPage.Name = "linkPage";
            this.linkPage.Size = new System.Drawing.Size(560, 309);
            this.linkPage.Text = "Links";
            this.linkPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tweakPage
            // 
            this.tweakPage.Controls.Add(this.tweakBox1);
            this.tweakPage.ItemSize = new System.Drawing.SizeF(92F, 30F);
            this.tweakPage.Location = new System.Drawing.Point(9, 37);
            this.tweakPage.Name = "tweakPage";
            this.tweakPage.Size = new System.Drawing.Size(566, 315);
            this.tweakPage.Text = "Tweaks";
            this.tweakPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.settingBox1);
            this.settingPage.Description = "Configure FlowerFly in your taste";
            this.settingPage.ItemSize = new System.Drawing.SizeF(92F, 30F);
            this.settingPage.Location = new System.Drawing.Point(12, 40);
            this.settingPage.Name = "settingPage";
            this.settingPage.Size = new System.Drawing.Size(560, 309);
            this.settingPage.Text = "Settings";
            this.settingPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingPage.Title = "Settings";
            this.settingPage.ToolTipText = "Configure FlowerFly in your taste";
            // 
            // noteBox1
            // 
            this.noteBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBox1.Location = new System.Drawing.Point(0, 0);
            this.noteBox1.Name = "noteBox1";
            this.noteBox1.Size = new System.Drawing.Size(566, 315);
            this.noteBox1.TabIndex = 0;
            // 
            // routineBox1
            // 
            this.routineBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routineBox1.Location = new System.Drawing.Point(0, 0);
            this.routineBox1.Name = "routineBox1";
            this.routineBox1.Size = new System.Drawing.Size(560, 309);
            this.routineBox1.TabIndex = 0;
            // 
            // toolBox1
            // 
            this.toolBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBox1.Location = new System.Drawing.Point(0, 0);
            this.toolBox1.Name = "toolBox1";
            this.toolBox1.Size = new System.Drawing.Size(560, 309);
            this.toolBox1.TabIndex = 0;
            // 
            // linkBox1
            // 
            this.linkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkBox1.Location = new System.Drawing.Point(0, 0);
            this.linkBox1.Name = "linkBox1";
            this.linkBox1.Size = new System.Drawing.Size(560, 309);
            this.linkBox1.TabIndex = 0;
            // 
            // tweakBox1
            // 
            this.tweakBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tweakBox1.Location = new System.Drawing.Point(0, 0);
            this.tweakBox1.Name = "tweakBox1";
            this.tweakBox1.Size = new System.Drawing.Size(566, 315);
            this.tweakBox1.TabIndex = 0;
            // 
            // settingBox1
            // 
            this.settingBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingBox1.Location = new System.Drawing.Point(0, 0);
            this.settingBox1.Name = "settingBox1";
            this.settingBox1.Size = new System.Drawing.Size(560, 309);
            this.settingBox1.TabIndex = 0;
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
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowerFly - Your own desktop aide";
            this.ThemeName = "Office2010Black";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.notePage.ResumeLayout(false);
            this.routinePage.ResumeLayout(false);
            this.toolPage.ResumeLayout(false);
            this.linkPage.ResumeLayout(false);
            this.tweakPage.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.NoteBox noteBox1;
        private Components.RoutineBox routineBox1;
        private Components.ToolBox toolBox1;
        private Components.TweakBox tweakBox1;
        private Components.LinkBox linkBox1;
        private Components.SettingBox settingBox1;
        private Controllers.ThemeManager themeManager1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage notePage;
        private Telerik.WinControls.UI.RadPageViewPage routinePage;
        private Telerik.WinControls.UI.RadPageViewPage toolPage;
        private Telerik.WinControls.UI.RadPageViewPage linkPage;
        private Telerik.WinControls.UI.RadPageViewPage tweakPage;
        private Telerik.WinControls.UI.RadPageViewPage settingPage;
    }
}