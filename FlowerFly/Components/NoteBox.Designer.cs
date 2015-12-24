namespace FlowerFly.Components
{
    partial class NoteBox
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.leftSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.rightSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.customShape2 = new Telerik.WinControls.CustomShape(this.components);
            this.object_d507a918_8fdb_473a_81c1_5d22260d8de9 = new Telerik.WinControls.RootRadElement();
            this.object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb = new Telerik.WinControls.RootRadElement();
            this.object_ecc0be87_52cb_44fe_bbec_041c51986d8a = new Telerik.WinControls.RootRadElement();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.categoryPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.timelinePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.categoryList = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitPanel)).BeginInit();
            this.rightSplitPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.categoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.leftSplitPanel);
            this.radSplitContainer1.Controls.Add(this.rightSplitPanel);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.EnableImmediateResize = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Size = new System.Drawing.Size(550, 350);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            this.radSplitContainer1.ThemeName = "Office2010Black";
            ((Telerik.WinControls.UI.SplitterElement)(this.radSplitContainer1.GetChildAt(1).GetChildAt(0))).AutoSize = false;
            // 
            // leftSplitPanel
            // 
            this.leftSplitPanel.Location = new System.Drawing.Point(0, 0);
            this.leftSplitPanel.Name = "leftSplitPanel";
            this.leftSplitPanel.Size = new System.Drawing.Size(350, 350);
            this.leftSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1410257F, 0F);
            this.leftSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(77, 0);
            this.leftSplitPanel.TabIndex = 0;
            this.leftSplitPanel.TabStop = false;
            this.leftSplitPanel.Text = "splitPanel1";
            this.leftSplitPanel.ThemeName = "Office2010Black";
            // 
            // rightSplitPanel
            // 
            this.rightSplitPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightSplitPanel.Location = new System.Drawing.Point(354, 0);
            this.rightSplitPanel.Name = "rightSplitPanel";
            this.rightSplitPanel.Size = new System.Drawing.Size(196, 350);
            this.rightSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1410256F, 0F);
            this.rightSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(-77, 0);
            this.rightSplitPanel.TabIndex = 1;
            this.rightSplitPanel.TabStop = false;
            this.rightSplitPanel.Text = "splitPanel2";
            this.rightSplitPanel.ThemeName = "Office2010Black";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radPageView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radTextBox1.Location = new System.Drawing.Point(3, 3);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Search...";
            this.radTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.radTextBox1.Size = new System.Drawing.Size(190, 23);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.ThemeName = "Office2010Black";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.radTextBox1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(3);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTextBox1.GetChildAt(0).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTextBox1.GetChildAt(0).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTextBox1.GetChildAt(0).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTextBox1.GetChildAt(0).GetChildAt(2))).BottomWidth = 5F;
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // customShape2
            // 
            this.customShape2.AsString = "20,20,200,100:20,20,False,0,0,0,0,0:220,20,False,0,0,0,0,0:220,120,False,0,0,0,0," +
    "0:20,120,False,0,0,0,0,0:";
            // 
            // object_d507a918_8fdb_473a_81c1_5d22260d8de9
            // 
            this.object_d507a918_8fdb_473a_81c1_5d22260d8de9.Name = "object_d507a918_8fdb_473a_81c1_5d22260d8de9";
            this.object_d507a918_8fdb_473a_81c1_5d22260d8de9.StretchHorizontally = true;
            this.object_d507a918_8fdb_473a_81c1_5d22260d8de9.StretchVertically = true;
            // 
            // object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb
            // 
            this.object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb.Name = "object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb";
            this.object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb.StretchHorizontally = true;
            this.object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb.StretchVertically = true;
            // 
            // object_ecc0be87_52cb_44fe_bbec_041c51986d8a
            // 
            this.object_ecc0be87_52cb_44fe_bbec_041c51986d8a.Name = "object_ecc0be87_52cb_44fe_bbec_041c51986d8a";
            this.object_ecc0be87_52cb_44fe_bbec_041c51986d8a.StretchHorizontally = true;
            this.object_ecc0be87_52cb_44fe_bbec_041c51986d8a.StretchVertically = true;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.categoryPage);
            this.radPageView1.Controls.Add(this.timelinePage);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            this.radPageView1.Location = new System.Drawing.Point(3, 32);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.categoryPage;
            this.radPageView1.Size = new System.Drawing.Size(190, 315);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "Office2010Black";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack;
            ((Telerik.WinControls.UI.RadPageViewStackElement)(this.radPageView1.GetChildAt(0))).ItemSelectionMode = Telerik.WinControls.UI.StackViewItemSelectionMode.ContentWithSelected;
            ((Telerik.WinControls.UI.RadPageViewStackElement)(this.radPageView1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(1);
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(1);
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).Text = "Category";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // categoryPage
            // 
            this.categoryPage.Controls.Add(this.categoryList);
            this.categoryPage.ItemSize = new System.Drawing.SizeF(188F, 27F);
            this.categoryPage.Location = new System.Drawing.Point(4, 32);
            this.categoryPage.Name = "categoryPage";
            this.categoryPage.Size = new System.Drawing.Size(182, 251);
            this.categoryPage.Text = "Category";
            // 
            // timelinePage
            // 
            this.timelinePage.ItemSize = new System.Drawing.SizeF(188F, 27F);
            this.timelinePage.Location = new System.Drawing.Point(5, 66);
            this.timelinePage.Name = "timelinePage";
            this.timelinePage.Size = new System.Drawing.Size(180, 244);
            this.timelinePage.Text = "Timeline";
            // 
            // categoryList
            // 
            this.categoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryList.Location = new System.Drawing.Point(0, 0);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(182, 251);
            this.categoryList.TabIndex = 0;
            this.categoryList.Text = "Category List";
            ((Telerik.WinControls.UI.RadListElement)(this.categoryList.GetChildAt(0))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadListElement)(this.categoryList.GetChildAt(0))).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadListElement)(this.categoryList.GetChildAt(0))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadListElement)(this.categoryList.GetChildAt(0))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadListElement)(this.categoryList.GetChildAt(0))).BorderBottomWidth = 0F;
            // 
            // NoteBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSplitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NoteBox";
            this.Size = new System.Drawing.Size(550, 350);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitPanel)).EndInit();
            this.rightSplitPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.categoryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel leftSplitPanel;
        private Telerik.WinControls.UI.SplitPanel rightSplitPanel;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private Telerik.WinControls.CustomShape customShape2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.RootRadElement object_d507a918_8fdb_473a_81c1_5d22260d8de9;
        private Telerik.WinControls.RootRadElement object_c3730bfd_80cb_4b04_8477_dc4177d4a8bb;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage categoryPage;
        private Telerik.WinControls.UI.RadPageViewPage timelinePage;
        private Telerik.WinControls.RootRadElement object_ecc0be87_52cb_44fe_bbec_041c51986d8a;
        private Telerik.WinControls.UI.RadListControl categoryList;
    }
}
