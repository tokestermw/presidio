# IO.Swagger.Api.DeanonymizerApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeanonymizePost**](DeanonymizerApi.md#deanonymizepost) | **POST** /deanonymize | Deanonymize Text

<a name="deanonymizepost"></a>
# **DeanonymizePost**
> DeanonymizeResponse DeanonymizePost (DeanonymizeRequest body)

Deanonymize Text

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeanonymizePostExample
    {
        public void main()
        {
            var apiInstance = new DeanonymizerApi();
            var body = new DeanonymizeRequest(); // DeanonymizeRequest | 

            try
            {
                // Deanonymize Text
                DeanonymizeResponse result = apiInstance.DeanonymizePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeanonymizerApi.DeanonymizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeanonymizeRequest**](DeanonymizeRequest.md)|  | 

### Return type

[**DeanonymizeResponse**](DeanonymizeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
