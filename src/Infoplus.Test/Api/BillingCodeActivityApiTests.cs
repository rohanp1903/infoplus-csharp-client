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
    ///  Class for testing BillingCodeActivityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillingCodeActivityApiTests
    {
        private BillingCodeActivityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingCodeActivityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingCodeActivityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillingCodeActivityApi
            //Assert.IsInstanceOfType(typeof(BillingCodeActivityApi), instance, "instance is a BillingCodeActivityApi");
        }

        
        /// <summary>
        /// Test AddBillingCodeActivity
        /// </summary>
        [Test]
        public void AddBillingCodeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCodeActivity body = null;
            //var response = instance.AddBillingCodeActivity(body);
            //Assert.IsInstanceOf<BillingCodeActivity> (response, "response is BillingCodeActivity");
        }
        
        /// <summary>
        /// Test AddBillingCodeActivityAudit
        /// </summary>
        [Test]
        public void AddBillingCodeActivityAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //string billingCodeActivityAudit = null;
            //instance.AddBillingCodeActivityAudit(billingCodeActivityId, billingCodeActivityAudit);
            
        }
        
        /// <summary>
        /// Test AddBillingCodeActivityFile
        /// </summary>
        [Test]
        public void AddBillingCodeActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //string fileName = null;
            //instance.AddBillingCodeActivityFile(billingCodeActivityId, fileName);
            
        }
        
        /// <summary>
        /// Test AddBillingCodeActivityTag
        /// </summary>
        [Test]
        public void AddBillingCodeActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //string billingCodeActivityTag = null;
            //instance.AddBillingCodeActivityTag(billingCodeActivityId, billingCodeActivityTag);
            
        }
        
        /// <summary>
        /// Test DeleteBillingCodeActivity
        /// </summary>
        [Test]
        public void DeleteBillingCodeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //instance.DeleteBillingCodeActivity(billingCodeActivityId);
            
        }
        
        /// <summary>
        /// Test DeleteBillingCodeActivityTag
        /// </summary>
        [Test]
        public void DeleteBillingCodeActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //string billingCodeActivityTag = null;
            //instance.DeleteBillingCodeActivityTag(billingCodeActivityId, billingCodeActivityTag);
            
        }
        
        /// <summary>
        /// Test GetBillingCodeActivityByFilter
        /// </summary>
        [Test]
        public void GetBillingCodeActivityByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetBillingCodeActivityByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<BillingCodeActivity>> (response, "response is List<BillingCodeActivity>");
        }
        
        /// <summary>
        /// Test GetBillingCodeActivityById
        /// </summary>
        [Test]
        public void GetBillingCodeActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //var response = instance.GetBillingCodeActivityById(billingCodeActivityId);
            //Assert.IsInstanceOf<BillingCodeActivity> (response, "response is BillingCodeActivity");
        }
        
        /// <summary>
        /// Test GetBillingCodeActivityTags
        /// </summary>
        [Test]
        public void GetBillingCodeActivityTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //instance.GetBillingCodeActivityTags(billingCodeActivityId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateBillingCodeActivityById
        /// </summary>
        [Test]
        public void GetDuplicateBillingCodeActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeActivityId = null;
            //var response = instance.GetDuplicateBillingCodeActivityById(billingCodeActivityId);
            //Assert.IsInstanceOf<BillingCodeActivity> (response, "response is BillingCodeActivity");
        }
        
        /// <summary>
        /// Test UpdateBillingCodeActivity
        /// </summary>
        [Test]
        public void UpdateBillingCodeActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCodeActivity body = null;
            //instance.UpdateBillingCodeActivity(body);
            
        }
        
    }

}
