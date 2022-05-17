# Org.OpenAPITools.Api.SignerApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSigner**](SignerApi.md#getsigner) | **GET** /signer/{signerId} | Get signer
[**GetSignerFields**](SignerApi.md#getsignerfields) | **GET** /signer/{signerId}/fields1 | Get signer form fields
[**GetSignerLink**](SignerApi.md#getsignerlink) | **GET** /signer/{signerId}/new-link | Get signer access link
[**GetSignerRejection**](SignerApi.md#getsignerrejection) | **GET** /signer/{signerId}/rejection | Get signer rejection reason
[**PostSignerReminder**](SignerApi.md#postsignerreminder) | **POST** /signer/{signerId}/send-reminder | Send signer reminder email
[**PostSignerReset**](SignerApi.md#postsignerreset) | **POST** /signer/{signerId}/reset | Reset to earlier signer



## GetSigner

> SignerResponse GetSigner (string signerId)

Get signer

Get status and details of an individual signer

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSignerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignerApi(Configuration.Default);
            var signerId = "signerId_example";  // string | ID of signer

            try
            {
                // Get signer
                SignerResponse result = apiInstance.GetSigner(signerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SignerApi.GetSigner: " + e.Message );
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
 **signerId** | **string**| ID of signer | 

### Return type

[**SignerResponse**](SignerResponse.md)

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


## GetSignerFields

> List&lt;InlineResponse2002&gt; GetSignerFields (string signerId)

Get signer form fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSignerFieldsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignerApi(Configuration.Default);
            var signerId = "signerId_example";  // string | ID of signer

            try
            {
                // Get signer form fields
                List<InlineResponse2002> result = apiInstance.GetSignerFields(signerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SignerApi.GetSignerFields: " + e.Message );
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
 **signerId** | **string**| ID of signer | 

### Return type

[**List&lt;InlineResponse2002&gt;**](InlineResponse2002.md)

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


## GetSignerLink

> void GetSignerLink (string signerId)

Get signer access link

Returns 1-use link for signer in Location header. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSignerLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignerApi(Configuration.Default);
            var signerId = "signerId_example";  // string | ID of signer

            try
            {
                // Get signer access link
                apiInstance.GetSignerLink(signerId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SignerApi.GetSignerLink: " + e.Message );
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
 **signerId** | **string**| ID of signer | 

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
| **200** | operation sucessful |  * Location - resource_uri for new template <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSignerRejection

> InlineResponse2003 GetSignerRejection (string signerId)

Get signer rejection reason

Returns reason signer gave for rejecting a document, if given

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSignerRejectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignerApi(Configuration.Default);
            var signerId = "signerId_example";  // string | 

            try
            {
                // Get signer rejection reason
                InlineResponse2003 result = apiInstance.GetSignerRejection(signerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SignerApi.GetSignerRejection: " + e.Message );
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
 **signerId** | **string**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

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


## PostSignerReminder

> void PostSignerReminder (string signerId, SendReminderPost sendReminderPost)

Send signer reminder email

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostSignerReminderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignerApi(Configuration.Default);
            var signerId = "signerId_example";  // string | 
            var sendReminderPost = new SendReminderPost(); // SendReminderPost | Message text

            try
            {
                // Send signer reminder email
                apiInstance.PostSignerReminder(signerId, sendReminderPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SignerApi.PostSignerReminder: " + e.Message );
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
 **signerId** | **string**|  | 
 **sendReminderPost** | [**SendReminderPost**](SendReminderPost.md)| Message text | 

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
| **200** | operation successful |  -  |
| **401** | failed to send |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostSignerReset

> void PostSignerReset (string signerId, SignerResetResponse signerResetResponse)

Reset to earlier signer

Reset to an earlier signer if forwarded

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostSignerResetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignerApi(Configuration.Default);
            var signerId = "signerId_example";  // string | 
            var signerResetResponse = new SignerResetResponse(); // SignerResetResponse | Email of the earlier signer, notify current signer by email of event

            try
            {
                // Reset to earlier signer
                apiInstance.PostSignerReset(signerId, signerResetResponse);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SignerApi.PostSignerReset: " + e.Message );
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
 **signerId** | **string**|  | 
 **signerResetResponse** | [**SignerResetResponse**](SignerResetResponse.md)| Email of the earlier signer, notify current signer by email of event | 

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
| **200** | Ok |  -  |
| **400** | error - document either signed, or email is same as existing, or if previous email not found. Read response body for error information. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

