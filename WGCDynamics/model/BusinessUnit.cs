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
    public class BusinessUnit
    {
        public string address1_addressid { get; set; }
        public int? address1_addresstypecode { get; set; }
        public string address1_city { get; set; }
        public string address1_country { get; set; }
        public string address1_county { get; set; }
        public string address1_fax { get; set; }
        public double? address1_latitude { get; set; }
        public string address1_line1 { get; set; }
        public string address1_line2 { get; set; }
        public string address1_line3 { get; set; }
        public double? address1_longitude { get; set; }
        public string address1_name { get; set; }
        public string address1_postalcode { get; set; }
        public string address1_postofficebox { get; set; }
        public int? address1_shippingmethodcode { get; set; }
        public string address1_stateorprovince { get; set; }
        public string address1_telephone1 { get; set; }
        public string address1_telephone2 { get; set; }
        public string address1_telephone3 { get; set; }
        public string address1_upszone { get; set; }
        public string address1_utcoffset { get; set; }
        public string address2_addressid { get; set; }
        public int? address2_addresstypecode { get; set; }
        public string address2_city { get; set; }
        public string address2_country { get; set; }
        public string address2_county { get; set; }
        public string address2_fax { get; set; }
        public double? address2_latitude { get; set; }
        public string address2_line1 { get; set; }
        public string address2_line2 { get; set; }
        public string address2_line3 { get; set; }
        public double? address2_longitude { get; set; }
        public string address2_name { get; set; }
        public string address2_postalcode { get; set; }
        public string address2_postofficebox { get; set; }
        public int? address2_shippingmethodcode { get; set; }
        public string address2_stateorprovince { get; set; }
        public string address2_telephone1 { get; set; }
        public string address2_telephone2 { get; set; }
        public string address2_telephone3 { get; set; }
        public string address2_upszone { get; set; }
        public string address2_utcoffset { get; set; }
        public string businessunitid { get; set; }
        public string costcenter { get; set; }
        public DateTime? createdon { get; set; }
        public double? creditlimit { get; set; }
        public string description { get; set; }
        public string disabledreason { get; set; }
        public string divisionname { get; set; }
        public string emailaddress { get; set; }
        public double? exchangerate { get; set; }
        public string fileasname { get; set; }
        public int? importsequencenumber { get; set; }
        public int? inheritancemask { get; set; }
        public bool? isdisabled { get; set; }
        public DateTime? modifiedon { get; set; }
        public string name { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string picture { get; set; }
        public string stockexchange { get; set; }
        public string tickersymbol { get; set; }
        public string usergroupid { get; set; }
        public string utcoffset { get; set; }
        public long? versionnumber { get; set; }
        public bool? workflowsuspended { get; set; }
    }
}
