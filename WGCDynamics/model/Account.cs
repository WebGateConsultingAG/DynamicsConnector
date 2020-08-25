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
    public class Account
    {
        public int? accountcategorycode { get; set; }
        public int? accountclassificationcode { get; set; }
        public string accountid { get; set; }
        public string accountnumber { get; set; }
        public int? accountratingcode { get; set; }
        public string address1_addressid { get; set; }
        public int? address1_addresstypecode { get; set; }
        public string address1_city { get; set; }
        public string address1_composite { get; set; }
        public string address1_country { get; set; }
        public string address1_county { get; set; }
        public string address1_fax { get; set; }
        public int? address1_freighttermscode { get; set; }
        public double? address1_latitude { get; set; }
        public string address1_line1 { get; set; }
        public string address1_line2 { get; set; }
        public string address1_line3 { get; set; }
        public double? address1_longitude { get; set; }
        public string address1_name { get; set; }
        public string address1_postalcode { get; set; }
        public string address1_postofficebox { get; set; }
        public string address1_primarycontactname { get; set; }
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
        public string address2_composite { get; set; }
        public string address2_country { get; set; }
        public string address2_county { get; set; }
        public string address2_fax { get; set; }
        public int? address2_freighttermscode { get; set; }
        public double? address2_latitude { get; set; }
        public string address2_line1 { get; set; }
        public string address2_line2 { get; set; }
        public string address2_line3 { get; set; }
        public double? address2_longitude { get; set; }
        public string address2_name { get; set; }
        public string address2_postalcode { get; set; }
        public string address2_postofficebox { get; set; }
        public string address2_primarycontactname { get; set; }
        public int? address2_shippingmethodcode { get; set; }
        public string address2_stateorprovince { get; set; }
        public string address2_telephone1 { get; set; }
        public string address2_telephone2 { get; set; }
        public string address2_telephone3 { get; set; }
        public string address2_upszone { get; set; }
        public string address2_utcoffset { get; set; }
        public int? businesstypecode { get; set; }
        public DateTime? createdon { get; set; } //?
        public bool? creditonhold { get; set; }
        public int? customersizecode { get; set; }
        public int? customertypecode { get; set; }
        public string description { get; set; }
        public bool? donotbulkemail { get; set; }
        public bool? donotbulkpostalmail { get; set; }
        public bool? donotemail { get; set; }
        public bool? donotfax { get; set; }
        public bool? donotphone { get; set; }
        public bool? donotpostalmail { get; set; }
        public bool? donotsendmm { get; set; }
        public double? exchangerate { get; set; }
        public string fax { get; set; }
        public bool? followemail { get; set; }
        public int? importsequencenumber { get; set; }
        public int? industrycode { get; set; }
        public bool? isprivate { get; set; }
        public DateTime? lastonholdtime { get; set; }
        public DateTime? lastusedincampaign { get; set; }
        public bool? marketingonly { get; set; }
        public bool? merged { get; set; }
        public DateTime? modifiedon { get; set; }
        public string name { get; set; }
        public int? numberofemployees { get; set; }
        public int? onholdtime { get; set; }
        public int? opendeals { get; set; }
        public DateTime? opendeals_date { get; set; }
        public int? opendeals_state { get; set; }
        public DateTime? openrevenue_date { get; set; }
        public int? openrevenue_state { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public int? ownershipcode { get; set; }
        public bool? participatesinworkflow { get; set; }
        public int? paymenttermscode { get; set; }
        public int? preferredappointmentdaycode { get; set; }
        public int? preferredappointmenttimecode { get; set; }
        public int? preferredcontactmethodcode { get; set; }
        public string primarysatoriid { get; set; }
        public string primarytwitterid { get; set; }
        public string processid { get; set; }
        public int? sharesoutstanding { get; set; }
        public int? shippingmethodcode { get; set; }
        public string sic { get; set; }
        public string stageid { get; set; }
        public int? statecode { get; set; }
        public int? statuscode { get; set; }
        public string stockexchange { get; set; }
        public int? teamsfollowed { get; set; }
        public string telephone1 { get; set; }
        public string telephone2 { get; set; }
        public string telephone3 { get; set; }
        public int? territorycode { get; set; }
        public string timespentbymeonemailandmeetings { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string traversedpath { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public long? versionnumber { get; set; }
    
    }
}
