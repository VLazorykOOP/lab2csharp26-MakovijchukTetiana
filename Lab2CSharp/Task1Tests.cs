using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace Lab2_Tests
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void CountOutsideInterval_MixedElements_ReturnsCorrectCount()
        {
            // У масиві є як числа з інтервалу, так і поза ним
            int[] arr = { 1, 5, 10, 15, 20 };
            int min = 5;
            int max = 15;
            
            int result = Task1.CountOutsideInterval(arr, min, max);
            
            // Очікуємо 2 (це числа 1 та 20)
            Assert.AreEqual(2, result); 
        }

        [TestMethod]
        public void CountOutsideInterval_AllInside_ReturnsZero()
        {
            // Усі числа потрапляють в інтервал
            int[] arr = { 5, 8, 10, 15 };
            int min = 5;
            int max = 15;
            
            int result = Task1.CountOutsideInterval(arr, min, max);
            
            // Очікуємо 0
            Assert.AreEqual(0, result); 
        }

        [TestMethod]
        public void CountOutsideInterval_AllOutside_ReturnsArrayLength()
        {
            // Жодне число не потрапляє в інтервал
            int[] arr = { 1, 2, 20, 25 };
            int min = 5;
            int max = 15;
            
            int result = Task1.CountOutsideInterval(arr, min, max);
            
            // Очікуємо 4 (всі елементи)
            Assert.AreEqual(4, result); 
        }

        [TestMethod]
        public void CountOutsideInterval_EmptyArray_ReturnsZero()
        {
            // Перевірка на порожній масив
            int[] arr = new int[0];
            int min = 5;
            int max = 15;
            
            int result = Task1.CountOutsideInterval(arr, min, max);
            
            Assert.AreEqual(0, result); 
        }
    }
}