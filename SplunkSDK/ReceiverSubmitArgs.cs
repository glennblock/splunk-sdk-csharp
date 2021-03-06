﻿/*
 * Copyright 2013 Splunk, Inc.
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

namespace Splunk
{
    /// <summary>
    /// The <see cref="ReceiverSubmitArgs"/> class extends <see cref="Args"/> for
    /// using the <see cref="Receiver.Submit(ReceiverSubmitArgs, string)" /> class.
    /// </summary>
    public class ReceiverSubmitArgs : Args
    {
        /// <summary>
        /// Sets a value to populate the host field for inputs from this data 
        /// input. 
        /// </summary>
        public string Host
        {
            set
            {
                this["host"] = value;
            }
        }

        /// <summary>
        /// Sets a regular expression or a file path. 
        /// </summary>
        /// <remarks>
        /// If the path for a file matches this regular expression, the 
        /// captured value is used to populate the host field for events from
        /// this data input. The regular expression must have one capture 
        /// group.
        /// </remarks>
        public string HostRegex
        {
            set
            {
                this["host_regex"] = value;
            }
        }

        /// <summary>
        /// Sets the index for the events generated by this data input. 
        /// </summary>
        /// <remarks>
        /// This property's default value is "default".
        /// </remarks>
        public string Index
        {
            set
            {
                this["index"] = value;
            }
        }

        /// <summary>
        /// Sets a value to populate the source for inputs from this data 
        /// input.
        /// </summary>
        public string Source
        {
            set
            {
                this["source"] = value;
            }
        }

        /// <summary>
        /// Sets a value to populate the source type for inputs from this data 
        /// input.
        /// </summary>
        public string SourceType
        {
            set
            {
                this["sourcetype"] = value;
            }
        }
    }
}
  
