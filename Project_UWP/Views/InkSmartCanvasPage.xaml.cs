﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using Project_UWP.Services.Ink;
using Project_UWP.Services.Ink.UndoRedo;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Project_UWP.Views
{
    // For more information regarding Windows Ink documentation and samples see https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/pages/ink.md
    public sealed partial class InkSmartCanvasPage : Page, INotifyPropertyChanged
    {
        private InkStrokesService strokeService;
        private InkLassoSelectionService lassoSelectionService;
        private InkNodeSelectionService nodeSelectionService;
        private InkPointerDeviceService pointerDeviceService;
        private InkUndoRedoService undoRedoService;
        private InkTransformService transformService;
        private InkFileService fileService;

        public InkSmartCanvasPage()
        {
            InitializeComponent();
            Loaded += (sender, eventArgs) =>
            {
                SetCanvasSize();

                strokeService = new InkStrokesService(inkCanvas.InkPresenter);
                var analyzer = new InkAsyncAnalyzer(inkCanvas, strokeService);
                var selectionRectangleService = new InkSelectionRectangleService(inkCanvas, selectionCanvas, strokeService);

                lassoSelectionService = new InkLassoSelectionService(inkCanvas, selectionCanvas, strokeService, selectionRectangleService);
                nodeSelectionService = new InkNodeSelectionService(inkCanvas, selectionCanvas, analyzer, strokeService, selectionRectangleService);
                pointerDeviceService = new InkPointerDeviceService(inkCanvas);
                undoRedoService = new InkUndoRedoService(inkCanvas, strokeService);
                transformService = new InkTransformService(drawingCanvas, strokeService);
                fileService = new InkFileService(inkCanvas, strokeService);

                touchInkingButton.IsChecked = true;
                mouseInkingButton.IsChecked = true;
                penInkingButton.IsChecked = true;

                strokeService.ClearStrokesEvent += (s, e) => RefreshEnabledButtons();
                undoRedoService.UndoEvent += (s, e) => RefreshEnabledButtons();
                undoRedoService.RedoEvent += (s, e) => RefreshEnabledButtons();
                undoRedoService.AddUndoOperationEvent += (s, e) => RefreshEnabledButtons();
                pointerDeviceService.DetectPenEvent += (s, e) => touchInkingButton.IsChecked = false;

                RefreshEnabledButtons();
            };
        }

        private void SetCanvasSize()
        {
            inkCanvas.Width = Math.Max(canvasScroll.ViewportWidth, 1000);
            inkCanvas.Height = Math.Max(canvasScroll.ViewportHeight, 1000);
        }

        private void LassoSelection_Checked(object sender, RoutedEventArgs e) => lassoSelectionService?.StartLassoSelectionConfig();

        private void LassoSelection_Unchecked(object sender, RoutedEventArgs e) => lassoSelectionService?.EndLassoSelectionConfig();

        private void TouchInking_Checked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableTouch = true;

        private void TouchInking_Unchecked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableTouch = false;

        private void MouseInking_Checked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableMouse = true;

        private void MouseInking_Unchecked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableMouse = false;

        private void PenInking_Checked(object sender, RoutedEventArgs e) => pointerDeviceService.EnablePen = true;

        private void PenInking_Unchecked(object sender, RoutedEventArgs e) => pointerDeviceService.EnablePen = false;

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            undoRedoService?.Undo();
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            undoRedoService?.Redo();
        }

        private async void LoadInkFile_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            var fileLoaded = await fileService.LoadInkAsync();

            if (fileLoaded)
            {
                transformService.ClearTextAndShapes();
                undoRedoService.Reset();
            }
        }

        private async void SaveInkFile_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            await fileService.SaveInkAsync();
        }

        private async void TransformTextAndShapes_Click(object sender, RoutedEventArgs e)
        {
            var result = await transformService.TransformTextAndShapesAsync();
            if (result.TextAndShapes.Any())
            {
                ClearSelection();
                undoRedoService.AddOperation(new TransformUndoRedoOperation(result, strokeService));
            }
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            var strokes = strokeService?.GetStrokes().ToList();
            var textAndShapes = transformService?.GetTextAndShapes().ToList();
            ClearSelection();
            strokeService.ClearStrokes();
            transformService.ClearTextAndShapes();
            undoRedoService.AddOperation(new ClearStrokesAndShapesUndoRedoOperation(strokes, textAndShapes, strokeService, transformService));
        }

        private void RefreshEnabledButtons()
        {
            UndoButton.IsEnabled = undoRedoService.CanUndo;
            RedoButton.IsEnabled = undoRedoService.CanRedo;
            SaveInkFileButton.IsEnabled = strokeService.GetStrokes().Any();
            TransformTextAndShapesButton.IsEnabled = strokeService.GetStrokes().Any();
            ClearAllButton.IsEnabled = strokeService.GetStrokes().Any() || transformService.HasTextAndShapes();
        }

        private void ClearSelection()
        {
            nodeSelectionService.ClearSelection();
            lassoSelectionService.ClearSelection();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
