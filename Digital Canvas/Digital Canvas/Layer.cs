using System;
using System.Drawing;

namespace Digital_Canvas
{
    [Serializable]
    public class Layer
    {
        private string layerName;
        private Bitmap bmpLayer;
        private Boolean isVisible = true;

        public Layer(string layerName, Bitmap bmpLayer)
        {
            this.layerName = layerName;
            this.bmpLayer = bmpLayer;
        }
        
        public string LayerName
        {
            get => layerName;
            set => layerName = value;
        }

        public Bitmap BmpLayer
        {
            get => bmpLayer;
            set => bmpLayer = value;
        }

        public bool IsVisible
        {
            get => isVisible;
            set => isVisible = value;
        }

        public override string ToString()
        {
            return layerName;
        }
    }
}