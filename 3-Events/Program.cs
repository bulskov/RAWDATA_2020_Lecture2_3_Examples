using System;
using System.Collections.Generic;

namespace _3_Events
{

    interface IObserver
    {
        void Update(string data);
    }

    class Subject
    {
        //public delegate void DataChangeHandler(string data);
        public event EventHandler<string> DataChanged;


        public void Notify(string data)
        {
            if (DataChanged != null)
                DataChanged(this, data);

        }

        //List<IObserver> _subscribers = new List<IObserver>();

        //public void Subscribe(IObserver obs)
        //{
        //    _subscribers.Add(obs);
        //}

        //public void Notify(string data)
        //{
        //    foreach (var subscriber in _subscribers)
        //    {
        //        subscriber.Update(data);
        //    }
        //}
    }

    class MyObserver 
    {
        public void Update(object sender, string data)
        {
            Console.WriteLine(data);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var myObserver = new MyObserver();

            var subject = new Subject();

            subject.DataChanged += myObserver.Update;
            subject.DataChanged += (sender, data) => Console.WriteLine("Lambda:" + data);


            //subject.Subscribe(new MyObserver());
            //subject.Subscribe(new MyObserver());
            //subject.Subscribe(new MyObserver());


            subject.Notify("something happen");

        }
    }
}
