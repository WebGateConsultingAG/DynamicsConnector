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
using System.Collections.Generic;
using System.Linq;
namespace WGCDynamics
{
    public class DynamicsQuery
    {
        /// <summary>Main Table for Query use class Tables to found your API Endpoint</summary>
        public string Table { get; set; }

        /// <summary>
        /// If Key is set the Query will extendet by the key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// If set this set the max count of returning Results. 
        /// </summary>
        public int? Top { get; set; }

        /// <summary>List of Filednames in Dynamics what will select. Will be Changed to the OGraph Format</summary>
        public ICollection<string> Fields { get; set; }

        /// <summary>List of Filters to reduce the result</summary>
        public ICollection<Filter> Filters { get; set; }
        /// <summary>
        /// Expand your query to an relation 
        /// </summary>
        public DynamicsQuery Expand { get; set; }

        /// <summary>
        /// Build the ograph Path from all given Variables
        /// </summary>
        /// <returns>Ograph Path as string</returns>
        public string GetPath()
        {
            string path = Table;
            if (Key != null && Key.Length > 0)
            {
                path += "(" + Key + ")";
            }
            if (Fields != null && Fields.Count() > 0)
            {
                path += QuestionMarkOrAnd(path);
                path += GetSelect(Fields);
            }
            if (Filters != null && Filters.Count() > 0)
            {
                path += QuestionMarkOrAnd(path);
                path += GetFilter();
            }
            if (Expand != null)
            {
                path += QuestionMarkOrAnd(path);
                path += GetExpand();
            }
            if (Top != null) {
                path += QuestionMarkOrAnd(path);
                path += GetTop();
            }
            return path;
        }

        private string GetTop() {
            return "$top=" + Top;
        }

        private string GetExpand()
        {
            string expandText = "$expand=" + Expand.Key;
            if (Expand.Fields != null && Expand.Fields.Count > 0)
            {
                expandText += "(" + GetSelect(Expand.Fields) + ")";
            }
            return expandText;
        }

        private string QuestionMarkOrAnd(string path)
        {
            return path.IndexOf("?") == -1 ? "?" : "&";
        }

        private string GetFilter()
        {
            string filterText = "$filter=";
            int count = 0;
            foreach (Filter filter in Filters)
            {
                if (count > 0)
                {
                    filterText += " " + filter.GlobalOperator + " ";
                }
                filterText += filter.Field + " " + filter.Operator + " " + GetFilterValue(filter.Value);
                count++;
            }
            return filterText;
        }

        private object GetFilterValue(object value)
        {

            if (value is string)
            {
                return "'" + value + "'";
            }
            else
            {
                return value;
            }

        }

        private string GetSelect(ICollection<string> Fields)
        {
            string select = "$select=";
            int count = 0;
            foreach (string field in Fields)
            {
                if (count > 0)
                {
                    select += ",";
                }
                select += field;
                count++;
            }
            return select;
        }
    }

    public class Filter
    {
        /// <summary>
        /// Filter Field
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// Filter Operator use FilterOperator Class
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// If you use more than one Filter define the globalOperator for concat the filters.
        /// </summary>
        public string GlobalOperator { get; set; }
        /// <summary>
        /// what value will be compared
        /// </summary>
        public object Value { get; set; }
    }
}

