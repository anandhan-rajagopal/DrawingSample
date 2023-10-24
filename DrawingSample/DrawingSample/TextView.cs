using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSample
{
    public class TextView : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            float padding = 30;
            float cornerRadius = 0;
            RectF innerRect = new RectF(dirtyRect.X + padding, dirtyRect.Y + padding, dirtyRect.Width - (padding * 2), dirtyRect.Height - (padding * 2));

            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 22;

            canvas.DrawRoundedRectangle(innerRect, cornerRadius);
        }
    }
}
