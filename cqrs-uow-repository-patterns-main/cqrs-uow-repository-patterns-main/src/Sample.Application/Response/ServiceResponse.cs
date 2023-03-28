 using System.Text.Json.Serialization;

 namespace Sample.Application.Response
{
    public class ServiceResponse<T>
    {
        public ServiceResponse()
        {
            
        }
        
        public ServiceResponse(T data)
        {
            Data = data;
            HasError = false;
        }
        public ServiceResponse(bool hasError, string responseMessage)
        {
            HasError = hasError;
            ResponseMessage = responseMessage;
        }
        
        public ServiceResponse(T data, string responseMessage)
        {
            Data = data;
            ResponseMessage = responseMessage;
        }

        [JsonPropertyName("HasError")]
        public bool HasError { get; set; }
      
        [JsonPropertyName("ResponseMessage")]
        public string ResponseMessage { get; set; }
        
        [JsonPropertyName("Data")]
        public T Data { get; set; }
    }
}