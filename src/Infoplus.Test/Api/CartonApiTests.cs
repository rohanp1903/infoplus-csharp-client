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
    ///  Class for testing CartonApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CartonApiTests
    {
        private CartonApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CartonApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CartonApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' CartonApi
            Assert.IsInstanceOfType(typeof(CartonApi), instance, "instance is a CartonApi");
        }

        
        /// <summary>
        /// Test AddCarton
        /// </summary>
        [Test]
        public void AddCartonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Carton body = null;
            //var response = instance.AddCarton(body);
            //Assert.IsInstanceOf<Carton> (response, "response is Carton");
        }
        
        /// <summary>
        /// Test DeleteCarton
        /// </summary>
        [Test]
        public void DeleteCartonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //instance.DeleteCarton(cartonId);
            
        }
        
        /// <summary>
        /// Test GetCartonByFilter
        /// </summary>
        [Test]
        public void GetCartonByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCartonByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Carton>> (response, "response is List<Carton>");
        }
        
        /// <summary>
        /// Test GetCartonById
        /// </summary>
        [Test]
        public void GetCartonByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //var response = instance.GetCartonById(cartonId);
            //Assert.IsInstanceOf<Carton> (response, "response is Carton");
        }
        
        /// <summary>
        /// Test UpdateCarton
        /// </summary>
        [Test]
        public void UpdateCartonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Carton body = null;
            //instance.UpdateCarton(body);
            
        }
        
        /// <summary>
        /// Test UpdateCartonCustomFields
        /// </summary>
        [Test]
        public void UpdateCartonCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Carton body = null;
            //instance.UpdateCartonCustomFields(body);
            
        }
        
    }

}
