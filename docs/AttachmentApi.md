# Org.OpenAPITools.Api.AttachmentApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAttachment**](AttachmentApi.md#deleteattachment) | **DELETE** /attachment/{attachmentId} | Delete attachment
[**GetAttachment**](AttachmentApi.md#getattachment) | **GET** /attachment/{attachmentId} | Get attachment
[**GetAttachments**](AttachmentApi.md#getattachments) | **GET** /attachment/ | Get attachments
[**PostAttachment**](AttachmentApi.md#postattachment) | **POST** /attachment/ | Upload attachment (PDF)



## DeleteAttachment

> void DeleteAttachment (Guid attachmentId)

Delete attachment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentApi(Configuration.Default);
            var attachmentId = "attachmentId_example";  // Guid | attachment id

            try
            {
                // Delete attachment
                apiInstance.DeleteAttachment(attachmentId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.DeleteAttachment: " + e.Message );
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
 **attachmentId** | **Guid**| attachment id | 

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


## GetAttachment

> AttachmentResponse GetAttachment (Guid attachmentId)

Get attachment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentApi(Configuration.Default);
            var attachmentId = "attachmentId_example";  // Guid | attachment id

            try
            {
                // Get attachment
                AttachmentResponse result = apiInstance.GetAttachment(attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.GetAttachment: " + e.Message );
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
 **attachmentId** | **Guid**| attachment id | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

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


## GetAttachments

> AttachmentListResponse GetAttachments (string group = null, int? limit = null, int? offset = null)

Get attachments

List attachments in your groups

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAttachmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentApi(Configuration.Default);
            var group = my-group;  // string | Filter by a specific group (optional) 
            var limit = 20;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional)  (default to 20)
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 

            try
            {
                // Get attachments
                AttachmentListResponse result = apiInstance.GetAttachments(group, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.GetAttachments: " + e.Message );
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
 **group** | **string**| Filter by a specific group | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] [default to 20]
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 

### Return type

[**AttachmentListResponse**](AttachmentListResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation, list of attachment objects |  -  |
| **400** | Invalid status value |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostAttachment

> void PostAttachment (AttachmentPost attachmentPost)

Upload attachment (PDF)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentApi(Configuration.Default);
            var attachmentPost = new AttachmentPost(); // AttachmentPost | Upload a pdf to be an email attachment

            try
            {
                // Upload attachment (PDF)
                apiInstance.PostAttachment(attachmentPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.PostAttachment: " + e.Message );
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
 **attachmentPost** | [**AttachmentPost**](AttachmentPost.md)| Upload a pdf to be an email attachment | 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: example error report


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success. Attachment URI will be in Location header. |  -  |
| **400** | Bad Request, read response for error information |  -  |
| **401** | Unauthorized |  -  |
| **429** | Throttled |  -  |
| **500** | Usually unparseable JSON |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

