/// <reference path="../layui/layui.all.js" />

//需要依赖layui.js 

(function () {
    var layer_msg_option = { time: 1200 };
    window.msg = function (msg, options, cb) {
        options = $.extend({}, layer_msg_option, options);
        layer.msg(msg, options, cb);
    };
    window.warn = function (msg, options, cb) {
        options = $.extend({ icon: 7 }, options);
        window.msg(msg, options, cb);
    }
    window.succeed = function (msg, options, cb) {
        options = $.extend({ icon: 1 }, options);
        window.msg(msg, options, cb);
    }
    window.error = function (msg, options, cb) {
        options = $.extend({ icon: 2 }, options);
        window.msg(msg, options, cb);
    }



    /*
        * layuiAlert     弹出层
        * tipInfo        提示信息，不可为空,
    */
    window.layuiAlert = function (tipInfo) {
        if (!validationParameter(tipInfo))
            return false;

        layer.alert(tipInfo, {
            skin: 'layui-layer-demo' //layui-layer-molv 墨绿色   layui-layer-lan 深蓝色
            , closeBtn: 0
            , anim: 4 //动画类型
        });
    }


    /* 
         * layuiConfirm   询问框
         * tipInfo        提示内容,可以传空，为空时提示：您确定要执行该操作吗?
         * callback       回调函数 
     */
    window.layuiConfirm = function (tipInfo, callback) {
        if (!validationParameter(tipInfo)) {
            tipInfo = "您确定要执行该操作吗？";
        }
        layer.confirm('' + tipInfo + '', {
            btn: ['确定', '取消'],
            title: '提示',
            //icon: 1,//图标
            anim: 6,
            btnAlign: 'c',
            shadeClose: true,
            skin: 'layui-layer-demo',
            shade: 0.2
        }, function () {
            layer.close();
            if (typeof callback == 'function') {
                callback();
            }
        }, function () {
            layer.close();
        });
    }

    /*
        * Loading  加载框
        * true     开启加载
        * false    关闭加载
    */
    window.myShowLoading = function (isTrue) {
        if (isTrue) {
            loading = layer.load(1, {
                shade: [0.4, '#393D49']
            });
        } else {
            layer.close(loading);
        }
    }

    /*
        * 参数检查 返回值 true / false
    */
    window.validationParameter = function (paramet) {
        if (paramet == "" || paramet == null || paramet == undefined || paramet == "undefined")
            return false;
        else
            return true;
    }

})();
