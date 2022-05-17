# Org.OpenAPITools.Api.DocumentApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveDocument**](DocumentApi.md#archivedocument) | **DELETE** /document/{docId} | Void/archive signing document
[**DeleteDocument**](DocumentApi.md#deletedocument) | **DELETE** /document/{docId}/delete | Permanently delete signing document
[**GetDocument**](DocumentApi.md#getdocument) | **GET** /document/{docId} | Get document
[**GetDocumentFields**](DocumentApi.md#getdocumentfields) | **GET** /document/{docId}/fields | Get document fields
[**GetDocumentPdf**](DocumentApi.md#getdocumentpdf) | **GET** /pdf/{docId} | Location to download PDF
[**GetDocuments**](DocumentApi.md#getdocuments) | **GET** /document/ | Get signing documents
[**GetStatus**](DocumentApi.md#getstatus) | **GET** /status/{docId} | Get signing document status
[**GetStatuses**](DocumentApi.md#getstatuses) | **GET** /status | Get signing documents status
[**PostDocument**](DocumentApi.md#postdocument) | **POST** /document/ | Create signing document
[**PostPdfPreview**](DocumentApi.md#postpdfpreview) | **POST** /pdf/preview | text/html document as pdf preview
[**PreviewDocumentSigning**](DocumentApi.md#previewdocumentsigning) | **POST** /document/preview | Preview text document signing page



## ArchiveDocument

> void ArchiveDocument (Guid docId)

Void/archive signing document

Delete does not remove permanently but sets it with status 40 (removed)  and archives it.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var docId = "docId_example";  // Guid | document id

            try
            {
                // Void/archive signing document
                apiInstance.ArchiveDocument(docId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.ArchiveDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **Guid**| document id | 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteDocument

> void DeleteDocument (Guid docId)

Permanently delete signing document

Permanently deletes data and files. You must enable group automated deletion. We recommend archiveDocument.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var docId = "docId_example";  // Guid | document id

            try
            {
                // Permanently delete signing document
                apiInstance.DeleteDocument(docId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.DeleteDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **Guid**| document id | 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful operation |  -  |
| **200** | Something went wrong, probably you need to allow automated deleetions. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDocument

> DocumentResponseDetail GetDocument (Guid docId)

Get document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var docId = "docId_example";  // Guid | document id

            try
            {
                // Get document
                DocumentResponseDetail result = apiInstance.GetDocument(docId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.GetDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **Guid**| document id | 

### Return type

[**DocumentResponseDetail**](DocumentResponseDetail.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDocumentFields

> List&lt;InlineResponse200&gt; GetDocumentFields (Guid docId)

Get document fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentFieldsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var docId = "docId_example";  // Guid | document id

            try
            {
                // Get document fields
                List<InlineResponse200> result = apiInstance.GetDocumentFields(docId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.GetDocumentFields: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **Guid**| document id | 

### Return type

[**List&lt;InlineResponse200&gt;**](InlineResponse200.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | operation successful |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDocumentPdf

> System.IO.Stream GetDocumentPdf (string docId)

Location to download PDF

Get the PDF for a signing document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentPdfExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var docId = "docId_example";  // string | 

            try
            {
                // Location to download PDF
                System.IO.Stream result = apiInstance.GetDocumentPdf(docId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.GetDocumentPdf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A PDF file |  -  |
| **201** | Being de-archived, available in 4 hours |  -  |
| **302** | Redirect to the download location |  * location - resource_uri for new user (if password set) <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDocuments

> DocumentListResponse GetDocuments (string archived = null, string email = null, int? limit = null, int? offset = null, string group = null, int? status = null, string nosigners = null)

Get signing documents

List (unarchived) signing documents. Use /status/ if you need high-level information.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var archived = "\"false\"";  // string | Filter on archived status, default is false (optional)  (default to "false")
            var email = "email_example";  // string | Filter by signer email (optional) 
            var limit = 20;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional)  (default to 20)
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 
            var group = "group_example";  // string | Filter by a specific group (optional) 
            var status = 56;  // int? | Filter on document status (optional) 
            var nosigners = "nosigners_example";  // string | Add value '1' to remove signers information for a faster query (optional) 

            try
            {
                // Get signing documents
                DocumentListResponse result = apiInstance.GetDocuments(archived, email, limit, offset, group, status, nosigners);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.GetDocuments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **archived** | **string**| Filter on archived status, default is false | [optional] [default to &quot;false&quot;]
 **email** | **string**| Filter by signer email | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] [default to 20]
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 
 **group** | **string**| Filter by a specific group | [optional] 
 **status** | **int?**| Filter on document status | [optional] 
 **nosigners** | **string**| Add value &#39;1&#39; to remove signers information for a faster query | [optional] 

### Return type

[**DocumentListResponse**](DocumentListResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation, list of document objects |  -  |
| **400** | Invalid status value |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStatus

> StatusResponse GetStatus (string docId)

Get signing document status

Faster short query for a document status

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var docId = "docId_example";  // string | ID of document

            try
            {
                // Get signing document status
                StatusResponse result = apiInstance.GetStatus(docId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.GetStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docId** | **string**| ID of document | 

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | operation successful |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStatuses

> StatusListResponse GetStatuses (string filter = null, int? offset = null, int? limit = null)

Get signing documents status

Shortened faster query for status of signing documents

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetStatusesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var filter = "filter_example";  // string | Filter on archived status, default is false (optional) 
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 
            var limit = 56;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional) 

            try
            {
                // Get signing documents status
                StatusListResponse result = apiInstance.GetStatuses(filter, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.GetStatuses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filter on archived status, default is false | [optional] 
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] 

### Return type

[**StatusListResponse**](StatusListResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | operation successful |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostDocument

> InlineResponse201 PostDocument (DocumentPost documentPost)

Create signing document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var documentPost = new DocumentPost(); // DocumentPost | Send a document to be signed

            try
            {
                // Create signing document
                InlineResponse201 result = apiInstance.PostDocument(documentPost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.PostDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentPost** | [**DocumentPost**](DocumentPost.md)| Send a document to be signed | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, example error report


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success. Document URI will be in Location header. If return_signer_links was set to true, the body will contain a JSON dict containing the signing links. |  * Location - new document resource uri <br>  |
| **400** | Bad Request, read response for error information |  -  |
| **401** | Unauthorized |  -  |
| **429** | Throttled |  -  |
| **500** | Usually unparseable JSON, or mis-referenced object |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostPdfPreview

> System.IO.Stream PostPdfPreview (DocumentPdfPreview documentPdfPreview)

text/html document as pdf preview

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostPdfPreviewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var documentPdfPreview = new DocumentPdfPreview(); // DocumentPdfPreview | Data to generate pdf

            try
            {
                // text/html document as pdf preview
                System.IO.Stream result = apiInstance.PostPdfPreview(documentPdfPreview);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.PostPdfPreview: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentPdfPreview** | [**DocumentPdfPreview**](DocumentPdfPreview.md)| Data to generate pdf | 

### Return type

**System.IO.Stream**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A PDF file |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreviewDocumentSigning

> void PreviewDocumentSigning (HTMLSigningPreviewPost hTMLSigningPreviewPost)

Preview text document signing page

Returns a redirect response (302) with link in the Location header to a one-use temporary URL you can redirect to, to see a preview of the signing page. Follow the redirect immediately since it expires after a few seconds.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PreviewDocumentSigningExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentApi(Configuration.Default);
            var hTMLSigningPreviewPost = new HTMLSigningPreviewPost(); // HTMLSigningPreviewPost | Preview signing page for HTML document

            try
            {
                // Preview text document signing page
                apiInstance.PreviewDocumentSigning(hTMLSigningPreviewPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentApi.PreviewDocumentSigning: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hTMLSigningPreviewPost** | [**HTMLSigningPreviewPost**](HTMLSigningPreviewPost.md)| Preview signing page for HTML document | 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Short-lived link (a few seconds) to signing page preview returned in Location header |  * location - resource_uri for new user (if password set) <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

