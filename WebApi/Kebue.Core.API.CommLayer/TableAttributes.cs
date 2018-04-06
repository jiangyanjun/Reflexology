using System;
using System.Collections.Generic;
using System.Linq;

namespace Kebue.Core.API.CommLayer
{

    #region S_UserInfo	
    public class S_UserInfoTable
    {
        public const string Name = "S_UserInfo";
        public const string Column = "Id,UserAccount,Password";
        public const string _ColumnN = "@Id,@UserAccount,@Password";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region U_Url_Check	
    public class U_Url_CheckTable
    {
        public const string Name = "U_Url_Check";
        public const string Column = "Id,UrlId,Url,Webstate,Msg,Result,Create_Time";
        public const string _ColumnN = "@Id,@UrlId,@Url,@Webstate,@Msg,@Result,@Create_Time";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region U_Url_Type	
    public class U_Url_TypeTable
    {
        public const string Name = "U_Url_Type";
        public const string Column = "ID,NAME,SortDesc,STATUS,ParentID,Create_Id,Create_Time,LastUpdate_Id,LastUpdate_Time";
        public const string _ColumnN = "@ID,@NAME,@SortDesc,@STATUS,@ParentID,@Create_Id,@Create_Time,@LastUpdate_Id,@LastUpdate_Time";
        public const string PrimaryKey = "ID";
    }
    #endregion

    #region S_Config	
    public class S_ConfigTable
    {
        public const string Name = "S_Config";
        public const string Column = "Id,Types,Keys,Value,Create_Time,Create_Id,LastUpdate_Id,LastUpdate_Time";
        public const string _ColumnN = "@Id,@Types,@Keys,@Value,@Create_Time,@Create_Id,@LastUpdate_Id,@LastUpdate_Time";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region U_URL_LIST	
    public class U_URL_LISTTable
    {
        public const string Name = "U_URL_LIST";
        public const string Column = "ID,NAME,URL,IconImg,Title,Types,Status,SortDesc,Source,IcomStream,Create_Id,Create_Time,LastUpdate_Id,LastUpdate_Time";
        public const string _ColumnN = "@ID,@NAME,@URL,@IconImg,@Title,@Types,@Status,@SortDesc,@Source,@IcomStream,@Create_Id,@Create_Time,@LastUpdate_Id,@LastUpdate_Time";
        public const string PrimaryKey = "URL";
    }
    #endregion

    #region U_Url_ClickRate	
    public class U_Url_ClickRateTable
    {
        public const string Name = "U_Url_ClickRate";
        public const string Column = "Id,Ip,Msg,UrlId,UserAgents,ClickDate";
        public const string _ColumnN = "@Id,@Ip,@Msg,@UrlId,@UserAgents,@ClickDate";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region S_Menu	
    public class S_MenuTable
    {
        public const string Name = "S_Menu";
        public const string Column = "Id,Name,Url,Types,ParentId,Sort";
        public const string _ColumnN = "@Id,@Name,@Url,@Types,@ParentId,@Sort";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region S_Log	
    public class S_LogTable
    {
        public const string Name = "S_Log";
        public const string Column = "Id,Log_Type,Msg,Module,Category,SubCategory,Create_Time";
        public const string _ColumnN = "@Id,@Log_Type,@Msg,@Module,@Category,@SubCategory,@Create_Time";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region R_KnowledgeBase	
    public class R_KnowledgeBaseTable
    {
        public const string Name = "R_KnowledgeBase";
        public const string Column = "INFO,CODE,Text,USERID,LAST_MODIFIED_TIME,ClientAddressJson,Ip";
        public const string _ColumnN = "@INFO,@CODE,@Text,@USERID,@LAST_MODIFIED_TIME,@ClientAddressJson,@Ip";
        public const string PrimaryKey = "INFO";
    }
    #endregion

    #region R_Visitors	
    public class R_VisitorsTable
    {
        public const string Name = "R_Visitors";
        public const string Column = "Id,Ip,Isp,country,province,city,district,street,street_number,admin_area_code,lat,lng,locid,radius,confidence,Status,OperationTime,IMG,InCount,Remarks";
        public const string _ColumnN = "@Id,@Ip,@Isp,@country,@province,@city,@district,@street,@street_number,@admin_area_code,@lat,@lng,@locid,@radius,@confidence,@Status,@OperationTime,@IMG,@InCount,@Remarks";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region R_VisitorsDetail	
    public class R_VisitorsDetailTable
    {
        public const string Name = "R_VisitorsDetail";
        public const string Column = "Id,Ip,Browser,OS,modelType,Remarks,OperationTime";
        public const string _ColumnN = "@Id,@Ip,@Browser,@OS,@modelType,@Remarks,@OperationTime";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region R_VisitorsInfo	
    public class R_VisitorsInfoTable
    {
        public const string Name = "R_VisitorsInfo";
        public const string Column = "Id,Ip,Isp,Browser,OS,lat,lng,Status,OperationTime,IMG,InCount,Remarks,modelType,Browser_1,OS_1";
        public const string _ColumnN = "@Id,@Ip,@Isp,@Browser,@OS,@lat,@lng,@Status,@OperationTime,@IMG,@InCount,@Remarks,@modelType,@Browser_1,@OS_1";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region S_LeaveAMessage	
    public class S_LeaveAMessageTable
    {
        public const string Name = "S_LeaveAMessage";
        public const string Column = "Id,Name,Content,UserAgent,Create_Time";
        public const string _ColumnN = "@Id,@Name,@Content,@UserAgent,@Create_Time";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region R_TruingLog	
    public class R_TruingLogTable
    {
        public const string Name = "R_TruingLog";
        public const string Column = "ID,UserId,SESSION,INFO,LAST_MODIFIED_TIME";
        public const string _ColumnN = "@ID,@UserId,@SESSION,@INFO,@LAST_MODIFIED_TIME";
        public const string PrimaryKey = "ID";
    }
    #endregion

}

