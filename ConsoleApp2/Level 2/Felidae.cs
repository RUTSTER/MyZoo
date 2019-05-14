using System;
using System.Windows.Forms;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс семейства кошачьих
    /// </summary>
    abstract class Felidae : Animal
    {
        #region Constructor
        public Felidae(string Name, int Age, Genders Gender, TabPage SelectedTab, Delegates Delegates)
            : base(Name, Age, Gender, SelectedTab, Delegates)
        {
        }
        #endregion


        #region Methods
        protected override void BackgroundPicSet()
        {
            SelectedTab.BackgroundImage = Properties.Resources.FireBackground;
        }
        #endregion
    }
}
