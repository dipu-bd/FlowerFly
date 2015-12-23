using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace FlowerFly.Controllers
{
    public class ThemeManager : System.ComponentModel.Component
    {
        public ThemeManager()
        {
            aquaTheme = new AquaTheme();
            breezeTheme = new BreezeTheme();
            desertTheme = new DesertTheme();
            highContrastBlackTheme = new HighContrastBlackTheme();
            office2007BlackTheme = new Office2007BlackTheme();
            office2007SilverTheme = new Office2007SilverTheme();
            office2010BlackTheme = new Office2010BlackTheme();
            office2010BlueTheme = new Office2010BlueTheme();
            office2010SilverTheme = new Office2010SilverTheme();
            office2013DarkTheme = new Office2013DarkTheme();
            office2013LightTheme = new Office2013LightTheme();
            telerikMetroBlueTheme = new TelerikMetroBlueTheme();
            telerikMetroTheme = new TelerikMetroTheme();
            telerikMetroTouchTheme = new TelerikMetroTouchTheme();
            visualStudio2012DarkTheme = new VisualStudio2012DarkTheme();
            visualStudio2012LightTheme = new VisualStudio2012LightTheme();
            windows7Theme = new Windows7Theme();
            windows8Theme = new Windows8Theme();

            ThemeResolutionService.AllowAnimations = true;
        }

        Telerik.WinControls.Themes.AquaTheme aquaTheme;
        Telerik.WinControls.Themes.BreezeTheme breezeTheme;
        Telerik.WinControls.Themes.DesertTheme desertTheme;
        Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme;
        Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme;
        Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme;
        Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme;
        Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme;
        Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme;
        Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme;
        Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme;
        Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme;
        Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme;
        Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme;
        Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme;
        Telerik.WinControls.Themes.Windows7Theme windows7Theme;
        Telerik.WinControls.Themes.Windows8Theme windows8Theme;

        public string[] GetThemeList()
        {
            return new string[] {
                aquaTheme.ThemeName,
                breezeTheme.ThemeName,
                desertTheme.ThemeName,
                highContrastBlackTheme.ThemeName,
                office2007BlackTheme.ThemeName,
                office2007SilverTheme.ThemeName,
                office2010BlackTheme.ThemeName,
                office2010BlueTheme.ThemeName,
                office2010SilverTheme.ThemeName,
                office2013DarkTheme.ThemeName,
                office2013LightTheme.ThemeName,
                telerikMetroBlueTheme.ThemeName,
                telerikMetroTheme.ThemeName,
                telerikMetroTouchTheme.ThemeName,
                visualStudio2012DarkTheme.ThemeName,
                visualStudio2012LightTheme.ThemeName,
                windows7Theme.ThemeName,
                windows8Theme.ThemeName
            };
        }
        
        public void SetTheme(string ThemeName)
        {
            ThemeResolutionService.ApplicationThemeName = ThemeName;
        }
    }
}
