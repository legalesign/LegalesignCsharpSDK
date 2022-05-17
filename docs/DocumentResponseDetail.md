
# Org.OpenAPITools.Model.DocumentResponseDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archived** | **bool** |  | [optional] 
**AutoArchive** | **bool** | Send document archive very soon after signing. | [optional] [default to true]
**CcEmails** | **string** | who will be cc&#39;d  with sender on email notification when signed | [optional] 
**Created** | **DateTime** |  | [optional] 
**DoEmail** | **bool** |  | [optional] 
**DownloadFinal** | **bool** | Final PDF is available to download | [optional] 
**Footer** | **string** | HTML docs - text for footer if used | [optional] 
**FooterHeight** | **int** | HTMl docs - px height of footer if used | [optional] 
**Group** | **string** | Resource URI of group | [optional] 
**HasFields** | **bool** |  | [optional] 
**HashValue** | **string** | SHA256 checksum of final doc, use this to validate your final PDF download | [optional] 
**Header** | **string** | HTML docs - text for header if used | [optional] 
**HeaderHeight** | **int** | HTMl docs - px height of header if used | [optional] 
**Modified** | **DateTime** |  | [optional] 
**Name** | **string** |  | [optional] 
**PdfPassword** | **string** | PDF password if used and if save-able | [optional] 
**PdfPasswordType** | **string** | how pdf password is retained | [optional] 
**Pdftext** | **string** | ignore this | [optional] 
**Redirect** | **string** | url for signer redirect after signing | [optional] 
**ResourceUri** | **string** |  | [optional] 
**ReturnSignerLinks** | **bool** | ignore | [optional] 
**SignMouse** | **bool** | legacy | [optional] 
**SignTime** | **DateTime** |  | [optional] 
**SignType** | **bool** | legacy | [optional] 
**SignUpload** | **bool** | legacy | [optional] 
**SignaturePlacement** | **int** | legacy | [optional] 
**SignatureType** | **int** | legacy - always 4 | [optional] 
**Signers** | **List&lt;List&lt;string&gt;&gt;** | nested arrays with signer details | [optional] 
**SignersInOrder** | **bool** |  | [optional] 
**Status** | **DocumentStatusEnum** |  | [optional] 
**Tag** | **string** | your reference | [optional] 
**Template** | **string** |  | [optional] 
**Templatepdf** | **string** |  | [optional] 
**Text** | **string** |  | [optional] 
**User** | **string** | Resource URI of user | [optional] 
**Uuid** | **Guid** | Object ID alone | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

