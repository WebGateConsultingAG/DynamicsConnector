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
    public class TeamTemplate
    {
        public DateTime? createdon { get; set; }
        public int? defaultaccessrightsmask { get; set; }
        public string description { get; set; }
        public bool? issystem { get; set; }
        public DateTime? modifiedon { get; set; }
        public int? objecttypecode { get; set; }
        public string teamtemplateid { get; set; }
        public string teamtemplatename { get; set; }
    }
}
