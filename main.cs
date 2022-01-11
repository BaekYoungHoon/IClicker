using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace IClicker
{
    public partial class main : Form

    {
        String Mob = "MOB.png";
        String Mob_hit = "MOB_hit.png";
        System.Timers.Timer aTimer = new System.Timers.Timer();
        int damage1 = 10;                                                    //기본 데미지
        int critical = 0;                                                    //크리티컬 확률
        int cri_price = 1000;                                                //크리티컬 가격
        int time_price = 5000;
        int timeG_price = 3000;
        int time_money = 10;
        static int time_up = 3000;
        const int MAX_SLIDING_WIDTH = 150;
        const int MIN_SLIDING_WIDTH = 35;
        const int STEP_SLIDING = 10;
        int _posSliding = 100;
        Stopwatch stopwatch = new Stopwatch(); //객체 선언
        public main()
        {
            InitializeComponent();
            aTimer.Interval = time_up;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
            
            stopwatch.Start(); // 시간측정 시작

        }
        

        public String money_Up(Label a)                                       // 몬스터를 클릭시 데미지 적용 및 돈증가 함수
        {
            String b = a.Text;
            int price;

            Random rand = new Random();

            int num = rand.Next(0, 100);
            if (critical > num)
            {
                price = Convert.ToInt32(b);
                int i = rand.Next(damage1 / 2, damage1);
                price = price + damage1 + i;                                   //지역 변수라서 함수 바깥에서는 사용되지 않음
                BossHealth.Text = Convert.ToString(Convert.ToInt32(BossHealth.Text) - (damage1 + i));
                notice.Text = "크리티컬!" + "(기본공격 + " + Convert.ToString(i) + ")";
                return a.Text = Convert.ToString(price);
            }
            else
            {
                notice.Text = "기본공격";
                price = Convert.ToInt32(b);
                price += damage1;                                               //지역 변수라서 함수 바깥에서는 사용되지 않음
                BossHealth.Text = Convert.ToString(Convert.ToInt32(BossHealth.Text) - damage1);
                return a.Text = Convert.ToString(price);
            }
        }

        public String TimeDUp()
        {
            int price = Convert.ToInt32(money.Text) - Convert.ToInt32(DelDownB.Text);
            if (time_price > Convert.ToInt32(money.Text))
            {
                return notice.Text = "돈이 " + Convert.ToString(-price) + "G 부족합니다.";
            }
            else
                if (time_up <= 500)
            {
                DelDownB.Enabled = false;
                notice.Text = "더 이상 레벨 업 할 수 없습니다.";
                notice.Text = "업적 달성! [토끼]";
                return DelDownB.Text = "Max";
            }
            else
            {
                int a = Convert.ToInt32(money.Text) - time_price;
                String b = Convert.ToString(a);
                time_price += 5000;
                DelDownB.Text = Convert.ToString(time_price);
                time_up -= 500;
                aTimer.Interval = time_up;
                재화습득시간.Text = Convert.ToString(time_up) + " ms";
                notice.Text = "자동재화 습득 간격 감소!";
                return money.Text = b;
            }
        }
        public String TimeGUp()
        {
            int price = Convert.ToInt32(money.Text) - Convert.ToInt32(TimeGB.Text);
            if (timeG_price > Convert.ToInt32(money.Text))
            {
                return notice.Text = "돈이 " + Convert.ToString(-price) + "G 부족합니다.";
            }
            else
                if (time_money == 1000)
            {
                TimeGB.Enabled = false;
                notice.Text = "더 이상 레벨 업 할 수 없습니다.";
                notice.Text = "업적 달성! [연금 마련]";
                return TimeGB.Text = "Max";
            }
            else
            {
                int a = Convert.ToInt32(money.Text) - timeG_price;
                String b = Convert.ToString(a);
                timeG_price += 3000;
                TimeGB.Text = Convert.ToString(timeG_price);
                time_money += 5;
                재화습득량.Text = Convert.ToString(time_money) + " G";
                notice.Text = "자동재화 습득량 증가!";
                return money.Text = b;
            }


        }
        public String criticalUp()
        {
            int price = Convert.ToInt32(money.Text) - Convert.ToInt32(CriUpB.Text);
            if (cri_price > Convert.ToInt32(money.Text))
            {
                return notice.Text = "돈이 " + Convert.ToString(-price) + "G 부족합니다.";
            }
            else
            {
                if (critical >= 100)
                {
                    CriUpB.Enabled = false;
                    notice.Text = "더 이상 레벨 업 할 수 없습니다.";
                    notice.Text = "업적 달성! [매의 눈]";
                    return CriUpB.Text = "Max";
                }
                else
                {
                    int a = Convert.ToInt32(money.Text) - cri_price;
                    String b = Convert.ToString(a);
                    cri_price += cri_price;
                    CriUpB.Text = Convert.ToString(cri_price);
                    critical += 10;
                    크리확률.Text = Convert.ToString(critical) + " %";
                    notice.Text = "치명타 확률 증가!";
                    return money.Text = b;
                }
            }

        }
        int n = 100;
        public String damage(Button a)                                      // 버튼을 눌렀을 시 공격력 및 가격 증가 함수
        {
            int mn;
            String mT = money.Text;                                         // 현재 가지고 있는 돈을 변수에 저장
            int price;
            String pr = a.Text;                                             // 현재 버튼이 가지고 있는 값을 변수에 저장
            mn = Convert.ToInt32(mT);                                       // String 타입의 변수를 Int 타입으로 형 변환
            price = Convert.ToInt32(pr);                                    // String 타입의 변수를 Int 타입으로 형 변환


            if (mn < price)                                                 // 돈이 부족 할 때 실행되는 조건
            {
                return a.Text;
            }
            else                                                               // 돈이 부족하지 않을 때 실행되는 조건
            {
                String price_damage = a.Text;
                int price_Temp = Convert.ToInt32(price_damage);
                price_Temp += n;
                n += 100;
                damage1 += 20;                                               //데미지 증가율
                데미지.Text = Convert.ToString(damage1);
                notice.Text = "공격력 증가 성공!";
                return a.Text = Convert.ToString(price_Temp);
            }

        }

        private void monster_Click(object sender, EventArgs e)
        {
            //money_Up(money);                                                //몬스터 클릭시 Label money텍스트 변경
            

            if (Convert.ToInt32(money.Text) == 0)
            {
                notice.Text = "업적 달성! [빈털터리]";
            }
            if (Convert.ToInt32(money.Text) == 100)
            {
                notice.Text = "업적 달성! [백점만점]";
            }
            if (Convert.ToInt32(money.Text) == 1000)
            {
                notice.Text = "업적 달성! [백투백]";
            }
            if (Convert.ToInt32(money.Text) == 10000)
            {
                notice.Text = "업적 달성! [진짜 만점?!]";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)              //버튼 클릭시  이벤트
        {

            String mN = money.Text;                                         //버튼을 누를 때 생성되는 변수에 돈을 저장
            String damage_Up = DmgUpB.Text;                                //버튼을 누를 때 생성되는 변수에 현재 공격력 증가 가격을 저장
            int price = Convert.ToInt32(mN) - Convert.ToInt32(damage_Up);   //돈 - 공격력 증가 가격
            if (price >= 0)                                                  //남는돈이 0보다 작지 않으면 이벤트 실행
            {
                damage((Button)sender);
                money.Text = Convert.ToString(price);

            }
            else                                                            //남는 돈이 0보다 작을경우 돈이부족하다고 알림
            {
                notice.Text = "돈이 " + Convert.ToString(-price) + "G 부족합니다.";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            criticalUp();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TimeDUp();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\a0104\source\repos\IClicker1031\Resources\" + Mob_hit);
            money_Up(money);
            if (Convert.ToInt32(BossHealth.Text) <= 0)
            {
                money.Text = Convert.ToString(Convert.ToInt32(money.Text) + 100000);
                //stopwatch.Stop();
                var Playtime = Convert.ToString(stopwatch.ElapsedMilliseconds / 1000) + " 초";
                BossHealth.Text = "0";
                DialogResult dialogResult = MessageBox.Show("클리어 하셨습니다. 이어서 진행하시겠습니까??\n 플레이타임 : " + Playtime, "클리어!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    monster.Text = "LV. 2 뜨뜨뜨뜨";
                    Mob = "MOB2.png";
                    Mob_hit = "MOB2_hit.png";
                    BossHealth.Text = "1000000";
                }
                else Application.Exit();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\a0104\source\repos\IClicker1031\Resources\" + Mob);
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                int mtime_money = Convert.ToInt32(money.Text);
                mtime_money += time_money;
                money.Text = Convert.ToString(mtime_money);
            }));

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked == true)
            {

                checkBoxHide.Text = "스킬";

            }
            else
            {

                checkBoxHide.Text = "▽";
            }

            //타이머 시작
            timerSliding.Start();
        }

        private void timerSliding_Tick(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding.Stop();
            }

            SkillPanel.Height = _posSliding;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TimeGUp();
        }

        private void BossHealth_Click(object sender, EventArgs e)
        {

        }
    }
}

