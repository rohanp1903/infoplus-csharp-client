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
    ///  Class for testing WorkActivityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkActivityApiTests
    {
        private WorkActivityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkActivityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkActivityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkActivityApi
            //Assert.IsInstanceOfType(typeof(WorkActivityApi), instance, "instance is a WorkActivityApi");
        }

        
        /// <summary>
        /// Test AddWorkActivity
        /// </summary>
        [Test]
        public void AddWorkActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WorkActivity body = null;
            //var response = instance.AddWorkActivity(body);
            //Assert.IsInstanceOf<WorkActivity> (response, "response is WorkActivity");
        }
        
        /// <summary>
        /// Test AddWorkActivityAudit
        /// </summary>
        [Test]
        public void AddWorkActivityAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //string workActivityAudit = null;
            //instance.AddWorkActivityAudit(workActivityId, workActivityAudit);
            
        }
        
        /// <summary>
        /// Test AddWorkActivityFile
        /// </summary>
        [Test]
        public void AddWorkActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //string fileName = null;
            //instance.AddWorkActivityFile(workActivityId, fileName);
            
        }
        
        /// <summary>
        /// Test AddWorkActivityFileByURL
        /// </summary>
        [Test]
        public void AddWorkActivityFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? workActivityId = null;
            //instance.AddWorkActivityFileByURL(body, workActivityId);
            
        }
        
        /// <summary>
        /// Test AddWorkActivityTag
        /// </summary>
        [Test]
        public void AddWorkActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //string workActivityTag = null;
            //instance.AddWorkActivityTag(workActivityId, workActivityTag);
            
        }
        
        /// <summary>
        /// Test DeleteWorkActivity
        /// </summary>
        [Test]
        public void DeleteWorkActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //instance.DeleteWorkActivity(workActivityId);
            
        }
        
        /// <summary>
        /// Test DeleteWorkActivityFile
        /// </summary>
        [Test]
        public void DeleteWorkActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //int? fileId = null;
            //instance.DeleteWorkActivityFile(workActivityId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteWorkActivityTag
        /// </summary>
        [Test]
        public void DeleteWorkActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //string workActivityTag = null;
            //instance.DeleteWorkActivityTag(workActivityId, workActivityTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateWorkActivityById
        /// </summary>
        [Test]
        public void GetDuplicateWorkActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //var response = instance.GetDuplicateWorkActivityById(workActivityId);
            //Assert.IsInstanceOf<WorkActivity> (response, "response is WorkActivity");
        }
        
        /// <summary>
        /// Test GetWorkActivityByFilter
        /// </summary>
        [Test]
        public void GetWorkActivityByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetWorkActivityByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<WorkActivity>> (response, "response is List<WorkActivity>");
        }
        
        /// <summary>
        /// Test GetWorkActivityById
        /// </summary>
        [Test]
        public void GetWorkActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //var response = instance.GetWorkActivityById(workActivityId);
            //Assert.IsInstanceOf<WorkActivity> (response, "response is WorkActivity");
        }
        
        /// <summary>
        /// Test GetWorkActivityFiles
        /// </summary>
        [Test]
        public void GetWorkActivityFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //instance.GetWorkActivityFiles(workActivityId);
            
        }
        
        /// <summary>
        /// Test GetWorkActivityTags
        /// </summary>
        [Test]
        public void GetWorkActivityTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workActivityId = null;
            //instance.GetWorkActivityTags(workActivityId);
            
        }
        
        /// <summary>
        /// Test UpdateWorkActivity
        /// </summary>
        [Test]
        public void UpdateWorkActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WorkActivity body = null;
            //instance.UpdateWorkActivity(body);
            
        }
        
    }

}
