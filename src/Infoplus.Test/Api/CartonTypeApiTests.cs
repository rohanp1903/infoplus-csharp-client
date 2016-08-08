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
    ///  Class for testing CartonTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CartonTypeApiTests
    {
        private CartonTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CartonTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CartonTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' CartonTypeApi
            Assert.IsInstanceOfType(typeof(CartonTypeApi), instance, "instance is a CartonTypeApi");
        }

        
        /// <summary>
        /// Test AddCartonType
        /// </summary>
        [Test]
        public void AddCartonTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonType body = null;
            //var response = instance.AddCartonType(body);
            //Assert.IsInstanceOf<CartonType> (response, "response is CartonType");
        }
        
        /// <summary>
        /// Test DeleteCartonType
        /// </summary>
        [Test]
        public void DeleteCartonTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //instance.DeleteCartonType(cartonTypeId);
            
        }
        
        /// <summary>
        /// Test GetCartonTypeByFilter
        /// </summary>
        [Test]
        public void GetCartonTypeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCartonTypeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<CartonType>> (response, "response is List<CartonType>");
        }
        
        /// <summary>
        /// Test GetCartonTypeById
        /// </summary>
        [Test]
        public void GetCartonTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //var response = instance.GetCartonTypeById(cartonTypeId);
            //Assert.IsInstanceOf<CartonType> (response, "response is CartonType");
        }
        
        /// <summary>
        /// Test UpdateCartonType
        /// </summary>
        [Test]
        public void UpdateCartonTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonType body = null;
            //instance.UpdateCartonType(body);
            
        }
        
        /// <summary>
        /// Test UpdateCartonTypeCustomFields
        /// </summary>
        [Test]
        public void UpdateCartonTypeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonType body = null;
            //instance.UpdateCartonTypeCustomFields(body);
            
        }
        
    }

}
