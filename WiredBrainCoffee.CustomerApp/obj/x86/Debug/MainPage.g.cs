﻿#pragma checksum "C:\Users\fb142897\Code\CS\WiredBrainCoffee.CustomerApp\WiredBrainCoffee.CustomerApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7D2A89CCDDB421F997BB76F6C2DB6F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WiredBrainCoffee.CustomerApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 47
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.ButtonToggleTheme_Click;
                }
                break;
            case 3: // MainPage.xaml line 55
                {
                    this.customerListGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 93
                {
                    this.customerDetailControl = (global::WiredBrainCoffee.CustomerApp.Controls.CustomerDetailControl)(target);
                }
                break;
            case 5: // MainPage.xaml line 86
                {
                    this.customerListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 6: // MainPage.xaml line 64
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.ButtonMove_Click;
                }
                break;
            case 7: // MainPage.xaml line 70
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.ButtonAddCustomer_Click;
                }
                break;
            case 8: // MainPage.xaml line 77
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.ButtonDeleteCustomer_Click;
                }
                break;
            case 9: // MainPage.xaml line 66
                {
                    this.moveSymbolIcon = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

