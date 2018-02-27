using ClassLibrary1;
using System;

namespace StorageApp
{
    public class ProductSelectedEventArgs : EventArgs
    {
        public Proizvodi SelectedProduct { get; set; }
        
    }
}