﻿#pragma checksum "..\..\..\Pages\PagePlayersMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1CE522D570D103DC4784E35522395A8FBF07964034E91AD9C133949045092744"
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
    /// PagePlayersMain
    /// </summary>
    public partial class PagePlayersMain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackButtons;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSeasons;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboTeams;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PoiskText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataPlayers;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllDown;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Down;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Up;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\PagePlayersMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllUp;
        
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
            System.Uri resourceLocater = new System.Uri("/NBA;component/pages/pageplayersmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PagePlayersMain.xaml"
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
            
            #line 10 "..\..\..\Pages\PagePlayersMain.xaml"
            ((NBA.Pages.PagePlayersMain)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StackButtons = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.ComboSeasons = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\PagePlayersMain.xaml"
            this.ComboSeasons.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSeasons_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboTeams = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Pages\PagePlayersMain.xaml"
            this.ComboTeams.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboTeams_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PoiskText = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Pages\PagePlayersMain.xaml"
            this.PoiskText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PoiskText_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DataPlayers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\..\Pages\PagePlayersMain.xaml"
            this.DataPlayers.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataPlayers_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AllDown = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Pages\PagePlayersMain.xaml"
            this.AllDown.Click += new System.Windows.RoutedEventHandler(this.AllDown_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Down = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\PagePlayersMain.xaml"
            this.Down.Click += new System.Windows.RoutedEventHandler(this.Down_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Up = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Pages\PagePlayersMain.xaml"
            this.Up.Click += new System.Windows.RoutedEventHandler(this.Up_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AllUp = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Pages\PagePlayersMain.xaml"
            this.AllUp.Click += new System.Windows.RoutedEventHandler(this.AllUp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

