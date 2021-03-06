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
    ///  Class for testing InvoiceWorksheetLineApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvoiceWorksheetLineApiTests
    {
        private InvoiceWorksheetLineApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoiceWorksheetLineApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceWorksheetLineApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoiceWorksheetLineApi
            //Assert.IsInstanceOfType(typeof(InvoiceWorksheetLineApi), instance, "instance is a InvoiceWorksheetLineApi");
        }

        
        /// <summary>
        /// Test AddInvoiceWorksheetLine
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceWorksheetLine body = null;
            //var response = instance.AddInvoiceWorksheetLine(body);
            //Assert.IsInstanceOf<InvoiceWorksheetLine> (response, "response is InvoiceWorksheetLine");
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineAudit
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //string invoiceWorksheetLineAudit = null;
            //instance.AddInvoiceWorksheetLineAudit(invoiceWorksheetLineId, invoiceWorksheetLineAudit);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineFile
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //string fileName = null;
            //instance.AddInvoiceWorksheetLineFile(invoiceWorksheetLineId, fileName);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineFileByURL
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? invoiceWorksheetLineId = null;
            //instance.AddInvoiceWorksheetLineFileByURL(body, invoiceWorksheetLineId);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineTag
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //string invoiceWorksheetLineTag = null;
            //instance.AddInvoiceWorksheetLineTag(invoiceWorksheetLineId, invoiceWorksheetLineTag);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheetLine
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //instance.DeleteInvoiceWorksheetLine(invoiceWorksheetLineId);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheetLineFile
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetLineFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //int? fileId = null;
            //instance.DeleteInvoiceWorksheetLineFile(invoiceWorksheetLineId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheetLineTag
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetLineTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //string invoiceWorksheetLineTag = null;
            //instance.DeleteInvoiceWorksheetLineTag(invoiceWorksheetLineId, invoiceWorksheetLineTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateInvoiceWorksheetLineById
        /// </summary>
        [Test]
        public void GetDuplicateInvoiceWorksheetLineByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //var response = instance.GetDuplicateInvoiceWorksheetLineById(invoiceWorksheetLineId);
            //Assert.IsInstanceOf<InvoiceWorksheetLine> (response, "response is InvoiceWorksheetLine");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineByFilter
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetInvoiceWorksheetLineByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<InvoiceWorksheetLine>> (response, "response is List<InvoiceWorksheetLine>");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineById
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //var response = instance.GetInvoiceWorksheetLineById(invoiceWorksheetLineId);
            //Assert.IsInstanceOf<InvoiceWorksheetLine> (response, "response is InvoiceWorksheetLine");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineFiles
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //instance.GetInvoiceWorksheetLineFiles(invoiceWorksheetLineId);
            
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineTags
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineId = null;
            //instance.GetInvoiceWorksheetLineTags(invoiceWorksheetLineId);
            
        }
        
        /// <summary>
        /// Test UpdateInvoiceWorksheetLine
        /// </summary>
        [Test]
        public void UpdateInvoiceWorksheetLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceWorksheetLine body = null;
            //instance.UpdateInvoiceWorksheetLine(body);
            
        }
        
    }

}
