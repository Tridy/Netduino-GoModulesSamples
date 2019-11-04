namespace PotentiometerModule
{
    public class Program
    {
        public static void Main()
        {
            NetduinoGo.RgbLed led = new NetduinoGo.RgbLed();
            NetduinoGo.Potentiometer pot = new NetduinoGo.Potentiometer();

            // pot.GetValue() - Returns a float from 0 to 1. 

            while (true)
            {
                var value = (byte)(pot.GetValue() * 255);
                led.SetColor(value, value, value);
            }
        }
    }
}
