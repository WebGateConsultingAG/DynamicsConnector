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
    public class RecurringAppointmentMaster
    {
        public string activityid { get; set; }
        public string category { get; set; }
        public DateTime? createdon { get; set; }
        public int? dayofmonth { get; set; }
        public int? daysofweekmask { get; set; }
        public string deletedexceptionslist { get; set; }
        public string description { get; set; }
        public string duration { get; set; }
        public DateTime? effectiveenddate { get; set; }
        public DateTime? effectivestartdate { get; set; }
        public DateTime? endtime { get; set; }
        public double? exchangerate { get; set; }
        public int? expansionstatecode { get; set; }
        public int? firstdayofweek { get; set; }
        public string globalobjectid { get; set; }
        public int? importsequencenumber { get; set; }
        public int? instance { get; set; }
        public int? instancetypecode { get; set; }
        public int? interval { get; set; }
        public bool? isalldayevent { get; set; }
        public bool? isbilled { get; set; }
        public bool? ismapiprivate { get; set; }
        public bool? isnthmonthly { get; set; }
        public bool? isnthyearly { get; set; }
        public bool? isregenerate { get; set; }
        public bool? isregularactivity { get; set; }
        public int? isunsafe { get; set; }
        public bool? isweekdaypattern { get; set; }
        public bool? isworkflowcreated { get; set; }
        public DateTime? lastexpandedinstancedate { get; set; }
        public string location { get; set; }
        public DateTime? modifiedon { get; set; }
        public int? monthofyear { get; set; }
        public DateTime? nextexpansioninstancedate { get; set; }
        public int? occurrences { get; set; }
        public int? outlookownerapptid { get; set; }
        public DateTime? overriddencreatedon { get; set; }
        public string ownerid { get; set; }
        public DateTime? patternenddate { get; set; }
        public int? patternendtype { get; set; }
        public DateTime? patternstartdate { get; set; }
        public int? prioritycode { get; set; }
        public string processid { get; set; }
        public int? recurrencepatterntype { get; set; }
        public DateTime? scheduledend { get; set; }
        public DateTime? scheduledstart { get; set; }
        public bool? seriesstatus { get; set; }
        public DateTime? sortdate { get; set; }
        public string stageid { get; set; }
        public DateTime? starttime { get; set; }
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
