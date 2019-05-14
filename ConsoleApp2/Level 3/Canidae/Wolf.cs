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

        private const float Multiplier = 1.5f;

        private const ulong BaseBuyingPrice = 4;
        public static ulong BuyingPriceStatic = BaseBuyingPrice;
        protected override ulong BuyingPrice => BuyingPriceStatic;

        public static void ChangeBuyingPrice()
        {
            BuyingPriceStatic = (ulong)
                (BaseBuyingPrice *
                Math.Pow(Multiplier, CountThisTypeAlive) *
                (1 +
                (3 * CountThisType) +
                (2 * CountAllAnimalsAlive) +
                CountAllAnimals));
        }



        protected override int ProfitPerLvl { get; } = 500;
        protected override float PriceIncreaseModifier { get; } = 1.15f;

        protected override int MaxHelthBase { get; } = 500;
        protected override int HelthPerLvl { get; } = 5;
        protected override int MaxSatietyBase { get; } = 100;
        protected override int SatietyPerLvl { get; } = 2;
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
        public override ulong NewLvlPrice()
        {
            return (ulong)(BaseBuyingPrice * Pow(PriceIncreaseModifier, Lvl));
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
