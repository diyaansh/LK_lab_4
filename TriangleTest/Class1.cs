using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Methodology_Lab3_LK;

namespace TriangleTest
{
    public class TestClass
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 60;
                int second_angle = 60;
                int third_angle = 60;
                string expected = "the triangle is valid.";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void InputTriangle_StudentNumber_InvalidTriangle()
            {
                //Arrange
                int first_angle = 20; 
                int second_angle = 8761551;
                int third_angle = 50;
                string expected = "the triangle is valid.";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void ValidTriangle_Input50and20and30_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 50;
                int second_angle = 20;
                int third_angle = 30;
                string expected = "the triangle is valid.";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);

            }

        }

    }

}
