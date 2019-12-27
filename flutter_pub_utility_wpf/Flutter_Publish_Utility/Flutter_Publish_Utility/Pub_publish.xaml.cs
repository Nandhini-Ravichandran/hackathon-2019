﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flutter_Publish_Utility
{
    /// <summary>
    /// Interaction logic for Pub_publish.xaml
    /// </summary>
    public partial class Pub_publish : Page
    {
        List<String> controlList;
        public Pub_publish()
        {
            InitializeComponent();
            controlList = new List<string>();
            controlList.Add("A");
            controlList.Add("k");
            controlList.Add("s");
            controlList.Add("c");
            combobox.ItemsSource = controlList;
            combobox.DefaultText = "Select the controls";
        }
    }
}