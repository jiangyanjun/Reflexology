<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>Insert title here</title>

    <link rel="stylesheet" type="text/css" href="../css/imgareaselect-default.css" />
    <script type="text/javascript" src="../js/jquery.min.js"></script>
    <script type="text/javascript" src="../js/jquery.imgareaselect.pack.js"></script>
    <script src="../lib/jquery.form.js" type="text/javascript" ></script>
    <script type="text/javascript">
        function preview(img, selection) {
            if (!selection.width || !selection.height)
                return;

            var scaleX = 120 / selection.width;
            var scaleY = 120 / selection.height;

            $('#preview1 img').css({
                width: Math.round(scaleX * $("#photo").width()),
                height: Math.round(scaleY * $("#photo").height()),
                marginLeft: -Math.round(scaleX * selection.x1),
                marginTop: -Math.round(scaleY * selection.y1)
            });

            $('#x1').val(selection.x1);
            $('#y1').val(selection.y1);
            $('#x2').val(selection.x2);
            $('#y2').val(selection.y2);
            $('#w').val(selection.width);
            $('#h').val(selection.height);
        }

        $(function () {
            var api = $('#photo').imgAreaSelect({
                instance: true,
                aspectRatio: '1:1',
                handles: true,
                fadeSpeed: 0,
                onSelectChange: preview,
                show: true,
                x1: 0, y1: 0, x2: 120, y2: 120
            });
            api.cancelSelection();
        });
        function uploadimg() {
            var filename = $("#upload").val();
            var location = "file:///" + $("#upload").val();
            var type = location.substr(location.lastIndexOf(".")).toLowerCase();
            if (type == ".jpg" || type == ".gif" || type == ".jpeg" || type == ".bmp" || type == ".png") {
                $("#form1").ajaxSubmit({
                    type: "post",
                    url: "../data/upload.ashx", /* ע���������ֶ�ӦCS�ķ������� */
                    data: { Action: 'upload', filename: filename, rnd: Math.random() }, /* ע������ĸ�ʽ������ */
                    contentType: "application/json; charset=utf-8",
                    dataType: "text",
                    success: function (result) {
                        $("#photo").attr("src", result);
                        $('#preview1 img').attr("src", result);
                    }
                });
            }
        }

        function f_save() {
            if ($("#upload").val() == "" || $("#upload").val() == null) {
                alert("�����ϴ�ͼƬ");
                return;
            }
            else if ($("#x1").val() == "-" || $("#y1").val() == "-" || $("#x2").val() == "-" || $("#y2").val() == "-" || $("#w").val() == "-" || $("#h").val() == "-") {
                alert("����ѡ��ͷ��");
                return;
            }
            else {
                var sendtxt = "&Action=upheadimg";
                return $("form :input[name!='__VIEWSTATE']").fieldSerialize() + sendtxt;
            }
        }
    </script>
    <style type="text/css">
        fieldset { padding: 8px; }
        legend { font-size: 12px; margin-left: 15px; }
        body { font-size: 12px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container demo">
            <fieldset>
                <legend>ԭͼ</legend>
                <div style="float: left; width: 500px;">


                    <div class="frame" style="margin: 0 0.3em; width: 485px; height: 325px; overflow: auto; z-index: 100">
                        <img id="photo" src="../images/noheadimage.jpg" height="300" />
                    </div>
                    <p class="instructions">
                        ���ϴ�ͼƬ��<input type="file" id="upload" name="upload" onchange="uploadimg()" style="width: 250px; height: 21px;" runat="server"  /></p>

                </div>

                <div style="float: left; width: 200px;">

                    <div class="frame"
                        style="margin: 0 1em; width: 120px; height: 120px;">
                        <div id="preview1" style="width: 120px; height: 120px; overflow: hidden;">
                            <img src="../images/noheadimage.jpg" style="width: 120px; height: 120px;" />
                        </div>
                    </div>


                    <input type="hidden" id="x1" name="x1" value="-" />
                    <input type="hidden" id="y1" name="y1" value="-" />
                    <input type="hidden" id="x2" name="x2" value="-" />
                    <input type="hidden" id="y2" name="y2" value="-" />
                    <input type="hidden" id="w" name="w" value="-" />
                    <input type="hidden" id="h" name="h" value="-" />

                </div>
            </fieldset>
        </div>
    </form>
</body>
</html>
