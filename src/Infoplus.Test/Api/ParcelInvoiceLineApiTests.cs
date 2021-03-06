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
    ///  Class for testing ParcelInvoiceLineApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ParcelInvoiceLineApiTests
    {
        private ParcelInvoiceLineApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ParcelInvoiceLineApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ParcelInvoiceLineApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ParcelInvoiceLineApi
            //Assert.IsInstanceOfType(typeof(ParcelInvoiceLineApi), instance, "instance is a ParcelInvoiceLineApi");
        }

        
        /// <summary>
        /// Test AddParcelInvoiceLineAudit
        /// </summary>
        [Test]
        public void AddParcelInvoiceLineAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //string parcelInvoiceLineAudit = null;
            //instance.AddParcelInvoiceLineAudit(parcelInvoiceLineId, parcelInvoiceLineAudit);
            
        }
        
        /// <summary>
        /// Test AddParcelInvoiceLineFile
        /// </summary>
        [Test]
        public void AddParcelInvoiceLineFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //string fileName = null;
            //instance.AddParcelInvoiceLineFile(parcelInvoiceLineId, fileName);
            
        }
        
        /// <summary>
        /// Test AddParcelInvoiceLineFileByURL
        /// </summary>
        [Test]
        public void AddParcelInvoiceLineFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? parcelInvoiceLineId = null;
            //instance.AddParcelInvoiceLineFileByURL(body, parcelInvoiceLineId);
            
        }
        
        /// <summary>
        /// Test AddParcelInvoiceLineTag
        /// </summary>
        [Test]
        public void AddParcelInvoiceLineTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //string parcelInvoiceLineTag = null;
            //instance.AddParcelInvoiceLineTag(parcelInvoiceLineId, parcelInvoiceLineTag);
            
        }
        
        /// <summary>
        /// Test DeleteParcelInvoiceLineFile
        /// </summary>
        [Test]
        public void DeleteParcelInvoiceLineFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //int? fileId = null;
            //instance.DeleteParcelInvoiceLineFile(parcelInvoiceLineId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteParcelInvoiceLineTag
        /// </summary>
        [Test]
        public void DeleteParcelInvoiceLineTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //string parcelInvoiceLineTag = null;
            //instance.DeleteParcelInvoiceLineTag(parcelInvoiceLineId, parcelInvoiceLineTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateParcelInvoiceLineById
        /// </summary>
        [Test]
        public void GetDuplicateParcelInvoiceLineByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //var response = instance.GetDuplicateParcelInvoiceLineById(parcelInvoiceLineId);
            //Assert.IsInstanceOf<ParcelInvoiceLine> (response, "response is ParcelInvoiceLine");
        }
        
        /// <summary>
        /// Test GetParcelInvoiceLineByFilter
        /// </summary>
        [Test]
        public void GetParcelInvoiceLineByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetParcelInvoiceLineByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ParcelInvoiceLine>> (response, "response is List<ParcelInvoiceLine>");
        }
        
        /// <summary>
        /// Test GetParcelInvoiceLineById
        /// </summary>
        [Test]
        public void GetParcelInvoiceLineByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //var response = instance.GetParcelInvoiceLineById(parcelInvoiceLineId);
            //Assert.IsInstanceOf<ParcelInvoiceLine> (response, "response is ParcelInvoiceLine");
        }
        
        /// <summary>
        /// Test GetParcelInvoiceLineFiles
        /// </summary>
        [Test]
        public void GetParcelInvoiceLineFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //instance.GetParcelInvoiceLineFiles(parcelInvoiceLineId);
            
        }
        
        /// <summary>
        /// Test GetParcelInvoiceLineTags
        /// </summary>
        [Test]
        public void GetParcelInvoiceLineTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelInvoiceLineId = null;
            //instance.GetParcelInvoiceLineTags(parcelInvoiceLineId);
            
        }
        
        /// <summary>
        /// Test UpdateParcelInvoiceLine
        /// </summary>
        [Test]
        public void UpdateParcelInvoiceLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ParcelInvoiceLine body = null;
            //instance.UpdateParcelInvoiceLine(body);
            
        }
        
    }

}
