// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent
{

    /// <summary>
    /// Fluent interface that allows global logging settings to be configured.
    /// </summary>
    public interface ILoggingConfigurationOptions : ILoggingConfigurationContd, IFluentInterface
    {
        /// <summary>
        /// Disables tracing in the configuration schema. <br/>
        /// Tracing is enabled by deault.
        /// </summary>
        ILoggingConfigurationOptions DisableTracing();

        /// <summary>
        /// Disables temporarily reverting impersonation when logging. <br/>
        /// Impersonation is temporarily reverted by default.
        /// </summary>
        ILoggingConfigurationOptions DoNotRevertImpersonation();

        /// <summary>
        /// Specifies that no warnings should be logged for non-existant categories. <br/>
        /// Warnings are logged for non-existant categories by default.
        /// </summary>
        ILoggingConfigurationOptions DoNotLogWarningsWhenNoCategoryExists();
    }
}
