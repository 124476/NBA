﻿#pragma checksum "..\..\..\Pages\PageImages.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9621E20ECD1182FDB99944405EED8317C42CA87AA2A6F4453389A7A397B66F1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NBA.Pages;
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


namespace NBA.Pages {
    
    
    /// <summary>
    /// PageImages
    /// </summary>
    public partial class PageImages : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListPhotos;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextAll;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownAll;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Down;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextOnly;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Up;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpAll;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\PageImages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadAll;
        
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
            System.Uri resourceLocater = new System.Uri("/NBA;component/pages/pageimages.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageImages.xaml"
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
            this.ListPhotos = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.TextAll = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DownAll = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pages\PageImages.xaml"
            this.DownAll.Click += new System.Windows.RoutedEventHandler(this.DownAll_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Down = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\PageImages.xaml"
            this.Down.Click += new System.Windows.RoutedEventHandler(this.Down_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextOnly = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Up = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\PageImages.xaml"
            this.Up.Click += new System.Windows.RoutedEventHandler(this.Up_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UpAll = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\PageImages.xaml"
            this.UpAll.Click += new System.Windows.RoutedEventHandler(this.UpAll_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DownloadAll = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\PageImages.xaml"
            this.DownloadAll.Click += new System.Windows.RoutedEventHandler(this.DownloadAll_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 24 "..\..\..\Pages\PageImages.xaml"
            ((System.Windows.Controls.Image)(target)).MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseRightButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
