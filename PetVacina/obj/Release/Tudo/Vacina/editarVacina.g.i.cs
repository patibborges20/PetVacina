﻿#pragma checksum "C:\Users\patricia\documents\visual studio 2012\Projects\PetVacina\PetVacina\Tudo\Vacina\editarVacina.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "797EDE281DE958C8E250167C23B57865"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PetVacina.Tudo {
    
    
    public partial class editarVacina : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txbNomeVacina;
        
        internal Microsoft.Phone.Controls.DatePicker datapicker;
        
        internal System.Windows.Controls.TextBlock txbDataVacinacao;
        
        internal System.Windows.Controls.Button salvarEditado;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PetVacina;component/Tudo/Vacina/editarVacina.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txbNomeVacina = ((System.Windows.Controls.TextBox)(this.FindName("txbNomeVacina")));
            this.datapicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("datapicker")));
            this.txbDataVacinacao = ((System.Windows.Controls.TextBlock)(this.FindName("txbDataVacinacao")));
            this.salvarEditado = ((System.Windows.Controls.Button)(this.FindName("salvarEditado")));
        }
    }
}

