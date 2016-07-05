﻿using System;

namespace Elmah.Io.Client
{
    public partial interface IMessages
    {
        /// <summary>
        /// Write a log message with the Verbose severity.
        /// </summary>
        void Verbose(Guid logId, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Verbose severity and associated exception.
        /// </summary>
        void Verbose(Guid logId, Exception exception, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Debug severity.
        /// </summary>
        void Debug(Guid logId, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Debug severity and associated exception.
        /// </summary>
        void Debug(Guid logId, Exception exception, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Information severity.
        /// </summary>
        void Information(Guid logId, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Information severity and associated exception.
        /// </summary>
        void Information(Guid logId, Exception exception, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Warning severity.
        /// </summary>
        void Warning(Guid logId, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Warning severity and associated exception.
        /// </summary>
        void Warning(Guid logId, Exception exception, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Error severity.
        /// </summary>
        void Error(Guid logId, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Error severity and associated exception.
        /// </summary>
        void Error(Guid logId, Exception exception, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Fatal severity.
        /// </summary>
        void Fatal(Guid logId, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Write a log message with the Verbose Fatal and associated exception.
        /// </summary>
        void Fatal(Guid logId, Exception exception, string messageTemplate, params object[] propertyValues);

        void Log(Guid logId, Exception exception, Severity severity, string messageTemplate, params object[] propertyValues);
    }
}