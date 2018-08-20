using System;
using System.Collections.Generic;

namespace Database
{
    public class Database
    {
        private int[] values;
        private int currentIndex;
        private const int defaultCapacity = 16;


        private Database()
        {
            this.values = new int[16];
            this.currentIndex = 0;
        }

        public Database(params int[] param) 
            : this()
        {
            this.InitializeValues(param);  
        }

        private void InitializeValues(int[] inputValues)
        {

            try
            {
                Array.Copy(values, inputValues, inputValues.Length);
                this.currentIndex = inputValues.Length;
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException("Array is full!", ex);
            }

        }

        public void Add(int el)
        {
            if (currentIndex >= defaultCapacity)
            {
                throw new InvalidOperationException("Array already has 16 elements!");
            }

            this.values[currentIndex] = el;
            this.currentIndex++;
        }

        public void Remove()
        {
            if (currentIndex == 0)
            {
                throw new InvalidOperationException("Can't remove element from empty array!");
            }

            this.currentIndex--;
            this.values[currentIndex] = default(int);
        }

        public int[] Fetch()
        {
            int[] newArray = new int[currentIndex];
            Array.Copy(this.values, newArray, currentIndex);

            return newArray;
        }
    }
}
