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
    ///  Class for testing ItemSerialApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemSerialApiTests
    {
        private ItemSerialApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemSerialApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemSerialApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemSerialApi
            //Assert.IsInstanceOfType(typeof(ItemSerialApi), instance, "instance is a ItemSerialApi");
        }

        
        /// <summary>
        /// Test AddItemSerial
        /// </summary>
        [Test]
        public void AddItemSerialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemSerial body = null;
            //var response = instance.AddItemSerial(body);
            //Assert.IsInstanceOf<ItemSerial> (response, "response is ItemSerial");
        }
        
        /// <summary>
        /// Test AddItemSerialAudit
        /// </summary>
        [Test]
        public void AddItemSerialAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //string itemSerialAudit = null;
            //instance.AddItemSerialAudit(itemSerialId, itemSerialAudit);
            
        }
        
        /// <summary>
        /// Test AddItemSerialFile
        /// </summary>
        [Test]
        public void AddItemSerialFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //string fileName = null;
            //instance.AddItemSerialFile(itemSerialId, fileName);
            
        }
        
        /// <summary>
        /// Test AddItemSerialFileByURL
        /// </summary>
        [Test]
        public void AddItemSerialFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? itemSerialId = null;
            //instance.AddItemSerialFileByURL(body, itemSerialId);
            
        }
        
        /// <summary>
        /// Test AddItemSerialTag
        /// </summary>
        [Test]
        public void AddItemSerialTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //string itemSerialTag = null;
            //instance.AddItemSerialTag(itemSerialId, itemSerialTag);
            
        }
        
        /// <summary>
        /// Test DeleteItemSerial
        /// </summary>
        [Test]
        public void DeleteItemSerialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //instance.DeleteItemSerial(itemSerialId);
            
        }
        
        /// <summary>
        /// Test DeleteItemSerialFile
        /// </summary>
        [Test]
        public void DeleteItemSerialFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //int? fileId = null;
            //instance.DeleteItemSerialFile(itemSerialId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteItemSerialTag
        /// </summary>
        [Test]
        public void DeleteItemSerialTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //string itemSerialTag = null;
            //instance.DeleteItemSerialTag(itemSerialId, itemSerialTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateItemSerialById
        /// </summary>
        [Test]
        public void GetDuplicateItemSerialByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //var response = instance.GetDuplicateItemSerialById(itemSerialId);
            //Assert.IsInstanceOf<ItemSerial> (response, "response is ItemSerial");
        }
        
        /// <summary>
        /// Test GetItemSerialByFilter
        /// </summary>
        [Test]
        public void GetItemSerialByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetItemSerialByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ItemSerial>> (response, "response is List<ItemSerial>");
        }
        
        /// <summary>
        /// Test GetItemSerialById
        /// </summary>
        [Test]
        public void GetItemSerialByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //var response = instance.GetItemSerialById(itemSerialId);
            //Assert.IsInstanceOf<ItemSerial> (response, "response is ItemSerial");
        }
        
        /// <summary>
        /// Test GetItemSerialFiles
        /// </summary>
        [Test]
        public void GetItemSerialFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //instance.GetItemSerialFiles(itemSerialId);
            
        }
        
        /// <summary>
        /// Test GetItemSerialTags
        /// </summary>
        [Test]
        public void GetItemSerialTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemSerialId = null;
            //instance.GetItemSerialTags(itemSerialId);
            
        }
        
        /// <summary>
        /// Test UpdateItemSerial
        /// </summary>
        [Test]
        public void UpdateItemSerialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemSerial body = null;
            //instance.UpdateItemSerial(body);
            
        }
        
    }

}
