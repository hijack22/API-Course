namespace API_Course.Models
{
    public class serviceResponse<T>
     {
            public T Data {get; set;}

            public bool Success {get; set;} = true;
         
            public string Message {get; set;} 
    }
}