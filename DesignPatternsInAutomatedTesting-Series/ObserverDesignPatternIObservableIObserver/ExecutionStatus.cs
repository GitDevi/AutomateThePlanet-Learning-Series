﻿// <copyright file="ExecutionStatus.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternsInAutomatedTests.Advanced.Observer.Advanced.ObservableObserver.Enums;

namespace ObserverDesignPatternIObservableIObserver
{
    public class ExecutionStatus
    {
        public TestContext TestContext { get; set; }

        public MemberInfo MemberInfo { get; set; }
        
        public ExecutionPhases ExecutionPhase { get; set; }

        public ExecutionStatus(TestContext testContext, ExecutionPhases executionPhase) : this(testContext, null, executionPhase)
        {
        }

        public ExecutionStatus(TestContext testContext, MemberInfo memberInfo, ExecutionPhases executionPhase)
        {
            this.TestContext = testContext;
            this.MemberInfo = memberInfo;
            this.ExecutionPhase = executionPhase;
        }
    }
}