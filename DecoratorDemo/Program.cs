using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace DecoratorDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var container = new Container();
			var serviceProvider = new ServiceCollection()
				.AddSimpleInjector(container)
				.AddServices()
				.BuildServiceProvider()
				.UseSimpleInjector(container);

			var command = serviceProvider.GetRequiredService<ICommandHandler<FooCommand>>();
			command.Handle(new FooCommand());
		}
	}

	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			// *********** Can NOT Decorate ***********
			return services
				.AddTransient(typeof(ICommandHandler<>), typeof(CommandHandler<>))
				.Decorate(typeof(ICommandHandler<>), typeof(CommandHandlerDecorator<>));

			// *********** Can Decorate ***********
			//return services
			//	.AddTransient<ICommandHandler<FooCommand>, CommandHandler<FooCommand>>()
			//	.Decorate(typeof(ICommandHandler<>), typeof(CommandHandlerDecorator<>));
		}
	}
}
