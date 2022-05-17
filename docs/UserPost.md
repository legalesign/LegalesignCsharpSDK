
# Org.OpenAPITools.Model.UserPost

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** |  | 
**LastName** | **string** |  | 
**Email** | **string** |  | 
**Timezone** | **TimezoneEnum** |  | [optional] 
**Password** | **string** | If not set a verification email is sent. Password must be at least 8 chars, include upper and lower case, with a number and a special character | [optional] 
**Groups** | **string** | comma delimited list of groups to add user to, can be full group resource_uri or groupId | [optional] 
**Permission** | **string** | set user permissions * 1 - admin * 2 - create and send docs, team user * 3 - readonly, team user * 4 - send only, team user * 5 - send only, individual user * 6 - create and send docs, invidual user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

