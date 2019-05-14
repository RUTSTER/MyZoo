using System;
using System.Windows.Forms;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс семейства псовых
    /// </summary>
    abstract class Canidae : Animal
    {
        #region Constructor
        public Canidae(string Name, int Age, Genders Gender, TabPage SelectedTab, Delegates Delegates)
            : base(Name, Age, Gender, SelectedTab, Delegates)
        { 
        }
        #endregion


        #region Methods
        protected override void BackgroundPicSet()
        {
            SelectedTab.BackgroundImage = Properties.Resources.IceBackground;
        }
        #endregion
    }
}
