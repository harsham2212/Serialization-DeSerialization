using System;

namespace SerializationAndDeSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serializaton and Desserialization\n");
            //BinarySerialization.Serialization();
            //BinarySerialization.DeSerialization();

            XMLserialization xmlSerialization = new XMLserialization();
            JSONSerialization jSONSerialization = new JSONSerialization();

            //XMLserialization xmlSerialization = new XMLserialization();
            //xmlSerialization.SerializeDataSet("dataFile");


            ////JSONSerialization.JsonSerialization();
            //JSONSerialization.JsonDeSerialization();

            XMLserialization.SerializeXML();
            XMLserialization.DeSerializeXMl();
        }
    }
}
 