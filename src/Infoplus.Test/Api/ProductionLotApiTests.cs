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
    ///  Class for testing ProductionLotApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductionLotApiTests
    {
        private ProductionLotApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductionLotApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductionLotApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ProductionLotApi
            Assert.IsInstanceOfType(typeof(ProductionLotApi), instance, "instance is a ProductionLotApi");
        }

        
        /// <summary>
        /// Test GetProductionLotByFilter
        /// </summary>
        [Test]
        public void GetProductionLotByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetProductionLotByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ProductionLot>> (response, "response is List<ProductionLot>");
        }
        
        /// <summary>
        /// Test GetProductionLotById
        /// </summary>
        [Test]
        public void GetProductionLotByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionLotId = null;
            //var response = instance.GetProductionLotById(productionLotId);
            //Assert.IsInstanceOf<ProductionLot> (response, "response is ProductionLot");
        }
        
        /// <summary>
        /// Test UpdateProductionLotCustomFields
        /// </summary>
        [Test]
        public void UpdateProductionLotCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionLot body = null;
            //instance.UpdateProductionLotCustomFields(body);
            
        }
        
    }

}
