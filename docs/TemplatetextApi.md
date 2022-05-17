# Org.OpenAPITools.Api.TemplatetextApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveTextTemplate**](TemplatetextApi.md#archivetexttemplate) | **DELETE** /template/{templateId} | Archive text template
[**GetTextTemplate**](TemplatetextApi.md#gettexttemplate) | **GET** /template/{templateId} | Get text template
[**GetTextTemplates**](TemplatetextApi.md#gettexttemplates) | **GET** /template | Get text templates
[**PatchTextTemplate**](TemplatetextApi.md#patchtexttemplate) | **PATCH** /template/{templateId} | Update text template
[**PostTextTemplate**](TemplatetextApi.md#posttexttemplate) | **POST** /template | Create text template



## ArchiveTextTemplate

> void ArchiveTextTemplate (Guid templateId)

Archive text template

Archives a template (is recoverable, i.e. not fully deleted, if you need true data deletion contact us).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveTextTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatetextApi(Configuration.Default);
            var templateId = "templateId_example";  // Guid | saved html template id

            try
            {
                // Archive text template
                apiInstance.ArchiveTextTemplate(templateId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatetextApi.ArchiveTextTemplate: " + e.Message );
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
 **templateId** | **Guid**| saved html template id | 

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
| **204** | operation successful |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTextTemplate

> TemplateResponseDetail GetTextTemplate (Guid templateId)

Get text template

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTextTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatetextApi(Configuration.Default);
            var templateId = "templateId_example";  // Guid | saved html template id

            try
            {
                // Get text template
                TemplateResponseDetail result = apiInstance.GetTextTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatetextApi.GetTextTemplate: " + e.Message );
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
 **templateId** | **Guid**| saved html template id | 

### Return type

[**TemplateResponseDetail**](TemplateResponseDetail.md)

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


## GetTextTemplates

> TemplateListResponse GetTextTemplates (string group = null, int? limit = null, string archive = null, int? offset = null)

Get text templates

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTextTemplatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatetextApi(Configuration.Default);
            var group = "group_example";  // string | can be full resource_uri or only id (optional) 
            var limit = 20;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional)  (default to 20)
            var archive = "archive_example";  // string |  (optional) 
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 

            try
            {
                // Get text templates
                TemplateListResponse result = apiInstance.GetTextTemplates(group, limit, archive, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatetextApi.GetTextTemplates: " + e.Message );
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
 **group** | **string**| can be full resource_uri or only id | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] [default to 20]
 **archive** | **string**|  | [optional] 
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 

### Return type

[**TemplateListResponse**](TemplateListResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of text templates |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchTextTemplate

> void PatchTextTemplate (Guid templateId, string body)

Update text template

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchTextTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatetextApi(Configuration.Default);
            var templateId = "templateId_example";  // Guid | saved html template id
            var body = "body_example";  // string | Updated text template object

            try
            {
                // Update text template
                apiInstance.PatchTextTemplate(templateId, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatetextApi.PatchTextTemplate: " + e.Message );
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
 **templateId** | **Guid**| saved html template id | 
 **body** | **string**| Updated text template object | 

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
| **202** | operation successful |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostTextTemplate

> void PostTextTemplate (TemplatePost templatePost)

Create text template

Create a new html/text template. This probably isn't the method you are looking for. You can use the 'text' attribute in /document/ to create and send your HTML as a signing document in one call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostTextTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatetextApi(Configuration.Default);
            var templatePost = new TemplatePost(); // TemplatePost | data for template creation

            try
            {
                // Create text template
                apiInstance.PostTextTemplate(templatePost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TemplatetextApi.PostTextTemplate: " + e.Message );
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
 **templatePost** | [**TemplatePost**](TemplatePost.md)| data for template creation | 

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
| **201** | operation successful |  * Location - resource_uri for new template <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

