﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListTest
{
    public interface IListDS<T>
    {
        int Count();

        void Clear();

        bool IsEmpty();

        void Append(T item);

        void InsertBefore(T item, int i);

        void InsertAfter(T item, int i);

        T RemoveAt(int i);

        T GetItemAt(int i);

        int IndexOf(T value);

        void Resverse();
    }
}