﻿#pragma checksum "..\..\WindowCadastroClientePJ.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AF30638AEFEC0F3FDAEEBA7159B2A3E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InterfaceGrafica;
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


namespace InterfaceGrafica {
    
    
    /// <summary>
    /// WindowCadastroClientePJ
    /// </summary>
    public partial class WindowCadastroClientePJ : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\WindowCadastroClientePJ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFocusMe;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WindowCadastroClientePJ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox box1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WindowCadastroClientePJ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSelecionarFoto;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\WindowCadastroClientePJ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\WindowCadastroClientePJ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelarButton;
        
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
            System.Uri resourceLocater = new System.Uri("/InterfaceGrafica;component/windowcadastroclientepj.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowCadastroClientePJ.xaml"
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
            this.tbFocusMe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.box1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnSelecionarFoto = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\WindowCadastroClientePJ.xaml"
            this.BtnSelecionarFoto.Click += new System.Windows.RoutedEventHandler(this.BtnSelecionarFoto_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\WindowCadastroClientePJ.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CancelarButton = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\WindowCadastroClientePJ.xaml"
            this.CancelarButton.Click += new System.Windows.RoutedEventHandler(this.CancelarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

