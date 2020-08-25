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

namespace WGCDynamics
{
    public static class FilterOperator
    {
        public readonly static string EqualsOperator = "eq";
        public readonly static string InOperator = "in";
        public readonly static string NotEquals = "ne";
        public readonly static string GreaterThan = "gt";
        public readonly static string GreaterThanOrEquals = "ge";
        public readonly static string LessThan = "lt";
        public readonly static string LessThanOrEquals = "le";
        public readonly static string And = "and";
        public readonly static string Or = "or";
        public readonly static string Not = "not";
    }
}
