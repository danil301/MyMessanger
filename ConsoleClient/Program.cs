using System;
using Newtonsoft.Json;

namespace MyMessanger 
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{"UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-10-02T12:23:14.315288Z"}
            //RusAl < 02.10.2022 12:23:14 >: Privet
            
        }
    }
}
 
