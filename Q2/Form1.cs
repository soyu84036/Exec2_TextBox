using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "輸入日期是否不大於今天";
            this.MinimizeBox = this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            generateButton.Text = "執行";

            resultLabel.Text = String.Empty;
            resultLabel.Font = new Font("Aril", 12, FontStyle.Regular);

            yearLabel.Text = "年 (西元)";
            yearLabel.Font = new Font("Aril", 10, FontStyle.Bold);
            monthLabel.Text = "月";
            monthLabel.Font = new Font("Aril", 10, FontStyle.Bold);
            dayLabel.Text = "日";
            dayLabel.Font = new Font("Aril", 10, FontStyle.Bold);

            yearTextBox.MaxLength = 4;
            monthTextBox.MaxLength = 2;
            dayTextBox.MaxLength = 2;

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // todo 清空textbox 
            // 取得輸入的年月日的值
            int year = 0, month = 0, day = 0;
            try
            {
                year = GetYear();
                month = GetMonth();
                day = GetDay();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
                return;
            }

            // 判斷輸入的年月日是正確的
            DateTime date = DateTime.Now; ;
            try { date = CorrectDate(year, month, day); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            resultLabel.Text = $"輸入的日期: \r\n\r\n{date:yyyy / MM / dd}";

            // 判斷時間在今天之前還是之後
            TimeSpan timeSpan = DateTime.Today - date;
            string result=string.Empty;
            if (timeSpan.Days < 0)
            { result = "大於"; }
            else if (timeSpan.Days > 0)
            { result = "小於"; }
            else 
            { result = "是"; }

            // 呈現結果
            MessageBox.Show($"輸入的日期{result}今天");
        }

        private DateTime CorrectDate(int year, int month, int day)
        {
            string dateToString = Convert.ToString(year) + "/" + Convert.ToString(month) + "/" + Convert.ToString(day);
            bool isdate = DateTime.TryParse(dateToString, out DateTime date);

            return isdate ? date : throw new Exception("請輸入確實的年月日");
        }

        private int GetDay()
        {
            TextBox txt = dayTextBox;
            string title = "日期";

            return GetInt(txt, title); ;
        }

        private int GetMonth()
        {
            TextBox txt = monthTextBox;
            string title = "月份";

            return GetInt(txt, title); ;
        }

        private int GetInt(TextBox txt, string title)
        {
            string input = txt.Text;
            bool isint = int.TryParse(input, out int value);

            return isint ? value : throw new Exception($"請輸入正確的{title}");
        }

        private int GetYear()
        {
            TextBox txt = yearTextBox;
            string title = "年份";

            return GetInt(txt, title); ;
        }
    }
}
