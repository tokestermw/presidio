# IO.Swagger.Model.AnonymizeRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The text to anonymize | 
**Anonymizers** | **AnyOfAnonymizeRequestAnonymizers** | Object where the key is DEFAULT or the ENTITY_TYPE and the value is the anonymizer definition | [optional] [default to {"DEFAULT":{"type":"replace","new_value":"<ENTITY_TYPE>"}}]
**AnalyzerResults** | [**List&lt;RecognizerResult&gt;**](RecognizerResult.md) | Array of analyzer detections | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

