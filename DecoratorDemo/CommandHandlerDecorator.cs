using System.Windows.Input;

namespace DecoratorDemo
{
	internal class CommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
		where TCommand : ICommand
	{
        private readonly ICommandHandler<TCommand> _decorated;

        public CommandHandlerDecorator(ICommandHandler<TCommand> decorated)
        {
			_decorated = decorated;
		}

        public void Handle(TCommand command)
		{
			_decorated.Handle(command);
		}
	}
}
