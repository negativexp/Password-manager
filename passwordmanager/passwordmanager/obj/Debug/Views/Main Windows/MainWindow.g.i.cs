﻿#pragma checksum "..\..\..\..\Views\Main Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "90196997B80DD11085E10B996927B76FF67B3800F110DDC36604DBAFBADA2094"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
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
using passwordmanager;


namespace passwordmanager {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLogins;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPersonalInformation;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCreditCards;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSecureNotes;
        
        #line default
        #line hidden
        
        /// <summary>
        /// FrameContent Name Field
        /// </summary>
        
        #line 53 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Frame FrameContent;
        
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
            System.Uri resourceLocater = new System.Uri("/passwordmanager;component/views/main%20windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
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
            
            #line 12 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            ((passwordmanager.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonX_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMinimze_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonLogins = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            this.ButtonLogins.Click += new System.Windows.RoutedEventHandler(this.Logins_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonPersonalInformation = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            this.ButtonPersonalInformation.Click += new System.Windows.RoutedEventHandler(this.PersonalInformation_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonCreditCards = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            this.ButtonCreditCards.Click += new System.Windows.RoutedEventHandler(this.CreditCards_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonSecureNotes = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Views\Main Windows\MainWindow.xaml"
            this.ButtonSecureNotes.Click += new System.Windows.RoutedEventHandler(this.SecureNotes_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FrameContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
