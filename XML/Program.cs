using System.Xml.Serialization;

namespace XML
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person { Name = "John", Age = 30 };
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, person);
                string v = writer.ToString();
                Console.WriteLine(v);
            }

            string xmlString = "<Person><Name>John</Name><Age>30</Age></Person>";
            _ = new XmlSerializer(typeof(Person));
            using (StringReader reader = new StringReader(xmlString))
            {
                Person? person1 = (Person)serializer.Deserialize(reader);
                Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
            }
        }
    }
}
