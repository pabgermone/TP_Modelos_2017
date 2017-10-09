using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

namespace WebApplication1.Helper
{
    public class Javascript
    {
        public static void jQueryNotify(Page page, string m, string n)
        {
            StringBuilder script = new StringBuilder();
            script.Append(@"<script type='text/javascript'>
                var n = '" + n + @"';
                var m = '" + m + @"';
                var r = 'Error!';
                var t = 'danger';
                var i = 'fa fa-times-circle-o';

                switch (n) {
                    case '1':
                        r = 'Excelente!';
                        t = 'success';
                        i = 'fa fa-check-circle-o';
                        break;

                    case '2':
                        r = 'Atención!';
                        t = 'info';
                        i = 'fa fa-exclamation-triangle';
                        break;

                    case '3':
                        r = 'Atención!';
                        t = 'warning';
                        i = 'fa fa-exclamation-triangle';
                        break;

                    case '4':
                        t = 'danger'
                        break;
                }

                var n = $.notify({
                    title: r,
                    icon: i,
                    message: m,
                    target: '_blank'
                }, {
                    // Configuración
                    type: t,
                    delay: 5000,
                    animate: {
                        enter: 'animated bounceInDown',
                        exit: 'animated fadeOutUp'
                    },
                    placement: {
                        from: 'top',
                        align: 'right'
                        
                    },
                });
            </script>");

            ScriptManager.RegisterStartupScript(page, page.GetType(), "Notify", script.ToString(), false);
        }

        public static void jQueryToggle(Page page)
        {
            StringBuilder script = new StringBuilder();
            script.Append(@"
                $('.checkboxtoggle>input').bootstrapToggle({
                    on: 'Urgente',
                    onstyle: 'danger',
                    off: 'Normal',
                    offstyle: 'info'
                });
            ");

            ScriptManager.RegisterStartupScript(page, page.GetType(), "Toggle", script.ToString(), true);
        }
    }
}