// In this example, we get data from an XML file for currency conversion (RUB)
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
            XmlElement xRootKron = xDoc.DocumentElement;                              
            foreach (XmlNode xnode in xRootKron)
            {       
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode FORINT = xRootFrint.SelectSingleNode("Valute [@ID='R01135']");
                    XmlNode KRON = xRootKron.SelectSingleNode("Valute [@ID='R01535']");
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                       if (childnode.Name == "Value")
                       {
                            for (int i = 1; i <= 5; i++)
                            {                             
                                double kron_value = Double.Parse(KRON.SelectSingleNode("Value").InnerText);
                                double forint_value = Double.Parse(FORINT.SelectSingleNode("Value").InnerText);
                                double kron_naminal = Double.Parse(KRON.SelectSingleNode("Nominal").InnerText);
                                double forint_naminal = Double.Parse(FORINT.SelectSingleNode("Nominal").InnerText);
                                double kron = kron_value/kron_naminal;
                                double forint = forint_value / forint_naminal;
                                double correlation = forint / kron;
                                Console.Write("Венгерский Форинт: ");
                                double Forint = Convert.ToDouble(Console.ReadLine());                               
                                double kron_res = Forint * correlation;
                                Console.WriteLine("Норвежский крон:" + kron_res + "\n");
                            }                          
                        }                       
                    }                    
                }
                Console.WriteLine("Stop pocess, please click enter");
                Console.ReadLine();
                break;
            }      
        }
    }
}
