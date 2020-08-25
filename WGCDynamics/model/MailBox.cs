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
    public class MailBox
    {
        public int? actdeliverymethod { get; set; }
        public int? actstatus { get; set; }
        public bool? allowemailconnectortousecredentials { get; set; }
        public int? averagetotalduration { get; set; }
        public DateTime? createdon { get; set; }
        public string emailaddress { get; set; }
        public int? emailrouteraccessapproval { get; set; }
        public bool? enabledforact { get; set; }
        public bool? enabledforincomingemail { get; set; }
        public bool? enabledforoutgoingemail { get; set; }
        public DateTime? exchangecontactsimportcompletedon { get; set; }
        public int? exchangecontactsimportstatus { get; set; }
        public string exchangesyncstatexml { get; set; }
        public string folderhierarchy { get; set; }
        public int? forcedunlockcount { get; set; }
        public string hostid { get; set; }
        public int? incomingemaildeliverymethod { get; set; }
        public int? incomingemailstatus { get; set; }
        public bool? isactsyncorgflagset { get; set; }
        public bool? isemailaddressapprovedbyo365admin { get; set; }
        public bool? isexchangecontactsimportscheduled { get; set; }
        public bool? isforwardmailbox { get; set; }
        public bool? isoauthaccesstokenset { get; set; }
        public bool? isoauthrefreshtokenset { get; set; }
        public bool? ispasswordset { get; set; }
        public bool? isserviceaccount { get; set; }
        public int? itemsfailedforlastsync { get; set; }
        public int? itemsprocessedforlastsync { get; set; }
        public DateTime? lastactiveon { get; set; }
        public DateTime? lastautodiscoveredon { get; set; }
        public int? lastduration { get; set; }
        public DateTime? lastmailboxforcedunlockoccurredon { get; set; }
        public string lastmessageid { get; set; }
        public DateTime? lastsuccessfulsynccompletedon { get; set; }
        public string lastsyncerror { get; set; }
        public int? lastsyncerrorcode { get; set; }
        public int? lastsyncerrorcount { get; set; }
        public string lastsyncerrormachinename { get; set; }
        public DateTime? lastsyncerroroccurredon { get; set; }
        public DateTime? lastsyncstartedon { get; set; }
        public string mailboxid { get; set; }
        public int? mailboxprocessingcontext { get; set; }
        public int? mailboxstatus { get; set; }
        public DateTime? modifiedon { get; set; }
        public string name { get; set; }
        public int? noactcount { get; set; }
        public int? noemailcount { get; set; }
        public string oauthaccesstoken { get; set; }
        public string oauthrefreshtoken { get; set; }
        public DateTime? oauthtokenexpireson { get; set; }
        public DateTime? officeappsdeploymentcompleteon { get; set; }
        public string officeappsdeploymenterror { get; set; }
        public bool? officeappsdeploymentscheduled { get; set; }
        public int? officeappsdeploymentstatus { get; set; }
        public bool? orgmarkedasprimaryforexchangesync { get; set; }
        public int? outgoingemaildeliverymethod { get; set; }
        public int? outgoingemailstatus { get; set; }
        public string ownerid { get; set; }
        public string password { get; set; }
        public DateTime? postponemailboxprocessinguntil { get; set; }
        public DateTime? postponeofficeappsdeploymentuntil { get; set; }
        public DateTime? postponesendinguntil { get; set; }
        public DateTime? postponetestemailconfigurationuntil { get; set; }
        public bool? processanddeleteemails { get; set; }
        public int? processedtimes { get; set; }
        public DateTime? processemailreceivedafter { get; set; }
        public DateTime? processinglastattemptedon { get; set; }
        public int? processingstatecode { get; set; }
        public DateTime? receivingpostponeduntil { get; set; }
        public DateTime? receivingpostponeduntilforact { get; set; }
        public int? statecode { get; set; }
        public int? statuscode { get; set; }
        public int? testemailconfigurationretrycount { get; set; }
        public bool? testemailconfigurationscheduled { get; set; }
        public DateTime? testmailboxaccesscompletedon { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public int? transientfailurecount { get; set; }
        public string undeliverablefolder { get; set; }
        public string username { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public int? verboseloggingenabled { get; set; }
        public long? versionnumber { get; set; }
    }
}
