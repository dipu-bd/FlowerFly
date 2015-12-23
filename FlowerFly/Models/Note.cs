using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerFly.Models
{
    public class Note : FlyModel
    { 
        private string mContent;  

        /// <summary>
        /// Create a new note.
        /// </summary>
        /// <param name="title">Title of the note.</param>
        /// <param name="description">Description of the note.</param>
        /// <param name="content">Content of the note.</param>
        public Note(string title = "", string description = "", string content = "")
        { 
            Title = title;
            Description = description;
            Content = content; 
        }
     
        /// <summary>
        /// Gets or sets the content of the note.
        /// </summary>
        public string Content
        {
            get { return mContent; }
            set
            {
                mContent = value;
                SetModified();
            }
        }
         
    }
}
