using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App2
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void b1c(object sender, RoutedEventArgs e)
        {
            result.Text = "1-大秦帝国";
        }

        private void b2c(object sender, RoutedEventArgs e)
        {
            result.Text = "2-大汉王朝";
        }

        private void b3c(object sender, RoutedEventArgs e)
        {
            result.Text = "3-隋王朝";
        }

        private void b4c(object sender, RoutedEventArgs e)
        {
            result.Text = "4-大唐帝国";
        }

        private void b5c(object sender, RoutedEventArgs e)
        {
            result.Text = "5-两晋王朝";
        }

        private void b6c(object sender, RoutedEventArgs e)
        {
            result.Text = "6-两宋王朝";
        }

        private void b7c(object sender, RoutedEventArgs e)
        {
            result.Text = "7-元帝国";
        }

        private void b8c(object sender, RoutedEventArgs e)
        {
            result.Text = "8-明帝国";
        }

        private void b9c(object sender, RoutedEventArgs e)
        {
            result.Text = "9-大清帝国";
        }
    }
}
