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
    public class Territory
    {
        public DateTime? createdon { get; set; }
        public string description { get; set; }
        public double? exchangerate { get; set; }
        public int? importsequencenumber { get; set; }
        public DateTime? modifiedon { get; set; }
        public string name { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string territoryid { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public long? versionnumber { get; set; }
    }
}
