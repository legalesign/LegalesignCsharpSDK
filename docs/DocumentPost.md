
# Org.OpenAPITools.Model.DocumentPost

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Group** | **string** |  | 
**Name** | **string** |  | 
**Text** | **string** | Raw html. This API call must contain either one of the attributes text, templatepdf, template. | [optional] 
**Templatepdf** | **string** | Resource URI of templatepdf object. This API call must contain either one of the attributes text, templatepdf, template. | [optional] 
**Template** | **string** | Resource URI of text template object. This call must contain either one of the attributes text, templatepdf, template. | [optional] 
**Signers** | [**List&lt;DocumentSignerPost&gt;**](DocumentSignerPost.md) |  | 
**SignatureType** | **int** | Use 4 to get your executed PDF Certified. Recommended. Defaults to 1 (uses a sha256 hash for document integrity). | [optional] [default to 1]
**AppendPdf** | **bool** | Append Legalesign validation info to final PDF. If not included uses the group default. | [optional] [default to false]
**AutoArchive** | **bool** | Send to archive soon after signing. Keeps web app clutter free | [optional] [default to true]
**DoEmail** | **bool** | Use Legalesign email to send notification emails. If false suppresses all emails. | [optional] [default to false]
**CcEmails** | **string** | Comma delimited string of email addresses that are notified of signing or rejection. | [optional] 
**ConvertSenderToSigner** | **bool** | If any sender fields are left blank, convert them to signer fields. | [optional] 
**Footer** | **string** | Text doc only. The footer for the final pdf. Use keyword \\\&quot;default\\\&quot; to use group default footer. | [optional] 
**FooterHeight** | **long** | Text based doc only. Pixel height of PDF footer, if used. 1px &#x3D; 0.025cm | [optional] 
**Header** | **string** | Text based doc only. The header for the final pdf. Use keyword \\\&quot;default\\\&quot; to use group header footer. | [optional] 
**HeaderHeight** | **long** | Text based doc only. Pixel height of final PDF footer, if used. 1px &#x3D; 0.025cm | [optional] 
**PdfPassword** | **string** | Set a password. Must be ascii encode-able, you must also set signature_type to 4 and choose a pdf_password_type. | [optional] 
**PdfPasswordType** | **int** | 1 to store password, 2 for to delete from our records upon final signing. | [optional] 
**Pdftext** | **Dictionary&lt;string, string&gt;** | Assign values to PDF sender fields, use field labels as keys. Requires unique fields labels. See also strict_fields. | [optional] 
**Redirect** | **string** | URL to send the signer to after signing (instead of download page).  Your URL will include query parameters with ID and state information as follows: YOUR-URL?signer&#x3D;[signer_uid]&amp;doc&#x3D;[doc_id]&amp;group&#x3D;[group_id]&amp;signer_state&#x3D;[signer_status]&amp;doc_state&#x3D;[doc_status] | [optional] 
**Reminders** | **string** | Put &#39;default&#39; if you wish to use the default reminder schedule in the group (go to web app to set default schedule) | [optional] 
**ReturnSignerLinks** | **bool** | Return document links for signers in the response BODY. | [optional] 
**SignersInOrder** | **bool** | Notify signers in their order sequence. If false all are notified simulataneously. | [optional] 
**Signertext** | **Dictionary&lt;string, string&gt;** | Add custom placeholders to signer fields, using labels as keys in an object (as for pdftext). Relies on unique labelling. | [optional] 
**StrictFields** | **bool** | pdftext fails silently for invalid field value, set to true to return an error | [optional] 
**Tag** | **string** |  | [optional] 
**User** | **string** | Assign document another user in the group. Defaults to API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

