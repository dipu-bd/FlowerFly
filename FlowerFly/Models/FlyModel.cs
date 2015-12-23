using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerFly.Models
{
    public abstract class FlyModel
    {
        private string mTitle;
        private string mDescription;
        private DateTime mLastModified;
        private DateTime mCreationTime;

        public FlyModel()
        {
            mCreationTime = DateTime.Now;
            mLastModified = DateTime.Now;
        }
        
        /// <summary>
        /// Update the last modified time to current date-time.
        /// </summary>
        protected void SetModified()
        {
            mLastModified = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title
        {
            get { return mTitle; }
            set
            {
                mTitle = value;
                SetModified();
            }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get { return mDescription; }
            set
            {
                mDescription = value;
                SetModified();
            }
        }
        
        /// <summary>
        /// Gets the last modified time.
        /// </summary>
        public DateTime LastModified
        {
            get
            {
                return mLastModified;
            }
        }

        /// <summary>
        /// Gets the creation time.
        /// </summary> 
        public DateTime CreationTime
        {
            get
            {
                return mCreationTime;
            }
        }
    }
}
