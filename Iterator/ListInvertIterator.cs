using System.Collections.Generic;

namespace Iterator
{
    public class ListInvertIterator<T>
    {
        private List<T> list;
        
        public ListInvertIterator(List<T> list)
        {
            this.list = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }
    }
}