using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp2
{
    partial class Animal
    {
        //comment
        #region Properties
        protected TabPage SelectedTab;
        #endregion


        #region Constructor
        /// <summary>
        /// Meтод для отрисовки графического интерфейса "животного".
        /// </summary>
        public void DrowGUI(TabPage SelectedTab, Delegates Delegates)
        {
            this.SelectedTab = SelectedTab;
            SelectedTab.Paint += tabPage_Paint;
            DrowControls();

            
            Delegates.ShowNewData += RedrowBars;

            RedrowBars();
        }
        #endregion


        #region Methods
        private void DrowControls() 
        {
            BackgroundPicSet();
            PicBoxDrow();
            HPBarDrow();
            SPBarDrow();
            AnimalTypeLabelDrow();
            HPLabelDrow();
            SPLabelDrow();
            HPValueLabelDrow();
            SPValueLabelDrow();
            LvlLabelDrow();
            LvlValueLabelDrow();
            ProfitLabelDrow();
            ProfitValueLabelDrow();
            NameLabelDrow();
            AgeLabelDrow();
            GenderLabelDrow();
            CostLvlupLabelDrow();
            CostCuringLabelDrow();
            CostFeedingLabelDrow();
        }

        private int Percent(int Value, int MaxValue)
        {
            double percent;
            percent = ((Value * 100) / MaxValue);

            return (int)Math.Ceiling(percent);
        }

        private void RedrowBars()
        {
            HPUpdate();
            SPUpdate();
        }

        #region DrowMethods

        #region Background
        protected abstract void BackgroundPicSet();
        #endregion

        #region PicBox    
        private void PicBoxDrow()
        {
            PictureBox PicBox = new PictureBox();
            PicBox.Parent = SelectedTab;
            PicBox.Location = new Point(5, 40);
            PicBox.Size = new Size(430, 220);            
            PicBox.BackgroundImageLayout = ImageLayout.Stretch;
            SetPic(PicBox);
        }

        protected virtual void SetPic(PictureBox PicBox)
        {
            PicBox.BackgroundImage = Properties.Resources.AnimalPic;
        }
        #endregion

        #region AnimaTypelLabel     
        void AnimalTypeLabelDrow()
        {
            Label AnimalTypeLabel = new Label();
            AnimalTypeLabel.Parent = SelectedTab;
            #region CustomFontStyle
            FontStyle CustomFontStyle = FontStyle.Regular;
            CustomFontStyle |= FontStyle.Bold;
            CustomFontStyle |= FontStyle.Italic;
            CustomFontStyle |= FontStyle.Underline;
            #endregion
            AnimalTypeLabel.Font = new Font("MV Boli", 20.25f, CustomFontStyle);
            AnimalTypeLabel.BackColor = Color.Transparent;
            AnimalTypeLabel.AutoSize = false;
            AnimalTypeLabel.TextAlign = ContentAlignment.MiddleCenter;

            AnimalTypeLabelSettings(AnimalTypeLabel);
            //DelObj(AnimalTypeLabel);
        }
        protected abstract void AnimalTypeLabelSettings(Label AnimalTypeLabel);
        #endregion

        #region Bars

        #region HPBarGroup

        #region HPBar
        ProgressBar HPBar;
        private void HPBarDrow()
        {
            HPBar = new ProgressBar();
            HPBar.Parent = SelectedTab;
            HPBar.Location = new Point(5, 285);
            HPBar.Size = new Size(430, 25);
            HPBar.ForeColor = Color.DarkGreen;
            HPBar.Style = ProgressBarStyle.Continuous;

            HPBar.Maximum = 100;            
        }
        #endregion

        #region HPLabel
        private void HPLabelDrow()
        {
            Label HPLabel = new Label();
            HPLabel.Parent = SelectedTab;
            HPLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            HPLabel.BackColor = Color.Transparent;
            HPLabel.AutoSize = false;
            HPLabel.Size = new Size(39, 15);
            HPLabel.TextAlign = ContentAlignment.MiddleCenter;
            HPLabel.BringToFront();
            HPLabel.Text = $"Helth:";
            HPLabel.Location = new Point(181, 265);
        }
        #endregion

        #region HPValueLabel
        Label HPValueLabel;
        private void HPValueLabelDrow()
        {
            HPValueLabel = new Label();
            HPValueLabel.Parent = SelectedTab;
            HPValueLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            HPValueLabel.BackColor = Color.Transparent;
            HPValueLabel.AutoSize = false;
            HPValueLabel.Size = new Size(39, 15);
            HPValueLabel.TextAlign = ContentAlignment.MiddleRight;
            HPValueLabel.BringToFront();            
            HPValueLabel.Location = new Point(220, 265);
        }
        #endregion

        #region HPUpdate
        public void HPUpdate()
        {
            HPBar.Invoke(new Action(() => 
            HPBar.Value = Percent(Helth, MaxHelth)));
            ChangeBarColor(HPBar);

            HPValueLabel.Invoke(new Action(() => 
            HPValueLabel.Text = $"{Percent(Helth, MaxHelth)}%"));
        }
        #endregion

        #endregion

        #region SPBarGroup

        #region SPBar
        ProgressBar SPBar;
        private void SPBarDrow()
        {
            SPBar = new ProgressBar();
            SPBar.Parent = SelectedTab;
            SPBar.Location = new Point(5, 335);
            SPBar.Size = new Size(430, 25);
            SPBar.ForeColor = Color.DarkGreen;
            SPBar.Style = ProgressBarStyle.Continuous;

            SPBar.Maximum = 100;
        }
        #endregion
               
        #region SPLabel
        private void SPLabelDrow()
        {
            Label SPLabel = new Label();
            SPLabel.Parent = SelectedTab;
            SPLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            SPLabel.BackColor = Color.Transparent;
            SPLabel.AutoSize = false;
            SPLabel.Size = new Size(46, 15);
            SPLabel.TextAlign = ContentAlignment.MiddleCenter;
            SPLabel.BringToFront();
            SPLabel.Text = $"Satiety:";
            SPLabel.Location = new Point(177, 315);
        }
        #endregion

        #region SPValueLabel
        Label SPValueLabel;
        private void SPValueLabelDrow()
        {
            SPValueLabel = new Label();
            SPValueLabel.Parent = SelectedTab;
            SPValueLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            SPValueLabel.BackColor = Color.Transparent;
            SPValueLabel.AutoSize = false;
            SPValueLabel.Size = new Size(39, 15);
            SPValueLabel.TextAlign = ContentAlignment.MiddleRight;
            SPValueLabel.BringToFront();            
            SPValueLabel.Location = new Point(223, 315);
        }
        #endregion

        #region SPUpdate
        public void SPUpdate()
        {
            SPBar.Invoke(new Action(() =>
            SPBar.Value = Percent(Satiety, MaxSatiety)));
            ChangeBarColor(SPBar);

            SPValueLabel.Invoke(new Action(() =>
            SPValueLabel.Text = $"{Percent(Satiety, MaxSatiety)}%"));
        }
        #endregion

        #endregion

        #region ChangeBarColor
        void ChangeBarColor(ProgressBar PBar)
        {
            switch (PBar.Value)
            {
                case int n when n <= 10:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.DarkRed));
                    break;

                case int n when n <= 20:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.Red));
                    break;

                case int n when n <= 30:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.OrangeRed));
                    break;

                case int n when n <= 40:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.DarkOrange));
                    break;

                case int n when n <= 55:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.Gold));
                    break;

                case int n when n <= 70:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.ForestGreen));
                    break;

                case int n when n <= 85:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.Green));
                    break;

                default:
                    PBar.Invoke(new Action(() =>
                    PBar.ForeColor = Color.DarkGreen));
                    break;
            }
        }
        #endregion

        #endregion

        #region LvlLabel
        private void LvlLabelDrow()
        {
            Label LvlLabel = new Label();
            LvlLabel.Parent = SelectedTab;
            #region CustomFontStyle
            FontStyle CustomFontStyle = FontStyle.Regular;
            CustomFontStyle |= FontStyle.Bold;
            CustomFontStyle |= FontStyle.Italic;
            #endregion
            LvlLabel.Font = new Font("MV Boli", 18f, CustomFontStyle);
            LvlLabel.BackColor = Color.Transparent;
            LvlLabel.AutoSize = false;
            LvlLabel.Size = new Size(71, 31);
            LvlLabel.TextAlign = ContentAlignment.MiddleCenter;
            LvlLabel.Text = $"LVL:";
            LvlLabel.Location = new Point(510, 8);
        }
        #endregion

        #region LvlValueLabel
        Label LvlValueLabel;
        private void LvlValueLabelDrow()
        {
            LvlValueLabel = new Label();
            LvlValueLabel.Parent = SelectedTab;
            #region CustomFontStyle
            FontStyle CustomFontStyle = FontStyle.Regular;
            CustomFontStyle |= FontStyle.Bold;
            CustomFontStyle |= FontStyle.Italic;
            #endregion
            LvlValueLabel.Font = new Font("MV Boli", 18f, CustomFontStyle);
            LvlValueLabel.BackColor = Color.Transparent;
            LvlValueLabel.AutoSize = false;
            LvlValueLabel.Size = new Size(82, 31);
            LvlValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            LvlValueLabel.Text = $"{Lvl}";
            LvlValueLabel.Location = new Point(580, 8);
        }

        public void LvlValueLabelUpdate()
        {
            LvlValueLabel.Invoke(new Action(() =>
            LvlValueLabel.Text = $"{Lvl}"));
        }
        #endregion

        #region ProfitLabel
        private void ProfitLabelDrow()
        {
            Label ProfitLabel = new Label();
            ProfitLabel.Parent = SelectedTab;
            ProfitLabel.Font = new Font("Microsoft Sans Serif", 12.00f, FontStyle.Regular);
            ProfitLabel.BackColor = Color.Transparent;
            ProfitLabel.AutoSize = false;
            ProfitLabel.Size = new Size(71, 31);
            ProfitLabel.TextAlign = ContentAlignment.MiddleCenter;
            ProfitLabel.Text = $"PROFIT/second:";
            ProfitLabel.Location = new Point(510, 60);
        }
        #endregion

        #region ProfitValueLabel
        Label ProfitValueLabel;
        private void ProfitValueLabelDrow()
        {
            ProfitValueLabel = new Label();
            ProfitValueLabel.Parent = SelectedTab;
            #region CustomFontStyle
            FontStyle CustomFontStyle = FontStyle.Regular;
            CustomFontStyle |= FontStyle.Bold;
            CustomFontStyle |= FontStyle.Italic;
            #endregion
            ProfitValueLabel.Font = new Font("MV Boli", 18f, CustomFontStyle);
            ProfitValueLabel.BackColor = Color.Transparent;
            ProfitValueLabel.AutoSize = false;
            ProfitValueLabel.Size = new Size(82, 31);
            ProfitValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            ProfitValueLabel.Text = $"{Zoo.ConvertMoney(1234)}";
            ProfitValueLabel.Location = new Point(580, 60);
        }

        public void ProfitValueLabelUpdate()
        {
            LvlValueLabel.Invoke(new Action(() =>
            LvlValueLabel.Text = $"{Lvl}"));
        }
        #endregion

        #region NameLabel
        private void NameLabelDrow()
        {
            Label NameLabel = new Label();
            NameLabel.Parent = SelectedTab;
            NameLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            NameLabel.BackColor = Color.Transparent;
            NameLabel.AutoSize = false;
            NameLabel.Size = new Size(170, 15);
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            NameLabel.Text = $"Name: {Name}";
            NameLabel.Location = new Point(20, 370);
        }
        #endregion

        #region AgeLabel
        private void AgeLabelDrow()
        {
            Label AgeLabel = new Label();
            AgeLabel.Parent = SelectedTab;
            AgeLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            AgeLabel.BackColor = Color.Transparent;
            AgeLabel.AutoSize = false;
            AgeLabel.Size = new Size(48, 15);
            AgeLabel.TextAlign = ContentAlignment.MiddleCenter;
            AgeLabel.Text = $"Age: {Age}";
            AgeLabel.Location = new Point(196, 370);
        }
        #endregion

        #region GenderLabel
        private void GenderLabelDrow()
        {
            #region GenderValue
            string GenderValue()
            {
                if (Gender == Genders.Male)
                    return "Male";
                else
                    return "Female";
            }
            #endregion 
            Label GenderLabel = new Label();
            GenderLabel.Parent = SelectedTab;
            GenderLabel.Font = new Font("Microsoft Sans Serif", 9.00f, FontStyle.Regular);
            GenderLabel.BackColor = Color.Transparent;
            GenderLabel.AutoSize = false;
            GenderLabel.Size = new Size(64, 15);
            GenderLabel.TextAlign = ContentAlignment.MiddleLeft;
            GenderLabel.Text = $"Gender: {GenderValue()}";
            GenderLabel.Location = new Point(355, 370);
        }
        #endregion

        #region CostLvlupLabel
        Label CostLvlupLabel;
        private void CostLvlupLabelDrow()
        {
            CostLvlupLabel = new Label();
            CostLvlupLabel.Parent = SelectedTab;
            CostLvlupLabel.Font = new Font("Arial", 9.75f, FontStyle.Bold);
            CostLvlupLabel.BackColor = Color.Transparent;
            CostLvlupLabel.AutoSize = false;
            CostLvlupLabel.Location = new Point(85, 405);
            CostLvlupLabel.Size = new Size(60, 16);
            CostLvlupLabel.TextAlign = ContentAlignment.MiddleCenter;
            CostLvlupLabelUpdate();
        }

        private void CostLvlupLabelUpdate()
        {
            CostLvlupLabel.Text = Zoo.ConvertMoney(LvlupPrice);
        }
        #endregion

        #region CostCuringLabel
        private void CostCuringLabelDrow()
        {
            Label CostCuringLabel = new Label();
            CostCuringLabel.Parent = SelectedTab;
            CostCuringLabel.Font = new Font("Arial", 9.75f, FontStyle.Bold);
            CostCuringLabel.BackColor = Color.Transparent;
            CostCuringLabel.AutoSize = false;
            CostCuringLabel.Location = new Point(190, 405);
            CostCuringLabel.Size = new Size(60, 16);
            CostCuringLabel.TextAlign = ContentAlignment.MiddleCenter;
            CostCuringLabelUpdate();
        }

        private void CostCuringLabelUpdate()
        {
            CostLvlupLabel.Text = Zoo.ConvertMoney(LvlupPrice);
        }
        #endregion

        #region CostFeedingLabel
        private void CostFeedingLabelDrow()
        {
            Label CostFeedingLabel = new Label();
            CostFeedingLabel.Parent = SelectedTab;
            CostFeedingLabel.Font = new Font("Arial", 9.75f, FontStyle.Bold);
            CostFeedingLabel.BackColor = Color.Transparent;
            CostFeedingLabel.AutoSize = false;
            CostFeedingLabel.Location = new Point(295, 405);
            CostFeedingLabel.Size = new Size(60, 16);
            CostFeedingLabel.TextAlign = ContentAlignment.MiddleCenter;
            CostFeedingLabelUpdate();
        }

        private void CostFeedingLabelUpdate()
        {
            CostLvlupLabel.Text = Zoo.ConvertMoney(LvlupPrice);
        }
        #endregion

        #region drow lines
        private void DrowLines()
        {
            DrowCostsFrames();
            DrowDividingLine();
        }

        private void DrowDividingLine()
        {
            Point[] points = new Point[] { new Point { X = 440, Y = 0 }, new Point { X = 440, Y = 423 }};
            Pen pen = new Pen(Brushes.Black, 1);
            Graphics MyPaint = SelectedTab.CreateGraphics();
            MyPaint.DrawLines(pen, points);
        }

        private void DrowCostsFrames()
        {
            Graphics MyPaint = SelectedTab.CreateGraphics();

            Point[] points = new Point[] { new Point { X = 75, Y = 423 }, new Point { X = 75, Y = 400 }, new Point { X = 155, Y = 400 }, new Point { X = 155, Y = 423 } };
            Pen pen = new Pen(Brushes.Black, 3);

            for (int i = 0; i < 3; i++)
            {
                MyPaint.DrawLines(pen, points);
                for (int j = 0; j < points.Length; j++)
                {
                    points[j].X += 105;
                }                
            }
        }
        #endregion

        #endregion

        #endregion


        #region Events
        private void tabPage_Paint(object sender, PaintEventArgs e)
        {
            DrowLines();
        }
        #endregion  
    }
}
    