﻿using DemoCommon.Models;
using DemoServer.Utils;
using DemoServer.Utils.Cache;
using DemoServer.Utils.Database;
using Microsoft.AspNetCore.Mvc;
#region Usings
using Raven.Client.Documents.Session;
#endregion

namespace DemoServer.Controllers.Demos.Basics.CreateDocument
{
    public class CreateDocumentController : DemoCodeController
    {
        public CreateDocumentController(HeadersAccessor headersAccessor, UserStoreCache userStoreCache, MediaStoreCache mediaStoreCache,
            DatabaseSetup databaseSetup) : base(headersAccessor, userStoreCache, mediaStoreCache, databaseSetup)
        {
        }

        [HttpPost]
        public IActionResult Run(RunParams runParams)
        {
            string companyName = runParams.CompanyName;
            string companyPhone = runParams.CompanyPhone;
            string contactName = runParams.ContactName;
            string contactTitle = runParams.ContactTitle;

            string theNewDocumentId;

            #region Demo 
            #region Step_1
            Company newCompany = new Company
            {
                Name = companyName,
                Phone = companyPhone,
                Contact = new Contact
                {
                    Name = contactName,
                    Title = contactTitle
                }
            };
            #endregion

            using (IDocumentSession session = DocumentStoreHolder.Store.OpenSession())
            {
                #region Step_2
                session.Store(newCompany);
                #endregion
                
                #region Step_3
                theNewDocumentId = newCompany.Id;
                #endregion
                
                #region Step_4
                session.SaveChanges();
                #endregion
            }
            #endregion

            return Ok($"Document {theNewDocumentId} was created successfully");
        }

        public class RunParams
        {
            public string CompanyName { get; set; }
            public string CompanyPhone { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
        }
    }
}
