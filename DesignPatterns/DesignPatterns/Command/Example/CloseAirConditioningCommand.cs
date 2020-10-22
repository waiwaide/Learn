using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.Example
{
    class CloseAirConditioningCommand : ICommand
    {
        private AirConditioningReceiver airConditioningInvoker = new AirConditioningReceiver();
       internal CloseAirConditioningCommand(AirConditioningReceiver airConditioningInvoker)
        {
            this.airConditioningInvoker = airConditioningInvoker;
        }
        public void Execute()
        {
            airConditioningInvoker.Close();
        }
    }
}
