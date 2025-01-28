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
        /// タイトル名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 著者名
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// 出版社名
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// ジャンル
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// 感想やメモ
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 画像
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 読み始めた日
        /// </summary>
        public DateTime BeginingDay { get; set; }
        /// <summary>
        /// 読み終えた日
        /// </summary>
        public DateTime EndDay { get; set; }
    }
}
