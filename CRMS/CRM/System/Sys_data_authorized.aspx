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
        var data = [{id:1,text:'����'},{id:2,text:'����'},{id:3,text:'ȫ��'}];
        $(function () {
            //$(".bodytable input:text").ligerComboBox({ data: data });
            $("#maingrid").ligerGrid({
                columns: [
                { display: '���', name: 'option_id', width: 30, isSort: false, type: 'int' },
                { display: 'Ȩ������', name: 'Sys_option', isSort: false },
                { display: '�鿴', name: 'Sys_view', isSort: false, width: 80,
                    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                        for (var i = 0; i < data.length; i++) {
                            if (data[i]['id'] == item.Sys_view)
                                return data[i]['text']
                        }
                        return item.add;
                    }
                },
                //{ display: '����', name: 'Sys_add', isSort: false, width: 80,
                //    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                //        for (var i = 0; i < data.length; i++) {
                //            if (data[i]['id'] == item.Sys_add)
                //                return data[i]['text']
                //        }
                //        return item.add;
                //    }
                //},
                //{ display: '�޸�', name: 'Sys_edit', isSort: false, width: 80,
                //    editor: { type: 'select', data: data, valueColumnName: 'id', displayColumnName: 'text' }, render: function (item) {
                //        for (var i = 0; i < data.length; i++) {
                //            if (data[i]['id'] == item.Sys_edit)
                //                return data[i]['text']
                //        }
                //        return item.edit;
                //    }
                //},
                { display: 'ɾ��', name: 'Sys_del', isSort: false, width: 80,
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
                url: "../data/Sys_data_authority.ashx", /* ע���������ֶ�ӦCS�ķ������� */
                data: { Action: "save", rid: str1, savestring: postdata }, /* ע������ĸ�ʽ������ */
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
            if (!row) { alert('��ѡ����'); return; }
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
    <a class="l-button" style="width:120px;float:left; margin-left:10px;" onclick="deleteRow()">ɾ��ѡ�����</a>
    <a class="l-button" style="width:100px;float:left; margin-left:10px;" onclick="addNewRow()">�����</a>
    <a class="l-button" style="width:100px;float:left; margin-left:10px;" onclick="getSelected()">��ȡѡ�е�ֵ(ѡ����)</a>
    <a class="l-button" style="width:100px;float:left; margin-left:10px;" onclick="getData()">��ȡ��ǰ��ֵ</a>--%>
</body>
</html>
