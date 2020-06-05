using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Dacia;
using R5T.Larissa;


namespace R5T.Southampton.Larissa
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SvnSourceControlOperator"/> implementation of <see cref="ISourceControlOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSvnSourceControlOperator(this IServiceCollection services,
            IServiceAction<ISvnOperator> svnOperatorAction,
            IServiceAction<ISvnversionOperator> svnversionOperatorAction,
            IServiceAction<ILogger> loggerAction)
        {
            services
                .AddSingleton<ISourceControlOperator, SvnSourceControlOperator>()
                .Run(svnOperatorAction)
                .Run(svnversionOperatorAction)
                .Run(loggerAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SvnSourceControlOperator"/> implementation of <see cref="ISourceControlOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISourceControlOperator> AddSvnSourceControlOperatorAction(this IServiceCollection services,
            IServiceAction<ISvnOperator> svnOperatorAction,
            IServiceAction<ISvnversionOperator> svnversionOperatorAction,
            IServiceAction<ILogger> loggerAction)
        {
            var serviceAction = ServiceAction<ISourceControlOperator>.New(() => services.AddSvnSourceControlOperator(
                svnOperatorAction,
                svnversionOperatorAction,
                loggerAction));

            return serviceAction;
        }
    }
}
