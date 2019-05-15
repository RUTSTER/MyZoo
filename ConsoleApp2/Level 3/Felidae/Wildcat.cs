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

        private const float BuyingModifier = 3f;

        private const ulong BaseBuyingPriceConst = 179000000;
        public static ulong BuyingPriceStatic = BaseBuyingPriceConst;
        protected override ulong BaseBuyingPrice => BaseBuyingPriceConst;
        protected override ulong BuyingPrice => BuyingPriceStatic;


        protected override int ProfitPerLvl { get; } = 58000;
        protected override float LvlupModifier { get; } = 1.09f;

        protected override int MaxHelthBase { get; } = 200;
        protected override int HelthPerLvl { get; } = 7;
        protected override int MaxSatietyBase { get; } = 200;
        protected override int SatietyPerLvl { get; } = 7;
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

        public static void ChangeBuyingPrice()
        {
            BuyingPriceStatic = (ulong)
                (BaseBuyingPriceConst *
                Pow(BuyingModifier, CountThisTypeAlive) *
                (1 + 3 * CountThisType));
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
