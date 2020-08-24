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
    public class List
    {
        public string cost { get; set; }
        public string cost_base { get; set; }
        public int? createdfromcode { get; set; }
        public DateTime? createdon { get; set; }
        public string description { get; set; }
        public bool? donotsendonoptout { get; set; }
        public double? exchangerate { get; set; }
        public bool? ignoreinactivelistmembers { get; set; }
        public int? importsequencenumber { get; set; }
        public DateTime? lastusedon { get; set; }
        public string listid { get; set; }
        public string listname { get; set; }
        public bool? lockstatus { get; set; }
        public int? membercount { get; set; }
        public int? membertype { get; set; }
        public DateTime? modifiedon { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public int? processedmembercount { get; set; }
        public string processfetchxml { get; set; }
        public string processid { get; set; }
        public string purpose { get; set; }
        public string query { get; set; }
        public string source { get; set; }
        public string stageid { get; set; }
        public int? statecode { get; set; }
        public int? statuscode { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string traversedpath { get; set; }
        public bool? type { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public long? versionnumber { get; set; }
    }
}
