/// <reference path="E:\asp.net mvc资料\项目\StudyDemo\Demo.Web\Scripts/jquery-1.11.3.min.js" />
/// <reference path="E:\asp.net mvc资料\项目\StudyDemo\Demo.Web\Scripts/jquery.easyui-1.4.3.min.js" />
/*
easyui通用模块
*/
define(function (require,exports,module) {
    var $ = require("jquery");
    var easyui = require("easyui");
    var com = {};
    com.dialog = function(options) {
        var parent = parent.$,fClose=options.onClose;
        options = parent.extend({
            title: '对话框',
            width: 400,
            height: 220,
            closed: false,
            cache: false,
            modal: true,
            html: '',
            url: '',
        }, options);
        //dialog删除方法
        options.onClose = function() {
            if (parent.isFunction(fClose)) {
                fClose();
            } else {
                parent(this).dialog("destory");
            }
        }


    }

    exports = com;

});