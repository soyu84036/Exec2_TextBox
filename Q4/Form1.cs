using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "計算入場費用";
            this.MinimizeBox = this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            peopleTextBox.MaxLength = 3;
            carsTextBox.MaxLength = 4;

            peopleLabel.Font = new Font("標楷體", 10, FontStyle.Regular);

            carsLabel.Font = new Font("標楷體", 10, FontStyle.Regular);

            resultLabel.Font = new Font("標楷體", 12, FontStyle.Bold);
            resultLabel.Text = String.Empty;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 取得人數和車輛
            int people = 0, cars = 0;
            try
            {
                people = GetInt(peopleTextBox);
                cars = GetInt(carsTextBox);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // 車輛計費
            decimal eachCar = 200;
            decimal carCost = cars * eachCar;

            // 人數計費
            decimal person = 60;
            decimal peopleCost = people * person;

            // 以較便宜的方式收取費用
            decimal totalCost = carCost + peopleCost;
            decimal actualCost = (carCost >= peopleCost)
                ? peopleCost : carCost;

            // 呈現結果
            resultLabel.Text = $"車輛計費: {carCost}\r\n" +
                $"人數計費: {peopleCost}\r\n" +
                $"總共花費: {totalCost}";

            MessageBox.Show($"實際花費: {actualCost}");


        }

        private int GetInt(TextBox textBox)
        {
            string input = textBox.Text;
            bool isInt = int.TryParse(input, out int value);

            return (isInt && value > 0)
                ? value
                : throw new Exception("請輸入正確的人數與車的數量");
        }
    }

}
