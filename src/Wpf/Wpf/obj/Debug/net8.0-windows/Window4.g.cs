﻿#pragma checksum "..\..\..\Window4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457CFE16D924FA4AE83445554EC4C512EBB3EF5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Wpf;


namespace Wpf {
    
    
    /// <summary>
    /// Window4
    /// </summary>
    public partial class Window4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputTextBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Result;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lb;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Result_Копировать;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lb2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wpf;component/window4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window4.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.InputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Result = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Window4.xaml"
            this.Result.Click += new System.Windows.RoutedEventHandler(this.TranslateButton_Clickk);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lb = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Window4.xaml"
            this.lb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.lb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Result_Копировать = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Window4.xaml"
            this.Result_Копировать.Click += new System.Windows.RoutedEventHandler(this.TranslateButton_Click22);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lb2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\Window4.xaml"
            this.lb2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.lb_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

