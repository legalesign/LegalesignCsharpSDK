# Org.OpenAPITools.Api.MemberApi

All URIs are relative to *https://eu-api.legalesign.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInvite**](MemberApi.md#deleteinvite) | **DELETE** /invited/{invitedId} | Delete invitation
[**DeleteMember**](MemberApi.md#deletemember) | **DELETE** /member/{memberId} | Remove member from group
[**GetInvites**](MemberApi.md#getinvites) | **GET** /invited | Get group invitations
[**GetMember**](MemberApi.md#getmember) | **GET** /member/{memberId} | Get group member
[**GetMembers**](MemberApi.md#getmembers) | **GET** /member | Get group members
[**PostMember**](MemberApi.md#postmember) | **POST** /member | Create group member



## DeleteInvite

> void DeleteInvite (Guid invitedId)

Delete invitation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteInviteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberApi(Configuration.Default);
            var invitedId = "invitedId_example";  // Guid | 

            try
            {
                // Delete invitation
                apiInstance.DeleteInvite(invitedId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MemberApi.DeleteInvite: " + e.Message );
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
 **invitedId** | **Guid**|  | 

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


## DeleteMember

> void DeleteMember (Guid memberId)

Remove member from group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberApi(Configuration.Default);
            var memberId = "memberId_example";  // Guid | member of group id

            try
            {
                // Remove member from group
                apiInstance.DeleteMember(memberId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MemberApi.DeleteMember: " + e.Message );
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
 **memberId** | **Guid**| member of group id | 

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


## GetInvites

> InvitedListResponse GetInvites (string group = null)

Get group invitations

Invitations to people to join the group are listed by email

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvitesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberApi(Configuration.Default);
            var group = "group_example";  // string | filter list by a given group (optional) 

            try
            {
                // Get group invitations
                InvitedListResponse result = apiInstance.GetInvites(group);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MemberApi.GetInvites: " + e.Message );
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
 **group** | **string**| filter list by a given group | [optional] 

### Return type

[**InvitedListResponse**](InvitedListResponse.md)

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


## GetMember

> MemberResponse GetMember (Guid memberId)

Get group member

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberApi(Configuration.Default);
            var memberId = "memberId_example";  // Guid | member of group id

            try
            {
                // Get group member
                MemberResponse result = apiInstance.GetMember(memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MemberApi.GetMember: " + e.Message );
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
 **memberId** | **Guid**| member of group id | 

### Return type

[**MemberResponse**](MemberResponse.md)

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


## GetMembers

> MemberListResponse GetMembers (string group = null, int? offset = null, int? limit = null)

Get group members

List members of groups, one user may be in one or more groups

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberApi(Configuration.Default);
            var group = "group_example";  // string | filter list by a given group (optional) 
            var offset = 56;  // int? | Offset from start of dataset. Use with the limit query to iterate through dataset. (optional) 
            var limit = 20;  // int? | Length of dataset to return. Use with offset query to iterate through results. (optional)  (default to 20)

            try
            {
                // Get group members
                MemberListResponse result = apiInstance.GetMembers(group, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MemberApi.GetMembers: " + e.Message );
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
 **group** | **string**| filter list by a given group | [optional] 
 **offset** | **int?**| Offset from start of dataset. Use with the limit query to iterate through dataset. | [optional] 
 **limit** | **int?**| Length of dataset to return. Use with offset query to iterate through results. | [optional] [default to 20]

### Return type

[**MemberListResponse**](MemberListResponse.md)

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


## PostMember

> void PostMember (MemberPost memberPost)

Create group member

If the email is a registered user then access to group will be immediate, otherise an invitation will be created and emailed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu-api.legalesign.com/api/v1";
            // Configure API key authorization: apikeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberApi(Configuration.Default);
            var memberPost = new MemberPost(); // MemberPost | 

            try
            {
                // Create group member
                apiInstance.PostMember(memberPost);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MemberApi.PostMember: " + e.Message );
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
 **memberPost** | [**MemberPost**](MemberPost.md)|  | 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | operation successful |  -  |
| **400** | operation not successful, e.g. person is already a member or not yet joined |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

