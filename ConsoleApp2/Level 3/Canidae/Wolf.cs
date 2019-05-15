using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;

namespace ConsoleApp2
{
    /// <summary>
    /// Волк
    /// </summary>
    class Wolf : Canidae, IBig
    {
        #region Properties
        private static int CountThisType = 0;
        private static int CountThisTypeAlive = 0;

        private const float BuyingModifier = 3f;
        private const ulong BaseBuyingPriceConst = 1244160;
        public static ulong BuyingPriceStatic = BaseBuyingPriceConst;
        protected override ulong BaseBuyingPrice => BaseBuyingPriceConst;
        protected override ulong BuyingPrice => BuyingPriceStatic;


        protected override int ProfitPerLvl { get; } = 6500;
        protected override float LvlupModifier { get; } = 1.11f;

        protected override int MaxHelthBase { get; } = 500;
        protected override int HelthPerLvl { get; } = 5;
        protected override int MaxSatietyBase { get; } = 150;
        protected override int SatietyPerLvl { get; } = 5;
        #endregion


        #region Consructor
        public Wolf(string Name, int Age, Genders Gender, TabPage SelectedTab, Delegates Delegates)
            : base(Name, Age, Gender, SelectedTab, Delegates)
        {
            CountThisType++;
            CountThisTypeAlive++;

            ChangeAllBuyingPrice();
        }
        #endregion


        #region Methods
        protected override void SetPic(PictureBox PicBox)
        {
            PicBox.BackgroundImage = Properties.Resources.WolfMainPic;
        }

        public static void ChangeBuyingPrice()
        {
            BuyingPriceStatic = (ulong)
                (BaseBuyingPriceConst *
                Pow(BuyingModifier, CountThisTypeAlive) *
                (1 + 3 * CountThisType));
        }


        protected override void AnimalTypeLabelSettings(Label AnimalTypeLabel)
        {
            AnimalTypeLabel.Location = new Point(182, 5);
            AnimalTypeLabel.Size = new Size(76, 34);
            AnimalTypeLabel.Text = $"Wolf";
        }
        #endregion
    }
}
