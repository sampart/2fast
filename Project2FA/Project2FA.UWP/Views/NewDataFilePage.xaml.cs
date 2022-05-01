﻿using Project2FA.UWP.ViewModels;
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


namespace Project2FA.UWP.Views
{
    public sealed partial class NewDataFilePage : Page
    {
        public NewDataFilePageViewModel ViewModel => DataContext as NewDataFilePageViewModel;
        public NewDataFilePage()
        {
            this.InitializeComponent();
            this.Loaded += NewDataFilePage_Loaded;
        }

        private void NewDataFilePage_Loaded(object sender, RoutedEventArgs e)
        {
            App.ShellPageInstance.ShellViewInternal.Header = string.Empty;
            App.ShellPageInstance.ShellViewInternal.HeaderTemplate = ShellHeaderTemplate;
        }

        private void HLBTN_PasswordInfo(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_LocalPath_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_WebDAV_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UseDatafileContentDialogWDLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PB_LocalPassword_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}
