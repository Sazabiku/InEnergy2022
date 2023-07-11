using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ИнЭнерджи.project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] theoryPage = new string[10];
        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //Owner.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (radioButton1.Checked)
                {
                    Form4 form4 = new Form4();
                    form4.Owner = this;
                    form4.Show();
                    this.Close();
                } 
                else if (radioButton2.Checked)
                {
                    Form3 form3 = new Form3();
                    form3.Owner = this;
                    form3.Show();
                    this.Close();
                }
                else 
                    MessageBox.Show("Проверьте, выбрали ли вы один из вариантов ответа.");
            }
            catch
            {
                MessageBox.Show("Проверьте, выбрали ли вы один из вариантов ответа.");
            }*/
            
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*int CountOfVisibleForms = 0;
            for (int i = Application.OpenForms.Count; i == 0; i--)
            {
                if (Application.OpenForms[i-1].Visible)
                    CountOfVisibleForms += 1;
            }
                
            if (CountOfVisibleForms == 0)
                Owner.Show();*/
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form[] form = Parent.FindForm().MdiChildren;          
            foreach (Form fr in form)          
                fr.Close();
            
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*theoryPage[0] = "Актуальность работы. На сегодняшний день разработчиками и производителями автотранспорта в мире решается задача создания электрических транспортных средств, " +
                "с эксплуатационными характеристиками, приближенными к традиционным автомобилям с двигателем внутреннего сгорания (ДВС). Одним из перспективных направлений развития " +
                "электроэнергетического комплекса России является создание большегрузного и пассажирского транспорта, работающего на электротяге. Данный вид транспорта требует наличия энергоемкого " +
                "источника электрической энергии. В настоящее время в качестве тяговых источников тока для электромобилей зарекомендовали себя аккумуляторные батареи. Основными проблемами массового " +
                "использования электромобилей являются низкие эксплуатационные показатели, в том числе ресурс тяговых аккумуляторных батарей (ТАБ), существенная ограниченность автономного хода в сравнении " +
                "с автотранспортными средствами (АТС) на основе ДВС, высокая стоимость аккумуляторных батарей, ограниченное внедрение зарядной инфраструктуры, ухудшение эффективной работы при низких температурах " +
                "окружающей среды. От эффективности восполнения, хранения и использования электроэнергии на борту электромобиля (ЭМ) зависит большинство эксплуатационных показателей. К ним можно отнести: пробег, " +
                "ресурс ТАБ и экономические затраты на эксплуатацию. При этом от эффективности использования энергии на борту зависит возможность снижения дополнительной массы ТАБ, что в итоге приводит к улучшению " +
                "транспортной работы и эксплуатационных показателей в целом. При существующих недостатках возможна организация эффективной работы наиболее слабого звена – ТАБ таким образом, чтобы увеличить ресурс " +
                "и энергетическую эффективность электромобиля.";
            theoryPage[1] = "Стоимость тягового источника тока в современных электромобилях составляет около 40% от общей стоимости всего транспортного средства. В связи с этим рациональным способом эффективной " +
                "эксплуатации будет работа в номинальных режимах. Однако соблюдение номинальной работы аккумуляторной батареи не позволяет реализовывать рабочие режимы транспортного средства. Данное противоречие " +
                "может быть решено путем определения рациональных эксплуатационных характеристик ТАБ, при которых будет происходить сохранение ресурса.";
            */
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Inenergy_simulation/index.html");
            }
            catch
            {
                MessageBox.Show("Ошибка №12! \n Не найдены необходимые файлы для запуска модели потребления \n Проверьте, находятся ли необходимые файлы модели потребления в одной папке с данным приложением.");
            }
        }
    }

}
