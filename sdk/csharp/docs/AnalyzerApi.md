# Microsoft.Presidio.Api.AnalyzerApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyzePost**](AnalyzerApi.md#analyzepost) | **POST** /analyze | Analyze Text
[**HealthGet**](AnalyzerApi.md#healthget) | **GET** /health | Healthcheck
[**RecognizersGet**](AnalyzerApi.md#recognizersget) | **GET** /recognizers | Get Recognizers
[**SupportedentitiesGet**](AnalyzerApi.md#supportedentitiesget) | **GET** /supportedentities | Get supported entities

<a name="analyzepost"></a>
# **AnalyzePost**
> List<RecognizerResultWithAnaysisExplanation> AnalyzePost (AnalyzeRequest body)

Analyze Text

Recognizes PII entities in a given text and returns their types, locations and score

### Example
```csharp
using System;
using System.Diagnostics;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Client;
using Microsoft.Presidio.Model;

namespace Example
{
    public class AnalyzePostExample
    {
        public void main()
        {
            var apiInstance = new AnalyzerApi();
            var body = new AnalyzeRequest(); // AnalyzeRequest | 

            try
            {
                // Analyze Text
                List&lt;RecognizerResultWithAnaysisExplanation&gt; result = apiInstance.AnalyzePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzerApi.AnalyzePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AnalyzeRequest**](AnalyzeRequest.md)|  | 

### Return type

[**List<RecognizerResultWithAnaysisExplanation>**](RecognizerResultWithAnaysisExplanation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="healthget"></a>
# **HealthGet**
> string HealthGet ()

Healthcheck

### Example
```csharp
using System;
using System.Diagnostics;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Client;
using Microsoft.Presidio.Model;

namespace Example
{
    public class HealthGetExample
    {
        public void main()
        {
            var apiInstance = new AnalyzerApi();

            try
            {
                // Healthcheck
                string result = apiInstance.HealthGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzerApi.HealthGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="recognizersget"></a>
# **RecognizersGet**
> List<string> RecognizersGet (string language = null)

Get Recognizers

Get the available PII recognizers for a given language

### Example
```csharp
using System;
using System.Diagnostics;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Client;
using Microsoft.Presidio.Model;

namespace Example
{
    public class RecognizersGetExample
    {
        public void main()
        {
            var apiInstance = new AnalyzerApi();
            var language = language_example;  // string | Two characters for the desired language in ISO_639-1 format (optional) 

            try
            {
                // Get Recognizers
                List&lt;string&gt; result = apiInstance.RecognizersGet(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzerApi.RecognizersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Two characters for the desired language in ISO_639-1 format | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="supportedentitiesget"></a>
# **SupportedentitiesGet**
> List<string> SupportedentitiesGet (string language = null)

Get supported entities

Get the list of PII entities Presidio-Analyzer is capable of detecting

### Example
```csharp
using System;
using System.Diagnostics;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Client;
using Microsoft.Presidio.Model;

namespace Example
{
    public class SupportedentitiesGetExample
    {
        public void main()
        {
            var apiInstance = new AnalyzerApi();
            var language = language_example;  // string | Two characters for the desired language in ISO_639-1 format (optional) 

            try
            {
                // Get supported entities
                List&lt;string&gt; result = apiInstance.SupportedentitiesGet(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzerApi.SupportedentitiesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Two characters for the desired language in ISO_639-1 format | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
