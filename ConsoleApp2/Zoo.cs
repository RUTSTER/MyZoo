using System;
using System.Timers;
using System.Media;
using static System.Math;

namespace ConsoleApp2
{

    public class Zoo
    {
        #region Properties
        private Timer TimerMain;

        private MainForm MainFormRef;
        private CagesSystem Cages;

        private Delegates Delegates = new Delegates();
        #endregion


        #region Constructor
        public Zoo()
        {
            Delegates.ShowNewData += RefreshLabelsInForm;
            SetTimer();
        }
        #endregion    


        #region Methods

        void RefreshLabelsInForm()
        {
            MainFormRef.RefreshMoneyLabel(Zoo.ConvertMoney(Zoo.Money));
            MainFormRef.RefreshNewCagePriceLabel(Zoo.ConvertMoney(Cages.NextCagePrice));

        }

        public void CreateNewCage() => Cages.CreateNewCage();

        public void SetReference(MainForm MainFormRef) => this.MainFormRef = MainFormRef;

        public void InitializeComponent()
        {
            Cages = new CagesSystem(MainFormRef, Delegates);
        }

        #region Actions
        public void Lvlup() => Cages.Lvlup();

        public void Curing() => Cages.Curing();

        public void Feeding() => Cages.Feeding();

        public void Cleaning() => Cages.Cleaning();

        public void Kill() => Cages.Kill();
        #endregion

        #endregion


        #region Timer
        private void SetTimer()
        {
            TimerMain = new Timer(1000);
            TimerMain.Elapsed += Timer_Handler;
            TimerMain.Start();
        }

        private void Timer_Handler(object sender, ElapsedEventArgs e)
        {
            Delegates.Invoke();
        }
        #endregion

        
        #region Static

        #region Money

        #region Property
        private static ulong money = 5;
        public static ulong Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                money = value;
            }
        }
        #endregion

        #region ConvertMethod       
        public static string ConvertMoney(ulong value)
        {
            switch (value.ToString().Length)
            {
                case int n when n <= 3:
                    return Convertation(0, "");

                case int n when n <= 6:
                    return Convertation(1, "K");

                case int n when n <= 9:
                    return Convertation(2, "M");

                case int n when n <= 12:
                    return Convertation(3, "B");

                case int n when n <= 15:
                    return Convertation(4, "T");

                case int n when n <= 18:
                    return Convertation(5, "q");

                case int n when n <= 21:
                    return Convertation(6, "Q");

                case int n when n <= 22:
                    return Convertation(6, "s");

                default:
                    return "<-->";
            }

            string Convertation(byte Thousands, string Abbreviation)
            {
                string result = (value / Pow(1000, Thousands)).ToString();

                if (result.Length > 3)
                    result = result.Substring(0, 3).TrimEnd(new char[] { ',' });

                return "$" + result + Abbreviation;
            }
        }
        #endregion

        #endregion


        #region Sounds
        public static readonly SoundPlayer PressSound = new SoundPlayer(Properties.Resources.PressSound);
        public static readonly SoundPlayer PutSound = new SoundPlayer(Properties.Resources.PutSound);
        public static readonly SoundPlayer SelectSound = new SoundPlayer(Properties.Resources.SelectSound);
        public static readonly SoundPlayer MoneySound = new SoundPlayer(Properties.Resources.MoneySound);
        #endregion
        

        #region рандомный костыль хД
        /// <summary>
        /// Хороший пример инкостыляции. Если не сделать задержку хотя бы такой(~10мс), то "рандом" будет выдавать 2 одинаковых значения. 
        /// Возможно, я не до конца разобрался в вопросе, и есть более элегантное решение, но я ничего лучше не нашел.
        /// </summary>        
        public static int RandomInt(int MaxValue)
        {
            System.Threading.Thread.Sleep(10);
            return new Random().Next(MaxValue);
        }
        #endregion

        #endregion 
    }
}
