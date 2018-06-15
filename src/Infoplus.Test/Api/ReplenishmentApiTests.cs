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
    ///  Class for testing ReplenishmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReplenishmentApiTests
    {
        private ReplenishmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReplenishmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReplenishmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReplenishmentApi
            //Assert.IsInstanceOfType(typeof(ReplenishmentApi), instance, "instance is a ReplenishmentApi");
        }

        
        /// <summary>
        /// Test AddReplenishmentAudit
        /// </summary>
        [Test]
        public void AddReplenishmentAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? replenishmentId = null;
            //string replenishmentAudit = null;
            //instance.AddReplenishmentAudit(replenishmentId, replenishmentAudit);
            
        }
        
        /// <summary>
        /// Test AddReplenishmentTag
        /// </summary>
        [Test]
        public void AddReplenishmentTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? replenishmentId = null;
            //string replenishmentTag = null;
            //instance.AddReplenishmentTag(replenishmentId, replenishmentTag);
            
        }
        
        /// <summary>
        /// Test DeleteReplenishmentTag
        /// </summary>
        [Test]
        public void DeleteReplenishmentTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? replenishmentId = null;
            //string replenishmentTag = null;
            //instance.DeleteReplenishmentTag(replenishmentId, replenishmentTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateReplenishmentById
        /// </summary>
        [Test]
        public void GetDuplicateReplenishmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? replenishmentId = null;
            //var response = instance.GetDuplicateReplenishmentById(replenishmentId);
            //Assert.IsInstanceOf<Replenishment> (response, "response is Replenishment");
        }
        
        /// <summary>
        /// Test GetReplenishmentByFilter
        /// </summary>
        [Test]
        public void GetReplenishmentByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetReplenishmentByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Replenishment>> (response, "response is List<Replenishment>");
        }
        
        /// <summary>
        /// Test GetReplenishmentById
        /// </summary>
        [Test]
        public void GetReplenishmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? replenishmentId = null;
            //var response = instance.GetReplenishmentById(replenishmentId);
            //Assert.IsInstanceOf<Replenishment> (response, "response is Replenishment");
        }
        
        /// <summary>
        /// Test GetReplenishmentTags
        /// </summary>
        [Test]
        public void GetReplenishmentTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? replenishmentId = null;
            //instance.GetReplenishmentTags(replenishmentId);
            
        }
        
        /// <summary>
        /// Test UpdateReplenishmentCustomFields
        /// </summary>
        [Test]
        public void UpdateReplenishmentCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Replenishment body = null;
            //instance.UpdateReplenishmentCustomFields(body);
            
        }
        
    }

}