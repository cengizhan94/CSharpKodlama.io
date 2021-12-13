using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork1Video40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // ButtonsDemo();
        }

        private void ButtonsDemo()
        {
            Button[,] buttons = new Button[8, 8];//< burada 8-8 lik 64 tane button olsun diye Arraylerden yararlanıyorum
            int top = 0;//<Burada form klasımın içine buttonları eklediğimde,
            int left = 0;//Buttonlar üst üste değil de yan yana dizilsinler diye üstten ve soldan mesafeler ayarlayabilmek için top ve left değişkenlerini tanımladım.

            //Buradaki iç içe for döngüleri index no sıfır olan satıra..
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                //index no sıfır olan buttonu koy demek oluyor.
                //Döngü devam ettikçe sıfırıncı satırın 1. buttonu, 2. buttonu ...
                //Döngü devam ettikçe 1. satırın sıfırıncı buttonu gibi 8-8 lik 64 button olana kadar sürecek.
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    //Burada her button yeni bir button olduğundan button klasını newliyoruz.
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;//Buttonumun genişlik ve yüksekliklerini ayarlıyorum.
                    buttons[i, j].Height = 50;//^
                    buttons[i, j].Left = left;
                    left += 50;//Buttonlarım yan yana gelmeleri için left değişkenime değer atadım
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);//Buttonumu form classıma ekliyorum.
                }
                top += 50;//sekiz button yan yana dizdikten sonra alt satıra geçebilsin diye top değerime 50 atadım. 
                left = 0;
            }

        }
    }
}
