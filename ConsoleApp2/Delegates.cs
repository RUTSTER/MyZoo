using System;

namespace ConsoleApp2
{
    public class Delegates
    {
        public Action ChangeValues = () => { };
        public Action ShowNewData = () => { };       
        
        public void Invoke()
        {
            ChangeValues.Invoke();
            ShowNewData.Invoke();
        }
    }
}