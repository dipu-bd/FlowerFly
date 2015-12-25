using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using System.Drawing;
using Telerik.WinControls;
using System.Windows.Forms;

namespace FlowerFly.Notes.Models
{
    public class NoteVisualItem : IconListViewVisualItem
    {
        private LightVisualElement contentElement;

        public NoteVisualItem()
        {

        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            contentElement = new LightVisualElement();
            contentElement.TextWrap = true;
            contentElement.Padding = new Padding(7);
            contentElement.TextAlignment = ContentAlignment.MiddleLeft;
            contentElement.BackgroundImage = FlowerFly.Properties.Resources.texture_paper;
            contentElement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            contentElement.MaxSize = new Size(200, 350);
            contentElement.MinSize = new Size(200, 50);

            this.Children.Add(contentElement);

            this.DrawBorder = true;
            this.BorderColor = Color.Goldenrod;
            this.BackColor = Color.PaleGoldenrod;
            this.BorderGradientStyle = GradientStyles.Solid;
        }

        protected override void SynchronizeProperties()
        {
            string title = Convert.ToString(this.Data["Title"]);
            string description = Convert.ToString(this.Data["Description"]);

            if (!string.IsNullOrEmpty(title))
                title = "<size=12><font=Segoe UI Semibold>" + title;

            if (!string.IsNullOrEmpty(description))
                description = "<br><size=9><font=Segoe UI><color=DimGray>" + description;

            contentElement.Text = "<html>" + title + description + "</html>";
        }

        //protected override SizeF MeasureOverride(SizeF availableSize)
        //{
        //    SizeF measuredSize = base.MeasureOverride(availableSize);
        //    this.contentElement.Measure(measuredSize);
        //    return measuredSize;
        //}

        //protected override SizeF ArrangeOverride(SizeF finalSize)
        //{
        //    base.ArrangeOverride(finalSize);
        //    this.contentElement.Arrange(new RectangleF(PointF.Empty, finalSize));
        //    return finalSize;
        //}

        //protected override Type ThemeEffectiveType
        //{
        //    get
        //    {
        //        return typeof(IconListViewVisualItem);
        //    }
        //}

    }
}
