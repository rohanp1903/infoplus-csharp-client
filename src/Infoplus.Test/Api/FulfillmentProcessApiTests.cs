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
    ///  Class for testing FulfillmentProcessApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FulfillmentProcessApiTests
    {
        private FulfillmentProcessApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FulfillmentProcessApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentProcessApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FulfillmentProcessApi
            //Assert.IsInstanceOfType(typeof(FulfillmentProcessApi), instance, "instance is a FulfillmentProcessApi");
        }

        
        /// <summary>
        /// Test AddFulfillmentProcessAudit
        /// </summary>
        [Test]
        public void AddFulfillmentProcessAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessId = null;
            //string fulfillmentProcessAudit = null;
            //instance.AddFulfillmentProcessAudit(fulfillmentProcessId, fulfillmentProcessAudit);
            
        }
        
        /// <summary>
        /// Test AddFulfillmentProcessTag
        /// </summary>
        [Test]
        public void AddFulfillmentProcessTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessId = null;
            //string fulfillmentProcessTag = null;
            //instance.AddFulfillmentProcessTag(fulfillmentProcessId, fulfillmentProcessTag);
            
        }
        
        /// <summary>
        /// Test DeleteFulfillmentProcessTag
        /// </summary>
        [Test]
        public void DeleteFulfillmentProcessTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessId = null;
            //string fulfillmentProcessTag = null;
            //instance.DeleteFulfillmentProcessTag(fulfillmentProcessId, fulfillmentProcessTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateFulfillmentProcessById
        /// </summary>
        [Test]
        public void GetDuplicateFulfillmentProcessByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessId = null;
            //var response = instance.GetDuplicateFulfillmentProcessById(fulfillmentProcessId);
            //Assert.IsInstanceOf<FulfillmentProcess> (response, "response is FulfillmentProcess");
        }
        
        /// <summary>
        /// Test GetFulfillmentProcessByFilter
        /// </summary>
        [Test]
        public void GetFulfillmentProcessByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetFulfillmentProcessByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<FulfillmentProcess>> (response, "response is List<FulfillmentProcess>");
        }
        
        /// <summary>
        /// Test GetFulfillmentProcessById
        /// </summary>
        [Test]
        public void GetFulfillmentProcessByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessId = null;
            //var response = instance.GetFulfillmentProcessById(fulfillmentProcessId);
            //Assert.IsInstanceOf<FulfillmentProcess> (response, "response is FulfillmentProcess");
        }
        
        /// <summary>
        /// Test GetFulfillmentProcessTags
        /// </summary>
        [Test]
        public void GetFulfillmentProcessTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fulfillmentProcessId = null;
            //instance.GetFulfillmentProcessTags(fulfillmentProcessId);
            
        }
        
        /// <summary>
        /// Test UpdateFulfillmentProcessCustomFields
        /// </summary>
        [Test]
        public void UpdateFulfillmentProcessCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FulfillmentProcess body = null;
            //instance.UpdateFulfillmentProcessCustomFields(body);
            
        }
        
    }

}