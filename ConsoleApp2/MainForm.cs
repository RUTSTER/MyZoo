using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class MainForm : Form
    {
        #region Properties
        private Zoo ZooRef;
        #endregion


        #region Constructor 
        public MainForm()
        {
            InitializeComponent();            
            DrowControls();
        }
        #endregion


        #region Methods

        void InitializeOtherComponent() => ZooRef.InitializeComponent();
        
        public void SetReference(Zoo ZooRef)
        {
            this.ZooRef = ZooRef;
        }

        public void RefreshMoneyLabel(string Value)
        {
            MoneyLabel.Invoke(new Action(() =>
            MoneyLabel.Text = Value));
        }
        public void RefreshNewCagePriceLabel(string Value)
        {
            NewCagePriceLabel.Invoke(new Action(() =>
            NewCagePriceLabel.Text = Value));
        }

        private void DrowControls()
        {
            #region Buttons put/press BackColor
            BuyCageButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BuyCageButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            ExitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ExitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CuringButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CuringButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CleaningButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CleaningButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            FeedingButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            FeedingButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            LvlupButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LvlupButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            KillButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            KillButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            #endregion
        }

        #region Move & Draw Frames

        #region drow
        protected override void OnPaint(PaintEventArgs e)
        {
            #region main frame
            Point[] MyPoints = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = ClientSize.Width - 1, Y = 0 }, new Point { X = ClientSize.Width - 1, Y = ClientSize.Height - 1 }, new Point { X = 0, Y = ClientSize.Height - 1 }, new Point { X = 0, Y = 0 } };
            Pen MyPen = new Pen(Brushes.DarkBlue);
            e.Graphics.DrawLines(MyPen, MyPoints);
            #endregion

            #region button frames
            Point[] points = new Point[] { new Point { X = 80, Y = 450 }, new Point { X = 80, Y = 535 }, new Point { X = 160, Y = 535 }, new Point { X = 160, Y = 450 } };//координаты точек для обрисовки кнопок, смещенные на 100 влево, т.к. перед каждой отрисовкой будет смещение вправо
            Pen pen = new Pen(Brushes.Black, 3);

            for (int i = 0; i < 3; i++)
            {
                e.Graphics.DrawLines(pen, points);
                for (int j = 0; j < points.Length; j++)
                {
                    points[j].X += 105;
                }
            }


            Point[] pnts = new Point[] { new Point { X = 480, Y = 455 }, new Point { X = 480, Y = 535 }, new Point { X = 560, Y = 535 }, new Point { X = 560, Y = 455 }, new Point { X = 480, Y = 455 } };//координаты точек для обрисовки кнопок, смещенные на 100 влево, т.к. перед каждой отрисовкой будет смещение вправо
            Pen pn = new Pen(Brushes.Black, 3);

            e.Graphics.DrawLines(pn, pnts);
            for (int j = 0; j < pnts.Length; j++)
            {
                pnts[j].X += 105;
            }
            e.Graphics.DrawLines(pn, pnts);
            #endregion
        }
        #endregion

        #region move
        protected override void WndProc(ref Message m)
        {
            int CaptionRectSizeX = 260;
            int CaptionRectSizeY = 24;

            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if ((pos.X > ClientSize.Width - CaptionRectSizeX) && (pos.Y < CaptionRectSizeY))
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        #endregion

        #endregion


        #region Events

        #region Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeOtherComponent();
        }
        #endregion

        #region BuyCageButton
        private void BuyCageButton_Click(object sender, EventArgs e)
        {
            Zoo.MoneySound.Play();
            ZooRef.CreateNewCage();
        }

        private void BuyCageButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            BuyCageButton.BackgroundImage = Properties.Resources.BuyNewCagePutPic;
        }

        private void BuyCageButton_MouseLeave(object sender, EventArgs e)
        {
            BuyCageButton.BackgroundImage = Properties.Resources.BuyNewCagePic;
        }

        private void BuyCageButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
            BuyCageButton.BackgroundImage = Properties.Resources.BuyNewCagePressPic;
        }

        private void BuyCageButton_MouseUp(object sender, MouseEventArgs e)
        {
            BuyCageButton.BackgroundImage = Properties.Resources.BuyNewCagePutPic;
        }

        #endregion

        #region ButtonExit
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonExit_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ExitButton.BackgroundImage = Properties.Resources.ExitButtonPutPic;

        }

        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.ExitButtonPic;
        }

        private void ButtonExit_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();

        }
        #endregion

        #region ActionButtons 

        #region LvlupButton
        private void LvlupButton_Click(object sender, EventArgs e)
        {
            ZooRef.Lvlup();
        }

        private void LvlupButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.LvlupIconPut;
        }

        private void LvlupButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.LvlupIconBase;
        }

        private void LvlupButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.LvlupIconPress;
        }

        private void LvlupButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.LvlupIconPut;
        }
        #endregion


        #region CuringButton
        private void CuringButton_Click(object sender, EventArgs e)
        {
            ZooRef.Curing();
        }

        private void CuringButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.CuringIconPut;
        }

        private void CuringButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.CuringIconBase;
        }

        private void CuringButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.CuringIconPress;
        }

        private void CuringButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.CuringIconPut;
        }
        #endregion


        #region FeedingButton
        private void FeedingButton_Click(object sender, EventArgs e)
        {
            ZooRef.Feeding();
        }

        private void FeedingButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.FeedingIconPut;
        }

        private void FeedingButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.FeedingIconBase;
        }

        private void FeedingButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.FeedingIconPress;
        }

        private void FeedingButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.FeedingIconPut;
        }
        #endregion


        #region CleaningButton
        private void CleaningButton_Click(object sender, EventArgs e)
        {
            ZooRef.Cleaning();
        }

        private void CleaningButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.CleaningIconPut;
        }

        private void CleaningButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.CleaningIconBase;
        }

        private void CleaningButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.CleaningIconPress;
        }

        private void CleaningButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.CleaningIconPut;
        }
        #endregion


        #region KillButton
        private void KillButton_Click(object sender, EventArgs e)
        {
            ZooRef.Kill();
        }

        private void KillButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.KillIconPut;
        }

        private void KillButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.KillIconBase;
        }

        private void KillButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.KillIconPress;
        }

        private void KillButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.KillIconPut;
        }
        #endregion

        #endregion

        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Profit_Click(object sender, EventArgs e)
        {

        }

        private void LVLValue_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
