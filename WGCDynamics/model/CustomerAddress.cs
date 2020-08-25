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
    public class CustomerAddress
    {    
        public int? addressnumber { get; set; }
        public int? addresstypecode { get; set; }
        public string city { get; set; }
        public string composite { get; set; }
        public string country { get; set; }
        public string county { get; set; }
        public DateTime? createdon { get; set; }
        public string customeraddressid { get; set; }
        public double? exchangerate { get; set; }
        public string fax { get; set; }
        public int? freighttermscode { get; set; }
        public int? importsequencenumber { get; set; }
        public double? latitude { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public double? longitude { get; set; }
        public DateTime? modifiedon { get; set; }
        public string name { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public string postalcode { get; set; }
        public string postofficebox { get; set; }
        public string primarycontactname { get; set; }
        public int? shippingmethodcode { get; set; }
        public string stateorprovince { get; set; }
        public string telephone1 { get; set; }
        public string telephone2 { get; set; }
        public string telephone3 { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string upszone { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public DateTime? utcoffset { get; set; }
        public long versionnumber { get; set; }
    }
}
