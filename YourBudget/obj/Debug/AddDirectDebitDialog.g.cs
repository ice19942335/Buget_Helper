﻿#pragma checksum "..\..\AddDirectDebitDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A0236C2863D552391D390DD31CE8349928BAEAD"
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
using YourBudget;


namespace YourBudget {
    
    
    /// <summary>
    /// AddDirectDebitDialog
    /// </summary>
    public partial class AddDirectDebitDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal YourBudget.AddDirectDebitDialog AddDirectDebitDialog1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDialogName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDialogPrice;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDialogName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDialogPrice;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDialogAdd;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddDirectDebitDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDialogDate;
        
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
            System.Uri resourceLocater = new System.Uri("/YourBudget;component/adddirectdebitdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddDirectDebitDialog.xaml"
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
            this.AddDirectDebitDialog1 = ((YourBudget.AddDirectDebitDialog)(target));
            return;
            case 2:
            this.lblDialogName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblDialogPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tbDialogName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbDialogPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnDialogAdd = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AddDirectDebitDialog.xaml"
            this.btnDialogAdd.Click += new System.Windows.RoutedEventHandler(this.btnDialogAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblDialogDate = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
