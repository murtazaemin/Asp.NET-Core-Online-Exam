using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HtmlAgilityPack;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Data.SQLite;
using Microsoft.AspNetCore.Http;

namespace Konus.Controllers
{
    
    
    public class SinavController : Controller
    {

        public String html;
        public Uri url;
        public string[] tittles = new string[5];
        public string[] links = new string[5];
        public string[] texts = new string[5];

        
        
      
       
        [Authorize]
        public IActionResult Index()
        {

            veriAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]/div/ul/li[2]/a[2]/h2", 0);
            linkAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]/div/ul/li[2]/a[2]", "href", 0);
            textAl("https://www.wired.com"+links[0], "//*[@id='main-content']/article/div[2]/div/div[1]/div/div[1]", 0);

            veriAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[2]/div/ul/li[2]/a[2]/h2", 1);
            linkAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[2]/div/ul/li[2]/a[2]","href", 1);
            textAl("https://www.wired.com" + links[1], "//*[@id='main-content']/article/div[2]/div/div[1]/div/div[1]", 1);

            veriAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[1]/div/ul/li[2]/a[2]/h2", 2);
            linkAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[1]/div/ul/li[2]/a[2]","href", 2);
            textAl("https://www.wired.com" + links[2], "//*[@id='main-content']/article/div[2]/div/div[1]/div/div[1]", 2);

            veriAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[2]/div/ul/li[2]/a[2]/h2", 3);
            linkAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[2]/div/ul/li[2]/a[2]", "href", 3);
            textAl("https://www.wired.com" + links[3], "//*[@id='main-content']/article/div[2]/div/div[1]/div/div[1]", 3);

            veriAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/ul/li[2]/a[2]/h2", 4);
            linkAl("https://www.wired.com/", "//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/ul/li[2]/a[2]", "href", 4);
            textAl("https://www.wired.com" + links[4], "//*[@id='main-content']/article/div[2]/div/div[1]/div/div[1]", 4);


            ViewBag.basliklar = new List<string>(tittles);
            ViewBag.yazilar = new List<string>(texts);

            

           

            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Kaydet(IFormCollection form)
        {
            int basliksecim = Convert.ToInt32(form["baslik"]);
            string yazi, tarih, soru1, soru2, soru3, soru4, cevap1a, cevap1b, cevap1c, cevap1d, cevap2a, cevap2b, cevap2c, cevap2d,
                cevap3a, cevap3b, cevap3c, cevap3d, cevap4a, cevap4b, cevap4c, cevap4d, cevap1, cevap2, cevap3, cevap4;

            tarih = DateTime.Now.ToLongDateString();

           

            yazi = form["yazi"];
            soru1 = form["soru1"];
            soru2 = form["soru2"];
            soru3 = form["soru3"];
            soru4 = form["soru4"];

            cevap1a = form["cevap1a"];
            cevap1b = form["cevap1b"];
            cevap1c = form["cevap1c"];
            cevap1d = form["cevap1d"];

            cevap2a = form["cevap2a"];
            cevap2b = form["cevap2b"];
            cevap2c = form["cevap2c"];
            cevap2d = form["cevap2d"];

            cevap3a = form["cevap3a"];
            cevap3b = form["cevap3b"];
            cevap3c = form["cevap3c"];
            cevap3d = form["cevap3d"];

            cevap4a = form["cevap4a"];
            cevap4b = form["cevap4b"];
            cevap4c = form["cevap4c"];
            cevap4d = form["cevap4d"];

            cevap1 = form["cevap1"];
            cevap2 = form["cevap2"];
            cevap3 = form["cevap3"];
            cevap4 = form["cevap4"];

            SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;");

            con.Open();

            string query1 = "INSERT INTO sinavlar (baslik,yazi,tarih) values (@baslik,@yazi,@tarih)";
            string query2 = "INSERT INTO sorular (soru1,soru2,soru3,soru4,cevap1a,cevap1b,cevap1c,cevap1d,cevap1,cevap2a,cevap2b,cevap2c,cevap2d,cevap2,cevap3a,cevap3b,cevap3c,cevap3d,cevap3,cevap4a,cevap4b,cevap4c,cevap4d,cevap4) " +
                                         "values (@soru1,@soru2,@soru3,@soru4,@cevap1a,@cevap1b,@cevap1c,@cevap1d,@cevap1,@cevap2a,@cevap2b,@cevap2c,@cevap2d,@cevap2,@cevap3a,@cevap3b,@cevap3c,@cevap3d,@cevap3,@cevap4a,@cevap4b,@cevap4c,@cevap4d,@cevap4)";

            SQLiteCommand com1 = new SQLiteCommand(query1, con);
            SQLiteCommand com2 = new SQLiteCommand(query2, con);

            if (basliksecim == 0)
                com1.Parameters.AddWithValue("@baslik", form["baslik1"]);
            else if (basliksecim == 1)
                com1.Parameters.AddWithValue("@baslik", form["baslik2"]);
            else if (basliksecim == 2)
                com1.Parameters.AddWithValue("@baslik", form["baslik3"]);
            else if (basliksecim == 3)
                com1.Parameters.AddWithValue("@baslik", form["baslik4"]);
            else if (basliksecim == 4)
                com1.Parameters.AddWithValue("@baslik", form["baslik5"]);
            com1.Parameters.AddWithValue("@yazi", form["yazi"]);
            com1.Parameters.AddWithValue("@tarih", tarih); 

            com1.ExecuteNonQuery();

            
            com2.Parameters.AddWithValue("@soru1", form["soru1"]);
            com2.Parameters.AddWithValue("@soru2", form["soru2"]);
            com2.Parameters.AddWithValue("@soru3", form["soru3"]);
            com2.Parameters.AddWithValue("@soru4", form["soru4"]);

            com2.Parameters.AddWithValue("@cevap1a", form["cevap1a"]);
            com2.Parameters.AddWithValue("@cevap1b", form["cevap1b"]);
            com2.Parameters.AddWithValue("@cevap1c", form["cevap1c"]);
            com2.Parameters.AddWithValue("@cevap1d", form["cevap1d"]);
            com2.Parameters.AddWithValue("@cevap1", form["cevap1"]);

            com2.Parameters.AddWithValue("@cevap2a", form["cevap2a"]);
            com2.Parameters.AddWithValue("@cevap2b", form["cevap2b"]);
            com2.Parameters.AddWithValue("@cevap2c", form["cevap2c"]);
            com2.Parameters.AddWithValue("@cevap2d", form["cevap2d"]);
            com2.Parameters.AddWithValue("@cevap2", form["cevap2"]);

            com2.Parameters.AddWithValue("@cevap3a", form["cevap3a"]);
            com2.Parameters.AddWithValue("@cevap3b", form["cevap3b"]);
            com2.Parameters.AddWithValue("@cevap3c", form["cevap3c"]);
            com2.Parameters.AddWithValue("@cevap3d", form["cevap3d"]);
            com2.Parameters.AddWithValue("@cevap3", form["cevap3"]);

            com2.Parameters.AddWithValue("@cevap4a", form["cevap4a"]);
            com2.Parameters.AddWithValue("@cevap4b", form["cevap4b"]);
            com2.Parameters.AddWithValue("@cevap4c", form["cevap4c"]);
            com2.Parameters.AddWithValue("@cevap4d", form["cevap4d"]);
            com2.Parameters.AddWithValue("@cevap4", form["cevap4"]);

            com2.ExecuteNonQuery();

            con.Close();
            return RedirectToAction("Index", "MainControler");

        }

        [Authorize]
        public IActionResult Sinav(int id)
        {
            List<string> sorular = new List<string>();
            List<string> cevaplar = new List<string>();
            List<string> dogrucevaplar = new List<string>();
            SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;");

            con.Open();

            string query1 = "SELECT * FROM sinavlar WHERE Id =" + id;
            string query2 = "SELECT * FROM sorular WHERE Id =" + id;
            SQLiteCommand com1 = new SQLiteCommand(query1, con);
            SQLiteCommand com2 = new SQLiteCommand(query2, con);

            using (SQLiteDataReader dr1 = com1.ExecuteReader())
            {
                if (dr1.Read())
                {
                    ViewBag.baslik = dr1["Baslik"];
                    ViewBag.yazi = dr1["Yazi"];
                }
                

            }
            using (SQLiteDataReader dr2 = com2.ExecuteReader())
            {
                if (dr2.Read())
                {
                    sorular.Add(dr2["Soru1"].ToString());
                    sorular.Add(dr2["Soru2"].ToString());
                    sorular.Add(dr2["Soru3"].ToString());
                    sorular.Add(dr2["Soru4"].ToString());
                    cevaplar.Add(dr2["Cevap1a"].ToString());
                    cevaplar.Add(dr2["Cevap1b"].ToString());
                    cevaplar.Add(dr2["Cevap1c"].ToString());
                    cevaplar.Add(dr2["Cevap1d"].ToString());
                    cevaplar.Add(dr2["Cevap2a"].ToString());
                    cevaplar.Add(dr2["Cevap2b"].ToString());
                    cevaplar.Add(dr2["Cevap2c"].ToString());
                    cevaplar.Add(dr2["Cevap2d"].ToString());
                    cevaplar.Add(dr2["Cevap3a"].ToString());
                    cevaplar.Add(dr2["Cevap3b"].ToString());
                    cevaplar.Add(dr2["Cevap3c"].ToString());
                    cevaplar.Add(dr2["Cevap3d"].ToString());
                    cevaplar.Add(dr2["Cevap4a"].ToString());
                    cevaplar.Add(dr2["Cevap4b"].ToString());
                    cevaplar.Add(dr2["Cevap4c"].ToString());
                    cevaplar.Add(dr2["Cevap4d"].ToString());
                    dogrucevaplar.Add(dr2["Cevap1"].ToString());
                    dogrucevaplar.Add(dr2["Cevap2"].ToString());
                    dogrucevaplar.Add(dr2["Cevap3"].ToString());
                    dogrucevaplar.Add(dr2["Cevap4"].ToString());
                }
            }
            ViewBag.sorular = sorular;
            ViewBag.cevaplar = cevaplar;
            ViewBag.dogrucevaplar = dogrucevaplar;
            con.Close();
            return View();
        }

        [Authorize]
        public IActionResult Sil(int id)
        {

            SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;");

            con.Open();

            string query1 = "DELETE FROM sinavlar WHERE Id = " + id;
            string query2 = "DELETE FROM sorular WHERE Id = " + id;


            SQLiteCommand com1 = new SQLiteCommand(query1, con);
            SQLiteCommand com2 = new SQLiteCommand(query2, con);

            com1.ExecuteNonQuery();
            com2.ExecuteNonQuery();

            con.Close();
            return RedirectToAction("Index", "MainControler");
        }

        public string veriAl( String Url, String Xpath ,int i )
        {
            url = new Uri(Url);

            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            html = client.DownloadString(url);

            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(html);

           
                tittles[i] = doc.DocumentNode.SelectSingleNode(Xpath).InnerText;

            return tittles[i]; 
        }

        public string linkAl(String Url, String Xpath,String link, int i)
        {
            url = new Uri(Url);

            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            html = client.DownloadString(url);

            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(html);


            links[i] = doc.DocumentNode.SelectSingleNode(Xpath).Attributes[link].Value;

            return links[i];
        }

        public string textAl(String Url, String Xpath, int i)
        {
            url = new Uri(Url);

            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            html = client.DownloadString(url);

            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(html);


            texts[i] = doc.DocumentNode.SelectSingleNode(Xpath).InnerText;

            return texts[i];
        }

    }
}
