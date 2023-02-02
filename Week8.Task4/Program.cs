using Extensions;
using System.Xml;

using XmlWriter xmlWriter = XmlWriter.Create("test.xml");



xmlWriter.WriteStartDocument();
xmlWriter.WriteStartElement("Person");
var name = InputExtesions.ReadStringInput("введите ФИО");
xmlWriter.WriteAttributeString("name", name);
xmlWriter.WriteStartElement("Adress");

xmlWriter.WriteStartElement("Street");
var street = InputExtesions.ReadStringInput("введите Улицу");
xmlWriter.WriteString(street);
xmlWriter.WriteEndElement();

xmlWriter.WriteStartElement("HouseNumber");
var houseNumber = InputExtesions.ReadStringInput("введите Номер дома");
xmlWriter.WriteString(houseNumber);
xmlWriter.WriteEndElement();

xmlWriter.WriteStartElement("FlatNumber");
var flatNumber = InputExtesions.ReadStringInput("введите Номер квартиры");
xmlWriter.WriteString(flatNumber);
xmlWriter.WriteEndElement();

xmlWriter.WriteEndElement();

xmlWriter.WriteStartElement("Phones");

xmlWriter.WriteStartElement("MobilePhone");
var mobilePhone = InputExtesions.ReadStringInput("введите Мобильный телефон");
xmlWriter.WriteString(mobilePhone);
xmlWriter.WriteEndElement();

xmlWriter.WriteStartElement("FlatPhone");
var housePhone = InputExtesions.ReadStringInput("введите Домашний телефон");
xmlWriter.WriteString(housePhone);
xmlWriter.WriteEndElement();
xmlWriter.WriteEndElement();
xmlWriter.WriteEndElement();
xmlWriter.WriteEndDocument();