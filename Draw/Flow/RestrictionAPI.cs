﻿/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class RestrictionAPI
    {
        /// <summary>
        /// Indicates that the restriction is enabled
        /// </summary>
        [DataMember]
        public bool enabled
        {
            get;
            set;
        }

        /// <summary>
        /// The list of countries that are permitted by the restriction.
        /// A single country must be represented as its 2-letter country code (according to ISO 3166-1 alpha-2)
        /// </summary>
        [DataMember]
        public string[] countries
        {
            get;
            set;
        }
        
        /// <summary>
        /// The list of continents that are permitted by the restriction
        /// A single contintent must be represetend as its 2-letter code.
        /// </summary>
        /// <remarks>
        /// AF 	Africa
        /// AN 	Antarctica
        /// AS 	Asia
        /// EU 	Europe
        /// NA 	North America
        /// OC 	Oceania
        /// SA 	South America
        /// Based on https://secure.php.net/manual/en/function.geoip-continent-code-by-name.php
        /// </remarks>
        [DataMember]
        public string[] continents
        {
            get;
            set;
        }
    }
}