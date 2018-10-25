using New_gifts1.classes;
using NewGifts1.Enum;
using NewGifts1.interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace New_gifts1
{
    public partial class Form1 : Form
    {
        private IGift _gift;
        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int j = 0;
            foreach (var i in _gift.Items)
            {
                listBox1.Items.Insert(j, String.Format("{0}, {1}", i.TypeOfSweetness, i.ItemInfo));
                j++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        
        private void Initialize()
        {
            _gift = new Gift("GiftFofSTEM", new List<ISweetness>()); 
            Candy Konfetka = new Candy("Барбариски", 10, 50, 100, TypeOfCandy.Caramel);
            Candy Konfetka1 = new Candy("Бешенная пчелка", 15, 60, 250, TypeOfCandy.Dgele);
            Candy Konfetka2 = new Candy("Ириска", 20, 75, 300, TypeOfCandy.Iric);
            Candy Konfetka3 = new Candy("Чупа-чупс", 30, 65, 150, TypeOfCandy.Caramel);
            Candy Konfetka4 = new Candy("Коровка", 25, 65, 220,TypeOfCandy.Milk);
            Candy Konfetka5 = new Candy("Грильяж", 20, 35, 350, TypeOfCandy.Grillage);
            Candy Konfetka6 = new Candy("Свежая капля", 13, 40, 70, TypeOfCandy.Milk);
            Chocolate chocolate = new Chocolate("Аленка", 100, 60, 540, TypeOfChocolate.Milk);
            _gift.AddSweet(Konfetka);
            _gift.AddSweet(Konfetka1);
            _gift.AddSweet(Konfetka2);
            _gift.AddSweet(Konfetka3);
            _gift.AddSweet(Konfetka4);
            _gift.AddSweet(Konfetka5);
            _gift.AddSweet(Konfetka6);
            _gift.AddSweet(chocolate);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Typeofchocolate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var temp = _gift.SortSweetnessByWeight();
            int j = 0;
            foreach (var i in temp)
            {
                listBox1.Items.Insert(j, String.Format("Name: {0}," + "SugarPerUnit: {1}", i.Name, i.Vec));
                j++;
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            int j = 0;
         
            double min = Convert.ToDouble(minsugar.Text);
            double max = Convert.ToDouble(maxsugar.Text);
            var temp = _gift.FindSweetnessBySugar(min, max);
            foreach (var i in temp)
            {
                listBox1.Items.Insert(j, String.Format("Name: {0}," + "SugarPerUnit: {1}", i.Name, i.SugarPerUnit));
                j++;
            }
           
        }
    }
}