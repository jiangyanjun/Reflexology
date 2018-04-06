namespace Foot.EntityLayers
{
    #region OrderDetailed	
    public class OrderDetailedTable
    {
        public const string Name = "OrderDetailed";
        public const string Column = "Id,IId,ProductId,Price,Quantity,ShopId,Remarks,CreateUserId,CreateTime,LastOperationUserId,LastOperationTime";
        public const string _ColumnN = "@Id,@IId,@ProductId,@Price,@Quantity,@ShopId,@Remarks,@CreateUserId,@CreateTime,@LastOperationUserId,@LastOperationTime";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region Orders	
    public class OrdersTable
    {
        public const string Name = "Orders";
        public const string Column = "Id,DeskId,CustomerNumber,TypeId,MemberId,CustomerName,TelePhone,ShopId,Status,FlowStatus,TotalAmount,FreeAmount,PaymentAmount,Remarks,CreateUserId,CreateTime,LastOperationUserId,LastOperationTime,PackageId";
        public const string _ColumnN = "@Id,@DeskId,@CustomerNumber,@TypeId,@MemberId,@CustomerName,@TelePhone,@ShopId,@Status,@FlowStatus,@TotalAmount,@FreeAmount,@PaymentAmount,@Remarks,@CreateUserId,@CreateTime,@LastOperationUserId,@LastOperationTime,@PackageId";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region Product	
    public class ProductTable
    {
        public const string Name = "Product";
        public const string Column = "Id,ShopId,ProductTypeId,ProductName,CostPrice,Price,StockQuantity,Inventory,Status,Remarks,CreateUserId,CreateTime,LastOperationUserId,LastOperationTime,QRode";
        public const string _ColumnN = "@Id,@ShopId,@ProductTypeId,@ProductName,@CostPrice,@Price,@StockQuantity,@Inventory,@Status,@Remarks,@CreateUserId,@CreateTime,@LastOperationUserId,@LastOperationTime,@QRode";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region ProductType	
    public class ProductTypeTable
    {
        public const string Name = "ProductType";
        public const string Column = "Id,Name,ShopId,Status,Remarks,CreateUserId,CreateTime,LastOperationUserId,LastOperationTime";
        public const string _ColumnN = "@Id,@Name,@ShopId,@Status,@Remarks,@CreateUserId,@CreateTime,@LastOperationUserId,@LastOperationTime";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region tb_Booked	
    public class tb_BookedTable
    {
        public const string Name = "tb_Booked";
        public const string Column = "Id,GuestName,GuestTelePhone,BookedDeskTypeId,BookedDeskId,BookedDateTime,ShopId,Remarks,CreateUserId,CreateTime,LastOperationTime,LastOperationUserId,Status";
        public const string _ColumnN = "@Id,@GuestName,@GuestTelePhone,@BookedDeskTypeId,@BookedDeskId,@BookedDateTime,@ShopId,@Remarks,@CreateUserId,@CreateTime,@LastOperationTime,@LastOperationUserId,@Status";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region tb_Desk	
    public class tb_DeskTable
    {
        public const string Name = "tb_Desk";
        public const string Column = "ID,Name,TypeId,ShopId,Status,DeskStatus,Remarks,CreateUserId,CreateTime,LastOperationUserId,LastOperationTime";
        public const string _ColumnN = "@ID,@Name,@TypeId,@ShopId,@Status,@DeskStatus,@Remarks,@CreateUserId,@CreateTime,@LastOperationUserId,@LastOperationTime";
        public const string PrimaryKey = "ID";
    }
    #endregion

    #region tb_deskType	
    public class tb_DeskTypeTable
    {
        public const string Name = "tb_deskType";
        public const string Column = "Id,Name,Remarks,CreateUserId,CreateTime,LastOperationUserId,LastOperationTime,Status";
        public const string _ColumnN = "@Id,@Name,@Remarks,@CreateUserId,@CreateTime,@LastOperationUserId,@LastOperationTime,@Status";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region tb_deskXSTable	
    public class tb_DeskXSTable
    {
        public const string Name = "tb_deskXS";
        public const string Column = "XS_ID,XS_DeskName,XS_goodsName,XS_dj,XS_Sum,XS_allprice,XS_sj,beizhu";
        public const string _ColumnN = "@XS_ID,@XS_DeskName,@XS_goodsName,@XS_dj,@XS_Sum,@XS_allprice,@XS_sj,@beizhu";
        public const string PrimaryKey = "XS_ID";
    }
    #endregion

    #region tb_duty	
    public class tb_dutyTable
    {
        public const string Name = "tb_duty";
        public const string Column = "Duty_ID,Duty_Name";
        public const string _ColumnN = "@Duty_ID,@Duty_Name";
        public const string PrimaryKey = "Duty_ID";
    }
    #endregion

    #region tb_goods	
    public class tb_goodsTable
    {
        public const string Name = "tb_goods";
        public const string Column = "goods_ID,goods_Name,Goods_type,Goods_Xsprice,Goods_num,Goods_Jhnum,Goods_Jhprice,Goods_allprice,Goods_CKID,Beizhu";
        public const string _ColumnN = "@goods_ID,@goods_Name,@Goods_type,@Goods_Xsprice,@Goods_num,@Goods_Jhnum,@Goods_Jhprice,@Goods_allprice,@Goods_CKID,@Beizhu";
        public const string PrimaryKey = "goods_ID";
    }
    #endregion

    #region tb_goodsCF	
    public class tb_goodsCFTable
    {
        public const string Name = "tb_goodsCF";
        public const string Column = "ID,CF_ID,CF_GoodsID";
        public const string _ColumnN = "@ID,@CF_ID,@CF_GoodsID";
        public const string PrimaryKey = "ID";
    }
    #endregion

    #region tb_goodsCG	
    public class tb_goodsCGTable
    {
        public const string Name = "tb_goodsCG";
        public const string Column = "CG_ID,CG_sj,CG_ghs,CG_buyer,CG_Allprice,CG_beizhu";
        public const string _ColumnN = "@CG_ID,@CG_sj,@CG_ghs,@CG_buyer,@CG_Allprice,@CG_beizhu";
        public const string PrimaryKey = "CG_ID";
    }
    #endregion

    #region tb_goodsMX	
    public class tb_goodsMXTable
    {
        public const string Name = "tb_goodsMX";
        public const string Column = "MX_ID,MX_CGID,MX_name,Goods_type,MX_price,MX_num,MX_allprice,MX_beizhu";
        public const string _ColumnN = "@MX_ID,@MX_CGID,@MX_name,@Goods_type,@MX_price,@MX_num,@MX_allprice,@MX_beizhu";
        public const string PrimaryKey = "MX_ID";
    }
    #endregion

    #region tb_member	
    public class tb_memberTable
    {
        public const string Name = "tb_member";
        public const string Column = "member_ID,member_Name,Member_DJ,member_Sex,Member_birthday,Member_Phone,Member_DJRQ,Member_JF,Member_type,member_IDCard,Beizhu";
        public const string _ColumnN = "@member_ID,@member_Name,@Member_DJ,@member_Sex,@Member_birthday,@Member_Phone,@Member_DJRQ,@Member_JF,@Member_type,@member_IDCard,@Beizhu";
        public const string PrimaryKey = "member_ID";
    }
    #endregion

    #region tb_membertype	
    public class tb_membertypeTable
    {
        public const string Name = "tb_membertype";
        public const string Column = "Mt_ID,Mt_Name,Mt_csjf,Mt_agio";
        public const string _ColumnN = "@Mt_ID,@Mt_Name,@Mt_csjf,@Mt_agio";
        public const string PrimaryKey = "Mt_ID";
    }
    #endregion

    #region tb_memberXF	
    public class tb_memberXFTable
    {
        public const string Name = "tb_memberXF";
        public const string Column = "HY_ID,HY_Name,YH_Zdh,YH_desk,YH_money,YH_sj,Beizhu";
        public const string _ColumnN = "@HY_ID,@HY_Name,@YH_Zdh,@YH_desk,@YH_money,@YH_sj,@Beizhu";
        public const string PrimaryKey = "YH_Zdh";
    }
    #endregion

    #region tb_Open	
    public class tb_OpenTable
    {
        public const string Name = "tb_Open";
        public const string Column = "Id,TypeId,DeskId,CustomersNumber,Remarks,CreateUserId,LastOperationTime,LastOperationUserId,CreateTime,Status";
        public const string _ColumnN = "@Id,@TypeId,@DeskId,@CustomersNumber,@Remarks,@CreateUserId,@LastOperationTime,@LastOperationUserId,@CreateTime,@Status";
        public const string PrimaryKey = "Id";
    }
    #endregion

    #region tb_power	
    public class tb_powerTable
    {
        public const string Name = "tb_power";
        public const string Column = "power_ID,power_type,power_Name,pope";
        public const string _ColumnN = "@power_ID,@power_type,@power_Name,@pope";
        public const string PrimaryKey = "power_ID";
    }
    #endregion

    #region tb_powertype	
    public class tb_powertypeTable
    {
        public const string Name = "tb_powertype";
        public const string Column = "Pt_ID,Pt_Name";
        public const string _ColumnN = "@Pt_ID,@Pt_Name";
        public const string PrimaryKey = "Pt_ID";
    }
    #endregion

    #region tb_qtxs	
    public class tb_qtxsTable
    {
        public const string Name = "tb_qtxs";
        public const string Column = "QT_ID,QT_Goods,QT_goodstype,QT_dj,QT_Num,QT_Allprice,Beizhu";
        public const string _ColumnN = "@QT_ID,@QT_Goods,@QT_goodstype,@QT_dj,@QT_Num,@QT_Allprice,@Beizhu";
        public const string PrimaryKey = "QT_ID";
    }
    #endregion

    #region tb_User	
    public class tb_UserTable
    {
        public const string Name = "tb_User";
        public const string Column = "ID,User_Name,User_Pwd,power,ShopId";
        public const string _ColumnN = "@ID,@User_Name,@User_Pwd,@power,@ShopId";
        public const string PrimaryKey = "ID";
    }
    #endregion

    #region tb_Waiter	
    public class tb_WaiterTable
    {
        public const string Name = "tb_Waiter";
        public const string Column = "Waiter_ID,Waiter_Nmae,Waiter_Sex,Waiter_Age,Waiter_Phone,Waiter_duty,Waiter_pay,Waiter_birthday,Waiter_IDCard,Waiter_Stime,Waiter_Address,Beizhu";
        public const string _ColumnN = "@Waiter_ID,@Waiter_Nmae,@Waiter_Sex,@Waiter_Age,@Waiter_Phone,@Waiter_duty,@Waiter_pay,@Waiter_birthday,@Waiter_IDCard,@Waiter_Stime,@Waiter_Address,@Beizhu";
        public const string PrimaryKey = "Waiter_ID";
    }
    #endregion

    #region tb_warehouse	
    public class tb_warehouseTable
    {
        public const string Name = "tb_warehouse";
        public const string Column = "CK_ID,CK_Name";
        public const string _ColumnN = "@CK_ID,@CK_Name";
        public const string PrimaryKey = "CK_ID";
    }
    #endregion

    #region tb_XF	
    public class tb_XFTable
    {
        public const string Name = "tb_XF";
        public const string Column = "XF_ID,XF_desk,XF_Ymoney,XF_ZK,XF_Smoney,XF_sj,XF_waiter,beizhu";
        public const string _ColumnN = "@XF_ID,@XF_desk,@XF_Ymoney,@XF_ZK,@XF_Smoney,@XF_sj,@XF_waiter,@beizhu";
        public const string PrimaryKey = "XF_ID";
    }
    #endregion

    #region tb_XFMX	
    public class tb_XFMXTable
    {
        public const string Name = "tb_XFMX";
        public const string Column = "MX_XFID,MX_Goods,MX_goodstype,MX_dj,MX_Num,MX_Allprice,Beizhu";
        public const string _ColumnN = "@MX_XFID,@MX_Goods,@MX_goodstype,@MX_dj,@MX_Num,@MX_Allprice,@Beizhu";
        public const string PrimaryKey = "MX_XFID";
    }
    #endregion
}
