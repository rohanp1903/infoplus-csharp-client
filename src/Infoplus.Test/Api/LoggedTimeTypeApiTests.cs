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
    ///  Class for testing LoggedTimeTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LoggedTimeTypeApiTests
    {
        private LoggedTimeTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LoggedTimeTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoggedTimeTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LoggedTimeTypeApi
            Assert.IsInstanceOfType(typeof(LoggedTimeTypeApi), instance, "instance is a LoggedTimeTypeApi");
        }

        
        /// <summary>
        /// Test GetLoggedTimeTypeById
        /// </summary>
        [Test]
        public void GetLoggedTimeTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loggedTimeTypeId = null;
            //var response = instance.GetLoggedTimeTypeById(loggedTimeTypeId);
            //Assert.IsInstanceOf<LoggedTimeType> (response, "response is LoggedTimeType");
        }
        
        /// <summary>
        /// Test GetLoggedTimeTypeBySearchText
        /// </summary>
        [Test]
        public void GetLoggedTimeTypeBySearchTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetLoggedTimeTypeBySearchText(searchText, page, limit);
            //Assert.IsInstanceOf<List<LoggedTimeType>> (response, "response is List<LoggedTimeType>");
        }
        
    }

}
