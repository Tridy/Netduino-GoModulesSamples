namespace PiezoBuzzerModule
{
    public class Program
    {
        public static void Main()
        {
            NetduinoGo.Potentiometer pot = new NetduinoGo.Potentiometer();
            NetduinoGo.PiezoBuzzer buzzer = new NetduinoGo.PiezoBuzzer();

            while (true)
            {
                buzzer.SetFrequency(pot.GetValue() * 2000);
            }
        }
    }
}
