using Avalonia;
using Avalonia.Controls;

namespace SonicFlowFrontend.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.AttachDevTools();
    }
}