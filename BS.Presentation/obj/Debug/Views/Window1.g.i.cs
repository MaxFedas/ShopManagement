﻿#pragma checksum "..\..\..\Views\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9A18B49E6B39585A9E90451B239B9BE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BS.Presentation.Views {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Categoty;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_SubCategoty;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Producer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Product;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Volume;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Measure;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_VolumeMeasure;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Price;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPackege;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BS.Presentation;component/views/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CB_Categoty = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\Views\Window1.xaml"
            this.CB_Categoty.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CB_Categoty_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CB_SubCategoty = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CB_Producer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.CB_Product = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.TB_Volume = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CB_Measure = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.CB_VolumeMeasure = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.TB_Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnAddPackege = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Views\Window1.xaml"
            this.btnAddPackege.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 35 "..\..\..\Views\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
