using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace SEDSelfHelpCashierSystem.Component
{
    /// <summary>
    /// SedButton.xaml 的交互逻辑
    /// </summary>
    public partial class SedButton : Button
    {
        public static readonly DependencyProperty CornerProperty = DependencyProperty.Register("Corner", typeof(CornerRadius), typeof(SedButton));
        public static readonly DependencyProperty BorderColorProperty = DependencyProperty.Register("BorderColor", typeof(SolidColorBrush), typeof(SedButton));
        public SedButton()
        {
            InitializeComponent();
        }

        //边框颜色
        public SolidColorBrush BorderColor
        {
            get
            {
                return (SolidColorBrush)GetValue(BorderColorProperty);
            }
            set
            {
                SetValue(BorderColorProperty, value);
                //border.CornerRadius = value;
            }
        }

        public CornerRadius Corner
        {
            get
            {
                return (CornerRadius)GetValue(CornerProperty);
            }
            set
            {
                SetValue(CornerProperty, value);
                //border.CornerRadius = value;
            }
        }
    }
}
