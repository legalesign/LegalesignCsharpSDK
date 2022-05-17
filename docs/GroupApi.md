# Org.OpenAPITools.Api.GroupApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGroup**](GroupApi.md#getgroup) | **GET** /group/{groupId} | Get group
[**GetGroups**](GroupApi.md#getgroups) | **GET** /group | Get groups
[**PostGroup**](GroupApi.md#postgroup) | **POST** /group | Create group
[**UpdateGroup**](GroupApi.md#updategroup) | **PATCH** /group/{groupId} | Update group



## GetGroup

> GroupResponse GetGroup (string groupId)

Get group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(Configuration.Default);
            var groupId = "groupId_example";  // string | 

            try
            {
                // Get group
                GroupResponse result = apiInstance.GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroup: " + e.Message );
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
 **groupId** | **string**|  | 

### Return type

[**GroupResponse**](GroupResponse.md)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ok |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetGroups

> GroupListResponse GetGroups (int? offset = null, int? limit = null)

Get groups

List groups the api user belongs to

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(Configuration.Default);
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 
            var limit = 56;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional) 

            try
            {
                // Get groups
                GroupListResponse result = apiInstance.GetGroups(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroups: " + e.Message );
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
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] 

### Return type

[**GroupListResponse**](GroupListResponse.md)

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


## PostGroup

> void PostGroup (GroupPost groupPost)

Create group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(Configuration.Default);
            var groupPost = new GroupPost(); // GroupPost | 

            try
            {
                // Create group
                apiInstance.PostGroup(groupPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupApi.PostGroup: " + e.Message );
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
 **groupPost** | [**GroupPost**](GroupPost.md)|  | 

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
| **400** | groups allowance exceeded |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateGroup

> void UpdateGroup (string groupId, GroupPatch groupPatch)

Update group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(Configuration.Default);
            var groupId = "groupId_example";  // string | group id
            var groupPatch = new GroupPatch(); // GroupPatch | 

            try
            {
                // Update group
                apiInstance.UpdateGroup(groupId, groupPatch);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupApi.UpdateGroup: " + e.Message );
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
 **groupId** | **string**| group id | 
 **groupPatch** | [**GroupPatch**](GroupPatch.md)|  | 

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
| **400** | bad request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

