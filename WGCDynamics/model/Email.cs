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
    public class Email
    {
        public string activityadditionalparams { get; set; }
        public string activityid { get; set; }
        public int? actualdurationminutes { get; set; }
        public DateTime? actualend { get; set; }
        public DateTime? actualstart { get; set; }
        public int? attachmentcount { get; set; }
        public int? attachmentopencount { get; set; }
        public int? baseconversationindexhash { get; set; }
        public string category { get; set; }
        public bool? compressed { get; set; }
        public string conversationindex { get; set; }
        public string conversationtrackingid { get; set; }
        public int? correlationmethod { get; set; }
        public DateTime? createdon { get; set; }
        public DateTime? delayedemailsendtime { get; set; }
        public int? deliveryattempts { get; set; }
        public int? deliveryprioritycode { get; set; }
        public bool? deliveryreceiptrequested { get; set; }
        public string description { get; set; }
        public bool? directioncode { get; set; }
        public DateTime? emailreminderexpirytime { get; set; }
        public int? emailreminderstatus { get; set; }
        public string emailremindertext { get; set; }
        public int? emailremindertype { get; set; }
        public string emailtrackingid { get; set; }
        public double? exchangerate { get; set; }
        public bool? followemailuserpreference { get; set; }
        public int? importsequencenumber { get; set; }
        public string inreplyto { get; set; }
        public bool? isbilled { get; set; }
        public bool? isemailfollowed { get; set; }
        public bool? isemailreminderset { get; set; }
        public bool? isregularactivity { get; set; }
        public int? isunsafe { get; set; }
        public bool? isworkflowcreated { get; set; }
        public DateTime? lastonholdtime { get; set; }
        public DateTime? lastopenedtime { get; set; }
        public int? linksclickedcount { get; set; }
        public string messageid { get; set; }
        public string messageiddupcheck { get; set; }
        public string mimetype { get; set; }
        public DateTime? modifiedon { get; set; }
        public int? notifications { get; set; }
        public int? onholdtime { get; set; }
        public int? opencount { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public DateTime? postponeemailprocessinguntil { get; set; }
        public int? prioritycode { get; set; }
        public string processid { get; set; }
        public bool? readreceiptrequested { get; set; }
        public string reminderactioncardid { get; set; }
        public int? replycount { get; set; }
        public int? scheduleddurationminutes { get; set; }
        public DateTime? scheduledend { get; set; }
        public DateTime? scheduledstart { get; set; }
        public string sender { get; set; }
        public DateTime? senton { get; set; }
        public DateTime? sortdate { get; set; }
        public string stageid { get; set; }
        public int? statecode { get; set; }
        public int? statuscode { get; set; }
        public string subcategory { get; set; }
        public string subject { get; set; }
        public string submittedby { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string torecipients { get; set; }
        public string trackingtoken { get; set; }
        public string traversedpath { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public long? versionnumber { get; set; }
    }
}
