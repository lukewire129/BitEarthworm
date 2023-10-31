using System.Windows;
using System.Windows.Controls;

namespace BitEarthworm.UI.Units
{
    public class BackgroundGrid : ListBox
    {
        static BackgroundGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BackgroundGrid), new FrameworkPropertyMetadata(typeof(BackgroundGrid)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new Section ();
        }
    }
}
