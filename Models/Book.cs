using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeBooks.Models
{
    public class Book
    {
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 著者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// 出版社
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// ジャンル
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 画像
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 読んだ日
        /// </summary>
        public DateTime ReadDay { get; set; }
    }
}
