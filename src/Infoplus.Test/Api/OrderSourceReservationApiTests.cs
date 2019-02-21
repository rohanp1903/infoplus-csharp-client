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
    ///  Class for testing OrderSourceReservationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderSourceReservationApiTests
    {
        private OrderSourceReservationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderSourceReservationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderSourceReservationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderSourceReservationApi
            //Assert.IsInstanceOfType(typeof(OrderSourceReservationApi), instance, "instance is a OrderSourceReservationApi");
        }

        
        /// <summary>
        /// Test AddOrderSourceReservation
        /// </summary>
        [Test]
        public void AddOrderSourceReservationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSourceReservation body = null;
            //var response = instance.AddOrderSourceReservation(body);
            //Assert.IsInstanceOf<OrderSourceReservation> (response, "response is OrderSourceReservation");
        }
        
        /// <summary>
        /// Test AddOrderSourceReservationAudit
        /// </summary>
        [Test]
        public void AddOrderSourceReservationAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //string orderSourceReservationAudit = null;
            //instance.AddOrderSourceReservationAudit(orderSourceReservationId, orderSourceReservationAudit);
            
        }
        
        /// <summary>
        /// Test AddOrderSourceReservationTag
        /// </summary>
        [Test]
        public void AddOrderSourceReservationTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //string orderSourceReservationTag = null;
            //instance.AddOrderSourceReservationTag(orderSourceReservationId, orderSourceReservationTag);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSourceReservation
        /// </summary>
        [Test]
        public void DeleteOrderSourceReservationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //instance.DeleteOrderSourceReservation(orderSourceReservationId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSourceReservationTag
        /// </summary>
        [Test]
        public void DeleteOrderSourceReservationTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //string orderSourceReservationTag = null;
            //instance.DeleteOrderSourceReservationTag(orderSourceReservationId, orderSourceReservationTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOrderSourceReservationById
        /// </summary>
        [Test]
        public void GetDuplicateOrderSourceReservationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //var response = instance.GetDuplicateOrderSourceReservationById(orderSourceReservationId);
            //Assert.IsInstanceOf<OrderSourceReservation> (response, "response is OrderSourceReservation");
        }
        
        /// <summary>
        /// Test GetOrderSourceReservationByFilter
        /// </summary>
        [Test]
        public void GetOrderSourceReservationByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderSourceReservationByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OrderSourceReservation>> (response, "response is List<OrderSourceReservation>");
        }
        
        /// <summary>
        /// Test GetOrderSourceReservationById
        /// </summary>
        [Test]
        public void GetOrderSourceReservationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //var response = instance.GetOrderSourceReservationById(orderSourceReservationId);
            //Assert.IsInstanceOf<OrderSourceReservation> (response, "response is OrderSourceReservation");
        }
        
        /// <summary>
        /// Test GetOrderSourceReservationTags
        /// </summary>
        [Test]
        public void GetOrderSourceReservationTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceReservationId = null;
            //instance.GetOrderSourceReservationTags(orderSourceReservationId);
            
        }
        
        /// <summary>
        /// Test UpdateOrderSourceReservation
        /// </summary>
        [Test]
        public void UpdateOrderSourceReservationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSourceReservation body = null;
            //instance.UpdateOrderSourceReservation(body);
            
        }
        
        /// <summary>
        /// Test UpdateOrderSourceReservationCustomFields
        /// </summary>
        [Test]
        public void UpdateOrderSourceReservationCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSourceReservation body = null;
            //instance.UpdateOrderSourceReservationCustomFields(body);
            
        }
        
    }

}