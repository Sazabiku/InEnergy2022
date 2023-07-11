using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИнЭнерджи.project
{
    public partial class Form4 : Form
    {
        /*
        Kc - постоянная; емкостной коэфф(?)
        C0z - C0* – емкость батареи без нагрузки при 0 °С, А·с;
        Kt - температурный коэффициент;
        I - ток разряда в амперах;
        Iz - I* – текущий номинальный ток батареи, А;
        b - постоянная, определяемая параметрами аккумулятора, о.е.;
        ElT - θ – температура электролита в °С;
        Ci0 - C(I,θ) состояние емкости батареи
        Qe - заряд батареи, А·с; 
        Em0 - напряжение холостого хода при полном заряде, В;
        Ke - температурный коэффициент, В/°C;
        SOC - SOC – состояние заряда батареи, о.е.
        Em -  описывает внутреннюю электродвижущую силу (ЭДС) или напряжение холостого хода Em одного аккумулятора батареи. 
        Im -  ток главной ветви
        tay1 - постоянная времени главной ветви;
        Iavg - текущий средний ток разряда, А;
        DOC - глубина заряда батареи, о.е;
        Ciavg0 - (Может не использоваться)
        R10 - постоянная
        R1 - изменение сопротивления от глубины заряда, Ом;
        C1 - Емкость главной ветви
        R00 - сопротивление R0 при полностью зараженной батарее (SOC=1);
        A0 - постоянная, определяемая параметрами аккумулятора.
        R0 - Сопротивление на клеммах одной ячейки аккумуляторной батареи, Ом
        R20 - сопротивление в нормальных условиях, Ом;
        A21 - постоянные, о.е.;
        A22 - постоянные, о.е.;
        R2 - Сопротивление R2
        VR1 - ??? напряжение на первом резисторе
        Ps - Потеря мощности Ps это мощность тепловых потерь, с помощью которой можно рассчитать нагрев ТАБ.
        Vpn - напряжение на паразитной ветви, В;
        Gp0 - постоянная, определяемая параметрами аккумулятора, с;
        Vp0 - постоянная, В; начальное напряжение на паразитной ветви (?)
        tayp - постоянная времени паразитной ветви, с;
        Ap - постоянная, о.е.;
        ElTF - температура замерзания электролита, °C. (тета)
        Ip - Величина тока разряда в паразитной ветви, А
        Qe_init – начальная величина заряда
        tay - τ – переменная времени интегрирования
        t –время моделирования
         */
        double Kc,C0z,Kt,I,Iz,b,ElT,Ci0,Qe,Em0,Ke,SOC,Em,Im,tay1,Iavg,DOC,Ciavg0,R10,R1,C1,R00,A0,R0,R20,A21,A22,R2,VR1,Ps,Vpn,Gp0,Vp0,tayp,Ap,ElTF,Ip,Qe_init,tay,t;

        

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar11.Value);
        }

        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(trackBar12.Value);
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            textBox11.Text = Convert.ToString(trackBar10.Value);
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            textBox33.Text = Convert.ToString(trackBar9.Value);
        }

        /*private void trackBar8_Scroll(object sender, EventArgs e)
        {
            //textBox9.Text = Convert.ToString(trackBar8.Value);
        }*/

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(trackBar7.Value);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            textBox20.Text = Convert.ToString(trackBar6.Value);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(trackBar5.Value);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox10.Text = Convert.ToString(trackBar4.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(trackBar2.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private static double Simpson(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum1 = 0d;
            var sum2 = 0d;
            for (var k = 1; k <= n; k++)
            {
                var xk = a + k * h;
                if (k <= n - 1)
                {
                    sum1 += f(xk);
                }

                var xk_1 = a + (k - 1) * h;
                sum2 += f((xk + xk_1) / 2);
            }

            var result = h / 3d * (1d / 2d * f(a) + sum1 + 2 * sum2 + 1d / 2d * f(b));
            return result;
        }

        private static double Simpson2(Func<double, double> f, double a, double b, int n)
        {
            double x, h, s;          

            h = (b - a) / n;
            s = 0; x = a + h;
            while (x < b)
            {
                s = s + 4 * f(x);
                x = x + h;
                s = s + 2 * f(x);
                x = x + h;
            }
            s = h / 3 * (s + f(a) - f(b));
            return s;
        }


        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form[] form = Parent.FindForm().MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Qe_init = Convert.ToDouble(textBox5.Text);
                //tay = Convert.ToDouble(textBox2.Text);

                double f(double x) => (-1)*Im*x;
                for (int i = 1; i < 61; i++)
                {
                    //var result = Simpson(f, 0, i, 1000);
                    var result = Simpson2(f, 0, i, 1000);
                    chart1.Series["Qe(t)"].Points.AddXY(i, Qe_init + result);
                }
                
            }
            catch
            {
                MessageBox.Show("Ошибка №12! \n (Qe_init, tay = Qe(t)) \n Проверьте, все ли значения введены.");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try//сделать через цикл, поставить проверку на каждое найденное значение(если != null, то можно не считать и идти дальше(экономия времени)). Займет время, но вычислит всёБо
            {
                /*
                Kc = 0; C0z = 0; Kt = 0; I = 0; Iz = 0; b = 0; ElT = 0; Ci0 = 0; 
                Qe = 0; Em0 = 0; Ke = 0; SOC = 0; Em = 0; Im = 0; tay1 = 0; Iavg = 0; 
                DOC = 0; Ciavg0 = 0; R10 = 0; R1 = 0; C1 = 0; R00 = 0; A0 = 0; 
                R0 = 0; R20 = 0; A21 = 0; A22 = 0; R2 = 0; VR1 = 0; Ps = 0;
                Vpn = 0; Gp0 = 0; Vp0 = 0; tayp = 0; Ap = 0; ElTF = 0; Ip = 0;
                */

                Kc = 0.55; C0z = 0; Kt = 0.5; I = 0; Iz = 0; b = 0.5; ElT = 0; Ci0 = 0;
                Qe = 0; Em0 = 0; Ke = 0.35; SOC = 0; Em = 0; Im = 0; tay1 = 0.003; Iavg = 0;
                DOC = 0; Ciavg0 = 0; R10 = 500; R1 = 0; C1 = 0; R00 = 500; A0 = 0.5;
                R0 = 0; R20 = 500; A21 = 0.33; A22 = 0.12; R2 = 0; VR1 = 0; Ps = 0;
                Vpn = 0; Gp0 = Math.Pow(10,-12); Vp0 = 3.7; tayp = 0.002; Ap = 0.5; ElTF = -40; Ip = 0;
                tay = 0; t = 0; Qe_init = 0;

                //Kc = Convert.ToDouble(textBox5.Text); //const
                C0z = Convert.ToDouble(textBox7.Text);
                //C0z = Convert.ToDouble(domainUpDown7.Text);
                //Kt = Convert.ToDouble(textBox6.Text); //const
                I = Convert.ToDouble(textBox10.Text);
                Iz = Convert.ToDouble(textBox8.Text);
                //b = Convert.ToDouble(textBox9.Text); //const
                ElT = Convert.ToDouble(textBox3.Text);
                //I = Convert.ToDouble(domainUpDown4.Text);
                //Iz = Convert.ToDouble(domainUpDown5.Text);
                //b = Convert.ToDouble(domainUpDown8.Text); //const
                //ElT = Convert.ToDouble(domainUpDown2.Text);
                Ci0 = Csolver(I, ElT);
                //textBox25.Text = Convert.ToString(Ci0);
                textBox25.Text = Convert.ToString(Math.Round(Ci0, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №1! \n (Kc, C0z, Kt, I, Iz, b, ElT = Ci0) \n Проверьте, все ли значения введены.");
            }

            try
            {
                Qe = Convert.ToDouble(textBox4.Text);
                //Em0 = Convert.ToDouble(textBox7.Text);
                //Qe = Convert.ToDouble(domainUpDown3.Text);
                //Em0 = Convert.ToDouble(domainUpDown1.Text);
                //Ke = Convert.ToDouble(textBox6.Text); //const
                SOC = 1 - (Qe/Ci0);
                //textBox26.Text = Convert.ToString(SOC);
                Ci0 = Csolver(I, ElT);
                textBox26.Text = Convert.ToString(Math.Round(SOC, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №2! \n (Qe, Em0, Ke = SOC) \n Проверьте, все ли значения введены.");
            }

            try
            {
                
                Em0 = Convert.ToDouble(textBox1.Text);
                //Em0 = Convert.ToDouble(domainUpDown1.Text);
                //Ke = Convert.ToDouble(textBox2.Text);
                Em = Em0 - (Ke*(273 + ElT)*(1-SOC));
                //textBox30.Text = Convert.ToString(Em);
                textBox30.Text = Convert.ToString(Math.Round(Em, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №3! \n (Em0, Ke, ElT, SOC = Em) \n Проверьте, все ли значения введены.");
            }

            try
            {

                Im = Convert.ToDouble(textBox20.Text);
                //Im = Convert.ToDouble(domainUpDown6.Text);
                //tay1 = Convert.ToDouble(textBox19.Text); //const
                //Ciavg0 = Csolver(Im, ElT);
                Iavg = Im / (tay1 + 1);
                //textBox22.Text = Convert.ToString(Iavg);
                textBox22.Text = Convert.ToString(Math.Round(Iavg, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №4! \n (Im, tay1 = Iavg) \n Проверьте, все ли значения введены.");
            }

            try
            {

                //Qe = Convert.ToDouble(domainUpDown3.Text);
                Ciavg0 = Csolver(Iavg, ElT);
                DOC = 1 - (Qe / Ciavg0);
                //textBox21.Text = Convert.ToString(DOC);
                textBox21.Text = Convert.ToString(Math.Round(DOC, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №5 \n (Ciavg0, Qe = DOC)! \n Проверьте, все ли значения введены.");
            }

            try
            {
                //R10 = Convert.ToDouble(textBox17.Text); //const
                R1 = (-1) * R10 * Math.Log10(DOC);
                //textBox29.Text = Convert.ToString(R1);
                textBox29.Text = Convert.ToString(Math.Round(R1, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №6! \n (R10, DOC = R1) \n Проверьте, все ли значения введены.");
            }

            try
            {
                C1 = tay1 / R1;
                //textBox23.Text = Convert.ToString(C1);
                textBox23.Text = Convert.ToString(Math.Round(C1, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №7! \n (tay1, R1 = C1) \n Проверьте, все ли значения введены.");
            }

            try
            {
                //R00 = Convert.ToDouble(textBox18.Text); //const
                //A0 = Convert.ToDouble(textBox13.Text); //const
                R0 = R00 * (1 + (A0 * (1 - SOC)));
                //textBox28.Text = Convert.ToString(R0);
                textBox28.Text = Convert.ToString(Math.Round(R0, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №8 \n (R00, A0 = R0)! \n Проверьте, все ли значения введены.");
            }

            try
            {
                //R20 = Convert.ToDouble(textBox14.Text); //const
                //A21 = Convert.ToDouble(textBox15.Text); //const
                //A22 = Convert.ToDouble(textBox16.Text); //const
                R2 = R20 * (Math.Exp(A21 * (1 - SOC)) / (1 + Math.Exp(A22 * (Im / Iz))));
                //textBox27.Text = Convert.ToString(R2);
                textBox27.Text = Convert.ToString(Math.Round(R2, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №9! \n (R20, A21, A22 = R2) \n Проверьте, все ли значения введены.");
            }

            try
            {
                VR1 = Convert.ToDouble(textBox11.Text);
                //VR1 = Convert.ToDouble(domainUpDown10.Text);
                Ps = (Math.Pow(VR1, 2) / R1) + (Math.Pow(I, 2) * R0) + (Math.Pow(I, 2) * R2);
                //textBox31.Text = Convert.ToString(Ps);
                textBox31.Text = Convert.ToString(Math.Round(Ps, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №10! \n (VR1, R1, I, R0, R2 = Ps) \n Проверьте, все ли значения введены.");
            }

            try
            {
                Vpn = Convert.ToDouble(textBox33.Text);
                //Vpn = Convert.ToDouble(domainUpDown9.Text);
                //Gp0 = Convert.ToDouble(textBox34.Text); //const
                //Vp0 = Convert.ToDouble(textBox35.Text); //const
                //tayp = Convert.ToDouble(textBox36.Text); //const
                //Ap = Convert.ToDouble(textBox12.Text); //const
                //ElTF = Convert.ToDouble(textBox32.Text); //const
                Ip = Vpn * Gp0 * Math.Exp((Vpn/((tayp+1)/Vp0))+(Ap*(1-(ElT/ElTF))));
                textBox24.Text = Convert.ToString(Ip);
                //textBox24.Text = Convert.ToString(Math.Round(Ip, 5));
            }
            catch
            {
                MessageBox.Show("Ошибка №11! \n (Vpn, Gp0, Vp0, tayp, Ap, ElTF = Ip) \n Проверьте, все ли значения введены.");
            }
        }

        private double Csolver(double _I, double _ElT)
        {
            double C;
            C = (Kc * C0z * Kt) / (1 + ((Kc - 1) * Math.Pow(_I / Iz,b))) ;
            return C;
        }
    }
}
