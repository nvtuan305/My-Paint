﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B542628357D46B76E6C8B2C858E84E61"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace MyPaint {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas PaintCanvas;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnOpenImage;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnSaveImage;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnUndo;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnRedo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnClearAll;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnDelete;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnSelect;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnCopy;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnPaste;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnCut;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnInsertText;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFontText;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSizeText;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnBoldText;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnItalicText;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnUnderlineText;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnLineTool;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnRectangleTool;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnEllipseTool;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnArrowTool;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbShapePlugin;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadShapePlugin;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnStrokeColor;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnFillColor;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker colorPicker;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorNoneColor;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFFED1C24;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFF00A2E8;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFF3F48CC;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFFA349A4;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFF22B14C;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFFFF7F27;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnColorFFFFC90E;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFillStyle;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton btnFill;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuButton ribbonMenuSize;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem btnStroke1;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem btnStroke2;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem btnStroke3;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem btnStroke4;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBorderStyle;
        
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
            System.Uri resourceLocater = new System.Uri("/MyPaint;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 7 "..\..\MainWindow.xaml"
            ((MyPaint.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PaintCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.PaintCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PaintCanvas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.PaintCanvas.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.PaintCanvas_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.PaintCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.PaintCanvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.PaintCanvas.KeyDown += new System.Windows.Input.KeyEventHandler(this.PaintCanvas_KeyDown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.PaintCanvas.KeyUp += new System.Windows.Input.KeyEventHandler(this.PaintCanvas_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 40 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNew_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOpenImage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 42 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSaveImage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOpenImage = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.btnOpenImage.Click += new System.Windows.RoutedEventHandler(this.btnOpenImage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSaveImage = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.btnSaveImage.Click += new System.Windows.RoutedEventHandler(this.btnSaveImage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnUndo = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.btnUndo.Click += new System.Windows.RoutedEventHandler(this.btnUndo_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRedo = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.btnRedo.Click += new System.Windows.RoutedEventHandler(this.btnRedo_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnClearAll = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.btnClearAll.Click += new System.Windows.RoutedEventHandler(this.btnClearAll_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnSelect = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 65 "..\..\MainWindow.xaml"
            this.btnSelect.Click += new System.Windows.RoutedEventHandler(this.btnSelect_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnCopy = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 66 "..\..\MainWindow.xaml"
            this.btnCopy.Click += new System.Windows.RoutedEventHandler(this.btnCopy_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btnPaste = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 67 "..\..\MainWindow.xaml"
            this.btnPaste.Click += new System.Windows.RoutedEventHandler(this.btnPaste_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnCut = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 68 "..\..\MainWindow.xaml"
            this.btnCut.Click += new System.Windows.RoutedEventHandler(this.btnCut_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnInsertText = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.btnInsertText.Click += new System.Windows.RoutedEventHandler(this.btnInsertText_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.cbFontText = ((System.Windows.Controls.ComboBox)(target));
            
            #line 75 "..\..\MainWindow.xaml"
            this.cbFontText.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFontText_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            this.cbSizeText = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.cbSizeText.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSizeText_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 20:
            this.btnBoldText = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.btnBoldText.Click += new System.Windows.RoutedEventHandler(this.btnBoldText_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.btnItalicText = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 78 "..\..\MainWindow.xaml"
            this.btnItalicText.Click += new System.Windows.RoutedEventHandler(this.btnItalicText_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.btnUnderlineText = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 79 "..\..\MainWindow.xaml"
            this.btnUnderlineText.Click += new System.Windows.RoutedEventHandler(this.btnUnderlineText_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.btnLineTool = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 85 "..\..\MainWindow.xaml"
            this.btnLineTool.Click += new System.Windows.RoutedEventHandler(this.btnLineTool_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.btnRectangleTool = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 91 "..\..\MainWindow.xaml"
            this.btnRectangleTool.Click += new System.Windows.RoutedEventHandler(this.btnRectangleTool_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.btnEllipseTool = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this.btnEllipseTool.Click += new System.Windows.RoutedEventHandler(this.btnEllipseTool_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            this.btnArrowTool = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 102 "..\..\MainWindow.xaml"
            this.btnArrowTool.Click += new System.Windows.RoutedEventHandler(this.btnArrowTool_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.cbShapePlugin = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 28:
            this.btnLoadShapePlugin = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\MainWindow.xaml"
            this.btnLoadShapePlugin.Click += new System.Windows.RoutedEventHandler(this.btnLoadShapePlugin_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.btnStrokeColor = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 114 "..\..\MainWindow.xaml"
            this.btnStrokeColor.Click += new System.Windows.RoutedEventHandler(this.btnStrokeColor_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.btnFillColor = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 122 "..\..\MainWindow.xaml"
            this.btnFillColor.Click += new System.Windows.RoutedEventHandler(this.btnFillColor_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            this.colorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 130 "..\..\MainWindow.xaml"
            this.colorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.colorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 32:
            this.btnColorNoneColor = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 138 "..\..\MainWindow.xaml"
            this.btnColorNoneColor.Click += new System.Windows.RoutedEventHandler(this.btnColorNoneColor_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            this.btnColorFFED1C24 = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 139 "..\..\MainWindow.xaml"
            this.btnColorFFED1C24.Click += new System.Windows.RoutedEventHandler(this.btnColorFFED1C24_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            this.btnColorFF00A2E8 = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 140 "..\..\MainWindow.xaml"
            this.btnColorFF00A2E8.Click += new System.Windows.RoutedEventHandler(this.btnColorFF00A2E8_Click);
            
            #line default
            #line hidden
            return;
            case 35:
            this.btnColorFF3F48CC = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 141 "..\..\MainWindow.xaml"
            this.btnColorFF3F48CC.Click += new System.Windows.RoutedEventHandler(this.btnColorFF3F48CC_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            this.btnColorFFA349A4 = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 142 "..\..\MainWindow.xaml"
            this.btnColorFFA349A4.Click += new System.Windows.RoutedEventHandler(this.btnColorFFA349A4_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            this.btnColorFF22B14C = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 143 "..\..\MainWindow.xaml"
            this.btnColorFF22B14C.Click += new System.Windows.RoutedEventHandler(this.btnColorFF22B14C_Click);
            
            #line default
            #line hidden
            return;
            case 38:
            this.btnColorFFFF7F27 = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 144 "..\..\MainWindow.xaml"
            this.btnColorFFFF7F27.Click += new System.Windows.RoutedEventHandler(this.btnColorFFFF7F27_Click);
            
            #line default
            #line hidden
            return;
            case 39:
            this.btnColorFFFFC90E = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 145 "..\..\MainWindow.xaml"
            this.btnColorFFFFC90E.Click += new System.Windows.RoutedEventHandler(this.btnColorFFFFC90E_Click);
            
            #line default
            #line hidden
            return;
            case 40:
            this.cbFillStyle = ((System.Windows.Controls.ComboBox)(target));
            
            #line 151 "..\..\MainWindow.xaml"
            this.cbFillStyle.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFillStyle_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 41:
            this.btnFill = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 157 "..\..\MainWindow.xaml"
            this.btnFill.Click += new System.Windows.RoutedEventHandler(this.btnFill_Click);
            
            #line default
            #line hidden
            return;
            case 42:
            this.ribbonMenuSize = ((System.Windows.Controls.Ribbon.RibbonMenuButton)(target));
            return;
            case 43:
            this.btnStroke1 = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            
            #line 167 "..\..\MainWindow.xaml"
            this.btnStroke1.Click += new System.Windows.RoutedEventHandler(this.btnStroke1_Click);
            
            #line default
            #line hidden
            return;
            case 44:
            this.btnStroke2 = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            
            #line 168 "..\..\MainWindow.xaml"
            this.btnStroke2.Click += new System.Windows.RoutedEventHandler(this.btnStroke2_Click);
            
            #line default
            #line hidden
            return;
            case 45:
            this.btnStroke3 = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            
            #line 169 "..\..\MainWindow.xaml"
            this.btnStroke3.Click += new System.Windows.RoutedEventHandler(this.btnStroke3_Click);
            
            #line default
            #line hidden
            return;
            case 46:
            this.btnStroke4 = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            
            #line 170 "..\..\MainWindow.xaml"
            this.btnStroke4.Click += new System.Windows.RoutedEventHandler(this.btnStroke4_Click);
            
            #line default
            #line hidden
            return;
            case 47:
            this.cbBorderStyle = ((System.Windows.Controls.ComboBox)(target));
            
            #line 174 "..\..\MainWindow.xaml"
            this.cbBorderStyle.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbBorderStyle_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

