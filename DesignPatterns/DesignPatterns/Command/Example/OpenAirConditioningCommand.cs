using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.Example
{
    class OpenAirConditioningCommand: ICommand
    {
        private AirConditioningReceiver airConditioningInvoker = new AirConditioningReceiver();
       public OpenAirConditioningCommand(AirConditioningReceiver airConditioningInvoker)
        {
            this.airConditioningInvoker = airConditioningInvoker;
        }
        public void Execute()
        {
            airConditioningInvoker.Open();
        }
    }
}
