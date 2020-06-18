using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        private string deneme;
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public string Notify()
        {
            foreach (Observer o in _observers)
            {
               deneme=o.Update();
            }
            return deneme;
        }
    }
    class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }
    abstract class Observer
    {
        public abstract string Update();
    }
    class ConcreteObserver : Observer
    {      
        private string _observerState="Order Not Ready!!";

        public ConcreteObserver(ConcreteSubject subject)
        {
            Subject = subject;
        }

        public override string Update()
        {
            if(Subject.SubjectState != null)
            {
                _observerState = Subject.SubjectState;
            }
            return string.Format("{0}:{1}",
              _observerState,Personnel.customerName);
        }
        public ConcreteSubject Subject { get; set; }
    }
}
