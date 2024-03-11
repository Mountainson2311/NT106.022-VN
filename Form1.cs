using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        bool check = true; // kiếm tra trên màn hình có phép tính trước đó hay ko
        string sign = "";
        double value1, value2;
        double kq = 0;
        double kqmul = 1;
        string sig;
        string specialsign = "";
        public Form1()
        {
            InitializeComponent();
            result.Text = "0";

        }
        #region numberbutton       
        private void seven_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "7";
            else
            {
                result.Text = "7";
                check = true;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "0";
            else
            {
                result.Text = "0";
                check = true;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {

            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "1";
            else
            {
                result.Text = "1";
                check = true;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "2";
            else
            {
                result.Text = "2";
                check = true;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "3";
            else
            {
                result.Text = "3";
                check = true;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "4";
            else
            {
                result.Text = "4";
                check = true;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "5";
            else
            {
                result.Text = "5";
                check = true;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "6";
            else
            {
                result.Text = "6";
                check = true;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "8";
            else
            {
                result.Text = "8";
                check = true;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "9";
            else
            {
                result.Text = "9";
                check = true;
            }
        }
        #endregion

        bool checksign = true;//kiểm tra phép tính dồn

        #region sign
        private void add_Click(object sender, EventArgs e)
        {
            if (checksign == true && check == true)
            {
                converse(result.Text, ref value1);
                if (specialsign == "xcany")
                {
                    result.Text = (Math.Pow(x, (double)1 / value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else if (specialsign == "xmuy")
                {
                    result.Text = (Math.Pow(y, value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else if (specialsign == "mod")
                {
                    result.Text = (a % value1).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }

                if (sign == "") kq = value1;
                else
                if (sign == "-") kq -= value1;
                else if (sign == "x")
                {

                    if (sig == "-")
                        kq = kq - value1 * kqmul;
                    else if (sig == "+" || sig == "") kq += value1 * kqmul;
                    else if (sig == "/") kq /= value1 * kqmul;
                    kqmul = 1;
                }
                else if (sign == ":")
                {
                    if (sig == "-")
                        kq = kq - kqmul / value1;
                    else if (sig == "+" || sig == "") kq += kqmul / value1;
                    else if (sig == "/") kq /= kqmul / value1;
                    kqmul = 1;

                }
                else kq += value1;
                if (specialsign == "") calcu.Text += result.Text + "+";
                else
                {
                    if (specialsign == "xcany")
                        calcu.Text += value2.ToString() + ")+";
                    else if (specialsign == "xmuy" || specialsign == "mod")
                        calcu.Text += value2.ToString() + "+";
                    else
                        calcu.Text += "+";
                    specialsign = "";
                }
                result.Text = kq.ToString();
                check = false;
                sign = "+";
            }
            else
            {
                checksign = true;
                sign = "+";
                converse(result.Text, ref value1);
                //kq += value1;
                calcu.Text = result.Text + "+";
                result.Text = "";
                check = false;
            }

        }

        private void subtract_Click(object sender, EventArgs e)
        {

            if (checksign == true && check == true)
            {
                converse(result.Text, ref value1);
                if (specialsign == "xcany")
                {
                    result.Text = (Math.Pow(x, (double)1 / value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else
                if (specialsign == "xmuy")
                {
                    result.Text = (Math.Pow(y, value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else if (specialsign == "mod")
                {
                    result.Text = (a % value1).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                if (sign == "") kq = value1;
                else
                if (sign == "-") kq -= value1;
                else if (sign == "x")
                {
                    if (sig == "-")
                        kq = kq - value1 * kqmul;
                    else if (sig == "+" || sig == "") kq += value1 * kqmul;
                    else if (sig == "/") kq /= value1 * kqmul;
                    kqmul = 1;
                }
                else if (sign == ":")
                {
                    if (sig == "-")
                        kq = kq - kqmul / value1;
                    else if (sig == "+" || sig == "") kq += kqmul / value1;
                    else if (sig == "/") kq /= kqmul / value1;
                    kqmul = 1;
                }
                else kq += value1;
                sign = "-";
                if (specialsign == "") calcu.Text += result.Text + "-";
                else
                {
                    if (specialsign == "xcany")
                    {
                        calcu.Text += value2.ToString() + ")-";
                        specialsign = "";
                    }
                    else
                    if (specialsign == "xmuy" || specialsign == "mod")
                    {
                        calcu.Text += value2.ToString() + "-";
                        specialsign = "";
                    }

                    else
                    {
                        calcu.Text += "-";
                        specialsign = "";
                    }
                }

                result.Text = kq.ToString();
                sign = "-";
                check = false;

            }
            else// trường hợp đã nhấn nút '=' , tiếp tục lấy kết quả để nhân tiếp nhưng xóa màn hình
            {
                checksign = true;
                sign = "-";
                converse(result.Text, ref value1);
                //kq += value1;
                calcu.Text = result.Text + "-";
                result.Text = "";
                check = false;
            }

        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (checksign == true && check == true)
            {
                converse(result.Text, ref value1);
                if (sign == "")
                {
                    kqmul = value1;
                    sig = sign;
                }
                else
                if (sign == "-" || sign == "+")
                {
                    sig = sign;
                    kqmul *= value1;
                }
                else if (sign == ":")
                {
                    kqmul = kqmul / value1;
                }
                else kqmul *= value1;

                result.Text = kqmul.ToString();
                if (specialsign == "")
                    calcu.Text += value1.ToString() + "x";
                else if (specialsign == "xcany")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(x, (double)1 / value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(x, (double)1 / value1);
                    calcu.Text += value1.ToString() + ")" + "x";
                    result.Text = kqmul.ToString();
                }
                else if (specialsign == "xmuy")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(y, value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(y, value1);
                    calcu.Text += value1.ToString() + "x";
                    result.Text = kqmul.ToString();
                }
                else if (specialsign == "mod")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / (a % value1);
                    else
                        kqmul = kqmul / value1 * (a % value1);
                    calcu.Text += value1.ToString() + "x";
                    result.Text = kqmul.ToString();
                }
                else
                {
                    calcu.Text += "x";
                }
                specialsign = "";
                sign = "x";
                check = false;
            }
            else
            {
                checksign = true;
                sign = "x";
                converse(result.Text, ref value1);
                calcu.Text = result.Text + "x";
                result.Text = "";
                check = false;
            }
        }
        private void devide_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có phải là phép tính tiếp theo hay không
            if (checksign == true && check == true)
            {
                // Chuyển đổi chuỗi kết quả thành giá trị số và lưu vào value1
                converse(result.Text, ref value1);

                // Xử lý phép tính trước đó
                if (sign == "")
                {
                    kqmul = value1;
                    sig = sign;
                }
                else if (sign == "-" || sign == "+")
                {
                    sig = sign;
                    kqmul = value1;
                }
                else if (sign == ":")
                {
                    // Kiểm tra trường hợp chia cho 0
                    if (value1 != 0)
                        kqmul = kqmul / value1;
                    else
                    {
                        // Xử lý khi chia cho 0
                        MessageBox.Show("Không thể chia cho 0!");
                        // Đặt lại giá trị và thoát khỏi hàm
                        result.Text = "0";
                        return;
                    }
                 
                }
                else
                {
                    kqmul *= value1;
                }

                // Hiển thị kết quả và dấu phép tính
                result.Text = kqmul.ToString();
                if (specialsign == "")
                    calcu.Text += value1.ToString() + "÷";
                else if (specialsign == "xcany")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(x, (double)1 / value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(x, (double)1 / value1);
                    calcu.Text += value1.ToString() + ")" + "÷";
                    result.Text = kqmul.ToString();
                }
                else if (specialsign == "xmuy")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(y, value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(y, value1);
                    calcu.Text += value1.ToString() + "÷";
                    result.Text = kqmul.ToString();
                }
                else if (specialsign == "mod")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / (a % value1);
                    else
                        kqmul = kqmul / value1 * (a % value1);
                    calcu.Text += value1.ToString() + "÷";
                    result.Text = kqmul.ToString();
                }
                else
                    calcu.Text += "÷";

                // Đặt lại các biến và cờ
                specialsign = "";
                sign = ":";
                check = false;
            }
            else
            {
                // Kiểm tra nếu đã có kết quả từ phép tính trước đó
                if (!string.IsNullOrEmpty(result.Text))
                {
                    // Xác định phép tính mới và chuẩn bị cho phép tính tiếp theo
                    checksign = true;
                    sign = "÷";
                    converse(result.Text, ref value1);
                    calcu.Text = result.Text + "÷";
                    result.Text = "";
                    check = false;
                }
            }
        }



        void converse(string s, ref double value)
        {
            try
            {
                value = double.Parse(s);
            }
            catch (Exception)
            {
                MessageBox.Show("your number is not valid");

            }

        }
        // dấu "="
        private void equal_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    if (checksign)
                    {
                        converse(result.Text, ref value2);
                        if (specialsign == "xcany")
                        {
                            calcu.Text += value2.ToString() + ")";
                            value2 = Math.Pow(x, (double)1 / value2);
                        }
                        else if (specialsign == "xmuy")
                        {
                            calcu.Text += value2.ToString();
                            value2 = Math.Pow(y, value2);
                        }
                        else if (specialsign == "mod")
                        {
                            calcu.Text += value2.ToString();
                            value2 = a % value2;
                        }
                        else if (specialsign == "")
                            calcu.Text += value2.ToString();
                        result.Text = (kq + value2).ToString();
                        kq += value2;
                        checksign = false;
                    }
                    else// phép tính dồn
                    {
                        converse(result.Text, ref value1);
                        calcu.Text = value1.ToString() + sign + value2.ToString();
                        kq += value2;
                        result.Text = (value1 + value2).ToString();

                    }
                    specialsign = "";
                    check = false;
                    break;

                case "-":
                    if (checksign)
                    {
                        converse(result.Text, ref value2);
                        if (specialsign == "xcany")
                        {
                            calcu.Text += value2.ToString() + ")";
                            value2 = Math.Pow(x, (double)1 / value2);
                        }
                        else if (specialsign == "xmuy")
                        {
                            calcu.Text += value2.ToString();
                            value2 = Math.Pow(y, value2);
                        }
                        else if (specialsign == "mod")
                        {
                            calcu.Text += value2.ToString();
                            value2 = a % value2;
                        }
                        else if (specialsign == "")
                            calcu.Text += value2.ToString();
                        result.Text = (kq - value2).ToString();
                        kq -= value2;
                        checksign = false;
                    }
                    else
                    {
                        converse(result.Text, ref value1);
                        calcu.Text = value1.ToString() + sign + value2.ToString();
                        kq -= value2;
                        result.Text = (value1 - value2).ToString();

                    }
                    specialsign = "";
                    check = false;
                    break;
                case "x":

                    if (checksign)// phép 2 số
                    {
                        converse(result.Text, ref value2);

                        if (specialsign == "")
                            calcu.Text += value2.ToString();
                        else
                        {
                            calcu.Text += value2.ToString();
                            if (specialsign == "xcany")
                            {
                                calcu.Text += ")";
                                value2 = Math.Pow(x, (double)1 / value2);
                            }
                            else if (specialsign == "xmuy")
                            {
                                value2 = Math.Pow(y, value2);
                            }
                            else if (specialsign == "mod")
                            {

                                value2 = a % value2;
                            }

                        }

                        specialsign = "";
                        if (sig == "+" || sig == "")
                            kq += kqmul * value2;
                        else if (sig == "-")
                            kq -= kqmul * value2;
                        result.Text = kq.ToString();
                        kqmul = 1;
                        checksign = false;
                    }
                    else// phép tính dồn
                    {
                        converse(result.Text, ref value1);
                        calcu.Text = value1.ToString() + sign + value2.ToString();
                        kq *= value2;
                        result.Text = (value1 * value2).ToString();

                    }
                    check = false;
                    break;
                case ":":
                    converse(result.Text, ref value1);

                    if (value1 != 0)
                    {
                        if (checksign)// phép 2 số
                        {
                            value2 = value1;//dùng cho phép chia dồn để giữ số chia;
                            if (specialsign == "")
                                calcu.Text += value1.ToString();
                            else
                            {
                                calcu.Text += value1.ToString();
                                if (specialsign == "xcany")
                                {
                                    calcu.Text += ")";
                                    value1 = Math.Pow(x, (double)1 / value1);
                                }
                                else if (specialsign == "xmuy")
                                    value1 = Math.Pow(y, value1);
                                else if (specialsign == "mod")
                                    value2 = a % value2;
                            }

                            if (sig == "+" || sig == "")
                                kq += kqmul / value1;
                            else if (sig == "-")
                                kq -= kqmul / value1;
                            result.Text = kq.ToString();
                            kqmul = 1;
                            specialsign = "";
                            checksign = false;
                        }
                        else// phép tính dồn
                        {
                            calcu.Text = value1.ToString() + sign + value2.ToString();
                            kq /= value2;
                            result.Text = kq.ToString();
                        }
                    }
                    else
                        result.Text = "Math error";
                    check = false;
                    break;
                case "":
                    if (specialsign == "xcany")
                    {
                        converse(result.Text, ref value1);
                        calcu.Text += result.Text + ")";
                        result.Text = (Math.Pow(x, (double)1 / value1)).ToString();
                        specialsign = "";
                    }
                    else
                         if (specialsign == "xmuy")
                    {
                        converse(result.Text, ref value1);
                        calcu.Text += result.Text;
                        result.Text = (Math.Pow(y, value1)).ToString();
                        specialsign = "";
                    }
                    else if (specialsign == "mod")
                    {
                        converse(result.Text, ref value1);
                        calcu.Text += result.Text;
                        result.Text = (a % value1).ToString();
                        specialsign = "";
                    }
                    else
                        calcu.Text = result.Text;
                    check = false;
                    break;
                default:
                    break;
            }
        }
        #endregion
        private void delete_Click(object sender, EventArgs e)
        {
            if (checksign == true)
            {
                int l = result.Text.Length;
                if (l > 1)
                {
                    string t = result.Text;
                    t = t.Remove(l - 1);
                    result.Text = t;
                }
                else if (l <= 1) result.Text = "0";
            }

        }



        bool can = true;
        #region phép căn bậc 2

        #endregion

        double x;
        //xcany
        private void button3_Click(object sender, EventArgs e)
        {
            specialsign = "xcany";
            converse(result.Text, ref x);
            if (sign == "") calcu.Text = "(" + x.ToString() + "√";
            else calcu.Text += "(" + x.ToString() + "can";
            result.Text = "0";
            check = false;
        }

        double gt(double n)
        {
            double t = 1;
            for (double i = 1; i <= n; i++)
                t *= i;
            return t;
        }
        //xmuy
        double y;

        private void doc_Click(object sender, EventArgs e)
        {
            //if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += ".";
            else
            {
                result.Text = "0.";
                check = true;
            }
        }
        void disablebut(bool can)
        { 
          
            devide.Enabled = can;
            multi.Enabled = can;
            add.Enabled = can;
        }

        double a;
        //mod
        private void modbut_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref a);
            calcu.Text += a.ToString() + "mod";
            check = false;
            specialsign = "mod";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (can == false)
            {
                can = true;
                result.Text = "0";
                calcu.Text = "";
                disablebut(can);
                checksign = true;
                sign = "";
                kq = 0;
                kqmul = 1;
                check = true;
                specialsign = "";
            }
            else
            {
                sign = "";
                specialsign = "";
                checksign = true;
                kq = 0;
                kqmul = 1;
                result.Text = "0";
                calcu.Text = "";
                check = true;
            }
        }

       
    }
}