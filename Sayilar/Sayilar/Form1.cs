using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bildirim.ShowBalloonTip(1000, "Programa hoþ geldiniz!", "Nesne Yönelimli programlama Ödev 1\nTek Çift", ToolTipIcon.Info);
        }


        ListViewItem item;
        private void btnCalistir_Click(object sender, EventArgs e)
        {

            int intBaslangic;
            if (Int32.TryParse(txtBaslangic.Text, out intBaslangic) == false)
                intBaslangic = 0;

            int intBitis;
            if (Int32.TryParse(txtBitis.Text, out intBitis) == false)
                intBitis = 0;

            tekCiftSayiYaz(intBaslangic, intBitis);
     
            asalSayiYaz(intBaslangic, intBitis);

            mukemmelSayiYaz(intBaslangic, intBitis);

        }
         
        bool asalSayiKontrol(int kontrolEdilenSayi)
        {
            int i = 2;
            while(i<kontrolEdilenSayi)
            {
                if (kontrolEdilenSayi % i == 0)
                    break;
                
                i++;
            }
            if (kontrolEdilenSayi == i)
                return true;
            else if (kontrolEdilenSayi == 1)
                return false;

            return false;
        }

        int asalSayiYaz(int baslangic, int bitis)
        {
            string[] asalSayilarDizi = new string[3];
            

            for (int a = baslangic; a <= bitis; a++)
            {

                if (asalSayiKontrol(a) == true)
                {
                    int asallar = a;
                    string asalDizisi = asallar.ToString();
                    asalSayilarDizi[0] = asalDizisi;
                    
                    asalToplam += a;
                    string strAsalToplam = asalToplam.ToString();
                    asalSayilarDizi[1] = strAsalToplam;


                    asalCarpim *= a;
                    string strAsalCarpim = asalCarpim.ToString();
                    asalSayilarDizi[2]= strAsalCarpim;
 
                   
                    item = new ListViewItem(asalSayilarDizi);
                    listAsalSayi.Items.Add(item);
                }

            }
            return 0;
        }
        

        int tekToplam = 0, ciftToplam = 0, asalToplam = 0, mukemmelToplam = 0;
        int tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1, mukemmelCarpim = 1;

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listTekSayi.Items.Clear();
            listCiftSayi.Items.Clear();
            listAsalSayi.Items.Clear();
            listMukemmelSayi.Items.Clear();
        }

        int tekCiftSayiYaz(int bas, int bit)
        {
            string[] ciftSayilarDizi = new string[3];
            
            string[] tekSayilarDizi =new string[3];

            int i =0;
            for (i = bas; i <= bit; i++)
            {
                if ((i % 2) == 0)
                {
                                
                    int ciftler = i;
                    string ciftDizisi = "";
                    ciftDizisi = ciftler.ToString();
                    ciftSayilarDizi[0] = ciftDizisi;

                    
                    ciftToplam += i;
                    string ciftToplamDizisi = "";
                    ciftToplamDizisi = ciftToplam.ToString();
                    ciftSayilarDizi[1] = ciftToplamDizisi;

                 
                    ciftCarpim *= i;
                    string ciftCarpimDizisi = "";
                    ciftCarpimDizisi = ciftCarpim.ToString();
                    ciftSayilarDizi[2] = ciftCarpimDizisi;


                    item = new ListViewItem(ciftSayilarDizi);
                    listCiftSayi.Items.Add(item);            
                }
                else
                {
                  
                   int tekler = i;
                    string tekDizisi = "";
                    tekDizisi = tekler.ToString();
                    tekSayilarDizi[0] = tekDizisi;


                    tekToplam += i;
                    string tekToplamDizisi = "";
                    tekToplamDizisi = tekToplam.ToString();
                    tekSayilarDizi[1] = tekToplamDizisi;


                    tekCarpim *= i;
                    string tekCarpimDizisi = "";
                    tekCarpimDizisi = tekCarpim.ToString();
                    tekSayilarDizi[2] = tekCarpimDizisi;


                    item = new ListViewItem(tekSayilarDizi);
                    listTekSayi.Items.Add(item);

                }

            }

            return 0;
        }
        
        bool mukemmelSayiKontrol(int kontrolEdilenSayi)
        {
            int toplam = 0;

            for(int i=1;i<kontrolEdilenSayi;i++)
            {
                if(kontrolEdilenSayi % i == 0)
                {
                    toplam += i;
                }

            }
           
            return (kontrolEdilenSayi == toplam);
           
        }

        int mukemmelSayiYaz(int bas, int bit)
        {
            string[] mukemmelSayilarDizi = new string[3];

            for (int sayi=bas; sayi<bit; sayi++)
            { 
               if(mukemmelSayiKontrol(sayi))
                {
                    string mukemmelDizisi = "";
                    mukemmelDizisi = sayi.ToString();
                    mukemmelSayilarDizi[0] = mukemmelDizisi;


                    mukemmelToplam += sayi;
                    string mukemmelToplamDizisi = "";
                    mukemmelToplamDizisi = mukemmelToplam.ToString();
                    mukemmelSayilarDizi[1] = mukemmelToplamDizisi;


                    mukemmelCarpim *= sayi;
                    string mukemmelCarpimDizisi = "";
                    mukemmelCarpimDizisi = mukemmelCarpim.ToString();
                    mukemmelSayilarDizi[2] = mukemmelCarpimDizisi;


                    item = new ListViewItem(mukemmelSayilarDizi);
                    listMukemmelSayi.Items.Add(item);
                }
            }
            return 0;
    }

}
}