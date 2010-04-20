namespace EyeOpen.Wpf.UI.Controls
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public class ImageButton : Button
    {
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public ImageButton()
        {
            FocusVisualStyle = null;
        }

        public static readonly DependencyProperty SourceProperty =
          DependencyProperty.Register("Source", typeof(ImageSource), typeof(ImageButton));

        public ImageSource Source
        {
            get
            {
                return GetValue(SourceProperty) as ImageSource;
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }
    }
}
