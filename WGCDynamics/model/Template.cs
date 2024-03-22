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
    public class Template
    {
        public string body { get; set; }
        public int? componentstate { get; set; }
        public DateTime? createdon { get; set; }
        public string description { get; set; }
        public int? generationtypecode { get; set; }
        public int? importsequencenumber { get; set; }
        public string introducedversion { get; set; }
        public bool? ismanaged { get; set; }
        public bool? ispersonal { get; set; }
        public bool? isrecommended { get; set; }
        public string languagecode { get; set; }
        public string mimetype { get; set; }
        public DateTime? modifiedon { get; set; }
        public int? opencount { get; set; }
        public int? openrate { get; set; }
        public DateTime? overwritetime { get; set; }
        public string ownerid { get; set; }
        public string presentationxml { get; set; }
        public int? replycount { get; set; }
        public int? replyrate { get; set; }
        public string safehtml { get; set; }
        public string solutionid { get; set; }
        public string subject { get; set; }
        public string subjectpresentationxml { get; set; }
        public string subjectsafehtml { get; set; }
        public string supportingsolutionid { get; set; }
        public string templateid { get; set; }
        public string templateidunique { get; set; }
        public string title { get; set; }
        public int? usedcount { get; set; }
        public long? versionnumber { get; set; }
    }
}
