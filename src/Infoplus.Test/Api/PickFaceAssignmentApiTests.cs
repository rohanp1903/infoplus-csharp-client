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
    ///  Class for testing PickFaceAssignmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PickFaceAssignmentApiTests
    {
        private PickFaceAssignmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PickFaceAssignmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PickFaceAssignmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PickFaceAssignmentApi
            //Assert.IsInstanceOfType(typeof(PickFaceAssignmentApi), instance, "instance is a PickFaceAssignmentApi");
        }

        
        /// <summary>
        /// Test AddPickFaceAssignment
        /// </summary>
        [Test]
        public void AddPickFaceAssignmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PickFaceAssignment body = null;
            //var response = instance.AddPickFaceAssignment(body);
            //Assert.IsInstanceOf<PickFaceAssignment> (response, "response is PickFaceAssignment");
        }
        
        /// <summary>
        /// Test AddPickFaceAssignmentAudit
        /// </summary>
        [Test]
        public void AddPickFaceAssignmentAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //string pickFaceAssignmentAudit = null;
            //instance.AddPickFaceAssignmentAudit(pickFaceAssignmentId, pickFaceAssignmentAudit);
            
        }
        
        /// <summary>
        /// Test AddPickFaceAssignmentFile
        /// </summary>
        [Test]
        public void AddPickFaceAssignmentFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //string fileName = null;
            //instance.AddPickFaceAssignmentFile(pickFaceAssignmentId, fileName);
            
        }
        
        /// <summary>
        /// Test AddPickFaceAssignmentFileByURL
        /// </summary>
        [Test]
        public void AddPickFaceAssignmentFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? pickFaceAssignmentId = null;
            //instance.AddPickFaceAssignmentFileByURL(body, pickFaceAssignmentId);
            
        }
        
        /// <summary>
        /// Test AddPickFaceAssignmentTag
        /// </summary>
        [Test]
        public void AddPickFaceAssignmentTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //string pickFaceAssignmentTag = null;
            //instance.AddPickFaceAssignmentTag(pickFaceAssignmentId, pickFaceAssignmentTag);
            
        }
        
        /// <summary>
        /// Test DeletePickFaceAssignment
        /// </summary>
        [Test]
        public void DeletePickFaceAssignmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //instance.DeletePickFaceAssignment(pickFaceAssignmentId);
            
        }
        
        /// <summary>
        /// Test DeletePickFaceAssignmentFile
        /// </summary>
        [Test]
        public void DeletePickFaceAssignmentFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //int? fileId = null;
            //instance.DeletePickFaceAssignmentFile(pickFaceAssignmentId, fileId);
            
        }
        
        /// <summary>
        /// Test DeletePickFaceAssignmentTag
        /// </summary>
        [Test]
        public void DeletePickFaceAssignmentTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //string pickFaceAssignmentTag = null;
            //instance.DeletePickFaceAssignmentTag(pickFaceAssignmentId, pickFaceAssignmentTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicatePickFaceAssignmentById
        /// </summary>
        [Test]
        public void GetDuplicatePickFaceAssignmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //var response = instance.GetDuplicatePickFaceAssignmentById(pickFaceAssignmentId);
            //Assert.IsInstanceOf<PickFaceAssignment> (response, "response is PickFaceAssignment");
        }
        
        /// <summary>
        /// Test GetPickFaceAssignmentByFilter
        /// </summary>
        [Test]
        public void GetPickFaceAssignmentByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetPickFaceAssignmentByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<PickFaceAssignment>> (response, "response is List<PickFaceAssignment>");
        }
        
        /// <summary>
        /// Test GetPickFaceAssignmentById
        /// </summary>
        [Test]
        public void GetPickFaceAssignmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //var response = instance.GetPickFaceAssignmentById(pickFaceAssignmentId);
            //Assert.IsInstanceOf<PickFaceAssignment> (response, "response is PickFaceAssignment");
        }
        
        /// <summary>
        /// Test GetPickFaceAssignmentFiles
        /// </summary>
        [Test]
        public void GetPickFaceAssignmentFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //instance.GetPickFaceAssignmentFiles(pickFaceAssignmentId);
            
        }
        
        /// <summary>
        /// Test GetPickFaceAssignmentTags
        /// </summary>
        [Test]
        public void GetPickFaceAssignmentTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pickFaceAssignmentId = null;
            //instance.GetPickFaceAssignmentTags(pickFaceAssignmentId);
            
        }
        
        /// <summary>
        /// Test UpdatePickFaceAssignment
        /// </summary>
        [Test]
        public void UpdatePickFaceAssignmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PickFaceAssignment body = null;
            //instance.UpdatePickFaceAssignment(body);
            
        }
        
        /// <summary>
        /// Test UpdatePickFaceAssignmentCustomFields
        /// </summary>
        [Test]
        public void UpdatePickFaceAssignmentCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PickFaceAssignment body = null;
            //instance.UpdatePickFaceAssignmentCustomFields(body);
            
        }
        
    }

}
