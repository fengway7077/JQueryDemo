using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Web.Script.Serialization;

namespace JqueryDemo
{
    public class Employee
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string age { get; set; }
    }
    public partial class json3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string json = "[{ \"firstname\":\"NO NAME\",\"lastName\":\"App\",\"email \":\"abc@gmail.com\",\"age\":14},{ \"firstname\":\"Linh\",\"lastName\":\"Tran\",\"email \":\"def@gmail.com\",\"age\":123}]";
            JavaScriptSerializer javascriptserializer = new JavaScriptSerializer();
            var listEmployee = javascriptserializer.Deserialize<List<Employee>>(json);//json sang object

            var strjson = javascriptserializer.Serialize(listEmployee);//chuyen tu 1 list object sang json
            Response.Write(strjson);
        }
    }
}