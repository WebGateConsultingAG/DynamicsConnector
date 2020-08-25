/*
 * Copyright WebGate Consulting AG, 2020
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at:
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
 * implied. See the License for the specific language governing
 * permissions and limitations under the License.
 *
 */
using System;

namespace WGCDynamics.model
{
    #pragma warning disable IDE1006 // Benennungsstile
    public class Team
    {
        public string azureactivedirectoryobjectid { get; set; }
        public DateTime? createdon { get; set; }
        public string description { get; set; }
        public string emailaddress { get; set; }
        public double? exchangerate { get; set; }
        public int? importsequencenumber { get; set; }
        public bool? isdefault { get; set; }
        public int? membershiptype { get; set; }
        public DateTime? modifiedon { get; set; }
        public string name { get; set; }
        public string organizationid { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string processid { get; set; }
        public string stageid { get; set; }
        public bool? systemmanaged { get; set; }
        public string teamid { get; set; }
        public int? teamtype { get; set; }
        public string traversedpath { get; set; }
        public long? versionnumber { get; set; }
    }
}
