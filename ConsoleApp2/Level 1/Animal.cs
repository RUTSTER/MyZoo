using System;
using System.Windows.Forms;
using static System.Math;

namespace ConsoleApp2
{
    /// <summary>
    /// Базовый класс всех животных
    /// </summary>
    public abstract partial class Animal
    {
        #region Properties
        protected static int CountAllAnimals = 0;
        protected static int CountAllAnimalsAlive = 0;

        public Genders Gender { get; }

        public string Name { get; }

        public int Age { get; private set; }

        Delegates Delegates;

        #region IsAlive
        bool isAlive = true;
        public bool IsAlive
        {
            get
            {
                return isAlive; 
            }

            private set
            {
                isAlive = false;              

                RemoveMethodsToDel();
                //Work with other methods/properties, from another part of this class
                Delegates.ShowNewData -= RedrowBars;
                SelectedTab.Paint -= tabPage_Paint;
                SelectedTab.BackgroundImage = Properties.Resources.DeadBackground;
            }
        }
        #endregion

        #region Lvl
        private int lvl = 1;
        private int MultiplierPerLvl = 1;
        protected int Lvl
        {
            get
            {
                return lvl;
            }

            set // увеличение уровня и пересчет значений, которые зависят от данной величины
            {
                lvl++;

                MaxHelth++;     // пересчет максимального здоровья
                MaxSatiety++;   // пересчет максимальной сытости

                LvlupPrice = NewLvlPrice(); // пересчет стоимости повышения уровня
                CostLvlupLabelUpdate();
                SetMultiplier();

                LvlValueLabelUpdate();
            }         
        }

        void SetMultiplier()
        {
            switch (lvl)
            {
                case int n when n >= 500:
                    MultiplierPerLvl = 64;
                    break;

                case int n when n >= 300:
                    MultiplierPerLvl = 32;
                    break;

                case int n when n >= 200:
                    MultiplierPerLvl = 16;
                    break;

                case int n when n >= 100:
                    MultiplierPerLvl = 8;
                    break;

                case int n when n >= 50:
                    MultiplierPerLvl = 4;
                    break;

                case int n when n >= 25:
                    MultiplierPerLvl = 2;
                    break;

                default:
                    break;
            }
        }


        #endregion

        #region Helth

        protected abstract int MaxHelthBase { get; }
        protected abstract int HelthPerLvl { get; }

        #region MaxHelth
        private int maxHelth;
        public int MaxHelth
        {
            get
            {
                return maxHelth;
            }
            set
            {
                maxHelth = CalcMaxHelth();
            }
        }

        private int CalcMaxHelth()
        {
            int LvlFactor = Lvl * HelthPerLvl;
            int AgeFactor = (int)Math.Pow(Age, 2);
            int GenderFactor = (Gender == Genders.Male) ? GenderFactor = 3 : GenderFactor = 2;

            return MaxHelthBase + LvlFactor + (GenderFactor * AgeFactor * 2);
        }
        #endregion

        #region Helth
        private int helth;    //75%-100%
        public int Helth
        {
            get
            {
                return helth;
            }
            set
            {
                if (value > MaxHelth)
                {
                    helth = MaxHelth;
                    return;
                }
                if (value < 0)
                {
                    helth = 0;
                    RedrowBars();
                    IsAlive = false;
                }
                helth = value;
            }
        }

        private int HelthFirstValue()
        {
            return MaxHelth - Zoo.RandomInt(MaxHelth / 4 + 1);
        }
        #endregion

        #endregion

        #region Satiety
        protected abstract int MaxSatietyBase { get; }
        protected abstract int SatietyPerLvl { get; }

        #region MaxSatiety
        private int maxSatiety;
        public int MaxSatiety
        {
            get
            {
                return maxSatiety;
            }
            set
            {
                maxSatiety = CalcMaxSatiety();
            }
        }
        private int CalcMaxSatiety()
        {
            int LvlFactor = Lvl * SatietyPerLvl;
            int AgeFactor = (int)Math.Pow(Age, 2);
            int GenderFactor = (Gender == Genders.Male) ? GenderFactor = 2 : GenderFactor = 3;

            return MaxSatietyBase + LvlFactor + (GenderFactor * AgeFactor * 2);
        }
        #endregion

        #region Satiety      
        private int satiety;   //50%-75%
        public int Satiety
        {
            get
            {
                return satiety;
            }
            set
            {
                if (value > MaxSatiety)
                {
                    satiety = MaxSatiety;
                    return;
                }
                if (value < 0)
                {
                    satiety = 0;
                    return;
                }
                satiety = value;
            }
        }
        private int SatietyFirstValue()
        {
            return MaxSatiety / 2 + Zoo.RandomInt(MaxSatiety / 4 + 1);
        }
        #endregion

        #endregion

        #endregion
                     
        
        #region Constructor 
        public Animal(string Name, int Age, Genders Gender, TabPage CageTP, Delegates Delegates)
        {
            CountAllAnimals++;
            CountAllAnimalsAlive++;      

            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            SetBasicValues();

            this.Delegates = Delegates;
            AddMethodsToDel();

            DrowGUI(CageTP, Delegates);
               
            #region SetBasicValues
            void SetBasicValues()
            {
                maxHelth = CalcMaxHelth();
                helth = HelthFirstValue();
                maxSatiety = CalcMaxSatiety();
                satiety = SatietyFirstValue();

                LvlupPrice = NewLvlPrice();
            }
            #endregion
        }
        #endregion  
        

        #region Methods        

        void SatietyDecrease()
        {
            Satiety-=1;
            Console.WriteLine($"{satiety} - {maxSatiety}");
        }

        void HelthDecrease()
        {
            int perc = Percent(Satiety, MaxSatiety);

            if (perc < 10)
            {
                Helth -= 1 + (10 - perc)/2;
            }
        }

        private void ChangeStats()
        {
            HelthDecrease();
            SatietyDecrease();
        }

        protected static void ChangeAllBuyingPrice()
        {
            Raccoon.ChangeBuyingPrice();
            Wolf.ChangeBuyingPrice();
            Wildcat.ChangeBuyingPrice();
            Tiger.ChangeBuyingPrice();
        }

        void AddMethodsToDel()
        {
            Delegates.ChangeValues += ChangeStats;
            Delegates.ChangeValues += AddMoneyFromAnimal;
        }
        void RemoveMethodsToDel()
        {
            Delegates.ChangeValues -= ChangeStats;
            Delegates.ChangeValues -= AddMoneyFromAnimal;
        }


        #region Actions

        #region Lvlup
        public void Lvlup()
        {
            if (IsAlive == false)
                return;

            if (Zoo.Money > LvlupPrice)
            {
                Zoo.Money -= LvlupPrice;
                Lvl++;
            }
        }
        #endregion

        #region Curing
        public void Curing()
        {
            if (IsAlive == false)
                return;

            if (Zoo.Money > 100)
            {
                Zoo.Money -= 100;
                Helth += (int)(0.2 * MaxHelth);
            }
            
        }
        #endregion

        #region Feeding
        public void Feeding()
        {
            if (IsAlive == false)
                return;

            if (Zoo.Money > 50)
            {
                Zoo.Money -= 50;
                Satiety += (int)(0.2 * MaxSatiety);
            }            
        }
        #endregion

        #region Cleaning
        public void Cleaning()
        {
            if (IsAlive == false)
                return;
        }
        #endregion

        #region Kill
        public void Kill()
        {
            if (IsAlive == false)
                return;

            IsAlive = false;
        }
        #endregion

        #endregion

        #endregion


        #region Economics
        protected abstract ulong BuyingPrice { get; }
        protected abstract int ProfitPerLvl { get; }
        protected abstract float PriceIncreaseModifier { get; }

        public ulong LvlupPrice;

        public abstract ulong NewLvlPrice();

        void AddMoneyFromAnimal()
        {
            Zoo.Money += (ulong)(Lvl * ProfitPerLvl * MultiplierPerLvl);
        }

        #endregion
    }
}