﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.CosmosDB.Models
{
    using Microsoft.Azure.Management.CosmosDB.Models;

    public class PSThroughputSettingsGetResults
    {
        public PSThroughputSettingsGetResults()
        {
        }        
        
        public PSThroughputSettingsGetResults(ThroughputSettingsGetResults throughputSettingsGetResults)
        {
            Name = throughputSettingsGetResults.Name;
            Id = throughputSettingsGetResults.Id;
            Throughput = throughputSettingsGetResults.Throughput;
            MinimumThroughput = throughputSettingsGetResults.MinimumThroughput;
            OfferReplacePending = throughputSettingsGetResults.OfferReplacePending;
        }

        /// <summary>
        /// Gets or sets Name of the Cosmos DB resource throughput
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Id of the Cosmos DB resource throughput
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets value of the Cosmos DB resource throughput
        /// </summary>
        public int Throughput { get; set; }

        /// <summary>
        /// Gets the minimum throughput of the resource
        /// </summary>
        public string MinimumThroughput { get; set; }

        /// <summary>
        /// Gets the throughput replace is pending
        /// </summary>
        public string OfferReplacePending { get; set; }
    }
}