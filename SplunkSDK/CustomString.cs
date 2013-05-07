﻿/*
 * Copyright 2012 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System;

namespace Splunk
{
    /// <summary>
    /// The <see cref="CustomString"/> class represents an <see cref="Attribute"/>
    /// for custom Enum strings.
    /// </summary>
    internal class CustomString : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomString" /> class.
        /// </summary>
        /// <param name="value">The value of the custom string.</param>
        public CustomString(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value of the custom string.
        /// </summary>
        public string Value { get; private set; }
    }
}
