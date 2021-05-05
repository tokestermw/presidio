# IO.Swagger.Api.AnonymizerApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnonymizePost**](AnonymizerApi.md#anonymizepost) | **POST** /anonymize | Anonymize Text
[**AnonymizersGet**](AnonymizerApi.md#anonymizersget) | **GET** /anonymizers | Get supported anonymizers
[**DeanonymizersGet**](AnonymizerApi.md#deanonymizersget) | **GET** /deanonymizers | Get supported deanonymizers
[**HealthGet**](AnonymizerApi.md#healthget) | **GET** /health | Healthcheck

<a name="anonymizepost"></a>
# **AnonymizePost**
> AnonymizeResponse AnonymizePost (AnonymizeRequest body)

Anonymize Text

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnonymizePostExample
    {
        public void main()
        {
            var apiInstance = new AnonymizerApi();
            var body = new AnonymizeRequest(); // AnonymizeRequest | 

            try
            {
                // Anonymize Text
                AnonymizeResponse result = apiInstance.AnonymizePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizerApi.AnonymizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AnonymizeRequest**](AnonymizeRequest.md)|  | 

### Return type

[**AnonymizeResponse**](AnonymizeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="anonymizersget"></a>
# **AnonymizersGet**
> List<string> AnonymizersGet ()

Get supported anonymizers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnonymizersGetExample
    {
        public void main()
        {
            var apiInstance = new AnonymizerApi();

            try
            {
                // Get supported anonymizers
                List&lt;string&gt; result = apiInstance.AnonymizersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizerApi.AnonymizersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deanonymizersget"></a>
# **DeanonymizersGet**
> List<string> DeanonymizersGet ()

Get supported deanonymizers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeanonymizersGetExample
    {
        public void main()
        {
            var apiInstance = new AnonymizerApi();

            try
            {
                // Get supported deanonymizers
                List&lt;string&gt; result = apiInstance.DeanonymizersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizerApi.DeanonymizersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HealthGetExample
    {
        public void main()
        {
            var apiInstance = new AnonymizerApi();

            try
            {
                // Healthcheck
                string result = apiInstance.HealthGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizerApi.HealthGet: " + e.Message );
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
