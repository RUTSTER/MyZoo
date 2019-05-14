using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс представляющий "клетку", в которую будет размещаться животное.
    /// </summary>
    public class Cage
    {
        #region AnimalSpecies enum
        enum AnimalSpecies
        {
            Raccoon,
            Wolf,
            Wildcat,
            Tiger
        }
        #endregion


        #region Propeerties
        private TabPage CageTPage;

        private bool IsChoosedSpecies = false;
        private AnimalSpecies ChoosedSpecies;
        private bool IsChoosedGender = false;
        private Genders ChoosedGender;

        private Animal PlacedAnimal { get; set; }

        Delegates Delegates;
        #endregion


        #region Constructor
        public Cage(out TabPage CageTPage, int CageNumber, Delegates Delegates)
        {
            this.Delegates = Delegates;
            CageTPage = new TabPage($"Cage №{CageNumber}");
            this.CageTPage = CageTPage;

            this.CageTPage.Paint += tabPage_Paint;
            DrowControls();
        }
        #endregion

      
        #region Methods    

        private void DrowControls()
        {
            CageTPage.BackgroundImage = Properties.Resources.SecondBackground;

            BuyButtonDrow();

            RaccoonButtonDrow();
            WolfButtonDrow();
            WildcatButtonDrow();
            TigerButtonDrow();
            RaccoonPriceLabelDrow();
            WolfPriceLabelDrow();
            WildcatPriceLabelDrow();
            TigerPriceLabelDrow();

            NameTBDrow();
            AgeTBDrow();
            IsMaleCBDrow();
            IsFemaleCBDrow();
        }           


        public void FeedSelectedAnimal()
        {
            PlacedAnimal.Feeding();
        }

        private void AnimalPriceLabelsUpdate()
        {
            RaccoonPriceLabelUpdate();
            WolfPriceLabelUpdate();
            WildcatPriceLabelUpdate();
            TigerPriceLabelUpdate();
        }


        #region Actions

        public void Lvlup()
        {
            if (PlacedAnimal == null)
                return;
            PlacedAnimal.Lvlup();
        }

        public void Curing()
        {
            if (PlacedAnimal == null)
                return;
            PlacedAnimal.Curing();
        }

        public void Feeding()
        {
            if (PlacedAnimal == null)
                return;
            PlacedAnimal.Feeding();
        }

        public void Cleaning()
        {
            if (PlacedAnimal == null)
                return;
            PlacedAnimal.Cleaning();
        }

        public void Kill()
        {
            if (PlacedAnimal == null)
                return;

            PlacedAnimal.Kill();
            PlacedAnimal = null;
            IsChoosedSpecies = false;
            CageTPage.Controls.Clear();
            DrowControls();
        }

        #endregion


        #region DrawingMethods

        #region BuyButton
        private void BuyButtonDrow()
        {
            Button BuyButton = new Button();
            BuyButton.Parent = CageTPage;
            BuyButton.BackColor = Color.White;
            BuyButton.BackgroundImageLayout = ImageLayout.Stretch;
            BuyButton.Cursor = Cursors.Hand;
            BuyButton.FlatStyle = FlatStyle.Flat;
            BuyButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BuyButton.Location = new Point(295, 305);
            BuyButton.Name = "BuyAnimalButton";
            BuyButton.Size = new Size(100, 60);
            BuyButton.Text = "BUY";

            BuyButton.Click += BuyButton_Click;
            BuyButton.MouseEnter += BuyButton_MouseEnter;
            BuyButton.MouseLeave += BuyButton_MouseLeave;
            BuyButton.MouseDown += BuyButton_MouseDown;
            BuyButton.MouseUp += BuyButton_MouseUp;
        }
        #endregion

        #region СhooseAnimal Buttons&Labels

        #region RaccoonButton
        private Button RaccoonButton;
        private void RaccoonButtonDrow()
        {
            RaccoonButton = new Button();
            RaccoonButton.Parent = CageTPage;
            RaccoonButton.BackColor = Color.Transparent;
            RaccoonButton.BackgroundImage = Properties.Resources.RaccoonIconBase;
            RaccoonButton.BackgroundImageLayout = ImageLayout.Stretch;
            RaccoonButton.Cursor = Cursors.Hand;
            RaccoonButton.FlatAppearance.BorderSize = 0;
            RaccoonButton.FlatStyle = FlatStyle.Flat;
            RaccoonButton.Location = new Point(165, 70);
            RaccoonButton.Name = "RaccoonButton";
            RaccoonButton.Size = new Size(60, 60);
            RaccoonButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            RaccoonButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            RaccoonButton.Click += RaccoonButton_Click;
            RaccoonButton.MouseEnter += RaccoonButton_MouseEnter;
            RaccoonButton.MouseLeave += RaccoonButton_MouseLeave;
            RaccoonButton.MouseDown += RaccoonButton_MouseDown;
            RaccoonButton.MouseUp += RaccoonButton_MouseUp;
        }
        #endregion

        #region WolfButton
        private Button WolfButton;
        private void WolfButtonDrow()
        {
            WolfButton = new Button();
            WolfButton.Parent = CageTPage;
            WolfButton.BackColor = Color.Transparent;
            WolfButton.BackgroundImage = Properties.Resources.WolfIconBase;
            WolfButton.BackgroundImageLayout = ImageLayout.Stretch;
            WolfButton.Cursor = Cursors.Hand;
            WolfButton.FlatAppearance.BorderSize = 0;
            WolfButton.FlatStyle = FlatStyle.Flat;
            WolfButton.Location = new Point(265, 70);
            WolfButton.Name = "WolfButton";
            WolfButton.Size = new Size(60, 60);
            WolfButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            WolfButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            WolfButton.Click += WolfButton_Click;
            WolfButton.MouseEnter += WolfButton_MouseEnter;
            WolfButton.MouseLeave += WolfButton_MouseLeave;
            WolfButton.MouseDown += WolfButton_MouseDown;
            WolfButton.MouseUp += WolfButton_MouseUp;
        }
        #endregion

        #region WildcatButton
        private Button WildcatButton;
        private void WildcatButtonDrow()
        {
            WildcatButton = new Button();
            WildcatButton.Parent = CageTPage;
            WildcatButton.BackColor = Color.Transparent;
            WildcatButton.BackgroundImage = Properties.Resources.WildcatIconBase;
            WildcatButton.BackgroundImageLayout = ImageLayout.Stretch;
            WildcatButton.Cursor = Cursors.Hand;
            WildcatButton.FlatAppearance.BorderSize = 0;
            WildcatButton.FlatStyle = FlatStyle.Flat;
            WildcatButton.Location = new Point(365, 70);
            WildcatButton.Name = "WildcatButton";
            WildcatButton.Size = new Size(60, 60);
            WildcatButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            WildcatButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            WildcatButton.Click += WildcatButton_Click;
            WildcatButton.MouseEnter += WildcatButton_MouseEnter;
            WildcatButton.MouseLeave += WildcatButton_MouseLeave;
            WildcatButton.MouseDown += WildcatButton_MouseDown;
            WildcatButton.MouseUp += WildcatButton_MouseUp;
        }
        #endregion

        #region TigerButton
        private Button TigerButton;
        private void TigerButtonDrow()
        {
            TigerButton = new Button();
            TigerButton.Parent = CageTPage;
            TigerButton.BackColor = Color.Transparent;
            TigerButton.BackgroundImage = Properties.Resources.TigerIconBase;
            TigerButton.BackgroundImageLayout = ImageLayout.Stretch;
            TigerButton.Cursor = Cursors.Hand;
            TigerButton.FlatAppearance.BorderSize = 0;
            TigerButton.FlatStyle = FlatStyle.Flat;
            TigerButton.Location = new Point(465, 70);
            TigerButton.Name = "TigerButton";
            TigerButton.Size = new Size(60, 60);
            TigerButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            TigerButton.FlatAppearance.MouseDownBackColor = Color.Transparent;

            TigerButton.Click += TigerButton_Click;
            TigerButton.MouseEnter += TigerButton_MouseEnter;
            TigerButton.MouseLeave += TigerButton_MouseLeave;
            TigerButton.MouseDown += TigerButton_MouseDown;
            TigerButton.MouseUp += TigerButton_MouseUp;
        }
        #endregion

        #region RaccoonPriceLabel
        Label RaccoonPriceLabel;
        private void RaccoonPriceLabelDrow()
        {
            RaccoonPriceLabel = new Label();
            RaccoonPriceLabel.Parent = CageTPage;
            RaccoonPriceLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RaccoonPriceLabel.BackColor = Color.Transparent;
            RaccoonPriceLabel.Location = new Point(160, 150);
            RaccoonPriceLabel.Name = "RaccoonPriceLabel";
            RaccoonPriceLabel.Size = new Size(70, 20);
            RaccoonPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            RaccoonPriceLabelUpdate();
        }

        private void RaccoonPriceLabelUpdate()
        {
            RaccoonPriceLabel.Text = Zoo.ConvertMoney(Raccoon.BuyingPriceStatic);
        }
        #endregion

        #region WolfPriceLabel
        Label WolfPriceLabel;
        private void WolfPriceLabelDrow()
        {
            WolfPriceLabel = new Label();
            WolfPriceLabel.Parent = CageTPage;
            WolfPriceLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WolfPriceLabel.BackColor = Color.Transparent;
            WolfPriceLabel.Location = new Point(260, 150);
            WolfPriceLabel.Name = "WolfPriceLabel";
            WolfPriceLabel.Size = new Size(70, 20);
            WolfPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            WolfPriceLabelUpdate();
        }

        private void WolfPriceLabelUpdate()
        {
            WolfPriceLabel.Text = Zoo.ConvertMoney(Wolf.BuyingPriceStatic);
        }
        #endregion

        #region WildcatPriceLabel
        Label WildcatPriceLabel;
        private void WildcatPriceLabelDrow()
        {
            WildcatPriceLabel = new Label();
            WildcatPriceLabel.Parent = CageTPage;
            WildcatPriceLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WildcatPriceLabel.BackColor = Color.Transparent;
            WildcatPriceLabel.Location = new Point(360, 150);
            WildcatPriceLabel.Name = "WildcatPriceLabel";
            WildcatPriceLabel.Size = new Size(70, 20);
            WildcatPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            WildcatPriceLabelUpdate();
        }

        private void WildcatPriceLabelUpdate()
        {
            WildcatPriceLabel.Text = Zoo.ConvertMoney(Wildcat.BuyingPriceStatic);
        }
        #endregion

        #region TigerPriceLabel
        Label TigerPriceLabel;
        private void TigerPriceLabelDrow()
        {
            TigerPriceLabel = new Label();
            TigerPriceLabel.Parent = CageTPage;
            TigerPriceLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TigerPriceLabel.BackColor = Color.Transparent;
            TigerPriceLabel.Location = new Point(460, 150);
            TigerPriceLabel.Name = "TigerPriceLabel";
            TigerPriceLabel.Size = new Size(70, 20);
            TigerPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            TigerPriceLabelUpdate();
        }

        private void TigerPriceLabelUpdate()
        {
            TigerPriceLabel.Text = Zoo.ConvertMoney(Tiger.BuyingPriceStatic);
        }
        #endregion

        #endregion

        #region NameTB
        private TextBox NameTB;
        private void NameTBDrow()
        {
            NameTB = new TextBox();
            NameTB.Parent = CageTPage;
            NameTB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTB.BorderStyle = BorderStyle.FixedSingle;
            NameTB.Location = new Point(255, 200);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(140, 22);
            NameTB.MaxLength = 10;
            NameTB.ForeColor = Color.Silver;
            NameTB.Text = "Name";
            NameTB.TextAlign = HorizontalAlignment.Center;

            NameTB.Enter += NameTB_Enter;
            NameTB.Leave += NameTB_Leave;
            NameTB.KeyPress += NameTB_KeyPress;
        }
        #endregion

        #region AgeTB
        private TextBox AgeTB;
        private void AgeTBDrow()
        {
            AgeTB = new TextBox();
            AgeTB.Parent = CageTPage;
            AgeTB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AgeTB.BorderStyle = BorderStyle.FixedSingle;
            AgeTB.Location = new Point(405, 200);
            AgeTB.Name = "AgeTB";
            AgeTB.Size = new Size(30, 22);
            AgeTB.MaxLength = 2;
            AgeTB.ForeColor = Color.Silver;
            AgeTB.Text = "Age";
            AgeTB.TextAlign = HorizontalAlignment.Center;

            AgeTB.Enter += AgeTB_Enter;
            AgeTB.Leave += AgeTB_Leave;
            AgeTB.KeyPress += AgeTB_KeyPress;
        }
        #endregion

        #region IsMaleCB
        private CheckBox IsMaleCB;
        private void IsMaleCBDrow()
        {
            IsMaleCB = new CheckBox();
            IsMaleCB.Parent = CageTPage;
            IsMaleCB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IsMaleCB.BackColor = Color.Transparent;
            IsMaleCB.FlatStyle = FlatStyle.Flat;
            IsMaleCB.Location = new Point(285, 230);
            IsMaleCB.Name = "IsMaleCB";
            IsMaleCB.Size = new Size(54, 20);
            IsMaleCB.Text = "Male";

            IsMaleCB.CheckedChanged += CheckBoxes_CheckedChanged;
        }
        #endregion

        #region IsFemaleCB
        private CheckBox IsFemaleCB;
        private void IsFemaleCBDrow()
        {
            IsFemaleCB = new CheckBox();
            IsFemaleCB.Parent = CageTPage;
            IsFemaleCB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IsFemaleCB.BackColor = Color.Transparent;
            IsFemaleCB.FlatStyle = FlatStyle.Flat;
            IsFemaleCB.Location = new Point(347, 230);
            IsFemaleCB.Name = "IsFemaleCB";
            IsFemaleCB.Size = new Size(68, 20);
            IsFemaleCB.Text = "Female";

            IsFemaleCB.CheckedChanged += CheckBoxes_CheckedChanged;
        }
        #endregion

        #endregion

        #endregion


        #region Events

        #region TabPagePaint&DrowFrame
        private void tabPage_Paint(object sender, PaintEventArgs e)
        {
            if (PlacedAnimal != null)
                return;

            AnimalPriceLabelsUpdate();

            if (!IsChoosedSpecies)
                return;            

            int BtnX = 0;
            switch (ChoosedSpecies)
            {
                case AnimalSpecies.Raccoon:
                    BtnX = 165;
                    break;
                case AnimalSpecies.Wolf:
                    BtnX = 265;
                    break;
                case AnimalSpecies.Wildcat:
                    BtnX = 365;
                    break;
                case AnimalSpecies.Tiger:
                    BtnX = 465;
                    break;
                default:
                    break;
            }
            DrowFrame(BtnX);
        }


        private void DrowFrame(int BtnX)
        {            
            Graphics MyFormPaint = CageTPage.CreateGraphics();
            Point[] points = new Point[] {
                new Point { X = BtnX - 10, Y = 60 },
                new Point { X = BtnX + 70, Y = 60 },
                new Point { X = BtnX + 70, Y = 180 },
                new Point { X = BtnX - 10, Y = 180 },
                new Point { X = BtnX - 10, Y = 60 } };
            Pen pen = new Pen(Brushes.Black, 3);
            MyFormPaint.DrawLines(pen, points);
        }
        #endregion


        #region BuyButton
        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (CheckInput(AnimalPrices()))
            {
                Zoo.MoneySound.Play();
                CageTPage.Controls.Clear();
                BuyAnimal();
            }
        }

        private void BuyButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
        }

        private void BuyButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BuyButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.PressSound.Play();
        }

        private void BuyButton_MouseUp(object sender, MouseEventArgs e)
        {

        }

        #region Methods
        private ulong[] AnimalPrices()
        {
            ulong[] Prices = new ulong[4];
            Prices[0] = Raccoon.BuyingPriceStatic;
            Prices[1] = Wolf.BuyingPriceStatic;
            Prices[2] = Wildcat.BuyingPriceStatic;
            Prices[3] = Tiger.BuyingPriceStatic;
            return Prices;
        }

        private void BuyAnimal()
        {
            switch (ChoosedSpecies)
            {
                case AnimalSpecies.Raccoon:
                    Zoo.Money -= Raccoon.BuyingPriceStatic;
                    PlacedAnimal = new Raccoon(NameTB.Text, Convert.ToInt32(AgeTB.Text), ChoosedGender, CageTPage, Delegates);
                    break;
                case AnimalSpecies.Wolf:
                    Zoo.Money -= Wolf.BuyingPriceStatic;
                    PlacedAnimal = new Wolf(NameTB.Text, Convert.ToInt32(AgeTB.Text), ChoosedGender, CageTPage, Delegates);
                    break;
                case AnimalSpecies.Wildcat:
                    Zoo.Money -= Wildcat.BuyingPriceStatic;
                    PlacedAnimal = new Wildcat(NameTB.Text, Convert.ToInt32(AgeTB.Text), ChoosedGender, CageTPage, Delegates);
                    break;
                case AnimalSpecies.Tiger:
                    Zoo.Money -= Tiger.BuyingPriceStatic;
                    PlacedAnimal = new Tiger(NameTB.Text, Convert.ToInt32(AgeTB.Text), ChoosedGender, CageTPage, Delegates);
                    break;
                default:
                    break;
            }
        }

        private bool CheckInput(ulong[] Prices)
        {
            bool IsCorrectInput = true;
            string message = "";

            if (!IsChoosedSpecies)
            {
                IsCorrectInput = false;
                message += "Choose species!\n";
            }
            if (!IsChoosedGender)
            {
                IsCorrectInput = false;
                message += "Choose gender!\n";
            }
            if (NameTB.Text == "Name")
            {
                IsCorrectInput = false;
                message += "Choose name!\n";
            }
            if (AgeTB.Text == "Age")
            {
                IsCorrectInput = false;
                message += "Choose age!\n";
            }

            if (Zoo.Money < Prices[(int)ChoosedSpecies])
            {
                IsCorrectInput = false;
                message += "Earn more money!\n";
            }

            if (IsCorrectInput)
            {
                return true;
            }
            else
            {
                MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #endregion


        #region AnimalButtons

        #region Raccoon
        private void RaccoonButton_Click(object sender, EventArgs e)
        {
            IsChoosedSpecies = true;
            ChoosedSpecies = AnimalSpecies.Raccoon;
            CageTPage.Invalidate();
        }

        private void RaccoonButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.RaccoonIconPut;
        }

        private void RaccoonButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.RaccoonIconBase;
        }

        private void RaccoonButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.SelectSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.RaccoonIconPress;
        }

        private void RaccoonButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.RaccoonIconPut;
        }
        #endregion


        #region Wolf
        private void WolfButton_Click(object sender, EventArgs e)
        {
            IsChoosedSpecies = true;
            ChoosedSpecies = AnimalSpecies.Wolf;
            CageTPage.Invalidate();
        }

        private void WolfButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.WolfIconPut;
        }

        private void WolfButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.WolfIconBase;
        }

        private void WolfButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.SelectSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.WolfIconPress;
        }

        private void WolfButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.WolfIconPut;
        }
        #endregion


        #region Wildcat
        private void WildcatButton_Click(object sender, EventArgs e)
        {
            IsChoosedSpecies = true;
            ChoosedSpecies = AnimalSpecies.Wildcat;
            CageTPage.Invalidate();
        }

        private void WildcatButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.WildcatIconPut;
        }

        private void WildcatButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.WildcatIconBase;
        }

        private void WildcatButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.SelectSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.WildcatIconPress;
        }

        private void WildcatButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.WildcatIconPut;
        }
        #endregion


        #region Tiger
        private void TigerButton_Click(object sender, EventArgs e)
        {
            IsChoosedSpecies = true;
            ChoosedSpecies = AnimalSpecies.Tiger;
            CageTPage.Invalidate();
        }

        private void TigerButton_MouseEnter(object sender, EventArgs e)
        {
            Zoo.PutSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.TigerIconPut;
        }

        private void TigerButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.TigerIconBase;
        }

        private void TigerButton_MouseDown(object sender, MouseEventArgs e)
        {
            Zoo.SelectSound.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.TigerIconPress;
        }

        private void TigerButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.TigerIconPut;
        }
        #endregion

        #endregion


        #region NameTB
        private void NameTB_Enter(object sender, EventArgs e)
        {
            if (NameTB.Text == "Name")
            {
                NameTB.Text = "";
                NameTB.ForeColor = Color.Black;
            }
        }
        
        private void NameTB_Leave(object sender, EventArgs e)
        {
            if (NameTB.Text == "")
            {
                NameTB.Text = "Name";
                NameTB.ForeColor = Color.Silver;
            }
        }

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8) // буквы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        #endregion


        #region AgeTB
        private void AgeTB_Enter(object sender, EventArgs e)
        {
            if (AgeTB.Text == "Age")
            {
                AgeTB.Text = "";
                AgeTB.ForeColor = Color.Black;
            }
        }

        private void AgeTB_Leave(object sender, EventArgs e)
        {
            if (AgeTB.Text == "")
            {
                AgeTB.Text = "Age";
                AgeTB.ForeColor = Color.Silver;
            }
        }

        private void AgeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        #endregion


        #region CheckBoxes
        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            Zoo.SelectSound.Play();

            CheckBox CB = (CheckBox)sender;
            if (CB.Checked)
            {                         
                IsChoosedGender = true;
                if(CB.Name == "IsMaleCB")
                {
                    ChoosedGender = Genders.Male;
                    IsFemaleCB.Checked = false;
                }
                else
                {
                    ChoosedGender = Genders.Female;
                    IsMaleCB.Checked = false;
                }
            }
            else
            {
                IsChoosedGender = false;
            }
        }
        #endregion

        #endregion
    }
}