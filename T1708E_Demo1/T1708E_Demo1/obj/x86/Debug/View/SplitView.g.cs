﻿#pragma checksum "C:\Users\NguyenCongJP\source\repos\T1708E_Demo1\T1708E_Demo1\View\SplitView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6A1B3E0FE706163B51A1DFF8771F693"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T1708E_Demo1.View
{
    partial class SplitView : 
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
            case 2: // View\SplitView.xaml line 12
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // View\SplitView.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.btn_SplitView;
                }
                break;
            case 4: // View\SplitView.xaml line 52
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 5: // View\SplitView.xaml line 54
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element5 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element5).Click += this.ShowLogin;
                }
                break;
            case 6: // View\SplitView.xaml line 60
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element6 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element6).Click += this.ShowRegister;
                }
                break;
            case 7: // View\SplitView.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element7 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element7).Click += this.btn_Frame;
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
