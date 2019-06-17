using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleCCaptchaASP.Net
{
    public partial class SampleCCaptcha : System.Web.UI.Page
    {
        public class Info
        {
            public string Token { get; set; }
            public string Secret_Code { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Secret_Code = "YOUR SECRET CODE";
            if (Request.Form["ccaptcha_token_input"] != null)
                info.Token = (Request.Form["ccaptcha_token_input"]).ToString();

            // connect  to  webservice
            WebClient objclient = new WebClient();
            objclient.Headers[HttpRequestHeader.ContentType] = "application/json ; charset=utf-8";
            objclient.Encoding = UTF8Encoding.UTF8;

            //for use JsonConvert Serializer please install Newtonsoft package
            string json = JsonConvert.SerializeObject(info);
            string Response = objclient.UploadString("https://api.ccaptcha.com/api/Validate/ValidationPost", json);

            if (Response == "\"true\"")
            {
                lbl.Text = "true"; // Correctly solved
            }
            else
            {
                lbl.Text = "false";
            }

        }
    }
}