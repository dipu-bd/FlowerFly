using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace FlowerFly.Components
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

        public void SetTheme(string ThemeName)
        {
            ThemeResolutionService.ApplicationThemeName = ThemeName;
        }

        public void SetTheme(RadThemeComponentBase Theme)
        {
            ThemeResolutionService.ApplicationThemeName = Theme.ThemeName;
        }

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

        public AquaTheme aquaTheme { get; private set; }
        public BreezeTheme breezeTheme { get; private set; }
        public DesertTheme desertTheme { get; private set; }
        public HighContrastBlackTheme highContrastBlackTheme { get; private set; }
        public Office2007BlackTheme office2007BlackTheme { get; private set; }
        public Office2007SilverTheme office2007SilverTheme { get; private set; }
        public Office2010BlackTheme office2010BlackTheme { get; private set; }
        public Office2010BlueTheme office2010BlueTheme { get; private set; }
        public Office2010SilverTheme office2010SilverTheme { get; private set; }
        public Office2013DarkTheme office2013DarkTheme { get; private set; }
        public Office2013LightTheme office2013LightTheme { get; private set; }
        public TelerikMetroBlueTheme telerikMetroBlueTheme { get; private set; }
        public TelerikMetroTheme telerikMetroTheme { get; private set; }
        public TelerikMetroTouchTheme telerikMetroTouchTheme { get; private set; }
        public VisualStudio2012DarkTheme visualStudio2012DarkTheme { get; private set; }
        public VisualStudio2012LightTheme visualStudio2012LightTheme { get; private set; }
        public Windows7Theme windows7Theme { get; private set; }
        public Windows8Theme windows8Theme { get; private set; }

    }
}
