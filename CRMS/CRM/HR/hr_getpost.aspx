<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link href="../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/input.css" rel="stylesheet" type="text/css" />
    <script src="../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerDrag.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../JS/XHD.js" type="text/javascript"></script>
    <script src="../JS/Toolbar.js" type="text/javascript"></script>
    <link href="../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/core.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">

        var manager = "";
        var treemanager;
        $(function () {
            $("#layout1").ligerLayout({ leftWidth: 160, allowLeftResize: false, allowLeftCollapse: true, space: 2 });
            $("#tree1").ligerTree({
                url: '../data/hr_department.ashx?Action=tree&rnd=' + Math.random(),
                onSelect: onSelect,
                idFieldName: 'id',
                parentIDFieldName: 'pid',
                usericon: 'd_icon',
                checkbox: false,
                itemopen: false
            });

            treemanager = $("#tree1").ligerGetTreeManager();

            initLayout();
            $(window).resize(function () {
                initLayout();
            });



            $("#maingrid4").ligerGrid({
                columns: [
                    { display: '��λ����', name: 'post_name', width: 90 },
                    { display: '��������', name: 'depname', width: 90 },
                    { display: 'ְ������', name: 'position_name', width: 90 },
                    { display: '����', name: 'emp_name', width: 90 }

                ],
                dataAction: 'local',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                onSelectRow: function (row, index, data) {
                    //alert('onSelectRow:' + index + " | " + data.ProductName); 
                },
                url: "../data/hr_post.ashx?Action=grid&depid=0",
                width: '100%',
                height: '100%',
                heightDiff: -1
            });
            toolbar();

            $("#empstatus").ligerComboBox({
                width: 80,
                selectBoxHeight:90,
                data: [{ id: '0', text: 'ȫ��' }, { id: '1', text: 'δʹ��' }, { id: '2', text: '��ʹ��' }],
                initValue: 1,
                onSelected: function (value, text) {
                    var treemanager = $("#tree1").ligerGetTreeManager();
                    var note = treemanager.getSelected();
                    if (note) {
                        var manager = $("#maingrid4").ligerGetGridManager();
                        manager.showData({ Rows: [], Total: 0 });
                        var url = "../data/hr_post.ashx?Action=grid&depid=" + note.data.id + "&empstatus=" + value + "&rnd=" + Math.random();
                        manager.GetDataByURL(url);
                    }                    
                }
            });
            $("#Serchtext").ligerTextBox({ width: 120 });
            $("#pageloading").fadeOut(400);
        });
        function toolbar() {
            var toolbar1 = new Toolbar({
                renderTo: 'toolbar',
                items: [
                {
                    type: 'textfield',
                    text: '',
                    id:"empstatus",
                    useable: 'enabled',
                    handler: function () {
                    }                
                },
                '-', {
                    type: 'textfield',
                    text: '��λ����',
                    id: "Serchtext",
                    useable: 'enabled',
                    handler: function () {                       
                    }
                },
                {
                    type: 'button',
                    text: '��ѯ',
                    bodyStyle: 'search ',
                    useable: 'T',
                    handler: function () {                        
                        f_search();
                    }
                }

                ]
                //�����ĸ�
            });
            toolbar1.render();
        }


        function onSelect(note) {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.showData({ Rows: [], Total: 0 });
            var url = "../data/hr_post.ashx?Action=grid&depid=" + note.data.id + "&empstatus=" + $("#empstatus_val").val() + "&rnd=" + Math.random();
            manager.GetDataByURL(url);
        }

        function f_select() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var rows = manager.getSelectedRow();
            return rows;
        }
        function f_search() {
            var sendtxt = "&Action=serch&rnd=" + Math.random();
            var serchtxt = $("#form1 :input").fieldSerialize() + sendtxt;
            //alert(serchtxt);
            $.ligerDialog.waitting('���ݲ�ѯ��,���Ժ�...',9003);
            var manager = $("#maingrid4").ligerGetGridManager();
            $.ajax({
                url: "../data/hr_post.ashx", type: "POST",
                data: serchtxt,
                dataType: 'json',
                beforeSend: function () {
                    manager.showData({ Rows: [], Total: 0 });
                },
                success: function (responseText) {
                    //alert("../data/crm_customer.ashx" + serchtxt);
                    manager.setURL("../data/hr_post.ashx?" + serchtxt);
                    manager.showData(responseText);
                    $.ligerDialog.closeWaitting();
                },
                error: function () {
                    $.ligerDialog.closeWaitting();
                    $.ligerDialog.error('��ѯʧ�ܣ������ѯ�',9003);
                }
            });
        }
    </script>
</head>
<body style="padding: 0px">
    <form id="form1">
        <div id="pageloading"></div>
        <div id="layout1" style="margin: -1px">
            <div position="left" title="��֯�ܹ�">
                <div id="treediv" style="width: 200px; height: 100%; margin: -1px; float: left; border: 1px solid #ccc; overflow: auto;">
                    <ul id="tree1"></ul>
                </div>
            </div>
            <div position="center">
                <div style="position: absolute;z-index:1000;width:100%">
                <div id="toolbar"></div></div>
                <div style="position:fixed;width:100%;margin-top:26px">
                <div id="maingrid4" style="margin: -1px;"></div></div>

            </div>
        </div>


        <!--<a class="l-button" onclick="getChecked()" style="float:left;margin-right:10px;">��ȡѡ��(��ѡ��)</a> -->
        <div style="display: none">
            <!--  ����ͳ�ƴ��� -->
        </div>
    </form>
</body>
</html>
