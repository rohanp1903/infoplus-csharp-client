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
    ///  Class for testing FulfillmentPlan
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FulfillmentPlanTests
    {
        // TODO uncomment below to declare an instance variable for FulfillmentPlan
        //private FulfillmentPlan instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FulfillmentPlan
            //instance = new FulfillmentPlan();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentPlan
        /// </summary>
        [Test]
        public void FulfillmentPlanInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FulfillmentPlan
            //Assert.IsInstanceOfType<FulfillmentPlan> (instance, "variable 'instance' is a FulfillmentPlan");
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'PriorityCode'
        /// </summary>
        [Test]
        public void PriorityCodeTest()
        {
            // TODO unit test for the property 'PriorityCode'
        }
        /// <summary>
        /// Test the property 'LastRunTime'
        /// </summary>
        [Test]
        public void LastRunTimeTest()
        {
            // TODO unit test for the property 'LastRunTime'
        }
        /// <summary>
        /// Test the property 'OrderSmartFilterId'
        /// </summary>
        [Test]
        public void OrderSmartFilterIdTest()
        {
            // TODO unit test for the property 'OrderSmartFilterId'
        }
        /// <summary>
        /// Test the property 'LocationSmartFilterId'
        /// </summary>
        [Test]
        public void LocationSmartFilterIdTest()
        {
            // TODO unit test for the property 'LocationSmartFilterId'
        }
        /// <summary>
        /// Test the property 'MaxOrders'
        /// </summary>
        [Test]
        public void MaxOrdersTest()
        {
            // TODO unit test for the property 'MaxOrders'
        }
        /// <summary>
        /// Test the property 'BatchSizeMax'
        /// </summary>
        [Test]
        public void BatchSizeMaxTest()
        {
            // TODO unit test for the property 'BatchSizeMax'
        }
        /// <summary>
        /// Test the property 'BatchSizeMin'
        /// </summary>
        [Test]
        public void BatchSizeMinTest()
        {
            // TODO unit test for the property 'BatchSizeMin'
        }
        /// <summary>
        /// Test the property 'MaxCartons'
        /// </summary>
        [Test]
        public void MaxCartonsTest()
        {
            // TODO unit test for the property 'MaxCartons'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'IsMassDistribution'
        /// </summary>
        [Test]
        public void IsMassDistributionTest()
        {
            // TODO unit test for the property 'IsMassDistribution'
        }
        /// <summary>
        /// Test the property 'CreatePickWork'
        /// </summary>
        [Test]
        public void CreatePickWorkTest()
        {
            // TODO unit test for the property 'CreatePickWork'
        }
        /// <summary>
        /// Test the property 'PickingRule'
        /// </summary>
        [Test]
        public void PickingRuleTest()
        {
            // TODO unit test for the property 'PickingRule'
        }
        /// <summary>
        /// Test the property 'PickBatchGroupId'
        /// </summary>
        [Test]
        public void PickBatchGroupIdTest()
        {
            // TODO unit test for the property 'PickBatchGroupId'
        }
        /// <summary>
        /// Test the property 'MaxSKUsPerBatch'
        /// </summary>
        [Test]
        public void MaxSKUsPerBatchTest()
        {
            // TODO unit test for the property 'MaxSKUsPerBatch'
        }
        /// <summary>
        /// Test the property 'LayoutRule'
        /// </summary>
        [Test]
        public void LayoutRuleTest()
        {
            // TODO unit test for the property 'LayoutRule'
        }
        /// <summary>
        /// Test the property 'PickSortRule'
        /// </summary>
        [Test]
        public void PickSortRuleTest()
        {
            // TODO unit test for the property 'PickSortRule'
        }
        /// <summary>
        /// Test the property 'LocationSort'
        /// </summary>
        [Test]
        public void LocationSortTest()
        {
            // TODO unit test for the property 'LocationSort'
        }
        /// <summary>
        /// Test the property 'CreatePickList'
        /// </summary>
        [Test]
        public void CreatePickListTest()
        {
            // TODO unit test for the property 'CreatePickList'
        }
        /// <summary>
        /// Test the property 'PickListFormat'
        /// </summary>
        [Test]
        public void PickListFormatTest()
        {
            // TODO unit test for the property 'PickListFormat'
        }
        /// <summary>
        /// Test the property 'PickListLayout'
        /// </summary>
        [Test]
        public void PickListLayoutTest()
        {
            // TODO unit test for the property 'PickListLayout'
        }
        /// <summary>
        /// Test the property 'PickListGroup'
        /// </summary>
        [Test]
        public void PickListGroupTest()
        {
            // TODO unit test for the property 'PickListGroup'
        }
        /// <summary>
        /// Test the property 'PickListSort'
        /// </summary>
        [Test]
        public void PickListSortTest()
        {
            // TODO unit test for the property 'PickListSort'
        }
        /// <summary>
        /// Test the property 'PickListLocationSort'
        /// </summary>
        [Test]
        public void PickListLocationSortTest()
        {
            // TODO unit test for the property 'PickListLocationSort'
        }
        /// <summary>
        /// Test the property 'CreatePickSummary'
        /// </summary>
        [Test]
        public void CreatePickSummaryTest()
        {
            // TODO unit test for the property 'CreatePickSummary'
        }
        /// <summary>
        /// Test the property 'PickSummaryFormat'
        /// </summary>
        [Test]
        public void PickSummaryFormatTest()
        {
            // TODO unit test for the property 'PickSummaryFormat'
        }
        /// <summary>
        /// Test the property 'PickSummaryLayout'
        /// </summary>
        [Test]
        public void PickSummaryLayoutTest()
        {
            // TODO unit test for the property 'PickSummaryLayout'
        }
        /// <summary>
        /// Test the property 'PickSummarySort'
        /// </summary>
        [Test]
        public void PickSummarySortTest()
        {
            // TODO unit test for the property 'PickSummarySort'
        }
        /// <summary>
        /// Test the property 'PickScanSchemeId'
        /// </summary>
        [Test]
        public void PickScanSchemeIdTest()
        {
            // TODO unit test for the property 'PickScanSchemeId'
        }
        /// <summary>
        /// Test the property 'CartonizeOrders'
        /// </summary>
        [Test]
        public void CartonizeOrdersTest()
        {
            // TODO unit test for the property 'CartonizeOrders'
        }
        /// <summary>
        /// Test the property 'CartonizationScriptId'
        /// </summary>
        [Test]
        public void CartonizationScriptIdTest()
        {
            // TODO unit test for the property 'CartonizationScriptId'
        }
        /// <summary>
        /// Test the property 'AutoShipCasebreakCartons'
        /// </summary>
        [Test]
        public void AutoShipCasebreakCartonsTest()
        {
            // TODO unit test for the property 'AutoShipCasebreakCartons'
        }
        /// <summary>
        /// Test the property 'AutoShipOrders'
        /// </summary>
        [Test]
        public void AutoShipOrdersTest()
        {
            // TODO unit test for the property 'AutoShipOrders'
        }
        /// <summary>
        /// Test the property 'PreGenerateParcelLabels'
        /// </summary>
        [Test]
        public void PreGenerateParcelLabelsTest()
        {
            // TODO unit test for the property 'PreGenerateParcelLabels'
        }
        /// <summary>
        /// Test the property 'LabelSort'
        /// </summary>
        [Test]
        public void LabelSortTest()
        {
            // TODO unit test for the property 'LabelSort'
        }
        /// <summary>
        /// Test the property 'CreatePackingSlip'
        /// </summary>
        [Test]
        public void CreatePackingSlipTest()
        {
            // TODO unit test for the property 'CreatePackingSlip'
        }
        /// <summary>
        /// Test the property 'OverridePackingSlipTemplateId'
        /// </summary>
        [Test]
        public void OverridePackingSlipTemplateIdTest()
        {
            // TODO unit test for the property 'OverridePackingSlipTemplateId'
        }
        /// <summary>
        /// Test the property 'CreateOrderAssemblyGuide'
        /// </summary>
        [Test]
        public void CreateOrderAssemblyGuideTest()
        {
            // TODO unit test for the property 'CreateOrderAssemblyGuide'
        }
        /// <summary>
        /// Test the property 'CreateOrderInvoice'
        /// </summary>
        [Test]
        public void CreateOrderInvoiceTest()
        {
            // TODO unit test for the property 'CreateOrderInvoice'
        }
        /// <summary>
        /// Test the property 'OverrideOrderInvoiceTemplateId'
        /// </summary>
        [Test]
        public void OverrideOrderInvoiceTemplateIdTest()
        {
            // TODO unit test for the property 'OverrideOrderInvoiceTemplateId'
        }
        /// <summary>
        /// Test the property 'SendToExternalShippingSystem'
        /// </summary>
        [Test]
        public void SendToExternalShippingSystemTest()
        {
            // TODO unit test for the property 'SendToExternalShippingSystem'
        }
        /// <summary>
        /// Test the property 'ExternalShippingSystemId'
        /// </summary>
        [Test]
        public void ExternalShippingSystemIdTest()
        {
            // TODO unit test for the property 'ExternalShippingSystemId'
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
