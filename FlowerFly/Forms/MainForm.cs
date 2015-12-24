using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Windows.Forms;
using Telerik.WinControls;

namespace FlowerFly
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        
        public MainForm()
        {
            InitializeComponent();

            themeManager1.SetTheme(themeManager1.office2010BlackTheme);             
        }
    }
}
