using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANUDING_SITE.Models
{
    public class Blog
    {
        public string Message { get; set; }
        private BlogContext blogcontext { get; set; }

        public string idtab_articles { get; set; }
        public string title { get; set; }
        public string navimg { get; set; }
        public string content { get; set; }
        public string tags { get; set; }
        public string dateCreated { get; set; }


        
        public static string mk2str()
        {
            //string markdown_string = "#标题\r\n 1. 文字1 \r\n 2. 文字2";
            //MarkdownSharp.Markdown markdown = new MarkdownSharp.Markdown();
            //string result = markdown.Transform(markdown_string);
            return "";
        }
        public void OnGet()
        {
            Message = "";
            Message = mk2str();
           
            //foreach (Blog element in this) //T的类型与mList声明时一样
            //{
            //    Message += element.content;
            //}
        }

    }
}
