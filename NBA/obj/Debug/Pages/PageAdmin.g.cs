﻿#pragma checksum "..\..\..\Pages\PageAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1354D682A19F7EDC2129BE644F912EE55C028BA0A83B5C5E719DDBD33E77BDC6"
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
    /// PageAdmin
    /// </summary>
    public partial class PageAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageSeasons;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Matchups;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageTeams;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManagePlayers;
        
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
            System.Uri resourceLocater = new System.Uri("/NBA;component/pages/pageadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageAdmin.xaml"
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
            
            #line 10 "..\..\..\Pages\PageAdmin.xaml"
            ((NBA.Pages.PageAdmin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ManageSeasons = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\PageAdmin.xaml"
            this.ManageSeasons.Click += new System.Windows.RoutedEventHandler(this.ManageSeasons_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Matchups = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\PageAdmin.xaml"
            this.Matchups.Click += new System.Windows.RoutedEventHandler(this.Matchups_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ManageTeams = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\PageAdmin.xaml"
            this.ManageTeams.Click += new System.Windows.RoutedEventHandler(this.ManageTeams_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ManagePlayers = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Pages\PageAdmin.xaml"
            this.ManagePlayers.Click += new System.Windows.RoutedEventHandler(this.ManagePlayers_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

