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
    ///  Class for testing ManageScheduledPlansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ManageScheduledPlansApiTests
    {
        private ManageScheduledPlansApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ManageScheduledPlansApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ManageScheduledPlansApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ManageScheduledPlansApi
            Assert.IsInstanceOfType(typeof(ManageScheduledPlansApi), instance, "instance is a ManageScheduledPlansApi");
        }

        
        /// <summary>
        /// Test AddManageScheduledPlans
        /// </summary>
        [Test]
        public void AddManageScheduledPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ManageScheduledPlans body = null;
            //var response = instance.AddManageScheduledPlans(body);
            //Assert.IsInstanceOf<ManageScheduledPlans> (response, "response is ManageScheduledPlans");
        }
        
        /// <summary>
        /// Test DeleteManageScheduledPlans
        /// </summary>
        [Test]
        public void DeleteManageScheduledPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? manageScheduledPlansId = null;
            //instance.DeleteManageScheduledPlans(manageScheduledPlansId);
            
        }
        
        /// <summary>
        /// Test GetManageScheduledPlansByFilter
        /// </summary>
        [Test]
        public void GetManageScheduledPlansByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetManageScheduledPlansByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ManageScheduledPlans>> (response, "response is List<ManageScheduledPlans>");
        }
        
        /// <summary>
        /// Test GetManageScheduledPlansById
        /// </summary>
        [Test]
        public void GetManageScheduledPlansByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? manageScheduledPlansId = null;
            //var response = instance.GetManageScheduledPlansById(manageScheduledPlansId);
            //Assert.IsInstanceOf<ManageScheduledPlans> (response, "response is ManageScheduledPlans");
        }
        
        /// <summary>
        /// Test UpdateManageScheduledPlans
        /// </summary>
        [Test]
        public void UpdateManageScheduledPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ManageScheduledPlans body = null;
            //instance.UpdateManageScheduledPlans(body);
            
        }
        
    }

}
