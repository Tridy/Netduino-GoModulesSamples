using System.Threading;

namespace NetDuinoGoModulles
{
    public class Program
    {
        public static void Main()
        {
            NetduinoGo.RgbLed led = new NetduinoGo.RgbLed();

            Blink(led);

            Thread.Sleep(500);

            led.SetColor(0, 0, 0);
            Thread.Sleep(2000);
            led.SetColor(255, 0, 0);
            Thread.Sleep(2000);
            led.SetColor(0, 255, 0);
            Thread.Sleep(2000);
            led.SetColor(0, 0, 255);
            Thread.Sleep(2000);
            led.SetColor(255, 255, 0);
            Thread.Sleep(2000);
            led.SetColor(0, 255, 255);
            Thread.Sleep(2000);
            led.SetColor(255, 0, 255);
            Thread.Sleep(2000);
            led.SetColor(255, 255, 255);

            led.SetColor(0, 0, 0);

            Blink(led);

            // 255 - Full brightness
            // 0   - Off
        }

        private static void Blink(NetduinoGo.RgbLed led)
        {
            for (int i = 0; i < 4; i++)
            {
                led.SetColor(255, 255, 255);
                Thread.Sleep(200);
                led.SetColor(0, 0, 0);
                Thread.Sleep(200);
            }
        }
    }
}
