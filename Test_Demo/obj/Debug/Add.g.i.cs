// Updated by XamlIntelliSenseFileGenerator 08.06.2023 0:58:23
#pragma checksum "..\..\Add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB7EC702C4A426D761FF03EA1992F724CE9B9CE3DB7F3227DFA4908FDA00A34E"
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
using Test_Demo;


namespace Test_Demo
{


    /// <summary>
    /// Add
    /// </summary>
    public partial class Add : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Test_Demo;component/add.xaml", System.UriKind.Relative);

#line 1 "..\..\Add.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox TxtArticul;
        internal System.Windows.Controls.TextBox TxtName;
        internal System.Windows.Controls.TextBox TxtDescr;
        internal System.Windows.Controls.ComboBox TxtCat;
        internal System.Windows.Controls.TextBox TxtPhoto;
        internal System.Windows.Controls.TextBox TxtManuf;
        internal System.Windows.Controls.TextBox TxtCost;
        internal System.Windows.Controls.TextBox TxtDiscaunt;
        internal System.Windows.Controls.TextBox TxtStok;
        internal System.Windows.Controls.TextBox TxtStatus;
        internal System.Windows.Controls.TextBox TxtUnit;
        internal System.Windows.Controls.TextBox TxtMax;
        internal System.Windows.Controls.TextBox TxtProvider;
        internal System.Windows.Controls.Button BtnAdd;
    }
}
