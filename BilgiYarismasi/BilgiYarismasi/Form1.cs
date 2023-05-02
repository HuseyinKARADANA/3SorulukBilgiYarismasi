namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String cevap, cdogru;
        int SoruNo = 0, dogru = 0, yanlis = 0;
        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            SoruNo++;
            lbl_soruNo.Text = SoruNo.ToString();
            cdogru = "";
            if (SoruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                btn_A.Text = "1920";
                btn_B.Text = "1921";
                btn_C.Text = "1922";
                btn_D.Text = "1923";
                cdogru = "1923";


            }
            else if (SoruNo == 2)
            {
                richTextBox1.Text = "Hangi il ege b�lgesinde bulunmaz?";
                btn_A.Text = "�zmir";
                btn_B.Text = "Bal�kesir";
                btn_C.Text = "Ayd�n";
                btn_D.Text = "Manisa";
                cdogru = "Bal�kesir";
            }
            else if (SoruNo == 3)
            {
                richTextBox1.Text = "Son Ku�lar hangi yazara aittir?";
                btn_A.Text = "Sait Faik";
                btn_B.Text = "Cemal S�reyya";
                btn_C.Text = "Atilla �lhan";
                btn_D.Text = "Re�at Nuri";
                cdogru = "Sait Faik";
            }
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_sonraki.Enabled = false;
            img_dogru.Visible = false;
            img_yanlis.Visible = false;
            if (SoruNo == 4)
            {
                btn_A.Enabled = false;
                btn_B.Enabled=false;
                btn_C.Enabled=false;
                btn_D.Enabled=false;
                richTextBox1.Text = "Sorular� Bitirdiniz Tebrik Ederiz";
                lbl_soruNo.Text = "3";
            }

        }

        private void btn_A_Click(object sender, EventArgs e)
        {

            cevap = btn_A.Text;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            if (cevap == cdogru)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                img_dogru.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                img_yanlis.Visible = true;
            }
            btn_sonraki.Enabled = true;
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            cevap = btn_B.Text;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            if (cevap == cdogru)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                img_dogru.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                img_yanlis.Visible = true;
            }
            btn_sonraki.Enabled = true;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            cevap = btn_C.Text;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            if (cevap == cdogru)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                img_dogru.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                img_yanlis.Visible = true;
            }
            btn_sonraki.Enabled = true;
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            cevap = btn_D.Text;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            if (cevap == cdogru)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                img_dogru.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                img_yanlis.Visible = true;
            }
            btn_sonraki.Enabled = true;
        }

        private void btn_D_Click_1(object sender, EventArgs e)
        {
            cevap = btn_D.Text;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            if (cevap == cdogru)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                img_dogru.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                img_yanlis.Visible = true;
            }
            btn_sonraki.Enabled = true;
        }
    }
}