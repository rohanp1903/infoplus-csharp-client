/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    ///  Class for testing OrderSourceItemSetupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderSourceItemSetupApiTests
    {
        private OrderSourceItemSetupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderSourceItemSetupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderSourceItemSetupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderSourceItemSetupApi
            //Assert.IsInstanceOfType(typeof(OrderSourceItemSetupApi), instance, "instance is a OrderSourceItemSetupApi");
        }

        
        /// <summary>
        /// Test AddOrderSourceItemSetup
        /// </summary>
        [Test]
        public void AddOrderSourceItemSetupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSourceItemSetup body = null;
            //var response = instance.AddOrderSourceItemSetup(body);
            //Assert.IsInstanceOf<OrderSourceItemSetup> (response, "response is OrderSourceItemSetup");
        }
        
        /// <summary>
        /// Test AddOrderSourceItemSetupAudit
        /// </summary>
        [Test]
        public void AddOrderSourceItemSetupAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //string orderSourceItemSetupAudit = null;
            //instance.AddOrderSourceItemSetupAudit(orderSourceItemSetupId, orderSourceItemSetupAudit);
            
        }
        
        /// <summary>
        /// Test AddOrderSourceItemSetupFile
        /// </summary>
        [Test]
        public void AddOrderSourceItemSetupFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //string fileName = null;
            //instance.AddOrderSourceItemSetupFile(orderSourceItemSetupId, fileName);
            
        }
        
        /// <summary>
        /// Test AddOrderSourceItemSetupTag
        /// </summary>
        [Test]
        public void AddOrderSourceItemSetupTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //string orderSourceItemSetupTag = null;
            //instance.AddOrderSourceItemSetupTag(orderSourceItemSetupId, orderSourceItemSetupTag);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSourceItemSetup
        /// </summary>
        [Test]
        public void DeleteOrderSourceItemSetupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //instance.DeleteOrderSourceItemSetup(orderSourceItemSetupId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSourceItemSetupTag
        /// </summary>
        [Test]
        public void DeleteOrderSourceItemSetupTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //string orderSourceItemSetupTag = null;
            //instance.DeleteOrderSourceItemSetupTag(orderSourceItemSetupId, orderSourceItemSetupTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOrderSourceItemSetupById
        /// </summary>
        [Test]
        public void GetDuplicateOrderSourceItemSetupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //var response = instance.GetDuplicateOrderSourceItemSetupById(orderSourceItemSetupId);
            //Assert.IsInstanceOf<OrderSourceItemSetup> (response, "response is OrderSourceItemSetup");
        }
        
        /// <summary>
        /// Test GetOrderSourceItemSetupByFilter
        /// </summary>
        [Test]
        public void GetOrderSourceItemSetupByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderSourceItemSetupByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OrderSourceItemSetup>> (response, "response is List<OrderSourceItemSetup>");
        }
        
        /// <summary>
        /// Test GetOrderSourceItemSetupById
        /// </summary>
        [Test]
        public void GetOrderSourceItemSetupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //var response = instance.GetOrderSourceItemSetupById(orderSourceItemSetupId);
            //Assert.IsInstanceOf<OrderSourceItemSetup> (response, "response is OrderSourceItemSetup");
        }
        
        /// <summary>
        /// Test GetOrderSourceItemSetupTags
        /// </summary>
        [Test]
        public void GetOrderSourceItemSetupTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceItemSetupId = null;
            //instance.GetOrderSourceItemSetupTags(orderSourceItemSetupId);
            
        }
        
        /// <summary>
        /// Test UpdateOrderSourceItemSetup
        /// </summary>
        [Test]
        public void UpdateOrderSourceItemSetupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSourceItemSetup body = null;
            //instance.UpdateOrderSourceItemSetup(body);
            
        }
        
        /// <summary>
        /// Test UpdateOrderSourceItemSetupCustomFields
        /// </summary>
        [Test]
        public void UpdateOrderSourceItemSetupCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSourceItemSetup body = null;
            //instance.UpdateOrderSourceItemSetupCustomFields(body);
            
        }
        
    }

}
