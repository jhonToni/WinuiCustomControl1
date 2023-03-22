// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CustomControl2.Controls
{
    public sealed class CustomControl1 : Control
    {
        private ItemsControl? _list;

        private ObservableCollection<TextBlock> _fields = new ObservableCollection<TextBlock>();


        public ObservableCollection<TextBlock> Fields { get { return _fields; } }



        public CustomControl1()
        {
            this.DefaultStyleKey = typeof(CustomControl1);
        }


        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _list = GetTemplateChild("MainList") as ItemsControl;

           if(_list != null) _list.ItemsSource = Fields;
        }
    }
}
