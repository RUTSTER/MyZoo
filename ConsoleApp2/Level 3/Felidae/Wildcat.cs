using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;

namespace ConsoleApp2
{
    /// <summary>
    /// Дикий кот
    /// </summary>
    class Wildcat : Felidae, ISmall
    {
        #region Properties
        private static int CountThisType = 0;
        private static int CountThisTypeAlive = 0;

        private const float Multiplier = 1.5f;

        private const ulong BaseBuyingPrice = 700;
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


        protected override int ProfitPerLvl { get; } = 34533;
        protected override float PriceIncreaseModifier { get; } = 1.07f;

        protected override int MaxHelthBase { get; } = 200;
        protected override int HelthPerLvl { get; } = 4;
        protected override int MaxSatietyBase { get; } = 100;
        protected override int SatietyPerLvl { get; } = 2;
        #endregion


        #region Consructor
        public Wildcat(string Name, int Age, Genders Gender, TabPage SelectedTab, Delegates Delegates)
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
            PicBox.BackgroundImage = Properties.Resources.WildcatMainPic;
        }
        public override ulong NewLvlPrice()
        {
            return (ulong)(BaseBuyingPrice * Pow(PriceIncreaseModifier, Lvl));
        }

        public void TryToEscape()
        {

        }

        protected override void AnimalTypeLabelSettings(Label AnimalTypeLabel)
        {
            AnimalTypeLabel.Location = new Point(163, 5);
            AnimalTypeLabel.Size = new Size(114, 34);
            AnimalTypeLabel.Text = $"Wildcat";
        }
        #endregion
    }
}
