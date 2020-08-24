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
    public class Contact
    {
        public int? accountrolecode { get; set; }
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
        public string address3_addressid { get; set; }
        public int? address3_addresstypecode { get; set; }
        public string address3_city { get; set; }
        public string address3_composite { get; set; }
        public string address3_country { get; set; }
        public string address3_county { get; set; }
        public string address3_fax { get; set; }
        public Account parent_contactid { get; set; }
        public int? address3_freighttermscode { get; set; }
        public double? address3_latitude { get; set; }
        public string address3_line1 { get; set; }
        public string address3_line2 { get; set; }
        public string address3_line3 { get; set; }
        public double? address3_longitude { get; set; }
        public string address3_name { get; set; }
        public string address3_postalcode { get; set; }
        public string address3_postofficebox { get; set; }
        public string address3_primarycontactname { get; set; }
        public int? address3_shippingmethodcode { get; set; }
        public string address3_stateorprovince { get; set; }
        public string address3_telephone1 { get; set; }
        public string address3_telephone2 { get; set; }
        public string address3_telephone3 { get; set; }
        public string address3_upszone { get; set; }
        public string address3_utcoffset { get; set; }
        public DateTime? anniversary { get; set; }
        public string assistantname { get; set; }
        public string assistantphone { get; set; }
        public DateTime? birthdate { get; set; }
        public string business2 { get; set; }
        public string businesscard { get; set; }
        public string businesscardattributes { get; set; }
        public string callback { get; set; }
        public string childrensnames { get; set; }
        public string company { get; set; }
        public SystemUser owninguser { get; set; }
        public string contactid { get; set; }
        public DateTime? createdon { get; set; }
        public bool? creditonhold { get; set; }
        public int? customersizecode { get; set; }
        public int? customertypecode { get; set; }
        public string department { get; set; }
        public string description { get; set; }
        public bool? donotbulkemail { get; set; }
        public bool? donotbulkpostalmail { get; set; }
        public bool? donotemail { get; set; }
        public bool? donotfax { get; set; }
        public bool? donotphone { get; set; }
        public bool? donotpostalmail { get; set; }
        public bool? donotsendmm { get; set; }
        public int? educationcode { get; set; }
        public string emailaddress1 { get; set; }
        public string emailaddress2 { get; set; }
        public string emailaddress3 { get; set; }
        public string employeeid { get; set; }
        public double? exchangerate { get; set; }
        public string externaluseridentifier { get; set; }
        public int? familystatuscode { get; set; }
        public string fax { get; set; }
        public string firstname { get; set; }
        public bool? followemail { get; set; }
        public string fullname { get; set; }
        public int? gendercode { get; set; }
        public string governmentid { get; set; }
        public int? haschildrencode { get; set; }
        public string home2 { get; set; }
        public int? importsequencenumber { get; set; }
        public bool? isautocreate { get; set; }
        public bool? isbackofficecustomer { get; set; }
        public bool? isprivate { get; set; }
        public string jobtitle { get; set; }
        public string lastname { get; set; }
        public DateTime? lastonholdtime { get; set; }
        public DateTime? lastusedincampaign { get; set; }
        public int? leadsourcecode { get; set; }
        public string managername { get; set; }
        public string managerphone { get; set; }
        public bool? marketingonly { get; set; }
        public bool? merged { get; set; }
        public string middlename { get; set; }
        public string mobilephone { get; set; }
        public DateTime? modifiedon { get; set; }
        public bool? msdyn_gdproptout { get; set; }
        public int? msdyn_orgchangestatus { get; set; }
        public string nickname { get; set; }
        public int? numberofchildren { get; set; }
        public int? onholdtime { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public string pager { get; set; }
        public string parentcustomerid { get; set; }
        public bool? participatesinworkflow { get; set; }
        public int? paymenttermscode { get; set; }
        public int? preferredappointmentdaycode { get; set; }
        public int? preferredappointmenttimecode { get; set; }
        public int? preferredcontactmethodcode { get; set; }
        public string processid { get; set; }
        public string salutation { get; set; }
        public int? shippingmethodcode { get; set; }
        public string spousesname { get; set; }
        public string stageid { get; set; }
        public int? statecode { get; set; }
        public int? statuscode { get; set; }
        public string subscriptionid { get; set; }
        public string suffix { get; set; }
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
