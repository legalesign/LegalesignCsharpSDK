
# Org.OpenAPITools.Model.DocumentSignerPost

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **int** | Zero-indexed signer ordering, deprecated. Ordering of signers/witnesses/approvers is now the natural order of your signers list. | [optional] 
**Email** | **string** |  | 
**Firstname** | **string** |  | 
**Lastname** | **string** |  | 
**Attachments** | **List&lt;string&gt;** | List of attachment resource URIs | [optional] 
**Behalfof** | **string** | deprecated, do not use | [optional] 
**DecideLater** | **bool** | Add this you want the previous signer or approver to decide who the next person should be.  Commonly used for witnesses (see \\\&quot;role\\\&quot;). If you use this leave all other attributes blank. First signer cannot use this attribute. | [optional] 
**Expires** | **DateTime** | ISO8601 formed datetime, set to TZ of sender or timezone if used | [optional] 
**Message** | **string** | Use keyword \\\&quot;default\\\&quot; to use group message | [optional] 
**Reviewers** | [**List&lt;ReviewersPost&gt;**](ReviewersPost.md) |  | [optional] 
**Role** | **string** | If this person is a witness use \\\&quot;witness\\\&quot;. Required where a witness is defined in your PDF. If this person is a normal signer, use \\\&quot;approver\\\&quot; to switch to an approver role.  Witnesses and witnessed signers also require \\\&quot;sms\\\&quot; (see also \\\&quot;decide_later\\\&quot;). | [optional] 
**Sms** | **string** | Use international format number to add SMS verification. Required if a witness or a witnessed signer. | [optional] 
**Subject** | **string** | Subject line for outbound email | [optional] 
**Timezone** | **string** | TZ of the signer, must be valid TZ as per timezoneenum (see User for timezoneenum details).  If blank uses tz of the sender. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

