# IO.Swagger.Model.DeanonymizeRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The anonymized text | 
**Deanonymizers** | **AnyOfDeanonymizeRequestDeanonymizers** | Object where the key is DEFAULT or the ENTITY_TYPE and the value is decrypt since it is the only one supported | [default to {"DEFAULT":{"type":"decrypt","key":"3t6w9z$C&F)J@NcR"}}]
**AnonymizerResults** | [**List&lt;AnonymizerResult&gt;**](AnonymizerResult.md) | Array of anonymized PIIs | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

