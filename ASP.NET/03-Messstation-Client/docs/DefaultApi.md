# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://ASP_NET*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiMesstationGet**](DefaultApi.md#apimesstationget) | **GET** /api/Messtation | GET api/Messtation |
| [**ApiMesstationIdDelete**](DefaultApi.md#apimesstationiddelete) | **DELETE** /api/Messtation/{id} | DELETE api/Messtation/{id} |
| [**ApiMesstationIdGet**](DefaultApi.md#apimesstationidget) | **GET** /api/Messtation/{id} | GET api/Messtation/{id} |
| [**ApiMesstationIdMesswertMesswertIdDelete**](DefaultApi.md#apimesstationidmesswertmesswertiddelete) | **DELETE** /api/Messtation/{id}/messwert/{messwertId} | DELETE api/Messtation/{id}/messwert/{messwertId} |
| [**ApiMesstationIdMesswertPost**](DefaultApi.md#apimesstationidmesswertpost) | **POST** /api/Messtation/{id}/messwert | POST api/Messtation/{id}/messwert |
| [**ApiMesstationIdPut**](DefaultApi.md#apimesstationidput) | **PUT** /api/Messtation/{id} | PUT api/Messtation/{id} |
| [**ApiMesstationPost**](DefaultApi.md#apimesstationpost) | **POST** /api/Messtation | POST api/Messtation |

<a id="apimesstationget"></a>
# **ApiMesstationGet**
> void ApiMesstationGet ()

GET api/Messtation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);

            try
            {
                // GET api/Messtation
                apiInstance.ApiMesstationGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET api/Messtation
    apiInstance.ApiMesstationGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationiddelete"></a>
# **ApiMesstationIdDelete**
> void ApiMesstationIdDelete (int id)

DELETE api/Messtation/{id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | 

            try
            {
                // DELETE api/Messtation/{id}
                apiInstance.ApiMesstationIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE api/Messtation/{id}
    apiInstance.ApiMesstationIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationidget"></a>
# **ApiMesstationIdGet**
> void ApiMesstationIdGet (int id)

GET api/Messtation/{id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | 

            try
            {
                // GET api/Messtation/{id}
                apiInstance.ApiMesstationIdGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET api/Messtation/{id}
    apiInstance.ApiMesstationIdGetWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationidmesswertmesswertiddelete"></a>
# **ApiMesstationIdMesswertMesswertIdDelete**
> void ApiMesstationIdMesswertMesswertIdDelete (int id, int messwertId)

DELETE api/Messtation/{id}/messwert/{messwertId}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationIdMesswertMesswertIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | 
            var messwertId = 56;  // int | 

            try
            {
                // DELETE api/Messtation/{id}/messwert/{messwertId}
                apiInstance.ApiMesstationIdMesswertMesswertIdDelete(id, messwertId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationIdMesswertMesswertIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationIdMesswertMesswertIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE api/Messtation/{id}/messwert/{messwertId}
    apiInstance.ApiMesstationIdMesswertMesswertIdDeleteWithHttpInfo(id, messwertId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationIdMesswertMesswertIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **messwertId** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationidmesswertpost"></a>
# **ApiMesstationIdMesswertPost**
> void ApiMesstationIdMesswertPost (int id)

POST api/Messtation/{id}/messwert

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationIdMesswertPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | 

            try
            {
                // POST api/Messtation/{id}/messwert
                apiInstance.ApiMesstationIdMesswertPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationIdMesswertPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationIdMesswertPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST api/Messtation/{id}/messwert
    apiInstance.ApiMesstationIdMesswertPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationIdMesswertPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationidput"></a>
# **ApiMesstationIdPut**
> void ApiMesstationIdPut (int id)

PUT api/Messtation/{id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | 

            try
            {
                // PUT api/Messtation/{id}
                apiInstance.ApiMesstationIdPut(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT api/Messtation/{id}
    apiInstance.ApiMesstationIdPutWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationpost"></a>
# **ApiMesstationPost**
> void ApiMesstationPost ()

POST api/Messtation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://ASP_NET";
            var apiInstance = new DefaultApi(config);

            try
            {
                // POST api/Messtation
                apiInstance.ApiMesstationPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiMesstationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST api/Messtation
    apiInstance.ApiMesstationPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiMesstationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

