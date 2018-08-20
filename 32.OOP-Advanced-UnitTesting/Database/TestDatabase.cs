namespace DatabaseTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Database;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class TestDatabase
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 3, 2, 1 })]
        [TestCase(new int[] { -10 })]
        [TestCase(new int[] {  })]
        public void TestConstructor_Valid(int[] values)
        {
            Database database = new Database(values);

            FieldInfo fieldInfo = GetFieldInfo(database, typeof(int[]));

            int[] fieldValues = ((int[])fieldInfo.GetValue(database));
            int[] buffer = new int[fieldValues.Length - values.Length];

            Assert.That(fieldValues, Is.EquivalentTo(values.Concat(buffer)));
        }

        [Test]
        public void TestConstructor_InValid()
        {
            int[] values = new int[17];

            Assert.That(() => new Database(values), Throws.InvalidOperationException);
        }


        [Test]
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        [TestCase(-20)]
        [TestCase(0)]

        public void TestAddMethod_Valid(int value)
        {
            Database database = new Database();
            database.Add(value);

            FieldInfo valuesInfo = GetFieldInfo(database, typeof(int[]));
            
            FieldInfo currIndexInfo = GetFieldInfo(database, typeof(int));
            
            int firstValue = ((int[])valuesInfo.GetValue(database)).First();
            Assert.That(firstValue, Is.EqualTo(value));

            int valueCount = ((int)currIndexInfo.GetValue(database));
            Assert.That(valueCount, Is.EqualTo(1));
        }

        [Test]
        public void TestAddMethod_InValid()
        {
            Database database = new Database();

            FieldInfo currIndexInfo = GetFieldInfo(database, typeof(int));

            currIndexInfo.SetValue(database, 16);

            Assert.That(() => database.Add(1), Throws.InvalidOperationException);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 3, 2, 1 })]
        [TestCase(new int[] { -10 })]
        public void TestRemoveMethod_Valid(int[] values)
        {
            Database database = new Database();

            FieldInfo fieldInfo = GetFieldInfo(database, typeof(int[]));


            fieldInfo.SetValue(database, values);

            FieldInfo currIndexInfo = GetFieldInfo(database, typeof(int));

            currIndexInfo.SetValue(database, values.Length);

            database.Remove();

            int[] actualValues = ((int[])fieldInfo.GetValue(database));
            int[] buffer = new int[actualValues.Length - (values.Length - 1)];

            values = values.Take(values.Length - 1).Concat(buffer).ToArray();


            Assert.That(actualValues, Is.EquivalentTo(values));
        }

        [Test]
        public void TestRemoveMethod_InValid()
        {
            Database database = new Database();

            FieldInfo currIndexInfo = GetFieldInfo(database, typeof(int));

            currIndexInfo.SetValue(database, 0);

            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }


        private FieldInfo GetFieldInfo(object instance, Type fieldType)
        {
            FieldInfo fieldInfo = instance.GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(f => f.FieldType == fieldType);

            return fieldInfo;
        }
    }
}
