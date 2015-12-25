using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using FlowerFly.Models;

namespace FlowerFly.Notes.Models
{
    public class Note : FlyModel
    {
        #region Fields

        private string mContent;
        private List<Category> mCategories;

        #endregion

        #region Initializers

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

        #endregion

        #region Properties

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

        /// <summary>
        /// Gets or sets the back color of the note.
        /// </summary>
        public Color BackColor { get; set; }

        /// <summary>
        /// Gets or sets the category list of the note.
        /// </summary>
        public ReadOnlyCollection<Category> CategoryList
        {
            get { return mCategories.AsReadOnly(); }
        }

        #endregion

        #region Methods

        public void AddCategory(Category category)
        {
            if (!mCategories.Contains(category))
            {
                mCategories.Add(category);
                category.AddNote(this);
            }
        }

        #endregion

    }
}
