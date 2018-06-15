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
    ///  Class for testing CartonActivityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CartonActivityApiTests
    {
        private CartonActivityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CartonActivityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CartonActivityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CartonActivityApi
            //Assert.IsInstanceOfType(typeof(CartonActivityApi), instance, "instance is a CartonActivityApi");
        }

        
        /// <summary>
        /// Test AddCartonActivity
        /// </summary>
        [Test]
        public void AddCartonActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonActivity body = null;
            //var response = instance.AddCartonActivity(body);
            //Assert.IsInstanceOf<CartonActivity> (response, "response is CartonActivity");
        }
        
        /// <summary>
        /// Test AddCartonActivityAudit
        /// </summary>
        [Test]
        public void AddCartonActivityAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //string cartonActivityAudit = null;
            //instance.AddCartonActivityAudit(cartonActivityId, cartonActivityAudit);
            
        }
        
        /// <summary>
        /// Test AddCartonActivityTag
        /// </summary>
        [Test]
        public void AddCartonActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //string cartonActivityTag = null;
            //instance.AddCartonActivityTag(cartonActivityId, cartonActivityTag);
            
        }
        
        /// <summary>
        /// Test DeleteCartonActivity
        /// </summary>
        [Test]
        public void DeleteCartonActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //instance.DeleteCartonActivity(cartonActivityId);
            
        }
        
        /// <summary>
        /// Test DeleteCartonActivityTag
        /// </summary>
        [Test]
        public void DeleteCartonActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //string cartonActivityTag = null;
            //instance.DeleteCartonActivityTag(cartonActivityId, cartonActivityTag);
            
        }
        
        /// <summary>
        /// Test GetCartonActivityByFilter
        /// </summary>
        [Test]
        public void GetCartonActivityByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCartonActivityByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<CartonActivity>> (response, "response is List<CartonActivity>");
        }
        
        /// <summary>
        /// Test GetCartonActivityById
        /// </summary>
        [Test]
        public void GetCartonActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //var response = instance.GetCartonActivityById(cartonActivityId);
            //Assert.IsInstanceOf<CartonActivity> (response, "response is CartonActivity");
        }
        
        /// <summary>
        /// Test GetCartonActivityTags
        /// </summary>
        [Test]
        public void GetCartonActivityTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //instance.GetCartonActivityTags(cartonActivityId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateCartonActivityById
        /// </summary>
        [Test]
        public void GetDuplicateCartonActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonActivityId = null;
            //var response = instance.GetDuplicateCartonActivityById(cartonActivityId);
            //Assert.IsInstanceOf<CartonActivity> (response, "response is CartonActivity");
        }
        
        /// <summary>
        /// Test UpdateCartonActivity
        /// </summary>
        [Test]
        public void UpdateCartonActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonActivity body = null;
            //instance.UpdateCartonActivity(body);
            
        }
        
    }

}