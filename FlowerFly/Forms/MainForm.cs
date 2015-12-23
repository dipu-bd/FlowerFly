using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace FlowerFly
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

            radListControl1.DataSource = themeManager1.GetThemeList();

            radButton1.Click += delegate(object sender, EventArgs e)
            { 
                var item = radListControl1.SelectedItem;
                if (item != null) themeManager1.SetTheme(item.ToString());
            };
        }
    }
}
