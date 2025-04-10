using SplashKitSDK;

namespace DrawTriangleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Random Colourful Triangles", 800, 600);

            SplashKit.ClearScreen();
            for (int i = 0; i < 10; i++)
            {
                // Random point 1 for the triangle (x1,y1)
                int x1 = SplashKit.Rnd(800);
                int y1 = SplashKit.Rnd(600);

                // Random point 2 for the triangle (x2,y2)
                int x2 = SplashKit.Rnd(800);
                int y2 = SplashKit.Rnd(600);

                // Random point 3 for the triangle (x3,y3)
                int x3 = SplashKit.Rnd(800);
                int y3 = SplashKit.Rnd(600);

                // Draw triangle using the random points above
                SplashKit.DrawTriangle(SplashKit.RandomRGBColor(255), x1, y1, x2, y2, x3, y3);
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}