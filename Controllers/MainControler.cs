using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Konus.Controllers
{
    public class MainControler : Controller
    {

        public DataTable dt = new DataTable();

        public SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;");



        [Authorize]
        public IActionResult Index()
        {
            List<string> id = new List<string>();
            List<string> baslik = new List<string>();
            List<string> yazi = new List<string>();
            List<string> tarih = new List<string>();

            con.Open();

            string query = "SELECT * FROM sinavlar";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
            da.Fill(dt);
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {

                id.Add(row[0].ToString());
                baslik.Add(row[1].ToString());
                yazi.Add(row[2].ToString());
                tarih.Add(row[3].ToString());


                count++;
            }

            con.Close();

            ViewBag.id = id;
            ViewBag.baslik = baslik;
            ViewBag.yazi = yazi;
            ViewBag.tarih = tarih;

            return View();
        }

    }
}