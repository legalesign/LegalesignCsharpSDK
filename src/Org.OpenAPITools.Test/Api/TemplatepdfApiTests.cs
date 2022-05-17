/*
 * Legalesign API
 *
 * Legalesign.com is an electronic signature software. This is the documentation for its REST API.   Start by creating a trial account at https://app1.legalesign.com/auth/intro/. Upon account activation, select the API dev option.  Get an API key by emailing support@legalesign with background on your use-case and skills. You will need to show experience in API dev.  You will be in sandbox mode that will limit you to 5 signers. Add them on https://app1.legalesign.com/acc/settings/#api. Contact support to move to production mode when you are ready.  For any queries contact us at support@legalesign.com. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@legalesign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing TemplatepdfApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TemplatepdfApiTests
    {
        private TemplatepdfApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplatepdfApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplatepdfApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TemplatepdfApi
            //Assert.IsInstanceOf(typeof(TemplatepdfApi), instance);
        }

        
        /// <summary>
        /// Test GetPdfTemplate
        /// </summary>
        [Test]
        public void GetPdfTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid pdfId = null;
            //var response = instance.GetPdfTemplate(pdfId);
            //Assert.IsInstanceOf(typeof(TemplatePdfResponse), response, "response is TemplatePdfResponse");
        }
        
        /// <summary>
        /// Test GetPdfTemplateFields
        /// </summary>
        [Test]
        public void GetPdfTemplateFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid pdfId = null;
            //var response = instance.GetPdfTemplateFields(pdfId);
            //Assert.IsInstanceOf(typeof(TemplatePdfFieldsList), response, "response is TemplatePdfFieldsList");
        }
        
        /// <summary>
        /// Test GetPdfTemplates
        /// </summary>
        [Test]
        public void GetPdfTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string archive = null;
            //string group = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetPdfTemplates(archive, group, limit, offset);
            //Assert.IsInstanceOf(typeof(TemplatePdfListResponse), response, "response is TemplatePdfListResponse");
        }
        
        /// <summary>
        /// Test PostPdfTemplate
        /// </summary>
        [Test]
        public void PostPdfTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatePdfFieldPost templatePdfFieldPost = null;
            //instance.PostPdfTemplate(templatePdfFieldPost);
            
        }
        
        /// <summary>
        /// Test PostPdfTemplateFields
        /// </summary>
        [Test]
        public void PostPdfTemplateFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid pdfId = null;
            //List<PdfFieldsPost> pdfFieldsPost = null;
            //instance.PostPdfTemplateFields(pdfId, pdfFieldsPost);
            
        }
        
        /// <summary>
        /// Test PostPdfTemplateTags
        /// </summary>
        [Test]
        public void PostPdfTemplateTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pdfId = null;
            //instance.PostPdfTemplateTags(pdfId);
            
        }
        
    }

}
