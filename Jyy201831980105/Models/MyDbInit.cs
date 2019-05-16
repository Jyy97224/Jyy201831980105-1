using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jyy201831980105.Models
{
    public class MyDbInit
         : System.Data.Entity.CreateDatabaseIfNotExists<MyDb>
    {
        protected override void Seed(MyDb context)
        {
            base.Seed(context);


            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "201831980105",
                Xueshengxingming = "阿蒋",
                Xueshengxingbie = "女"

            });
            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "201831980106",
                Xueshengxingming = "阿姣",
                Xueshengxingbie = "女"
            });


        }


    }
}