using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using System.Collections.Specialized;
namespace TestTaskOnellect
{
    public  class PostArray
    {
       static string url = ConfigurationManager.ConnectionStrings["apiConnection"].ConnectionString;
       static HttpClient client = new HttpClient();
     
        
        public static async Task Post(string arrayString)
        {
                
            
                StringContent content =  new StringContent(arrayString);
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Content = content;

                var response = await client.SendAsync(request);
                string responseText = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseText);
                    
                
            }
           
        }

        
        
               

    }

