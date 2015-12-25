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
    public class CustomVisualItem : IconListViewVisualItem
    {
        private StackLayoutPanel stackLayout;
        private RadLineItem radLineItem;
        private LightVisualElement titleElement;
        private LightVisualElement contentElement;

        public CustomVisualItem()
        {

        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            stackLayout = new StackLayoutPanel();
            stackLayout.Orientation = System.Windows.Forms.Orientation.Vertical;

            titleElement = new LightVisualElement();
            titleElement.TextAlignment = ContentAlignment.MiddleLeft;
            titleElement.Margin = new Padding(5, 3, 5, 0);
            titleElement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, FontStyle.Regular);
            stackLayout.Children.Add(titleElement);

            radLineItem = new RadLineItem();
            radLineItem.Margin = new Padding(3, 1, 5, 1);
            radLineItem.LineColor = Color.Goldenrod;
            radLineItem.Opacity = 0.8;
            stackLayout.Children.Add(radLineItem);

            contentElement = new LightVisualElement();
            contentElement.TextAlignment = ContentAlignment.TopLeft;
            contentElement.TextWrap = true;
            contentElement.Margin = new Padding(5, 3, 3, 3);
            contentElement.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular);
            contentElement.ShouldApplyTheme = true;
            stackLayout.Children.Add(contentElement);

            this.Children.Add(stackLayout);

            this.Padding = new Padding(3);
            this.DrawBorder = true;
            this.DrawFill = true;
            this.BackColor = Color.PaleGoldenrod;
            this.GradientStyle = GradientStyles.Linear;
            this.BorderColor = Color.Goldenrod;
            this.BorderGradientStyle = GradientStyles.Solid;
        }

        protected override void SynchronizeProperties()
        {
            this.titleElement.Text = Convert.ToString(this.Data["Title"]);
            this.contentElement.Text = Convert.ToString(this.Data["Description"]);
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF measuredSize = base.MeasureOverride(availableSize);
            this.stackLayout.Measure(measuredSize);
            return measuredSize;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);
            this.stackLayout.Arrange(new RectangleF(PointF.Empty, finalSize));
            return finalSize;
        }
         
        //protected override Type ThemeEffectiveType
        //{
        //    get
        //    {
        //        return typeof(IconListViewVisualItem);
        //    }
        //}

    }
}
