// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Xml;
while (true)
{
    List<User> users = new List<User>();
    Console.WriteLine("Введите имя пол и год рождения сотрудника:");
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.Load(@"C:\Users\User1\source\repos\XMLProject\XMLProject\bin\Debug\net6.0\people.xml");
    XmlElement newemployee = xmlDocument.DocumentElement;


    XmlElement userElem = xmlDocument.CreateElement("user");
    XmlAttribute nameAttr = xmlDocument.CreateAttribute("name");
    XmlElement sexElem = xmlDocument.CreateElement("sex");
    XmlElement birthyearElem = xmlDocument.CreateElement("birthyear");


    string name = Convert.ToString(Console.ReadLine());
    string sex = Convert.ToString(Console.ReadLine());
    string birthyear = Convert.ToString(Console.ReadLine());

    XmlText nameText = xmlDocument.CreateTextNode(name);
    XmlText sexText = xmlDocument.CreateTextNode(sex);
    XmlText birthyearText = xmlDocument.CreateTextNode(birthyear);

    nameAttr.AppendChild(nameText);
    sexElem.AppendChild(sexText);
    birthyearElem.AppendChild(birthyearText);

    userElem.Attributes.Append(nameAttr);
    userElem.AppendChild(sexElem);
    userElem.AppendChild(birthyearElem);
    newemployee.AppendChild(userElem);
    xmlDocument.Save("people.xml");

    XmlDocument xml = new XmlDocument();
    xml.Load(@"C:\Users\User1\source\repos\XMLProject\XMLProject\bin\Debug\net6.0\people.xml");
    XmlElement element = xml.DocumentElement;
    foreach (XmlElement xnode in element)
    {
        User user = new User();
        XmlNode attr = xnode.Attributes.GetNamedItem("name");
        if (attr != null)
            user.Name = attr.Value;

        foreach (XmlNode childnode in xnode.ChildNodes)
        {
            if (childnode.Name == "sex")
                user.Sex = childnode.InnerText;
            if (childnode.Name == "birthyear")
                user.Birthyear = Int32.Parse(childnode.InnerText);
        }
        users.Add(user);
    }
    foreach (User emp in users)
        Console.WriteLine($"{emp.Name}; {emp.Sex} пол - {emp.Birthyear} года рождения");
    Console.ReadKey();

}



public class User
{
    public string Name;
    public string Sex;
    public int Birthyear;
}








