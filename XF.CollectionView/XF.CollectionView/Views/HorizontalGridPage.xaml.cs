﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.CollectionView.ViewModels;

namespace XF.CollectionView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HorizontalGridPage : ContentPage
    {
        public HorizontalGridPage()
        {
            InitializeComponent();

            BindingContext = new PageViewModel();
        }
    }
}