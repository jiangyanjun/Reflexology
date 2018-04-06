using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Web.Script.Serialization;

namespace XHD.CRM.Data
{
    /// <summary>
    /// Sys_data_authority 的摘要说明
    /// </summary>
    public class Sys_data_authority : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            BLL.Sys_data_authority auth = new BLL.Sys_data_authority();
            Model.Sys_data_authority model = new Model.Sys_data_authority();

            if (request["Action"] == "get")
            {
                DataSet ds = auth.GetList("Role_id=" + request["Role_id"]);
                if (ds.Tables[0].Rows.Count == 4)
                {
                    context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
                }
                else
                {
                    string datatxt = "";

                    datatxt += "{Rows: [";
                    datatxt += "        { '__status': null, 'option_id': 1, 'Sys_option': '客户管理', 'Sys_view': 1, 'Sys_add': 1, 'Sys_edit': 1, 'Sys_del': 1 },";
                    datatxt += "        { '__status': null, 'option_id': 2, 'Sys_option': '跟进管理', 'Sys_view': 1, 'Sys_add': 1, 'Sys_edit': 1, 'Sys_del': 1 },";
                    datatxt += "        { '__status': null, 'option_id': 3, 'Sys_option': '订单管理', 'Sys_view': 1, 'Sys_add': 1, 'Sys_edit': 1, 'Sys_del': 1 },";
                    datatxt += "        { '__status': null, 'option_id': 4, 'Sys_option': '合同管理', 'Sys_view': 1, 'Sys_add': 1, 'Sys_edit': 1, 'Sys_del': 1 }";

                    datatxt += "    ],Total: 4 }";
                    context.Response.Write(datatxt);
                }
            }
            if (request["Action"] == "save")
            {
                string rid = request["rid"];
                string savestring = request["savestring"];
                model.Role_id = int.Parse(rid);

                auth.Delete("Role_id=" + int.Parse( rid));

                JavaScriptSerializer json = new JavaScriptSerializer();
                List<AuthData> _list = json.Deserialize<List<AuthData>>(savestring);

                foreach (AuthData authdata in _list)
                {
                    model.option_id = authdata.option_id;
                    model.Sys_view = authdata.Sys_view;
                    model.Sys_add = authdata.Sys_add;
                    model.Sys_edit = authdata.Sys_edit;
                    model.Sys_del = authdata.Sys_del;
                    model.Sys_option = authdata.Sys_option;

                    auth.Add(model);
                }
                context.Response.Write("true");
            }

            if (request["Action"] == "getauth")
            {
                string crmid = request["crmid"];
                if (string.IsNullOrEmpty(crmid))
                    crmid = "0";
                DataSet ds = null;

                string authtype = request["authtype"];
                string authid = request["authid"];

                if (authid == "1")
                {
                    BLL.CRM_Customer crm = new BLL.CRM_Customer();
                    ds = crm.GetList("id=" + crmid);
                }
                if (authid == "2")
                {
                    BLL.CRM_Follow follow = new BLL.CRM_Follow();
                    ds = follow.GetList("id=" + crmid);
                }

                //权限
                Data.GetDataAuth dataauth = new Data.GetDataAuth();
                string txt = dataauth.GetDataAuthByid(authid, authtype, context.Request.Cookies["UserID"].Value);

                string[] arr = txt.Split(':');
                switch (arr[0])
                {
                    case "all": context.Response.Write("true");
                        break;
                    case "none": context.Response.Write("false");
                        break;
                    case "my":
                        if (ds.Tables[0].Rows[0]["Employee_id"].ToString() == context.Request.Cookies["UserID"].Value)
                        {
                            context.Response.Write("true");
                        }
                        else
                        {
                            context.Response.Write("false");
                        }
                        break;
                    case "dep":
                        BLL.hr_employee emp = new BLL.hr_employee();
                        DataSet ds1 = emp.GetList("id=" + context.Request.Cookies["UserID"].Value);
                        if (ds.Tables[0].Rows[0]["Department_id"].ToString() == arr[1])
                        {
                            context.Response.Write("true");
                        }
                        else
                        {
                            context.Response.Write("false");
                        }
                        break;
                }
            }
        }

        public class AuthData
        {
            public int option_id { get; set; }
            public string Sys_option { get; set; }
            public int Sys_view { get; set; }
            public int Sys_add { get; set; }
            public int Sys_edit { get; set; }
            public int Sys_del { get; set; }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}