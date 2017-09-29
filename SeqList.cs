using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListTest
{
    /// <summary>
    /// 顺序表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SeqList<T> : IListDS<T>
    {
        private int maxsize;
        private T[] data;
        private int last;

        //类索引器
        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
            set
            {
                if (index<0||index>last+1)
                {
                    Console.WriteLine("Position is error!!!");
                    return;
                }
                data[index] = value;
            }
        }

        //最后一个元素的下标
        public int Last
        {
            get
            {
                return last;
            }
        }
        
        //最大容量
        public int Maxsize
        {
            get
            {
                return this.maxsize;
            }
            set
            {
                this.maxsize = value;
            }
        }
        
        //构造函数
        public SeqList(int size)
        {
            data = new T[size];
            maxsize = size;
            last = -1;
        }

        //清空
        public void Clear()
        {
            last = -1;
        }

        //返回链表的实际长度
        public int Count()
        {
            return last + 1;
        }

        //是否空
        public bool IsEmpty()
        {
            return last == -1;
        }

        //是否满
        public bool IsFull()
        {
            return last == maxsize - 1;
        }
#region 前插
        /// <summary>
        /// 前插
        /// </summary>
        /// <param name="item">要插入的元素</param>
        /// <param name="i">要插入的位置索引</param>
        public void InsertBefore(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full!!!");
                return;
            }

            if (i < 0 || i > last + 1)
            {
                Console.WriteLine("Position is error!!");
                return;
            }

            if (i == last + 1)
            {
                data[i] = item;
            }
            else
            {
                for (int j = last; j >= i; j--)
                {
                    data[j + 1] = data[j];
                }
                data[i] = item;
            }
            ++last;
        }
#endregion

        #region 后插
        /// <summary>
        /// 后插
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i"></param>
        public void InsertAfter(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full!!!");
                return;
            }

            if (i < 0 || i > last)
            {
                Console.WriteLine("Position is error!!");
                return;
            }

            if (i == last)
            {
                data[last + 1] = item;
            }
            else
            {
                for (int j = last; j > i; j--)
                {
                    data[j + 1] = data[j];
                }
                data[i + 1] = item;
            }
            ++last;
        }
#endregion


        //(在最后位置)追加元素
        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full!!!");
                return;
            }
            data[++last] = item;
        }

#region 删除元素
        /// <summary>
        /// 删除元素
        /// </summary>
        /// <param name="i">要删除的元素索引</param>
        /// <returns></returns>
        public T RemoveAt(int i)
        {
            T temp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!!!");
                return temp;
            }

            if (i < 0 || i > last)
            {
                Console.WriteLine("Position is error!!!");
                return temp;
            }

            if (i == last)
            {
                temp = data[last];
            }
            else
            {
                temp = data[i];
                //位置i以及i以后的元素前移
                for (int j = i; j < last; j++)
                {
                    data[j] = data[j + 1];
                }
            }
            --last;
            return temp;
        }
        #endregion

#region 获取某个位置的元素
        /// <summary>
        /// 获取某个位置的元素
        /// </summary>
        /// <param name="i">元素的位置</param>
        /// <returns></returns>
        public T GetItemAt(int i)
        {
            if (IsEmpty() || (i < 0) || (i > last))
            {
                Console.WriteLine("List is empty or Position is error!!!");
            }
            return data[i];
        }

        /// <summary>
        /// 定位元素的下标索引
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int IndexOf(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!!!");
                return -1;
            }

            int i = 0;
            for (i = 0; i <= last; i++)
            {
                if(value.Equals(data[i]))
                {
                    break;
                }
            }

            if(i>last)
            {
                return -1;
            }
            return i;
        }
#endregion

        /// <summary>
        /// 元素反转
        /// </summary>
        public void Resverse()
        {
            T temp = default(T);
            for (int i = 0; i <=last/2; i++)
            {
                temp = data[i];
                data[i] = data[last - i];
                data[last - i] = temp;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <=last; i++)
            {
                sb.Append(data[i].ToString() + ',');
            }
            return sb.ToString().TrimEnd(',');
        }
    }
}
