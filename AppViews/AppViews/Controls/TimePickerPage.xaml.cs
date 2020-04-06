﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViews.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerPage : ContentPage
    {
        public TimePickerPage()
        {
            InitializeComponent();
            timePicker.Time = DateTime.Now.TimeOfDay;
        }        
    }
}