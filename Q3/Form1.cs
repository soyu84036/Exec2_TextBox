using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "輸入生日判斷是否已滿 13 歲";
            this.MinimizeBox = this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            runButton.Text = "執行";

            resultLabel.Text = String.Empty;
            resultLabel.Font = new Font("標楷體", 12, FontStyle.Bold);

            birthTextBox.MaxLength = 10;
            birthTextBox.Font = new Font("標楷體", 10, FontStyle.Regular);

            titleLabel.Text = "請輸入生日(西元年/月/日): ";
            titleLabel.Font = new Font("標楷體", 10, FontStyle.Regular);

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // 取得出生日期
            DateTime birthday = DateTime.Today;
            try 
            { birthday = GetBirthday(); }
            catch(Exception ex) 
            { MessageBox.Show(ex.Message);
                return;
            }

            // 生日是否在今天之後
            if (birthday > DateTime.Today)            
            {
                MessageBox.Show("出生日期不能在今天以後");
                return;
            }


            // 判斷是否已滿13歲
            int age = DateTime.Today.Year - birthday.Year;
            string result = String.Empty;
            int limit = 13;
            if ( age >= limit)
            { result = $"已滿{limit}歲"; }
            else { result = $"未滿{limit}歲"; }

            // 呈現結果
            resultLabel.Text = $"您的年紀，{result}";

        }

        private DateTime GetBirthday()
        {
            string input = birthTextBox.Text;
            bool isDateTime = DateTime.TryParse(input, out DateTime date);

            return isDateTime
                ? date
                : throw new Exception("請輸入正確的日期，且格式要正確");
        }
    }
}
