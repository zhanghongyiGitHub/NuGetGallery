﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGetGallery.Configuration
{
    /// <summary>
    /// Configuration values related to Service Bus integration.
    /// </summary>
    public interface IServiceBusConfiguration
    {
        /// <summary>
        /// The connection string to use when connecting to the validation topic. This connection string should not
        /// contain the topic name as the name is explicitly specified by <see cref="Validation_TopicName"/>. This
        /// connection string only needs to have the "Send" privilege. This topic is used for requesting asynchronous
        /// validation of packages.
        /// </summary>
        string Validation_ConnectionString { get; set; }

        /// <summary>
        /// The name of the Azure Service Bus topic to send validation messages to. This topic name is used at the same
        /// time as the <see cref="Validation_ConnectionString"/>.
        /// </summary>
        string Validation_TopicName { get; set; }
    }
}