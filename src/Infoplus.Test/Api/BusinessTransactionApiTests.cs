/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Infoplus.Client;
using Infoplus.Api;
using Infoplus.Model;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing BusinessTransactionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BusinessTransactionApiTests
    {
        private BusinessTransactionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BusinessTransactionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BusinessTransactionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' BusinessTransactionApi
            Assert.IsInstanceOfType(typeof(BusinessTransactionApi), instance, "instance is a BusinessTransactionApi");
        }

        
        /// <summary>
        /// Test GetBusinessTransactionByFilter
        /// </summary>
        [Test]
        public void GetBusinessTransactionByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetBusinessTransactionByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<BusinessTransaction>> (response, "response is List<BusinessTransaction>");
        }
        
        /// <summary>
        /// Test GetBusinessTransactionById
        /// </summary>
        [Test]
        public void GetBusinessTransactionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? businessTransactionId = null;
            //var response = instance.GetBusinessTransactionById(businessTransactionId);
            //Assert.IsInstanceOf<BusinessTransaction> (response, "response is BusinessTransaction");
        }
        
        /// <summary>
        /// Test UpdateBusinessTransactionCustomFields
        /// </summary>
        [Test]
        public void UpdateBusinessTransactionCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BusinessTransaction body = null;
            //instance.UpdateBusinessTransactionCustomFields(body);
            
        }
        
    }

}
