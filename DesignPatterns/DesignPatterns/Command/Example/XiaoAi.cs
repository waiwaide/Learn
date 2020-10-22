using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.Example
{
    class XiaoAi
    {
        private readonly List<ICommand> commands= new List<ICommand>();

        

        internal void SetCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
