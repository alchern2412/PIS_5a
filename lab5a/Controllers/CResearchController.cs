using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace lab5a.Controllers
{
    public class CResearchController : Controller
    {
        // GET, POST: CResearch/C01
        // - метод запроса;
        // - query-параметры(если они есть);
        // - uri;
        // - заголовки;
        // - тело(для post-запроса).
        public void C01()
        {
            HttpRequestBase req = HttpContext.Request;

            StringBuilder res = new StringBuilder();
            res.Append("Method: ").Append(req.HttpMethod);
            res.AppendLine();

            res.Append("URL: ").Append(req.Url);
            res.AppendLine();

            res.Append("QueryString: ").Append(req.RawUrl);
            res.AppendLine();

            res.AppendLine("Query: ");
            for (int i = 0; i < req.QueryString.Count; i++)
            {
                res.AppendLine(req.QueryString.GetKey(i) + " = " + req.QueryString.Get(req.QueryString.GetKey(i)));
            }
            res.AppendLine();

            res.AppendLine("Params: ");
            for (int i = 0; i < req.Params.Count; i++)
            {
                res.AppendLine(req.Params.GetKey(i) + " = " + req.Params.Get(req.Params.GetKey(i)));
            }
            res.AppendLine();

            res.AppendLine("Form: ");
            for (int i = 0; i < req.Form.Count; i++)
            {
                res.AppendLine(req.Form.GetKey(i) + " = " + req.Form.Get(req.Form.GetKey(i)));
            }
            res.AppendLine();

            Response.Write(res.ToString());
        }

        // GET, POST: CResearch/C02
        public void C02()
        {
            HttpResponseBase responseBase = HttpContext.Response;
            StringBuilder res = new StringBuilder();

            res.Append("Response Status: ").AppendLine(responseBase.StatusCode.ToString());

            res.AppendLine("Response Headers: ");
            for (int i = 0; i < responseBase.Headers.Count; i++)
            {
                res.AppendLine(responseBase.Headers.GetKey(i) + " = " + responseBase.Headers.Get(responseBase.Headers.GetKey(i)));
            }
            res.AppendLine("Body: ");
            for (int i = 0; i < Request.Form.Count; i++)
            {
                res.AppendLine(Request.Form.GetKey(i) + " = " + Request.Form.Get(Request.Form.GetKey(i)));
            }

            Response.Write(res.ToString());
        }
    }
}