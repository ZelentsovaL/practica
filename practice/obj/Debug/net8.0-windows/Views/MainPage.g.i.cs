﻿#pragma checksum "..\..\..\..\Views\MainPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6BC6122AD191A8DC929BCF3A4355140AAB4B16C3"
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
using practice.Views;


namespace practice.Views {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableData;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddData;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveData;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateData;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateTable;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentRole;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/practice;component/views/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TableData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\..\Views\MainPage.xaml"
            this.TableData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TableData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddData = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Views\MainPage.xaml"
            this.AddData.Click += new System.Windows.RoutedEventHandler(this.AddData_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RemoveData = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Views\MainPage.xaml"
            this.RemoveData.Click += new System.Windows.RoutedEventHandler(this.RemoveData_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpdateData = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Views\MainPage.xaml"
            this.UpdateData.Click += new System.Windows.RoutedEventHandler(this.UpdateData_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdateTable = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Views\MainPage.xaml"
            this.UpdateTable.Click += new System.Windows.RoutedEventHandler(this.UpdateTable_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CurrentRole = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

