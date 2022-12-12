using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_2._0
{
    public partial class Form1 : Form
    {
        public bool flag = false;
        public Random r = new Random();
        public int random = -1;
        public int random1 = -1;
        public int random2 = -1;
        public int temp = 0;
        public int temp1 = 0;
        public int temp2 = 0;
        public int point = 0;
        public int score = 0;
        public int time = 0;
        public int time1 = 0;
        public int gameState = 0;
        public string season = " ";
        public string bait = " ";
        public string fish = " ";
        public int fishInt = 0;

        //public string fishingLine = " ";  Заготовка для версії 0.2
        //public string hook = " ";         Заготовка для версії 0.2
        public void GameOver(string s)
        {
            timer1.Stop();
            time = 0;
            button3.BackColor = Color.White;
            MessageBox.Show("Game Over  " + s);
            gameState = 0;
            flag = false;
            temp1 = 0;
            pictureBox1.Image = new Bitmap("image/1.png");
            point = 0;
            progressBar1.Value = 0;
        }
        public void GameWin()
        {
            progressBar1.Value = 0;
            point = 0;
            timer1.Stop();
            time = 0;
            button3.BackColor = Color.Gold;
            pictureBox1.Image = new Bitmap("image/5.png");
            gameState = 0;
            flag = false;
            temp1 = 0;
            fish = Fish(fish);
            MessageBox.Show("Ви впіймали: \n\r" + fish);
        }
        public string Fish(string fish)
        {            
            season = comboBox1.Text;
            bait = comboBox2.Text;
            //hook = comboBox3.Text;         Заготовка для версії 0.2
            //fishingLine = comboBox4.Text;  Заготовка для версії 0.2
            switch (season)
            {
                case "Березень":
                    switch (bait)
                    {
                        case "Живець":
                            fish = "Щука";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                case "Квітень":
                    switch (bait)
                    {
                        case "Живець":
                            fishInt = r.Next(1, 2);
                            if (fishInt == 1)
                            {
                                fish = "Щука";
                            }
                            else
                            {
                                fish = "Жерех";
                            }
                            break;
                        case "Червяк":

                            fishInt = r.Next(1, 5);
                            if (fishInt == 1)
                            {
                                fish = "Говаль";
                            }
                            else if(fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Окунь";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Плітка";
                            }
                            break;

                        case "Тісто":
                            fishInt = r.Next(1, 2);
                            if (fishInt == 1)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Краснопірка";
                            }
                            break;

                        case "Опариш":
                            fishInt = r.Next(1, 2);
                            if (fishInt == 1)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Краснопірка";
                            }
                            break;
                        case "Перловка":
                            fish = "Краснопірка"; 
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                case "Травень":                    
                    switch (bait)
                    {
                    case "Живець":
                        fishInt = r.Next(1, 4);
                        if (fishInt == 1)
                        {
                            fish = "Жерех";
                        }
                        else if (fishInt == 2)
                        {
                            fish = "Судак";
                        }
                        else if (fishInt == 3)
                        {
                            fish = "Щука";
                        }
                        else if (fishInt == 3)
                        {
                            fish = "Сом";
                        }
                        break;
                    case "Червяк":
                        fishInt = r.Next(1, 9);
                        if (fishInt == 1)
                        {
                            fish = "Говаль";
                        }
                        else if (fishInt == 2)
                        {
                            fish = "Карась";
                        }
                        else if (fishInt == 3)
                        {
                            fish = "Короп";
                        }
                        else if (fishInt == 4)
                        {
                            fish = "Краснопірка";
                        }
                        else if (fishInt == 5)
                        {
                            fish = "Лящ";
                        }
                        else if (fishInt == 6)
                        {
                            fish = "Лин";
                        }
                        else if (fishInt == 7)
                        {
                            fish = "Окунь";
                        }
                        else if (fishInt == 8)
                        {
                            fish = "Плітка";
                        }
                        else if (fishInt == 9)
                        {
                            fish = "Сазан";
                        }
                        break;

                    case "Тісто":
                        fishInt = r.Next(1, 7);
                        if (fishInt == 1)
                        {
                            fish = "Карась";
                        }
                        else if (fishInt == 2)
                        {
                            fish = "Короп";
                        }
                        else if (fishInt == 3)
                        {
                            fish = "Краснопірка";
                        }
                        else if (fishInt == 4)
                        {
                            fish = "Лящ";
                        }
                        else if (fishInt == 6)
                        {
                            fish = "Плітка";
                        }
                        else if (fishInt == 7)
                        {
                            fish = "Сазан";
                        }
                        break;


                    case "Опариш":
                        fishInt = r.Next(1, 5);
                        if (fishInt == 1)
                        {
                            fish = "Карась";
                        }
                        else if (fishInt == 2)
                        {
                            fish = "Короп";
                        }
                        else if (fishInt == 3)
                        {
                            fish = "Краснопірка";
                        }
                        else if (fishInt == 4)
                        {
                            fish = "Лящ";
                        }
                        else if (fishInt == 5)
                        {
                            fish = "Плітка";
                        }
                        break;
                    case "Варена картопля":
                        fish = "Короп";
                        break;
                    case "Перловка":
                        fish = "Краснопірка";
                        break;
                    default:
                        fish = "НІЧОГО";
                        break;
                }
                    break;                                
                case "Червень":
                    switch (bait)
                    {
                        case "Живець":
                            fishInt = r.Next(1, 3);
                            if (fishInt == 1)
                            {
                                fish = "Жерех";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Судак";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Щука";
                            }
                            break;
                        case "Червяк":
                            fishInt = r.Next(1, 8);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 6)
                            {
                                fish = "Лин";
                            }
                            else if (fishInt == 7)
                            {
                                fish = "Окунь";
                            }
                            else if (fishInt == 8)
                            {
                                fish = "Плітка";
                            }
                            break;

                        case "Тісто":
                            fishInt = r.Next(1, 7);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 6)
                            {
                                fish = "Плітка";
                            }                           
                            break;


                        case "Опариш":
                            fishInt = r.Next(1, 5);
                            if (fishInt == 1)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Плітка";
                            }
                            break;
                        case "Варена картопля":
                            fish = "Короп";
                            break;
                        case "Перловка":
                            fish = "Краснопірка";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break; 
                case "Липень":
                    switch (bait)
                    {
                        case "Живець":
                            fishInt = r.Next(1, 2);
                            if (fishInt == 1)
                            {
                                fish = "Жерех";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Судак";
                            }
                            break;
                        case "Червяк":
                            fishInt = r.Next(1, 6);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 6)
                            {
                                fish = "Лин";
                            }                       
                            break;

                        case "Тісто":
                            fishInt = r.Next(1, 5);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }                         
                            break;


                        case "Опариш":
                            fishInt = r.Next(1, 4);
                            if (fishInt == 1)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Лящ";
                            }
                            break;
                        case "Варена картопля":
                            fish = "Короп";
                            break;
                        case "Перловка":
                            fish = "Краснопірка";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                case "Серпень":
                    switch (bait)
                    {
                        case "Живець":
                            fish = "Щука";
                            break;
                        case "Червяк":
                            fishInt = r.Next(1, 6);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 6)
                            {
                                fish = "Лин";
                            }                          
                            break;

                        case "Тісто":
                            fishInt = r.Next(1, 5);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                         
                            break;


                        case "Опариш":
                            fishInt = r.Next(1, 4);
                            if (fishInt == 1)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Лящ";
                            }
                            break;
                        case "Варена картопля":
                            fish = "Короп";
                            break;
                        case "Перловка":
                            fish = "Краснопірка";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                case "Вересень":
                    switch (bait)
                    {
                        case "Живець":
                            fish = "Щука";
                            break;
                        case "Червяк":
                            fishInt = r.Next(1, 8);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 6)
                            {
                                fish = "Лин";
                            }
                            else if (fishInt == 7)
                            {
                                fish = "Плітка";
                            }
                            else if (fishInt == 8)
                            {
                                fish = "Сазан";
                            }
                            break;

                        case "Тісто":
                            fishInt = r.Next(1, 7);
                            if (fishInt == 1)
                            {
                                fish = "Амур білий";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 6)
                            {
                                fish = "Плітка";
                            }
                            else if (fishInt == 7)
                            {
                                fish = "Сазан";
                            }
                            break;
 

                        case "Опариш":
                            fishInt = r.Next(1, 5);
                            if (fishInt == 1)
                            {
                                fish = "Карась";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Короп";
                            }
                            else if (fishInt == 3)
                            {
                                fish = "Краснопірка";
                            }
                            else if (fishInt == 4)
                            {
                                fish = "Лящ";
                            }
                            else if (fishInt == 5)
                            {
                                fish = "Плітка";
                            }
                            break;
                        case "Варена картопля":
                            fish = "Короп";
                            break;
                        case "Перловка":
                            fish = "Краснопірка";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                case "Жовтень":
                    switch (bait)
                    {

                        case "Живець":
                            fishInt = r.Next(1, 2);
                            if (fishInt == 1)
                            {
                                fish = "Судак";
                            }
                            else if (fishInt == 2)
                            {
                                fish = "Щука";
                            }
                            break;

                        case "Червяк":
                            fish = "Плітка";
                            break;

                        case "Тісто":
                            fish = "Плітка";
                            break;

                        case "Опариш":
                            fish = "Плітка";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                case "Листопад":
                    switch (bait)
                    {
                        case "Живець":
                            fish = "Судак";
                            break;
                        default:
                            fish = "НІЧОГО";
                            break;
                    }
                    break;
                default:
                    fish = "НІЧОГО";
                    break;
            }
            return fish;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("image/1.png");            
        }
        private void Help(object sender, EventArgs e)
        {            
            MessageBox.Show("♦ Як грати? ♦\r\n" +
                "♦ Все дуже просто, для початку потрібно вибрати Сезон та Наживку(без них ви аж ніяк не зловите рибку)\n\r" +
                "♦ Якщо хочете глянути для якої риби, які данні потрібні, нажміть на кнопку \"Для Рибки\"\n\r" +
                "♦ Після того як налаштуємо обов'язкові параметри нажимаємо кнопочку \"Play\"\n\r" +
                "♦ Гра працює по принципу світлофора, і коли кнопка стане зеленою, то потрібно тримани кнопку включеною(зажати клавішу мишки на кнопкі) аж до поки не включиться жовтий колір\n\r" +
                "♦ Якщо ви підпустили кнопку ще на зеленому кольорі, у вас ще буде шанс не програти, потрібно нажати на кнопку коли вона буде жовтою, інакше ви програєте\n\r" +
                "♦ Якщо загорається жовтий колір, рекомендовано пибрати палець з мишки як мога бистріше тому, що який інтервал часу буде горіти жовта кнопка - невідомо, проте відомо, що після жовтого кольору йде червоний\n\r" +
                "♦ І як ви вже могли здогадатись, якщо ж загорається червоний колір, а ви тримаєте кнопку нажатою, ви програли.\n\r");
        }
        

        private void Timer(object sender, EventArgs e)
        {
            progressBar1.Value = point;
            time++;                 
            if(score <= point)
            {
                GameWin();
                
            }
            if(time <= temp && flag == true)
            {
                if(temp1 == 0)
                {
                    GameOver("Рибка ще не клюнула");
                }
                else
                {
                    GameOver("Рибка зірвалась");
                }
                
            }
            if (time == temp)
            {
                pictureBox1.Image = new Bitmap("image/3.png");
                button3.BackColor = Color.Green;
                time = 0;
                temp = -1;
            }
            if (temp == -1)
            {
                if (time <= random && flag == true)
                {
                    point++;
                    
                }
                if (time > random && flag == true)
                {
                    button3.BackColor = Color.Yellow;
                    time = 0;
                    random = (int)random / 2;
                    temp = -2;
                }
                else if(time > random && flag == false)
                {
                    button3.BackColor = Color.Yellow;
                    time = 0;
                    random = (int)random / 2;
                    temp = -2;
                    temp2++;
                }
                
            }
            else if (temp == -2)
            {
                if (time <= random && flag == true)
                {
                    point += 2;  
                }
                if (time == random && flag == false)
                {
                    if(temp2 == 0)
                    {
                        temp = r.Next(20, 40);
                        random = r.Next(20, 40);
                        time = 0;
                        button3.BackColor = Color.Red;
                        temp1++;
                    }
                    else
                    {
                        GameOver("Рибка зірвалась");
                    }
                    
                }
                if (time > random)
                {
                    GameOver("Рибка зірвалась");
                    
                }       
            }
        }

        private void Play_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameState == 1)
            {
                flag = true;
                pictureBox1.Image = new Bitmap("image/4.png");
            }
            temp2 = 0;
                
        }

        private void Play_MouseUp(object sender, MouseEventArgs e)
        {
            if (button3.BackColor == Color.Green || button3.BackColor == Color.Yellow)
            {
                flag = false;
                pictureBox1.Image = new Bitmap("image/3.png");
            }

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                pictureBox1.Image = new Bitmap("image/2.png");
                button3.BackColor = Color.Red;
                time = 0;
                timer1.Start();
                temp = r.Next(20, 40);
                random = r.Next(20, 40);
                score = r.Next(100, 500);
                gameState = 1;
                progressBar1.Maximum = score;

            }
        }

        private void FishHelp(object sender, EventArgs e)
        {
            if (comboBox6.Text == "Інформаційна табличка 1")
            {
                pictureBox1.Image = new Bitmap("image/info1.png");
            } else if (comboBox6.Text == "Інформаційна табличка 2")
            {
                pictureBox1.Image = new Bitmap("image/info2.png");
            }
            else if (comboBox6.Text == "Інформаційна табличка 3")
            {
                pictureBox1.Image = new Bitmap("image/info3.png");
            }
            else 
            {
                MessageBox.Show("Спочатку оберіть один із пунктів у випливаючому списку вище");
            }
        }
    }
}
