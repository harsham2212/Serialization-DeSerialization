using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SerializationAndDeSerialization
{
    public class XMLserialization
    {
        public static void SerializeXML()
        {
            XmlSerializer ser = new XmlSerializer (typeof(OrderForm));
            FileStream fileStream = new FileStream(@"E:\BridgeLAbz\demo\SerializationAndDeSerialization\Utility2\Sample2.txt",FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2021, 12, 20);
            orderForm.OrderDate = dt2;
            ser.Serialize(fileStream,orderForm);
        }

        public static void DeSerializeXMl()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"E:\BridgeLAbz\demo\SerializationAndDeSerialization\Utility2\Sample2.txt", FileMode.Open);
            OrderForm data = (OrderForm)ser.Deserialize(fileStream);
            Console.WriteLine(data.OrderDate);
        }

    }

    public class OrderForm
    {
        public DateTime OrderDate;
    }
}
