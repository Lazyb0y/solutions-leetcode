using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class OrderedStream
    {
        private readonly string[] _items;
        private int _alreadySent;

        public OrderedStream(int n)
        {
            _items = new string[n];
        }

        public IList<string> Insert(int idKey, string value)
        {
            _items[idKey - 1] = value;

            int toTake = 0;
            foreach (var item in _items)
            {
                if (item == null)
                {
                    break;
                }

                toTake++;
            }

            List<string> result = new List<string>();
            for (int i = _alreadySent; i < toTake; i++)
            {
                result.Add(_items[i]);
            }

            _alreadySent = toTake;
            return result;
        }
    }

    /**
     * Your OrderedStream object will be instantiated and called as such:
     * OrderedStream obj = new OrderedStream(n);
     * IList<string> param_1 = obj.Insert(idKey,value);
     */
}