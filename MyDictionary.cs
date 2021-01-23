using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey keyItem, TValue valueItem)
        {
            TKey[] tempKey = _keys;
            TValue[] tempValue = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _keys[i] = tempKey[i];
                _values[i] = tempValue[i];
            }
            _keys[_keys.Length - 1] = keyItem;
            _values[_values.Length - 1] = valueItem;
        }
        public TKey[] Keys { get { return _keys; } }
        public TValue[] Values { get { return _values; } }
        public int Lenght { get => _keys.Length; }
    }
}
