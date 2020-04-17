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
    ///  Class for testing WarehouseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WarehouseApiTests
    {
        private WarehouseApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WarehouseApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WarehouseApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WarehouseApi
            //Assert.IsInstanceOfType(typeof(WarehouseApi), instance, "instance is a WarehouseApi");
        }

        
        /// <summary>
        /// Test AddWarehouseAudit
        /// </summary>
        [Test]
        public void AddWarehouseAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //string warehouseAudit = null;
            //instance.AddWarehouseAudit(warehouseId, warehouseAudit);
            
        }
        
        /// <summary>
        /// Test AddWarehouseFile
        /// </summary>
        [Test]
        public void AddWarehouseFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //string fileName = null;
            //instance.AddWarehouseFile(warehouseId, fileName);
            
        }
        
        /// <summary>
        /// Test AddWarehouseFileByURL
        /// </summary>
        [Test]
        public void AddWarehouseFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? warehouseId = null;
            //instance.AddWarehouseFileByURL(body, warehouseId);
            
        }
        
        /// <summary>
        /// Test AddWarehouseTag
        /// </summary>
        [Test]
        public void AddWarehouseTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //string warehouseTag = null;
            //instance.AddWarehouseTag(warehouseId, warehouseTag);
            
        }
        
        /// <summary>
        /// Test DeleteWarehouseFile
        /// </summary>
        [Test]
        public void DeleteWarehouseFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //int? fileId = null;
            //instance.DeleteWarehouseFile(warehouseId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteWarehouseTag
        /// </summary>
        [Test]
        public void DeleteWarehouseTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //string warehouseTag = null;
            //instance.DeleteWarehouseTag(warehouseId, warehouseTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateWarehouseById
        /// </summary>
        [Test]
        public void GetDuplicateWarehouseByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //var response = instance.GetDuplicateWarehouseById(warehouseId);
            //Assert.IsInstanceOf<Warehouse> (response, "response is Warehouse");
        }
        
        /// <summary>
        /// Test GetWarehouseByFilter
        /// </summary>
        [Test]
        public void GetWarehouseByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetWarehouseByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Warehouse>> (response, "response is List<Warehouse>");
        }
        
        /// <summary>
        /// Test GetWarehouseById
        /// </summary>
        [Test]
        public void GetWarehouseByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //var response = instance.GetWarehouseById(warehouseId);
            //Assert.IsInstanceOf<Warehouse> (response, "response is Warehouse");
        }
        
        /// <summary>
        /// Test GetWarehouseFiles
        /// </summary>
        [Test]
        public void GetWarehouseFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //instance.GetWarehouseFiles(warehouseId);
            
        }
        
        /// <summary>
        /// Test GetWarehouseTags
        /// </summary>
        [Test]
        public void GetWarehouseTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warehouseId = null;
            //instance.GetWarehouseTags(warehouseId);
            
        }
        
        /// <summary>
        /// Test UpdateWarehouse
        /// </summary>
        [Test]
        public void UpdateWarehouseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Warehouse body = null;
            //instance.UpdateWarehouse(body);
            
        }
        
        /// <summary>
        /// Test UpdateWarehouseCustomFields
        /// </summary>
        [Test]
        public void UpdateWarehouseCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Warehouse body = null;
            //instance.UpdateWarehouseCustomFields(body);
            
        }
        
    }

}
