<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/Toolbar.css" rel="stylesheet" />
    <link href="../../CSS/core.css" rel="stylesheet" />
    <meta http-equiv="X-UA-Compatible" content="IE=8" />
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerRadio.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerSpinner.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDateEditor.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerCheckBox.js" type="text/javascript"></script>

    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>

    <script src="../../lib/jquery-validation/jquery.validate.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/jquery.metadata.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/messages_cn.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/common.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../JS/Toolbar.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            var str1 = getparastr("rid");
            $("#maingrid4").ligerGrid({
                columns: [
                    { display: '���', width: 30, render: function (item, i) { return i + 1; } },
                    { display: '��˾����', name: 'Customer', width: 160, align: 'left' },
                    
                    {
                        display: '�ͻ�����', name: '', width: 120, render: function (item) {
                            return item.Department + "." + item.Employee;
                        }
                    },

                    {
                        display: '������', name: 'lastfollow', width: 90, render: function (item) {
                            return formatTimebytype(item.lastfollow, 'yyyy-MM-dd');
                        }
                    },
                    { display: '�绰', name: 'tel', width: 150 }

                ],
                onAfterShowData: function (grid) {
                    $("tr[rowtype='�ѳɽ�']").addClass("l-treeleve2").removeClass("l-grid-row-alt");
                    $(".abc").hover(function (e) {
                        $(this).ligerTip({ content: $(this).html(), width: 200, distanceX: event.clientX - $(this).offset().left - $(this).width() + 15 });
                    }, function (e) {
                        $(this).ligerHideTip(e);
                    });
                },
                checkbox: false,
                dataAction: 'server',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                url: "../../data/crm_customer.ashx?Action=grid&rnd=" + Math.random(),
                width: '100%',
                height: '100%',
                //title: "Ա���б�",
                heightDiff: 0
            });
            toolbar();
            $("#pageloading").fadeOut(400);
            $(document).keydown(function (e) {
                if (e.keyCode == 13) {
                    doserch();
                }
            });
        });
        function toolbar() {
            var toolbar1 = new Toolbar({
                renderTo: 'serchbar1',
                items: [
                {
                    type: 'textfield',
                    text: '�ؼ��֣�',
                    id: "company",
                    useable: 'enabled',
                    handler: function () {
                        //EditButton();
                    }
                }, {
                    type: 'button',
                    text: '��ѯ',
                    bodyStyle: 'search ',
                    useable: 'T',
                    handler: function () {
                        //alert($("#Serchtext").val())
                        doserch();
                    }
                }

                ],
                //�����ĸ�
            });
            toolbar1.render();

            $("#company").ligerTextBox({ width: 200, nullText: "����ؼ������������ͻ�" });
        }
        function doserch() {
            var sendtxt = "&Action=grid&rnd=" + Math.random();
            var serchtxt = $("#form1 :input").fieldSerialize() + sendtxt;
            //alert(serchtxt);
            $.ligerDialog.waitting('���ݲ�ѯ��,���Ժ�...');
            var manager = $("#maingrid4").ligerGetGridManager();

            manager.setURL("../../data/crm_customer.ashx?" + serchtxt);
            manager.loadData(true);
            $.ligerDialog.closeWaitting();
        }
        function f_select() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var rows = manager.getSelectedRow();
            //alert(rows);
            return rows;
        }


    </script>

</head>
<body>

    <form id="form1">
        <div>
            <div id="serchbar1"></div>
            <div class="l-loading" style="display: block" id="pageloading"></div>
            <div id="maingrid4" style="margin: -1px;"></div>
        </div>
    </form>


</body>
</html>
