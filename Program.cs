internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    class HTable
    {
        List<KeyValuePair<int, string>> list;

        public HTable()
        {
            list = new List<KeyValuePair<int, string>>(0);
        }

        public void Add(KeyValuePair<int, string> el)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key == el.Key)
                {
                    Console.WriteLine("Key already exists");
                    return;
                }
            }
            list.Add(el);
        }

        public void Remove(int key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key == key)
                {
                    Move(i);
                    return;
                }
            }
            Console.WriteLine("Key do not exist");
        }

        void Move(int index)
        {
            int i;
            for (i = index; i < list.Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list.RemoveAt(i);
        }

        public string Search(int key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key == key) return list[i].Value;
            }
            return null;
        }

        public int GetLength()
        {
            return list.Count;
        }
    }
}