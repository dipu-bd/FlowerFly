using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text; 

namespace FlowerFly.Models.NoteModel
{
    public class Category : FlyModel
    {
        #region Fields

        private List<Note> mNotes = new List<Note>();

        #endregion

        #region Initializers

        /// <summary>
        /// Creates a new category
        /// </summary>
        /// <param name="title">Title of the category</param>
        /// <param name="description">Description of the category</param>
        public Category(string title = "", string description = "")
        {
            this.Title = title;
            this.Description = description;            
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of notes which has this category.
        /// </summary>
        public ReadOnlyCollection<Note> NoteList 
        {
            get { return mNotes.AsReadOnly(); }
        }

        /// <summary>
        /// Gets the number of notes under this category.
        /// </summary>
        public int NoteCount
        {
            get
            {
                return mNotes.Count;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a note to this category.
        /// </summary>
        /// <param name="note"></param>
        public void AddNote(Note note)
        {
            if (!mNotes.Contains(note))
            {
                mNotes.Add(note);
                note.AddCategory(this);
            }
        }

        #endregion

    }
}
