using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Options;

namespace ZLogger
{
	public static class UnityLoggerFactory
	{
		private class LoggingConfiguration
		{
			public IConfiguration Configuration { get; }
		}

		private class LoggerProviderConfiguration<T> : ILoggerProviderConfiguration<T>
		{
			public IConfiguration Configuration { get; }

			public LoggerProviderConfiguration(ILoggerProviderConfigurationFactory providerConfigurationFactory)
			{
			}
		}

		private class LoggerProviderConfigurationFactory : ILoggerProviderConfigurationFactory
		{
			private readonly IEnumerable<LoggingConfiguration> _configurations;

			public LoggerProviderConfigurationFactory(IEnumerable<LoggingConfiguration> configurations)
			{
			}

			public IConfiguration GetConfiguration(Type providerType)
			{
				return null;
			}
		}

		private class LoggerProviderConfigureOptions<TOptions, TProvider> : ConfigureFromConfigurationOptions<TOptions> where TOptions : class
		{
			public LoggerProviderConfigureOptions(ILoggerProviderConfiguration<TProvider> providerConfiguration)
				: base((IConfiguration)null)
			{
			}
		}

		private static class ProviderAliasUtilities
		{
			internal static string GetAlias(Type providerType)
			{
				return null;
			}
		}

		private class DisposingLoggerFactory : ILoggerFactory, IDisposable
		{
			private readonly ILoggerFactory loggerFactory;

			private readonly IServiceProvider serviceProvider;

			public DisposingLoggerFactory(ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
			{
			}

			public void Dispose()
			{
			}

			public ILogger CreateLogger(string categoryName)
			{
				return null;
			}

			public void AddProvider(ILoggerProvider provider)
			{
				throw new NotImplementedException();
			}
		}

		public static ILoggerFactory Create(Action<ILoggingBuilder> configure)
		{
			return null;
		}

		private static void AddBeforeConfiguration(ILoggingBuilder builder)
		{
		}

		private static void AddAfterConfiguration(ILoggingBuilder builder)
		{
		}
	}
}
