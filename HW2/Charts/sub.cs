using System.Collections.Generic;


namespace HW2.Charts
{
    internal class sub
    {
        private List<Observer> observers1 = new List<Observer>();

        public void Attach(Observer ob)
        {
            observers1.Add(ob);
        }

        public void Deattach(Observer ob)
        {
            observers1.Remove(ob);
        }

        public void Notify()
        {
            foreach (Observer ob in observers1)
            {
                ob.Update();
            }
        }
    }
}
