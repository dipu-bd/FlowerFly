using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlowerFly.Models
{
    public class Link : FlyModel
    {
        private string mUrl; 
        private string mIconPath;

        /// <summary>
        /// Creates a new link.
        /// </summary>
        /// <param name="url">URL of the link</param>
        /// <param name="title">Title of the link</param>
        /// <param name="description">Description of the link</param>
        /// <param name="iconPath">Path to icon of the link</param>
        public Link(string url = "", string title = "", string description = "", string iconPath = null)
        {
            Url = url;
            Title = title;
            Description = description;
            IconPath = iconPath;
        }

        /// <summary>
        /// gets or sets the URL of the link.
        /// </summary>
        public string Url
        {
            get { return mUrl; }
            set
            {
                mUrl = value;
                SetModified();
            }
        }
         
        /// <summary>
        /// Gets or sets the icon path of the link.
        /// </summary>
        public string IconPath
        {
            get { return mIconPath; }
            set
            {
                mIconPath = value;
                SetModified();
            }
        }
    }
}
