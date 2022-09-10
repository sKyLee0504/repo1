using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment

{
    internal class Video
    {
        public string title;
        public string auther;
        // video只有4种类型 教育、娱乐、音乐、其他
        // 用了private 只可以在类里面使用
        private string type;

        public Video(string title, string auther, string type)
        {
            this.title = title;
            this.auther = auther;
            // 这里的type是形参
            Type = type;
        }
        public string Type
        {
            get { 
                // 这里的type是定义的属性名
                return type; 
            }
            set { 
                if (value == "教育" || value == "娱乐" || value == "音乐" || value == "其他")
                {
                    type = value;
                } else
                {
                    type = "其他";
                }
                
            }
        }
    }
}
