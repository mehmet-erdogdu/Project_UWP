﻿#pragma checksum "D:\Works\Repos\Project_UWP\Project_UWP\Views\InkDrawPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "144179E013A9DF75EC1A30C0F371E0FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_UWP.Views
{
    partial class InkDrawPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(global::Windows.UI.Xaml.Controls.InkToolbar obj, global::Windows.UI.Xaml.Controls.InkCanvas value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.InkCanvas) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.InkCanvas), targetNullValue);
                }
                obj.TargetInkCanvas = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class InkDrawPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IInkDrawPage_Bindings
        {
            private global::Project_UWP.Views.InkDrawPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.InkToolbar obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TargetInkCanvasDisabled = false;

            public InkDrawPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 23 && columnNumber == 50)
                {
                    isobj6TargetInkCanvasDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\InkDrawPage.xaml line 23
                        this.obj6 = (global::Windows.UI.Xaml.Controls.InkToolbar)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // IInkDrawPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Project_UWP.Views.InkDrawPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Project_UWP.Views.InkDrawPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_inkCanvas(obj.inkCanvas, phase);
                    }
                }
            }
            private void Update_inkCanvas(global::Windows.UI.Xaml.Controls.InkCanvas obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\InkDrawPage.xaml line 23
                    if (!isobj6TargetInkCanvasDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(this.obj6, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\InkDrawPage.xaml line 9
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\InkDrawPage.xaml line 142
                {
                    this.canvasScroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4: // Views\InkDrawPage.xaml line 152
                {
                    this.inkCanvas = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 5: // Views\InkDrawPage.xaml line 155
                {
                    this.selectionCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 6: // Views\InkDrawPage.xaml line 23
                {
                    this.toolbar = (global::Windows.UI.Xaml.Controls.InkToolbar)(target);
                }
                break;
            case 7: // Views\InkDrawPage.xaml line 24
                {
                    this.lassoSelectionButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)this.lassoSelectionButton).Checked += this.LassoSelection_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)this.lassoSelectionButton).Unchecked += this.LassoSelection_Unchecked;
                }
                break;
            case 8: // Views\InkDrawPage.xaml line 33
                {
                    this.touchInkingButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.touchInkingButton).Checked += this.TouchInking_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.touchInkingButton).Unchecked += this.TouchInking_Unchecked;
                }
                break;
            case 9: // Views\InkDrawPage.xaml line 42
                {
                    this.mouseInkingButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.mouseInkingButton).Checked += this.MouseInking_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.mouseInkingButton).Unchecked += this.MouseInking_Unchecked;
                }
                break;
            case 10: // Views\InkDrawPage.xaml line 54
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.ZoomIn_Click;
                }
                break;
            case 11: // Views\InkDrawPage.xaml line 60
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.ZoomOut_Click;
                }
                break;
            case 12: // Views\InkDrawPage.xaml line 67
                {
                    this.CutButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.CutButton).Click += this.Cut_Click;
                }
                break;
            case 13: // Views\InkDrawPage.xaml line 75
                {
                    this.CopyButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.CopyButton).Click += this.Copy_Click;
                }
                break;
            case 14: // Views\InkDrawPage.xaml line 83
                {
                    this.PasteButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PasteButton).Click += this.Paste_Click;
                }
                break;
            case 15: // Views\InkDrawPage.xaml line 92
                {
                    this.UndoButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.UndoButton).Click += this.Undo_Click;
                }
                break;
            case 16: // Views\InkDrawPage.xaml line 100
                {
                    this.RedoButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.RedoButton).Click += this.Redo_Click;
                }
                break;
            case 17: // Views\InkDrawPage.xaml line 109
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element17 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element17).Click += this.LoadInkFile_Click;
                }
                break;
            case 18: // Views\InkDrawPage.xaml line 115
                {
                    this.SaveInkFileButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SaveInkFileButton).Click += this.SaveInkFile_Click;
                }
                break;
            case 19: // Views\InkDrawPage.xaml line 123
                {
                    this.ExportAsImageButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.ExportAsImageButton).Click += this.ExportAsImage_Click;
                }
                break;
            case 20: // Views\InkDrawPage.xaml line 132
                {
                    this.ClearAllButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.ClearAllButton).Click += this.ClearAll_Click;
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
            switch(connectionId)
            {
            case 1: // Views\InkDrawPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    InkDrawPage_obj1_Bindings bindings = new InkDrawPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
