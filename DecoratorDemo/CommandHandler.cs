using System.Windows.Input;

namespace DecoratorDemo
{
	public class CommandHandler<TCommand> : ICommandHandler<TCommand>
		where TCommand : ICommand
	{
        public void Handle(TCommand command)
		{
			command.Execute(null);
		}
	}
}
