// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ControllersTests.cs">
//   Copyright (c) 2022 Aspose.Cells Dev
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Dev.SDK.Tests.API
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using Aspose.Cells.Dev.SDK.Model;
    using System.Collections.Generic;
    /// <summary>
    /// Test  of how to convert excel workbook to one of the available formats.
    /// </summary>
    [TestClass]
    public class ControllersTests 
    {
        private CellsDevApi instance;

        private readonly string remoteFolder = "TestData/In";


        public ControllersTests()
        {
            instance = new CellsDevApi(TestHelper.CellsDevHost,TestHelper.CellsDevVersion);
        }

        /// <summary>
        /// Test for conver workbook to one of the available formats.
        /// </summary>
        [TestMethod]
        [DataRow("pdf")]
        [DataRow("docx")]
        [DataRow("pptx")]
        [DataRow("json")]
        [DataRow("markdown")]
        [DataRow("png")]
        [DataRow("ods")]
        [DataRow("numbers")]
        [DataRow("html")]
        public void TestPostConvertWorkbook(string format)
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            ConvertRequest request = new ConvertRequest();
            request.Format = format;  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostConvertWorkbook(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for merge multi workbook into one of the available formats.
        /// </summary>
        [TestMethod]
        [DataRow("pdf")]
        [DataRow("docx")]
        [DataRow("pptx")]
        [DataRow("json")]
        [DataRow("markdown")]
        [DataRow("png")]
        [DataRow("ods")]
        [DataRow("numbers")]
        [DataRow("html")]
        public void TestPostMerge(string format)
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            MergeRequest request = new MergeRequest();
            request.Format = format;  
            request.InOneSheet = true;  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostMerge(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for split files to  the available format files.
        /// </summary>
        [TestMethod]
        [DataRow("pdf")]
        [DataRow("docx")]
        [DataRow("pptx")]
        [DataRow("json")]
        [DataRow("markdown")]
        [DataRow("png")]
        [DataRow("ods")]
        [DataRow("numbers")]
        [DataRow("html")]
        public void TestPostSplit(string format)
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            SplitRequest request = new SplitRequest();
            request.Format = format;  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostSplit(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for search text in files.
        /// </summary>
        [TestMethod]
        [DataRow("123")]
        [DataRow("test")]
        public void TestPostSearch(string text)
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            SearchRequest request = new SearchRequest();
            request.Text = text;  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostSearch(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for replace in files.
        /// </summary>
        [TestMethod]
        [DataRow("123","456")]
        [DataRow("testnew","testold")]
        public void TestPostReplace(string newValue,string oldValue)
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            ReplaceRequest request = new ReplaceRequest();
            request.NewValue = newValue;  
            request.OldValue = oldValue;  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostReplace(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for encrypt files with password.
        /// </summary>
        [TestMethod]
        public void TestPostEncryptWithPassword()
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            ProtectionRequest request = new ProtectionRequest();
            request.Password = "123456";  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostEncryptWithPassword(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for decrypt files with password.
        /// </summary>
        [TestMethod]
        public void TestPostDecryptWithPassword()
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";

         
            ProtectionRequest request = new ProtectionRequest();
            request.Password = "123456";  
             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostDecryptWithPassword(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for digital signature for files.
        /// </summary>
        [TestMethod]
        public void TestPostDigitalSignature()
        {
            string localBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";
            string localPfx = "roywang.pfx";

         
            DigitalSignaturRequest request = new DigitalSignaturRequest();
             
            DigitalSignaturFile pfxfiles = new DigitalSignaturFile();
            pfxfiles.Name = localBook1;  
            pfxfiles.Password = "123456";  
            pfxfiles.Data =  TestHelper.ToRequestFileFromFile(localPfx).Data;  
            request.DigitalSignaturFiles.Add(pfxfiles);

             
            RequestFile book1 = new RequestFile();
            book1.Name = localBook1;  
            book1.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(book1);
            RequestFile myDoc = new RequestFile();
            myDoc.Name = localMyDoc;  
            myDoc.Data =  TestHelper.ToRequestFileFromFile(localMyDoc).Data;  
            request.Files.Add(myDoc);
             

            var actual =  this.instance.PostDigitalSignature(request);
            Assert.IsNotNull(actual);
        }
    }
}
