/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Infoplus.Api;
using Infoplus.Model;
using Infoplus.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing Job
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class JobTests
    {
        // TODO uncomment below to declare an instance variable for Job
        //private Job instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Job
            //instance = new Job();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Job
        /// </summary>
        [Test]
        public void JobInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Job
            //Assert.IsInstanceOfType<Job> (instance, "variable 'instance' is a Job");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'ModifyDate'
        /// </summary>
        [Test]
        public void ModifyDateTest()
        {
            // TODO unit test for the property 'ModifyDate'
        }
        /// <summary>
        /// Test the property 'SourceJobRecipeId'
        /// </summary>
        [Test]
        public void SourceJobRecipeIdTest()
        {
            // TODO unit test for the property 'SourceJobRecipeId'
        }
        /// <summary>
        /// Test the property 'AssemblyQuantity'
        /// </summary>
        [Test]
        public void AssemblyQuantityTest()
        {
            // TODO unit test for the property 'AssemblyQuantity'
        }
        /// <summary>
        /// Test the property 'WarehouseId'
        /// </summary>
        [Test]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
        }
        /// <summary>
        /// Test the property 'LobId'
        /// </summary>
        [Test]
        public void LobIdTest()
        {
            // TODO unit test for the property 'LobId'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'OrderNoId'
        /// </summary>
        [Test]
        public void OrderNoIdTest()
        {
            // TODO unit test for the property 'OrderNoId'
        }
        /// <summary>
        /// Test the property 'PoNoId'
        /// </summary>
        [Test]
        public void PoNoIdTest()
        {
            // TODO unit test for the property 'PoNoId'
        }
        /// <summary>
        /// Test the property 'WorkBatchId'
        /// </summary>
        [Test]
        public void WorkBatchIdTest()
        {
            // TODO unit test for the property 'WorkBatchId'
        }
        /// <summary>
        /// Test the property 'Layout'
        /// </summary>
        [Test]
        public void LayoutTest()
        {
            // TODO unit test for the property 'Layout'
        }
        /// <summary>
        /// Test the property 'TrackAssemblies'
        /// </summary>
        [Test]
        public void TrackAssembliesTest()
        {
            // TODO unit test for the property 'TrackAssemblies'
        }
        /// <summary>
        /// Test the property 'TrackSteps'
        /// </summary>
        [Test]
        public void TrackStepsTest()
        {
            // TODO unit test for the property 'TrackSteps'
        }
        /// <summary>
        /// Test the property 'JobNo'
        /// </summary>
        [Test]
        public void JobNoTest()
        {
            // TODO unit test for the property 'JobNo'
        }
        /// <summary>
        /// Test the property 'AssemblyInstructions'
        /// </summary>
        [Test]
        public void AssemblyInstructionsTest()
        {
            // TODO unit test for the property 'AssemblyInstructions'
        }
        /// <summary>
        /// Test the property 'Inputs'
        /// </summary>
        [Test]
        public void InputsTest()
        {
            // TODO unit test for the property 'Inputs'
        }
        /// <summary>
        /// Test the property 'Outputs'
        /// </summary>
        [Test]
        public void OutputsTest()
        {
            // TODO unit test for the property 'Outputs'
        }
        /// <summary>
        /// Test the property 'Steps'
        /// </summary>
        [Test]
        public void StepsTest()
        {
            // TODO unit test for the property 'Steps'
        }
        /// <summary>
        /// Test the property 'FulfillmentPlanId'
        /// </summary>
        [Test]
        public void FulfillmentPlanIdTest()
        {
            // TODO unit test for the property 'FulfillmentPlanId'
        }
        /// <summary>
        /// Test the property 'TotalPicksPutbacks'
        /// </summary>
        [Test]
        public void TotalPicksPutbacksTest()
        {
            // TODO unit test for the property 'TotalPicksPutbacks'
        }
        /// <summary>
        /// Test the property 'CompletedPicksPutbacks'
        /// </summary>
        [Test]
        public void CompletedPicksPutbacksTest()
        {
            // TODO unit test for the property 'CompletedPicksPutbacks'
        }
        /// <summary>
        /// Test the property 'TotalAssemblies'
        /// </summary>
        [Test]
        public void TotalAssembliesTest()
        {
            // TODO unit test for the property 'TotalAssemblies'
        }
        /// <summary>
        /// Test the property 'CompletedAssemblies'
        /// </summary>
        [Test]
        public void CompletedAssembliesTest()
        {
            // TODO unit test for the property 'CompletedAssemblies'
        }
        /// <summary>
        /// Test the property 'TotalSteps'
        /// </summary>
        [Test]
        public void TotalStepsTest()
        {
            // TODO unit test for the property 'TotalSteps'
        }
        /// <summary>
        /// Test the property 'CompletedSteps'
        /// </summary>
        [Test]
        public void CompletedStepsTest()
        {
            // TODO unit test for the property 'CompletedSteps'
        }
        /// <summary>
        /// Test the property 'TotalReceipts'
        /// </summary>
        [Test]
        public void TotalReceiptsTest()
        {
            // TODO unit test for the property 'TotalReceipts'
        }
        /// <summary>
        /// Test the property 'CompletedReceipts'
        /// </summary>
        [Test]
        public void CompletedReceiptsTest()
        {
            // TODO unit test for the property 'CompletedReceipts'
        }
        /// <summary>
        /// Test the property 'TotalToDo'
        /// </summary>
        [Test]
        public void TotalToDoTest()
        {
            // TODO unit test for the property 'TotalToDo'
        }
        /// <summary>
        /// Test the property 'CompletedToDo'
        /// </summary>
        [Test]
        public void CompletedToDoTest()
        {
            // TODO unit test for the property 'CompletedToDo'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }

    }

}
