// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsDevApi.cs">
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

namespace Aspose.Cells.Dev.SDK
{
    using Aspose.Cells.Dev.SDK.Model;
    using System.Collections.Generic;
    using System.Net;
    using Aspose.Cells.Dev.SDK.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// Aspose.Cells Dev API.
    /// </summary>
    public class CellsDevApi
    {
		private ApiInvoker ApiInvoker { get; set; }
		private string Host { get; set; }
		private string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecrent"></param>
        /// <param name="baseUrl"></param>
        /// <param name="version"></param>
        public CellsDevApi(string basePath = "https://api.conholdate.cloud",string version = "v1.0")    
        {
            this.Host = basePath;
            this.Version = version;
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new ApiExceptionRequestHandler());
            ApiInvoker = new ApiInvoker(requestHandlers);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        public CellsDevApi(string clientId, string clientSecret, string basePath = "https://api.conholdate.cloud", string version = "v1.0")
        {
            this.Host = basePath;
            this.Version = version;
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new ApiExceptionRequestHandler());
            if (!string.IsNullOrEmpty(clientId) && !string.IsNullOrEmpty(clientSecret))
            {
                requestHandlers.Add(new JwtTokenRequestHandler(basePath, clientId, clientSecret));
            }
            ApiInvoker = new ApiInvoker(requestHandlers);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetHealthStatusRequest" /></param>
        public string GetHealthStatus()
        {
            string url = string.Format("{0}/{1}/cells", this.Host, this.Version);
            string bodyParam =  null  ; 
            return ApiInvoker.InvokeApiAsync< string >(url, "GET", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchRequest" /></param>
        public TextItems PostSearch( SearchRequest request )
        {
            string url = string.Format("{0}/{1}/cells/content/search", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< TextItems >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostReplaceRequest" /></param>
        public ResponseFiles PostReplace( ReplaceRequest request )
        {
            string url = string.Format("{0}/{1}/cells/content/replace", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFiles >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookRequest" /></param>
        public ResponseFiles PostConvertWorkbook( ConvertRequest request )
        {
            string url = string.Format("{0}/{1}/cells/convert", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFiles >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostMergeRequest" /></param>
        public ResponseFile PostMerge( MergeRequest request )
        {
            string url = string.Format("{0}/{1}/cells/merge", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFile >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostEncryptWithPasswordRequest" /></param>
        public ResponseFiles PostEncryptWithPassword( ProtectionRequest request )
        {
            string url = string.Format("{0}/{1}/cells/protect/encrypt-with-password", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFiles >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostDecryptWithPasswordRequest" /></param>
        public ResponseFiles PostDecryptWithPassword( ProtectionRequest request )
        {
            string url = string.Format("{0}/{1}/cells/protect/decrypt-with-password", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFiles >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostDigitalSignatureRequest" /></param>
        public ResponseFiles PostDigitalSignature( DigitalSignaturRequest request )
        {
            string url = string.Format("{0}/{1}/cells/protect/digital-signature", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFiles >(url, "POST", bodyParam, null, null).Result;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSplitRequest" /></param>
        public ResponseFiles PostSplit( SplitRequest request )
        {
            string url = string.Format("{0}/{1}/cells/split", this.Host, this.Version);
            string bodyParam =  JsonConvert.SerializeObject(request)  ; 
            return ApiInvoker.InvokeApiAsync< ResponseFiles >(url, "POST", bodyParam, null, null).Result;
        }


    }
}
