using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WMPLib;

namespace Patriot
{
    public partial class Form1 : Form
    {
        static Image medalBronzePic = Properties.Resources.бронзовая_медаль_removebg_preview;
        static Image medalGoldPic = Properties.Resources.золотая_медаль_removebg_preview;
        static Image medalSilverPic = Properties.Resources.серебрянная_медаль_removebg_preview;
        static bool exit = false;

        static Sportmans Sportmans = new Sportmans();

        static List<Control> list_infoF = new List<Control>();
        static List<Control> list_text = new List<Control>();
        static bool[] logics = new bool[16];

        static string logic_txt;
        static int logic_int;
        static bool logic;

        public void GetMedal(PictureBox firstmedal, Image firstpicture, PictureBox noSecondMedal, PictureBox noThirdMedal)
        {
            firstmedal.Image = firstpicture;
            firstmedal.Location = new Point((int)57 / 2 + 8, 434 - 86);
            firstmedal.Visible = true;
            noSecondMedal.Visible = false;
            noThirdMedal.Visible = false;
        }
        public void GetMedal(PictureBox firstmedal, Image firstpicture, PictureBox secondMedal, Image secondPicture, PictureBox noThirdMedal)
        {
            firstmedal.Image = firstpicture;
            firstmedal.Location = new Point((int)57 / 2 + 8, 247 + 10);
            secondMedal.Image = secondPicture;
            secondMedal.Location = new Point((int)57 / 2 + 8, 434 - 15);
            firstmedal.Visible = true;
            secondMedal.Visible = true;
            noThirdMedal.Visible = false;
        }
        public void getAllMedal()
        {
            pictureBox2.Image = medalGoldPic;
            pictureBox2.Location = new Point((int)57 / 2 + 8, 247 - 43);
            pictureBox3.Image = medalSilverPic;
            pictureBox3.Location = new Point((int)57 / 2 + 8, 434 - 86);
            pictureBox4.Image = medalBronzePic;
            pictureBox4.Location = new Point((int)57 / 2 + 8, 619 - 129);
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }
        public void labelEnable(Label label)
        {
            for (int i = 0; i < massLabel.Length; i++)
            {
                if (massLabel[i].Font.Bold)
                {
                    massLabel[i].Font = new Font(massLabel[i].Font, massLabel[i].Font.Style ^ FontStyle.Bold);
                }
            }

            label.Font = new Font(label.Font, label.Font.Style | FontStyle.Bold);
        }
        public void labelUpSize(Label label)
        {
            label.Font = new Font(label.Font.Name, 18, label.Font.Style);
        }
        public void labelLowerSize(Label label)
        {
            label.Font = new Font(label.Font.Name, 16, label.Font.Style);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public Label[] massLabel = new Label[15];
        private void label14_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 7;
            exit = true;
            label19.Text = "Летние Олимпийские игры в 2004 году проводились в Пекине (Китай) с 8 по 24 августа."+
            " В программу Игр вошли следующие виды спорта: академическая гребля, бадминтон, баскетбол, бейсбол, бокс, борьба, велоспорт."+
            " На Олимпиаде было разыграно 302 комплекта медалей в 34 видах, на один комплект больше, чем 4 года назад."+
            " Беларусь была представлена 181 спортсменом, выступавшими в соревнованиях по 26 видам спорта."+
            " 28 спортсменов завоевали 14 медалей: 3 золотых, 4 серебряных и 7 бронзовых."+
            " Республика Беларусь по общему количеству завоеванных наград – 16-е место.";
            labelEnable(label14);
            getAllMedal();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            list_infoF.Add(infoL1);
            list_infoF.Add(infoL2);
            list_infoF.Add(infoL3);
            list_infoF.Add(infoL4);
            list_infoF.Add(infoL5);
            list_infoF.Add(infoL6);
            list_infoF.Add(infoL7);

            list_text.Add(text1);
            list_text.Add(text2);
            list_text.Add(text3);
            list_text.Add(text4);
            list_text.Add(text5);
            list_text.Add(text6);
            list_text.Add(text7);
            list_text.Add(text8);
            list_text.Add(text9);
            list_text.Add(text10);
            list_text.Add(text11);
            list_text.Add(text12);
            list_text.Add(text13);
            list_text.Add(text14);
            list_text.Add(text15);
            list_text.Add(text16);
            list_text.Add(text17);

            list_text.Add(SSSR1);
            list_text.Add(SSSR2);
            list_text.Add(SSSR3);
            list_text.Add(SSSR4);

            massLabel[0] = label3;
            massLabel[1] = label4;
            massLabel[2] = label9; 
            massLabel[3] = label8;
            massLabel[4] = label7;
            massLabel[5] = label6;
            massLabel[6] = label5;
            massLabel[7] = label14;
            massLabel[8] = label13;
            massLabel[9] = label12;
            massLabel[10] = label11;
            massLabel[11] = label10;
            massLabel[12] = label17;
            massLabel[13] = label16;
            massLabel[14] = label15;
            clear();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 3;
            exit = true;
            label19.Text = "Летние Олимпийские игры в 2000 году проводились в Сиднее (Австралия) с 15 сентября по 1 октября."+
            " Олимпийские игры в Сиднее были наиболее представительными за всю историю современного олимпийского движения." +
            " В них приняли участие около 11000 спортсменов и 5100 официальных лиц из 199 стран, разыграно 300 комплектов медалей в 28 видах спорта."+
            " Беларусь представляли 141 спортсмен, которые выступили в 21 виде спорта." +
            " Белорусские олимпийцы завоевали 17 медалей: 3 золотых, 3 серебряных и 11 бронзовых."+
            " Республика Беларусь в неофициальном командном зачете заняла 23-е, а по общему количеству завоеванных наград – 15-е место.";
            labelEnable(label8);
            getAllMedal();
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label3);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label3);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 0;
            exit = true;
            label19.Visible = true;
            label19.Text = "Зимние Олимпийские игры в 1994 году проводились в Лиллехаммере (Норвегия) С 12 по 27 февраля."+
            " Эти олимпийские игры вошли в историю мирового и белорусского спорта. Мирового — потому что" +
            " стали первой Белой Олимпиадой, прошедшей не в один год с летней. Белорусского — из-за того," +
            " что стали первыми Играми, на которых наши спортсмены выступили отдельной командой, представляя суверенную страну." +
            " И начали отсчет медалям, завоеванным на главных стартах четырехлетия." +
            " Белорусская команда на зимних Играх привезла в Норвегию 33 спортсмена, которые выступали в 7 видах спорта." +
            " Всего Беларусь завоевала две серебряные медали.";
            labelEnable(label3);
            GetMedal(pictureBox3, medalSilverPic, pictureBox2, pictureBox4);
        }
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label4);
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label4);
        }
        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label9);
        }
        private void label9_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label9);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label8);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label8);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 4;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 2002 году проводились в Солт-Лейк-Сити (США) с 8 по 22 февраля."+
            " В этих олимпийских играх участников было рекордное количество – 2 399 спортсменов из 77 стран." +
            " Разыграно 78 комплектов медалей. В программе Олимпиады были новые дисциплины:" +
            " скелетон, бобслей, гонки преследования в биатлоне, спринт у двоеборцев, спринт в лыжных гонках, дистанция 1500 метров в шорт - треке."+
            " Беларусь представляли 64 спортсмена в 9 видах спорта, удалось завоевать лишь одну бронзовую медаль.";
            labelEnable(label7);
            GetMedal(pictureBox4, medalBronzePic, pictureBox2, pictureBox3);
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label7);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label7);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 5;
            exit = true;
            label19.Text = "Летние Олимпийские игры в 2004 году проводились в Афинах (Греция) с 13 сентября по 29 августа."+
            " В соревнованиях приняли участие 10 625 спортсменов из 201 страны." +
            " Всего был разыгран 301 комплект наград в 28 видах спорта."+
            " Беларусь была представлена 151 спортсменом, выступавшим в соревнованиях по 23 видам спорта." +
            " Завоевано 15 медалей: 2 золотые, 6 серебряных и 7 бронзовых." +
            " Республика Беларусь в неофициальном командном зачете заняла 26-е, а по общему количеству завоеванных наград – 18-е место.";
            labelEnable(label6);
            getAllMedal();
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label6);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label6);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label5);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label5);
        }

        private void label14_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label14);
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label14);
        }

        private void label13_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label13);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label13);
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label12);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label12);
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label11);
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label11);
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label10);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label10);
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label17);
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label17);
        }

        private void label16_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label16);
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label16);
        }

        private void label15_MouseMove(object sender, MouseEventArgs e)
        {
            labelUpSize(label15);
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            labelLowerSize(label15);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 1;
            exit = true;
            label19.Text = "Летние Олимпийские игры в 1996 году проводились в Атланте (штат Джорджия, США) с 19 июля по 4 августа."+
            " В программу включены соревнования по пляжному волейболу." +
            " На Олимпийских играх дебютировали софтбол, пляжный волейбол, маунтинбайк, женский футбол и гонки экипажей лёгкого веса в академической гребле."+
            " Команда Республики Беларусь была представлена 144 спортсменами, выступившими в 21 виде спорта." +
            " В результате 16 - дневной спортивной борьбы 20 белорусских спортсменов завоевали 15 медалей(1 золотая, 6 серебряных, 8 бронзовых) в 6 видах спорта." +
            " В неофициальном командном зачете Беларусь заняла 37-е место, а по количеству выигранных медалей – 23-е место.";
            labelEnable(label4);
            getAllMedal();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 2;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 1998 году проводились в Нагано (Хонсю, Япония) с 2 по 22 февраля."+
            " На Играх 1998 года участвовало 72 страны(2338 спортсменов: 1528 мужчин и 810 женщин)." +
            " Программа включала 14 видов спорта и 68 дисциплин."+
            " В Японию белорусские спортсмены отправились составом из 58 атлетов и соревновались в девяти видах спорта." +
            " К семи видам Лиллехаммера добавились горнолыжный спорт и хоккей."+
            " На этой олимпиаде наши спортсмены завоевали две бронзовые награды.В индивидуальной биатлонной гонке.";
            labelEnable(label9);
            GetMedal(pictureBox4,medalBronzePic,pictureBox2,pictureBox3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 6;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 2006 году проводились в Турине (Италия) с 10 по 26 февраля."+
            " В соревнованиях приняли участие 2508 атлетов из 80 стран." +
            " В 15 видах спорта были разыграны 84 комплекта наград – на шесть больше, чем в Солт-Лейк-Сити в 2002-м."+
            " Белорусские спортсмены приняли участие в своих четвертых зимних Олимпийских играх." +
            " Беларусь представляли 28 спортсменов в 7 спортивных дисциплинах." +
            " Медали завоевывали на них представители только трех видов: фристайла(3 медали), биатлона(2 медали) и конькобежного спорта(1 медаль).";
            labelEnable(label5);
            GetMedal(pictureBox3, medalSilverPic, pictureBox2, pictureBox4);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 8;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 2010 году проводились в Ванкувер (Канада) с 12 по 28 февраля."+
            " В олимпиаде приняли участие 2566 спортсменов из 82 стран." +
            " В ходе соревнований разыграли 86 комплектов наград в 15 видах спорта." +
            " По сравнению с предыдущими Играми в программу была включена новая дисциплина — ски-кросс среди мужчин и женщин."+
            " Беларусь приняла участие в своих пятых зимних Олимпийских играх.Её представляли 49 спортсменов(35 мужчин и 14 женщин) в 6 спортивных дисциплинах." +
            " Было завоевано 3 медали: 1 золото, 1 серебро, 1 бронза.";
            labelEnable(label13);
            getAllMedal();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 9;
            exit = true;
            label19.Text = "Летние Олимпийские игры в 2012 году проводились в Лондоне (Великобритания) с 27 июля по 12 августа."+
            " В соревнованиях приняли участие спортсмены из 204 стран." +
            " 4 участника выступали под флагом МОК.Всего соревнования проходят по 26 видам спорта и 39 спортивным дисциплинам."+
            " Беларусь была представлена 173 спортсменами в 25 видах спорта."+
            " Всего белорусские спортсмены завоевали 12 медалей: 2 золотые, 5 серебряных и 5 бронзовых." +
            " В медальном зачете Олимпиады Беларусь заняла 26-е место.";
            labelEnable(label12);
            getAllMedal();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 10;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 2014 году проводились в Сочи (Россия) с 7 по 23 февраля."+
            " Участвовало 2 800 спортсменов из 88 стран." +
            " В 15 дисциплинах 7 видов спорта разыграно 98 комплектов медалей." +
            " В программу было включено пять новых соревнований."+
            " Беларусь представляли 26 спортсменов(15 мужчин и 11 женщин)." +
            " По итогам Олимпиады  у сборной Беларуси – 6 медалей: 5 золотых и 1 бронзовая." +
            " По количеству наград высшей пробы за всю суверенную историю страны это новый рекорд: на одно золото больше прошлого достижения на летней Олимпиаде Пекин-2008."+
            " В неофициальном командном зачете спортсмены сборной Беларуси заняли 8-е место.";
            labelEnable(label11);
            GetMedal(pictureBox2,medalGoldPic, pictureBox4,medalBronzePic,pictureBox3);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 11;
            exit = true;
            label19.Text = "Летние Олимпийские игры в 2016 году проводились в Рио-да-Жанейро (Бразилия) с 5 по 21 августа."+
            " На Олимпиаде было разыграно рекордное количество комплектов медалей – 306, приняло участие рекордное число стран - 207." +
            " В список олимпийских видов спорта вошли регби-7(упрощённая версия регби) и гольф."+
            " В составе белорусской делегации было около 200 человек, из них 57 тренеров и 123 спортсмена," +
            " которые выступали в 23 видах спорта, 75 дисциплинах олимпийской программы. 12 атлетов стали призерами олимпийских состязаний." +
            " Беларусским спортсменам удалось завоевать 9 медалей: 1 золотая, 4 серебряные, 4 бронзовые."+
            " В неофициальном командном зачете Беларусь заняла 40-е место.";
            labelEnable(label10);
            getAllMedal();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 12;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 2018 году проводились в Пхенчхане (Республика Корея) с 9 по 25 февраля."+
            " В Играх приняли участие 2 900 спортсменов." +
            " 102 комплекта наград были разыграны в 7 видах спорта, включающих 15 зимних спортивных дисциплин." +
            " Игры стали первыми зимними Олимпийскими играми, на которых разыграли более 100 золотых медалей."+
            " Побороться за медали в Пхенчхан отправились 28 белорусских атлета," +
            " которые приняли участие в соревнованиях по 6 видам спорта: биатлон, горнолыжный спорт, конькобежный спорт, лыжные гонки, фристайл и шорт-трек."+
            " На счету белорусских атлетов 3 медали: 2 золота и 1 серебро." +
            " В неофициальном командном зачете Беларусь заняла 15-е место.";
            labelEnable(label17);
            GetMedal(pictureBox2, medalGoldPic, pictureBox3, medalSilverPic, pictureBox4);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 13;
            exit = true;
            label19.Text = "Летние Олимпийские игры из-за пандемии коронавируса COVID-19 состоялись в 2021 году и проводились в Токио (Япония) с 23 июля по 8 августа."+
            " Главный турнир четырехлетия принял 11656 лучших спортсменов планеты." +
            " Здесь разыграли 339 комплектов медалей в 33 видах спорта." +
            " В традиционные олимпийские виды спорта были добавлены 16 новых дисциплин."+
            " Нашу страну на главных стартах четырехлетия представили 107 спортсменов в 20 видах спорта."+
            " Спортсмены сборной Беларуси завоевали 7 медалей: 1 золото, 3 серебра и 3 бронзы." +
            " В неофициальном командном зачете Беларусь заняла 45-е место.";
            labelEnable(label16);
            getAllMedal();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            DissableEuroPic();
            DissableSSSRButton();
            clear();
            logic_int = 14;
            exit = true;
            label19.Text = "Зимние Олимпийские игры в 2022 году проводились в Пекине (Китай) с 4 по 20 февраля."+
            " В них участвовали более 4 тысяч спортсменов из 95 стран. Всего было разыграно 109 комплектов наград в 15 видах спорта."+
            " Белорусская сборная была представлена 29 спортсменами в " +
            "6 видах спорта: биатлоне, горнолыжном спорте, конькобежном спорте, лыжных гонках, фигурном катании и фристайле."+
            " Для нашей сборной команды эти зимние игры стали восьмыми в суверенной истории." +
            " У белорусской сборной есть два коронных вида спорта – биатлон и фристайл," +
            " которые в основном и пополняют копилку всей команды." +
            " Беларусским спортсменам удалось завоевать 2 серебряные медали." +
            " По итогам Игр в медальном зачете наша страна заняла 24-е место.";
            labelEnable(label15);
            GetMedal(pictureBox3, medalSilverPic,pictureBox2,pictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DissableSSSRButton();
            clear();
            pictureBox2.Visible = false;
            pictureBox3.Visible=false;
            pictureBox4.Visible = false;
            EuroPic1.Visible = false;
            PictureBox8.Image = Properties.Resources.Рисунок33;
            for (int i = 0; i < massLabel.Length; i++)
            {
                if (massLabel[i].Font.Bold)
                {
                    massLabel[i].Font = new Font(massLabel[i].Font, massLabel[i].Font.Style ^ FontStyle.Bold);
                }
            }
            label19.Visible = true;
            label19.Text = "История Олимпийского движения в Беларуси начинается с 1952 года," +
                "когда впервые советские спортсмены, а в их числе и белорусы, приняли участие в ХV летних Олимпийских играх в столице Финляндии – Хельсинки." +
                "На протяжении этого периода, богатого событиями, олимпийское движение развивалось, приспосабливалось к социальным, экономическим и политическим изменениям." +
                " С получением республикой государственного суверенитета 22 марта 1991 года на учредительной конференции в Минске был создан Национальный олимпийский комитет Республики Беларусь." +
                " Он является самостоятельным общественным объединением, статус и роль которого полностью соответствуют Олимпийской Хартии и Закону Республики Беларусь «О физической культуре и спорте».";
        }

        async private void pictureBox2_Click (object sender, EventArgs e)
        {            
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            exit = false;
            while (pictureBox2.Location.Y < 434 - 86)
            {
                if (exit) break;
                await Task.Delay(1);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + pictureBox2.Location.Y/105);
            }
            if (exit)
                pictureBox2.Image = medalGoldPic;
            else pictureBox2.Image = Properties.Resources.золотаямедаль;
            logic_txt = "З";
            label_logic(logic_int, logic_txt);
        }

        async private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            exit = false;
            while (pictureBox3.Location.Y > 434 - 86)
            {
                if (exit) break;
                await Task.Delay(1);
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - pictureBox3.Location.Y / 105);
            }
            if (exit)
                pictureBox3.Image = medalSilverPic;
            else pictureBox3.Image = Properties.Resources.серебряннаямедаль;
            logic_txt = "C";
            label_logic(logic_int, logic_txt);
        }

        async private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            exit = false;
            while ( pictureBox4.Location.Y >= 434 - 86)
            {
                if(exit) break;
                await Task.Delay(1);
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - pictureBox4.Location.Y/145);
            }
            if (exit)
                pictureBox4.Image = medalBronzePic;
            else pictureBox4.Image = Properties.Resources.бронзоваямедаль;
            logic_txt = "Б";
            label_logic(logic_int, logic_txt);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            for (int i = 0; i < list_text.Count; i++)
            {
                list_text[i].Visible = false;
                list_text[i].Location = new Point(0, 0);
            }
            for (int i = 0; i < list_infoF.Count; i++)
            {
                list_infoF[i].Visible = false;
                list_infoF[i].Location = new Point(0, 0);
            }
        }
        private void set_info(int x, int y, int sX, int sY, string text, int index) 
        {
            list_infoF[index].Location = new Point(x, y);
            list_infoF[index].Text = text;
            list_infoF[index].Size = new Size(sX, sY);
        }

        private void set_text(int x, int y, string text, int index)
        {
            list_text[index].Text = text;
            list_text[index].Location = new Point(x, y);
        }

        private void label_logic(int logic, string logic_txt)
        {
            label19.Text = "";
            switch (logic)
            {
                // 1994
                case 0:
                    for (int i = 0; i < 2; i++) { list_text[i].Visible = true; }
                    for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                    set_info(196, 240, 346, 39, "Конькобежный спорт", 0);
                    set_info(546, 240, 339, 39, "Биатлон", 1);
                    set_text(196, 296, "Игорь Железовский", 0);
                    set_text(546, 296, "Светлана Парамыгина", 1);
                    break;

                // 1996
                case 1:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Академическая гребля", 0);
                            set_text(453, 296, "Екатерина Карстен", 0);
                            break;

                        case ("C"):
                            for (int i = 0; i < 6; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 227, 39, "Легкая атлетика", 0);
                            set_info(426, 240, 227, 39, "Борьба", 1);
                            set_info(658, 240, 227, 39, "Стрельба", 2);

                            set_text(196, 296, "Владимир Дубровщик", 0);
                            set_text(196, 326, "Наталья Сазанович", 1);
                            set_text(658, 296, "Игорь Басинский", 2);
                            set_text(426, 296, "Александр Павлов", 3);
                            set_text(426, 326, "Сергей Лиштван", 4);
                            set_text(426, 356, "Алексей Медведев", 5);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 12; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 4; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 177, 39, "Легкая атлетика", 0);
                            set_info(376, 240, 147, 39, "Борьба", 1);
                            set_info(526, 240, 177, 39, "Спорт.гимнастика", 2);
                            set_info(708, 240, 177, 39, "Академич.гребля", 3);

                            set_text(196, 296, "Василий Каптюх", 0);
                            set_text(196, 326, "Эллина Зверева", 1);

                            set_text(366, 296, "Валерий Циленьть", 2);
                            set_text(546, 296, "Виталий Щербо", 3);

                            set_text(708, 296, "Елена Микулич", 4);
                            set_text(708, 326, "Марина Знак", 5);
                            set_text(708, 356, "Наталья Волчек", 6);
                            set_text(708, 386, "Наталья Стасюк", 7);
                            set_text(708, 416, "Тамара Давыденко", 8);
                            set_text(708, 446, "Валентина Скрабатун", 9);
                            set_text(708, 476, "Наталья Лавриненко", 10);
                            set_text(708, 506, "Александра Панькина", 11);
                            break;
                    }
                    break;

                // 1998
                case 2:
                    for (int i = 0; i < 2; i++) { list_text[i].Visible = true; }
                    for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                    set_info(196, 240, 346, 39, "Фристайл ", 0);
                    set_info(546, 240, 339, 39, "Биатлон", 1);

                    set_text(196, 296, "Дмитрий Владимирович", 0);
                    set_text(546, 296, "Алексей Петрович Айдаров", 1);
                    break;

                // 2000
                case 3:
                    switch (logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 3; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Метание", 0);
                            set_info(546, 240, 339, 39, "Гребля", 1);

                            set_text(196, 296, "Екатерина Карстен", 0);
                            set_text(196, 326, "Янина Корольчик", 1);
                            set_text(546, 296, "Эллина Зверева", 2);
                            break;

                        case ("C"):
                            for (int i = 0; i < 2; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Художественная гимнастика", 0);
                            set_info(546, 240, 339, 39, "Стрельба", 1);

                            set_text(196, 296, "Юлия Раскина", 0);
                            set_text(546, 296, "Игорь Басинский", 1);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 11; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 6; i++) { list_infoF[i].Visible = true; }

                            set_info(196, 240, 227, 39, "Метание", 0);
                            set_info(426, 240, 227, 39, "Многоборье", 1);
                            set_info(656, 240, 227, 39, "Дзюдо", 2);
                            set_info(196, 440, 227, 39, "Тяжёлая атлетика", 3);
                            set_info(426, 440, 227, 39, "Борьба греко-римская", 4);
                            set_info(656, 440, 227, 39, "Стрельба", 5);

                            set_text(196, 296, "Ирина Ятченко", 0);
                            set_text(196, 326, "Игорь Астапкович", 1);
                            set_text(426, 296, "Наталья Сазанович", 2);
                            set_text(426, 326, "Павел Довгаль", 3);
                            set_text(656, 296, "Анатолий Ларюков", 4);
                            set_text(656, 496, "Игорь Басинский", 5);
                            set_text(656, 526, "Лолита Евглевская", 6);
                            set_text(656, 556, "Сергей Мартынов", 7);

                            set_text(196, 496, "Геннадий Олещук", 8);
                            set_text(196, 526, "Сергей Лавренов", 9);
                            set_text(426, 496, "Дмитрий Дебелка", 10);
                            break;
                    }
                    break;

                // 2002
                case 4:
                    for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                    for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                    set_info(196, 240, 690, 39, "Фристайл", 0);
                    set_text(465, 296, "Алексей Гришин", 0);
                    break;

                // 2004
                case 5:
                    switch(logic_txt)
                    {
                        case ("З"):
                            ////////////////////////////
                            for (int i = 0; i < 2; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Лёгкая атлетика ", 0);
                            set_info(546, 240, 339, 39, "Дзюдо", 1);
                            set_text(200, 296, "Юлия Нестеренко", 0);
                            set_text(550, 296, "Игорь Макаров", 1);
                            break;

                        case ("C"):
                            for (int i = 0; i < 5; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 227, 39, "Бокс", 0);
                            set_info(426, 240, 227, 39, "Академическая гребля", 1);
                            set_info(658, 240, 227, 39, "Тяжёлая атлетика", 2);

                            text1.Text = "Магомед Арипгаджиев";
                            text1.Location = new Point(262 - 66, 296);
                            text2.Text = "Виктор Зуев";
                            text2.Location = new Point(262 - 66, 326);
                            text3.Text = "Екатерина Карстен";
                            text3.Location = new Point(570 - 144, 296);
                            text4.Text = "Андрей Рыбаков";
                            text4.Location = new Point(802 - 144, 296);
                            text5.Text = "Анна Батюшко";
                            text5.Location = new Point(802 - 144, 326);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 8; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 6; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 227, 39, "Гребля", 0);
                            set_info(426, 240, 227, 39, "Академическая гребля", 1);
                            set_info(658, 240, 227, 39, "Борьба греко-римская", 2);
                            set_info(196, 440, 227, 39, "Тяжёлая атлетика", 3);
                            set_info(426, 440, 227, 39, "Велоспорт", 4);
                            set_info(658, 440, 227, 39, "Стрельба", 5);

                            text1.Text = "Роман Петрушенко";
                            text1.Location = new Point(262 - 66, 296);
                            text2.Text = "Вадим Махнев";
                            text2.Location = new Point(262 - 66, 326);
                            text3.Text = "Юлия Бичик";
                            text3.Location = new Point(570 - 144, 296);
                            text4.Text = "Наталья Гелах";
                            text4.Location = new Point(570 - 144, 326);
                            text5.Text = "Наталья Цилинская";
                            text5.Location = new Point(570 - 144, 496);
                            text6.Text = "Сергей Мартынов";
                            text6.Location = new Point(802 - 144, 496);
                            text7.Text = "Татьяна Стукалова";
                            text7.Location = new Point(262 - 66, 496);
                            text8.Text = "Вячеслав Макаренко";
                            text8.Location = new Point(802 - 144, 296);
                            break;
                    }
                    break;

                // 2006
                case 6:
                    switch (logic_txt)
                    {
                        case ("C"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Фристайл", 0);
                            set_text(453, 296, "Дмитрий Дащинский", 0);
                            break;
                    }
                    break;

                // 2008
                case 7:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 8; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 210, 45, "Тяжелая атлетика", 0);
                            set_info(410, 240, 260, 45, "Гребля на байдарках и каноэ", 1);
                            set_info(675, 240, 210, 45, "Метание молота", 2);

                            text1.Text = "Андрей Арямнов";
                            text1.Location = new Point(262 - 66, 296);
                            text2.Text = "Александр Богданович";
                            text2.Location = new Point(554 - 144, 296);
                            text3.Text = "Андрей Богданович";
                            text3.Location = new Point(554 - 144, 326);
                            text4.Text = "Роман Петрушенко";
                            text4.Location = new Point(554 - 144, 356);
                            text5.Text = "Алексей Абалмасов";
                            text5.Location = new Point(554 - 144, 386);
                            text6.Text = "Артур Литвинчук";
                            text6.Location = new Point(554 - 144, 416);
                            text7.Text = "Вадим Махнев";
                            text7.Location = new Point(554 - 144, 446);
                            text8.Text = "Оксана Менькова";
                            text8.Location = new Point(802 - 114, 296);
                            break;

                        case ("C"):
                            for (int i = 0; i < 5; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 5; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Вольная борьба ", 0);
                            set_info(546, 240, 339, 39, "Метание молота", 1);
                            set_info(196, 440, 227, 39, "Десятиборье", 2);
                            set_info(426, 440, 227, 39, "Художеств. гимнастика", 3);
                            set_info(658, 440, 227, 39, "Тяжелая атлетика", 4);

                            text1.Text = "Мурад Гайдаров";
                            text1.Location = new Point(262 - 66, 296);
                            text2.Text = "Вадим Девятовский";
                            text2.Location = new Point(690 - 144, 296);
                            text3.Text = "Андрей Кравченко";
                            text3.Location = new Point(262 - 66, 496);
                            text4.Text = "Инна Жукова";
                            text4.Location = new Point(570 - 144, 496);
                            text5.Text = "Андрей Рыбаков";
                            text5.Location = new Point(802 - 144, 496);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 16; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 7; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 210, 45, "Академическая гребля", 0);
                            set_info(410, 240, 260, 45, "Худож. гимнастика, групповые упражнения", 1);
                            set_info(675, 240, 210, 45, "Толкание ядра", 2);
                            set_info(196, 470, 177, 45, "Гребля на байдарке и каноэ", 3);
                            set_info(376, 470, 147, 45, "Борьба греко-римская", 4);
                            set_info(526, 470, 177, 45, "Тяжелая атлетика", 5);
                            set_info(708, 470, 177, 45, "Метание молота", 6);

                            // Группа
                            set_text(410, 296, "Олеся Бабушкина", 0);
                            set_text(410, 326, "Анастасия Иванькова", 1);
                            set_text(410, 356, "Зинаида Лунина", 2);
                            set_text(410, 386, "Глафира Мартинович", 3);
                            set_text(410, 416, "Ксения Санкович", 4);
                            set_text(410, 446, "Алина Тумилович", 5);

                            set_text(675, 296, "Андрей Михневич", 6);
                            set_text(675, 326, "Надежда Остапчук", 7);

                            set_text(196, 296, "Екатерина Карстен", 8);
                            set_text(196, 326, "Наталья Гелах", 9);
                            set_text(196, 356, "Юлия Бичик", 10);

                            set_text(708, 526, "Иван Тихон", 11);
                            set_text(376, 526, "Михаил Семенов", 12);
                            set_text(196, 526, "Роман Петрушенко", 13);
                            set_text(196, 556, "Вадим Махнев", 14);
                            set_text(526, 526, "Анастасия Новикова", 15);
                            break;
                    }
                    break;

                // 2010
                case 8:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Фристайл", 0);
                            set_text(465, 296, "Алексей Гришин", 0);
                            break;
                        case ("C"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Биатлон", 0);
                            set_text(465, 296, "Сергей Новиков", 0);
                            break;
                        case ("Б"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Биатлон", 0);
                            set_text(463, 296, "Дарья Домрачева", 0);
                            break;
                    }
                    break;
                // 2012
                case 9:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 3; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Теннис", 0);
                            set_info(546, 240, 339, 39, "Стрельба", 1);

                            set_text(196, 296, "Виктория Азаренко", 0);
                            set_text(196, 326, "Максим Мирный", 1);
                            set_text(546, 296, "Сергей Мартынов", 2);
                            break;

                        case ("C"):
                            for (int i = 0; i < 11; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 227, 42, "Плавание", 0);
                            set_info(426, 240, 227, 42, "Гребля на байдарках и каноэе", 1);
                            set_info(658, 240, 227, 42, "Художеств. гимнастика", 2);

                            set_text(200, 296, "Александра Герасименя", 0);
                            set_text(430, 296, "Александр Богданович", 1);
                            set_text(430, 326, "Андрей Богданович", 2);
                            set_text(430, 356, "Роман Петрушенко", 3);
                            set_text(430, 386, "Вадим Махнев", 4);
                            set_text(660, 296, "Марина Гончарова", 5);
                            set_text(660, 326, "Анастасия Иванькова", 6);
                            set_text(660, 356, "Наталия Лещик", 7);
                            set_text(660, 386, "Александра Наркевич", 8);
                            set_text(660, 416, "Ксения Санкович ", 9);
                            set_text(660, 446, "Алина Тумилович", 10);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 8; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 4; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Гребля на байдарках и каноэе", 0);
                            set_info(546, 240, 339, 39, "Тяжелая атлетика", 1);
                            set_info(196, 440, 346, 39, "Теннис", 2);
                            set_info(546, 440, 339, 39, "Художеств. гимнастика", 3);

                            set_text(200, 296, "Марина Полторан", 0);
                            set_text(200, 326, "Ирина Помелова", 1);
                            set_text(550, 296, "Надежда Попок", 2);
                            set_text(550, 326, "Ольга Худенко", 3);
                            set_text(550, 356, "Марина Шкерманкова", 4);
                            set_text(550, 386, "Ирина Кулеша", 5);
                            set_text(200, 496, "Виктория Азаренко", 6);
                            set_text(550, 496, "Любовь Черкашина", 7);
                            break;
                    }
                    break;

                // 2014
                case 10:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 4; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }

                            set_info(196, 240, 346, 39, "Биатлон", 0);
                            set_info(546, 240, 339, 39, "Фристайл", 1);

                            set_text(196, 296, "Дарья Домрачева", 0);
                            set_text(546, 296, "Алла Цупер", 1);
                            set_text(196, 326, "Надежда Скардино", 2);
                            set_text(546, 326, "Антон Кушнир", 3);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Биатлон", 0);
                            set_text(453, 296, "Надежда Скардино", 0);
                            break;
                    }
                    break;

                // 2016
                case 11:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Прыжки на батуте", 0);
                            set_text(453, 296, "Владислав Гончаров", 0);
                            break;

                        case ("C"):
                            for (int i = 0; i < 4; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 227, 42, "Тяжёлая атлетика", 0);
                            set_info(426, 240, 227, 42, "Борьба ", 1);
                            set_info(658, 240, 227, 42, "Лёгкая атлетика", 2);

                            set_text(200, 296, "Дарья Наумова", 0);
                            set_text(200, 326, "Вадим Стрельцов", 1);
                            set_text(430, 296, "Мария Мамашук", 2);
                            set_text(662, 296, "Иван Тихон", 3);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 7; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 227, 42, "Плавание", 0);
                            set_info(426, 240, 227, 42, "Борьба", 1);
                            set_info(658, 240, 227, 42, "Гребля на байдарках и каноэе", 2);

                            set_text(200, 296, "Александра Герасименя", 0);
                            set_text(430, 296, "Джавид Гамзатов", 1);
                            set_text(430, 326, "Ибрагим Саидов", 2);
                            set_text(662, 296, "Маргарита Махнёва", 3);
                            set_text(662, 326, "Надежда Лепешко", 4);
                            set_text(662, 356, "Ольга Худенко", 5);
                            set_text(662, 386, "Марина Литвинчук", 6);
                            break;
                    }
                    break;

                // 2018
                case 12:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 5; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Фристайл ", 0);
                            set_info(546, 240, 339, 39, "Биатлон", 1);

                            set_text(200, 296, "Анна Гуськова", 0);
                            set_text(550, 296, "Надежда Скардино", 1);
                            set_text(550, 326, "Ирина Кривко", 2);
                            set_text(550, 356, "Динара Алимбекова", 3);
                            set_text(550, 386, "Дарья Домрачева", 4);
                            break;

                        case ("C"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Биатлон", 0);
                            set_text(462, 296, "Дарья Домрачева", 0);
                            break;
                    }
                    break;

                // 2020
                case 13:
                    switch(logic_txt)
                    {
                        case ("З"):
                            for (int i = 0; i < 1; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 1; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 690, 39, "Прыжки на батуте", 0);
                            set_text(462, 296, "Иван Литвинович", 0);
                            break;

                        case ("C"):
                            for (int i = 0; i < 6; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Борьба", 0);
                            set_info(546, 240, 339, 39, "Гребля на байдарках и каноэ", 1);

                            set_text(200, 296, "Ирина Курочкина", 0);
                            set_text(200, 326, "Магомедхабиб Кадимагомедов", 1);
                            set_text(550, 296, "Маргарита Махнёва", 2);
                            set_text(550, 326, "Надежда Лепешко", 3);
                            set_text(550, 356, "Ольга Худенко", 4);
                            set_text(550, 386, "Марина Литвинчук", 5);
                            break;

                        case ("Б"):
                            for (int i = 0; i < 3; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 3; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 240, 45, "Лёгкая атлетика ", 0);
                            set_info(440, 240, 210, 45, "Борьба ", 1);
                            set_info(654, 240, 230, 45, "Художественная гимнастика", 2);

                            set_text(200, 296, "Максим Недосеков", 0);
                            set_text(445, 296, "Ванесса Колодинская", 1);
                            set_text(660, 296, "Алина Горносько", 2);
                            break;
                    }
                    break;

                // 2022
                case 14:
                    switch(logic_txt)
                    {
                        case ("C"):
                            for (int i = 0; i < 2; i++) { list_text[i].Visible = true; }
                            for (int i = 0; i < 2; i++) { list_infoF[i].Visible = true; }
                            set_info(196, 240, 346, 39, "Биатлон", 0);
                            set_info(546, 240, 339, 39, "Фристайл", 1);

                            set_text(196, 296, "Антон Смольский", 0);
                            set_text(546, 296, "Анна Гуськова", 1);
                            break;
                    }
                    break;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            PictureBox8.Image = Properties.Resources.ЛесикМинск;
            EuroPic1.Image = Properties.Resources.лесик1;
            EuroPic1.Visible = true;
            EuroPic1.Location = new Point(-5,233);
            EuroPic1.Size = new Size(220, 364);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            DissableSSSRButton();
            clear();
            exit = true;
            for (int i = 0; i < massLabel.Length; i++)
            {
                if (massLabel[i].Font.Bold)
                {
                    massLabel[i].Font = new Font(massLabel[i].Font, massLabel[i].Font.Style ^ FontStyle.Bold);
                }
            }
            VideoLable.Location = new Point(370, 603);
            VideoLable.Text = "Торжественное закрытие";
            VideoLable.Font = new Font(VideoLable.Font.Name, 22, VideoLable.Font.Style);
            VideoLable.Visible = true;
            label19.Visible = true;
            label19.Text = "II Европейские игры 2019 — проходили в столице Белоруссии, городе Минске, с 21 по 30 июня 2019 года." +
            "Соревнования по гребле на байдарках и каноэ принимал гребной канал в Заславле. На Играх разыграли 200 комплектов наград. В соревнованиях по 15 видам спорта принимали участие 3844 спортсменов из пятидесяти стран Европы. " +
            "Соревнования в восьми видах спорта были включены в квалификационную систему летних Олимпийских игр 2020 года в Токио.  " +
            "Во время проведения Игр было задействовано 8 тысяч волонтёров. Права на трансляцию Игр приобрели 196 стран мира. " +
            "Команда Беларуси на домашних Играх стала второй в общем медальном зачёте, завоевав 68 медалей – 23 золотые, 16 серебряных и 29 бронзовых.\n\n";
        }

        private void get_textInfo()
        {
            switch (logic_int)
            {
                // 1994 Выполнено
                case 0:
                    if (logics[0]) { clear(); Sportmans.info_sportmans(0, label19); logics[0] = false; }
                    if (logics[1]) { clear(); Sportmans.info_sportmans(1, label19); logics[1] = false; }
                    break;

                // 1996 Выполнено
                case 1:
                    switch (logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(2, label19); logics[0] = false; }
                            break;

                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(3, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(4, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(5, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(6, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(7, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(8, label19); logics[5] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(9, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(10, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(11, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(12, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(13, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(14, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(15, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(16, label19); logics[7] = false; }
                            if (logics[8]) { clear(); Sportmans.info_sportmans(17, label19); logics[8] = false; }
                            if (logics[9]) { clear(); Sportmans.info_sportmans(18, label19); logics[9] = false; }
                            if (logics[10]) { clear(); Sportmans.info_sportmans(19, label19); logics[10] = false; }
                            if (logics[11]) { clear(); Sportmans.info_sportmans(20, label19); logics[11] = false; }
                            break;
                    }
                    break;

                // 1998 Выполнено
                case 2:
                    if (logics[0]) { clear(); Sportmans.info_sportmans(21, label19); logics[0] = false; }
                    if (logics[1]) { clear(); Sportmans.info_sportmans(22, label19); logics[1] = false; }
                    break;

                // 2000 Выполнено
                case 3:
                    switch(logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(24, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(23, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(25, label19); logics[2] = false; }
                            break;
                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(26, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(27, label19); logics[1] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(28, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(29, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(4, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(31, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(30, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(5, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(32, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(33, label19); logics[7] = false; }
                            if (logics[8]) { clear(); Sportmans.info_sportmans(34, label19); logics[8] = false; }
                            if (logics[9]) { clear(); Sportmans.info_sportmans(35, label19); logics[9] = false; }
                            if (logics[10]) { clear(); Sportmans.info_sportmans(36, label19); logics[10] = false; }
                            break;
                    }
                    break;

                // 2002 Выполнено
                case 4:
                    if (logics[0]) { clear(); Sportmans.info_sportmans(37, label19); logics[0] = false; }
                    break;

                // 2004 Выполнено
                case 5:
                    switch(logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(38, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(39, label19); logics[1] = false; }
                            break;

                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(40, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(41, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(2, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(42, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(43, label19); logics[4] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(44, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(45, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(46, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(47, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(48, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(33, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(49, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(50, label19); logics[7] = false; }
                            break;
                    }
                    break;

                // 2006 Выполнено
                case 6:
                    if (logics[0]) { clear(); Sportmans.info_sportmans(51, label19); logics[0] = false; }
                    break;

                // 2008 
                case 7:
                    switch(logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(52, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(53, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(54, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(44, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(55, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(56, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(45, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(57, label19); logics[7] = false; }
                            break;

                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(58, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(59, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(60, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(61, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(42, label19); logics[4] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(62, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(63, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(64, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(65, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(66, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(67, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(68, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(69, label19); logics[7] = false; }
                            if (logics[8]) { clear(); Sportmans.info_sportmans(2, label19); logics[8] = false; }
                            if (logics[9]) { clear(); Sportmans.info_sportmans(48, label19); logics[9] = false; }
                            if (logics[10]) { clear(); Sportmans.info_sportmans(47, label19); logics[10] = false; }
                            if (logics[11]) { clear(); Sportmans.info_sportmans(70, label19); logics[11] = false; }
                            if (logics[12]) { clear(); Sportmans.info_sportmans(71, label19); logics[12] = false; }
                            if (logics[13]) { clear(); Sportmans.info_sportmans(44, label19); logics[13] = false; }
                            if (logics[14]) { clear(); Sportmans.info_sportmans(45, label19); logics[14] = false; }
                            if (logics[15]) { clear(); Sportmans.info_sportmans(72, label19); logics[15] = false; }
                            break;
                    }
                    break;

                // 2010  Выполнено
                case 8:
                    switch(logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(37, label19); logics[0] = false; }
                            break;
                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(77, label19); logics[0] = false; }
                            break;
                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(76, label19); logics[0] = false; }
                            break;
                    }
                    break;

                // 2012
                case 9:
                    switch(logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(33, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(78, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(79, label19); logics[2] = false; }
                            break;
                            
                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(80, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(53, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(54, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(44, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(45, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(81, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(63, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(82, label19); logics[7] = false; }
                            if (logics[8]) { clear(); Sportmans.info_sportmans(83, label19); logics[8] = false; }
                            if (logics[9]) { clear(); Sportmans.info_sportmans(66, label19); logics[9] = false; }
                            if (logics[10]) { clear(); Sportmans.info_sportmans(67, label19); logics[10] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(85, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(86, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(87, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(89, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(84, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(88, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(78, label19); logics[6] = false; }
                            if (logics[7]) { clear(); Sportmans.info_sportmans(90, label19); logics[7] = false; }
                            break;
                    }
                    break;

                // 2014
                case 10:
                    switch (logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(76, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(91, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(92, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(93, label19); logics[3] = false; }
                            break;
                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(92, label19); logics[0] = false; }
                            break;
                    }
                    break;

                // 2016
                case 11:
                    switch (logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(95, label19); logics[0] = false; }
                            break;

                        case ("C"):
                            if(logics[0]) { clear(); Sportmans.info_sportmans(94, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(96, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(97, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(70, label19); logics[3] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(80, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(98, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(99, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(100, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(87, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(89, label19); logics[5] = false; }
                            if (logics[6]) { clear(); Sportmans.info_sportmans(85, label19); logics[6] = false; }
                            break;
                    }
                    break;

                // 2018
                case 12:
                    switch(logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(108, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(92, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(109, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(110, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(76, label19); logics[4] = false; }
                            break;

                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(76, label19); logics[0] = false; }
                            break;
                    }
                    break;

                // 2020
                case 13:
                    switch (logic_txt)
                    {
                        case ("З"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(102, label19); logics[0] = false; }
                            break;

                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(101, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(103, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(100, label19); logics[2] = false; }
                            if (logics[3]) { clear(); Sportmans.info_sportmans(87, label19); logics[3] = false; }
                            if (logics[4]) { clear(); Sportmans.info_sportmans(89, label19); logics[4] = false; }
                            if (logics[5]) { clear(); Sportmans.info_sportmans(85, label19); logics[5] = false; }
                            break;

                        case ("Б"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(104, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(105, label19); logics[1] = false; }
                            if (logics[2]) { clear(); Sportmans.info_sportmans(106, label19); logics[2] = false; }
                            break;
                    }
                    break;

                // 2022
                case 14:
                    switch(logic_txt)
                    {
                        case ("C"):
                            if (logics[0]) { clear(); Sportmans.info_sportmans(107, label19); logics[0] = false; }
                            if (logics[1]) { clear(); Sportmans.info_sportmans(108, label19); logics[1] = false; }
                            break;
                    }
                    break;

            }
        }

        private void text1_Click(object sender, EventArgs e) { logics[0] = true; get_textInfo(); }
        private void text2_Click(object sender, EventArgs e) { logics[1] = true; get_textInfo(); }
        private void text3_Click(object sender, EventArgs e) { logics[2] = true; get_textInfo(); }
        private void text4_Click(object sender, EventArgs e) { logics[3] = true; get_textInfo();  }
        private void text5_Click(object sender, EventArgs e) { logics[4] = true; get_textInfo(); }
        private void text6_Click(object sender, EventArgs e) { logics[5] = true; get_textInfo(); }
        private void text7_Click(object sender, EventArgs e) { logics[6] = true; get_textInfo(); }
        private void text8_Click(object sender, EventArgs e) { logics[7] = true; get_textInfo(); }
        private void text9_Click(object sender, EventArgs e) { logics[8] = true; get_textInfo(); }
        private void text10_Click(object sender, EventArgs e) { logics[9] = true; get_textInfo(); }
        private void text11_Click(object sender, EventArgs e) { logics[10] = true; get_textInfo(); }
        private void text12_Click(object sender, EventArgs e) { logics[11] = true; get_textInfo(); }
        private void text13_Click(object sender, EventArgs e) { logics[12] = true; get_textInfo(); }
        private void text14_Click(object sender, EventArgs e) { logics[13] = true; get_textInfo(); }
        private void text15_Click(object sender, EventArgs e) { logics[14] = true; get_textInfo(); }
        private void text16_Click(object sender, EventArgs e) { logics[15] = true; get_textInfo(); }

        private void text1_MouseMove(object sender, MouseEventArgs e)
        {
            text1.Font = new Font(text1.Font, text1.Font.Style | FontStyle.Underline);
        }
        private void text1_MouseLeave(object sender, EventArgs e)
        {
            text1.Font = new Font(text1.Font, text1.Font.Style ^ FontStyle.Underline);
        }

        private void text2_MouseMove(object sender, MouseEventArgs e)
        {
            text2.Font = new Font(text2.Font, text2.Font.Style | FontStyle.Underline);
        }

        private void text2_MouseLeave(object sender, EventArgs e)
        {
            text2.Font = new Font(text2.Font, text2.Font.Style ^ FontStyle.Underline);
        }

        private void text3_MouseMove(object sender, MouseEventArgs e)
        {
            text3.Font = new Font(text3.Font, text3.Font.Style | FontStyle.Underline);
        }

        private void text3_MouseLeave(object sender, EventArgs e)
        {
            text3.Font = new Font(text3.Font, text3.Font.Style ^ FontStyle.Underline);
        }

        private void text4_MouseMove(object sender, MouseEventArgs e)
        {
            text4.Font = new Font(text4.Font, text4.Font.Style | FontStyle.Underline);
        }

        private void text4_MouseLeave(object sender, EventArgs e)
        {
            text4.Font = new Font(text4.Font, text4.Font.Style ^ FontStyle.Underline);
        }

        private void text5_MouseMove(object sender, MouseEventArgs e)
        {
            text5.Font = new Font(text5.Font, text5.Font.Style | FontStyle.Underline);
        }

        private void text5_MouseLeave(object sender, EventArgs e)
        {
            text5.Font = new Font(text5.Font, text5.Font.Style ^ FontStyle.Underline);
        }

        private void text6_MouseMove(object sender, MouseEventArgs e)
        {
            text6.Font = new Font(text6.Font, text6.Font.Style | FontStyle.Underline);
        }

        private void text6_MouseLeave(object sender, EventArgs e)
        {
            text6.Font = new Font(text6.Font, text6.Font.Style ^ FontStyle.Underline);
        }

        private void text7_MouseMove(object sender, MouseEventArgs e)
        {
            text7.Font = new Font(text7.Font, text7.Font.Style | FontStyle.Underline);
        }

        private void text7_MouseLeave(object sender, EventArgs e)
        {
            text7.Font = new Font(text7.Font, text7.Font.Style ^ FontStyle.Underline);
        }

        private void text8_MouseMove(object sender, MouseEventArgs e)
        {
            text8.Font = new Font(text8.Font, text8.Font.Style | FontStyle.Underline);
        }

        private void text8_MouseLeave(object sender, EventArgs e)
        {
            text8.Font = new Font(text8.Font, text8.Font.Style ^ FontStyle.Underline);
        }

        private void text9_MouseMove(object sender, MouseEventArgs e)
        {
            text9.Font = new Font(text9.Font, text9.Font.Style | FontStyle.Underline);
        }

        private void text9_MouseLeave(object sender, EventArgs e)
        {
            text9.Font = new Font(text9.Font, text9.Font.Style ^ FontStyle.Underline);
        }

        private void text10_MouseMove(object sender, MouseEventArgs e)
        {
            text10.Font = new Font(text10.Font, text10.Font.Style | FontStyle.Underline);
        }

        private void text10_MouseLeave(object sender, EventArgs e)
        {
            text10.Font = new Font(text10.Font, text10.Font.Style ^ FontStyle.Underline);
        }

        private void text11_MouseMove(object sender, MouseEventArgs e)
        {
            text11.Font = new Font(text11.Font, text11.Font.Style | FontStyle.Underline);
        }

        private void text11_MouseLeave(object sender, EventArgs e)
        {
            text11.Font = new Font(text11.Font, text11.Font.Style ^ FontStyle.Underline);
        }

        private void text12_MouseMove(object sender, MouseEventArgs e)
        {
            text12.Font = new Font(text12.Font, text12.Font.Style | FontStyle.Underline);
        }

        private void text12_MouseLeave(object sender, EventArgs e)
        {
            text12.Font = new Font(text12.Font, text12.Font.Style ^ FontStyle.Underline);
        }

        private void text13_MouseMove(object sender, MouseEventArgs e)
        {
            text13.Font = new Font(text13.Font, text13.Font.Style | FontStyle.Underline);
        }

        private void text13_MouseLeave(object sender, EventArgs e)
        {
            text13.Font = new Font(text13.Font, text13.Font.Style ^ FontStyle.Underline);
        }

        private void text14_MouseMove(object sender, MouseEventArgs e)
        {
            text14.Font = new Font(text14.Font, text14.Font.Style | FontStyle.Underline);
        }

        private void text14_MouseLeave(object sender, EventArgs e)
        {
            text14.Font = new Font(text14.Font, text14.Font.Style ^ FontStyle.Underline);
        }

        private void text15_MouseMove(object sender, MouseEventArgs e)
        {
            text15.Font = new Font(text15.Font, text15.Font.Style | FontStyle.Underline);
        }

        private void text15_MouseLeave(object sender, EventArgs e)
        {
            text15.Font = new Font(text15.Font, text15.Font.Style ^ FontStyle.Underline);
        }

        private void text16_MouseMove(object sender, MouseEventArgs e)
        {
            text16.Font = new Font(text16.Font, text16.Font.Style | FontStyle.Underline);
        }

        private void text16_MouseLeave(object sender, EventArgs e)
        {
            text16.Font = new Font(text16.Font, text16.Font.Style ^ FontStyle.Underline);
        }

        private void text17_MouseMove(object sender, MouseEventArgs e)
        {
            text17.Font = new Font(text17.Font, text17.Font.Style | FontStyle.Underline);
        }

        private void text17_MouseLeave(object sender, EventArgs e)
        {
            text17.Font = new Font(text17.Font, text17.Font.Style ^ FontStyle.Underline);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            DissableEuroPic();
            DissableSSSRButton();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            for (int i = 0; i < massLabel.Length; i++)
            {
                if (massLabel[i].Font.Bold)
                {
                    massLabel[i].Font = new Font(massLabel[i].Font, massLabel[i].Font.Style ^ FontStyle.Bold);
                }
            }
            exit = true;
            clear();
            label19.Visible = false;
            EuroPic1.Visible = true;
            EuroPic1.Image = Properties.Resources.Рисунок22;
            VideoLable.Font = new Font(VideoLable.Font.Name, 29, VideoLable.Font.Style);
            EuroPic1.Location = new Point(- 57, 269);
            EuroPic1.Size = new Size(289, 301);
            for (int i = list_text.Count-1; i > list_text.Count - 5; i--) { list_text[i].Visible = true; }
            set_text(355, 316, "Ольга Валентиновна Корбут", list_text.Count-4);
            set_text(335, 351, "Александр Васильевич Медведь", list_text.Count-3);
            set_text(345, 386, "Виталий Венедиктович Щербо", list_text.Count-2);
            set_text(295, 421, "Владимир Владимирович Парфенович", list_text.Count-1);
        }
        private void SSSR1_MouseMove(object sender, MouseEventArgs e)
        {
            SSSR1.Font = new Font(SSSR1.Font, SSSR1.Font.Style | FontStyle.Underline);
        }

        private void SSSR1_MouseLeave(object sender, EventArgs e)
        {
            SSSR1.Font = new Font(SSSR1.Font, SSSR1.Font.Style ^ FontStyle.Underline);
        }

        private void SSSR2_MouseMove(object sender, MouseEventArgs e)
        {
            SSSR2.Font = new Font(SSSR2.Font, SSSR2.Font.Style | FontStyle.Underline);
        }

        private void SSSR2_MouseLeave(object sender, EventArgs e)
        {
            SSSR2.Font = new Font(SSSR2.Font, SSSR2.Font.Style ^ FontStyle.Underline);
        }

        private void SSSR3_MouseMove(object sender, MouseEventArgs e)
        {
            SSSR3.Font = new Font(SSSR3.Font, SSSR3.Font.Style | FontStyle.Underline);
        }

        private void SSSR3_MouseLeave(object sender, EventArgs e)
        {
            SSSR3.Font = new Font(SSSR3.Font, SSSR3.Font.Style ^ FontStyle.Underline);
        }

        private void SSSR4_MouseMove(object sender, MouseEventArgs e)
        {
            SSSR4.Font = new Font(SSSR4.Font, SSSR4.Font.Style | FontStyle.Underline);
        }

        private void SSSR4_MouseLeave(object sender, EventArgs e)
        {
            SSSR4.Font = new Font(SSSR4.Font, SSSR4.Font.Style ^ FontStyle.Underline);
        }
        //Реализация кнопок СССР
        static int index;
        public  void DissableSSSRButton()
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label22.Visible = false;
            VideoLable.Visible = false;
        }
        public void getSSSR(int index)
        {
            switch (index)
            {
                case (1):
                    if (label22.Text == "1/2")
                    {
                        VideoLable.Location = new Point(430, 550);
                        VideoLable.Visible = true;
                        VideoLable.Text = "Петля Корбут";
                        label22.Text = "2/2";
                        label19.Text = "1972 г. — вольные упражнения, бревно и командное первенство;" +
                        "1973 г. – серебряный призер чемпионата Европы в абсолютном первенстве.В этом же году Корбут пригласили на гастроли в США. Они прошли триумфально.В результате в Америке начался бум спортивной гимнастики." +
                        " 1974 г. – чемпионка мира в опорном прыжке и в командном первенстве." + "1975 г. – победительница советской Спартакиады и чемпионка СССР." +
                        " 1976 г. — командное первенство." +
                        " 1977 г. – окончила Гродненский педагогический институт по специальности тренер - преподаватель.\n\n\n\n\n";
                        pictureBox7.Visible = true;
                        pictureBox6.Visible = false;
                        
                    }
                    else if (label22.Text == "2/2")
                    {
                        VideoLable.Visible = false;
                        label22.Text = "1/2";
                        label19.Text = "Ольга Валентиновна Корбут — советская гимнастка, четырёхкратная Олимпийская чемпионка, заслуженный мастер спорта СССР." +
                        " Выступала за Вооружённые Силы. Тренировалась у Ренальда Кныша. 1970 г. — завоевала титул чемпионки СССР в опорном прыжке, став, таким образом, членом советской сборной." +
                        " В этом же году Ольга стала чемпионкой мира в командном первенстве. Ольга Корбут является 4-кратной олимпийской чемпионкой.";
                        pictureBox7.Visible = false;
                        pictureBox6.Visible = true;
                    }
                    break;
                case (2):
                    if(label22.Text == "1/2")
                    {
                        VideoLable.Location = new Point(375, 535);
                        VideoLable.Visible = true;
                        VideoLable.Text = "Александр Медведь";
                        label22.Text = "2/2";
                        label19.Text = "В 1980 году на открытии Олимпийских игр в Москве был удостоен чести прочитать Олимпийскую клятву от имени судей." +
            " После распада СССР стал вице - президентом НОК Белоруссии и тренером олимпийской сборной Белоруссии по вольной борьбе." +
            " В 2001 году признан лучшим спортсменом Белоруссии XX века." +
            " В 2005 году был признан лучшим борцом вольного стиля в истории спорта и введён в Зал спортивной славы борьбы.\n\n\n\n\n\n\n";
                        pictureBox7.Visible = true;
                        pictureBox6.Visible = false;
                    }
                    else if(label22.Text == "2/2")
                    {
                        VideoLable.Visible = false;
                        label22.Text = "1/2";
                        label19.Text = "Александр Васильевич Медведь — советский белорусский спортсмен, борец вольного стиля, многократный чемпион мира, Европы и СССР. Автор двух книг по борьбе." +
            " Три раза становился олимпийским чемпионом по вольной борьбе, в трёх разных весовых категориях, 7 раз становился чемпионом мира, 3 раза — чемпионом Европы. 9 раз становился чемпионом СССР." +
            " В 1962 году после своего первого чемпионства стал заслуженным мастером спорта, с 1965 года — член КПСС.";
                        pictureBox7.Visible = false;
                        pictureBox6.Visible = true;
                    }
                    break;
                case (3):
                    if(label22.Text == "1/2")
                    {
                        VideoLable.Location = new Point(405, 535);
                        VideoLable.Visible = true;
                        VideoLable.Text = "Виталий Щербо";
                        label22.Text = "2/2";
                        label19.Text = 
                        " С 1996 г. живет в США, имеет собственную гимнастическую школу; с 1998 г. – тренер сборной США по спортивной гимнастике." +
                        " Заслуженный мастер спорта СССР, заслуженный мастер спорта Беларуси. С 1993 г. инструктор по спорту Министерства спорта и туризма Беларуси, член республиканской сборной команды по спортивной гимнастике." +
                        " Чемпион XXV Олимпийских игр. Бронзовый призер XXVI Олимпийских игр.Победитель Игр доброй воли. Чемпион Универсиад. Лучший спортсмен мира за 10 - летие.\n\n\n\n\n\n";
                        pictureBox7.Visible = true;
                        pictureBox6.Visible = false;
                    }
                    else if (label22.Text == "2/2")
                    {
                        VideoLable.Visible= false;
                        label22.Text = "1/2";
                        label19.Text = "Виталий Венедиктович Щербо — советский и белорусский гимнаст, шестикратный олимпийский чемпион," +
                " четырёхкратный бронзовый призёр Олимпийских Игр, 12-кратный чемпион мира, 10-кратный чемпион Европы, двукратный обладатель Кубка мира по спортивной гимнастике." +
                " Единственный в истории не пловец, выйгравший 6 золотых медалей на одних Олимпийских Играх, что является абсолютным рекордом для этого вида спорта." +
                " Единственный гимнаст-мужчина, который становился чемпионом мира во всех 8 дисциплинах." +
                " Один из самых титулованных спортсменов в истории гимнастики и самый титулованный белорусский гимнаст.";
                        pictureBox7.Visible = false;
                        pictureBox6.Visible = true;
                    }
                    break;
                case (4):
                    if(label22.Text == "1/2")
                    {
                        VideoLable.Location = new Point(340,535);
                        VideoLable.Visible = true;
                        VideoLable.Text = "Владимир Парфенович";
                        label22.Text = "2/2";
                        label19.Text = "До 2004 года — член Национального олимпийского комитета. Награждён орденами Трудового Красного Знамени и Дружбы народов." +
                " Девятикратный чемпион мира. Девятикратный чемпион Европы. " +
                " Обладатель трех серебряных наград чемпионатов мира. " +
                " Победитель соревнований Дружба-84.Семнадцатикратный чемпион СССР. Девятнадцатикратный обладатель Кубка СССР. " + 
                " Четырехкратный победитель Спартакиад народов СССР. Заслуженный мастер спорта. Награжден орденами Трудового Красного Знамени и Дружбы народов.\n\n\n\n\n\n";
                        pictureBox7.Visible = true;
                        pictureBox6.Visible = false;
                    }
                    else if(label22.Text == "2/2")
                    {
                        VideoLable.Visible = false;
                        label22.Text = "1/2";
                        label19.Text = "Владимир Владимирович Парфенович — советский белорусский спортсмен, гребец на байдарке. Заслуженный мастер спорта СССР." +
               " Выступал за «Динамо» Минск. Единственный в мире байдарочник, выигравший 3 золотые медали в рамках одних Олимпийских игр. " +
               " В 1980—1983 годах Владимир Парфенович четырежды признавался лучшим спортсменом Белорусской ССCР. " +
               "После окончания спортивной карьеры занимался бизнесом. В 2000—2004 годах был депутатом парламента Беларуси.";
                        pictureBox7.Visible = false;
                        pictureBox6.Visible = true;
                    }
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        private void SSSR1_Click(object sender, EventArgs e)
        {
            index = 1;
            label22.Visible = true;
            label22.Text = "1/2";
            pictureBox6.Visible = true;
            for (int i = list_text.Count - 1; i > list_text.Count - 5; i--) { list_text[i].Visible = false; }
            label19.Visible = true;
            label19.Text = "Ольга Валентиновна Корбут — советская гимнастка, четырёхкратная Олимпийская чемпионка, заслуженный мастер спорта СССР." +
                " Выступала за Вооружённые Силы. Тренировалась у Ренальда Кныша. 1970 г. — завоевала титул чемпионки СССР в опорном прыжке, став, таким образом, членом советской сборной." +
                " В этом же году Ольга стала чемпионкой мира в командном первенстве. Ольга Корбут является 4-кратной олимпийской чемпионкой.";
        }

        private void SSSR2_Click(object sender, EventArgs e)
        {
            index = 2;
            label22.Visible = true;
            label22.Text = "1/2";
            pictureBox6.Visible = true;
            for (int i = list_text.Count - 1; i > list_text.Count - 5; i--) { list_text[i].Visible = false; }
            label19.Visible = true;
            label19.Text = "Александр Васильевич Медведь — советский белорусский спортсмен, борец вольного стиля, многократный чемпион мира, Европы и СССР. Автор двух книг по борьбе." +
            " Три раза становился олимпийским чемпионом по вольной борьбе, в трёх разных весовых категориях, 7 раз становился чемпионом мира, 3 раза — чемпионом Европы. 9 раз становился чемпионом СССР." +
            " В 1962 году после своего первого чемпионства стал заслуженным мастером спорта, с 1965 года — член КПСС.";
        }

        private void SSSR3_Click(object sender, EventArgs e)
        {
            index = 3;
            label22.Visible = true;
            label22.Text = "1/2";
            pictureBox6.Visible = true;
            for (int i = list_text.Count - 1; i > list_text.Count - 5; i--) { list_text[i].Visible = false; }
            label19.Visible = true;
            label19.Text = "Виталий Венедиктович Щербо — советский и белорусский гимнаст, шестикратный олимпийский чемпион," +
                " четырёхкратный бронзовый призёр Олимпийских Игр, 12-кратный чемпион мира, 10-кратный чемпион Европы, двукратный обладатель Кубка мира по спортивной гимнастике." +
                " Единственный в истории не пловец, выйгравший 6 золотых медалей на одних Олимпийских Играх, что является абсолютным рекордом для этого вида спорта." +
                " Единственный гимнаст-мужчина, который становился чемпионом мира во всех 8 дисциплинах." +
                " Один из самых титулованных спортсменов в истории гимнастики и самый титулованный белорусский гимнаст.";                
        }

        private void SSSR4_Click(object sender, EventArgs e)
        {
            index = 4;
            label22.Visible = true;
            label22.Text = "1/2";
            pictureBox6.Visible = true;
            for (int i = list_text.Count - 1; i > list_text.Count - 5; i--) { list_text[i].Visible = false; }
            label19.Visible = true;
            label19.Text = "Владимир Владимирович Парфенович — советский белорусский спортсмен, гребец на байдарке. Заслуженный мастер спорта СССР." +
                " Выступал за «Динамо» Минск. Единственный в мире байдарочник, выигравший 3 золотые медали в рамках одних Олимпийских игр. " +
                " В 1980—1983 годах Владимир Парфенович четырежды признавался лучшим спортсменом Белорусской ССР. " +
                " После окончания спортивной карьеры занимался бизнесом. В 2000—2004 годах был депутатом парламента Беларуси.";
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            getSSSR(index);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            getSSSR(index);
        }

        private void VideoLable_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            switch (VideoLable.Text)
            {
                case ("Петля Корбут"):
                    form2.Show();
                    form2.Text = "Петля Корбут";
                    form2.VideoPlayerURL = "SSSR1.mp4";
                    break;
                case ("Александр Медведь"):
                    form2.Show();
                    form2.Text = "Александр Медведь";
                    form2.VideoPlayerURL = "SSSR2.mp4";
                    break;
                case ("Виталий Щербо"):
                    form2.Show();
                    form2.Text = "Виталий Щербо";
                    form2.VideoPlayerURL = "SSSR3.mp4";
                    break;
                case ("Владимир Парфенович"):
                    form2.Show();
                    form2.Text = "Владимир Парфенович";
                    form2.VideoPlayerURL = "SSSR4.mp4";
                    break;
                case ("Торжественное закрытие"):
                    form2.Show();
                    form2.Text = "Европейские Игры 2019";
                    form2.VideoPlayerURL = "EuroGame1.mp4";
                    break;
            }
        }

        private void VideoLable_MouseMove(object sender, MouseEventArgs e)
        {
            VideoLable.Font = new Font(VideoLable.Font,VideoLable.Font.Style | FontStyle.Underline);
        }

        private void VideoLable_MouseLeave(object sender, EventArgs e)
        {
            VideoLable.Font = new Font(VideoLable.Font, VideoLable.Font.Style ^ FontStyle.Underline);
        }
        public void DissableEuroPic()
        {
            EuroPic1.Visible = false;
            PictureBox8.Image = Properties.Resources.Рисунок33;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://learningapps.org/watch?v=p5wpdzztt22");
        }
    }
}
