
using InterfacesCS;

namespace ArrayClass
{
    public class MyArray: ICalc
    {
        private static Random random = new Random();
        private readonly int _size;
        private int[] arr;
        public MyArray(int size)
        {
            _size = size;
            arr = new int[size];
            for (int i =0;i < _size; i++)
                arr[i] = random.Next(0,20);
        }

        public void Print()
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        public int Less(int value)
        {
            int count = 0;

            for(int i =0;i < arr.Length; i++)
            {
                if (arr[i] < value)
                    count++;
            }

            return count;
        }

        public int Greater(int value)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > value)
                    count++;
            }

            return count;
        }

        public void ShowOdd()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        public void ShowEven()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int count = 0;
            bool flag = false;
            for(int i = 0; i < arr.Length; i++)
            {
                int cur = arr[i];
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == cur && j !=i)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    count++;
                flag=false;
            }

            return count;
        }

        public int EqualToValue(int value)
        {
            int count=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    count++;
            }
            return count;
        }

    }
}
