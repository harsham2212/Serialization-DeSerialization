using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeSerialization
{
    public class BinarySerialization
    {
        public static void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"E:\BridgeLAbz\demo\SerializationAndDeSerialization\Utility\Sample1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }

        public static void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"E:\BridgeLAbz\demo\SerializationAndDeSerialization\Utility\Sample1.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {deserializedSampleDemo.ApplicationName} ---- ApplicationID {deserializedSampleDemo.ApplicationID}");
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialization";
        public int ApplicationID { get; set; } = 1001;
    }
}
