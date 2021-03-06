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
    ///  Class for testing ParcelAccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ParcelAccountApiTests
    {
        private ParcelAccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ParcelAccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ParcelAccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ParcelAccountApi
            //Assert.IsInstanceOfType(typeof(ParcelAccountApi), instance, "instance is a ParcelAccountApi");
        }

        
        /// <summary>
        /// Test AddParcelAccountAudit
        /// </summary>
        [Test]
        public void AddParcelAccountAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //string parcelAccountAudit = null;
            //instance.AddParcelAccountAudit(parcelAccountId, parcelAccountAudit);
            
        }
        
        /// <summary>
        /// Test AddParcelAccountFile
        /// </summary>
        [Test]
        public void AddParcelAccountFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //string fileName = null;
            //instance.AddParcelAccountFile(parcelAccountId, fileName);
            
        }
        
        /// <summary>
        /// Test AddParcelAccountFileByURL
        /// </summary>
        [Test]
        public void AddParcelAccountFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? parcelAccountId = null;
            //instance.AddParcelAccountFileByURL(body, parcelAccountId);
            
        }
        
        /// <summary>
        /// Test AddParcelAccountTag
        /// </summary>
        [Test]
        public void AddParcelAccountTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //string parcelAccountTag = null;
            //instance.AddParcelAccountTag(parcelAccountId, parcelAccountTag);
            
        }
        
        /// <summary>
        /// Test DeleteParcelAccountFile
        /// </summary>
        [Test]
        public void DeleteParcelAccountFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //int? fileId = null;
            //instance.DeleteParcelAccountFile(parcelAccountId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteParcelAccountTag
        /// </summary>
        [Test]
        public void DeleteParcelAccountTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //string parcelAccountTag = null;
            //instance.DeleteParcelAccountTag(parcelAccountId, parcelAccountTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateParcelAccountById
        /// </summary>
        [Test]
        public void GetDuplicateParcelAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //var response = instance.GetDuplicateParcelAccountById(parcelAccountId);
            //Assert.IsInstanceOf<ParcelAccount> (response, "response is ParcelAccount");
        }
        
        /// <summary>
        /// Test GetParcelAccountByFilter
        /// </summary>
        [Test]
        public void GetParcelAccountByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetParcelAccountByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ParcelAccount>> (response, "response is List<ParcelAccount>");
        }
        
        /// <summary>
        /// Test GetParcelAccountById
        /// </summary>
        [Test]
        public void GetParcelAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //var response = instance.GetParcelAccountById(parcelAccountId);
            //Assert.IsInstanceOf<ParcelAccount> (response, "response is ParcelAccount");
        }
        
        /// <summary>
        /// Test GetParcelAccountFiles
        /// </summary>
        [Test]
        public void GetParcelAccountFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //instance.GetParcelAccountFiles(parcelAccountId);
            
        }
        
        /// <summary>
        /// Test GetParcelAccountTags
        /// </summary>
        [Test]
        public void GetParcelAccountTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parcelAccountId = null;
            //instance.GetParcelAccountTags(parcelAccountId);
            
        }
        
        /// <summary>
        /// Test UpdateParcelAccountCustomFields
        /// </summary>
        [Test]
        public void UpdateParcelAccountCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ParcelAccount body = null;
            //instance.UpdateParcelAccountCustomFields(body);
            
        }
        
    }

}
