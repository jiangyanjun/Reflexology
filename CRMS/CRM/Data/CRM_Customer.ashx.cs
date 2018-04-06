using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using XHD.Common;

namespace XHD.CRM.Data
{
    /// <summary>
    /// CRM_Customer 的摘要说明
    /// </summary>
    public class CRM_Customer : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            BLL.CRM_Customer customer = new BLL.CRM_Customer();
            Model.CRM_Customer model = new Model.CRM_Customer();

            BLL.hr_employee emp = new BLL.hr_employee();
            int emp_id = int.Parse(request.Cookies["UserID"].Value);
            DataSet dsemp = emp.GetList("id=" + emp_id);
            string empname = dsemp.Tables[0].Rows[0]["name"].ToString();
            string uid = dsemp.Tables[0].Rows[0]["uid"].ToString();

            //save
            if (request["Action"] == "save")
            {
                model.Customer = PageValidate.InputText(request["T_company"], 255);
                model.address = PageValidate.InputText(request["T_address"], 255);
                model.fax = PageValidate.InputText(request["T_fax"], 255);
                model.site = PageValidate.InputText(request["T_Website"], 255);

                model.tel = PageValidate.InputText(request["T_company_tel"], 255);
                model.industry = PageValidate.InputText(request["T_industry"], 255);

                string provincesid = request["T_Provinces_val"];
                if (string.IsNullOrEmpty(provincesid))
                    provincesid = "0";
                model.Provinces_id = int.Parse(provincesid);

                model.Provinces = PageValidate.InputText(request["T_Provinces"], 255);

                string cityid = request["T_City_val"];
                if (string.IsNullOrEmpty(cityid))
                    cityid = "0";
                model.City_id = int.Parse(cityid);
                model.City = PageValidate.InputText(request["T_City"], 255);

                string ctypeid = request["T_customertype_val"];
                if (string.IsNullOrEmpty(ctypeid))
                    ctypeid = "0";
                model.CustomerType_id = int.Parse(ctypeid);
                model.CustomerType = PageValidate.InputText(request["T_customertype"], 255);

                string clevelid = request["T_customerlevel_val"];
                if (string.IsNullOrEmpty(clevelid))
                    clevelid = "0";
                model.CustomerLevel_id = int.Parse(clevelid);
                model.CustomerLevel = PageValidate.InputText(request["T_customerlevel"], 255);

                string csourceid = request["T_CustomerSource_val"];
                if (string.IsNullOrEmpty(csourceid))
                    csourceid = "0";
                model.CustomerSource_id = int.Parse(csourceid);
                model.CustomerSource = PageValidate.InputText(request["T_CustomerSource"], 255);

                model.DesCripe = PageValidate.InputText(request["T_descript"], 4000);
                model.Remarks = PageValidate.InputText(request["T_remarks"], 4000);
                model.privatecustomer = PageValidate.InputText(request["T_private"], 255);

                string depid = request["T_department_val"];
                if (string.IsNullOrEmpty(depid))
                    depid = "0";
                model.Department_id = int.Parse(depid);
                model.Department = PageValidate.InputText(request["T_department"], 255);

                string empid = request["T_employee_val"];
                if (string.IsNullOrEmpty(empid))
                    empid = "0";
                model.Employee_id = int.Parse(empid);
                model.Employee = PageValidate.InputText(request["T_employee"], 255);


                string id = request["id"];
                if (!string.IsNullOrEmpty(id) && id != "null")
                {
                    DataSet ds = customer.GetList("id=" + int.Parse(id));
                    DataRow dr = ds.Tables[0].Rows[0];

                    model.Serialnumber = PageValidate.InputText(dr["Serialnumber"].ToString(), 255);

                    model.id = int.Parse(id);
                    customer.Update(model);

                    //日志
                    C_Sys_log log = new C_Sys_log();

                    int UserID = emp_id;
                    string UserName = empname;
                    string IPStreet = request.UserHostAddress;
                    string EventTitle = model.Customer;
                    string EventType = "客户修改";
                    int EventID = model.id;

                    if (dr["Customer"].ToString() != request["T_company"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "公司名", dr["Customer"].ToString(), request["T_company"].ToString());

                    if (dr["address"].ToString() != request["T_address"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "地址", dr["address"].ToString(), request["T_address"].ToString());

                    if (dr["fax"].ToString() != request["T_fax"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "传真", dr["fax"].ToString(), request["T_fax"].ToString());

                    if (dr["site"].ToString() != request["T_Website"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "网址", dr["site"].ToString(), request["T_Website"].ToString());

                    if (dr["industry"].ToString() != request["T_industry"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "行业", dr["industry"].ToString(), request["T_industry"].ToString());

                    if (dr["Provinces"].ToString() != request["T_Provinces"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "省份", dr["Provinces"].ToString(), request["T_Provinces"].ToString());

                    if (dr["City"].ToString() != request["T_City"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "城市", dr["City"].ToString(), request["T_City"].ToString());

                    if (dr["CustomerType"].ToString() != request["T_customertype"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "客户类型", dr["CustomerType"].ToString(), request["T_customertype"].ToString());

                    if (dr["CustomerLevel"].ToString() != request["T_customerlevel"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "客户级别", dr["CustomerLevel"].ToString(), request["T_customerlevel"].ToString());

                    if (dr["CustomerSource"].ToString() != request["T_CustomerSource"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "客户来源", dr["CustomerSource"].ToString(), request["T_CustomerSource"].ToString());

                    if (dr["DesCripe"].ToString() != request["T_descript"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "客户描述", dr["DesCripe"].ToString(), request["T_descript"].ToString());

                    if (dr["Remarks"].ToString() != request["T_remarks"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "备注", dr["Remarks"].ToString(), request["T_remarks"].ToString());

                    if (dr["privatecustomer"].ToString() != request["T_private"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "公私", dr["privatecustomer"].ToString(), request["T_private"].ToString());

                    if (dr["Department"].ToString() != request["T_department"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "部门", dr["Department"].ToString(), request["T_department"].ToString());

                    if (dr["Employee"].ToString() != request["T_employee"])
                        log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "员工", dr["Employee"].ToString(), request["T_employee"].ToString());
                }
                else
                {

                    DateTime nowtime = DateTime.Now;
                    model.Create_date = nowtime;
                    model.Serialnumber = nowtime.AddMilliseconds(3).ToString("yyyyMMddHHmmssfff").Trim();
                    model.lastfollow = nowtime;
                    model.Create_id = int.Parse(request.Cookies["UserID"].Value);
                    int customerid = customer.Add(model);

                    BLL.CRM_Contact contact = new BLL.CRM_Contact();
                    Model.CRM_Contact modelcontact = new Model.CRM_Contact();
                    modelcontact.C_name = PageValidate.InputText(request["T_customername"], 255);
                    modelcontact.C_sex = PageValidate.InputText(request["T_sex"], 255);
                    modelcontact.C_department = PageValidate.InputText(request["T_dep"], 255);
                    modelcontact.C_position = PageValidate.InputText(request["T_position"], 255);
                    modelcontact.C_QQ = PageValidate.InputText(request["T_qq"], 255);
                    modelcontact.C_tel = PageValidate.InputText(request["T_tel"], 255);
                    modelcontact.C_mob = PageValidate.InputText(request["T_mobil"], 255);
                    modelcontact.C_email = Common.PageValidate.InputText(request["T_email"], 255);
                    modelcontact.C_customerid = customerid;
                    modelcontact.C_customername = model.Customer;
                    modelcontact.C_createId = emp_id;
                    modelcontact.C_createDate = DateTime.Now;
                    contact.Add(modelcontact);

                    context.Response.Write("{success:success}");

                }
            }
            if (request["Action"] == "grid")
            {
                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " Create_date";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = "desc";

                string sorttext = " " + sortname + " " + sortorder;

                string Total;
                string serchtxt = null;
                string serchtype = request["isdel"];
                if (serchtype == "1")
                {
                    serchtxt += " ISNULL(isDelete,0)=1 ";
                }
                else
                {
                    serchtxt += "ISNULL(isDelete,0)=0 ";
                }

                if (!string.IsNullOrEmpty(request["company"]))
                    serchtxt += " and Customer like N'%" + PageValidate.InputText( request["company"],255) + "%'";

                if (!string.IsNullOrEmpty(request["address"]))
                    serchtxt += " and address like N'%" + PageValidate.InputText( request["address"],255) + "%'";

                if (!string.IsNullOrEmpty(request["industry"]))
                    serchtxt += " and industry like N'%" + PageValidate.InputText(request["industry"], 255) + "%'";

                if (!string.IsNullOrEmpty(request["tel"]))
                    serchtxt += " and tel like N'%" + PageValidate.InputText( request["tel"],255) + "%'";

                if (!string.IsNullOrEmpty(request["mobil"]))
                    serchtxt += " and mobil like N'%" +PageValidate.InputText( request["mobil"],255) + "%'";

                if (!string.IsNullOrEmpty(request["qq"]))
                    serchtxt += " and QQ like N'%" + PageValidate.InputText( request["qq"],255) + "%'";

                if (!string.IsNullOrEmpty(request["website"]))
                    serchtxt += " and site like N'%" + PageValidate.InputText( request["website"] ,255)+ "%'";

                if (!string.IsNullOrEmpty(request["customertype"]))
                    serchtxt += " and CustomerType_id = " + int.Parse( request["customertype_val"]);

                if (!string.IsNullOrEmpty(request["customerlevel"]))
                    serchtxt += " and CustomerLevel_id = " + int.Parse( request["customerlevel_val"]);

                if (!string.IsNullOrEmpty(request["T_Provinces"]))
                    serchtxt += " and Provinces_id = " + int.Parse( request["T_Provinces_val"]);

                if (!string.IsNullOrEmpty(request["T_City"]))
                    serchtxt += " and City_id = " + int.Parse( request["T_City_val"]);

                if (!string.IsNullOrEmpty(request["department"]))
                    serchtxt += " and Department_id = " + int.Parse( request["department_val"]);

                if (!string.IsNullOrEmpty(request["employee"]))
                    serchtxt += " and Employee_id = " + int.Parse( request["employee_val"]);

                if (!string.IsNullOrEmpty(request["startdate"]))
                    serchtxt += " and Create_date >= '" + PageValidate.InputText( request["startdate"] ,255)+ "'";

                if (!string.IsNullOrEmpty(request["enddate"]))
                {
                    DateTime enddate = DateTime.Parse(request["enddate"]).AddHours(23).AddMinutes(59).AddSeconds(59);
                    serchtxt += " and Create_date <= '" + enddate + "'";
                }

                if (!string.IsNullOrEmpty(request["startdate_del"]))
                    serchtxt += " and Delete_time >= '" + PageValidate.InputText( request["startdate_del"],255) + "'";

                if (!string.IsNullOrEmpty(request["enddate_del"]))
                {
                    DateTime enddatedel = DateTime.Parse(request["enddate_del"]).AddHours(23).AddMinutes(59).AddSeconds(59);
                    serchtxt += " and Delete_time <= '" + enddatedel + "'";
                }

                if (!string.IsNullOrEmpty(request["startfollow"]))
                    serchtxt += " and lastfollow >= '" + PageValidate.InputText( request["startfollow"],255) + "'";

                if (!string.IsNullOrEmpty(request["endfollow"]))
                {
                    DateTime enddate = DateTime.Parse(request["endfollow"]).AddHours(23).AddMinutes(59).AddSeconds(59);
                    serchtxt += " and lastfollow <= '" + enddate + "'";
                }

                //权限
                DataSet ds = customer.GetList(PageSize, PageIndex, serchtxt, sorttext, out Total);

                DataSet dsauth = DataAuth(ds, request.Cookies["UserID"].Value);

                string dt = Common.GetGridJSON.DataTableToJSON1(dsauth.Tables[0], Total);
                context.Response.Write(dt);
            }

            //Form JSON
            if (request["Action"] == "form")
            {
                DataSet ds = customer.GetList("id=" + int.Parse(request["cid"]));

                string dt = Common.DataToJson.DataToJSON(DataAuth(ds, emp_id.ToString()));

                context.Response.Write(dt);
            }

            //预删除
            if (request["Action"] == "AdvanceDelete")
            {
                string id = request["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    id = Common.PageValidate.IsNumber(id) ? id : "-1";
                }
                else
                {
                    id = "-1";
                }
                DataSet ds = customer.GetList("id=" + int.Parse(id));

                BLL.CRM_Contact contact = new BLL.CRM_Contact();
                BLL.CRM_contract contract = new BLL.CRM_contract();
                BLL.CRM_Follow follow = new BLL.CRM_Follow();

                if (follow.GetList(" Customer_id=" + int.Parse(id)).Tables[0].Rows.Count > 0)
                {
                    //含有跟进信息，不能删除
                    context.Response.Write("false:follow");
                }
                else if (contact.GetList(" C_customerid=" + int.Parse(id)).Tables[0].Rows.Count > 0)
                {
                    //含联系人
                    context.Response.Write("false:contact");
                }
                else if (contract.GetList(" Customer_id=" + int.Parse(id)).Tables[0].Rows.Count > 0)
                {
                    //含订单
                    context.Response.Write("false:order");
                }
                else
                {

                    bool canedel = true;
                    if (uid != "admin")
                    {
                        Data.GetDataAuth dataauth = new Data.GetDataAuth();
                        string txt = dataauth.GetDataAuthByid("1", "Sys_del", emp_id.ToString());

                        string[] arr = txt.Split(':');
                        switch (arr[0])
                        {
                            case "none":
                                canedel = false;
                                break;
                            case "my":
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    if (ds.Tables[0].Rows[i]["Employee_id"].ToString() == arr[1])
                                        canedel = true;
                                    else
                                        canedel = false;
                                }
                                break;
                            case "dep":
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    if (ds.Tables[0].Rows[i]["dep_id"].ToString() == arr[1])
                                        canedel = true;
                                    else
                                        canedel = false;
                                }
                                break;
                            case "all":
                                canedel = true;
                                break;
                        }
                    }

                    if (canedel)
                    {
                        bool isdel = customer.AdvanceDelete(int.Parse(request["id"]), 1, DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss));
                        //context.Response.Write("{success:success}");
                        if (isdel)
                        {
                            //日志
                            string EventType = "客户预删除";

                            int UserID = emp_id;
                            string UserName = empname;
                            string IPStreet = request.UserHostAddress;
                            int EventID = int.Parse(id);
                            string EventTitle = ds.Tables[0].Rows[0]["Customer"].ToString();
                            string Original_txt = null;
                            string Current_txt = null;

                            C_Sys_log log = new C_Sys_log();

                            log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, null, Original_txt, Current_txt);

                            context.Response.Write("true");
                        }
                        else
                        {
                            context.Response.Write("false");
                        }
                    }

                    else
                    {
                        context.Response.Write("delfalse");
                    }
                }

            }

            //regain            
            if (request["Action"] == "regain")
            {
                string idlist = PageValidate.InputText( request["idlist"],100000);
                string[] arr = idlist.Split(',');

                DataSet ds = customer.GetList("id in (" + idlist.Trim() + ")");


                bool canedel = true;
                if (uid != "admin")
                {
                    Data.GetDataAuth dataauth = new Data.GetDataAuth();
                    string txt = dataauth.GetDataAuthByid("1", "Sys_del", emp_id.ToString());

                    string[] arr1 = txt.Split(':');
                    switch (arr1[0])
                    {
                        case "none":
                            canedel = false;
                            break;
                        case "my":
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                if (ds.Tables[0].Rows[i]["Employee_id"].ToString() == arr1[1])
                                    canedel = true;
                                else
                                    canedel = false;
                            }
                            break;
                        case "dep":
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                if (ds.Tables[0].Rows[i]["Department_id"].ToString() == arr1[1])
                                    canedel = true;
                                else
                                    canedel = false;
                            }
                            break;
                        case "all":
                            canedel = true;
                            break;
                    }
                }
                if (canedel)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        customer.AdvanceDelete(int.Parse(arr[i]), 0, DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss));
                    }

                    if (true)
                    {
                        //日志

                        string EventType = "恢复删除商家";


                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int UserID = emp_id;
                            string UserName = empname;
                            int EventID = idlist[i];
                            string IPStreet = request.UserHostAddress;
                            string EventTitle = ds.Tables[0].Rows[i]["Customer"].ToString();
                            string Original_txt = null;
                            string Current_txt = null;

                            C_Sys_log log = new C_Sys_log();
                            log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, null, Original_txt, Current_txt);
                        }

                        context.Response.Write("true");
                    }                      
                }
                else
                {    
                    context.Response.Write("delfalse");
                } 
            }  

            if (request.Params["Action"] == "del")
            {
                bool canDel = false;
                if (dsemp.Tables[0].Rows.Count > 0)
                {
                    if (dsemp.Tables[0].Rows[0]["uid"].ToString() == "admin")
                    {
                        canDel = true;
                    }
                    else
                    {
                        Data.GetAuthorityByUid getauth = new Data.GetAuthorityByUid();
                        string delauth = getauth.GetBtnAuthority(request.Cookies["UserID"].Value, "60");
                        if (delauth == "false")
                            canDel = false;
                        else
                            canDel = true;
                    }
                }
                if (canDel)
                {
                    string idlist = PageValidate.InputText( request["idlist"],100000);
                    string[] arr = idlist.Split(',');

                    string EventType = "彻底删除商家";

                    DataSet ds = customer.GetList("id in (" + idlist.Trim() + ")");

                    bool canedel = true;
                    if (uid != "admin")
                    {
                        Data.GetDataAuth dataauth = new Data.GetDataAuth();
                        string txt = dataauth.GetDataAuthByid("1", "Sys_del", emp_id.ToString());

                        string[] arr1 = txt.Split(':');
                        switch (arr1[0])
                        {
                            case "none":
                                canedel = false;
                                break;
                            case "my":
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    if (ds.Tables[0].Rows[i]["Employee_id"].ToString() == arr1[1])
                                        canedel = true;
                                    else
                                        canedel = false;
                                }
                                break;
                            case "dep":
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    if (ds.Tables[0].Rows[i]["dep_id"].ToString() == arr1[1])
                                        canedel = true;
                                    else
                                        canedel = false;
                                }
                                break;
                            case "all":
                                canedel = true;
                                break;
                        }
                    }
                    if (canedel)
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            customer.Delete(int.Parse(arr[i]));
                        }

                        if (true)
                        {
                            //日志    
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                int UserID = emp_id;
                                string UserName = empname;
                                string IPStreet = request.UserHostAddress;
                                int EventID = idlist[i];
                                string EventTitle = ds.Tables[0].Rows[0]["Customer"].ToString();
                                string Original_txt = null;
                                string Current_txt = null;

                                C_Sys_log log = new C_Sys_log();

                                log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, null, Original_txt, Current_txt);
                            }
                            context.Response.Write("true");
                        }                          
                    }
                    else
                    {
                        context.Response.Write("delfalse");
                    }
                }
                else
                {
                    context.Response.Write("auth");
                }
            }


            //validate website
            if (request["Action"] == "validate")
            {
                BLL.CRM_Customer cc = new BLL.CRM_Customer();
                string website = request["T_Website"];
                string customerid = request["T_cid"];
                if (string.IsNullOrEmpty(customerid) || customerid == "null")
                    customerid = "0";

                string oldsite = urlstr(website);

                //context.Response.Write("oldsite:"+oldsite);

                DataSet ds = cc.GetList("site like N'%" + oldsite + "%' and id!=" + customerid);
                //context.Response.Write(" Count:" + ds.Tables[0].Rows.Count);

                bool b = true;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //context.Response.Write(" newsite:"+urlstr(ds.Tables[0].Rows[0]["site"].ToString()));

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (urlstr(ds.Tables[0].Rows[i]["site"].ToString()) == oldsite)
                        {
                            b = false;
                            break;
                        }
                    }
                }

                if (b)
                {
                    context.Response.Write("true");
                }
                else
                {
                    context.Response.Write("false");
                }
            }

            if (request["Action"] == "Compared")
            {
                string dt1 = request["date1"];
                string dt2 = request["date2"];

                DataSet ds = customer.Compared(DateTime.Parse(dt1), DateTime.Parse(dt2));

                string dt = GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "Compared_type")
            {
                string dt1 = request["date1"];
                string dt2 = request["date2"];

                DataSet ds = customer.Compared_type(DateTime.Parse(dt1), DateTime.Parse(dt2));

                string dt = GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);

            }

            if (request["Action"] == "Compared_level")
            {
                string dt1 = request["date1"];
                string dt2 = request["date2"];

                DataSet ds = customer.Compared_level(DateTime.Parse(dt1), DateTime.Parse(dt2));

                string dt = GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "Compared_source")
            {
                string dt1 = request["date1"];
                string dt2 = request["date2"];

                DataSet ds = customer.Compared_source(DateTime.Parse(dt1), DateTime.Parse(dt2));

                string dt = GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "Compared_empcusadd")
            {
                var idlist = PageValidate.InputText( request["idlist"].Replace(";", ",").Replace("-", ""),100000);
                string dt1 = request["date1"];
                string dt2 = request["date2"];

                BLL.hr_post post = new BLL.hr_post();
                DataSet dspost = post.GetList(" post_id in(" + idlist + ")");

                string emplist = "(";

                for (int i = 0; i < dspost.Tables[0].Rows.Count - 1; i++)
                {
                    emplist += dspost.Tables[0].Rows[i]["emp_id"] + ",";
                }
                emplist += dspost.Tables[0].Rows[dspost.Tables[0].Rows.Count - 1]["emp_id"] + ")";

                //context.Response.Write(emplist);

                DataSet ds = customer.Compared_empcusadd(DateTime.Parse(dt1), DateTime.Parse(dt2), emplist);

                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "emp_customer")
            {
                var idlist = PageValidate.InputText( request["idlist"].Replace(";", ",").Replace("-", ""),100000);
                var syear = request["syear"];

                BLL.hr_post post = new BLL.hr_post();
                DataSet dspost = post.GetList("post_id in(" + idlist + ")");

                string emplist = "(";

                for (int i = 0; i < dspost.Tables[0].Rows.Count - 1; i++)
                {
                    emplist += dspost.Tables[0].Rows[i]["emp_id"] + ",";
                }
                emplist += dspost.Tables[0].Rows[dspost.Tables[0].Rows.Count - 1]["emp_id"] + ")";

                //context.Response.Write(emplist);

                DataSet ds = customer.report_empcus(int.Parse(syear), emplist);

                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

        }

        private DataSet DataAuth(DataSet ds, string uid)
        {
            //权限
            BLL.hr_employee emp = new BLL.hr_employee();
            DataSet dsemp = emp.GetList("ID=" + int.Parse( uid));
            if (dsemp.Tables[0].Rows.Count > 0)
            {
                if (dsemp.Tables[0].Rows[0]["uid"].ToString() != "admin")
                {
                    Data.GetDataAuth dataauth = new Data.GetDataAuth();
                    string txt = dataauth.GetDataAuthByid("1", "Sys_view", uid);


                    string[] arr = txt.Split(':');
                    switch (arr[0])
                    {
                        case "none": ds.Tables[0].Rows.Clear();
                            break;
                        case "my":
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                if (ds.Tables[0].Rows[i]["privatecustomer"].ToString() == "私客" && ds.Tables[0].Rows[i]["Employee_id"].ToString() != arr[1])
                                {
                                    ds.Tables[0].Rows[i]["contact"] = "---";
                                    ds.Tables[0].Rows[i]["QQ"] = "---";
                                    ds.Tables[0].Rows[i]["mobil"] = "---";
                                    ds.Tables[0].Rows[i]["tel"] = "---";
                                    ds.Tables[0].Rows[i]["fax"] = "---";
                                    ds.Tables[0].Rows[i]["site"] = "---";
                                    ds.Tables[0].Rows[i]["email"] = "---";
                                }
                            }
                            break;
                        case "dep":
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                if (ds.Tables[0].Rows[i]["privatecustomer"].ToString() == "私客" && ds.Tables[0].Rows[i]["Department_id"].ToString() != arr[1])
                                {
                                    ds.Tables[0].Rows[i]["contact"] = "---";
                                    ds.Tables[0].Rows[i]["QQ"] = "---";
                                    ds.Tables[0].Rows[i]["mobil"] = "---";
                                    ds.Tables[0].Rows[i]["tel"] = "---";
                                    ds.Tables[0].Rows[i]["fax"] = "---";
                                    ds.Tables[0].Rows[i]["site"] = "---";
                                    ds.Tables[0].Rows[i]["email"] = "---";
                                }
                            }
                            break;
                    }
                }
            }
            return ds;
        }

        public string urlstr(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                string a = url.Replace("http://", "").Replace("ftp://", "");
                string b = a.Split('/')[0];
                string[] c = b.Split('.');
                string d = c.ToString();
                if (c.Length >= 3)
                {
                    if (c[c.Length - 2] == "com" && c[c.Length - 1] == "cn")
                        d = c[c.Length - 3] + c[c.Length - 2] + "." + c[c.Length - 1];
                    else
                        d = c[c.Length - 2] + "." + c[c.Length - 1];
                }

                return d;
            }
            else
            {
                return "";
            }
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