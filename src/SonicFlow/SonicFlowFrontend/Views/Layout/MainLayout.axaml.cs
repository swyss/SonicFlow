using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SonicFlowFrontend.Views.Layout;

public partial class MainLayout : UserControl
{
    public MainLayout()
    {
        InitializeComponent();
    }
    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        message.Text = "Button clicked!";
    }
}