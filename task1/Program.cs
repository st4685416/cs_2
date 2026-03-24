using System.Text;

namespace task1
{
    
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            TempSensor tempSensor=new TempSensor();
            tempSensor.TempChanged += new Display().ShowTemp;
            tempSensor.TempChanged += new AirConditioner().ChangeMode;
            tempSensor.TempChanged += new SecuritySystem().ShowWarning;
            
            tempSensor.OnTempChanged(0);
            tempSensor.OnTempChanged(10);
            tempSensor.OnTempChanged(20);
            tempSensor.OnTempChanged(30);
            tempSensor.OnTempChanged(50);
        }
    }
}