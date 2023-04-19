using System;
using System.Xml;

public class XMLParser
{
  public static void Main()
  {
    // XML verisini bir dize olarak tanımlayın
    string xmlData = "<xmlroot><kisi><isim>Emrah</isim><yas>30</yas></kisi><kisi><isim>Hasan</isim><yas>25</yas></kisi></xmlroot>";
    
    // XML verisini XmlDocument sınıfı ile yükleyin
    XmlDocument xmlDoc = new XmlDocument();
    xmlDoc.LoadXml(xmlData);
    
    // XPath ile XML verisini analiz ederek örnek loop xml verisine göre 'kisi'ler verilerini kullanalım
    XmlNodeList kisiList = xmlDoc.SelectNodes("//kisi");
    
    // Her "kisi" satırı için döngü başlatın ve verilere erişin
    foreach (XmlNode kisiDetail in kisiList)
    {
      string isim = kisiDetail.SelectSingleNode("isim").InnerText; // "isim" içeriğini alın
      int yas = Convert.ToInt32(kisiDetail.SelectSingleNode("yas").InnerText); // "yas" içeriğini alın
      
      // Verileri ekrana yazdırın
      Console.WriteLine("İsim: " + isim);
      Console.WriteLine("Yaş: " + yas);
      Console.WriteLine();
    }
  }
}
