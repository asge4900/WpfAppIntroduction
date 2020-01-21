using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppIntroduction.Core
{
    /// <summary>
    /// The severity of the log message
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Developer-specific information
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Verbose information
        /// </summary>
        Verbose,

        /// <summary>
        /// General information
        /// </summary>
        Informative,

        /// <summary>
        /// A warning
        /// </summary>
        Warning,

        /// <summary>
        /// An error
        /// </summary>
        Error,

        /// <summary>
        /// A success
        /// </summary>
        Success
    }
}
