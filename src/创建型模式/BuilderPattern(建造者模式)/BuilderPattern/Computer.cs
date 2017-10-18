using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:计算机实体类]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-16]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-16]
    /// <说明>
    ///     [内容:]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 电脑组件集合
        /// </summary>
        private readonly IList<string> _parts = new List<string>();

        /// <summary>
        /// 把单个组件添加到电脑组件集合中
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始组装 ... ...");
            foreach (string part in _parts)
            {
                Console.WriteLine("组件" + part + "已装好");
            }
            Console.WriteLine("电脑组装好了 ... ...");
        }
    }
}
