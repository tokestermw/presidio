/* 
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * OpenAPI spec version: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Model;
using Microsoft.Presidio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Microsoft.Presidio.Test
{
    /// <summary>
    ///  Class for testing AnonymizerResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AnonymizerResultTests
    {
        private AnonymizerResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnonymizerResult(start: 10, end: 100, entityType: "PERSON");
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnonymizerResult
        /// </summary>
        [Test]
        public void AnonymizerResultInstanceTest()
        {
            Assert.IsInstanceOfType(typeof(AnonymizerResult), instance, "variable 'instance' is a AnonymizerResult");
        }


        /// <summary>
        /// Test the property 'Start'
        /// </summary>
        [Test]
        public void StartTest()
        {
            Assert.IsTrue(instance.Start == 10);
        }
        /// <summary>
        /// Test the property 'End'
        /// </summary>
        [Test]
        public void EndTest()
        {
            Assert.IsTrue(instance.End == 100);
        }
        /// <summary>
        /// Test the property 'EntityType'
        /// </summary>
        [Test]
        public void EntityTypeTest()
        {
            Assert.IsTrue(instance.EntityType == "PERSON");
        }

    }

}