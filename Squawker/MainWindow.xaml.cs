using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;

namespace Squawker;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private static IntPtr _hookID = IntPtr.Zero;

    public MainWindow(MainWindowViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}