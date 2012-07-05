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

namespace UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Splunk;

    [TestClass]
    public class StormTest : TestHelper
    {
        [TestMethod]
        public void TestMethod1()
        {
            // the storm token provided by Splunk
            Args loginArgs = new Args("StormToken",
                "p-n8SwuWEqPlyOXdDU4PjxavFdAn1CnJea9LirgTvzmIhMEBys6w7UJUCtxp_7g7Q9XopR5dW0w=");
            StormService stormService = StormService.Connect(loginArgs);

            // get the receiver object
            Receiver receiver = stormService.GetReceiver();

            // index and source type are required for storm event submission
            Args logArgs = new Args();
            logArgs.Add("index", "0e8a2df0834211e1a6fe123139335741");
            logArgs.Add("sourcetype", "yoursourcetype");

            // get the receiver object and post (aliased methods).
            receiver.Submit(logArgs, "This is a test from the SDK");
            receiver.Log(logArgs, "This is a test from the SDK, a second time");
        }
    }
}
