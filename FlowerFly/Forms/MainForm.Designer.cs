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
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.radMenuComboItem1.ComboBoxElement)).BeginInit();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowerFly - Your own desktop aide";
            ((System.ComponentModel.ISupportInitialize)(this.radMenuComboItem1.ComboBoxElement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuComboItem radMenuComboItem1;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}