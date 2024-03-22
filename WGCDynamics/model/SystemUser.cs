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
    public class SystemUser
    {
        public int? accessmode { get; set; }
        public string activedirectoryguid { get; set; }
        public string address1_addressid { get; set; }
        public int? address1_addresstypecode { get; set; }
        public string address1_city { get; set; }
        public string address1_composite { get; set; }
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
        public string address2_composite { get; set; }
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
        public string applicationid { get; set; }
        public string applicationiduri { get; set; }
        public string azureactivedirectoryobjectid { get; set; }
        public int? caltype { get; set; }
        public DateTime? createdon { get; set; }
        public bool? defaultfilterspopulated { get; set; }
        public string defaultodbfoldername { get; set; }
        public string disabledreason { get; set; }
        public bool? displayinserviceviews { get; set; }
        public string domainname { get; set; }
        public int? emailrouteraccessapproval { get; set; }
        public string employeeid { get; set; }
        public double? exchangerate { get; set; }
        public string firstname { get; set; }
        public string fullname { get; set; }
        public string governmentid { get; set; }
        public string homephone { get; set; }
        public int? identityid { get; set; }
        public int? importsequencenumber { get; set; }
        public int? incomingemaildeliverymethod { get; set; }
        public string internalemailaddress { get; set; }
        public int? invitestatuscode { get; set; }
        public bool? isactivedirectoryuser { get; set; }
        public bool? isdisabled { get; set; }
        public bool? isemailaddressapprovedbyo365admin { get; set; }
        public bool? isintegrationuser { get; set; }
        public bool? islicensed { get; set; }
        public bool? issyncwithdirectory { get; set; }
        public string jobtitle { get; set; }
        public string lastname { get; set; }
        public DateTime? latestupdatetime { get; set; }
        public string middlename { get; set; }
        public string mobilealertemail { get; set; }
        public string mobilephone { get; set; }
        public DateTime? modifiedon { get; set; }
        public bool? msdyn_gdproptout { get; set; }
        public string nickname { get; set; }
        public object organizationid{get; set;}
        public int? outgoingemaildeliverymethod { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public int? passporthi { get; set; }
        public int? passportlo { get; set; }
        public string personalemailaddress { get; set; }
        public int? preferredaddresscode { get; set; }
        public int? preferredemailcode { get; set; }
        public int? preferredphonecode { get; set; }
        public string processid { get; set; }
        public string salutation { get; set; }
        public bool? setupuser { get; set; }
        public string sharepointemailaddress { get; set; }
        public string skills { get; set; }
        public string stageid { get; set; }
        public string systemuserid { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string title { get; set; }
        public string traversedpath { get; set; }
        public int? userlicensetype { get; set; }
        public string userpuid { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public long? versionnumber { get; set; }
        public string windowsliveid { get; set; }
        public string yammeremailaddress { get; set; }
        public string yammeruserid { get; set; }
    }
}
