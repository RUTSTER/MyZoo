using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс, представляющий систему клеток зоопарка. Через него происходит взаимодействие с каждой отдельной клеткой.
    /// </summary>
    public class CagesSystem
    {
        #region Properties
        private Delegates Delegates { get; set; }

        public ulong NextCagePrice { get; set; } = 1; 

        private List<Cage> CageList = new List<Cage>();
        #endregion
    

        #region Constructor
        public CagesSystem(MainForm mainForm, Delegates Delegates)
        {
            this.Delegates = Delegates;

            CagesSystemTCDrow(mainForm);
        }
        #endregion


        #region Indexer
        public Cage this[int i] => CageList[i];
        #endregion


        #region Methods

        public void CreateNewCage()
        {
            if (Zoo.Money < NextCagePrice)
                return;

            Zoo.Money -= NextCagePrice;
            NextCagePrice *= 10;
            CageList.Add(new Cage(out TabPage TPage, CagesSystemTC.TabCount + 1, Delegates));
            CagesSystemTC.TabPages.Add(TPage);
        }

        public Cage SelectedCage()
        {
            Console.WriteLine("переделать!");
            if (IsEmpty())
                throw new Exception();
            return CageList[SelectedIndex()];
        }

        public bool IsEmpty()
        {
            if (CageList.Count == 0)
                return true;

            return false;
        }  
               

        #region Actions
        public void Lvlup()
        {
            if (IsEmpty())
                return;
            SelectedCage().Lvlup();
        }

        public void Curing()
        {
            if (IsEmpty())
                return;
            SelectedCage().Curing();
        }

        public void Feeding()
        {
            if (IsEmpty())
                return;
            SelectedCage().Feeding();
        }

        public void Cleaning()
        {
            if (IsEmpty())
                return;
            SelectedCage().Cleaning();
        }
        public void Kill()
        {
            if (IsEmpty())
                return;
            SelectedCage().Kill();
        }
        #endregion

        #endregion


        #region CagesSystemTC

        TabControl CagesSystemTC;
        private void CagesSystemTCDrow(MainForm mainForm)

        {
            CagesSystemTC = new TabControl();
            CagesSystemTC.Parent = mainForm;
            CagesSystemTC.Location = new Point(1, 1);
            CagesSystemTC.Size = new Size(699, 449);
        }

        private int SelectedIndex()
        {
            return CagesSystemTC.SelectedIndex;
        }

        #endregion
    }
}
