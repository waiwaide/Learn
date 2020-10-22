using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.state
{
    class Context
    {
        private State state;

        internal Context(State state)
        {
            this.State = state;
        }

        internal State State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                Console.WriteLine("State:"+state.GetType().Name);
            }
        }

        internal void Requset()
        {
            state.Handle(this);
        }
    }
}
