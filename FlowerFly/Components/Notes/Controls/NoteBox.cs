using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text; 
using System.Windows.Forms;
using FlowerFly.Notes.Models;

namespace FlowerFly.Components.Notes
{
    public partial class NoteBox : UserControl
    {
        public NoteBox()
        {
            InitializeComponent();                        

            

            this.radListView1.ItemSize = new Size(200, 300); 
            this.radListView1.ItemSpacing = 10;

            this.radListView1.ListViewElement.ViewElement.ViewElement.Margin = new Padding(0, 10, 0, 10); 
            this.radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal;

            this.radListView1.VisualItemCreating += radListView1_VisualItemCreating;

            addFakeItems();
        }

        void radListView1_VisualItemCreating(object sender, Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new CustomVisualItem();            
        }

        void addFakeItems()
        {
            List<Note> notes = new List<Note>();
            notes.Add(new Note("Hello", "This is placeholder text for hello message"));
            notes.Add(new Note("Dipu", "Lorem ipsum dolar siet"));
            notes.Add(new Note("Mipu", "This message has no value."));
            notes.Add(new Note("Shiu", "Get outta here"));
            notes.Add(new Note("Rrer", ""));
            notes.Add(new Note("Nimkl", "This is indeed good message."));
            notes.Add(new Note("Pre", "This is placeholder text for hello message. This is indeed good message. This message has no value."));
            notes.Add(new Note("Tipu", "Long message following. Long message following. Long message following. Long message following. Long message following. Long message following. Long message following. Long message following. Long message following. Long message following. Long message following. Long message following..."));
            notes.Add(new Note("Assr", "Utterly nonsensical bla bla bla"));

            radListView1.DataSource = notes;
        }
    }
}
