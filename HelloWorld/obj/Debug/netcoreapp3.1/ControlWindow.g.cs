﻿#pragma checksum "..\..\..\ControlWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B81E7D69A61D11B28A45226E93438A1D34DDB96"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HelloWorld;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace HelloWorld {
    
    
    /// <summary>
    /// ControlWindow
    /// </summary>
    public partial class ControlWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox uxLocal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink uxNavigator;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider uxSlider;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar uxProgressBar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HelloWorld;component/controlwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ControlWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.uxLocal = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\..\ControlWindow.xaml"
            this.uxLocal.Checked += new System.Windows.RoutedEventHandler(this.uxLocal_Clicked);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\ControlWindow.xaml"
            this.uxLocal.Unchecked += new System.Windows.RoutedEventHandler(this.uxLocal_Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxNavigator = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 17 "..\..\..\ControlWindow.xaml"
            this.uxNavigator.RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.uxNavigator_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.uxNavigator_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uxSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 32 "..\..\..\ControlWindow.xaml"
            this.uxSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.uxSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.uxProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
