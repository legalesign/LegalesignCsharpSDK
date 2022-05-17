
# Org.OpenAPITools.Model.TemplatePdfFieldDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Align** | **int?** | one of the following:    * 1 - left    * 2 - middle    * 3 - right  | [optional] 
**Ax** | **float** | left vertical, 0 &#x3D; left page edge, 1 &#x3D; right page edge | 
**Ay** | **float** | upper horizontal, 0 &#x3D; top page edge, 1 &#x3D; bottom page edge | 
**Bx** | **float** | right vertical, 0 &#x3D; left page edge, 1 &#x3D; right page edge | 
**By** | **float** | lower horizontal. 0 &#x3D; top page edge, 1 &#x3D; bottom page edge | 
**ElementType** | **string** | Must be one of the following: * signature - signature field  * initials - initials field  * text - signer field (field for signer to complete) * admin - sender field (field to complete by admin user when sending) | 
**Fieldorder** | **int** | order signer progresses through fields, top-down if blank | [optional] 
**FontName** | **string** |  | [optional] 
**FontSize** | **int** |  | [optional] 
**HideBorder** | **bool** |  | [optional] 
**Label** | **string** | help signer/sender understand what to do | [optional] 
**LabelExtra** | **string** | not in use | [optional] 
**LogicAction** | **int** | offers options for more advanced forms 1 &#x3D; One of a set of field (radio group), 2 &#x3D; Sum a set of fields,  3 &#x3D; Conditional upon another field | [optional] 
**MapTo** | **string** | custom data for form integrations | [optional] 
**LogicGroup** | **string** | values to enable a given logic_action in the form | [optional] 
**Optional** | **bool** |  | [optional] 
**Options** | **string** | user for certain validation types | [optional] [default to "false"]
**Page** | **int** | which page to place field on | 
**Signer** | **int** | 1-Index number for signer (witness+100) (approver+200) | 
**Substantive** | **bool** | Set if field substantive to contract terms, if so will not let others sign till this field completed | [optional] [default to false]
**Validation** | **PdfFieldValidationEnum** |  | [optional] 
**Value** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

