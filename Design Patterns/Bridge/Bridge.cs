using Design_Patterns.Tools;

namespace Design_Patterns.Bridge
{
    // رابط برای ویژگی‌های فرم
    public interface DrawingAPI
    {
        void DrawCircle(int radius, int x, int y);
        void DrawRectangle(int width, int height, int x, int y);
    }

    // رابط برای اشکال
    public abstract class Shape
    {
        protected DrawingAPI drawingAPI;

        protected Shape(DrawingAPI drawingAPI)
        {
            this.drawingAPI = drawingAPI;
        }

        public abstract void Draw();
    }

    // پیاده‌سازی اشکال
    public class Circle : Shape
    {
        private int radius;
        private int x;
        private int y;

        public Circle(int radius, int x, int y, DrawingAPI drawingAPI) : base(drawingAPI)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawingAPI.DrawCircle(radius, x, y);
        }
    }

    public class Rectangle : Shape
    {
        private int width;
        private int height;
        private int x;
        private int y;

        public Rectangle(int width, int height, int x, int y, DrawingAPI drawingAPI) : base(drawingAPI)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawingAPI.DrawRectangle(width, height, x, y);
        }
    }

    // پیاده‌سازی DrawingAPI برای رسم اشکال با کنسول
    public class ConsoleDrawingAPI : DrawingAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            LocalConsole.WriteLine($"Drawing Circle at ({x}, {y}) with radius {radius}");
        }

        public void DrawRectangle(int width, int height, int x, int y)
        {
            LocalConsole.WriteLine($"Drawing Rectangle at ({x}, {y}) with width {width} and height {height}");
        }
    }

    // پیاده‌سازی DrawingAPI برای رسم اشکال با گرافیک
    public class GraphicDrawingAPI : DrawingAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            // رسم دایره با استفاده از کتابخانه‌های گرافیک
            // (اینجا کد واقعی برای رسم دایره در یک محیط گرافیکی قرار می‌گیرد)
            LocalConsole.WriteLine($"Drawing Circle at ({x}, {y}) with radius {radius} in graphic environment");
        }

        public void DrawRectangle(int width, int height, int x, int y)
        {
            // رسم مستطیل با استفاده از کتابخانه‌های گرافیک
            // (اینجا کد واقعی برای رسم مستطیل در یک محیط گرافیکی قرار می‌گیرد)
            LocalConsole.WriteLine($"Drawing Rectangle at ({x}, {y}) with width {width} and height {height} in graphic environment");
        }
    }
}
