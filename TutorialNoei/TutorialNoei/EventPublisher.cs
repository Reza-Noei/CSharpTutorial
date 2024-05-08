using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialNoei
{
    public delegate void MyEventHandler(object sender, EventArgs args);

    internal class EventPublisher
    {
        public object lockobject = new object();
        
        public event MyEventHandler MyEvent;

        public MyEventHandler MyEventDelegate;

        private MyEventHandler _myEvent2;
        public event MyEventHandler MyEvent2
        {
            // Lock-Free thread safe
            add { _myEvent2 += value; }
            remove { _myEvent2 -= value; }
        }
    }

    public class EventSubscriber
    {
        public EventSubscriber()
        {
            //Program.MyEvent = null;
            //Program.MyEvent = myCustomSetOfDelegates;
            //Program.MyEvent.Invoke();
        }

        private void A_MyEvent(object sender, EventArgs args)
        {
            ///dasdsad
        }
    }
}
