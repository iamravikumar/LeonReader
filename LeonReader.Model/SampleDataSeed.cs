﻿using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonReader.Model
{
    /// <summary>
    /// 数据种子
    /// </summary>
    public class SampleDataSeed : SqliteDropCreateDatabaseAlways<UnityDBContext>
    {
        /// <summary>
        /// 构造数据种子
        /// </summary>
        /// <param name="modelBuilder"></param>
        public SampleDataSeed(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        //覆写此方法，用于初始化数据种子
        protected override void Seed(UnityDBContext context)
        {
            context.Articles.Add(new Article() {
                ArticleID = "10000",
                Title = "种子文章",
                ArticleLink = "http://www.cuteleon.com",
                Description = "种子文章",
                ImageFileName = "*",
                ImageLink = "*",
                IsNew = true,
                PublishTime = DateTime.Now.ToString(),
                Contents = new ContentItem[] {
                    new ContentItem(){ ImageDescription = "种子文章" },
                    new ContentItem(){ ImageDescription = "欢迎使用 Leon Reader."},
                    new ContentItem(){ ImageDescription = "Best Wishes !"}
                }.ToList(),
            });

            context.SaveChanges();
            base.Seed(context);
        }

    }
}