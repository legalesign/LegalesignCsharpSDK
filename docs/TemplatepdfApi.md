# Org.OpenAPITools.Api.TemplatepdfApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPdfTemplate**](TemplatepdfApi.md#getpdftemplate) | **GET** /templatepdf/{pdfId} | Get PDF template
[**GetPdfTemplateFields**](TemplatepdfApi.md#getpdftemplatefields) | **GET** /templatepdf/{pdfId}/fields | Get PDF template fields
[**GetPdfTemplates**](TemplatepdfApi.md#getpdftemplates) | **GET** /templatepdf | Get PDF templates
[**PostPdfTemplate**](TemplatepdfApi.md#postpdftemplate) | **POST** /templatepdf | Create PDF template
[**PostPdfTemplateFields**](TemplatepdfApi.md#postpdftemplatefields) | **POST** /templatepdf/{pdfId}/fields | Create PDF template fields
[**PostPdfTemplateTags**](TemplatepdfApi.md#postpdftemplatetags) | **POST** /templatepdf/{pdfId}/tags | Convert text tags



## GetPdfTemplate

> TemplatePdfResponse GetPdfTemplate (Guid pdfId)

Get PDF template

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPdfTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatepdfApi(Configuration.Default);
            var pdfId = "pdfId_example";  // Guid | uploaded PDF id

            try
            {
                // Get PDF template
                TemplatePdfResponse result = apiInstance.GetPdfTemplate(pdfId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatepdfApi.GetPdfTemplate: " + e.Message );
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
 **pdfId** | **Guid**| uploaded PDF id | 

### Return type

[**TemplatePdfResponse**](TemplatePdfResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PDF template details |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPdfTemplateFields

> TemplatePdfFieldsList GetPdfTemplateFields (Guid pdfId)

Get PDF template fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPdfTemplateFieldsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatepdfApi(Configuration.Default);
            var pdfId = "pdfId_example";  // Guid | uploaded PDF id

            try
            {
                // Get PDF template fields
                TemplatePdfFieldsList result = apiInstance.GetPdfTemplateFields(pdfId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatepdfApi.GetPdfTemplateFields: " + e.Message );
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
 **pdfId** | **Guid**| uploaded PDF id | 

### Return type

[**TemplatePdfFieldsList**](TemplatePdfFieldsList.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of a pdf template fields |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPdfTemplates

> TemplatePdfListResponse GetPdfTemplates (string archive = null, string group = null, int? limit = null, int? offset = null)

Get PDF templates

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPdfTemplatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatepdfApi(Configuration.Default);
            var archive = "\"false\"";  // string |  (optional)  (default to "false")
            var group = "group_example";  // string | can be full resource_uri or only id (optional) 
            var limit = 20;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional)  (default to 20)
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 

            try
            {
                // Get PDF templates
                TemplatePdfListResponse result = apiInstance.GetPdfTemplates(archive, group, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatepdfApi.GetPdfTemplates: " + e.Message );
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
 **archive** | **string**|  | [optional] [default to &quot;false&quot;]
 **group** | **string**| can be full resource_uri or only id | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] [default to 20]
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 

### Return type

[**TemplatePdfListResponse**](TemplatePdfListResponse.md)

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


## PostPdfTemplate

> void PostPdfTemplate (TemplatePdfFieldPost templatePdfFieldPost)

Create PDF template

Upload a PDF document you want to send to be signed

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostPdfTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatepdfApi(Configuration.Default);
            var templatePdfFieldPost = new TemplatePdfFieldPost(); // TemplatePdfFieldPost | Data for PDF upload

            try
            {
                // Create PDF template
                apiInstance.PostPdfTemplate(templatePdfFieldPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatepdfApi.PostPdfTemplate: " + e.Message );
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
 **templatePdfFieldPost** | [**TemplatePdfFieldPost**](TemplatePdfFieldPost.md)| Data for PDF upload | 

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
| **201** | operation successful |  * location - resource_uri for new user (if password set) <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostPdfTemplateFields

> void PostPdfTemplateFields (Guid pdfId, List<PdfFieldsPost> pdfFieldsPost)

Create PDF template fields

Replace existing pdf fields with new ones

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostPdfTemplateFieldsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatepdfApi(Configuration.Default);
            var pdfId = "pdfId_example";  // Guid | uploaded PDF id
            var pdfFieldsPost = new List<PdfFieldsPost>(); // List<PdfFieldsPost> | Replace PDF fields on a PDF template.

            try
            {
                // Create PDF template fields
                apiInstance.PostPdfTemplateFields(pdfId, pdfFieldsPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatepdfApi.PostPdfTemplateFields: " + e.Message );
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
 **pdfId** | **Guid**| uploaded PDF id | 
 **pdfFieldsPost** | [**List&lt;PdfFieldsPost&gt;**](PdfFieldsPost.md)| Replace PDF fields on a PDF template. | 

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
| **201** | operation successful |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostPdfTemplateTags

> void PostPdfTemplateTags (string pdfId)

Convert text tags

Convert any text tags in the PDF into fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostPdfTemplateTagsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatepdfApi(Configuration.Default);
            var pdfId = "pdfId_example";  // string | 

            try
            {
                // Convert text tags
                apiInstance.PostPdfTemplateTags(pdfId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatepdfApi.PostPdfTemplateTags: " + e.Message );
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
 **pdfId** | **string**|  | 

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
| **201** | operation successful |  -  |
| **400** | bad request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

