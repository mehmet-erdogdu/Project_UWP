﻿#pragma checksum "D:\Works\Repos\Project_UWP\Project_UWP\Views\InkSmartCanvasPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4CA790BF1EF18006086E638F6CB8FBBB"
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
    partial class InkSmartCanvasPage : 
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
        private class InkSmartCanvasPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IInkSmartCanvasPage_Bindings
        {
            private global::Project_UWP.Views.InkSmartCanvasPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.InkToolbar obj7;

            public InkSmartCanvasPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // Views\InkSmartCanvasPage.xaml line 23
                        this.obj7 = (global::Windows.UI.Xaml.Controls.InkToolbar)target;
                        break;
                    default:
                        break;
                }
            }

            // IInkSmartCanvasPage_Bindings

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
                    this.dataRoot = (global::Project_UWP.Views.InkSmartCanvasPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Project_UWP.Views.InkSmartCanvasPage obj, int phase)
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
                    // Views\InkSmartCanvasPage.xaml line 23
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_InkToolbar_TargetInkCanvas(this.obj7, obj, null);
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
            case 2: // Views\InkSmartCanvasPage.xaml line 9
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\InkSmartCanvasPage.xaml line 111
                {
                    this.canvasScroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4: // Views\InkSmartCanvasPage.xaml line 121
                {
                    this.inkCanvas = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                }
                break;
            case 5: // Views\InkSmartCanvasPage.xaml line 124
                {
                    this.drawingCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 6: // Views\InkSmartCanvasPage.xaml line 127
                {
                    this.selectionCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 7: // Views\InkSmartCanvasPage.xaml line 23
                {
                    this.toolbar = (global::Windows.UI.Xaml.Controls.InkToolbar)(target);
                }
                break;
            case 8: // Views\InkSmartCanvasPage.xaml line 24
                {
                    this.lassoSelectionButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)this.lassoSelectionButton).Checked += this.LassoSelection_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToolButton)this.lassoSelectionButton).Unchecked += this.LassoSelection_Unchecked;
                }
                break;
            case 9: // Views\InkSmartCanvasPage.xaml line 33
                {
                    this.touchInkingButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.touchInkingButton).Checked += this.TouchInking_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.touchInkingButton).Unchecked += this.TouchInking_Unchecked;
                }
                break;
            case 10: // Views\InkSmartCanvasPage.xaml line 42
                {
                    this.mouseInkingButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.mouseInkingButton).Checked += this.MouseInking_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.mouseInkingButton).Unchecked += this.MouseInking_Unchecked;
                }
                break;
            case 11: // Views\InkSmartCanvasPage.xaml line 51
                {
                    this.penInkingButton = (global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.penInkingButton).Checked += this.PenInking_Checked;
                    ((global::Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton)this.penInkingButton).Unchecked += this.PenInking_Unchecked;
                }
                break;
            case 12: // Views\InkSmartCanvasPage.xaml line 63
                {
                    this.UndoButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.UndoButton).Click += this.Undo_Click;
                }
                break;
            case 13: // Views\InkSmartCanvasPage.xaml line 70
                {
                    this.RedoButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.RedoButton).Click += this.Redo_Click;
                }
                break;
            case 14: // Views\InkSmartCanvasPage.xaml line 78
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element14 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element14).Click += this.LoadInkFile_Click;
                }
                break;
            case 15: // Views\InkSmartCanvasPage.xaml line 84
                {
                    this.SaveInkFileButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SaveInkFileButton).Click += this.SaveInkFile_Click;
                }
                break;
            case 16: // Views\InkSmartCanvasPage.xaml line 92
                {
                    this.TransformTextAndShapesButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.TransformTextAndShapesButton).Click += this.TransformTextAndShapes_Click;
                }
                break;
            case 17: // Views\InkSmartCanvasPage.xaml line 103
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
            case 1: // Views\InkSmartCanvasPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    InkSmartCanvasPage_obj1_Bindings bindings = new InkSmartCanvasPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
