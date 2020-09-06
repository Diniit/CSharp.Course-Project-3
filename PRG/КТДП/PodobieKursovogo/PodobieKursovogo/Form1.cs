using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Diagnostics;
using System.Drawing.Text;

namespace PodobieKursovogo
{
    #region ПОЯСНЕНИЕ К КОМПОНЕНТАМ
    /* При объявлении компонентов использовались сокращенные названия элементов
     * и пояснительное имя элемента.
     * cb - ComboBox, CheckBox
     * flp - FlowLayoutPanel
     * l - Label
     * p - Panel
     * pb - PictureBox
     * rt - RichTextBox
     * t - Timer
     * tb - TextBox
     * zhad_1, zhad_2 и т.д. являются Label, используются как кнопки для вызова заданий
     */
    #endregion
    
    public partial class Trenazher : Form
    {
        private int next = -1; //унарный
        private Button knop; //кнопки клавиатуры на p_klav
        private int timer;
        private int pravilno;
        private int nepravilno;
        private bool menu = false;
        private bool prover = false;

        //всплывающие подсказки
        private readonly ToolTip t = new ToolTip();

        //управление системным звуком
        private readonly CoreAudioDevice zvuk = new CoreAudioController().DefaultPlaybackDevice;

        //экземпляр класса-формы с выводом сообщений
        readonly MessageBox m = new MessageBox();


        public Trenazher()
        {
            InitializeComponent();
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            /* //ОТОБРАЖЕНИЕ ШРИФТА В ПРОГРАММЕ, ЕСЛИ ШРИФТ НЕ УСТАНОВЛЕН Franklin Gothic
             * fontCollection.AddFontFile("franklin.ttf"); // файл шрифта
            FontFamily f = fontCollection.Families[0];

            lvibor.Font = new Font(f, 10, FontStyle.Bold);
            l_zhad.Font = new Font(f, 22, FontStyle.Bold);
            zhad_1.Font = new Font(f, 22, FontStyle.Bold);
            zhad_2.Font = new Font(f, 22, FontStyle.Bold);
            zhad_3.Font = new Font(f, 22, FontStyle.Bold);
            zhad_4.Font = new Font(f, 22, FontStyle.Bold);
            zhad_5.Font = new Font(f, 22, FontStyle.Bold);
            lThema.Font = new Font(f, 18, FontStyle.Bold);
            */
        }
        private void Trenazher_Load(object sender, EventArgs e)
            //происходит при создании формы
        {
            

            svetlaya_thema(); //вызов светлой темы
            rtZhadanie.ForeColor = Color.FromArgb(64, 64, 64);
            rtZhadanie.SelectionAlignment = HorizontalAlignment.Center;
            menu = false;
            tbPole.TabIndex = 0;
            rtZhadanie.Text = "ЗДРАВСТВУЙ, В ЭТОЙ ПРОГРАММЕ ТЫ СМОЖЕШЬ ПОЛУЧИТЬ НАВЫКИ БЫСТРОЙ ПЕЧАТИ ЗАРЕЗЕРВИРОВАННЫХ СЛОВ В ТВОЕМ ЯЗЫКЕ ПРОГРАММИРОВАНИЯ";
        }

        #region метод Chtenie
        private string Chtenie(string f) //метод, который считывает информацию из файла с заданием
        {
            FileStream f1;
            StreamReader f2;
            f1 = new FileStream(f, FileMode.Open, FileAccess.Read);
            f2 = new StreamReader(f1);
            string text = f2.ReadToEnd();
            f1.Close();
            /*for (int i = 0; i < text.Length; i++)
            {
                rtZhadanie.ForeColor = Color.FromArgb(64, 64, 64);
            }*/
            return text;
        }
        #endregion

        #region метод Otkritie 
        private void Otkritie(string f) //метод, начинающий задание
        {
            try
            {
                knop.BackColor = Color.Silver;
            }
            catch (Exception ex) { }
            next = -1;
            timer = 0;
            pravilno = 0;
            nepravilno = 0;
            rtZhadanie.Focus();
            tbPole.Clear();
            tbPole.Text = Chtenie(f);
            m.l_mes1.Visible = true;
            m.l_mes2.Visible = false;
            m.l_mes3.Visible = false;
            m.l_mes1.Text = "ПЕРЕКЛЮЧИТЕ РАСКЛАДКУ НА ENG.\nЕСЛИ ВЫ ГОТОВЫ НАЧАТЬ ЗАДАНИЕ,\n НАЖМИТЕ ОК.";
            m.ShowDialog(); //окно сообщения
            t_vremya.Start();
            lVr.Visible = true;
        }
        #endregion

        #region метод Cvet 
        private void Cvet(Button clav, char[] s, int next, char key)
        { //метод, меняющий цвет нажатых клавиш и выделение цвета в поле печати
            try
            {
                knop.BackColor = Color.Silver;
            }
            catch (Exception e) { }
            try
            {
                if (s[next + 1] == ' ')
                {
                    lsled.Text = "_";
                }
                else
                {
                    lsled.Text = Convert.ToString(s[next + 1]);
                }

                if (key == s[next])
                {
                    zvuk.Volume = 0;
                    clav.BackColor = Color.SeaGreen;
                    knop = clav;
                    rtZhadanie.SelectionStart = next;
                    rtZhadanie.SelectionLength = 1;
                    rtZhadanie.SelectionColor = Color.SeaGreen;
                    pravilno++;
                }
                else
                {
                    zvuk.Volume = 20;
                    clav.BackColor = Color.Firebrick;
                    knop = clav;
                    rtZhadanie.SelectionStart = next;
                    rtZhadanie.SelectionLength = 1;
                    rtZhadanie.SelectionColor = Color.Firebrick;
                    nepravilno++;
                }
            }
            catch (Exception e) { }
        }
        #endregion

        #region метод KeyPress
        private void rtZhadanie_KeyPress(object sender, KeyPressEventArgs e)
            //отслеживает нажатие клавиш и производит подсчет результата
        {
            char key = e.KeyChar;
            char[] s = tbPole.Text.ToCharArray(); // s-символ
            next++; //ничего не оптимизируй, все работает
            for (int i = 0; i < p_klav.Controls.Count; i++)
            {
                if (p_klav.Controls[i].Name.Substring(0, 2).ToLower().CompareTo("b" + key.ToString().ToLower()) 
                 == 0 && p_klav.Controls[i].Name.Length <= 2)
                    Cvet((Button)p_klav.Controls[i], s, next, key);
            }
            if (key == 32) Cvet(bspacebar, s, next, key);
            /*if (key == 33) Cvet(b1, s, next, key);
            if (key == 64) Cvet(b2, s, next, key);
            if (key == 35) Cvet(b3, s, next, key);
            if (key == 36) Cvet(b4, s, next, key);
            if (key == 37) Cvet(b5, s, next, key);
            if (key == 94) Cvet(b6, s, next, key);
            if (key == 38) Cvet(b7, s, next, key);
            if (key == 42) Cvet(b8, s, next, key);
            if (key == 40) Cvet(b9, s, next, key);
            if (key == 41) Cvet(b0, s, next, key);
            if (key == 13) Cvet(benter, s, next, key);
            */
            if (s.Length == next + 1)
            {
                t_vremya.Stop();
                int vsego = pravilno + nepravilno;
                double sk = vsego / timer * 60;
                int skorost = (int)sk;
                m.l_mes2.Visible = false;
                m.l_mes1.Visible = false;
                m.l_mes3.Visible = true;
                m.l_mes3.Text="Всего символов: " + vsego + "\nДопущено ошибок: " + nepravilno
                    + "\nВремя: " + timer + " c" + "\nСкорость печати: " + skorost + " сим/мин";
                m.ShowDialog(); //окно сообщения
            }
        }
        #endregion

        #region Отсчет времени
        private void t_vremya_Tick(object sender, EventArgs e)
            //производит отсчет времени при выполнении задания
        {
            timer += 1;
            lVremya.Text = timer.ToString() + "с";
        }
        #endregion

        #region Работа с меню
        private void t_menu_Tick(object sender, EventArgs e)
        //движение меню по таймеру
        //Диана, если ты вдруг неудачно отладила...верни начальное положение на -287;0
        {
            if ((menu) && (pMenu.Left < 0))
                pMenu.Left = pMenu.Left + 5;
            if ((!menu) && (pMenu.Left > -210))
                pMenu.Left = pMenu.Left - 5;
        }
        private void pb_ukaz_Click(object sender, EventArgs e)
            //сворачивание, разворачивание меню
        {
            t_menu.Start();
            menu = !menu;
            if (menu)
                pb_ukaz.Image = Properties.Resources.стрелочка_назад as Bitmap; 
            else
            {
                pb_ukaz.Image = Properties.Resources.стрелочка as Bitmap; //меняем стрелочку
                p_zhadan.Size = p_zhadan.MinimumSize;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
            //сворачивание меню, если мышь активна на форме, а не на меню
        {
            if (menu)
                pb_ukaz_Click(sender, e);
        }
        #endregion

        #region Разворачивание заданий
        private void t_zhadan_Tick(object sender, EventArgs e)
        //работа с выезжающими заданиями по таймеру
        {
            if (prover)
            {
                p_zhadan.Height += 10;
                if (p_zhadan.Size == p_zhadan.MaximumSize)
                {
                    t_zhadan.Stop();
                    prover = false;
                }
            }
            else
            {
                p_zhadan.Height -= 10;
                if (p_zhadan.Size == p_zhadan.MinimumSize)
                {
                    t_zhadan.Stop();
                    prover = true;
                }
            }
        }
        #endregion

        #region Открытие заданий
        private void zhad_1_Click(object sender, EventArgs e)
            //открытие заданий по нажатию задания 1
        {
            rtZhadanie.SelectionStart = 0;
            rtZhadanie.SelectionLength = 1;
            pb_ukaz_Click(sender, e);
            switch (cb_lang.SelectedIndex) //проверка на выбранный язык
            {
                case 0:
                    rtZhadanie.Text = Chtenie("c# 1.txt");
                    Otkritie("c# 1.txt");
                    break;
                case 1:
                    rtZhadanie.Text = Chtenie("pas 1.txt");
                    Otkritie("pas 1.txt");
                    break;
                case 2:
                    rtZhadanie.Text = Chtenie("js 1.txt");
                    Otkritie("js 1.txt");
                    break;
                case 3:
                    rtZhadanie.Text = Chtenie("py 1.txt");
                    Otkritie("py 1.txt");
                    break;
                case 4:
                    rtZhadanie.Text = Chtenie("sql 1.txt");
                    Otkritie("sql 1.txt");
                    break;
            }
        }
        private void zhad_2_Click(object sender, EventArgs e)
            //открытие заданий по нажатию задания 2
        {
            rtZhadanie.SelectionStart = 0;
            rtZhadanie.SelectionLength = 1;
            pb_ukaz_Click(sender, e);
            switch (cb_lang.SelectedIndex)
            {
                case 0:
                    rtZhadanie.Text = Chtenie("c# 2.txt");
                    Otkritie("c# 2.txt");
                    break;
                case 1:
                    rtZhadanie.Text = Chtenie("pas 2.txt");
                    Otkritie("pas 2.txt");
                    break;
                case 2:
                    rtZhadanie.Text = Chtenie("js 2.txt");
                    Otkritie("js 2.txt");
                    break;
                case 3:
                    rtZhadanie.Text = Chtenie("py 2.txt");
                    Otkritie("py 2.txt");
                    break;
                case 4:
                    rtZhadanie.Text = Chtenie("sql 2.txt");
                    Otkritie("sql 2.txt");
                    break;
            }
        }

        private void zhad_3_Click(object sender, EventArgs e)
            //открытие заданий по нажатию задания 3
        { 
            rtZhadanie.SelectionStart = 0;
            rtZhadanie.SelectionLength = 1;
            pb_ukaz_Click(sender, e);
            switch (cb_lang.SelectedIndex)
            {
                case 0:
                    rtZhadanie.Text = Chtenie("c# 3.txt");
                    Otkritie("c# 3.txt");
                    break;
                case 1:
                    rtZhadanie.Text = Chtenie("pas 3.txt");
                    Otkritie("pas 3.txt");
                    break;
                case 2:
                    rtZhadanie.Text = Chtenie("js 3.txt");
                    Otkritie("js 3.txt");
                    break;
                case 3:
                    rtZhadanie.Text = Chtenie("py 3.txt");
                    Otkritie("py 3.txt");
                    break;
                case 4:
                    rtZhadanie.Text = Chtenie("sql 3.txt");
                    Otkritie("sql 3.txt");
                    break;
            }
        }

        private void zhad_4_Click(object sender, EventArgs e)
            //открытие заданий по нажатию задания 4
        {
            rtZhadanie.SelectionStart = 0;
            rtZhadanie.SelectionLength = 1;
            pb_ukaz_Click(sender, e);
            switch (cb_lang.SelectedIndex)
            {
                case 0:
                    rtZhadanie.Text = Chtenie("c# 4.txt");
                    Otkritie("c# 4.txt");
                    break;
                case 1:
                    rtZhadanie.Text = Chtenie("pas 4.txt");
                    Otkritie("pas 4.txt");
                    break;
                case 2:
                    rtZhadanie.Text = Chtenie("js 4.txt");
                    Otkritie("js 4.txt");
                    break;
                case 3:
                    rtZhadanie.Text = Chtenie("py 4.txt");
                    Otkritie("py 4.txt");
                    break;
                case 4:
                    rtZhadanie.Text = Chtenie("sql 4.txt");
                    Otkritie("sql 4.txt");
                    break;
            }
        }

        private void zhad_5_Click(object sender, EventArgs e)
            //открытие заданий по нажатию задания 5
        {
            rtZhadanie.SelectionStart = 0;
            rtZhadanie.SelectionLength = 1;
            pb_ukaz_Click(sender, e);
            switch (cb_lang.SelectedIndex)
            {
                case 0:
                    rtZhadanie.Text = Chtenie("c# 5.txt");
                    Otkritie("c# 5.txt");
                    break;
                case 1:
                    rtZhadanie.Text = Chtenie("pas 5.txt");
                    Otkritie("pas 5.txt");
                    break;
                case 2:
                    rtZhadanie.Text = Chtenie("js 5.txt");
                    Otkritie("js 5.txt");
                    break;
                case 3:
                    rtZhadanie.Text = Chtenie("py 5.txt");
                    Otkritie("py 5.txt");
                    break;
                case 4:
                    rtZhadanie.Text = Chtenie("sql 5.txt");
                    Otkritie("sql 5.txt");
                    break;
            }
        }

        #endregion

        #region Жмяканье кнопок
        private void pb_sprav_Click(object sender, EventArgs e)
            //вызов справочки
        {
            Process.Start("Справка КТДП.html");
        }
        private void pb_sprav_MouseHover(object sender, EventArgs e)
            //подсказочка для справочки
        {
            t.SetToolTip(pb_sprav, "Открыть справочное руководство");
        }
        private void l_zhad_Click(object sender, EventArgs e)
            //открытие панели с заданиями
        {
            if (cb_lang.SelectedIndex == -1)
            {
                m.l_mes1.Visible = false;
                m.l_mes2.Visible = true;
                m.l_mes3.Visible = false;
                m.l_mes2.Text = "ВЫ НЕ ВЫБРАЛИ ЯЗЫК \nПРОГРАММИРОВАНИЯ";
                m.ShowDialog();
                cb_lang.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
                t_zhadan.Start();
        }
        private void pb_email_Click(object sender, EventArgs e)
            //открытие почтового клиента
        {
            string mail = string.Format("mailto:di.in.it@ya.ru?subject=Клавитурный%20тренажер%20для%20программиста&body=Спасибо%20за%20данную%20программу!!!");
            Process.Start(mail);
        }
        private void pb_email_MouseHover(object sender, EventArgs e)
            //подсказочка для отрытия емейла
        {
            t.SetToolTip(pb_email, "Написать разработчику");
        }
        private void pb_inst_MouseHover(object sender, EventArgs e)
            //подсказочка для инстаграма
        {
            t.SetToolTip(pb_inst, "Открыть Instagram разработчика");
        }
        private void pb_vk_MouseHover(object sender, EventArgs e)
            //подсказочка для вк
        {
            t.SetToolTip(pb_vk, "Открыть ВК разработчика");
        }
        private void pb_vk_Click(object sender, EventArgs e)
            //открытие веб-страницы вк
        {
            Process.Start("https://vk.com/d_44_p");
        }
        private void pb_inst_Click(object sender, EventArgs e)
            //открытие веб-страницы инстаграм
        {
            Process.Start("https://www.instagram.com/d.44.p/");
        }
        private void cbThema_Click(object sender, EventArgs e)
            //смена цветовой темы
        { 
            if (cbThema.Checked)
            {
                temnaya_thema();
            }
            else
            {
                svetlaya_thema();
            }
        }
        private void pb_minim_Click(object sender, EventArgs e)
            //сворачивание программы
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pb_exit_Click(object sender, EventArgs e)
            //закрытие программы
        {
            Application.Exit();
        }
        #endregion

        #region Дезигн (изменение состояние при наведении) Label-ов и PictureBox-ов
        /* MouseMove - происходит при наведении на элемент
         *  MouseLeave - происходит при отведении от элемента
         */
        private void l_zhad_MouseLeave(object sender, EventArgs e)
        {
            l_zhad.ForeColor = Color.White;
        }

        private void l_zhad_MouseMove(object sender, MouseEventArgs e)
        {
            l_zhad.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void zhad_1_MouseMove(object sender, MouseEventArgs e)
        {
            zhad_1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void zhad_1_MouseLeave(object sender, EventArgs e)
        {
            zhad_1.ForeColor = Color.White;
        }

        private void zhad_2_MouseMove(object sender, MouseEventArgs e)
        {
            zhad_2.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void zhad_2_MouseLeave(object sender, EventArgs e)
        {
            zhad_2.ForeColor = Color.White;
        }

        private void zhad_3_MouseMove(object sender, MouseEventArgs e)
        {
            zhad_3.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void zhad_3_MouseLeave(object sender, EventArgs e)
        {
            zhad_3.ForeColor = Color.White;
        }

        private void zhad_4_MouseLeave(object sender, EventArgs e)
        {
            zhad_4.ForeColor = Color.White;
        }

        private void zhad_4_MouseMove(object sender, MouseEventArgs e)
        {
            zhad_4.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void zhad_5_MouseMove(object sender, MouseEventArgs e)
        {
            zhad_5.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void zhad_5_MouseLeave(object sender, EventArgs e)
        {
            zhad_5.ForeColor = Color.White;
        }

        private void pb_email_MouseMove(object sender, MouseEventArgs e)
        {
            pb_email.Image = Properties.Resources.письмо1 as Bitmap;
        }

        private void pb_email_MouseLeave(object sender, EventArgs e)
        {
            pb_email.Image = Properties.Resources.письмо as Bitmap;
        }

        private void pb_sprav_MouseMove(object sender, MouseEventArgs e)
        {
            pb_sprav.Image = Properties.Resources.помощь1 as Bitmap;
        }

        private void pb_sprav_MouseLeave(object sender, EventArgs e)
        {
            pb_sprav.Image = Properties.Resources.помощь as Bitmap;
        }

        private void pb_vk_MouseLeave(object sender, EventArgs e)
        {
            pb_vk.Image = Properties.Resources.вк as Bitmap;
        }

        private void pb_vk_MouseMove(object sender, MouseEventArgs e)
        {
            pb_vk.Image = Properties.Resources.вк1 as Bitmap;
        }

        private void pb_inst_MouseMove(object sender, MouseEventArgs e)
        {
            pb_inst.Image = Properties.Resources.инста1 as Bitmap;
        }

        private void pb_inst_MouseLeave(object sender, EventArgs e)
        {
            pb_inst.Image = Properties.Resources.инста as Bitmap;
        }

        private void cb_lang_MouseMove(object sender, MouseEventArgs e)
        {
            cb_lang.BackColor = Color.White;
        }

        private void pb_minim_MouseMove(object sender, MouseEventArgs e)
        {
            pb_minim.Image = Properties.Resources.свернуть1 as Bitmap;
        }

        private void pb_minim_MouseLeave(object sender, EventArgs e)
        {
            pb_minim.Image = Properties.Resources.свернуть as Bitmap;
        }

        private void pb_exit_MouseMove(object sender, MouseEventArgs e)
        {
            pb_exit.Image = Properties.Resources.закрыть1 as Bitmap;
        }

        private void pb_exit_MouseLeave(object sender, EventArgs e)
        {
            pb_exit.Image = Properties.Resources.закрыть as Bitmap;
        }
        #endregion

        #region Смена цветовой темы
        private void svetlaya_thema()
            //светлая тема цветовой схемы программы
        {
            BackColor = Color.White;
            p_klav.BackColor = Color.White;
            rtZhadanie.BackColor = Color.White;
            pb_minim.BackColor = Color.White;
            pb_exit.BackColor = Color.White;
            lVremya.BackColor = Color.White;
            lVr.BackColor = Color.White;
            pMenu.BackColor = Color.FromArgb(4, 157, 191);
            lThema.BackColor = Color.FromArgb(4, 157, 191);
            lvibor.BackColor = Color.FromArgb(4, 157, 191);
            m.BackColor = Color.FromArgb(4, 157, 191);
        }
        private void temnaya_thema()
            //темная тема цветовой схемы программы
        {
            BackColor = Color.FromArgb(130, 132, 148);
            p_klav.BackColor = Color.FromArgb(130, 132, 148);
            rtZhadanie.BackColor = Color.FromArgb(130, 132, 148);
            pb_minim.BackColor = Color.FromArgb(130, 132, 148);
            pb_exit.BackColor = Color.FromArgb(130, 132, 148);
            lVremya.BackColor = Color.FromArgb(130, 132, 148);
            pMenu.BackColor = Color.FromArgb(102, 106, 140);
            lVr.BackColor = Color.FromArgb(130, 132, 148);
            lsled.ForeColor = Color.FromArgb(64, 64, 64);
            lThema.BackColor = Color.FromArgb(102, 106, 140);
            lvibor.BackColor = Color.FromArgb(102, 106, 140);
            m.BackColor = Color.FromArgb(102, 106, 140);
        }
        #endregion
    }
}
