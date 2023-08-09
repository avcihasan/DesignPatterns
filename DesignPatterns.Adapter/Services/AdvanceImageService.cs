﻿using System.Drawing;
using LazZiya.ImageResize;

namespace DesignPatterns.Adapter.Services
{
    public class AdvanceImageService : IAdvanceImageService
    {
        public void AddWatermarkImage(Stream stream, string text, string filePath, Color color, Color outlineColor)
        {
            using (var img = Image.FromStream(stream))
            {
                var tOps = new TextWatermarkOptions
                {
                    TextColor = color,

                    OutlineColor = outlineColor
                };

                img.AddTextWatermark(text, tOps)
                   .SaveAs(filePath);
            }
        }
    }
}
