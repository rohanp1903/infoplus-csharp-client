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
    ///  Class for testing CartLocationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CartLocationApiTests
    {
        private CartLocationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CartLocationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CartLocationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CartLocationApi
            //Assert.IsInstanceOfType(typeof(CartLocationApi), instance, "instance is a CartLocationApi");
        }

        
        /// <summary>
        /// Test AddCartLocationAudit
        /// </summary>
        [Test]
        public void AddCartLocationAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //string cartLocationAudit = null;
            //instance.AddCartLocationAudit(cartLocationId, cartLocationAudit);
            
        }
        
        /// <summary>
        /// Test AddCartLocationFile
        /// </summary>
        [Test]
        public void AddCartLocationFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //string fileName = null;
            //instance.AddCartLocationFile(cartLocationId, fileName);
            
        }
        
        /// <summary>
        /// Test AddCartLocationFileByURL
        /// </summary>
        [Test]
        public void AddCartLocationFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? cartLocationId = null;
            //instance.AddCartLocationFileByURL(body, cartLocationId);
            
        }
        
        /// <summary>
        /// Test AddCartLocationTag
        /// </summary>
        [Test]
        public void AddCartLocationTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //string cartLocationTag = null;
            //instance.AddCartLocationTag(cartLocationId, cartLocationTag);
            
        }
        
        /// <summary>
        /// Test DeleteCartLocationFile
        /// </summary>
        [Test]
        public void DeleteCartLocationFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //int? fileId = null;
            //instance.DeleteCartLocationFile(cartLocationId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteCartLocationTag
        /// </summary>
        [Test]
        public void DeleteCartLocationTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //string cartLocationTag = null;
            //instance.DeleteCartLocationTag(cartLocationId, cartLocationTag);
            
        }
        
        /// <summary>
        /// Test GetCartLocationByFilter
        /// </summary>
        [Test]
        public void GetCartLocationByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCartLocationByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<CartLocation>> (response, "response is List<CartLocation>");
        }
        
        /// <summary>
        /// Test GetCartLocationById
        /// </summary>
        [Test]
        public void GetCartLocationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //var response = instance.GetCartLocationById(cartLocationId);
            //Assert.IsInstanceOf<CartLocation> (response, "response is CartLocation");
        }
        
        /// <summary>
        /// Test GetCartLocationFiles
        /// </summary>
        [Test]
        public void GetCartLocationFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //instance.GetCartLocationFiles(cartLocationId);
            
        }
        
        /// <summary>
        /// Test GetCartLocationTags
        /// </summary>
        [Test]
        public void GetCartLocationTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //instance.GetCartLocationTags(cartLocationId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateCartLocationById
        /// </summary>
        [Test]
        public void GetDuplicateCartLocationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartLocationId = null;
            //var response = instance.GetDuplicateCartLocationById(cartLocationId);
            //Assert.IsInstanceOf<CartLocation> (response, "response is CartLocation");
        }
        
    }

}
