﻿using AreaCirculoAppMvvm.views;

namespace AreaCirculoAppMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AreaCirculoAppMvvmView());
        }
    }
}