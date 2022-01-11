
namespace IClicker
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.monster = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.DmgUp = new System.Windows.Forms.Label();
            this.DmgUpB = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.Label();
            this.CriUpB = new System.Windows.Forms.Button();
            this.CriUp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.데미지 = new System.Windows.Forms.Label();
            this.크리확률 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.TimeDelDown = new System.Windows.Forms.Label();
            this.DelDownB = new System.Windows.Forms.Button();
            this.재화습득시간 = new System.Windows.Forms.Label();
            this.SkillPanel = new System.Windows.Forms.Panel();
            this.재화습득량 = new System.Windows.Forms.Label();
            this.TimeGB = new System.Windows.Forms.Button();
            this.TimeGoldUp = new System.Windows.Forms.Label();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.timerSliding = new System.Windows.Forms.Timer(this.components);
            this.Gold = new System.Windows.Forms.Label();
            this.BossHealth = new System.Windows.Forms.Label();
            this.BossHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SkillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monster.Location = new System.Drawing.Point(63, 45);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(242, 38);
            this.monster.TabIndex = 0;
            this.monster.Text = "Lv. 1 레로레로리";
            this.monster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monster.Click += new System.EventHandler(this.monster_Click);
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(272, 8);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(155, 20);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DmgUp
            // 
            this.DmgUp.AutoSize = true;
            this.DmgUp.Location = new System.Drawing.Point(61, 15);
            this.DmgUp.Name = "DmgUp";
            this.DmgUp.Size = new System.Drawing.Size(69, 12);
            this.DmgUp.TabIndex = 2;
            this.DmgUp.Text = "공격력 증가";
            // 
            // DmgUpB
            // 
            this.DmgUpB.Location = new System.Drawing.Point(251, 10);
            this.DmgUpB.Name = "DmgUpB";
            this.DmgUpB.Size = new System.Drawing.Size(75, 23);
            this.DmgUpB.TabIndex = 3;
            this.DmgUpB.Text = "100";
            this.DmgUpB.UseVisualStyleBackColor = true;
            this.DmgUpB.Click += new System.EventHandler(this.button1_Click);
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.Location = new System.Drawing.Point(12, 9);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(20, 22);
            this.notice.TabIndex = 4;
            this.notice.Text = " ";
            // 
            // CriUpB
            // 
            this.CriUpB.Location = new System.Drawing.Point(251, 39);
            this.CriUpB.Name = "CriUpB";
            this.CriUpB.Size = new System.Drawing.Size(75, 23);
            this.CriUpB.TabIndex = 5;
            this.CriUpB.Text = "1000";
            this.CriUpB.UseVisualStyleBackColor = true;
            this.CriUpB.Click += new System.EventHandler(this.button2_Click);
            // 
            // CriUp
            // 
            this.CriUp.AutoSize = true;
            this.CriUp.Location = new System.Drawing.Point(61, 44);
            this.CriUp.Name = "CriUp";
            this.CriUp.Size = new System.Drawing.Size(97, 12);
            this.CriUp.TabIndex = 6;
            this.CriUp.Text = "치명타 확률 증가";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IClicker.Properties.Resources.MOB1;
            this.pictureBox1.Location = new System.Drawing.Point(69, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // 데미지
            // 
            this.데미지.AutoSize = true;
            this.데미지.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.데미지.Location = new System.Drawing.Point(332, 14);
            this.데미지.Name = "데미지";
            this.데미지.Size = new System.Drawing.Size(27, 19);
            this.데미지.TabIndex = 8;
            this.데미지.Text = "10";
            // 
            // 크리확률
            // 
            this.크리확률.AutoSize = true;
            this.크리확률.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.크리확률.Location = new System.Drawing.Point(332, 39);
            this.크리확률.Name = "크리확률";
            this.크리확률.Size = new System.Drawing.Size(36, 19);
            this.크리확률.TabIndex = 9;
            this.크리확률.Text = "0 %";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(370, 368);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 25);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "게임종료";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TimeDelDown
            // 
            this.TimeDelDown.AutoSize = true;
            this.TimeDelDown.Location = new System.Drawing.Point(61, 73);
            this.TimeDelDown.Name = "TimeDelDown";
            this.TimeDelDown.Size = new System.Drawing.Size(149, 12);
            this.TimeDelDown.TabIndex = 11;
            this.TimeDelDown.Text = "시간당 재화 습득시간 감소";
            // 
            // DelDownB
            // 
            this.DelDownB.Location = new System.Drawing.Point(251, 68);
            this.DelDownB.Name = "DelDownB";
            this.DelDownB.Size = new System.Drawing.Size(75, 23);
            this.DelDownB.TabIndex = 12;
            this.DelDownB.Text = "5000";
            this.DelDownB.UseVisualStyleBackColor = true;
            this.DelDownB.Click += new System.EventHandler(this.button3_Click);
            // 
            // 재화습득시간
            // 
            this.재화습득시간.AutoSize = true;
            this.재화습득시간.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.재화습득시간.Location = new System.Drawing.Point(332, 68);
            this.재화습득시간.Name = "재화습득시간";
            this.재화습득시간.Size = new System.Drawing.Size(72, 19);
            this.재화습득시간.TabIndex = 13;
            this.재화습득시간.Text = "3000 ms";
            // 
            // SkillPanel
            // 
            this.SkillPanel.BackColor = System.Drawing.Color.Transparent;
            this.SkillPanel.Controls.Add(this.재화습득량);
            this.SkillPanel.Controls.Add(this.TimeGB);
            this.SkillPanel.Controls.Add(this.TimeGoldUp);
            this.SkillPanel.Controls.Add(this.checkBoxHide);
            this.SkillPanel.Controls.Add(this.재화습득시간);
            this.SkillPanel.Controls.Add(this.CriUpB);
            this.SkillPanel.Controls.Add(this.DelDownB);
            this.SkillPanel.Controls.Add(this.DmgUp);
            this.SkillPanel.Controls.Add(this.TimeDelDown);
            this.SkillPanel.Controls.Add(this.DmgUpB);
            this.SkillPanel.Controls.Add(this.CriUp);
            this.SkillPanel.Controls.Add(this.크리확률);
            this.SkillPanel.Controls.Add(this.데미지);
            this.SkillPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SkillPanel.Location = new System.Drawing.Point(0, 310);
            this.SkillPanel.Name = "SkillPanel";
            this.SkillPanel.Size = new System.Drawing.Size(455, 152);
            this.SkillPanel.TabIndex = 0;
            // 
            // 재화습득량
            // 
            this.재화습득량.AutoSize = true;
            this.재화습득량.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.재화습득량.Location = new System.Drawing.Point(332, 97);
            this.재화습득량.Name = "재화습득량";
            this.재화습득량.Size = new System.Drawing.Size(45, 19);
            this.재화습득량.TabIndex = 16;
            this.재화습득량.Text = "10 G";
            // 
            // TimeGB
            // 
            this.TimeGB.Location = new System.Drawing.Point(251, 97);
            this.TimeGB.Name = "TimeGB";
            this.TimeGB.Size = new System.Drawing.Size(75, 23);
            this.TimeGB.TabIndex = 15;
            this.TimeGB.Text = "3000";
            this.TimeGB.UseVisualStyleBackColor = true;
            this.TimeGB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TimeGoldUp
            // 
            this.TimeGoldUp.AutoSize = true;
            this.TimeGoldUp.Location = new System.Drawing.Point(61, 102);
            this.TimeGoldUp.Name = "TimeGoldUp";
            this.TimeGoldUp.Size = new System.Drawing.Size(137, 12);
            this.TimeGoldUp.TabIndex = 14;
            this.TimeGoldUp.Text = "시간당 재화 습득량 증가";
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxHide.Location = new System.Drawing.Point(0, 124);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(455, 28);
            this.checkBoxHide.TabIndex = 1;
            this.checkBoxHide.Text = "스킬";
            this.checkBoxHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // timerSliding
            // 
            this.timerSliding.Interval = 10;
            this.timerSliding.Tick += new System.EventHandler(this.timerSliding_Tick);
            // 
            // Gold
            // 
            this.Gold.AutoSize = true;
            this.Gold.BackColor = System.Drawing.Color.Transparent;
            this.Gold.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gold.Location = new System.Drawing.Point(421, 9);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(21, 23);
            this.Gold.TabIndex = 11;
            this.Gold.Text = "G";
            // 
            // BossHealth
            // 
            this.BossHealth.AutoSize = true;
            this.BossHealth.BackColor = System.Drawing.Color.Transparent;
            this.BossHealth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossHealth.Location = new System.Drawing.Point(355, 59);
            this.BossHealth.Name = "BossHealth";
            this.BossHealth.Size = new System.Drawing.Size(72, 19);
            this.BossHealth.TabIndex = 12;
            this.BossHealth.Text = "1000000";
            this.BossHealth.Click += new System.EventHandler(this.BossHealth_Click);
            // 
            // BossHP
            // 
            this.BossHP.AutoSize = true;
            this.BossHP.BackColor = System.Drawing.Color.Transparent;
            this.BossHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossHP.Location = new System.Drawing.Point(305, 59);
            this.BossHP.Name = "BossHP";
            this.BossHP.Size = new System.Drawing.Size(54, 19);
            this.BossHP.TabIndex = 13;
            this.BossHP.Text = "HP : ";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 462);
            this.Controls.Add(this.BossHP);
            this.Controls.Add(this.BossHealth);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.SkillPanel);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Exit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "main";
            this.Text = "I-Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SkillPanel.ResumeLayout(false);
            this.SkillPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label monster;
        public System.Windows.Forms.Label money;
        public System.Windows.Forms.Label DmgUp;
        public System.Windows.Forms.Button DmgUpB;
        public System.Windows.Forms.Label notice;
        public System.Windows.Forms.Button CriUpB;
        public System.Windows.Forms.Label CriUp;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label 데미지;
        public System.Windows.Forms.Label 크리확률;
        public System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Label TimeDelDown;
        public System.Windows.Forms.Button DelDownB;
        public System.Windows.Forms.Label 재화습득시간;
        private System.Windows.Forms.Panel SkillPanel;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.Timer timerSliding;
        private System.Windows.Forms.Label Gold;
        public System.Windows.Forms.Label 재화습득량;
        public System.Windows.Forms.Button TimeGB;
        public System.Windows.Forms.Label TimeGoldUp;
        private System.Windows.Forms.Label BossHealth;
        private System.Windows.Forms.Label BossHP;
    }
}

