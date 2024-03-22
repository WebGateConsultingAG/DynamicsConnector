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
    public class ActivityMimeAttachment
    {
        public string activitymimeattachmentid { get; set; }
        public string activitymimeattachmentidunique { get; set; }
        public string activitysubject { get; set; }
        public string anonymouslink { get; set; }
        public string attachmentcontentid { get; set; }
        public int? attachmentnumber { get; set; }
        public string body { get; set; }
        public int? componentstate { get; set; }
        public string filename { get; set; }
        public int? filesize { get; set; }
        public bool? isfollowed { get; set; }
        public bool? ismanaged { get; set; }
        public string mimetype { get; set; }
        public DateTime? overwritetime { get; set; }
        public string ownerid { get; set; }
        public string solutionid { get; set; }
        public string subject { get; set; }
        public string supportingsolutionid { get; set; }
        public long? versionnumber { get; set; }
    }
}
