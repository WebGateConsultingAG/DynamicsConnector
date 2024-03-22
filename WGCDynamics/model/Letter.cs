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

namespace WebGate.Dynamics.Model
{
    #pragma warning disable IDE1006 // Benennungsstile
    public class Letter
    {
        public string activityid { get; set; }
        public string actualdurationminutes { get; set; }
        public DateTime? actualend { get; set; }
        public DateTime? actualstart { get; set; }
        public string address { get; set; }
        public string category { get; set; }
        public DateTime? createdon { get; set; }
        public string description { get; set; }
        public bool? directioncode { get; set; }
        public double? exchangerate { get; set; }
        public int? importsequencenumber { get; set; }
        public bool? isbilled { get; set; }
        public bool? isregularactivity { get; set; }
        public bool? isworkflowcreated { get; set; }
        public DateTime? lastonholdtime { get; set; }
        public DateTime? modifiedon { get; set; }
        public int? onholdtime { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public int? prioritycode { get; set; }
        public string processid { get; set; }
        public int? scheduleddurationminutes { get; set; }
        public DateTime? scheduledend { get; set; }
        public DateTime? scheduledstart { get; set; }
        public DateTime? sortdate { get; set; }
        public string stageid { get; set; }
        public int? statecode { get; set; }
        public int? statuscode { get; set; }
        public string subcategory { get; set; }
        public string subject { get; set; }
        public string subscriptionid { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string traversedpath { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public long? versionnumber { get; set; }
    }
}
