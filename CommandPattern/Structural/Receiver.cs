using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Structural
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
