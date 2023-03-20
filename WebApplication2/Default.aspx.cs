using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BazaDataContext db = new BazaDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["AplikacjaConnectionString"].ConnectionString);

            uzytkownicy u = new uzytkownicy();
            u.email = "asdasd";
            u.imie = "Sebastian";
            u.nazwisko = "Sebastian";
            u.data_urodzenia = DateTime.Now;
            u.plec = 'K';
            u.login = "Seb";
            u.haslo = "AAA";

            db.uzytkownicy.InsertOnSubmit(u);
            

            int i = 20;
            foreach(uzytkownicy uu in db.uzytkownicy.Where(x=>x.id_uzytkownika%2==0))
            {
                uu.haslo += i.ToString();
                i++;
                Label1.Text += "___" + i.ToString();
            }

            db.uzytkownicy.DeleteAllOnSubmit(db.uzytkownicy.Where(x => x.id_uzytkownika <5));
            db.SubmitChanges();
        }
    }
}