using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodys.CL.RestApi;


namespace RestClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("qwerty");
           // Console.ReadLine();  
            
         CreditLensRequest workflowRequest = new CreditLensRequest
        {
            {"wfid", "00000000-000-0000-0000-000000000000" },
            {"taskid", "00000000-000-0000-0000-000000000000" }
        };


            using (CreditLensClient client = new CreditLensClient("http://172.30.2.124"))
            {
                CreditLensRequest searchRequest = new CreditLensRequest();
                //searchRequest.Add("context", workflowRequest);
                searchRequest.Add("PayLoad", new CreditLensRequest { { "Longname", "Entity" } });
                CreditLensResponses searchResponse = client.Search("1", searchRequest);
                if (searchResponse.Error)
                {
                    Console.WriteLine("error occured");
                }

            };



        //CreditLensClient client = new CreditLensClient("http://172.30.2.124");

        //    CreditLensRequest searchRequest = new CreditLensRequest();
        //    searchRequest.Add("context", workflowRequest);
        //    searchRequest.Add("PayLoad", new CreditLensRequest { { "Longname", "Entity" } });

        //    CreditLensResponses searchResponse = client.Search("1", searchRequest);

        //    if (searchResponse.Error)
        //    {
        //        Console.WriteLine("error occured");
        //    }
        //    else
        //    {
        //        //foreach(CreditLensResponses resultItem in searchResponse)
        //        //{
        //        //    Console.WriteLine("EntityId: {0} , LongName: {1}", resultItem["EntityId"], resultItem["LongName"]);
        //        //}
        //    }


    }


       


        //private string url = "http://172.30.2.124";

     //   CreditLensClient client = new CreditLensClient("http://172.30.2.124");
        //{
        //    CreditLensRequest entityRequest = new CreditLensRequest
        //{
        //    {"LongName", "CodeEntity" },
        //    {"ShortName","TestEntity" },
        //    {"CreditPortfolio", "UniTeam" },
        //    {"BusinessPortfolio", "Usa" }
        //};

        //CreditLensResponse entityResponse = client.Create("EntityCreate", entityRequest);


        //};



       
       



    }
}
