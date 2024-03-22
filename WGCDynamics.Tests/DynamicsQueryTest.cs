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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WebGate.Dynamics.Connector;
using WebGate.Dynamics.Model;
using WebGate.Dynamics.Util;

namespace DynamicsConnectorUnitTest
{
    [TestClass]
    public class DynamicsQueryTest
    {
        /// <summary>
        /// check for the right syntax for list
        /// </summary>
        [TestMethod]
        public void TestList()
        {
            DynamicsQuery query = new DynamicsQuery()
            {
                Table = DynamicsTables.Account
            };
            Assert.IsTrue(query.GetPath().Equals("accounts"));
        }


        /// <summary>
        /// check for the right syntax for single query
        /// </summary>
        [TestMethod]
        public void TestSingle()
        {
            DynamicsQuery query = new DynamicsQuery()
            {
                Table = DynamicsTables.Account,
                Key = "test"
            };
            Assert.IsTrue(query.GetPath().Equals("accounts(test)"));
        }

        /// <summary>
        /// check for the right syntax for singe select
        /// </summary>
        [TestMethod]
        public void TestSingleSelect()
        {
            DynamicsQuery query = new DynamicsQuery()
            {
                Table = DynamicsTables.Systemuser,
                Key = "test",
                Fields = new List<string>(){
                    nameof(SystemUser.firstname),
                    nameof(SystemUser.lastname),
                    nameof(SystemUser.address1_city)
                }
                
            };
            Assert.IsTrue(query.GetPath().Equals("systemusers(test)?$select=firstname,lastname,address1_city"));
        }

        /// <summary>
        /// check for the right syntax for top select
        /// </summary>
        [TestMethod]
        public void TestSelectAndTop()
        {
            DynamicsQuery query = new DynamicsQuery()
            {
                Table = DynamicsTables.Systemuser,
                Top = 5
            };
            Assert.IsTrue(query.GetPath().Equals("systemusers?$top=5"));
        }

        /// <summary>
        /// check for the right syntax for top select
        /// </summary>
        [TestMethod]
        public void TestFilter()
        {
            DynamicsQuery query = new DynamicsQuery()
            {
                Table = DynamicsTables.Systemuser,
                Filters = new List<Filter>() {
                    new Filter()
                    {
                        Field = nameof(SystemUser.firstname),
                        Operator = FilterOperator.EqualsOperator,
                        Value = "Mirko"
                    },
                    new Filter{
                        Field = nameof(SystemUser.address1_addresstypecode),
                        Operator = FilterOperator.EqualsOperator,
                        Value = 1,
                        GlobalOperator = FilterOperator.Or
                        
                    }
                },
                Top = 5
            };
            Console.WriteLine(query.GetPath());
            Assert.IsTrue(query.GetPath().Equals("systemusers?$filter=firstname eq 'Mirko' or address1_addresstypecode eq 1&$top=5"));
        }


        /// <summary>
        /// check for the right syntax for expand
        /// </summary>
        [TestMethod]
        public void ExpandFilter()
        {
            DynamicsQuery query = new DynamicsQuery
            {
                Table = DynamicsTables.Contact,
                Key = "contactId",
                Fields = new List<string>() {
                    nameof(Contact.firstname),
                    nameof(Contact.lastname)
                },
                Expand = new DynamicsQuery
                {
                    Key = nameof(Contact.owninguser),
                    Fields = new List<string>() {
                        nameof(SystemUser.firstname)
                    }
                }
            };
            Console.WriteLine(query.GetPath());
            Assert.IsTrue(query.GetPath().Equals("contacts(contactId)?$select=firstname,lastname&$expand=owninguser($select=firstname)"));
        }

    }
}
