using System.Windows;
using System.Windows.Controls;

namespace BitEarthworm.UI.Units
{
    public class Section : ContentControl
    {
        static Section()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Section), new FrameworkPropertyMetadata(typeof(Section)));
        }
    }
}
