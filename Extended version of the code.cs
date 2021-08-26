//In this example, we are selecting document values in a certain hierarchy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Collections;
using System.Globalization;

namespace ConvertersSh
{
  
class Program
    {
        static void Main(string[] args)
        {
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("http://www.cbr.ru/scripts/xml_daily.asp");        
            XmlElement xRootFrint = xDoc.DocumentElement;
            XmlElement xRootRub = xDoc.DocumentElement;
            XmlElement xRootKron = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRootFrint)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode FieldoneFrint = xRootFrint.SelectSingleNode("Valute [@ID='R01135']");                                    
                        //Console.WriteLine(Fieldone.OuterXml);
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "Name" )//&& Fieldone == xRootFrint.SelectSingleNode("Valute [@ID='R01060']"))
                            {
                                Console.WriteLine($"Наименование: {FieldoneFrint.SelectSingleNode("Name").InnerText}");                       
                            }
                            if (childnode.Name == "Value")
                            {
                                Console.WriteLine($"Значение: {FieldoneFrint.SelectSingleNode("Value").InnerText}\n");
                            }
                            if (childnode.Name == "Nominal")
                            {
                                Console.WriteLine($"Номинал: {FieldoneFrint.SelectSingleNode("Nominal").InnerText}");
                                
                            }
                        }
                        break;                   
                }
                Console.WriteLine();
            }
            foreach (XmlNode xnode in xRootRub)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode FieldoneRub = xRootRub.SelectSingleNode("Valute [@ID='R01090B']");
                    //Console.WriteLine(Fieldone.OuterXml);
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "Name")//&& Fieldone == xRootFrint.SelectSingleNode("Valute [@ID='R01060']"))
                        {
                            Console.WriteLine($"Наименование: {FieldoneRub.SelectSingleNode("Name").InnerText}");
                        }
                        if (childnode.Name == "Value")
                        {
                            Console.WriteLine($"Значение: {FieldoneRub.SelectSingleNode("Value").InnerText}\n");
                        }
                        if (childnode.Name == "Nominal")
                        {
                            Console.WriteLine($"Номинал: {FieldoneRub.SelectSingleNode("Nominal").InnerText}");
                        }
                    }
                    break;
                }
                Console.WriteLine();
            }
            foreach (XmlNode xnode in xRootKron)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode FieldoneKron = xRootKron.SelectSingleNode("Valute [@ID='R01535']");
                    //Console.WriteLine(Fieldone.OuterXml);
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "Name")//&& Fieldone == xRootFrint.SelectSingleNode("Valute [@ID='R01060']"))
                        {
                            Console.WriteLine($"Наименование: {FieldoneKron.SelectSingleNode("Name").InnerText}");
                        }
                        if (childnode.Name == "Value")
                        {
                            Console.WriteLine($"Значение: {FieldoneKron.SelectSingleNode("Value").InnerText}\n");
                        }
                        if (childnode.Name == "Nominal")
                        {
                            Console.WriteLine($"Номинал: {FieldoneKron.SelectSingleNode("Nominal").InnerText}");
                        }                     
                    }
                    break;
                }               
            }                      
            // foreach (XmlNode xnode in xRootKron)
            // {
                // if (xnode.Attributes.Count > 0)
                // {
                    // XmlNode RUB = xRootRub.SelectSingleNode("Valute [@ID='R01090B']");
                    // XmlNode KRON = xRootKron.SelectSingleNode("Valute [@ID='R01535']");
                    // foreach (XmlNode childnode in xnode.ChildNodes)
                    // {
                       // if (childnode.Name == "Value")
                       // {
                            // for (int i = 1; i <= 5; i++)
                            // {
                                // double rub = Double.Parse(RUB.SelectSingleNode("Value").InnerText);
                                // double kron = Double.Parse(KRON.SelectSingleNode("Value").InnerText);
                                // Console.Write("Форинт: ");
                                // double Forint = Convert.ToDouble(Console.ReadLine());
                                // double rub_res = Forint / rub;
                                // Console.WriteLine("RUB:" + rub_res);                               
                                // double kron_res = Forint / kron;
                                // Console.WriteLine("KRON:" + kron +"\n");
                            // }                          
                        // }                       
                    // }                    
                // }
                Console.WriteLine("Stop pocess, please click enter");
                Console.ReadLine();
                break;
                  
        }
    }
}
