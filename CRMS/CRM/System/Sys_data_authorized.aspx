<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <script src="../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link href="../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
   
    <link href="../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/core.css" rel="stylesheet" type="text/css" />
    <script src="../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../JS/XHD.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../lib/json.js" type="text/javascript"></script>
    <script type="text/javascript">
        var data = [{id:1,text:'本人'},{id:2,text:'本部'},{id:3,text:'全部'}];
        $(function () {
            //$(".bodytable input:text").ligerComboBox({ data: data });
            $("#maingrid").ligerGrid({
                columns: [
                { display: '序号', name: 'option_id', width: 30, isSort: false, type: 'int' },
                { display: '权限名称', name: 'Sys_option', isSort: false },
                { display: '查看', name: 'Sys_view', isSort: false, width: 80,
                    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                        for (var i = 0; i < data.length; i++) {
                            if (data[i]['id'] == item.Sys_view)
                                return data[i]['text']
                        }
                        return item.add;
                    }
                },
                //{ display: '新增', name: 'Sys_add', isSort: false, width: 80,
                //    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                //        for (var i = 0; i < data.length; i++) {
                //            if (data[i]['id'] == item.Sys_add)
                //                return data[i]['text']
                //        }
                //        return item.add;
                //    }
                //},
                //{ display: '修改', name: 'Sys_edit', isSort: false, width: 80,
                //    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                //        for (var i = 0; i < data.length; i++) {
                //            if (data[i]['id'] == item.Sys_edit)
                //                return data[i]['text']
                //        }
                //        return item.edit;
                //    }
                //},
                { display: '删除', name: 'Sys_del', isSort: false, width: 80,
                    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                        for (var i = 0; i < data.length; i++) {
                            if (data[i]['id'] == item.Sys_del)
                                return data[i]['text']
                        }
                        return item.del;
                    }
                }
                ],
                url:'../data/Sys_data_authority.ashx?Action=get&Role_id='+getparastr("rid"),
                enabledEdit: true,
                usePager: false,
                checkbox: true,
                dataAction: 'local',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                width: '100%',
                height: '100%',
                heightDiff: 0

                

            });
            $("#pageloading").fadeOut(400);
        })
        function f_save() {
            var str1 = getparastr("rid");
            var manager = $("#maingrid").ligerGetGridManager();
            var savedata = manager.getCurrentData();
            var postdata = JSON.stringify(savedata);

            $.ajax({
                type: "POST",
                url: "../data/Sys_data_authority.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: "save", rid: str1, savestring: postdata }, /* 注意参数的格式和名称 */
                success: function (result) {
                    parent.$.ligerDialog.close();
                }
            });
        }
        function deleteRow() {
            var manager = $("#maingrid").ligerGetGridManager();
            manager.deleteSelectedRow();
        }
        function addNewRow() {
            var manager = $("#maingrid").ligerGetGridManager();
            manager.addRow();
        }
        function getSelected() {
            var manager = $("#maingrid").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (!row) { alert('请选择行'); return; }
            alert(JSON.stringify(row));
        }
        function getData() {
            var manager = $("#maingrid").ligerGetGridManager();
            var data = manager.getData();
            alert(JSON.stringify(data));
        } 
    </script>
   
</head>
<body>
       <form id="from1">
        <div>
        
        <div class="l-loading" style="display:block" id="pageloading"></div>    
        <div id="maingrid" style="margin:-1px; "></div>   
    </div></form>
    <%--<br />
    <a class="l-button" style="width:120px;float:left; margin-left:10px;" onclick="deleteRow()">删除选择的行</a>
    <a class="l-button" style="width:100px;float:left; margin-left:10px;" onclick="addNewRow()">添加行</a>
    <a class="l-button" style="width:100px;float:left; margin-left:10px;" onclick="getSelected()">获取选中的值(选择行)</a>
    <a class="l-button" style="width:100px;float:left; margin-left:10px;" onclick="getData()">获取当前的值</a>--%>
</body>
</html>
