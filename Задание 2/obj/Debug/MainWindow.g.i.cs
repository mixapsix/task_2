﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88D15538A5FAB219DCA884F3715221066D0D731D22D6E1CA71A2E1603A8439F6"
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
using System.Collections;
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
using Task_2;
using Task_2.Properties;


namespace Task_2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fileNameBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox fileNameMaskBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lineMaskBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lineBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label directoryLabel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openDirectory;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox regimeBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid resultGrid;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu contextMenu;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox downloadTypeBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button downloadButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox uploadTypeBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uplaodButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Task_2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.fileNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.fileNameMaskBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.fileNameMaskBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.fileNameMaskBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainWindow.xaml"
            this.fileNameMaskBox.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.fileNameMaskBox_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainWindow.xaml"
            this.fileNameMaskBox.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.fileNameMaskBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lineMaskBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.lineMaskBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lineMaskBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.lineMaskBox.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lineMaskBox_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lineBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.lineBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.lineBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.directoryLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.openDirectory = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.openDirectory.Click += new System.Windows.RoutedEventHandler(this.OpenExplorer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.regimeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 37 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.resultGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.contextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 11:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemChange);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 42 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemDelete);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemBackup);
            
            #line default
            #line hidden
            return;
            case 14:
            this.downloadTypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.downloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.downloadButton.Click += new System.Windows.RoutedEventHandler(this.Download);
            
            #line default
            #line hidden
            return;
            case 16:
            this.uploadTypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 17:
            this.uplaodButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\MainWindow.xaml"
            this.uplaodButton.Click += new System.Windows.RoutedEventHandler(this.Upload);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

